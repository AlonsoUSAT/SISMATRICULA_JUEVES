Imports System.Data
Imports capaDatos
Imports capaDatos.capaDatos

Namespace capaLogica

    Public Class clsLogBecas

        ' Instancia de tu capa de datos (asegúrate de tener el namespace correcto)
        Private ReadOnly _dat As New clsDatBecas()

        ' ==================================================================
        ' CONSTANTES DE NEGOCIO
        ' ==================================================================
        Public Const ESTADO_ACTIVA As String = "ACTIVA"
        Public Const ESTADO_SUSPENDIDA As String = "SUSPENDIDA"
        Public Const ESTADO_REVOCADA As String = "REVOCADA"

        ' Monto base referencial de la pensión. Ajústalo al valor real de tu colegio.
        Private Const MONTO_PENSION_BASE As Decimal = 350D

        ' ==================================================================
        ' 1. CATÁLOGOS
        ' ==================================================================
        Public Function ObtenerTiposBeca() As DataTable
            Return _dat.ListarTiposBeca()
        End Function

        Public Function ObtenerAnoAcademicoActual() As DataTable
            Return _dat.ObtenerAnoAcademicoActual()
        End Function

        ' ==================================================================
        ' 2. BÚSQUEDA DE ESTUDIANTE
        ' ==================================================================
        Public Function BuscarEstudianteParaBeca(numDocumento As String) As DataTable
            Dim dni As String = numDocumento.Trim()

            ' Validación de regla de negocio: El DNI debe ser numérico y de 8 dígitos
            If dni.Length <> 8 OrElse Not Long.TryParse(dni, Nothing) Then
                Throw New ArgumentException("El DNI debe tener exactamente 8 dígitos numéricos.")
            End If

            Return _dat.BuscarEstudianteParaBeca(dni)
        End Function

        ' ==================================================================
        ' 3. CÁLCULO DE DESCUENTO
        ' ==================================================================
        Public Function CalcularMontoDescuento(porcentaje As Decimal) As Decimal
            ' Calcula cuánto se le descontará al estudiante basándose en la pensión base
            Return Math.Round(MONTO_PENSION_BASE * porcentaje / 100D, 2)
        End Function

        ' ==================================================================
        ' 4. VALIDACIÓN DE REGLAS DE ASIGNACIÓN
        ' ==================================================================
        Public Function ValidarDatosAsignacion(idEstudiante As Integer, idTipoBeca As Integer,
                                               idAnoAcademico As Integer, motivo As String) As String
            If idEstudiante <= 0 Then Return "Primero debe buscar y seleccionar un estudiante válido."
            If idTipoBeca <= 0 Then Return "Debe seleccionar un Tipo de Beca de la lista."
            If idAnoAcademico <= 0 Then Return "No se pudo determinar el año académico activo."
            If String.IsNullOrWhiteSpace(motivo) OrElse motivo.Trim().Length < 10 Then
                Return "El motivo de asignación es obligatorio y debe tener al menos 10 caracteres."
            End If

            Return String.Empty ' Retorna vacío si no hay errores
        End Function

        ' ==================================================================
        ' 5. ASIGNAR BECA
        ' ==================================================================
        Public Function AsignarBeca(idEstudiante As Integer, idTipoBeca As Integer, idAnoAcademico As Integer,
                                    motivo As String, porcentajeAplicado As Decimal, montoDescuentoMes As Decimal,
                                    usuarioRegistro As String) As Boolean

            ' 1. Validar reglas de negocio
            Dim errorValidacion As String = ValidarDatosAsignacion(idEstudiante, idTipoBeca, idAnoAcademico, motivo)
            If Not String.IsNullOrEmpty(errorValidacion) Then
                Throw New ArgumentException(errorValidacion)
            End If

            ' 2. Llamar a la capa de datos (Omitimos documento_sustento porque NO existe en la BD actual)
            Return _dat.AsignarBeca(idEstudiante, idTipoBeca, idAnoAcademico, motivo.Trim(),
                                    porcentajeAplicado, montoDescuentoMes, usuarioRegistro)
        End Function

        ' ==================================================================
        ' 6. CAMBIAR ESTADO DE BECA (Suspender/Revocar)
        ' ==================================================================
        Public Sub CambiarEstadoBeca(idAsignacionBeca As Integer, nuevoEstado As String, usuarioModificacion As String)
            If idAsignacionBeca <= 0 Then
                Throw New ArgumentException("Seleccione una asignación de beca válida.")
            End If

            Dim estadosValidos As String() = {ESTADO_ACTIVA, ESTADO_SUSPENDIDA, ESTADO_REVOCADA}
            If Array.IndexOf(estadosValidos, nuevoEstado.ToUpper()) < 0 Then
                Throw New ArgumentException("Estado de beca no válido: " & nuevoEstado)
            End If

            ' Llamamos a la BD (Omitimos motivo_cambio porque NO existe en la BD actual)
            _dat.CambiarEstadoBeca(idAsignacionBeca, nuevoEstado.ToUpper(), usuarioModificacion)
        End Sub

        ' ==================================================================
        ' 7. LISTADOS
        ' ==================================================================
        Public Function ListarBecadosAnoActual() As DataTable
            Return _dat.ListarBecadosAnoActual()
        End Function

        Public Function HistorialBecasEstudiante(idEstudiante As Integer) As DataTable
            If idEstudiante <= 0 Then Return New DataTable()
            Return _dat.HistorialBecasEstudiante(idEstudiante)
        End Function


    End Class

End Namespace
Imports System.Data
Imports capaDatos

Public Class clsLogProcesarMatricula

    Dim objDatos As New clsDatProcesarMatricula()


    Public Function BuscarPago(tipoBusqueda As String, valor As String) As DataTable
        If String.IsNullOrWhiteSpace(valor) Then
            Throw New Exception("Ingrese un valor para buscar.")
        End If

        valor = valor.Trim()

        Select Case tipoBusqueda
            Case "DNI"
                If valor.Length <> 8 Then
                    Throw New Exception("El DNI debe tener exactamente 8 dígitos.")
                End If
                Return objDatos.BuscarPagoPorDNI(valor)

            Case "Cod. Operativo"
                Return objDatos.BuscarPagoPorCodOperativo(valor)

            Case Else
                Throw New Exception("Tipo de búsqueda no válido.")
        End Select
    End Function


    Public Function ObtenerBecaActiva(idEstudiante As Integer) As DataTable
        Try
            Return objDatos.ObtenerBecaActiva(idEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function ObtenerNivelGradoSeccion(idEstudiante As Integer) As DataTable
        Try
            Return objDatos.ObtenerNivelGradoSeccion(idEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function FormatearNivelGradoSeccion(dt As DataTable) As String
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            Return "Sin asignar"
        End If
        Dim row As DataRow = dt.Rows(0)
        Return row("nivel").ToString() & " - " &
               row("grado").ToString() & " - " &
               row("seccion").ToString()
    End Function


    Public Function ObtenerCronograma(idEstudiante As Integer) As DataTable
        Try
            Return objDatos.ObtenerCronograma(idEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function ProcesarMatricula(idPagoMatricula As Integer,
                                  idEstudiante As Integer,
                                  idSeccion As Integer,
                                  idAnoAcademico As Integer,
                                  estadoPago As String,
                                  observacion As String,
                                  montoBase As Decimal,
                                  porcentajeBeca As Decimal) As Boolean
        If idPagoMatricula <= 0 Then
            Throw New Exception("No hay un pago seleccionado.")
        End If

        Try
            Return objDatos.ProcesarMatricula(idPagoMatricula, idEstudiante,
                                          idSeccion, idAnoAcademico,
                                          observacion, montoBase, porcentajeBeca)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function CalcularDescuento(montoBase As Decimal,
                                      porcentajeBeca As Decimal) As Decimal
        Return Math.Round(montoBase * (porcentajeBeca / 100), 2)
    End Function

    Public Function YaEstaMatriculado(idEstudiante As Integer) As Boolean
        Try
            Return objDatos.YaEstaMatriculado(idEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerObservacionMatricula(idEstudiante As Integer) As String
        Return objDatos.ObtenerObservacionMatricula(idEstudiante)
    End Function


End Class
Imports capaDatos
Imports System.Data

Public Class clsDocente

    Private obj As New capaDatos.clsDocente()

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Try
            Return obj.ObtenerSiguienteID()
        Catch ex As Exception
            Throw New Exception("Error al obtener el siguiente ID: " & ex.Message)
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR DOCENTES
    ' ══════════════════════════════════════════════
    Public Function MostrarDocentes() As DataTable
        Try
            Return obj.Mostrar()
        Catch ex As Exception
            Throw New Exception("Error al obtener la lista de docentes: " & ex.Message)
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  OBTENER PERSONAS PARA COMBOBOX (modo Nuevo)
    ' ══════════════════════════════════════════════
    Public Function ObtenerPersonas() As DataTable
        Try
            Return obj.ObtenerPersonas()
        Catch ex As Exception
            Throw New Exception("Error al cargar personas disponibles: " & ex.Message)
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  OBTENER PERSONAS PARA COMBOBOX (modo Edición)
    ' ══════════════════════════════════════════════
    Public Function ObtenerPersonasParaEdicion(idPersonaActual As Integer) As DataTable
        Try
            If idPersonaActual <= 0 Then
                Throw New Exception("El ID de persona para edición no es válido.")
            End If
            Return obj.ObtenerPersonasParaEdicion(idPersonaActual)
        Catch ex As Exception
            Throw New Exception("Error al cargar personas para edición: " & ex.Message)
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  VALIDACIONES COMPARTIDAS
    ' ══════════════════════════════════════════════
    Private Sub ValidarCampos(especialidad As String, idPersona As Integer)
        If String.IsNullOrWhiteSpace(especialidad) Then
            Throw New Exception("El campo 'Especialidad' es obligatorio.")
        End If
        If especialidad.Trim().Length < 3 Then
            Throw New Exception("La especialidad debe tener al menos 3 caracteres.")
        End If
        If especialidad.Trim().Length > 100 Then
            Throw New Exception("La especialidad no puede superar los 100 caracteres.")
        End If
        If idPersona <= 0 Then
            Throw New Exception("Debe seleccionar una persona válida del listado.")
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  INSERTAR DOCENTE
    ' ══════════════════════════════════════════════
    Public Sub InsertarDocente(especialidad As String, idPersona As Integer, estado As Boolean)
        Try
            ' 1. Validar campos
            ValidarCampos(especialidad, idPersona)

            ' 2. Verificar que la persona no sea ya docente
            If obj.PersonaYaEsDocente(idPersona) Then
                Throw New Exception("La persona seleccionada ya está registrada como docente.")
            End If

            ' 3. Insertar
            obj.Insertar(especialidad.Trim(), idPersona, estado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR DOCENTE
    ' ══════════════════════════════════════════════
    Public Sub EditarDocente(id As Integer, especialidad As String,
                              idPersona As Integer, estado As Boolean)
        Try
            ' 1. Validar ID
            If id <= 0 Then
                Throw New Exception("El ID del docente no es válido.")
            End If

            ' 2. Validar campos
            ValidarCampos(especialidad, idPersona)

            ' 3. Verificar duplicado excluyendo el propio registro
            If obj.PersonaYaEsDocente(idPersona, id) Then
                Throw New Exception("La persona seleccionada ya está asignada a otro docente.")
            End If

            ' 4. Editar
            obj.Editar(id, especialidad.Trim(), idPersona, estado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA
    ' ══════════════════════════════════════════════
    Public Sub DarBajaDocente(id As Integer)
        Try
            If id <= 0 Then
                Throw New Exception("El ID del docente no es válido.")
            End If
            obj.DarBaja(id, False)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja al docente: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR DOCENTE
    '  Retorna True  → eliminación física (sin relaciones)
    '  Retorna False → baja lógica       (tiene relaciones)
    ' ══════════════════════════════════════════════
    Public Function EliminarDocente(id As Integer) As Boolean
        Try
            If id <= 0 Then
                Throw New Exception("El ID del docente no es válido.")
            End If

            If obj.TieneRelaciones(id) Then
                ' Tiene relaciones: baja lógica automática
                obj.DarBaja(id, False)
                Return False
            Else
                ' Sin relaciones: eliminar físicamente
                obj.Eliminar(id)
                Return True
            End If

        Catch ex As Exception
            Throw New Exception("Error al eliminar docente: " & ex.Message)
        End Try
    End Function

End Class

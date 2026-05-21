Imports capaDatos
Imports System.Data

Public Class clsTutorAula

    Private obj As New capaDatos.clsTutorAula()

    Public Function ObtenerSiguienteID() As Integer
        Return obj.ObtenerSiguienteID()
    End Function

    Public Function MostrarTutores() As DataTable
        Return obj.Mostrar()
    End Function

    Public Function BuscarPorID(id As Integer) As DataTable
        If id <= 0 Then Throw New Exception("El código ingresado no es válido.")
        Dim dt As DataTable = obj.BuscarPorID(id)
        If dt.Rows.Count = 0 Then Throw New Exception("No se encontró un registro con ese código.")
        Return dt
    End Function

    Public Function ListarDocentes() As DataTable
        Return obj.ListarDocentes()
    End Function

    Public Function ListarSecciones() As DataTable
        Return obj.ListarSecciones()
    End Function

    Private Sub Validar(idDocente As Integer, idSeccion As Integer)
        If idDocente <= 0 Then Throw New Exception("Debe seleccionar un docente válido.")
        If idSeccion <= 0 Then Throw New Exception("Debe seleccionar una sección válida.")
    End Sub

    Public Sub Insertar(idDocente As Integer, idSeccion As Integer, estado As Boolean)
        Validar(idDocente, idSeccion)
        If obj.YaExiste(idDocente, idSeccion) Then
            Throw New Exception("Ese docente ya está asignado como tutor en esa sección.")
        End If
        obj.Insertar(idDocente, idSeccion, estado)
    End Sub

    Public Sub Actualizar(id As Integer, idDocente As Integer, idSeccion As Integer, estado As Boolean)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        Validar(idDocente, idSeccion)
        If obj.YaExiste(idDocente, idSeccion, id) Then
            Throw New Exception("Esa combinación docente-sección ya existe en otro registro.")
        End If
        obj.Actualizar(id, idDocente, idSeccion, estado)
    End Sub

    Public Sub DarBaja(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.DarBaja(id)
    End Sub

    ''' <summary>
    ''' Retorna True → eliminación física exitosa
    ''' Retorna False → no aplica para TUTOR_AULA (siempre se puede eliminar)
    ''' Aquí simplemente se elimina físico; si quisieras proteger, agrega lógica.
    ''' </summary>
    Public Sub Eliminar(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.Eliminar(id)
    End Sub

End Class

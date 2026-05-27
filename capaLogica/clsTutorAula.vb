Imports capaDatos
Imports System.Data

Public Class clsTutorAula

    Private obj As New capaDatos.clsTutorAula()

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Return obj.ObtenerSiguienteID()
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR TODOS
    ' ══════════════════════════════════════════════
    Public Function MostrarTutores() As DataTable
        Return obj.Mostrar()
    End Function

    Public Function MostrarPorDocente(idDocente As Integer) As DataTable
        If idDocente <= 0 Then Throw New Exception("Seleccione un docente válido.")
        Return obj.MostrarPorDocente(idDocente)
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR POR ID
    ' ══════════════════════════════════════════════
    Public Function BuscarPorID(id As Integer) As DataTable
        If id <= 0 Then Throw New Exception("El código ingresado no es válido.")
        Dim dt As DataTable = obj.BuscarPorID(id)
        If dt.Rows.Count = 0 Then Throw New Exception("No se encontró un registro con ese código.")
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR DOCENTES POR NOMBRE
    ' ══════════════════════════════════════════════
    Public Function BuscarDocentes(texto As String) As DataTable
        If String.IsNullOrWhiteSpace(texto) Then
            Throw New Exception("Ingrese un nombre para buscar el docente.")
        End If
        Dim dt As DataTable = obj.BuscarDocentes(texto)
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se encontró ningún docente con ese nombre.")
        End If
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR COMBOS
    ' ══════════════════════════════════════════════
    Public Function ListarDocentes() As DataTable
        Return obj.ListarDocentes()
    End Function

    Public Function ListarNiveles() As DataTable
        Return obj.ListarNiveles()
    End Function

    Public Function ListarGradosPorNivel(idNivel As Integer) As DataTable
        If idNivel <= 0 Then Throw New Exception("Debe seleccionar un nivel válido.")
        Return obj.ListarGradosPorNivel(idNivel)
    End Function

    Public Function ListarSeccionesPorGrado(idGrado As Integer) As DataTable
        If idGrado <= 0 Then Throw New Exception("Debe seleccionar un grado válido.")
        Return obj.ListarSeccionesPorGrado(idGrado)
    End Function

    ' ══════════════════════════════════════════════
    '  VALIDACIÓN INTERNA
    ' ══════════════════════════════════════════════
    Private Sub Validar(idDocente As Integer, idSeccion As Integer)
        If idDocente <= 0 Then Throw New Exception("Debe seleccionar un docente válido.")
        If idSeccion <= 0 Then Throw New Exception("Debe seleccionar una sección válida.")
    End Sub

    ' ══════════════════════════════════════════════
    '  INSERTAR
    ' ══════════════════════════════════════════════
    Public Sub Insertar(idDocente As Integer, idSeccion As Integer, estado As Boolean)
        Validar(idDocente, idSeccion)
        If obj.YaExiste(idDocente, idSeccion) Then
            Throw New Exception("Ese docente ya está asignado como tutor en esa sección.")
        End If
        obj.Insertar(idDocente, idSeccion, estado)
    End Sub

    ' ══════════════════════════════════════════════
    '  ACTUALIZAR
    ' ══════════════════════════════════════════════
    Public Sub Actualizar(id As Integer, idDocente As Integer, idSeccion As Integer, estado As Boolean)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        Validar(idDocente, idSeccion)
        If obj.YaExiste(idDocente, idSeccion, id) Then
            Throw New Exception("Esa combinación docente-sección ya existe en otro registro.")
        End If
        obj.Actualizar(id, idDocente, idSeccion, estado)
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA
    ' ══════════════════════════════════════════════
    Public Sub DarBaja(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.DarBaja(id)
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR FÍSICO
    ' ══════════════════════════════════════════════
    Public Sub Eliminar(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.Eliminar(id)
    End Sub

End Class
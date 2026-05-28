Imports System.Data.SqlClient

Public Class clsCursoGrado
    Dim objConexion As New clsConectaBD()

    ' Mostrar todas las asignaciones combinando las 3 tablas
    Public Function MostrarAsignaciones() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT GC.id_grado_curso AS ID_Asignacion, " &
                                  "G.nombre AS Grado, " &
                                  "C.nombreCurso AS Curso, " &
                                  "GC.estado AS Estado " &
                                  "FROM GRADO_CURSO GC " &
                                  "INNER JOIN GRADO G ON GC.id_grado = G.id_grado " &
                                  "INNER JOIN CURSO C ON GC.id_curso = C.id_curso"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al mostrar asignaciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function CargarAnios() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT DISTINCT YEAR(fechaInicio) AS Anio FROM ano_academico ORDER BY Anio DESC"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar años: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarAsignacionesFiltradas(anio As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT GC.id_grado_curso AS ID_Asignacion, " &
                              "G.nombre AS Grado, " &
                              "C.nombreCurso AS Curso, " &
                              "GC.estado AS Estado " &
                              "FROM GRADO_CURSO GC " &
                              "INNER JOIN GRADO G ON GC.id_grado = G.id_grado " &
                              "INNER JOIN CURSO C ON GC.id_curso = C.id_curso " &
                              "INNER JOIN nivel N ON G.id_nivel = N.id_nivel " &
                              "INNER JOIN ano_academico A ON N.id_anoAcademico = A.id_anoAcademico " &
                              "WHERE YEAR(A.fechaInicio) = @anio"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@anio", anio)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al filtrar asignaciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function CargarGradosPorAnio(anio As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT G.id_grado, G.nombre " &
                              "FROM GRADO G " &
                              "INNER JOIN nivel N ON G.id_nivel = N.id_nivel " &
                              "INNER JOIN ano_academico A ON N.id_anoAcademico = A.id_anoAcademico " &
                              "WHERE YEAR(A.fechaInicio) = @anio"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@anio", anio)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' Cargar listado de grados para el ComboBox
    Public Function CargarGrados() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_grado, nombre FROM GRADO"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' Cargar listado de cursos para el ComboBox
    Public Function CargarCursos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_curso, nombreCurso FROM CURSO WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar cursos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' Registrar una nueva asignación
    Public Sub RegistrarAsignacion(id_grado As Integer, id_curso As Integer, estado As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO GRADO_CURSO (id_grado, id_curso, estado) VALUES (@idGrado, @idCurso, @estado)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idGrado", id_grado)
            cmd.Parameters.AddWithValue("@idCurso", id_curso)
            cmd.Parameters.AddWithValue("@estado", estado)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al registrar asignación: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' Dar de baja a la asignación (cambiar estado a 0)
    Public Sub DarBajaAsignacion(id_grado_curso As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE GRADO_CURSO SET estado = 0 WHERE id_grado_curso = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_grado_curso)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' Eliminar físicamente la asignación
    Public Sub EliminarAsignacion(id_grado_curso As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "DELETE FROM GRADO_CURSO WHERE id_grado_curso = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_grado_curso)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al eliminar asignación: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub
End Class

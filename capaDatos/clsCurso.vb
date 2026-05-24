Imports System.Data.SqlClient

Public Class clsCurso
    Dim objConexion As New clsConectaBD()

    Public Function MostrarCursos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT C.id_curso AS ID, C.nombreCurso AS Nombre_Curso, " &
                                  "C.descripcion AS Descripcion, A.nombre AS Area_Academica, " &
                                  "C.estado AS Vigente " &
                                  "FROM CURSO C " &
                                  "INNER JOIN AREA_ACADEMICA A ON C.id_area = A.id_area"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al mostrar cursos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarCursosFiltrados(nombre As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT C.id_curso AS ID, C.nombreCurso AS Nombre_Curso, " &
                                  "C.descripcion AS Descripcion, A.nombre AS Area_Academica, " &
                                  "C.estado AS Vigente " &
                                  "FROM CURSO C " &
                                  "INNER JOIN AREA_ACADEMICA A ON C.id_area = A.id_area " &
                                  "WHERE C.nombreCurso LIKE @nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", "%" & nombre & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al filtrar cursos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarAreasAcademicas() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_area, nombre FROM AREA_ACADEMICA WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar áreas: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub RegistrarCurso(nombreCurso As String, descripcion As String, id_area As Integer, id_grado As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO CURSO (nombreCurso, descripcion, id_area, id_grado, estado) " &
                                  "VALUES (@nombre, @descripcion, @idArea, @idGrado, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombreCurso)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            cmd.Parameters.AddWithValue("@idArea", id_area)
            cmd.Parameters.AddWithValue("@idGrado", id_grado)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al registrar curso: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EditarCurso(id_curso As Integer, nombreCurso As String, descripcion As String, id_area As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE CURSO SET nombreCurso=@nombre, descripcion=@descripcion, " &
                                  "id_area=@idArea WHERE id_curso=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombreCurso)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            cmd.Parameters.AddWithValue("@idArea", id_area)
            cmd.Parameters.AddWithValue("@id", id_curso)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al editar curso: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaCurso(id_curso As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE CURSO SET estado = 0 WHERE id_curso = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_curso)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarCurso(id_curso As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "DELETE FROM CURSO WHERE id_curso = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_curso)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al eliminar curso: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

End Class
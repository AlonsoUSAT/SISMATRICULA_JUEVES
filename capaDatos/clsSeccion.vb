Imports System.Data
Imports System.Data.SqlClient

Public Class clsSeccion
    Dim objConexion As New clsConectaBD()

    Public Function ListarNiveles() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim da As New SqlDataAdapter("SELECT id_nivel, nombre FROM NIVEL", objConexion.miConexion)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarGrados(id_nivel As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("SELECT id_grado, nombre as Grado_Academico FROM GRADO WHERE id_nivel = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_nivel)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarSecciones(id_grado As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Agregamos vigencia al SELECT
            Dim cmd As New SqlCommand("SELECT id_seccion, nombre as Nombre, aforo as Aforo, tutor as Tutor, vigencia as Vigencia FROM SECCION WHERE id_grado = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_grado)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Sub InsertarSeccion(id_grado As Integer, nombre As String, aforo As Integer, tutor As String)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("INSERT INTO SECCION (id_grado, nombre, aforo, tutor) VALUES (@id_grado, @nombre, @aforo, @tutor)", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_grado", id_grado)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@aforo", aforo)
            cmd.Parameters.AddWithValue("@tutor", If(String.IsNullOrEmpty(tutor), DBNull.Value, tutor))
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub ModificarSeccion(id_seccion As Integer, nombre As String, aforo As Integer, tutor As String, vigencia As Integer)
        Try
            objConexion.conectar()
            ' Agregamos vigencia=@vigencia al UPDATE
            Dim cmd As New SqlCommand("UPDATE SECCION SET nombre=@nombre, aforo=@aforo, tutor=@tutor, vigencia=@vigencia WHERE id_seccion=@id_seccion", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_seccion", id_seccion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@aforo", aforo)
            cmd.Parameters.AddWithValue("@tutor", If(String.IsNullOrEmpty(tutor), DBNull.Value, tutor))

            ' Nuevo parámetro
            cmd.Parameters.AddWithValue("@vigencia", vigencia)

            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarSeccion(id_seccion As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("DELETE FROM SECCION WHERE id_seccion=@id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_seccion)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaSeccion(id_seccion As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("UPDATE SECCION SET vigencia = 0 WHERE id_seccion = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_seccion)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub
End Class
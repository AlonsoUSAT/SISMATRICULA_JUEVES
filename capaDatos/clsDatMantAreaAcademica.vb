Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatMantAreaAcademica

    Dim objConexion As New clsConectaBD()

    Public Function Listar() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "SELECT id_area, nombre, CASE estado WHEN 1 THEN 'ACTIVO' ELSE 'BAJA' END AS estado
                 FROM AREA_ACADEMICA ORDER BY nombre",
                objConexion.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Sub Insertar(nombre As String)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "INSERT INTO AREA_ACADEMICA (nombre, estado) VALUES (@nombre, 1)",
                objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub Actualizar(idArea As Integer, nombre As String)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "UPDATE AREA_ACADEMICA SET nombre = @nombre WHERE id_area = @id",
                objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@id", idArea)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al modificar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBaja(idArea As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "UPDATE AREA_ACADEMICA SET estado = 0 WHERE id_area = @id",
                objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", idArea)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub Eliminar(idArea As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "DELETE FROM AREA_ACADEMICA WHERE id_area = @id",
                objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", idArea)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function ExisteNombre(nombre As String, idExcluir As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM AREA_ACADEMICA 
                 WHERE UPPER(nombre) = UPPER(@nombre) AND id_area <> @id",
                objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@id", idExcluir)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar nombre: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


    Public Function ObtenerSiguienteId() As Integer
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand(
                "SELECT ISNULL(MAX(id_area), 0) + 1 FROM AREA_ACADEMICA",
                objConexion.miConexion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al obtener ID: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


End Class
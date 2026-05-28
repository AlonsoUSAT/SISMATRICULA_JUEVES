Imports System.Data.SqlClient

Public Class clsEspecialidad
    Dim objConexion As New clsConectaBD()

    Public Function ContarPorEstado(estado As Integer) As Integer
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT COUNT(*) FROM ESPECIALIDAD WHERE estado = @estado"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@estado", estado)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al contar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function MostrarEspecialidades() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT id_especialidad AS ID, nombre AS Nombre, " &
                "CASE WHEN estado = 1 THEN 'Vigente' ELSE 'Baja' END AS Estado " &
                "FROM ESPECIALIDAD"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al mostrar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarFiltradas(filtro As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim estado As Integer = If(filtro = "vigente", 1, 0)
            Dim query As String =
            "SELECT id_especialidad AS ID, nombre AS Nombre, " &
            "CASE WHEN estado = 1 THEN 'Vigente' ELSE 'Baja' END AS Estado " &
            "FROM ESPECIALIDAD WHERE estado = @estado"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@estado", estado)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al filtrar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub Registrar(nombre As String)
        Try
            objConexion.conectar()
            Dim query As String =
                "INSERT INTO ESPECIALIDAD (nombre, estado) VALUES (@nombre, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub Editar(id As Integer, nombre As String, estado As Boolean)
        Try
            objConexion.conectar()
            Dim query As String =
            "UPDATE ESPECIALIDAD SET nombre=@nombre, estado=@estado WHERE id_especialidad=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@estado", estado)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBaja(id As Integer)
        Try
            objConexion.conectar()
            Dim query As String =
                "UPDATE ESPECIALIDAD SET estado=0 WHERE id_especialidad=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            Dim query As String =
                "DELETE FROM ESPECIALIDAD WHERE id_especialidad=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub
End Class
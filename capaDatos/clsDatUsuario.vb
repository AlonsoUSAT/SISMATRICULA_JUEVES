Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatUsuario
    Dim objConexion As New clsConectaBD()

    Public Function ValidarLogin(usuario As String, clave As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT * FROM USUARIO WHERE nomusuario = @user AND clave = @pass AND estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@user", usuario)
            cmd.Parameters.AddWithValue("@pass", clave)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error en base de datos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function
End Class
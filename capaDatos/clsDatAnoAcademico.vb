Imports System.Data.SqlClient

Public Class clsDatAnoAcademico
    Dim objConexion As New clsConectaBD()

    Public Function ListarAnos() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_anoAcademico, fechaInicio, fechaFin, estado FROM ANO_ACADEMICO WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function InsertarAno(fechaInicio As Date, fechaFin As Date) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO ANO_ACADEMICO (fechaInicio, fechaFin, estado) VALUES (@fechaInicio, @fechaFin, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function ActualizarAno(id As Integer, fechaInicio As Date, fechaFin As Date, estado As Boolean) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE ANO_ACADEMICO SET fechaInicio = @fechaInicio, fechaFin = @fechaFin, estado = @estado WHERE id_anoAcademico = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin)
            cmd.Parameters.AddWithValue("@estado", estado)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al actualizar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function DarDeBajaAno(id As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE ANO_ACADEMICO SET estado = 0 WHERE id_anoAcademico = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function
End Class

Imports System.Data.SqlClient

Public Class clsDatPagoMatricula
    Dim objConexion As New clsConectaBD()

    ' 1. LISTAR PAGOS
    Public Function ListarPagos() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_pagoMatricula, fechaPago, codigoOperativo, monto, numeroReferencia, estado FROM PAGO_MATRICULA WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar pagos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' 2. INSERTAR NUEVO PAGO
    Public Function InsertarPago(fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO PAGO_MATRICULA (fechaPago, codigoOperativo, monto, numeroReferencia, estado) VALUES (@fechaPago, @codOperativo, @monto, @numReferencia, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@fechaPago", fechaPago)
            cmd.Parameters.AddWithValue("@codOperativo", codOperativo)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@numReferencia", numReferencia)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 3. ACTUALIZAR PAGO
    Public Function ActualizarPago(id As Integer, fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer, estado As Boolean) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PAGO_MATRICULA SET fechaPago = @fechaPago, codigoOperativo = @codOperativo, monto = @monto, numeroReferencia = @numReferencia, estado = @estado WHERE id_pagoMatricula = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fechaPago", fechaPago)
            cmd.Parameters.AddWithValue("@codOperativo", codOperativo)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@numReferencia", numReferencia)
            cmd.Parameters.AddWithValue("@estado", estado)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al actualizar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 4. DAR DE BAJA
    Public Function DarDeBajaPago(id As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PAGO_MATRICULA SET estado = 0 WHERE id_pagoMatricula = @id"
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

Imports System.Data.SqlClient

Public Class clsDatPlanEstudio
    Dim objConexion As New clsConectaBD()

    ' 1. LISTAR PLANES DE ESTUDIO
    Public Function ListarPlanes() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Consulta SQL directa en lugar de SP
            Dim query As String = "SELECT id_planEstudio, año, estado FROM PLAN_ESTUDIO WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text ' Indicamos que es texto SQL
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' 2. INSERTAR NUEVO PLAN
    Public Function InsertarPlan(año As Date) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO PLAN_ESTUDIO (año, estado) VALUES (@año, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@año", año)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 3. ACTUALIZAR PLAN EXISTENTE
    Public Function ActualizarPlan(id As Integer, año As Date, estado As Boolean) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PLAN_ESTUDIO SET año = @año, estado = @estado WHERE id_planEstudio = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@año", año)
            cmd.Parameters.AddWithValue("@estado", estado)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al actualizar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 4. DAR DE BAJA (Borrado Lógico)
    Public Function DarDeBajaPlan(id As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PLAN_ESTUDIO SET estado = 0 WHERE id_planEstudio = @id"
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

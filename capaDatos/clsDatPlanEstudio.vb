Imports System.Data
Imports System.Data.SqlClient

Namespace capaDatos
    Public Class clsDatPlanEstudio

        ' 1. LISTAR PLANES DE ESTUDIO
        Public Function ListarPlanes() As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                ' Extraemos la columna vigencia pero la mostramos como "estado" en la grilla para tu comodidad
                Dim query As String = "SELECT id_planEstudio, año, vigencia AS estado FROM PLAN_ESTUDIO"
                Dim cmd As New SqlCommand(query, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
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
        Public Function InsertarPlan(año As Date, vigencia As Boolean) As Boolean
            Dim objConexion As New clsConectaBD()
            Try
                Dim query As String = "INSERT INTO PLAN_ESTUDIO (año, vigencia) VALUES (@año, @vigencia)"
                Dim cmd As New SqlCommand(query, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@año", año)
                cmd.Parameters.AddWithValue("@vigencia", If(vigencia, 1, 0))

                objConexion.conectar()
                Return cmd.ExecuteNonQuery() > 0
            Catch ex As Exception
                Throw New Exception("Error al insertar: " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
        End Function

        ' 3. ACTUALIZAR PLAN EXISTENTE
        Public Function ActualizarPlan(id As Integer, año As Date, vigencia As Boolean) As Boolean
            Dim objConexion As New clsConectaBD()
            Try
                Dim query As String = "UPDATE PLAN_ESTUDIO SET año = @año, vigencia = @vigencia WHERE id_planEstudio = @id"
                Dim cmd As New SqlCommand(query, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@año", año)
                cmd.Parameters.AddWithValue("@vigencia", If(vigencia, 1, 0))

                objConexion.conectar()
                Return cmd.ExecuteNonQuery() > 0
            Catch ex As Exception
                Throw New Exception("Error al actualizar: " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
        End Function

        ' 4. DAR DE BAJA (Borrado Lógico)
        Public Function DarDeBajaPlan(id As Integer) As Boolean
            Dim objConexion As New clsConectaBD()
            Try
                Dim query As String = "UPDATE PLAN_ESTUDIO SET vigencia = 0 WHERE id_planEstudio = @id"
                Dim cmd As New SqlCommand(query, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@id", id)

                objConexion.conectar()
                Return cmd.ExecuteNonQuery() > 0
            Catch ex As Exception
                Throw New Exception("Error al dar de baja: " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
        End Function

        ' 5. OBTENER SIGUIENTE ID (Para mostrar en pantalla)
        Public Function ObtenerSiguienteId() As Integer
            Dim nextId As Integer = 1
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT ISNULL(MAX(id_planEstudio), 0) + 1 FROM PLAN_ESTUDIO"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
                nextId = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                Throw New Exception("Error BD (Siguiente ID): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return nextId
        End Function

    End Class
End Namespace
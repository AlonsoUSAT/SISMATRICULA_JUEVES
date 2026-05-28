Imports System.Data
Imports System.Data.SqlClient

Namespace capaDatos

    Public Class clsDatTipoBeca

        Public Function ObtenerSiguienteId() As Integer
            Dim nextId As Integer = 1
            Dim objConexion As New clsConectaBD()
            Try
                ' Busca el ID más alto y le suma 1. Si la tabla está vacía, devuelve 1.
                Dim sql As String = "SELECT ISNULL(MAX(id_tipo_beca), 0) + 1 FROM TIPO_BECA"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
                nextId = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                Throw New Exception("Error BD (Obtener Siguiente ID): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return nextId
        End Function
        Public Function Listar(filtro As String) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT id_tipo_beca AS ID, descripcion AS Descripcion, " &
                                    "porcentaje_descuento AS Porcentaje, estado AS Estado " &
                                    "FROM TIPO_BECA " &
                                    "WHERE descripcion LIKE '%' + @filtro + '%' " &
                                    "ORDER BY id_tipo_beca DESC"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@filtro", filtro.Trim())

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (Listar Tipos Beca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function Insertar(descripcion As String, porcentaje As Decimal, estado As Boolean) As Boolean
            Dim exito As Boolean = False
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "INSERT INTO TIPO_BECA (descripcion, porcentaje_descuento, estado) " &
                                    "VALUES (@desc, @pct, @est)"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@desc", descripcion.Trim())
                cmd.Parameters.AddWithValue("@pct", porcentaje)
                cmd.Parameters.AddWithValue("@est", If(estado, 1, 0))

                objConexion.conectar()
                If cmd.ExecuteNonQuery() > 0 Then exito = True
            Catch ex As Exception
                Throw New Exception("Error BD (Insertar Tipo Beca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return exito
        End Function

        Public Function Actualizar(id As Integer, descripcion As String, porcentaje As Decimal, estado As Boolean) As Boolean
            Dim exito As Boolean = False
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "UPDATE TIPO_BECA SET descripcion = @desc, " &
                                    "porcentaje_descuento = @pct, estado = @est " &
                                    "WHERE id_tipo_beca = @id"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@desc", descripcion.Trim())
                cmd.Parameters.AddWithValue("@pct", porcentaje)
                cmd.Parameters.AddWithValue("@est", If(estado, 1, 0))

                objConexion.conectar()
                If cmd.ExecuteNonQuery() > 0 Then exito = True
            Catch ex As Exception
                Throw New Exception("Error BD (Actualizar Tipo Beca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return exito
        End Function

        Public Function DarBaja(id As Integer) As Boolean
            Dim exito As Boolean = False
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "UPDATE TIPO_BECA SET estado = 0 WHERE id_tipo_beca = @id"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@id", id)

                objConexion.conectar()
                If cmd.ExecuteNonQuery() > 0 Then exito = True
            Catch ex As Exception
                Throw New Exception("Error BD (Dar de Baja Tipo Beca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return exito
        End Function

        ' ==================================================================
        ' 5. ELIMINAR DEFINITIVAMENTE
        ' ==================================================================
        Public Function Eliminar(id As Integer) As Boolean
            Dim exito As Boolean = False
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "DELETE FROM TIPO_BECA WHERE id_tipo_beca = @id"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@id", id)

                objConexion.conectar()
                If cmd.ExecuteNonQuery() > 0 Then exito = True
            Catch ex As SqlException
                ' Error 547 es violación de llave foránea (significa que está en uso en ASIGNACION_BECA)
                If ex.Number = 547 Then
                    Throw New Exception("No se puede eliminar esta beca porque ya fue asignada a uno o más estudiantes. Se recomienda 'Dar de Baja'.")
                Else
                    Throw New Exception("Error BD (Eliminar Tipo Beca): " & ex.Message)
                End If
            Catch ex As Exception
                Throw New Exception("Error BD (Eliminar Tipo Beca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return exito
        End Function

    End Class
End Namespace
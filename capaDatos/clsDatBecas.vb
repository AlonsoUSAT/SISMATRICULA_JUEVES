Imports System.Data
Imports System.Data.SqlClient

Namespace capaDatos

    Public Class clsDatBecas

        ' ==================================================================
        ' 1. CATÁLOGOS
        ' ==================================================================
        Public Function ListarTiposBeca() As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT id_tipo_beca, descripcion, porcentaje_descuento FROM TIPO_BECA WHERE estado = 1"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ListarTiposBeca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function ObtenerAnoAcademicoActual() As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT TOP 1 id_anoAcademico, CAST(YEAR(fechaInicio) AS VARCHAR) AS AnoAcademico " &
                                    "FROM ANO_ACADEMICO WHERE estado = 1 ORDER BY id_anoAcademico DESC"
                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ObtenerAnoAcademicoActual): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        ' ==================================================================
        ' 2. BÚSQUEDA DE ESTUDIANTE
        ' ==================================================================
        Public Function BuscarEstudianteParaBeca(numDocumento As String) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT e.id_estudiante, p.apePaterno + ' ' + p.apeMaterno + ', ' + p.nombre AS nombreCompleto, " &
                                    "ISNULL(e.tipoEstudiante, 'REGULAR') AS tipoEstudiante, " &
                                    "'-' AS gradoSeccion, " &
                                    "CAST(CASE WHEN EXISTS(SELECT 1 FROM ASIGNACION_BECA ab WHERE ab.id_estudiante = e.id_estudiante AND ab.estado = 'ACTIVA') THEN 1 ELSE 0 END AS BIT) AS tieneBecaActiva " &
                                    "FROM ESTUDIANTE e INNER JOIN PERSONA p ON e.id_persona = p.id_persona " &
                                    "WHERE p.num_doc = @numDocumento"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@numDocumento", numDocumento.Trim())

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (BuscarEstudiante): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        ' ==================================================================
        ' 3. ASIGNACIÓN DE BECA
        ' ==================================================================
        Public Function AsignarBeca(idEstudiante As Integer, idTipoBeca As Integer, idAnoAcademico As Integer,
                                    motivoAsignacion As String, porcentajeAplicado As Decimal, montoDescuentoMes As Decimal,
                                    usuarioRegistro As String) As Boolean
            Dim exito As Boolean = False
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "INSERT INTO ASIGNACION_BECA " &
                                    "(id_estudiante, id_tipo_beca, id_anoAcademico, motivo_asignacion, " &
                                    "porcentaje_aplicado, monto_descuento_mes, usuario_registro, estado, fecha_asignacion) " &
                                    "VALUES (@idEstudiante, @idTipoBeca, @idAnoAcademico, @motivo, " &
                                    "@porcentaje, @monto, @usuario, 'ACTIVA', GETDATE())"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante)
                cmd.Parameters.AddWithValue("@idTipoBeca", idTipoBeca)
                cmd.Parameters.AddWithValue("@idAnoAcademico", idAnoAcademico)
                cmd.Parameters.AddWithValue("@motivo", motivoAsignacion)
                cmd.Parameters.AddWithValue("@porcentaje", porcentajeAplicado)
                cmd.Parameters.AddWithValue("@monto", montoDescuentoMes)
                cmd.Parameters.AddWithValue("@usuario", If(String.IsNullOrWhiteSpace(usuarioRegistro), DBNull.Value, usuarioRegistro))

                objConexion.conectar()
                If cmd.ExecuteNonQuery() > 0 Then exito = True
            Catch ex As Exception
                Throw New Exception("Error BD (AsignarBeca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return exito
        End Function

        ' ==================================================================
        ' 4. CAMBIAR ESTADO DE BECA (SUSPENDER / REVOCAR)
        ' ==================================================================
        Public Sub CambiarEstadoBeca(idAsignacionBeca As Integer, nuevoEstado As String,
                                     usuarioModificacion As String)
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "UPDATE ASIGNACION_BECA " &
                                    "SET estado = @nuevoEstado, usuario_modificacion = @usuarioModificacion " &
                                    "WHERE id_asignacion = @idAsignacionBeca"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                cmd.Parameters.AddWithValue("@idAsignacionBeca", idAsignacionBeca)
                cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado)
                cmd.Parameters.AddWithValue("@usuarioModificacion", If(String.IsNullOrWhiteSpace(usuarioModificacion), DBNull.Value, usuarioModificacion))

                objConexion.conectar()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error BD (CambiarEstadoBeca): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
        End Sub

        ' ==================================================================
        ' 5. LISTADOS
        ' ==================================================================
        Public Function ListarBecadosAnoActual() As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT ab.id_asignacion, p.num_doc AS DNI, p.apePaterno + ' ' + p.apeMaterno + ', ' + p.nombre AS Estudiante, " &
                                    "tb.descripcion AS TipoBeca, ab.estado AS Estado " &
                                    "FROM ASIGNACION_BECA ab INNER JOIN ESTUDIANTE e ON ab.id_estudiante = e.id_estudiante " &
                                    "INNER JOIN PERSONA p ON e.id_persona = p.id_persona " &
                                    "INNER JOIN TIPO_BECA tb ON ab.id_tipo_beca = tb.id_tipo_beca " &
                                    "WHERE ab.estado = 'ACTIVA'"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ListarBecados): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function HistorialBecasEstudiante(idEstudiante As Integer) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT ab.id_asignacion, tb.descripcion AS TipoBeca, ab.fecha_asignacion AS Fecha, " &
                                    "ab.estado AS Estado, ab.motivo_asignacion AS Motivo " &
                                    "FROM ASIGNACION_BECA ab INNER JOIN TIPO_BECA tb ON ab.id_tipo_beca = tb.id_tipo_beca " &
                                    "WHERE ab.id_estudiante = @idEstudiante ORDER BY ab.fecha_asignacion DESC"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante)

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (HistorialBecas): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

    End Class
End Namespace
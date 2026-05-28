Imports System.Data
Imports System.Data.SqlClient

Namespace capaDatos

    Public Class clsDatHistorial

        Public Function ObtenerDatosEstudianteCompleto(dni As String) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT " &
                                    "e.id_estudiante, " &
                                    "pe.num_doc AS DNI, " &
                                    "pe.apePaterno + ' ' + pe.apeMaterno + ', ' + pe.nombre AS NombreCompleto, " &
                                    "pe.sexo AS Sexo, " &
                                    "ISNULL(e.tipoEstudiante, 'REGULAR') AS TipoEstudiante, " &
                                    "pe.telefono AS Telefono, " &
                                    "pe.correo AS Correo, " &
                                    "pa.num_doc AS DNIApoderado, " &
                                    "pa.apePaterno + ' ' + pa.apeMaterno + ', ' + pa.nombre AS NombreApoderado, " &
                                    "pa.telefono AS TelefonoApoderado " &
                                    "FROM ESTUDIANTE e " &
                                    "INNER JOIN PERSONA pe ON e.id_persona = pe.id_persona " &
                                    "LEFT JOIN APODERADO a ON e.id_apoderado = a.id_apoderado " &
                                    "LEFT JOIN PERSONA pa ON a.id_persona = pa.id_persona " &
                                    "WHERE pe.num_doc = @dni"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@dni", dni.Trim())

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ObtenerDatosEstudianteCompleto): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function ObtenerHistorialMatriculas(idEstudiante As Integer) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT " &
                                    "m.id_matricula, " &
                                    "aa.id_anoAcademico, " &
                                    "CAST(YEAR(aa.fechaInicio) AS VARCHAR) AS AnoAcademico, " &
                                    "n.nombre AS Nivel, " &
                                    "g.nombre AS Grado, " &
                                    "s.nombre AS Seccion, " &
                                    "m.fecha AS FechaMatricula, " &
                                    "CASE WHEN m.estadoMatricula = 1 THEN 'ACTIVA' ELSE 'INACTIVA' END AS Estado " &
                                    "FROM MATRICULA m " &
                                    "INNER JOIN SECCION s ON m.id_seccion = s.id_seccion " &
                                    "INNER JOIN GRADO g ON s.id_grado = g.id_grado " &
                                    "INNER JOIN NIVEL n ON g.id_nivel = n.id_nivel " &
                                    "INNER JOIN ANO_ACADEMICO aa ON n.id_anoAcademico = aa.id_anoAcademico " &
                                    "WHERE m.id_estudiante = @idEstudiante " &
                                    "ORDER BY aa.fechaInicio DESC"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante)

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ObtenerHistorialMatriculas): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function ObtenerCursosYHorarios(idEstudiante As Integer, idAnoAcademico As Integer) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                ' Se aplica un CASE en el ORDER BY para que los días de la semana se ordenen cronológicamente y no alfabéticamente
                Dim sql As String = "SELECT " &
                                    "c.nombreCurso AS Curso, " &
                                    "ca.diaSemana AS Dia, " &
                                    "ca.horaInicio AS HoraInicio, " &
                                    "ca.horaFin AS HoraFin, " &
                                    "pd.apePaterno + ' ' + pd.nombre AS Docente " &
                                    "FROM MATRICULA m " &
                                    "INNER JOIN CARGA_ACADEMICA ca ON m.id_seccion = ca.id_seccion " &
                                    "INNER JOIN CURSO c ON ca.id_curso = c.id_curso " &
                                    "INNER JOIN DOCENTE d ON ca.id_docente = d.id_docente " &
                                    "INNER JOIN PERSONA pd ON d.id_persona = pd.id_persona " &
                                    "WHERE m.id_estudiante = @idEstudiante AND ca.id_anoAcademico = @idAnoAcademico " &
                                    "ORDER BY " &
                                    "CASE ca.diaSemana " &
                                    "   WHEN 'Lunes' THEN 1 " &
                                    "   WHEN 'Martes' THEN 2 " &
                                    "   WHEN 'Miercoles' THEN 3 " &
                                    "   WHEN 'Jueves' THEN 4 " &
                                    "   WHEN 'Viernes' THEN 5 " &
                                    "   WHEN 'Sabado' THEN 6 " &
                                    "   WHEN 'Domingo' THEN 7 " &
                                    "   ELSE 8 " &
                                    "END, ca.horaInicio"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante)
                cmd.Parameters.AddWithValue("@idAnoAcademico", idAnoAcademico)

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ObtenerCursosYHorarios): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

        Public Function ObtenerHistorialBecas(idEstudiante As Integer) As DataTable
            Dim dt As New DataTable()
            Dim objConexion As New clsConectaBD()
            Try
                Dim sql As String = "SELECT " &
                                    "CAST(YEAR(aa.fechaInicio) AS VARCHAR) AS AnoAcademico, " &
                                    "tb.descripcion AS TipoBeca, " &
                                    "ab.porcentaje_aplicado AS DescuentoPorcentaje, " &
                                    "ab.monto_descuento_mes AS DescuentoDinero, " &
                                    "ab.estado AS Estado, " &
                                    "ab.fecha_asignacion AS FechaAsignacion, " &
                                    "ab.motivo_asignacion AS Motivo " &
                                    "FROM ASIGNACION_BECA ab " &
                                    "INNER JOIN TIPO_BECA tb ON ab.id_tipo_beca = tb.id_tipo_beca " &
                                    "LEFT JOIN ANO_ACADEMICO aa ON ab.id_anoAcademico = aa.id_anoAcademico " &
                                    "WHERE ab.id_estudiante = @idEstudiante " &
                                    "ORDER BY ab.fecha_asignacion DESC"

                Dim cmd As New SqlCommand(sql, objConexion.miConexion)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante)

                objConexion.conectar()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Error BD (ObtenerHistorialBecas): " & ex.Message)
            Finally
                objConexion.desconectar()
            End Try
            Return dt
        End Function

    End Class
End Namespace
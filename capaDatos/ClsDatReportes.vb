Imports System.Data.SqlClient
Public Class ClsDatReportes
    Public Function ObtenerHistoricoCarga(idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT " &
    "(CONVERT(VARCHAR, AA.fechaInicio, 103) + ' al ' + CONVERT(VARCHAR, AA.fechaFin, 103)) AS [Año Académico], " &
    "(P.nombre + ' ' + P.apePaterno) AS [Docente], " &
    "C.nombreCurso AS [Curso], " &
    "S.nombre AS [Seccion], " &
    "H.diaSemana AS [Dia], " &
    "CONVERT(VARCHAR(5), H.horaInicio, 108) AS [Inicio], " &
    "CONVERT(VARCHAR(5), H.horaFin, 108) AS [Fin] " &
    "FROM CARGA_ACADEMICA CA " &
    "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
    "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
    "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
    "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
    "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
    "INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel " &
    "INNER JOIN ANO_ACADEMICO AA ON N.id_anoAcademico = AA.id_anoAcademico " &
    "INNER JOIN HORARIO H ON CA.id_horario = H.id_horario " &
    "WHERE CA.estado = 1 AND AA.id_anoAcademico = @idAno"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", idAno)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error histórico: " & ex.Message)
        End Try
        Return dt
    End Function
End Class

Imports System.Data.SqlClient

Public Class ClsDatReportes
    Public Function ObtenerHistoricoCarga(idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()

            ' 🌟 QUERY ACTUALIZADO: Jalamos el día y las horas directamente de CA (CARGA_ACADEMICA)
            Dim query As String = "SELECT " &
                "(CONVERT(VARCHAR, AA.fechaInicio, 103) + ' al ' + CONVERT(VARCHAR, AA.fechaFin, 103)) AS [Año Académico], " &
                "(P.nombre + ' ' + P.apePaterno) AS [Docente], " &
                "C.nombreCurso AS [Curso], " &
                "S.nombre AS [Seccion], " &
                "CA.diaSemana AS [Dia], " & ' 👈 Cambiado de H a CA
                "CONVERT(VARCHAR(5), CA.horaInicio, 108) AS [Inicio], " & ' 👈 Cambiado de H a CA
                "CONVERT(VARCHAR(5), CA.horaFin, 108) AS [Fin] " & ' 👈 Cambiado de H a CA
                "FROM CARGA_ACADEMICA CA " &
                "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
                "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
                "INNER JOIN ANO_ACADEMICO AA ON CA.id_anoAcademico = AA.id_anoAcademico " & ' 👈 JOIN directo súper rápido
                "WHERE CA.estado = 1 AND AA.id_anoAcademico = @idAno"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", idAno)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error histórico: " & ex.Message)
        Finally
            objConexion.desconectar() ' Aseguramos el cierre de conexión
        End Try
        Return dt
    End Function

    Public Function ObtenerEstudiantesPorTipo(tipoEstudiante As String) As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()

            ' Query relacional exacto cruzando ESTUDIANTE con PERSONA 🌟
            Dim query As String = "SELECT P.num_doc AS [DNI], " &
                                 "(P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno) AS [Estudiante], " &
                                 "P.sexo AS [Sexo], P.telefono AS [Teléfono], P.correo AS [Correo], " &
                                 "UPPER(E.tipoEstudiante) AS [Condición] " &
                                 "FROM ESTUDIANTE E " &
                                 "INNER JOIN PERSONA P ON E.id_persona = P.id_persona " &
                                 "WHERE P.vigencia = 1"

            ' FILTRO DINÁMICO: Si el combo no dice "TODOS", filtramos por la columna de la BD
            If tipoEstudiante <> "TODOS" AndAlso tipoEstudiante <> "" Then
                query &= " AND UPPER(E.tipoEstudiante) = @tipo"
            End If

            Dim cmd As New SqlCommand(query, objConexion.miConexion)

            If tipoEstudiante <> "TODOS" AndAlso tipoEstudiante <> "" Then
                cmd.Parameters.AddWithValue("@tipo", tipoEstudiante)
            End If

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al consultar estudiantes por tipo: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function
End Class
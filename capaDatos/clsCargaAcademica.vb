Imports System.Data.SqlClient

Public Class clsCargaAcademica
    Dim objConexion As New clsConectaBD()

    Public Function MostrarCargaAcademica() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT CA.id_carga AS ID, " &
                "P.apePaterno + ' ' + P.nombre AS Docente, " &
                "C.nombreCurso AS Curso, " &
                "G.nombre + ' - ' + S.nombre AS Seccion, " &
                "H.diaSemana + ' | ' + CONVERT(VARCHAR,H.horaInicio,108) + ' - ' + CONVERT(VARCHAR,H.horaFin,108) AS Horario, " &
                "CA.estado AS Estado " &
                "FROM CARGA_ACADEMICA CA " &
                "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
                "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
                "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
                "INNER JOIN HORARIO H ON CA.id_horario = H.id_horario"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al mostrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarCargaFiltrada(idDocente As Integer, idSeccion As Integer, idHorario As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT CA.id_carga AS ID, " &
                "P.apePaterno + ' ' + P.nombre AS Docente, " &
                "C.nombreCurso AS Curso, " &
                "G.nombre + ' - ' + S.nombre AS Seccion, " &
                "H.diaSemana + ' | ' + CONVERT(VARCHAR,H.horaInicio,108) + ' - ' + CONVERT(VARCHAR,H.horaFin,108) AS Horario, " &
                "CA.estado AS Estado " &
                "FROM CARGA_ACADEMICA CA " &
                "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
                "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
                "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
                "INNER JOIN HORARIO H ON CA.id_horario = H.id_horario " &
                "WHERE (@idDocente = 0 OR CA.id_docente = @idDocente) " &
                "AND (@idSeccion = 0 OR CA.id_seccion = @idSeccion) " &
                "AND (@idHorario = 0 OR CA.id_horario = @idHorario)" ' ¡Aquí cambiamos curso por horario!

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDocente", idDocente)
            cmd.Parameters.AddWithValue("@idSeccion", idSeccion)
            cmd.Parameters.AddWithValue("@idHorario", idHorario) ' ¡Y aquí el parámetro!

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al filtrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarDocentes() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT D.id_docente, P.apePaterno + ' ' + P.nombre AS nombre_completo " &
                "FROM DOCENTE D INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "WHERE D.estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarCursos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_curso, nombreCurso FROM CURSO WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar cursos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarSecciones() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT S.id_seccion, G.nombre + ' - ' + S.nombre AS nombre " &
                "FROM SECCION S " &
                "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
                "WHERE S.vigencia = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarHorarios() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT id_horario, " &
                "diaSemana + ' | ' + CONVERT(VARCHAR,horaInicio,108) + ' - ' + CONVERT(VARCHAR,horaFin,108) AS descripcion " &
                "FROM HORARIO WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar horarios: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub RegistrarCarga(id_docente As Integer, id_curso As Integer, id_seccion As Integer, id_horario As Integer)
        Try
            objConexion.conectar()
            Dim query As String =
                "INSERT INTO CARGA_ACADEMICA (id_docente, id_curso, id_seccion, id_horario, estado) " &
                "VALUES (@idDocente, @idCurso, @idSeccion, @idHorario, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDocente", id_docente)
            cmd.Parameters.AddWithValue("@idCurso", id_curso)
            cmd.Parameters.AddWithValue("@idSeccion", id_seccion)
            cmd.Parameters.AddWithValue("@idHorario", id_horario)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EditarCarga(id_carga As Integer, id_docente As Integer, id_curso As Integer, id_seccion As Integer, id_horario As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            Dim query As String =
                "UPDATE CARGA_ACADEMICA SET id_docente=@idDocente, id_curso=@idCurso, " &
                "id_seccion=@idSeccion, id_horario=@idHorario, estado=@estado " &
                "WHERE id_carga=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDocente", id_docente)
            cmd.Parameters.AddWithValue("@idCurso", id_curso)
            cmd.Parameters.AddWithValue("@idSeccion", id_seccion)
            cmd.Parameters.AddWithValue("@idHorario", id_horario)
            cmd.Parameters.AddWithValue("@estado", estado)
            cmd.Parameters.AddWithValue("@id", id_carga)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarCarga(id_carga As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "DELETE FROM CARGA_ACADEMICA WHERE id_carga = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_carga)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function VerificarCruceHorario(id_docente As Integer, id_horario As Integer, id_carga_excluir As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT COUNT(*) FROM CARGA_ACADEMICA " &
                "WHERE id_docente = @idDocente AND id_horario = @idHorario " &
                "AND id_carga <> @idExcluir AND estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDocente", id_docente)
            cmd.Parameters.AddWithValue("@idHorario", id_horario)
            cmd.Parameters.AddWithValue("@idExcluir", id_carga_excluir)
            resultado = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar cruce: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return resultado
    End Function

End Class
Imports System.Data.SqlClient

Public Class clsCargaAcademica
    Dim objConexion As New clsConectaBD()

    '--- AÑO ACADÉMICO ---
    Public Function MostrarAniosAcademicos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT id_anoAcademico, fechaInicio, fechaFin, estado " &
                "FROM ANO_ACADEMICO ORDER BY fechaInicio DESC"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar años: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    '--- CASCADA NIVEL > GRADO > SECCIÓN ---
    Public Function MostrarNiveles() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT id_nivel, nombre FROM NIVEL"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarGradosPorNivel(id_nivel As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT id_grado, nombre FROM GRADO WHERE id_nivel = @idNivel"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idNivel", id_nivel)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarSeccionesPorGrado(id_grado As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT id_seccion, nombre FROM SECCION " &
            "WHERE id_grado = @idGrado AND vigencia = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idGrado", id_grado)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    '--- ESPECIALIDAD Y DOCENTE ---
    Public Function MostrarEspecialidades() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT id_especialidad, nombre FROM ESPECIALIDAD WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar especialidades: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarDocentesPorEspecialidad(id_especialidad As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT D.id_docente, P.apePaterno + ' ' + P.nombre AS nombre_completo " &
                "FROM DOCENTE D " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "WHERE D.id_especialidad = @idEsp AND D.estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEsp", id_especialidad)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarTodosDocentes() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT D.id_docente, P.apePaterno + ' ' + P.nombre AS nombre_completo " &
                "FROM DOCENTE D " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
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

    '--- CURSOS ---
    Public Function MostrarCursos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT id_curso, nombreCurso FROM CURSO WHERE estado = 1"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar cursos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    '--- LISTADO PRINCIPAL ---
    Public Function MostrarCargaAcademica(id_anoAcademico As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT CA.id_carga AS ID, " &
            "P.apePaterno + ' ' + P.nombre AS Docente, " &
            "E.nombre AS Especialidad, " &
            "C.nombreCurso AS Curso, " &
            "N.nombre AS Nivel, " &
            "G.nombre AS Grado, " &
            "S.nombre AS Seccion, " &
            "CA.diaSemana AS Dia, " &
            "CONVERT(VARCHAR, CA.horaInicio, 108) AS Hora_Inicio, " &
            "CONVERT(VARCHAR, CA.horaFin, 108) AS Hora_Fin, " &
            "CASE WHEN CA.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM CARGA_ACADEMICA CA " &
            "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
            "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
            "INNER JOIN ESPECIALIDAD E ON D.id_especialidad = E.id_especialidad " &
            "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
            "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
            "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
            "INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel " &
            "WHERE CA.id_anoAcademico = @idAno"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", id_anoAcademico)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al mostrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function MostrarCargaFiltrada(id_anoAcademico As Integer, id_nivel As Integer,
                                      id_grado As Integer, id_seccion As Integer,
                                      id_especialidad As Integer, id_docente As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String =
            "SELECT CA.id_carga AS ID, " &
            "P.apePaterno + ' ' + P.nombre AS Docente, " &
            "E.nombre AS Especialidad, " &
            "C.nombreCurso AS Curso, " &
            "N.nombre AS Nivel, " &
            "G.nombre AS Grado, " &
            "S.nombre AS Seccion, " &
            "CA.diaSemana AS Dia, " &
            "CONVERT(VARCHAR, CA.horaInicio, 108) AS Hora_Inicio, " &
            "CONVERT(VARCHAR, CA.horaFin, 108) AS Hora_Fin, " &
            "CASE WHEN CA.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM CARGA_ACADEMICA CA " &
            "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
            "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
            "INNER JOIN ESPECIALIDAD E ON D.id_especialidad = E.id_especialidad " &
            "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
            "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
            "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
            "INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel " &
            "WHERE CA.id_anoAcademico = @idAno " &
            "AND (@idNivel = 0 OR G.id_nivel = @idNivel) " &
            "AND (@idSeccion = 0 OR CA.id_seccion = @idSeccion) " &
            "AND (@idEsp = 0 OR D.id_especialidad = @idEsp) " &
            "AND (@idDoc = 0 OR CA.id_docente = @idDoc)" &
            "AND (@idNivel = 0 OR G.id_nivel = @idNivel) " &
            "AND (@idGrado = 0 OR G.id_grado = @idGrado) " &
            "AND (@idSeccion = 0 OR CA.id_seccion = @idSeccion) " &
            "AND (@idEsp = 0 OR D.id_especialidad = @idEsp) " &
            "AND (@idDoc = 0 OR CA.id_docente = @idDoc)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", id_anoAcademico)
            cmd.Parameters.AddWithValue("@idNivel", id_nivel)
            cmd.Parameters.AddWithValue("@idGrado", id_grado)
            cmd.Parameters.AddWithValue("@idSeccion", id_seccion)
            cmd.Parameters.AddWithValue("@idEsp", id_especialidad)
            cmd.Parameters.AddWithValue("@idDoc", id_docente)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al filtrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    '--- CRUD ---
    Public Sub RegistrarCarga(id_docente As Integer, id_curso As Integer,
                               id_seccion As Integer, id_anoAcademico As Integer,
                               diaSemana As String, horaInicio As String, horaFin As String)
        Try
            objConexion.conectar()
            Dim query As String =
                "INSERT INTO CARGA_ACADEMICA " &
                "(id_docente, id_curso, id_seccion, id_anoAcademico, diaSemana, horaInicio, horaFin, estado) " &
                "VALUES (@idDoc, @idCur, @idSec, @idAno, @dia, @hIni, @hFin, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDoc", id_docente)
            cmd.Parameters.AddWithValue("@idCur", id_curso)
            cmd.Parameters.AddWithValue("@idSec", id_seccion)
            cmd.Parameters.AddWithValue("@idAno", id_anoAcademico)
            cmd.Parameters.AddWithValue("@dia", diaSemana)
            cmd.Parameters.AddWithValue("@hIni", horaInicio)
            cmd.Parameters.AddWithValue("@hFin", horaFin)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al registrar carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EditarCarga(id_carga As Integer, id_docente As Integer, id_curso As Integer,
                            id_seccion As Integer, diaSemana As String,
                            horaInicio As String, horaFin As String, estado As Boolean)
        Try
            objConexion.conectar()
            Dim query As String =
                "UPDATE CARGA_ACADEMICA SET " &
                "id_docente=@idDoc, id_curso=@idCur, id_seccion=@idSec, " &
                "diaSemana=@dia, horaInicio=@hIni, horaFin=@hFin, estado=@estado " &
                "WHERE id_carga=@id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDoc", id_docente)
            cmd.Parameters.AddWithValue("@idCur", id_curso)
            cmd.Parameters.AddWithValue("@idSec", id_seccion)
            cmd.Parameters.AddWithValue("@dia", diaSemana)
            cmd.Parameters.AddWithValue("@hIni", horaInicio)
            cmd.Parameters.AddWithValue("@hFin", horaFin)
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
            Dim query As String =
                "DELETE FROM CARGA_ACADEMICA WHERE id_carga = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_carga)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function VerificarCruce(id_docente As Integer, diaSemana As String,
                                    horaInicio As String, horaFin As String,
                                    id_carga_excluir As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            objConexion.conectar()
            Dim query As String =
                "SELECT COUNT(*) FROM CARGA_ACADEMICA " &
                "WHERE id_docente = @idDoc AND diaSemana = @dia AND estado = 1 " &
                "AND id_carga <> @excluir " &
                "AND ((@hIni >= horaInicio AND @hIni < horaFin) OR " &
                "     (@hFin > horaInicio AND @hFin <= horaFin))"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idDoc", id_docente)
            cmd.Parameters.AddWithValue("@dia", diaSemana)
            cmd.Parameters.AddWithValue("@hIni", horaInicio)
            cmd.Parameters.AddWithValue("@hFin", horaFin)
            cmd.Parameters.AddWithValue("@excluir", id_carga_excluir)
            resultado = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar cruce: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return resultado
    End Function

End Class
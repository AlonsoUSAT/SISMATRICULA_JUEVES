Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatConsultaMatriculas

    Dim objConexion As New clsConectaBD()

    Public Function ObtenerNiveles(idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT id_nivel, nombre 
            FROM NIVEL 
            WHERE id_anoAcademico = @idAno
            ORDER BY nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", idAno)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ObtenerGradosPorNivel(idNivel As Integer, idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT G.id_grado, G.nombre 
            FROM GRADO G
            INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel
            WHERE G.id_nivel = @idNivel
              AND N.id_anoAcademico = @idAno
            ORDER BY G.nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idNivel", idNivel)
            cmd.Parameters.AddWithValue("@idAno", idAno)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ObtenerSeccionesPorGrado(idGrado As Integer, idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT S.id_seccion, S.nombre
            FROM SECCION S
            INNER JOIN GRADO G ON S.id_grado = G.id_grado
            INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel
            WHERE S.id_grado = @idGrado
              AND N.id_anoAcademico = @idAno
            ORDER BY S.nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idGrado", idGrado)
            cmd.Parameters.AddWithValue("@idAno", idAno)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ConsultarMatriculas(idNivel As Integer,
                                        idGrado As Integer,
                                        idSeccion As Integer,
                                        ano As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
                SELECT
                    P.num_doc                                         AS DNI,
                    P.nombre + ' ' + P.apePaterno + ' '
                              + P.apeMaterno                          AS Estudiante,
                    N.nombre                                          AS Nivel,
                    G.nombre                                          AS Grado,
                    S.nombre                                          AS Seccion,
                    CONVERT(VARCHAR, M.fecha, 103)                    AS [Fecha Matrícula],
                    ISNULL(TB.descripcion, 'Sin beca')                AS Beca,
                    ISNULL(TB.porcentaje_descuento, 0)                AS [% Descuento]
                FROM MATRICULA M
                INNER JOIN ESTUDIANTE  E  ON M.id_estudiante = E.id_estudiante
                INNER JOIN PERSONA     P  ON E.id_persona    = P.id_persona
                INNER JOIN SECCION     S  ON M.id_seccion    = S.id_seccion
                INNER JOIN GRADO       G  ON S.id_grado      = G.id_grado
                INNER JOIN NIVEL       N  ON G.id_nivel      = N.id_nivel
                LEFT  JOIN ASIGNACION_BECA AB
                           ON E.id_estudiante = AB.id_estudiante
                          AND AB.estado = 'ACTIVA'
                LEFT  JOIN TIPO_BECA TB ON AB.id_tipo_beca = TB.id_tipo_beca
                WHERE M.estadoMatricula = 1
                  AND (@idNivel   = 0 OR N.id_nivel   = @idNivel)
                  AND (@idGrado   = 0 OR G.id_grado   = @idGrado)
                  AND (@idSeccion = 0 OR S.id_seccion = @idSeccion)
                  AND (@ano       = 0 OR YEAR(M.fecha) = @ano)
                ORDER BY N.nombre, G.nombre, S.nombre, P.apePaterno"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idNivel", idNivel)
            cmd.Parameters.AddWithValue("@idGrado", idGrado)
            cmd.Parameters.AddWithValue("@idSeccion", idSeccion)
            cmd.Parameters.AddWithValue("@ano", ano)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al consultar matrículas: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ObtenerResumen(idNivel As Integer,
                               idGrado As Integer,
                               idSeccion As Integer,
                               ano As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT
                COUNT(*)                                               AS total,
                SUM(CASE WHEN AB.id_estudiante IS NOT NULL
                         THEN 1 ELSE 0 END)                            AS becados,
                SUM(CASE WHEN AB.id_estudiante IS NULL
                         THEN 1 ELSE 0 END)                            AS noBecados
            FROM MATRICULA M
            INNER JOIN ESTUDIANTE E  ON M.id_estudiante = E.id_estudiante
            INNER JOIN SECCION    S  ON M.id_seccion    = S.id_seccion
            INNER JOIN GRADO      G  ON S.id_grado      = G.id_grado
            INNER JOIN NIVEL      N  ON G.id_nivel      = N.id_nivel
            LEFT  JOIN ASIGNACION_BECA AB
                       ON E.id_estudiante = AB.id_estudiante
                      AND AB.estado = 'ACTIVA'
            WHERE M.estadoMatricula = 1
              AND (@idNivel   = 0 OR N.id_nivel   = @idNivel)
              AND (@idGrado   = 0 OR G.id_grado   = @idGrado)
              AND (@idSeccion = 0 OR S.id_seccion = @idSeccion)
              AND (@ano       = 0 OR YEAR(M.fecha) = @ano)"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idNivel", idNivel)
            cmd.Parameters.AddWithValue("@idGrado", idGrado)
            cmd.Parameters.AddWithValue("@idSeccion", idSeccion)
            cmd.Parameters.AddWithValue("@ano", ano)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener resumen: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ObtenerAnoAcademicoActual() As Integer
        Dim resultado As Integer = 0
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT id_anoAcademico 
            FROM ANO_ACADEMICO 
            WHERE GETDATE() BETWEEN fechaInicio AND fechaFin
            AND estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            Dim valor = cmd.ExecuteScalar()
            If valor IsNot Nothing AndAlso Not IsDBNull(valor) Then
                resultado = Convert.ToInt32(valor)
            End If
        Catch ex As Exception
            Throw New Exception("Error al obtener año académico: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return resultado
    End Function

End Class
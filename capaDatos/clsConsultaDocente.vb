Imports System.Data
Imports System.Data.SqlClient

Public Class clsConsultaDocente

    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()

    ' ══════════════════════════════════════════════
    '  CARGAR NIVELES
    ' ══════════════════════════════════════════════
    Public Function ObtenerNiveles() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT DISTINCT N.id_nivel, N.nombre " &
                "FROM NIVEL N " &
                "INNER JOIN ANO_ACADEMICO A ON N.id_anoAcademico = A.id_anoAcademico " &
                "WHERE A.estado = 1 " &
                "ORDER BY N.nombre"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al obtener niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  CARGAR GRADOS POR NIVEL
    ' ══════════════════════════════════════════════
    Public Function ObtenerGrados(Optional id_nivel As Integer = 0) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            If id_nivel > 0 Then
                comando.CommandText =
                    "SELECT G.id_grado, G.nombre " &
                    "FROM GRADO G " &
                    "WHERE G.id_nivel = @id_nivel " &
                    "ORDER BY G.nombre"
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@id_nivel", id_nivel)
            Else
                comando.CommandText =
                    "SELECT G.id_grado, G.nombre FROM GRADO G ORDER BY G.nombre"
                comando.Parameters.Clear()
            End If
            comando.CommandType = CommandType.Text
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al obtener grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  CARGAR SECCIONES POR GRADO
    ' ══════════════════════════════════════════════
    Public Function ObtenerSecciones(Optional id_grado As Integer = 0) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            If id_grado > 0 Then
                comando.CommandText =
                    "SELECT S.id_seccion, S.nombre " &
                    "FROM SECCION S " &
                    "WHERE S.id_grado = @id_grado AND S.vigencia = 1 " &
                    "ORDER BY S.nombre"
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@id_grado", id_grado)
            Else
                comando.CommandText =
                    "SELECT S.id_seccion, S.nombre FROM SECCION S " &
                    "WHERE S.vigencia = 1 ORDER BY S.nombre"
                comando.Parameters.Clear()
            End If
            comando.CommandType = CommandType.Text
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al obtener secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  OBTENER AÑOS DE CARGA ACADÉMICA VIGENTE
    ' ══════════════════════════════════════════════
    Public Function ObtenerAnosAcademicos() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT DISTINCT YEAR(A.fechaInicio) AS ano " &
                "FROM ANO_ACADEMICO A " &
                "WHERE A.estado = 1 " &
                "ORDER BY ano DESC"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al obtener años: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  CONSULTAR DOCENTES (filtros opcionales)
    '  Un docente aparece si tiene CARGA_ACADEMICA
    '  en el nivel/grado/sección/año indicado
    ' ══════════════════════════════════════════════
    Public Function ConsultarDocentes(
            Optional dni As String = "",
            Optional id_nivel As Integer = 0,
            Optional id_grado As Integer = 0,
            Optional id_seccion As Integer = 0,
            Optional ano As String = "") As DataTable

        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.Parameters.Clear()

            Dim sql As String =
                "SELECT DISTINCT " &
                "    P.num_doc                                           AS [DNI], " &
                "    P.apePaterno + ' ' + P.apeMaterno + ', ' + P.nombre AS [Docente], " &
                "    P.apePaterno                                        AS [_apePat], " &
                "    P.apeMaterno                                        AS [_apeMat], " &
                "    P.nombre                                            AS [_nombre], " &
                "    D.especialidad                                      AS [Especialidad], " &
                "    P.correo                                            AS [Correo], " &
                "    P.telefono                                          AS [Teléfono], " &
                "    N.nombre                                            AS [Nivel], " &
                "    G.nombre                                            AS [Grado], " &
                "    S.nombre                                            AS [Sección], " &
                "    CU.nombreCurso                                      AS [Curso], " &
                "    CASE WHEN D.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS [Estado] " &
                "FROM CARGA_ACADEMICA CA " &
                "INNER JOIN DOCENTE D    ON CA.id_docente  = D.id_docente " &
                "INNER JOIN PERSONA P    ON D.id_persona   = P.id_persona " &
                "INNER JOIN CURSO CU     ON CA.id_curso    = CU.id_curso " &
                "INNER JOIN SECCION S    ON CA.id_seccion  = S.id_seccion " &
                "INNER JOIN GRADO G      ON S.id_grado     = G.id_grado " &
                "INNER JOIN NIVEL N      ON G.id_nivel     = N.id_nivel " &
                "INNER JOIN ANO_ACADEMICO A ON N.id_anoAcademico = A.id_anoAcademico " &
                "WHERE CA.estado = 1 AND D.estado = 1 "

            If Not String.IsNullOrWhiteSpace(dni) Then
                sql &= "AND P.num_doc LIKE @dni "
                comando.Parameters.AddWithValue("@dni", "%" & dni.Trim() & "%")
            End If

            If id_nivel > 0 Then
                sql &= "AND N.id_nivel = @id_nivel "
                comando.Parameters.AddWithValue("@id_nivel", id_nivel)
            End If

            If id_grado > 0 Then
                sql &= "AND G.id_grado = @id_grado "
                comando.Parameters.AddWithValue("@id_grado", id_grado)
            End If

            If id_seccion > 0 Then
                sql &= "AND S.id_seccion = @id_seccion "
                comando.Parameters.AddWithValue("@id_seccion", id_seccion)
            End If

            If Not String.IsNullOrWhiteSpace(ano) Then
                sql &= "AND YEAR(A.fechaInicio) = @ano "
                comando.Parameters.AddWithValue("@ano", ano.Trim())
            End If

            sql &= "ORDER BY [_apePat], [_apeMat], [_nombre]"

            comando.CommandText = sql
            comando.CommandType = CommandType.Text

            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al consultar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

End Class
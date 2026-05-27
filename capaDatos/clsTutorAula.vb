Imports System.Data
Imports System.Data.SqlClient

Public Class clsTutorAula
    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Dim sig As Integer = 0
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT ISNULL(MAX(id_tutor), 0) + 1 FROM TUTOR_AULA"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            sig = CInt(comando.ExecuteScalar())
        Catch ex As SqlException
            Throw New Exception("Error BD al obtener ID: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return sig
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR TODOS (JOIN Docente+Persona y Seccion)
    ' ══════════════════════════════════════════════
    Public Function MostrarPorDocente(idDocente As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT TA.id_tutor, " &
                "P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS NombreDocente, " &
                "N.nombre AS NombreNivel, " &
                "G.nombre AS NombreGrado, " &
                "S.nombre AS NombreSeccion, " &
                "TA.id_docente, TA.id_seccion, TA.estado " &
                "FROM TUTOR_AULA TA " &
                "INNER JOIN DOCENTE D   ON TA.id_docente  = D.id_docente " &
                "INNER JOIN PERSONA P   ON D.id_persona   = P.id_persona " &
                "INNER JOIN SECCION S   ON TA.id_seccion  = S.id_seccion " &
                "INNER JOIN GRADO   G   ON S.id_grado     = G.id_grado " &
                "INNER JOIN NIVEL   N   ON G.id_nivel     = N.id_nivel " &
                "WHERE TA.id_docente = @idDocente"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idDocente", idDocente)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al buscar por docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function Mostrar() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT TA.id_tutor, " &
                "P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS NombreDocente, " &
                "N.nombre AS NombreNivel, " &
                "G.nombre AS NombreGrado, " &
                "S.nombre AS NombreSeccion, " &
                "TA.id_docente, TA.id_seccion, TA.estado " &
                "FROM TUTOR_AULA TA " &
                "INNER JOIN DOCENTE D   ON TA.id_docente  = D.id_docente " &
                "INNER JOIN PERSONA P   ON D.id_persona   = P.id_persona " &
                "INNER JOIN SECCION S   ON TA.id_seccion  = S.id_seccion " &
                "INNER JOIN GRADO   G   ON S.id_grado     = G.id_grado " &
                "INNER JOIN NIVEL   N   ON G.id_nivel     = N.id_nivel"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al mostrar tutores: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR POR ID
    ' ══════════════════════════════════════════════
    Public Function BuscarPorID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT TA.id_tutor, TA.id_docente, TA.id_seccion, TA.estado, " &
                "P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS NombreDocente, " &
                "S.nombre AS NombreSeccion, " &
                "G.id_grado, G.nombre AS NombreGrado, " &
                "N.id_nivel, N.nombre AS NombreNivel " &
                "FROM TUTOR_AULA TA " &
                "INNER JOIN DOCENTE D   ON TA.id_docente  = D.id_docente " &
                "INNER JOIN PERSONA P   ON D.id_persona   = P.id_persona " &
                "INNER JOIN SECCION S   ON TA.id_seccion  = S.id_seccion " &
                "INNER JOIN GRADO   G   ON S.id_grado     = G.id_grado " &
                "INNER JOIN NIVEL   N   ON G.id_nivel     = N.id_nivel " &
                "WHERE TA.id_tutor = @id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al buscar tutor: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR DOCENTES POR NOMBRE (para TextBox búsqueda)
    ' ══════════════════════════════════════════════
    Public Function BuscarDocentes(texto As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT D.id_docente, " &
                "P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS NombreCompleto " &
                "FROM DOCENTE D " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "WHERE D.estado = 1 " &
                "AND (P.nombre LIKE @texto OR P.apePaterno LIKE @texto OR P.apeMaterno LIKE @texto " &
                "     OR (P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno) LIKE @texto)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@texto", "%" & texto.Trim() & "%")
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al buscar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR DOCENTES ACTIVOS PARA COMBOBOX
    ' ══════════════════════════════════════════════
    Public Function ListarDocentes() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT D.id_docente, " &
                "P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS NombreCompleto " &
                "FROM DOCENTE D " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                "WHERE D.estado = 1 " &
                "ORDER BY P.apePaterno, P.apeMaterno, P.nombre"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al listar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR NIVELES PARA COMBOBOX
    ' ══════════════════════════════════════════════
    Public Function ListarNiveles() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT id_nivel, nombre FROM NIVEL ORDER BY nombre"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al listar niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR GRADOS POR NIVEL PARA COMBOBOX
    ' ══════════════════════════════════════════════
    Public Function ListarGradosPorNivel(idNivel As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT id_grado, nombre FROM GRADO " &
                "WHERE id_nivel = @idNivel ORDER BY nombre"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idNivel", idNivel)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al listar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  LISTAR SECCIONES POR GRADO PARA COMBOBOX
    ' ══════════════════════════════════════════════
    Public Function ListarSeccionesPorGrado(idGrado As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT id_seccion, nombre FROM SECCION " &
                "WHERE id_grado = @idGrado AND vigencia = 1 ORDER BY nombre"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idGrado", idGrado)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error BD al listar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  INSERTAR
    ' ══════════════════════════════════════════════
    Public Sub Insertar(idDocente As Integer, idSeccion As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "INSERT INTO TUTOR_AULA (id_docente, id_seccion, estado) " &
                "VALUES (@idDocente, @idSeccion, @estado)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idDocente", idDocente)
            comando.Parameters.AddWithValue("@idSeccion", idSeccion)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error BD al insertar tutor: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ACTUALIZAR
    ' ══════════════════════════════════════════════
    Public Sub Actualizar(id As Integer, idDocente As Integer, idSeccion As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "UPDATE TUTOR_AULA SET id_docente=@idDocente, id_seccion=@idSeccion, estado=@estado " &
                "WHERE id_tutor=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@idDocente", idDocente)
            comando.Parameters.AddWithValue("@idSeccion", idSeccion)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error BD al actualizar tutor: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA (estado → False)
    ' ══════════════════════════════════════════════
    Public Sub DarBaja(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE TUTOR_AULA SET estado=0 WHERE id_tutor=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error BD al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR FÍSICO
    ' ══════════════════════════════════════════════
    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "DELETE FROM TUTOR_AULA WHERE id_tutor=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error BD al eliminar tutor: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  VERIFICAR SI YA EXISTE ESA COMBINACIÓN
    ' ══════════════════════════════════════════════
    Public Function YaExiste(idDocente As Integer, idSeccion As Integer,
                              Optional idExcluir As Integer = 0) As Boolean
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT COUNT(*) FROM TUTOR_AULA " &
                "WHERE id_docente=@idDocente AND id_seccion=@idSeccion AND id_tutor<>@idExcluir"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idDocente", idDocente)
            comando.Parameters.AddWithValue("@idSeccion", idSeccion)
            comando.Parameters.AddWithValue("@idExcluir", idExcluir)
            Return CInt(comando.ExecuteScalar()) > 0
        Catch ex As SqlException
            Throw New Exception("Error BD al verificar duplicado: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

End Class
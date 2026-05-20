Imports System.Data
Imports System.Data.SqlClient

Public Class clsDocente

    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()

    ' ══════════════════════════════════════════════
    '  OBTENER SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 0
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT ISNULL(MAX(id_docente), 0) + 1 FROM DOCENTE"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            siguienteID = CInt(comando.ExecuteScalar())
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al obtener el siguiente ID: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al obtener el siguiente ID: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return siguienteID
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR TODOS LOS DOCENTES (JOIN con PERSONA)
    ' ══════════════════════════════════════════════
    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT D.id_docente, D.especialidad, D.estado, " &
                "P.id_persona, P.nombre, P.apePaterno, P.apeMaterno, " &
                "P.telefono, P.correo, P.sexo " &
                "FROM DOCENTE D " &
                "INNER JOIN PERSONA P ON D.id_persona = P.id_persona"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al mostrar docentes: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al mostrar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  OBTENER PERSONAS DISPONIBLES
    '  Solo activas que aún no son docentes activos
    ' ══════════════════════════════════════════════
    Public Function ObtenerPersonas() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT id_persona, " &
                "nombre + ' ' + apePaterno + ' ' + apeMaterno AS nombreCompleto " &
                "FROM PERSONA " &
                "WHERE estado = 1 " &
                "AND id_persona NOT IN (SELECT id_persona FROM DOCENTE WHERE estado = 1)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al obtener personas: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al obtener personas: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  OBTENER PERSONAS PARA EDICIÓN
    '  Incluye la persona ya asignada al docente actual
    ' ══════════════════════════════════════════════
    Public Function ObtenerPersonasParaEdicion(idPersonaActual As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT id_persona, " &
                "nombre + ' ' + apePaterno + ' ' + apeMaterno AS nombreCompleto " &
                "FROM PERSONA " &
                "WHERE estado = 1 " &
                "AND (id_persona NOT IN (SELECT id_persona FROM DOCENTE WHERE estado = 1) " &
                "     OR id_persona = @idPersonaActual)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idPersonaActual", idPersonaActual)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al obtener personas para edición: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al obtener personas para edición: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  INSERTAR DOCENTE
    ' ══════════════════════════════════════════════
    Public Sub Insertar(especialidad As String, idPersona As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "INSERT INTO DOCENTE (especialidad, id_persona, estado) " &
                "VALUES (@especialidad, @idPersona, @estado)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@especialidad", especialidad)
            comando.Parameters.AddWithValue("@idPersona", idPersona)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al insertar docente: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al insertar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR DOCENTE
    ' ══════════════════════════════════════════════
    Public Sub Editar(id As Integer, especialidad As String, idPersona As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "UPDATE DOCENTE SET especialidad=@especialidad, id_persona=@idPersona, estado=@estado " &
                "WHERE id_docente=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@especialidad", especialidad)
            comando.Parameters.AddWithValue("@idPersona", idPersona)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al editar docente: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al editar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA (cambia estado a False)
    ' ══════════════════════════════════════════════
    Public Sub DarBaja(id As Integer, estado As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE DOCENTE SET estado=@estado WHERE id_docente=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al dar de baja: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR DOCENTE FÍSICAMENTE
    ' ══════════════════════════════════════════════
    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "DELETE FROM DOCENTE WHERE id_docente=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al eliminar docente: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al eliminar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  VERIFICAR SI DOCENTE TIENE RELACIONES ACTIVAS
    '  Revisa TUTOR_AULA y CARGA_ACADEMICA
    ' ══════════════════════════════════════════════
    Public Function TieneRelaciones(id As Integer) As Boolean
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT " &
                "(SELECT COUNT(*) FROM TUTOR_AULA WHERE id_docente = @id) + " &
                "(SELECT COUNT(*) FROM CARGA_ACADEMICA WHERE id_docente = @id2)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@id2", id)
            Dim total As Integer = CInt(comando.ExecuteScalar())
            Return total > 0
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al verificar relaciones: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al verificar relaciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  VERIFICAR SI UNA PERSONA YA ES DOCENTE
    ' ══════════════════════════════════════════════
    Public Function PersonaYaEsDocente(idPersona As Integer, Optional idExcluir As Integer = 0) As Boolean
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT COUNT(*) FROM DOCENTE " &
                "WHERE id_persona = @idPersona AND id_docente <> @idExcluir"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@idPersona", idPersona)
            comando.Parameters.AddWithValue("@idExcluir", idExcluir)
            Return CInt(comando.ExecuteScalar()) > 0
        Catch ex As SqlException
            Throw New Exception("Error de base de datos al verificar persona duplicada: " & ex.Message)
        Catch ex As Exception
            Throw New Exception("Error inesperado al verificar persona duplicada: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

End Class

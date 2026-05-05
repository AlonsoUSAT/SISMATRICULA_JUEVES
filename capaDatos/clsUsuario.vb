Imports System.Data
Imports System.Data.SqlClient

Public Class clsUsuario

    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()

    ' ══════════════════════════════════════════════
    '  OBTENER SIGUIENTE ID (para mostrar en txtCodigo)
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 0
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT ISNULL(MAX(codusuario), 0) + 1 FROM USUARIO"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            siguienteID = CInt(comando.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al obtener siguiente ID: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return siguienteID
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR TODOS LOS USUARIOS
    ' ══════════════════════════════════════════════
    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            ' No mostramos la clave por seguridad
            comando.CommandText = "SELECT codusuario, nombres, apellidopaterno, apellidomaterno, " &
                                  "correo, sexo, estado, nomusuario, pregunta, respuesta FROM USUARIO"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al mostrar usuarios: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  INSERTAR USUARIO (clave ya viene encriptada desde lógica)
    ' ══════════════════════════════════════════════
    Public Sub Insertar(nombres As String, apellidoPaterno As String, apellidoMaterno As String,
                        correo As String, sexo As Char, claveHash As String,
                        estado As Boolean, nomUsuario As String,
                        pregunta As String, respuesta As String)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "INSERT INTO USUARIO (nombres, apellidopaterno, apellidomaterno, correo, sexo, " &
                "clave, estado, nomusuario, pregunta, respuesta) " &
                "VALUES (@nombres, @apPat, @apMat, @correo, @sexo, @clave, @estado, @nomUsu, @preg, @resp)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@nombres", nombres)
            comando.Parameters.AddWithValue("@apPat", apellidoPaterno)
            comando.Parameters.AddWithValue("@apMat", If(String.IsNullOrWhiteSpace(apellidoMaterno), DBNull.Value, apellidoMaterno))
            comando.Parameters.AddWithValue("@correo", If(String.IsNullOrWhiteSpace(correo), DBNull.Value, correo))
            comando.Parameters.AddWithValue("@sexo", sexo)
            comando.Parameters.AddWithValue("@clave", claveHash)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.Parameters.AddWithValue("@nomUsu", If(String.IsNullOrWhiteSpace(nomUsuario), DBNull.Value, nomUsuario))
            comando.Parameters.AddWithValue("@preg", If(String.IsNullOrWhiteSpace(pregunta), DBNull.Value, pregunta))
            comando.Parameters.AddWithValue("@resp", If(String.IsNullOrWhiteSpace(respuesta), DBNull.Value, respuesta))
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar usuario: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR USUARIO
    '  Si claveHash viene vacía, NO se actualiza la clave
    ' ══════════════════════════════════════════════
    Public Sub Editar(id As Integer, nombres As String, apellidoPaterno As String,
                      apellidoMaterno As String, correo As String, sexo As Char,
                      claveHash As String, estado As Boolean, nomUsuario As String,
                      pregunta As String, respuesta As String)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.Parameters.Clear()

            ' Si se envió nueva clave, se actualiza; si no, se conserva la anterior
            If Not String.IsNullOrWhiteSpace(claveHash) Then
                comando.CommandText =
                    "UPDATE USUARIO SET nombres=@nombres, apellidopaterno=@apPat, apellidomaterno=@apMat, " &
                    "correo=@correo, sexo=@sexo, clave=@clave, estado=@estado, " &
                    "nomusuario=@nomUsu, pregunta=@preg, respuesta=@resp " &
                    "WHERE codusuario=@id"
                comando.Parameters.AddWithValue("@clave", claveHash)
            Else
                comando.CommandText =
                    "UPDATE USUARIO SET nombres=@nombres, apellidopaterno=@apPat, apellidomaterno=@apMat, " &
                    "correo=@correo, sexo=@sexo, estado=@estado, " &
                    "nomusuario=@nomUsu, pregunta=@preg, respuesta=@resp " &
                    "WHERE codusuario=@id"
            End If

            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@nombres", nombres)
            comando.Parameters.AddWithValue("@apPat", apellidoPaterno)
            comando.Parameters.AddWithValue("@apMat", If(String.IsNullOrWhiteSpace(apellidoMaterno), DBNull.Value, apellidoMaterno))
            comando.Parameters.AddWithValue("@correo", If(String.IsNullOrWhiteSpace(correo), DBNull.Value, correo))
            comando.Parameters.AddWithValue("@sexo", sexo)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.Parameters.AddWithValue("@nomUsu", If(String.IsNullOrWhiteSpace(nomUsuario), DBNull.Value, nomUsuario))
            comando.Parameters.AddWithValue("@preg", If(String.IsNullOrWhiteSpace(pregunta), DBNull.Value, pregunta))
            comando.Parameters.AddWithValue("@resp", If(String.IsNullOrWhiteSpace(respuesta), DBNull.Value, respuesta))
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar usuario: " & ex.Message)
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
            comando.CommandText = "UPDATE USUARIO SET estado=@estado WHERE codusuario=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR USUARIO
    ' ══════════════════════════════════════════════
    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "DELETE FROM USUARIO WHERE codusuario=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar usuario: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  VERIFICAR SI CORREO O NOMUSUARIO YA EXISTEN
    '  (para validar duplicados antes de insertar/editar)
    ' ══════════════════════════════════════════════
    Public Function ExisteCorreo(correo As String, Optional idExcluir As Integer = 0) As Boolean
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT COUNT(*) FROM USUARIO WHERE correo=@correo AND codusuario<>@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@id", idExcluir)
            Return CInt(comando.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar correo: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function ExisteNomUsuario(nomUsuario As String, Optional idExcluir As Integer = 0) As Boolean
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT COUNT(*) FROM USUARIO WHERE nomusuario=@nomUsu AND codusuario<>@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@nomUsu", nomUsuario)
            comando.Parameters.AddWithValue("@id", idExcluir)
            Return CInt(comando.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar nombre de usuario: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


    ' ══════════════════════════════════════════════
    '  OBTENER DATOS DE LOGIN (devuelve fila del usuario si existe y está activo)
    ' ══════════════════════════════════════════════
    Public Function ObtenerUsuarioLogin(nomUsuario As String) As DataRow
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText =
                "SELECT codusuario, clave, estado, pregunta, respuesta " &
                "FROM USUARIO WHERE nomusuario = @nomUsu"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@nomUsu", nomUsuario)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
            If tabla.Rows.Count > 0 Then
                Return tabla.Rows(0)
            End If
            Return Nothing
        Catch ex As Exception
            Throw New Exception("Error al obtener usuario: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

End Class
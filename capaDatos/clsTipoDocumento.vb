Imports System.Data
Imports System.Data.SqlClient

Public Class clsTipoDocumento
    Private objConexion As New clsConectaBD()

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 0
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT ISNULL(MAX(id_tipoDocumento), 0) + 1 FROM TIPO_DOCUMENTO"
            comando.CommandType = CommandType.Text
            siguienteID = CInt(comando.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al obtener el siguiente ID: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
        Return siguienteID
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR TODOS
    ' ══════════════════════════════════════════════
    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable()
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT id_tipoDocumento, nombreTipoDocumento, estado FROM TIPO_DOCUMENTO"
            comando.CommandType = CommandType.Text
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al mostrar registros: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR POR ID
    ' ══════════════════════════════════════════════
    Public Function BuscarPorID(id As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT id_tipoDocumento, nombreTipoDocumento, estado " &
                                  "FROM TIPO_DOCUMENTO WHERE id_tipoDocumento = @id"
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@id", id)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al buscar registro: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' ══════════════════════════════════════════════
    '  INSERTAR
    ' ══════════════════════════════════════════════
    Public Sub Insertar(tipo_doc As String, vig As Boolean)
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "INSERT INTO TIPO_DOCUMENTO (nombreTipoDocumento, estado) " &
                                  "VALUES (@tipo_doc, @vig)"
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@tipo_doc", tipo_doc)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR
    ' ══════════════════════════════════════════════
    Public Sub Editar(id As Integer, tipo_doc As String, vig As Boolean)
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE TIPO_DOCUMENTO SET nombreTipoDocumento=@tipo_doc, " &
                                  "estado=@vig WHERE id_tipoDocumento=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@tipo_doc", tipo_doc)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA (estado → 0)
    ' ══════════════════════════════════════════════
    Public Sub DarBaja(id As Integer)
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE TIPO_DOCUMENTO SET estado=0 WHERE id_tipoDocumento=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR (verifica dependencias primero)
    ' ══════════════════════════════════════════════
    Public Sub Eliminar(id As Integer)
        Try
            Dim comando As New SqlCommand()
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandType = CommandType.Text
            comando.Parameters.AddWithValue("@id", id)

            ' Verificar si hay personas usando este tipo
            comando.CommandText = "SELECT COUNT(*) FROM PERSONA WHERE id_tipoDocumento = @id"
            Dim relacionados As Integer = CInt(comando.ExecuteScalar())

            If relacionados > 0 Then
                Throw New Exception("No se puede eliminar: existen " & relacionados &
                                    " persona(s) registradas con este tipo de documento.")
            End If

            comando.CommandText = "DELETE FROM TIPO_DOCUMENTO WHERE id_tipoDocumento = @id"
            comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

End Class
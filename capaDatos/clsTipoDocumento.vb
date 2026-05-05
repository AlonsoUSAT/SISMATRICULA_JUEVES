Imports System.Data
Imports System.Data.SqlClient

Public Class clsTipoDocumento
    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()


    Public Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 0
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            ' Calcula el próximo valor que asignará el IDENTITY de SQL Server
            comando.CommandText = "SELECT ISNULL(MAX(id_tipoDocumento), 0) + 1 FROM TIPO_DOCUMENTO"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            siguienteID = CInt(comando.ExecuteScalar())
        Catch ex As Exception
            Throw New Exception("Error al obtener el siguiente ID: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return siguienteID
    End Function

    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar() ' Usamos tu método para abrir la conexión
            comando.Connection = objConexion.miConexion ' Obtenemos la propiedad que retorna el SqlConnection
            comando.CommandText = "SELECT * FROM TIPO_DOCUMENTO"
            comando.CommandType = CommandType.Text
            Dim leer As SqlDataReader = comando.ExecuteReader()
            tabla.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al mostrar registros: " & ex.Message)
        Finally
            objConexion.desconectar() ' Usamos tu método para cerrar, asegurando que siempre pase por aquí
        End Try
        Return tabla
    End Function


    Public Sub Insertar(tipo_doc As String, vig As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "INSERT INTO TIPO_DOCUMENTO (nombreTipoDocumento, estado) VALUES (@tipo_Doc, @vig)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@tipo_doc", tipo_doc)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar capa datos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub


    Public Sub Editar(id As Integer, tipo_doc As String, vig As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE TIPO_DOCUMENTO set nombreTipoDocumento=@tipo_doc, estado=@vig where id_tipoDocumento=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@tipo_doc", tipo_doc)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar campos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub


    Public Sub DarBaja(id As Integer, vig As Boolean)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE TIPO_DOCUMENTO set estado=@vig where id_tipoDocumento=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub


    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)

            ' 1. Primero verificamos si hay personas usando este tipo de documento
            comando.CommandText = "SELECT COUNT(*) FROM PERSONA WHERE id_tipoDocumento = @id"
            Dim relacionados As Integer = CInt(comando.ExecuteScalar())

            ' 2. Lógica de decisión
            If relacionados > 0 Then
                ' Si hay al menos 1, lanzamos un mensaje amigable en lugar de un error de sistema
                Throw New Exception("No se puede eliminar: existen " & relacionados & " personas registradas con este tipo de documento.")
            Else
                ' Si no hay nadie relacionado, procedemos al borrado
                comando.CommandText = "DELETE FROM TIPO_DOCUMENTO WHERE id_tipoDocumento = @id"
                comando.ExecuteNonQuery()
            End If

        Catch ex As Exception
            ' Aquí capturamos tanto el error de validación como cualquier error de SQL
            Throw New Exception(ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub





End Class


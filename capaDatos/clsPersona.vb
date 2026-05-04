Imports System.Data
Imports System.Data.SqlClient

Public Class clsPersona
    ' Instanciamos TU clase de conexión
    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()

    ' Mostrar
    Public Function Mostrar() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar() ' Usamos tu método para abrir la conexión
            comando.Connection = objConexion.miConexion ' Obtenemos la propiedad que retorna el SqlConnection
            comando.CommandText = "SELECT * FROM PERSONA"
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

    ' Insertar
    Public Sub Insertar(apeMat As String, apePat As String, nom As String, tel As String, cor As String, vig As Boolean, tip As String, id_doc As Integer, sex As String)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "INSERT INTO PERSONA (apeMaterno, apePaterno, nombre, telefono, correo, vigencia, tipo, id_tipoDocumento, sexo) VALUES (@apeMat, @apePat, @nom, @tel, @cor, @vig, @tip, @id_doc, @sex)"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@apeMat", apeMat)
            comando.Parameters.AddWithValue("@apePat", apePat)
            comando.Parameters.AddWithValue("@nom", nom)
            comando.Parameters.AddWithValue("@tel", tel)
            comando.Parameters.AddWithValue("@cor", cor)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.Parameters.AddWithValue("@tip", tip)
            comando.Parameters.AddWithValue("@id_doc", id_doc)
            comando.Parameters.AddWithValue("@sex", sex)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' Editar
    Public Sub Editar(id As Integer, apeMat As String, apePat As String, nom As String, tel As String, cor As String, vig As Boolean, tip As String, id_doc As Integer, sex As String)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "UPDATE PERSONA SET apeMaterno=@apeMat, apePaterno=@apePat, nombre=@nom, telefono=@tel, correo=@cor, vigencia=@vig, tipo=@tip, id_tipoDocumento=@id_doc, sexo=@sex WHERE id_persona=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@apeMat", apeMat)
            comando.Parameters.AddWithValue("@apePat", apePat)
            comando.Parameters.AddWithValue("@nom", nom)
            comando.Parameters.AddWithValue("@tel", tel)
            comando.Parameters.AddWithValue("@cor", cor)
            comando.Parameters.AddWithValue("@vig", vig)
            comando.Parameters.AddWithValue("@tip", tip)
            comando.Parameters.AddWithValue("@id_doc", id_doc)
            comando.Parameters.AddWithValue("@sex", sex)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al editar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' Eliminar
    Public Sub Eliminar(id As Integer)
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "DELETE FROM PERSONA WHERE id_persona=@id"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id", id)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub
End Class
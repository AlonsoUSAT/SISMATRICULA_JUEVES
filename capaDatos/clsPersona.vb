Imports System.Data.SqlClient

Public Class clsPersona
    ' Instanciamos tu clase de conexión
    Dim objConexion As New clsConectaBD()

    Public Sub RegistrarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            objConexion.conectar()

            ' Se asume que id_persona es auto-incremental. 
            ' vigencia = 1 (Activo), tipo = 'APODERADO', id_tipoDocumento = 1 (Ej. DNI)
            Dim query As String = "INSERT INTO persona (apeMaterno, apePaterno, nombre, telefono, correo, vigencia, tipo, id_tipoDocumento, sexo, num_doc) " &
                                  "VALUES (@apeMaterno, @apePaterno, @nombre, @telefono, @correo, 1, 'APODERADO', 1, @sexo, @num_doc)"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeMaterno", apeMaterno)
            cmd.Parameters.AddWithValue("@apePaterno", apePaterno)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@num_doc", num_doc)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al registrar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function MostrarPersonas() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT apePaterno + ' ' + apeMaterno as Apellidos, nombre as Nombres, num_doc as Numero_Documento, 
                                    telefono as Telefono, correo as Correo, sexo as Sexo, vigencia as Vigencia
                                    FROM persona WHERE tipo = 'APODERADO'"
            Dim adapter As New SqlClient.SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function



    Public Sub EditarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            objConexion.conectar()
            ' Se actualiza usando num_doc en el WHERE
            Dim query As String = "UPDATE persona SET apeMaterno=@apeM, apePaterno=@apeP, nombre=@nom, telefono=@tel, correo=@cor, sexo=@sex WHERE num_doc=@doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeM", apeMaterno)
            cmd.Parameters.AddWithValue("@apeP", apePaterno)
            cmd.Parameters.AddWithValue("@nom", nombre)
            cmd.Parameters.AddWithValue("@tel", telefono)
            cmd.Parameters.AddWithValue("@cor", correo)
            cmd.Parameters.AddWithValue("@sex", sexo)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarPersona(num_doc As String)
        Try
            objConexion.conectar()
            ' Se elimina usando el número de documento como identificador
            Dim query As String = "DELETE FROM persona WHERE num_doc = @doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaPersona(num_doc As String)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE persona SET vigencia = 0 WHERE num_doc = @doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

End Class
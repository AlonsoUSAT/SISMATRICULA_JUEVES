Imports capaDatos

Public Class clPersona
    Private objDatos As New clsPersona()

    Public Function MostrarPersonas() As DataTable
        Dim tabla As New DataTable()
        tabla = objDatos.Mostrar()
        Return tabla
    End Function

    Public Sub InsertarPersona(apeMat As String, apePat As String, nom As String, tel As String, cor As String, vig As Boolean, tip As String, id_doc As Integer, sex As String)
        objDatos.Insertar(apeMat, apePat, nom, tel, cor, vig, tip, id_doc, sex)
    End Sub

    Public Sub EditarPersona(id As Integer, apeMat As String, apePat As String, nom As String, tel As String, cor As String, vig As Boolean, tip As String, id_doc As Integer, sex As String)
        objDatos.Editar(id, apeMat, apePat, nom, tel, cor, vig, tip, id_doc, sex)
    End Sub

    Public Sub EliminarPersona(id As Integer)
        objDatos.Eliminar(id)
    End Sub
End Class
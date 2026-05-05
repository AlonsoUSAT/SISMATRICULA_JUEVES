Imports capaDatos

Public Class clsTipoDocumento
    Private obj As New capaDatos.clsTipoDocumento()

    Public Function MostrarDocumentos() As DataTable
        Dim tabla As New DataTable()
        tabla = obj.Mostrar()
        Return tabla
    End Function

    Public Function ObtenerSiguienteID() As Integer
        Return obj.ObtenerSiguienteID()
    End Function

    Public Sub InsertarDocumento(tipo_doc As String, vigencia As Boolean)
        obj.Insertar(tipo_doc, vigencia)
    End Sub

    Public Sub EditarDocumento(id As Integer, tipo_doc As String, vigencia As Boolean)
        obj.Editar(id, tipo_doc, vigencia)
    End Sub

    Public Sub DarBajaDocumento(id As Integer, vigencia As Boolean)
        obj.DarBaja(id, vigencia)
    End Sub

    Public Sub EliminarDocumento(id As Integer)
        obj.Eliminar(id)
    End Sub

End Class


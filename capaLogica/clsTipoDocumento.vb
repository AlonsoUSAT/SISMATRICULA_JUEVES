Imports capaDatos
Imports System.Data

Public Class clsTipoDocumento
    Private obj As New capaDatos.clsTipoDocumento()

    ' ══════════════════════════════════════════════
    '  VALIDACIÓN INTERNA
    ' ══════════════════════════════════════════════
    Private Sub ValidarTipoDoc(tipo_doc As String)
        If String.IsNullOrWhiteSpace(tipo_doc) Then
            Throw New Exception("El nombre del tipo de documento no puede estar vacío.")
        End If
        If tipo_doc.Trim().Length < 3 Then
            Throw New Exception("El nombre debe tener al menos 3 caracteres.")
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  MOSTRAR
    ' ══════════════════════════════════════════════
    Public Function MostrarDocumentos() As DataTable
        Return obj.Mostrar()
    End Function

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Return obj.ObtenerSiguienteID()
    End Function

    ' ══════════════════════════════════════════════
    '  BUSCAR POR ID
    ' ══════════════════════════════════════════════
    Public Function BuscarPorID(id As Integer) As DataTable
        If id <= 0 Then Throw New Exception("Ingrese un código válido para buscar.")
        Dim dt As DataTable = obj.BuscarPorID(id)
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se encontró ningún registro con ese código.")
        End If
        Return dt
    End Function

    ' ══════════════════════════════════════════════
    '  INSERTAR
    ' ══════════════════════════════════════════════
    Public Sub InsertarDocumento(tipo_doc As String, vigencia As Boolean)
        ValidarTipoDoc(tipo_doc)
        obj.Insertar(tipo_doc.Trim(), vigencia)
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR
    ' ══════════════════════════════════════════════
    Public Sub EditarDocumento(id As Integer, tipo_doc As String, vigencia As Boolean)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        ValidarTipoDoc(tipo_doc)
        obj.Editar(id, tipo_doc.Trim(), vigencia)
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA
    ' ══════════════════════════════════════════════
    Public Sub DarBajaDocumento(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.DarBaja(id)
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR
    ' ══════════════════════════════════════════════
    Public Sub EliminarDocumento(id As Integer)
        If id <= 0 Then Throw New Exception("El ID del registro no es válido.")
        obj.Eliminar(id)
    End Sub

End Class
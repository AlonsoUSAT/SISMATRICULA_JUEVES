Imports capaDatos

Public Class clsLogPagoMatricula
    Dim objDatos As New clsDatPagoMatricula()

    Public Function Listar() As DataTable
        Return objDatos.ListarPagos()
    End Function

    Public Function Guardar(fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer) As Boolean
        If monto <= 0 Then Throw New Exception("El monto debe ser mayor a cero.")
        Return objDatos.InsertarPago(fechaPago, codOperativo, monto, numReferencia)
    End Function

    Public Function Modificar(id As Integer, fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer, estado As Boolean) As Boolean
        If monto <= 0 Then Throw New Exception("El monto debe ser mayor a cero.")
        Return objDatos.ActualizarPago(id, fechaPago, codOperativo, monto, numReferencia, estado)
    End Function

    Public Function DarDeBaja(id As Integer) As Boolean
        Return objDatos.DarDeBajaPago(id)
    End Function

    Public Function MostrarAnosAcademicos() As DataTable
        Return objDatos.ListarAnosAcademicos()
    End Function

End Class

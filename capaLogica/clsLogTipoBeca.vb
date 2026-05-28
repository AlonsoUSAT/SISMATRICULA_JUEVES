Imports System.Data
Imports capaDatos
Imports capaDatos.capaDatos

Namespace capaLogica

    Public Class clsLogTipoBeca

        Private ReadOnly _datTipo As New clsDatTipoBeca()

        Public Function Listar(Optional filtro As String = "") As DataTable
            Return _datTipo.Listar(filtro)
        End Function

        Public Function ObtenerSiguienteId() As Integer
            Return _datTipo.ObtenerSiguienteId()
        End Function

        Private Function ValidarDatos(descripcion As String, porcentaje As Decimal) As String
            If String.IsNullOrWhiteSpace(descripcion) OrElse descripcion.Trim().Length < 4 Then
                Return "La descripción debe tener al menos 4 caracteres."
            End If

            If porcentaje <= 0 OrElse porcentaje > 100 Then
                Return "El porcentaje de descuento debe ser mayor a 0 y máximo 100."
            End If

            Return String.Empty ' No hay errores
        End Function

        ' ==================================================================
        ' INSERTAR
        ' ==================================================================
        Public Function Insertar(descripcion As String, porcentaje As Decimal, estado As Boolean) As Boolean
            Dim errorVal As String = ValidarDatos(descripcion, porcentaje)
            If errorVal <> "" Then Throw New ArgumentException(errorVal)

            Return _datTipo.Insertar(descripcion, porcentaje, estado)
        End Function

        ' ==================================================================
        ' ACTUALIZAR
        ' ==================================================================
        Public Function Actualizar(id As Integer, descripcion As String, porcentaje As Decimal, estado As Boolean) As Boolean
            If id <= 0 Then Throw New ArgumentException("Seleccione un registro válido para modificar.")

            Dim errorVal As String = ValidarDatos(descripcion, porcentaje)
            If errorVal <> "" Then Throw New ArgumentException(errorVal)

            Return _datTipo.Actualizar(id, descripcion, porcentaje, estado)
        End Function

        Public Function DarBaja(id As Integer) As Boolean
            If id <= 0 Then Throw New ArgumentException("Seleccione un registro válido para dar de baja.")
            Return _datTipo.DarBaja(id)
        End Function

        Public Function Eliminar(id As Integer) As Boolean
            If id <= 0 Then Throw New ArgumentException("Seleccione un registro válido para eliminar.")
            Return _datTipo.Eliminar(id)
        End Function

    End Class
End Namespace
Imports capaDatos
Imports System.Data

Public Class clsLogUsuario
    Dim objDatos As New clsDatUsuario()

    Public Function Autenticar(usuario As String, clave As String) As Boolean
        ' Validaciones básicas antes de ir a la BD
        If String.IsNullOrEmpty(usuario) Or String.IsNullOrEmpty(clave) Then
            Throw New Exception("Por favor, ingrese su usuario y contraseña.")
        End If

        ' Aquí enviamos el usuario y la clave (que ya debe venir encriptada desde el formulario)
        Dim dt As DataTable = objDatos.ValidarLogin(usuario, clave)

        ' Si la tabla devuelve al menos 1 fila, el usuario y la clave coinciden en la BD
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
Imports capaLogica ' Asegúrate de que este sea el nombre de tu capa lógica

Public Class InicioSesion
    ' Instanciamos tu nueva clase maestra de usuarios
    Dim objLogica As New clsUsuario()

    ' BOTÓN INGRESAR
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            ' Variables vacías que tu función AutenticarUsuario necesita llenar (ByRef)
            Dim preguntaSecreta As String = ""
            Dim respuestaHash As String = ""

            ' Llamamos a la función enviando el usuario y la clave NORMAL (BCrypt se encarga del resto)
            Dim resultado As Integer = objLogica.AutenticarUsuario(txtUsuario.Text, txtContraseña.Text, preguntaSecreta, respuestaHash)

            ' Evaluamos la respuesta de la capa lógica
            Select Case resultado
                Case 2 ' ============= ACCESO CONCEDIDO =============
                    MsgBox("¡Bienvenido al Sistema del I.E.P Amancio Varona!", MsgBoxStyle.Information, "Acceso Concedido")

                    ' Abrimos el Menú Principal
                    Dim frmMain As New Principal()
                    frmMain.Show()

                    Me.Hide() ' Oculta la ventana de login

                Case 1 ' ============= CLAVE INCORRECTA =============
                    MsgBox("La contraseña ingresada es incorrecta.", MsgBoxStyle.Exclamation, "Error de Acceso")
                    txtContraseña.Clear()
                    txtContraseña.Focus()

                Case 0 ' ========= NO EXISTE O ESTÁ INACTIVO =========
                    MsgBox("El usuario no existe o se encuentra inactivo en el sistema.", MsgBoxStyle.Critical, "Acceso Denegado")
                    txtUsuario.Focus()

            End Select

        Catch ex As Exception
            MsgBox("Error al intentar iniciar sesión: " & ex.Message, MsgBoxStyle.Critical, "Atención")
        End Try
    End Sub

    ' BOTÓN CERRAR
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Cierra toda la aplicación de forma segura
        Application.Exit()
    End Sub

End Class
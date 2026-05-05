Public Class InicioSesion

    Private objLogica As New capaLogica.clsUsuario()
    Private _intentos As Integer = 0
    Private Const MAX_INTENTOS As Integer = 3

    ' Guardamos temporalmente la pregunta y hash de respuesta tras validar credenciales
    Private _pregunta As String = ""
    Private _respuestaHash As String = ""

    ' ══════════════════════════════════════════════
    '  BOTÓN INGRESAR
    ' ══════════════════════════════════════════════
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Validación básica de campos vacíos
        If String.IsNullOrWhiteSpace(txtNombreUsuario.Text) OrElse
           String.IsNullOrWhiteSpace(txtContra.Text) Then
            MessageBox.Show("Debe ingresar el nombre de usuario y la contraseña.",
                            "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim resultado As Integer =
                objLogica.AutenticarUsuario(txtNombreUsuario.Text.Trim(),
                                            txtContra.Text,
                                            _pregunta, _respuestaHash)

            Select Case resultado
                Case 0  ' Usuario no existe o está inactivo
                    RegistrarIntento("El usuario no existe o se encuentra inactivo.")

                Case 1  ' Clave incorrecta
                    RegistrarIntento("Contraseña incorrecta.")

                Case 2  ' Credenciales correctas → abrir modal de pregunta secreta
                    MostrarModalPregunta()
            End Select

        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  REGISTRAR INTENTO FALLIDO
    ' ══════════════════════════════════════════════
    Private Sub RegistrarIntento(motivo As String)
        _intentos += 1
        Dim restantes As Integer = MAX_INTENTOS - _intentos

        If _intentos >= MAX_INTENTOS Then
            MessageBox.Show(motivo & Environment.NewLine & Environment.NewLine &
                            "Ha agotado todos sus intentos. El sistema se cerrará.",
                            "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        Else
            MessageBox.Show(motivo & Environment.NewLine & Environment.NewLine &
                            "Intentos restantes: " & restantes,
                            "Credenciales incorrectas",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContra.Clear()
            txtContra.Focus()
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  MOSTRAR MODAL DE PREGUNTA SECRETA
    ' ══════════════════════════════════════════════
    Private Sub MostrarModalPregunta()
        ' Si el usuario no tiene pregunta configurada, ingresa directo
        If String.IsNullOrWhiteSpace(_pregunta) OrElse
           String.IsNullOrWhiteSpace(_respuestaHash) Then
            AbrirPrincipal()
            Return
        End If

        ' Crear el formulario modal en tiempo de ejecución
        Dim frmPregunta As New Form()
        frmPregunta.Text = "Verificación de seguridad"
        frmPregunta.Size = New Size(420, 220)
        frmPregunta.StartPosition = FormStartPosition.CenterParent
        frmPregunta.FormBorderStyle = FormBorderStyle.FixedDialog
        frmPregunta.MaximizeBox = False
        frmPregunta.MinimizeBox = False

        ' Etiqueta de instrucción
        Dim lblTitulo As New Label()
        lblTitulo.Text = "Responda su pregunta de seguridad:"
        lblTitulo.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblTitulo.Location = New Point(15, 15)
        lblTitulo.AutoSize = True

        ' Etiqueta con la pregunta
        Dim lblPregunta As New Label()
        lblPregunta.Text = _pregunta
        lblPregunta.Location = New Point(15, 40)
        lblPregunta.Size = New Size(380, 40)
        lblPregunta.Font = New Font("Segoe UI", 9)

        ' TextBox para la respuesta
        Dim txtRespuesta As New TextBox()
        txtRespuesta.Location = New Point(15, 88)
        txtRespuesta.Size = New Size(380, 25)

        ' Botón confirmar
        Dim btnConfirmar As New Button()
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.Location = New Point(200, 130)
        btnConfirmar.Size = New Size(90, 30)
        btnConfirmar.DialogResult = DialogResult.OK

        ' Botón cancelar
        Dim btnCancelar As New Button()
        btnCancelar.Text = "Cancelar"
        btnCancelar.Location = New Point(305, 130)
        btnCancelar.Size = New Size(90, 30)
        btnCancelar.DialogResult = DialogResult.Cancel

        frmPregunta.Controls.AddRange({lblTitulo, lblPregunta, txtRespuesta,
                                        btnConfirmar, btnCancelar})
        frmPregunta.AcceptButton = btnConfirmar
        frmPregunta.CancelButton = btnCancelar

        ' Mostrar el modal
        Dim resultado As DialogResult = frmPregunta.ShowDialog(Me)

        If resultado = DialogResult.OK Then
            If objLogica.VerificarRespuesta(txtRespuesta.Text, _respuestaHash) Then
                AbrirPrincipal()
            Else
                RegistrarIntento("La respuesta de seguridad es incorrecta.")
            End If
        End If

        frmPregunta.Dispose()
    End Sub

    ' ══════════════════════════════════════════════
    '  ABRIR FORMULARIO PRINCIPAL (MDI)
    ' ══════════════════════════════════════════════
    Private Sub AbrirPrincipal()
        MessageBox.Show("¡Bienvenido, " & txtNombreUsuario.Text.Trim() & "!",
                        "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim frmPrincipal As New Principal()
        frmPrincipal.Show()
        Me.Hide()
    End Sub

End Class
Imports capaLogica
Public Class frmMantDocente
    Dim objLogicaDocente As New clPersona()

    Private Sub frmMantDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        Try
            ' El DataGridView se llama dgvDocente
            dgvDocente.DataSource = objLogicaDocente.MostrarDocentes()
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validar que los campos obligatorios no estén vacíos
        If txtNombre.Text = "" Or txtPaterno.Text = "" Or txtMaterno.Text = "" Or txtNumDoc.Text = "" Or txtEspecialidad.Text = "" Then
            MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Capturar los datos del formulario
            Dim nombres As String = txtNombre.Text.Trim()
            Dim apePaterno As String = txtPaterno.Text.Trim()
            Dim apeMaterno As String = txtMaterno.Text.Trim()
            Dim numDoc As String = txtNumDoc.Text.Trim()
            Dim especialidad As String = txtEspecialidad.Text.Trim()

            ' Dependiendo de cómo llenes tu combo box, puedes capturar el texto ("M" o "F", o la palabra completa)
            Dim sexo As String = ""
            Select Case cboSexo.Text.ToUpper()
                Case "MASCULINO", "M"
                    sexo = "M"
                Case "FEMENINO", "F"
                    sexo = "F"
            End Select

            Dim telefono As String = txtTelefono.Text.Trim()
            Dim correo As String = txtCorreo.Text.Trim()

            ' 3. Enviar a la capa lógica para registrar
            objLogicaDocente.InsertarDocente(apeMaterno, apePaterno, nombres, telefono, correo, sexo, numDoc, especialidad)

            ' 4. Confirmación y limpieza
            MessageBox.Show("Docente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario() ' Este método ya hace txtNombre.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Try
                Dim sexo As String = ""
                If cboSexo.Text.ToUpper() = "MASCULINO" Then sexo = "M"
                If cboSexo.Text.ToUpper() = "FEMENINO" Then sexo = "F"

                ' Llama a EditarDocente, no a Insertar
                objLogicaDocente.EditarDocente(txtMaterno.Text.Trim(), txtPaterno.Text.Trim(), txtNombre.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), sexo, txtNumDoc.Text.Trim(), txtEspecialidad.Text.Trim())

                MessageBox.Show("Modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Seleccione un registro del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Try
                objLogicaDocente.DarBajaDocente(txtNumDoc.Text.Trim())
                MessageBox.Show("Registro dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Seleccione un registro del listado para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar definitivamente a este docente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Try
                    objLogicaDocente.EliminarDocente(txtNumDoc.Text.Trim())
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CargarListado()
                    LimpiarFormulario()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un registro del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvDocente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocente.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvDocente.Rows(e.RowIndex)

            txtNombre.Text = fila.Cells("Nombres").Value.ToString()
            txtNumDoc.Text = fila.Cells("Numero_Documento").Value.ToString()
            txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()

            ' Cargar la especialidad
            If dgvDocente.Columns.Contains("Especialidad") Then
                txtEspecialidad.Text = fila.Cells("Especialidad").Value.ToString()
            End If

            Dim apellidos As String = fila.Cells("Apellidos").Value.ToString().Trim()
            Dim espacioIndex As Integer = apellidos.IndexOf(" ")

            If espacioIndex > 0 Then
                txtPaterno.Text = apellidos.Substring(0, espacioIndex)
                txtMaterno.Text = apellidos.Substring(espacioIndex + 1).Trim()
            Else
                txtPaterno.Text = apellidos
                txtMaterno.Clear()
            End If

            ' Para que esto funcione, la query SELECT debe traer "P.sexo as Sexo"
            If dgvDocente.Columns.Contains("Sexo") Then
                Dim sexoBD As String = fila.Cells("Sexo").Value.ToString()
                If sexoBD = "M" Then
                    cboSexo.Text = "MASCULINO"
                ElseIf sexoBD = "F" Then
                    cboSexo.Text = "FEMENINO"
                Else
                    cboSexo.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub LimpiarFormulario()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        txtNumDoc.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtEspecialidad.Clear()
        cboSexo.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
Imports capaLogica

Public Class frmMantPersona
    Private objLogica As New clPersona()
    Private idPersona As String = Nothing
    Private editar As Boolean = False

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarPersonas()
    End Sub

    ' Método para cargar el DataGridView
    Private Sub MostrarPersonas()
        dgvPersonas.DataSource = objLogica.MostrarPersonas()
    End Sub

    ' Botón Guardar (Sirve para Insertar y para Actualizar)
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Captura de valores de los controles
            Dim apePat As String = txtPaterno.Text
            Dim apeMat As String = txtMaterno.Text
            Dim nom As String = txtNombre.Text
            Dim tel As String = txtTelefono.Text
            Dim cor As String = txtCorreo.Text
            Dim vig As Boolean = chkVigencia.Checked
            Dim tip As String = txtTipo.Text
            Dim idDoc As Integer = Convert.ToInt32(txtIdDocumento.Text)
            Dim sex As String = cboSexo.Text

            If editar = False Then
                ' INSERTAR
                objLogica.InsertarPersona(apeMat, apePat, nom, tel, cor, vig, tip, idDoc, sex)
                MessageBox.Show("Se insertó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' EDITAR
                objLogica.EditarPersona(Convert.ToInt32(idPersona), apeMat, apePat, nom, tel, cor, vig, tip, idDoc, sex)
                MessageBox.Show("Se actualizó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                editar = False
            End If

            MostrarPersonas()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Botón Editar (Pasa los datos del DataGridView a los TextBox)
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvPersonas.SelectedRows.Count > 0 Then
            editar = True
            idPersona = dgvPersonas.CurrentRow.Cells("id_persona").Value.ToString()
            txtMaterno.Text = dgvPersonas.CurrentRow.Cells("apeMaterno").Value.ToString()
            txtPaterno.Text = dgvPersonas.CurrentRow.Cells("apePaterno").Value.ToString()
            txtNombre.Text = dgvPersonas.CurrentRow.Cells("nombre").Value.ToString()
            txtTelefono.Text = dgvPersonas.CurrentRow.Cells("telefono").Value.ToString()
            txtCorreo.Text = dgvPersonas.CurrentRow.Cells("correo").Value.ToString()
            chkVigencia.Checked = Convert.ToBoolean(dgvPersonas.CurrentRow.Cells("vigencia").Value)
            txtTipo.Text = dgvPersonas.CurrentRow.Cells("tipo").Value.ToString()
            txtIdDocumento.Text = dgvPersonas.CurrentRow.Cells("id_tipoDocumento").Value.ToString()
            cboSexo.Text = dgvPersonas.CurrentRow.Cells("sexo").Value.ToString()
        Else
            MessageBox.Show("Seleccione una fila por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvPersonas.SelectedRows.Count > 0 Then
            Dim dialogResult As DialogResult = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                idPersona = dgvPersonas.CurrentRow.Cells("id_persona").Value.ToString()
                objLogica.EliminarPersona(Convert.ToInt32(idPersona))
                MostrarPersonas()
                MessageBox.Show("Eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione una fila por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Botón Limpiar (Cancela edición o vacía los campos)
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
        editar = False
    End Sub

    Private Sub LimpiarFormulario()
        txtPaterno.Clear()
        txtMaterno.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtTipo.Clear()
        txtIdDocumento.Clear()
        cboSexo.SelectedIndex = -1
        chkVigencia.Checked = False
        txtPaterno.Focus()
    End Sub
End Class
Imports capaLogica

Public Class frmMantEspecialidad
    Dim objLogica As New clEspecialidad()
    Dim idSeleccionado As Integer = 0
    Dim modoNuevo As Boolean = False


    Private Sub frmMantEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
        CargarFiltro()
    End Sub

    Private Sub CargarListado()
        Try
            dgvEspecialidades.DataSource = objLogica.MostrarEspecialidades()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarFiltro()
        Try
            cboFiltro.Items.Clear()
            cboFiltro.Items.Add("Todas")
            cboFiltro.Items.Add("Solo vigentes")
            cboFiltro.Items.Add("Solo dadas de baja")
            cboFiltro.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        txtNombre.Clear()
        chkEstado.Checked = True
        txtID.Clear()
        idSeleccionado = 0
        modoNuevo = False
        btnNuevoGuardar.Text = "Nuevo"
        btnNuevoGuardar.BackColor = Color.FromArgb(139, 0, 0)
        txtNombre.Focus()
    End Sub


    Private Sub btnNuevoGuardar_Click(sender As Object, e As EventArgs) Handles btnNuevoGuardar.Click
        If Not modoNuevo Then
            ' --- MODO NUEVO: limpiar y activar ---
            LimpiarFormulario()
            modoNuevo = True
            btnNuevoGuardar.Text = "Guardar"
            btnNuevoGuardar.BackColor = Color.FromArgb(0, 120, 0)  ' verde al guardar
            txtNombre.Enabled = True
            txtNombre.Focus()
        Else
            ' --- MODO GUARDAR: validar y guardar ---
            If txtNombre.Text.Trim() = "" Then
                MessageBox.Show("Ingrese el nombre de la especialidad.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                objLogica.InsertarEspecialidad(txtNombre.Text.Trim())
                MessageBox.Show("Especialidad registrada.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()

                ' Volver al modo inicial
                modoNuevo = False
                btnNuevoGuardar.Text = "Nuevo"
                btnNuevoGuardar.BackColor = Color.FromArgb(139, 0, 0)  ' rojo
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccione una especialidad del listado.", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtNombre.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            objLogica.EditarEspecialidad(idSeleccionado, txtNombre.Text.Trim(), chkEstado.Checked)
            MessageBox.Show("Especialidad modificada.", "Éxito",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccione una especialidad del listado.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            objLogica.DarBajaEspecialidad(idSeleccionado)
            MessageBox.Show("Especialidad dada de baja.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado = 0 Then
            MessageBox.Show("Seleccione una especialidad del listado.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim resp As DialogResult = MessageBox.Show("¿Eliminar esta especialidad?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            Try
                objLogica.EliminarEspecialidad(idSeleccionado)
                MessageBox.Show("Especialidad eliminada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged
        Try
            Select Case cboFiltro.SelectedIndex
                Case 0 ' Todas
                    dgvEspecialidades.DataSource = objLogica.MostrarEspecialidades()
                Case 1 ' Solo vigentes
                    dgvEspecialidades.DataSource = objLogica.MostrarFiltradas("vigente")
                Case 2 ' Solo dadas de baja
                    dgvEspecialidades.DataSource = objLogica.MostrarFiltradas("baja")
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEspecialidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEspecialidades.CellClick
        If e.RowIndex < 0 Then Return
        Dim fila As DataGridViewRow = dgvEspecialidades.Rows(e.RowIndex)
        idSeleccionado = Convert.ToInt32(fila.Cells("ID").Value)
        txtID.Text = idSeleccionado.ToString()
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        chkEstado.Checked = fila.Cells("Estado").Value.ToString() = "Vigente"
    End Sub
End Class
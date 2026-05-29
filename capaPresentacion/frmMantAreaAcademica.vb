Imports capaLogica

Public Class frmMantAreaAcademica

    Dim objLogica As New clsLogMantAreaAcademica()
    Dim _idAreaSeleccionada As Integer = 0

    Private Sub frmMantAreaAcademica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.ReadOnly = True
        ConfigurarGrid()
        CargarTabla()
        ModoConsulta()
    End Sub

    Private Sub ConfigurarGrid()
        dgvAreas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAreas.RowHeadersVisible = False
        dgvAreas.AllowUserToAddRows = False
        dgvAreas.ReadOnly = True
        dgvAreas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub CargarTabla()
        dgvAreas.DataSource = objLogica.Listar()
    End Sub



    Private Sub ModoConsulta()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = SystemColors.Control
        chkActivo.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnDarBaja.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub ModoNuevo()
        txtNombre.ReadOnly = False
        txtNombre.BackColor = SystemColors.Window
        chkActivo.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnDarBaja.Enabled = False
        btnEliminar.Enabled = False
        txtNombre.Focus()
    End Sub

    Private Sub ModoSeleccionado()
        txtNombre.ReadOnly = False
        txtNombre.BackColor = SystemColors.Window
        chkActivo.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnDarBaja.Enabled = True
        btnEliminar.Enabled = True
    End Sub



    Private Sub dgvAreas_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvAreas.CellClick
        If e.RowIndex < 0 Then Return
        Dim fila As DataGridViewRow = dgvAreas.Rows(e.RowIndex)
        _idAreaSeleccionada = Convert.ToInt32(fila.Cells("id_area").Value)
        txtId.Text = _idAreaSeleccionada.ToString()
        txtNombre.Text = fila.Cells("nombre").Value.ToString()
        chkActivo.Checked = fila.Cells("estado").Value.ToString() = "ACTIVO"
        ModoSeleccionado()
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _idAreaSeleccionada = 0
        txtId.Text = objLogica.ObtenerSiguienteId().ToString()
        txtNombre.Text = ""
        chkActivo.Checked = True
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            objLogica.Insertar(txtNombre.Text)
            MessageBox.Show("Área académica registrada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim confirmar As DialogResult = MessageBox.Show(
            "¿Confirma la modificación del área: " & txtNombre.Text & "?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmar <> DialogResult.Yes Then Return

            objLogica.Actualizar(_idAreaSeleccionada, txtNombre.Text, chkActivo.Checked)
            MessageBox.Show("Área académica modificada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If Not chkActivo.Checked Then
                MessageBox.Show("Esta área ya está dada de baja.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Verificar si tiene cursos asociados
            If objLogica.TieneCursosAsociados(_idAreaSeleccionada) Then
                MessageBox.Show("No se puede dar de baja el área: " & txtNombre.Text & vbCrLf &
                            "Tiene cursos asociados. Elimine o reasigne los cursos primero.",
                            "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmar As DialogResult = MessageBox.Show(
            "¿Desea dar de baja el área: " & txtNombre.Text & "?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmar <> DialogResult.Yes Then Return

            objLogica.DarBaja(_idAreaSeleccionada)
            MessageBox.Show("Área dada de baja correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim confirmar As DialogResult = MessageBox.Show(
                "¿Está seguro de ELIMINAR el área: " & txtNombre.Text & "?" & vbCrLf &
                "Esta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmar <> DialogResult.Yes Then Return

            objLogica.Eliminar(_idAreaSeleccionada)
            MessageBox.Show("Área eliminada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTabla()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LimpiarCampos()
        _idAreaSeleccionada = 0
        txtId.Text = ""
        txtNombre.Text = ""
        chkActivo.Checked = False
        ModoConsulta()
    End Sub

End Class
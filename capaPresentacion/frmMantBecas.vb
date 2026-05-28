Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports capaLogica
Imports capaLogica.capaLogica

Public Class frmMantBecas

    Private ReadOnly _logTipo As New clsLogTipoBeca()

    Private Sub frmMantBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTiposBeca()
        EstadoInicial()
    End Sub

    Private Sub ListarTiposBeca(Optional filtro As String = "")
        Try
            Dim dt As DataTable = _logTipo.Listar(filtro)
            dgvTiposBeca.DataSource = dt
            lblTotalTipos.Text = "Total: " & dt.Rows.Count.ToString()

            If dgvTiposBeca.Columns.Count > 0 Then
                dgvTiposBeca.Columns("ID").Width = 40
                dgvTiposBeca.Columns("Porcentaje").Width = 80
                dgvTiposBeca.Columns("Estado").Width = 60
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al listar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListarTiposBeca(txtFiltroTipo.Text)
    End Sub

    Private Sub txtFiltroTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltroTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarTiposBeca(txtFiltroTipo.Text)
        End If
    End Sub

    Private Sub dgvTiposBeca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiposBeca.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim fila As DataGridViewRow = dgvTiposBeca.Rows(e.RowIndex)

            ' Pasar los datos de la grilla a las cajas de texto
            txtCodigo.Text = fila.Cells("ID").Value.ToString()
            txtDescripcionTipo.Text = fila.Cells("Descripcion").Value.ToString()
            txtPorcentajeTipo.Text = fila.Cells("Porcentaje").Value.ToString()
            chkEstado.Checked = CBool(fila.Cells("Estado").Value)

            pnlFormTipo.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnDarBaja.Enabled = True
            btnEliminar.Enabled = True
            lblModoTipo.Text = "Editando registro seleccionado"

        Catch ex As Exception
            MessageBox.Show("Error al seleccionar la fila.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        EstadoInicial()
        pnlFormTipo.Enabled = True
        btnGuardar.Enabled = True
        chkEstado.Checked = True
        lblModoTipo.Text = "Creando nuevo registro"

        Try
            txtCodigo.Text = _logTipo.ObtenerSiguienteId().ToString()
            txtCodigo.ReadOnly = True
        Catch ex As Exception
            txtCodigo.Text = "---"
        End Try

        txtDescripcionTipo.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim porcentaje As Decimal
            If Not Decimal.TryParse(txtPorcentajeTipo.Text, porcentaje) Then
                MessageBox.Show("Ingrese un porcentaje numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ok As Boolean = _logTipo.Insertar(txtDescripcionTipo.Text, porcentaje, chkEstado.Checked)

            If ok Then
                MessageBox.Show("Tipo de beca registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarTiposBeca()
                EstadoInicial()
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Validación de negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim id As Integer = CInt(txtCodigo.Text)
            Dim porcentaje As Decimal

            If Not Decimal.TryParse(txtPorcentajeTipo.Text, porcentaje) Then
                MessageBox.Show("Ingrese un porcentaje numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Llamamos a la capa lógica
            Dim ok As Boolean = _logTipo.Actualizar(id, txtDescripcionTipo.Text, porcentaje, chkEstado.Checked)

            If ok Then
                MessageBox.Show("Registro actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarTiposBeca()
                EstadoInicial()
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Validación de negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If MessageBox.Show("¿Está seguro de DAR DE BAJA (desactivar) este tipo de beca?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Dim id As Integer = CInt(txtCodigo.Text)
            Dim ok As Boolean = _logTipo.DarBaja(id)

            If ok Then
                MessageBox.Show("El tipo de beca fue dado de baja. Ya no aparecerá como disponible para asignar.", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarTiposBeca()
                EstadoInicial()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim msg As String = "¡ATENCIÓN! Está a punto de eliminar definitivamente este registro de la base de datos." & vbCrLf & vbCrLf &
                            "Si este tipo de beca ya fue asignado a estudiantes en el pasado, el sistema cancelará la operación para proteger el historial." & vbCrLf & vbCrLf &
                            "¿Desea continuar de todos modos?"

        If MessageBox.Show(msg, "Confirmar Eliminación Física", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            Dim id As Integer = CInt(txtCodigo.Text)

            ' Intentamos eliminar...
            Dim ok As Boolean = _logTipo.Eliminar(id)

            If ok Then
                MessageBox.Show("Registro eliminado de forma permanente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarTiposBeca()
                EstadoInicial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operación Denegada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub EstadoInicial()
        txtCodigo.Clear()
        txtDescripcionTipo.Clear()
        txtPorcentajeTipo.Clear()
        chkEstado.Checked = False
        pnlFormTipo.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnDarBaja.Enabled = False
        btnEliminar.Enabled = False
        lblModoTipo.Text = "Seleccione un registro de la lista"
    End Sub

    Private Sub txtPorcentajeTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentajeTipo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> ","c AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

End Class
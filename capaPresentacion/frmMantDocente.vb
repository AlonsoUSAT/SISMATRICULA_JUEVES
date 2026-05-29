Imports capaLogica

Public Class frmMantDocente
    Dim objLogicaDocente As New clPersona()

    Private Sub frmMantDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEspecialidades() ' Llamamos al nuevo método
        CargarListado()
        txtNumDoc.MaxLength = 8
        txtTelefono.MaxLength = 9
        dgvDocente.AllowUserToAddRows = False
    End Sub

    ' NUEVO: Función para llenar el ComboBox
    Private Sub CargarEspecialidades()
        Try
            cboEspecialidad.DataSource = objLogicaDocente.ListarEspecialidades()
            cboEspecialidad.DisplayMember = "nombre"
            cboEspecialidad.ValueMember = "id_especialidad"
            cboEspecialidad.SelectedIndex = -1 ' Empieza en blanco
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarListado()
        Try
            dgvDocente.DataSource = objLogicaDocente.MostrarDocentes()
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' MODIFICADO: Validación adaptada al ComboBox
        If txtNombre.Text = "" Or txtPaterno.Text = "" Or txtMaterno.Text = "" Or txtNumDoc.Text = "" Or cboEspecialidad.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nombres As String = txtNombre.Text.Trim()
            Dim apePaterno As String = txtPaterno.Text.Trim()
            Dim apeMaterno As String = txtMaterno.Text.Trim()
            Dim numDoc As String = txtNumDoc.Text.Trim()

            ' CAPTURAMOS EL ID DE LA ESPECIALIDAD DEL COMBOBOX
            Dim id_especialidad As Integer = Convert.ToInt32(cboEspecialidad.SelectedValue)

            Dim sexo As String = ""
            Select Case cboSexo.Text.ToUpper()
                Case "MASCULINO", "M"
                    sexo = "M"
                Case "FEMENINO", "F"
                    sexo = "F"
            End Select

            Dim telefono As String = txtTelefono.Text.Trim()
            Dim correo As String = txtCorreo.Text.Trim()

            ' MODIFICADO: Enviamos id_especialidad
            objLogicaDocente.InsertarDocente(apeMaterno, apePaterno, nombres, telefono, correo, sexo, numDoc, id_especialidad)

            MessageBox.Show("Docente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            If cboEspecialidad.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, seleccione una especialidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Dim sexo As String = ""
                If cboSexo.Text.ToUpper() = "MASCULINO" Then sexo = "M"
                If cboSexo.Text.ToUpper() = "FEMENINO" Then sexo = "F"

                ' CAPTURAMOS EL ID
                Dim id_especialidad As Integer = Convert.ToInt32(cboEspecialidad.SelectedValue)

                ' MODIFICADO: Enviamos id_especialidad
                objLogicaDocente.EditarDocente(txtMaterno.Text.Trim(), txtPaterno.Text.Trim(), txtNombre.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), sexo, txtNumDoc.Text.Trim(), id_especialidad)

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

    Private Sub dgvDocente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocente.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvDocente.Rows(e.RowIndex)

            txtNombre.Text = fila.Cells("Nombres").Value.ToString()
            txtNumDoc.Text = fila.Cells("Numero_Documento").Value.ToString()
            txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()

            ' MODIFICADO: Buscar el texto en el ComboBox para que se seleccione automáticamente
            If dgvDocente.Columns.Contains("Especialidad") Then
                cboEspecialidad.Text = fila.Cells("Especialidad").Value.ToString()
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
        cboEspecialidad.SelectedIndex = -1 ' Limpia la selección del combobox
        cboSexo.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    ' (Los eventos de btnNuevo, btnDarBaja, btnEliminar y KeyPress se mantienen igual)
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        ' ... tu código original ...
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' ... tu código original ...
    End Sub

    Private Sub txtNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDoc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub
End Class
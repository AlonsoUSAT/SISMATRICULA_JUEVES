Imports capaLogica

Public Class frmCurso
    Dim objLogicaCurso As New clCurso()
    Dim idCursoSeleccionado As Integer = 0

    Private Sub frmCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAreas()
        CargarListado()
        dgvCursos.AllowUserToAddRows = False
    End Sub

    Private Sub CargarAreas()
        Try
            Dim dtAreas As DataTable = objLogicaCurso.MostrarAreasAcademicas()
            cboArea.DisplayMember = "nombre"
            cboArea.ValueMember = "id_area"
            cboArea.DataSource = dtAreas
            cboArea.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar áreas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarListado()
        Try
            dgvCursos.DataSource = objLogicaCurso.MostrarCursos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar listado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        txtNombreCurso.Clear()
        txtDescripcion.Clear()
        cboArea.SelectedIndex = -1
        chkVigente.Checked = False
        txtID.Clear()
        idCursoSeleccionado = 0
        txtNombreCurso.Focus()
    End Sub

    ' EVENTO ACTUALIZADO: btnNew
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        LimpiarFormulario()
    End Sub

    ' EVENTO ACTUALIZADO: btnSafe
    Private Sub btnSafe_Click(sender As Object, e As EventArgs) Handles btnSafe.Click
        If txtNombreCurso.Text.Trim() = "" Or cboArea.SelectedIndex = -1 Then
            MessageBox.Show("Complete los campos obligatorios: Nombre y Área.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nombreCurso As String = txtNombreCurso.Text.Trim()
            Dim descripcion As String = txtDescripcion.Text.Trim()
            Dim idArea As Integer = Convert.ToInt32(cboArea.SelectedValue)
            Dim idGrado As Integer = 1 ' Ajusta esto si tienes un ComboBox de grado en el form

            objLogicaCurso.InsertarCurso(nombreCurso, descripcion, idArea, idGrado)

            MessageBox.Show("Curso registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EVENTO ACTUALIZADO: btnUpdate
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If idCursoSeleccionado = 0 Then
            MessageBox.Show("Seleccione un curso del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNombreCurso.Text.Trim() = "" Or cboArea.SelectedIndex = -1 Then
            MessageBox.Show("Complete los campos obligatorios: Nombre y Área.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nombreCurso As String = txtNombreCurso.Text.Trim()
            Dim descripcion As String = txtDescripcion.Text.Trim()
            Dim idArea As Integer = Convert.ToInt32(cboArea.SelectedValue)

            objLogicaCurso.EditarCurso(idCursoSeleccionado, nombreCurso, descripcion, idArea)

            MessageBox.Show("Curso modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EVENTO ACTUALIZADO: btnBaja
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If idCursoSeleccionado = 0 Then
            MessageBox.Show("Seleccione un curso del listado para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            objLogicaCurso.DarBajaCurso(idCursoSeleccionado)
            MessageBox.Show("Curso dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al dar de baja: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EVENTO ACTUALIZADO: btnDelete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idCursoSeleccionado = 0 Then
            MessageBox.Show("Seleccione un curso del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar este curso?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                objLogicaCurso.EliminarCurso(idCursoSeleccionado)
                MessageBox.Show("Curso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            If txtBuscarNombre.Text.Trim() = "" Then
                CargarListado()
            Else
                dgvCursos.DataSource = objLogicaCurso.MostrarCursosFiltrados(txtBuscarNombre.Text.Trim())
            End If
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvCursos.Rows(e.RowIndex)

            idCursoSeleccionado = Convert.ToInt32(fila.Cells("ID").Value)
            txtID.Text = idCursoSeleccionado.ToString()
            txtNombreCurso.Text = fila.Cells("Nombre_Curso").Value.ToString()
            txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
            chkVigente.Checked = Convert.ToBoolean(fila.Cells("Vigente").Value)

            ' Seleccionar el área en el ComboBox
            Dim areaBD As String = fila.Cells("Area_Academica").Value.ToString().Trim()
            For Each item As DataRowView In cboArea.Items
                If item("nombre").ToString() = areaBD Then
                    cboArea.SelectedValue = item("id_area")
                    Exit For
                End If
            Next
        End If
    End Sub
End Class
Imports capaLogica ' Asegúrate de usar el nombre correcto de tu capa lógica

Public Class frmCursoGrado
    Dim objLogica As New clCursoGrado()
    Dim idAsignacionSeleccionada As Integer = 0

    Private Sub frmCursoGrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        CargarListado()
        dgvTabla.AllowUserToAddRows = False
    End Sub

    Private Sub LlenarCombos()
        Try
            ' Cargar Años
            cboAño.DataSource = objLogica.CargarAnios()
            cboAño.DisplayMember = "Anio"
            cboAño.ValueMember = "Anio"
            cboAño.SelectedIndex = -1

            ' Cargar Cursos
            cboCurso.DataSource = objLogica.CargarCursos()
            cboCurso.DisplayMember = "nombreCurso"
            cboCurso.ValueMember = "id_curso"
            cboCurso.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar las listas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged
        If cboAño.SelectedIndex <> -1 AndAlso cboAño.Text <> "System.Data.DataRowView" Then
            Try
                Dim anioSeleccionado As String = cboAño.Text

                ' 1. Filtrar grados en el combobox según el año seleccionado
                cboGrado.DataSource = objLogica.CargarGradosPorAnio(anioSeleccionado)
                cboGrado.DisplayMember = "nombre"
                cboGrado.ValueMember = "id_grado"
                cboGrado.SelectedIndex = -1

                ' 2. Filtrar tabla según el año seleccionado
                dgvTabla.DataSource = objLogica.MostrarAsignacionesFiltradas(anioSeleccionado)
            Catch ex As Exception
                MessageBox.Show("Error al filtrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            cboGrado.DataSource = Nothing
            CargarListado()
        End If
    End Sub

    Private Sub CargarListado()
        Try
            dgvTabla.DataSource = objLogica.MostrarAsignaciones()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la tabla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        cboGrado.SelectedIndex = -1
        cboCurso.SelectedIndex = -1
        chkEstado.Checked = True
        idAsignacionSeleccionada = 0
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cboGrado.SelectedIndex = -1 Or cboCurso.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un Grado y un Curso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idGrado As Integer = Convert.ToInt32(cboGrado.SelectedValue)
            Dim idCurso As Integer = Convert.ToInt32(cboCurso.SelectedValue)
            Dim estado As Integer = If(chkEstado.Checked, 1, 0)

            objLogica.RegistrarAsignacion(idGrado, idCurso, estado)

            MessageBox.Show("Asignación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If idAsignacionSeleccionada = 0 Then
            MessageBox.Show("Seleccione una asignación de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            objLogica.DarBajaAsignacion(idAsignacionSeleccionada)
            MessageBox.Show("Asignación dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al dar de baja: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idAsignacionSeleccionada = 0 Then
            MessageBox.Show("Seleccione una asignación de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar definitivamente esta asignación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                objLogica.EliminarAsignacion(idAsignacionSeleccionada)
                MessageBox.Show("Asignación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgvTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvTabla.Rows(e.RowIndex)

            ' Guardamos el ID de la tabla intermedia para poder eliminar o dar de baja
            idAsignacionSeleccionada = Convert.ToInt32(fila.Cells("ID_Asignacion").Value)

            ' Mostrar los datos en los controles buscando el texto en los ComboBox
            cboGrado.Text = fila.Cells("Grado").Value.ToString()
            cboCurso.Text = fila.Cells("Curso").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("Estado").Value)
        End If
    End Sub
End Class
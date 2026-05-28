' --- CAPA PRESENTACIÓN (frmMantNGS) ---
Imports capaLogica

Public Class frmMantNGS
    Dim objLogica As New clSeccion()
    Dim idGradoSeleccionado As Integer = 0
    Dim idSeccionSeleccionada As Integer = 0

    Private Sub frmMantNGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAnosAcademicos() ' Primero cargamos los años
        CargarTutores()
        dgvGrados.AllowUserToAddRows = False
        dgvSecciones.AllowUserToAddRows = False
    End Sub

    Private Sub CargarTutores()
        cboTutor.DataSource = objLogica.ListarTutores()
        cboTutor.DisplayMember = "NombreCompleto"
        cboTutor.ValueMember = "id_docente" ' <-- Debe ser id_docente
        cboTutor.SelectedIndex = -1
    End Sub

    ' NUEVO: Carga los años en cboAno
    Private Sub CargarAnosAcademicos()
        cboAno.DataSource = objLogica.ListarAnosAcademicos()
        cboAno.DisplayMember = "Anio"
        cboAno.ValueMember = "id_anoAcademico"
        cboAno.SelectedIndex = -1
    End Sub

    ' NUEVO: Evento al cambiar el año seleccionado
    Private Sub cboAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAno.SelectedIndexChanged
        If cboAno.SelectedIndex <> -1 AndAlso TypeOf cboAno.SelectedValue Is Integer Then
            Dim idAno As Integer = Convert.ToInt32(cboAno.SelectedValue)

            ' Cargamos los niveles asociados a este año académico
            CargarNiveles(idAno)

            ' Limpiamos en cascada los datos inferiores
            dgvGrados.DataSource = Nothing
            dgvSecciones.DataSource = Nothing
            LimpiarCampos()
            idGradoSeleccionado = 0
        End If
    End Sub

    ' MODIFICADO: Recibe el id del año para llenar los niveles correctos
    Private Sub CargarNiveles(id_anoAcademico As Integer)
        cboNivel.DataSource = objLogica.ListarNiveles(id_anoAcademico)
        cboNivel.DisplayMember = "nombre"
        cboNivel.ValueMember = "id_nivel"
        cboNivel.SelectedIndex = -1
    End Sub

    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        If cboNivel.SelectedIndex <> -1 AndAlso TypeOf cboNivel.SelectedValue Is Integer Then
            Dim idNivel As Integer = Convert.ToInt32(cboNivel.SelectedValue)
            dgvGrados.DataSource = objLogica.ListarGrados(idNivel)
            dgvGrados.Columns("id_grado").Visible = False

            dgvSecciones.DataSource = Nothing
            LimpiarCampos()
            idGradoSeleccionado = 0
        End If
    End Sub

    Private Sub dgvGrados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrados.CellClick
        If e.RowIndex >= 0 Then
            idGradoSeleccionado = Convert.ToInt32(dgvGrados.Rows(e.RowIndex).Cells("id_grado").Value)
            CargarSecciones()
            LimpiarCampos()
        End If
    End Sub

    Private Sub CargarSecciones()
        If idGradoSeleccionado > 0 Then
            dgvSecciones.DataSource = objLogica.ListarSecciones(idGradoSeleccionado)
            dgvSecciones.Columns("id_seccion").Visible = False
            dgvSecciones.Columns("id_docente_tutor").Visible = False
            dgvSecciones.Columns("vigencia").HeaderText = "Vigencia"
        End If
    End Sub

    Private Sub dgvSecciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSecciones.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex <> dgvSecciones.NewRowIndex Then
            Dim fila As DataGridViewRow = dgvSecciones.Rows(e.RowIndex)

            If Not IsDBNull(fila.Cells("id_seccion").Value) Then
                idSeccionSeleccionada = Convert.ToInt32(fila.Cells("id_seccion").Value)

                txtNombre.Text = fila.Cells("Nombre").Value.ToString()
                txtAforo.Text = fila.Cells("Aforo").Value.ToString()

                If Not IsDBNull(fila.Cells("id_docente_tutor").Value) Then
                    cboTutor.SelectedValue = Convert.ToInt32(fila.Cells("id_docente_tutor").Value)
                Else
                    cboTutor.SelectedIndex = -1
                End If

                txtNombre.Enabled = True
                txtAforo.Enabled = True
                cboTutor.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If idGradoSeleccionado = 0 Then
            MessageBox.Show("Seleccione un grado primero del listado de grados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboTutor.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tutor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            objLogica.InsertarSeccion(idGradoSeleccionado, txtNombre.Text.Trim(), Convert.ToInt32(txtAforo.Text.Trim()), Convert.ToInt32(cboTutor.SelectedValue))
            CargarSecciones()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idSeccionSeleccionada > 0 Then
            Try
                dgvSecciones.EndEdit()

                Dim fila As DataGridViewRow = dgvSecciones.CurrentRow
                Dim valorVigencia As Integer = 0
                If Not IsDBNull(fila.Cells("Vigencia").Value) AndAlso Convert.ToBoolean(fila.Cells("Vigencia").Value) = True Then
                    valorVigencia = 1
                End If

                objLogica.ModificarSeccion(idSeccionSeleccionada, txtNombre.Text.Trim(), Convert.ToInt32(txtAforo.Text.Trim()), Convert.ToInt32(cboTutor.SelectedValue), valorVigencia)

                MessageBox.Show("Sección modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CargarSecciones()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al modificar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeccionSeleccionada > 0 Then
            Dim rpta As DialogResult = MessageBox.Show("¿Está seguro de eliminar definitivamente esta sección?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rpta = DialogResult.Yes Then
                Try
                    objLogica.EliminarSeccion(idSeccionSeleccionada)
                    MessageBox.Show("La sección ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarSecciones()
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione una sección del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If idSeccionSeleccionada > 0 Then
            Try
                Dim rpta As DialogResult = MessageBox.Show("¿Está seguro de dar de baja esta sección?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If rpta = DialogResult.Yes Then
                    objLogica.DarBajaSeccion(idSeccionSeleccionada)
                    MessageBox.Show("Sección dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarSecciones()
                    LimpiarCampos()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione una sección del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtAforo.Clear()
        cboTutor.SelectedIndex = -1
        idSeccionSeleccionada = 0
    End Sub
End Class
Imports capaLogica
Imports System.Data

Public Class frmTransaccionTutorAula

    Dim objTutor As New clsTutorAula()
    Dim idSeleccionado As Integer = 0

    Private Sub frmTransaccionTutorAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstilarGrid()
        CargarGrid()
        LimpiarCampos()
    End Sub

    ' ══════════════════════════════════════════════
    '  ESTILO DEL DATAGRIDVIEW
    ' ══════════════════════════════════════════════
    Private Sub EstilarGrid()
        With tblAsignacion
            .AllowUserToAddRows = False          ' <-- elimina la fila vacía extra
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(220, 220, 220)

            ' Cabecera
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 0, 0)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(4)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersHeight = 32
            .EnableHeadersVisualStyles = False

            ' Filas
            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.Padding = New Padding(4)
            .RowTemplate.Height = 26
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 235, 235)

            ' Selección
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 0, 0)
            .DefaultCellStyle.SelectionForeColor = Color.White
        End With
    End Sub

    ' ══════════════════════════════════════════════
    '  CARGAR GRID
    ' ══════════════════════════════════════════════
    Private Sub CargarGrid()
        Try
            tblAsignacion.DataSource = objTutor.MostrarTutores()
            tblAsignacion.AutoGenerateColumns = True

            For Each col As String In {"id_docente", "id_seccion"}
                If tblAsignacion.Columns.Contains(col) Then
                    tblAsignacion.Columns(col).Visible = False
                End If
            Next

            Dim headers As New Dictionary(Of String, String) From {
                {"id_tutor", "Código"},
                {"NombreDocente", "Docente"},
                {"NombreNivel", "Nivel"},
                {"NombreGrado", "Grado"},
                {"NombreSeccion", "Sección"},
                {"estado", "Estado"}
            }
            For Each par In headers
                If tblAsignacion.Columns.Contains(par.Key) Then
                    tblAsignacion.Columns(par.Key).HeaderText = par.Value
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CARGAR COMBOS
    ' ══════════════════════════════════════════════
    Private Sub CargarComboDocentes()
        Try
            Dim dt As DataTable = objTutor.ListarDocentes()
            cboDocente.DataSource = dt
            cboDocente.DisplayMember = "NombreCompleto"
            cboDocente.ValueMember = "id_docente"
            cboDocente.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboNiveles()
        Try
            Dim dt As DataTable = objTutor.ListarNiveles()
            cboNivel.DataSource = dt
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboGrados(idNivel As Integer)
        Try
            cboGrado.DataSource = Nothing
            cboGrado.Items.Clear()
            cboSeccion.DataSource = Nothing
            cboSeccion.Items.Clear()
            If idNivel <= 0 Then Exit Sub
            Dim dt As DataTable = objTutor.ListarGradosPorNivel(idNivel)
            cboGrado.DataSource = dt
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboSecciones(idGrado As Integer)
        Try
            cboSeccion.DataSource = Nothing
            cboSeccion.Items.Clear()
            If idGrado <= 0 Then Exit Sub
            Dim dt As DataTable = objTutor.ListarSeccionesPorGrado(idGrado)
            cboSeccion.DataSource = dt
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CASCADA: Nivel → Grado → Sección
    ' ══════════════════════════════════════════════
    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        If cboNivel.SelectedIndex = -1 OrElse IsNothing(cboNivel.SelectedValue) Then Exit Sub
        If Not TypeOf cboNivel.SelectedValue Is Integer Then Exit Sub   ' ← guarda clave
        CargarComboGrados(CInt(cboNivel.SelectedValue))
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        If cboGrado.SelectedIndex = -1 OrElse IsNothing(cboGrado.SelectedValue) Then Exit Sub
        If Not TypeOf cboGrado.SelectedValue Is Integer Then Exit Sub   ' ← guarda clave
        CargarComboSecciones(CInt(cboGrado.SelectedValue))
    End Sub

    ' ══════════════════════════════════════════════
    '  LIMPIAR / MODOS
    ' ══════════════════════════════════════════════
    Private Sub LimpiarCampos()

        cboDocente.DataSource = Nothing
        cboDocente.Items.Clear()
        cboNivel.DataSource = Nothing
        cboNivel.Items.Clear()
        cboGrado.DataSource = Nothing
        cboGrado.Items.Clear()
        cboSeccion.DataSource = Nothing
        cboSeccion.Items.Clear()

        checkEstado.Checked = True
        idSeleccionado = 0

        btnNuevo.Enabled = True
        btnActualizar.Enabled = False
        btnActualizar.Text = "Guardar"
        btnEliminar.Enabled = False
        btnDarBaja.Enabled = False
    End Sub

    Private Sub HabilitarModoEdicion()
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
        btnDarBaja.Enabled = True

    End Sub

    Private Sub HabilitarModoNuevo()
        btnActualizar.Enabled = True
        btnEliminar.Enabled = False
        btnDarBaja.Enabled = False

    End Sub

    ' ══════════════════════════════════════════════
    '  BOTONES PRINCIPALES
    ' ══════════════════════════════════════════════
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            idSeleccionado = 0

            CargarComboDocentes()
            CargarComboNiveles()
            checkEstado.Checked = True
            HabilitarModoNuevo()
            btnActualizar.Text = "Guardar"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If cboDocente.SelectedIndex = -1 OrElse IsNothing(cboDocente.SelectedValue) Then
                MessageBox.Show("Debe seleccionar un docente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If
            If cboSeccion.SelectedIndex = -1 OrElse IsNothing(cboSeccion.SelectedValue) Then
                MessageBox.Show("Debe seleccionar una sección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If

            Dim idDoc As Integer = CInt(cboDocente.SelectedValue)
            Dim idSec As Integer = CInt(cboSeccion.SelectedValue)
            Dim estado As Boolean = checkEstado.Checked

            If idSeleccionado = 0 Then
                If MessageBox.Show("¿Desea guardar el nuevo registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return
                objTutor.Insertar(idDoc, idSec, estado)
                MessageBox.Show("Registro guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Desea actualizar este registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return
                objTutor.Actualizar(idSeleccionado, idDoc, idSec, estado)
                MessageBox.Show("Registro actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarGrid()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If idSeleccionado <= 0 Then
                MessageBox.Show("Primero busque un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If
            If MessageBox.Show("¿Eliminar este registro?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

            objTutor.Eliminar(idSeleccionado)
            MessageBox.Show("Registro eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrid()
            LimpiarCampos()
        Catch ex As Exception
            If ex.Message.Contains("REFERENCE") OrElse ex.Message.Contains("FK") OrElse ex.Message.Contains("FOREIGN") Then
                If MessageBox.Show("Tiene dependencias. ¿Dar de baja en su lugar?", "No se puede eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Try
                        objTutor.DarBaja(idSeleccionado)
                        MessageBox.Show("Registro dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarGrid()
                        LimpiarCampos()
                    Catch ex2 As Exception
                        MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If idSeleccionado <= 0 Then
                MessageBox.Show("Primero busque un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
            End If
            If MessageBox.Show("¿Dar de baja este registro?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

            objTutor.DarBaja(idSeleccionado)
            MessageBox.Show("Registro dado de baja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrid()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN "+" — handlers separados y correctos
    ' ══════════════════════════════════════════════
    Private Sub btnAgregarDocente_Click(sender As Object, e As EventArgs) Handles btnAgregarDocente.Click
        Dim frm As New frmMantDocente()
        frm.ShowDialog()
        CargarComboDocentes()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If cboDocente.SelectedIndex = -1 OrElse IsNothing(cboDocente.SelectedValue) Then
                MessageBox.Show("Seleccione un docente para buscar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim idDoc As Integer = CInt(cboDocente.SelectedValue)
            tblAsignacion.DataSource = objTutor.MostrarPorDocente(idDoc)
            tblAsignacion.AutoGenerateColumns = True

            For Each col As String In {"id_docente", "id_seccion"}
                If tblAsignacion.Columns.Contains(col) Then
                    tblAsignacion.Columns(col).Visible = False
                End If
            Next

            Dim headers As New Dictionary(Of String, String) From {
                {"id_tutor", "Código"},
                {"NombreDocente", "Docente"},
                {"NombreNivel", "Nivel"},
                {"NombreGrado", "Grado"},
                {"NombreSeccion", "Sección"},
                {"estado", "Estado"}
            }
            For Each par In headers
                If tblAsignacion.Columns.Contains(par.Key) Then
                    tblAsignacion.Columns(par.Key).HeaderText = par.Value
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
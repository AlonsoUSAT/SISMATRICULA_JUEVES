Imports System.Data
Imports capaLogica
Imports capaLogica.capaLogica

Public Class frmHistorialAcademico

    ' Instancia de la capa lógica
    Private ReadOnly _logFicha As New clsLogHistorialAcademico()

    ' Variables para mantener el estado de la búsqueda
    Private _idEstudianteSeleccionado As Integer = 0
    Private _idAnoAcademicoSeleccionado As Integer = 0

    ' ============================================================
    ' EVENTO LOAD
    ' ============================================================
    Private Sub frmHistorialAcademico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarTodo()
        txtDNI.Focus()
    End Sub

    ' ============================================================
    ' BÚSQUEDA DE ESTUDIANTE
    ' ============================================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dni As String = txtDNI.Text.Trim()

        If String.IsNullOrWhiteSpace(dni) Then
            MessageBox.Show("Ingrese un DNI para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
            Return
        End If

        Try
            ' Obtener datos de la BD
            Dim dtEstudiante As DataTable = _logFicha.ObtenerDatosEstudianteCompleto(dni)

            If dtEstudiante.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún estudiante con el DNI proporcionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarTodo()
                txtDNI.Text = dni
                Return
            End If

            ' Extraer la primera fila de resultados
            Dim row As DataRow = dtEstudiante.Rows(0)
            _idEstudianteSeleccionado = Convert.ToInt32(row("id_estudiante"))

            ' ── Llenar cajas de texto de Datos Personales ──
            txtDNIDisplay.Text = row("DNI").ToString()
            txtNombreCompleto.Text = row("NombreCompleto").ToString()
            txtSexo.Text = row("Sexo").ToString()
            txtTipoEstudiante.Text = row("TipoEstudiante").ToString()
            txtTelefono.Text = row("Telefono").ToString()
            txtCorreo.Text = row("Correo").ToString()

            ' ── Llenar cajas de texto del Apoderado ──
            txtNombreApoderado.Text = row("NombreApoderado").ToString()
            txtTelefonoApoderado.Text = row("TelefonoApoderado").ToString()
            txtDniApoderado.Text = row("DNIApoderado").ToString()

            ' Actualizar el resumen visual
            lblResumen.Text = "Estudiante encontrado: " & txtNombreCompleto.Text

            ' Habilitar los paneles bloqueados
            pnlDatosPersonales.Enabled = True
            tabControlFicha.Enabled = True

            ' Cargar las tablas de historial
            CargarHistorialMatriculas()
            CargarHistorialBecas()

            ' Preparar la pestaña de cursos para cuando elijan un año
            dgvCursos.DataSource = Nothing
            lblAnoSeleccionado.Text = "Seleccione un año en 'Historial de Matrículas' (doble clic)"
            _idAnoAcademicoSeleccionado = 0

            ' Llevar al usuario a la primera pestaña automáticamente
            tabControlFicha.SelectedTab = tabMatriculas

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' CARGA DE HISTORIALES (GRILLAS)
    ' ============================================================
    Private Sub CargarHistorialMatriculas()
        Try
            Dim dt As DataTable = _logFicha.ObtenerHistorialMatriculas(_idEstudianteSeleccionado)
            dgvMatriculas.DataSource = dt
            lblTotalMatriculas.Text = "Total de matrículas registradas: " & dt.Rows.Count.ToString()

            ' Ocultar las columnas de IDs (solo sirven para código, no para la vista)
            If dgvMatriculas.Columns.Contains("id_anoAcademico") Then dgvMatriculas.Columns("id_anoAcademico").Visible = False
            If dgvMatriculas.Columns.Contains("id_matricula") Then dgvMatriculas.Columns("id_matricula").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar matrículas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarHistorialBecas()
        Try
            Dim dt As DataTable = _logFicha.ObtenerHistorialBecas(_idEstudianteSeleccionado)
            dgvBecas.DataSource = dt
            lblTotalBecas.Text = "Total de becas registradas: " & dt.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al cargar becas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' CARGAR CURSOS POR AÑO SELECCIONADO (DOBLE CLIC EN MATRÍCULAS)
    ' ============================================================
    Private Sub dgvMatriculas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatriculas.CellDoubleClick
        ' Si hace doble clic en el encabezado, ignoramos
        If e.RowIndex < 0 Then Return

        ' Capturar el ID del año de la fila seleccionada
        _idAnoAcademicoSeleccionado = Convert.ToInt32(dgvMatriculas.Rows(e.RowIndex).Cells("id_anoAcademico").Value)
        Dim anoTexto As String = dgvMatriculas.Rows(e.RowIndex).Cells("AnoAcademico").Value.ToString()

        lblAnoSeleccionado.Text = "Cursos y Horarios del año académico: " & anoTexto

        ' Cargar datos
        CargarCursosPorAno()

        ' Cambiar automáticamente a la pestaña de cursos
        tabControlFicha.SelectedTab = tabCursos
    End Sub

    Private Sub btnCargarCursos_Click(sender As Object, e As EventArgs) Handles btnCargarCursos.Click
        If _idAnoAcademicoSeleccionado > 0 Then
            CargarCursosPorAno()
        Else
            MessageBox.Show("Por favor, vaya a la pestaña 'Historial de Matrículas' y haga DOBLE CLIC en un año para ver sus cursos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CargarCursosPorAno()
        Try
            Dim dt As DataTable = _logFicha.ObtenerCursosYHorarios(_idEstudianteSeleccionado, _idAnoAcademicoSeleccionado)
            dgvCursos.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron cursos o carga académica para el año seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' LIMPIEZA Y CIERRE
    ' ============================================================
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodo()
        txtDNI.Focus()
    End Sub


    Private Sub LimpiarTodo()
        _idEstudianteSeleccionado = 0
        _idAnoAcademicoSeleccionado = 0

        txtDNI.Clear()

        ' Limpiar datos personales
        txtNombreCompleto.Clear()
        txtDNIDisplay.Clear()
        txtSexo.Clear()
        txtTipoEstudiante.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()

        ' Limpiar apoderado
        txtNombreApoderado.Clear()
        txtTelefonoApoderado.Clear()
        txtDniApoderado.Clear()

        ' Limpiar grillas
        dgvMatriculas.DataSource = Nothing
        dgvCursos.DataSource = Nothing
        dgvBecas.DataSource = Nothing

        lblTotalMatriculas.Text = ""
        lblTotalBecas.Text = ""
        lblAnoSeleccionado.Text = "Seleccione un año en 'Historial de Matrículas' (doble clic)"

        lblResumen.Text = "—  Busque un estudiante por DNI  —"

        ' Deshabilitar
        pnlDatosPersonales.Enabled = False
        tabControlFicha.Enabled = False
    End Sub

    ' ============================================================
    ' VALIDACIONES DE TECLADO
    ' ============================================================
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        ' Restringir a solo números y tecla de retroceso (borrar)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNI.KeyDown
        ' Ejecutar búsqueda al presionar "Enter"
        If e.KeyCode = Keys.Enter Then
            btnBuscar_Click(sender, e)
        End If
    End Sub

End Class
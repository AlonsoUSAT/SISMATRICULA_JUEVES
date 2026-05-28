Imports capaLogica

Public Class frmCargaAcademica
    Dim objLogica As New clCargaAcademica()
    Dim cargando As Boolean = False

    Private Sub frmCargaAcademica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar año activo en el TextBox
        txtAnio.Text = ModuloSesion.nombreAnoActivo
        txtAnio.ReadOnly = True
        dgvCargaAcademica.AllowUserToAddRows = False
        cargando = True
        CargarNiveles()
        CargarEspecialidades()
        cargando = False

        CargarListado()
    End Sub

    '--- NIVELES ---
    Private Sub CargarNiveles()
        Try
            Dim dt As DataTable = objLogica.MostrarNiveles()
            Dim fila As DataRow = dt.NewRow()
            fila("id_nivel") = 0
            fila("nombre") = "Todos..."
            dt.Rows.InsertAt(fila, 0)
            cboFiltroNivel.DisplayMember = "nombre"
            cboFiltroNivel.ValueMember = "id_nivel"
            cboFiltroNivel.DataSource = dt
            cboFiltroNivel.SelectedIndex = 0

            cboFiltroGrado.Enabled = False
            cboFiltroGrado.DataSource = Nothing
            cboFiltroSeccion.Enabled = False
            cboFiltroSeccion.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar niveles: " & ex.Message)
        End Try
    End Sub

    '--- ESPECIALIDADES ---
    Private Sub CargarEspecialidades()
        Try
            Dim dt As DataTable = objLogica.MostrarEspecialidades()
            Dim fila As DataRow = dt.NewRow()
            fila("id_especialidad") = 0
            fila("nombre") = "Todas..."
            dt.Rows.InsertAt(fila, 0)
            cboFiltroEspecialidad.DisplayMember = "nombre"
            cboFiltroEspecialidad.ValueMember = "id_especialidad"
            cboFiltroEspecialidad.DataSource = dt
            cboFiltroEspecialidad.SelectedIndex = 0

            cboFiltroDocente.Enabled = False
            cboFiltroDocente.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message)
        End Try
    End Sub

    '--- CASCADA NIVEL > GRADO ---
    Private Sub cboFiltroNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroNivel.SelectedIndexChanged
        If cargando Then Return

        cboFiltroGrado.DataSource = Nothing
        cboFiltroGrado.Enabled = False
        cboFiltroSeccion.DataSource = Nothing
        cboFiltroSeccion.Enabled = False

        Dim idNivel As Integer = Convert.ToInt32(cboFiltroNivel.SelectedValue)
        If idNivel = 0 Then
            AplicarFiltros()
            Return
        End If

        Try
            Dim dt As DataTable = objLogica.MostrarGradosPorNivel(idNivel)
            Dim fila As DataRow = dt.NewRow()
            fila("id_grado") = 0
            fila("nombre") = "Todos..."
            dt.Rows.InsertAt(fila, 0)
            cboFiltroGrado.DisplayMember = "nombre"
            cboFiltroGrado.ValueMember = "id_grado"
            cboFiltroGrado.DataSource = dt
            cboFiltroGrado.SelectedIndex = 0
            cboFiltroGrado.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar grados: " & ex.Message)
        End Try

        AplicarFiltros()
    End Sub

    '--- CASCADA GRADO > SECCIÓN ---
    Private Sub cboFiltroGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroGrado.SelectedIndexChanged
        If cargando Then Return

        cboFiltroSeccion.DataSource = Nothing
        cboFiltroSeccion.Enabled = False

        Dim idGrado As Integer = Convert.ToInt32(cboFiltroGrado.SelectedValue)
        If idGrado = 0 Then
            AplicarFiltros()
            Return
        End If

        Try
            Dim dt As DataTable = objLogica.MostrarSeccionesPorGrado(idGrado)
            Dim fila As DataRow = dt.NewRow()
            fila("id_seccion") = 0
            fila("nombre") = "Todas..."
            dt.Rows.InsertAt(fila, 0)
            cboFiltroSeccion.DisplayMember = "nombre"
            cboFiltroSeccion.ValueMember = "id_seccion"
            cboFiltroSeccion.DataSource = dt
            cboFiltroSeccion.SelectedIndex = 0
            cboFiltroSeccion.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar secciones: " & ex.Message)
        End Try

        AplicarFiltros()
    End Sub

    '--- CASCADA ESPECIALIDAD > DOCENTE ---
    Private Sub cboFiltroEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroEspecialidad.SelectedIndexChanged
        If cargando Then Return

        cboFiltroDocente.DataSource = Nothing
        cboFiltroDocente.Enabled = False

        Dim idEsp As Integer = Convert.ToInt32(cboFiltroEspecialidad.SelectedValue)
        If idEsp = 0 Then
            AplicarFiltros()
            Return
        End If

        Try
            Dim dt As DataTable = objLogica.MostrarDocentesPorEspecialidad(idEsp)
            Dim fila As DataRow = dt.NewRow()
            fila("id_docente") = 0
            fila("nombre_completo") = "Todos..."
            dt.Rows.InsertAt(fila, 0)
            cboFiltroDocente.DisplayMember = "nombre_completo"
            cboFiltroDocente.ValueMember = "id_docente"
            cboFiltroDocente.DataSource = dt
            cboFiltroDocente.SelectedIndex = 0
            cboFiltroDocente.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar docentes: " & ex.Message)
        End Try

        AplicarFiltros()
    End Sub

    Private Sub cboFiltroSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroSeccion.SelectedIndexChanged
        If cargando Then Return
        AplicarFiltros()
    End Sub

    Private Sub cboFiltroDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroDocente.SelectedIndexChanged
        If cargando Then Return
        AplicarFiltros()
    End Sub

    '--- LISTADO Y FILTROS ---
    Public Sub CargarListado()
        Try
            dgvCargaAcademica.DataSource = objLogica.MostrarCargaAcademica(
                ModuloSesion.idAnoAcademicoActivo)
        Catch ex As Exception
            MessageBox.Show("Error al cargar listado: " & ex.Message)
        End Try
    End Sub

    Private Sub AplicarFiltros()
        Try
            Dim idNivel As Integer = 0
            Dim idGrado As Integer = 0
            Dim idSeccion As Integer = 0
            Dim idEsp As Integer = 0
            Dim idDoc As Integer = 0

            If cboFiltroNivel.SelectedValue IsNot Nothing Then
                idNivel = Convert.ToInt32(cboFiltroNivel.SelectedValue)
            End If
            If cboFiltroGrado.Enabled AndAlso cboFiltroGrado.SelectedValue IsNot Nothing Then
                idGrado = Convert.ToInt32(cboFiltroGrado.SelectedValue)
            End If
            If cboFiltroSeccion.Enabled AndAlso cboFiltroSeccion.SelectedValue IsNot Nothing Then
                idSeccion = Convert.ToInt32(cboFiltroSeccion.SelectedValue)
            End If
            If cboFiltroEspecialidad.SelectedValue IsNot Nothing Then
                idEsp = Convert.ToInt32(cboFiltroEspecialidad.SelectedValue)
            End If
            If cboFiltroDocente.Enabled AndAlso cboFiltroDocente.SelectedValue IsNot Nothing Then
                idDoc = Convert.ToInt32(cboFiltroDocente.SelectedValue)
            End If

            dgvCargaAcademica.DataSource = objLogica.MostrarCargaFiltrada(
            ModuloSesion.idAnoAcademicoActivo, idNivel, idGrado, idSeccion, idEsp, idDoc)
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message)
        End Try
    End Sub


    '--- BOTONES ---
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargando = True
        CargarNiveles()
        CargarEspecialidades()
        cargando = False
        CargarListado()
    End Sub

    Private Sub btnNuevaAsignacion_Click(sender As Object, e As EventArgs) Handles btnNuevaAsignacion.Click
        Dim modal As New frmNuevaAsignacion(0)
        modal.ShowDialog(Me)
        CargarListado()
    End Sub

    '--- CLICK EN EL DGV (EDITAR / ELIMINAR) ---
    Private Sub dgvCargaAcademica_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaAcademica.CellClick
        If e.RowIndex < 0 Then Return
        If dgvCargaAcademica.Rows(e.RowIndex).Cells("ID").Value Is Nothing Then Return

        Dim idCarga As Integer = Convert.ToInt32(dgvCargaAcademica.Rows(e.RowIndex).Cells("ID").Value)

        ' EDITAR — usa el Name exacto de tu columna botón
        If e.ColumnIndex = dgvCargaAcademica.Columns("colEditar").Index Then
            Dim modal As New frmNuevaAsignacion(idCarga)
            modal.ShowDialog(Me)
            CargarListado()
        End If

        ' ELIMINAR — usa el Name exacto de tu columna botón
        If e.ColumnIndex = dgvCargaAcademica.Columns("colEliminar").Index Then
            Dim resp As DialogResult = MessageBox.Show(
            "¿Eliminar esta asignación?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Try
                    objLogica.EliminarCarga(idCarga)
                    MessageBox.Show("Asignación eliminada.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarListado()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub dgvCargaAcademica_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaAcademica.CellContentClick

    End Sub
End Class
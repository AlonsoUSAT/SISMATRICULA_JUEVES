Imports capaLogica

Public Class frmCargaAcademica
    Dim objLogica As New clCargaAcademica()

    Private Sub frmCargaAcademica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFiltros()
        CargarListado()
    End Sub

    Private Sub CargarFiltros()
        Try
            ' --- ComboBox Docente ---
            Dim dtDocentes As DataTable = objLogica.MostrarDocentes()
            Dim filaTodasDocente As DataRow = dtDocentes.NewRow()
            filaTodasDocente("id_docente") = 0
            filaTodasDocente("nombre_completo") = "Docente..."
            dtDocentes.Rows.InsertAt(filaTodasDocente, 0)
            cboFiltroDocente.DisplayMember = "nombre_completo"
            cboFiltroDocente.ValueMember = "id_docente"
            cboFiltroDocente.DataSource = dtDocentes
            cboFiltroDocente.SelectedIndex = 0

            ' --- ComboBox Sección ---
            Dim dtSecciones As DataTable = objLogica.MostrarSecciones()
            Dim filaTodasSeccion As DataRow = dtSecciones.NewRow()
            filaTodasSeccion("id_seccion") = 0
            filaTodasSeccion("nombre") = "Sección..."
            dtSecciones.Rows.InsertAt(filaTodasSeccion, 0)
            cboFiltroSeccion.DisplayMember = "nombre"
            cboFiltroSeccion.ValueMember = "id_seccion"
            cboFiltroSeccion.DataSource = dtSecciones
            cboFiltroSeccion.SelectedIndex = 0

            ' --- ComboBox Curso ---
            Dim dtCursos As DataTable = objLogica.MostrarCursos()
            Dim filaTodasCurso As DataRow = dtCursos.NewRow()
            filaTodasCurso("id_curso") = 0
            filaTodasCurso("nombreCurso") = "Curso..."
            dtCursos.Rows.InsertAt(filaTodasCurso, 0)
            cboFiltroCurso.DisplayMember = "nombreCurso"
            cboFiltroCurso.ValueMember = "id_curso"
            cboFiltroCurso.DataSource = dtCursos
            cboFiltroCurso.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar filtros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargarListado()
        Try
            dgvCargaAcademica.DataSource = objLogica.MostrarCargaAcademica()
        Catch ex As Exception
            MessageBox.Show("Error al cargar listado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AplicarFiltros()
        Try
            Dim idDocente As Integer = Convert.ToInt32(cboFiltroDocente.SelectedValue)
            Dim idSeccion As Integer = Convert.ToInt32(cboFiltroSeccion.SelectedValue)
            Dim idCurso As Integer = Convert.ToInt32(cboFiltroCurso.SelectedValue)
            dgvCargaAcademica.DataSource = objLogica.MostrarCargaFiltrada(idDocente, idSeccion, idCurso)
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboFiltroDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroDocente.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub cboFiltroSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroSeccion.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub cboFiltroCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroCurso.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub btnNuevaAsignacion_Click(sender As Object, e As EventArgs) Handles btnNuevaAsignacion.Click
        ' Abrimos el modal en modo NUEVO (id = 0)
        Dim modal As New frmNuevaAsignacion(0)
        modal.ShowDialog(Me)
        CargarListado() ' Refrescamos al cerrar el modal
    End Sub

    Private Sub dgvCargaAcademica_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaAcademica.CellClick
        If e.RowIndex < 0 Then Return

        ' Columna EDITAR (la antepenúltima, ajusta el índice según tus columnas)
        If e.ColumnIndex = dgvCargaAcademica.Columns("colEditar").Index Then
            Dim idCarga As Integer = Convert.ToInt32(dgvCargaAcademica.Rows(e.RowIndex).Cells("ID").Value)
            Dim modal As New frmNuevaAsignacion(idCarga)
            modal.ShowDialog(Me)
            CargarListado()
        End If

        ' Columna ELIMINAR
        If e.ColumnIndex = dgvCargaAcademica.Columns("colEliminar").Index Then
            Dim idCarga As Integer = Convert.ToInt32(dgvCargaAcademica.Rows(e.RowIndex).Cells("ID").Value)
            Dim respuesta As DialogResult = MessageBox.Show("¿Eliminar esta asignación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                Try
                    objLogica.EliminarCarga(idCarga)
                    MessageBox.Show("Asignación eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarListado()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

End Class
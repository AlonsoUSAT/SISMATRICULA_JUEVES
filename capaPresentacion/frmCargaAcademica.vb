Imports capaLogica

Public Class frmCargaAcademica
    Dim objLogica As New clCargaAcademica()
    Dim cargandoFiltros As Boolean = True

    Private Sub frmCargaAcademica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFiltros()
        cargandoFiltros = False
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

            ' --- ComboBox Horario ---
            Dim dtHorarios As DataTable = objLogica.MostrarHorarios()
            Dim filaTodosHorario As DataRow = dtHorarios.NewRow()
            filaTodosHorario("id_horario") = 0
            filaTodosHorario("descripcion") = "Horario..."
            dtHorarios.Rows.InsertAt(filaTodosHorario, 0)
            cboFiltroHorario.DisplayMember = "descripcion"
            cboFiltroHorario.ValueMember = "id_horario"
            cboFiltroHorario.DataSource = dtHorarios
            cboFiltroHorario.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar filtros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- MÉTODO NUEVO: Agrega los botones por código ---
    Private Sub AgregarColumnasBotones()
        ' Verificamos si la columna NO existe para crearla
        If Not dgvCargaAcademica.Columns.Contains("colEditar") Then
            Dim btnEditar As New DataGridViewButtonColumn()
            btnEditar.Name = "colEditar"
            btnEditar.HeaderText = "Editar"
            btnEditar.Text = "✎ Editar"
            btnEditar.UseColumnTextForButtonValue = True
            dgvCargaAcademica.Columns.Add(btnEditar)
        End If

        If Not dgvCargaAcademica.Columns.Contains("colEliminar") Then
            Dim btnEliminar As New DataGridViewButtonColumn()
            btnEliminar.Name = "colEliminar"
            btnEliminar.HeaderText = "Eliminar"
            btnEliminar.Text = "🗑 Eliminar"
            btnEliminar.UseColumnTextForButtonValue = True
            dgvCargaAcademica.Columns.Add(btnEliminar)
        End If
    End Sub

    Public Sub CargarListado()
        Try
            ' Quitamos el AutoGenerateColumns = False para que las genere solas
            dgvCargaAcademica.DataSource = objLogica.MostrarCargaAcademica()
            AgregarColumnasBotones() ' Agregamos los botones al final
        Catch ex As Exception
            MessageBox.Show("Error al cargar listado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AplicarFiltros()
        If cargandoFiltros Then Return

        Try
            Dim idDocente As Integer = If(cboFiltroDocente.SelectedValue IsNot Nothing, Convert.ToInt32(cboFiltroDocente.SelectedValue), 0)
            Dim idSeccion As Integer = If(cboFiltroSeccion.SelectedValue IsNot Nothing, Convert.ToInt32(cboFiltroSeccion.SelectedValue), 0)
            Dim idHorario As Integer = If(cboFiltroHorario.SelectedValue IsNot Nothing, Convert.ToInt32(cboFiltroHorario.SelectedValue), 0)

            dgvCargaAcademica.DataSource = objLogica.MostrarCargaFiltrada(idDocente, idSeccion, idHorario)
            AgregarColumnasBotones() ' Agregamos los botones después de filtrar también
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

    Private Sub cboFiltroHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroHorario.SelectedIndexChanged
        AplicarFiltros()
    End Sub

    Private Sub btnNuevaAsignacion_Click(sender As Object, e As EventArgs) Handles btnNuevaAsignacion.Click
        Dim modal As New frmNuevaAsignacion(0)
        modal.ShowDialog(Me)
        CargarListado()
    End Sub

    Private Sub dgvCargaAcademica_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaAcademica.CellClick
        If e.RowIndex < 0 Then Return

        ' Al usar columnas autogeneradas, obtenemos los nombres de los ALIAS de tu SQL (ID, Docente, Curso, etc)
        If dgvCargaAcademica.Columns(e.ColumnIndex).Name = "colEditar" Then
            Dim row As DataGridViewRow = dgvCargaAcademica.Rows(e.RowIndex)
            Dim idCarga As Integer = Convert.ToInt32(row.Cells("ID").Value)
            Dim docente As String = row.Cells("Docente").Value.ToString()
            Dim curso As String = row.Cells("Curso").Value.ToString()
            Dim seccion As String = row.Cells("Seccion").Value.ToString()
            Dim horario As String = row.Cells("Horario").Value.ToString()
            Dim estado As Boolean = Convert.ToBoolean(row.Cells("Estado").Value)

            Dim modal As New frmNuevaAsignacion(idCarga, docente, curso, seccion, horario, estado)
            modal.ShowDialog(Me)
            CargarListado()
        End If

        If dgvCargaAcademica.Columns(e.ColumnIndex).Name = "colEliminar" Then
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
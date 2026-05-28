Imports capaLogica

Public Class frmConsultaEspecialidad
    Dim objLogica As New clEspecialidad()

    Private Sub frmConsultaEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstilizarTarjetas()
        CargarFiltro()
        CargarResumen()
        CargarListado()
    End Sub

    Private Sub EstilizarTarjetas()
        ' Barra izquierda roja - Total
        Dim b1 As New Label()
        b1.Size = New Size(4, pnlTotal.Height)
        b1.BackColor = Color.FromArgb(139, 0, 0)
        b1.Location = New Point(0, 0)
        pnlTotal.Controls.Add(b1)
        b1.BringToFront()

        ' Barra izquierda verde - Vigentes
        Dim b2 As New Label()
        b2.Size = New Size(4, pnlVigentes.Height)
        b2.BackColor = Color.FromArgb(26, 122, 74)
        b2.Location = New Point(0, 0)
        pnlVigentes.Controls.Add(b2)
        b2.BringToFront()

        ' Barra izquierda roja oscuro - Bajas
        Dim b3 As New Label()
        b3.Size = New Size(4, pnlBajas.Height)
        b3.BackColor = Color.FromArgb(153, 27, 27)
        b3.Location = New Point(0, 0)
        pnlBajas.Controls.Add(b3)
        b3.BringToFront()
    End Sub

    Private Sub CargarFiltro()
        cboFiltro.Items.Clear()
        cboFiltro.Items.Add("Todas")
        cboFiltro.Items.Add("Solo vigentes")
        cboFiltro.Items.Add("Solo dadas de baja")
        cboFiltro.SelectedIndex = 0
    End Sub

    Private Sub CargarResumen()
        Try
            Dim vigentes As Integer = objLogica.ContarPorEstado(1)
            Dim bajas As Integer = objLogica.ContarPorEstado(0)
            lblTotall.Text = (vigentes + bajas).ToString()
            lblVigente.Text = vigentes.ToString()
            lblBaja.Text = bajas.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al cargar resumen: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarListado()
        Try
            Dim dt As DataTable = objLogica.MostrarEspecialidades()
            dgvEspecialidades.DataSource = dt
            lblContar.Text = "Mostrando " & dt.Rows.Count.ToString() & " especialidad(es)"
            ' Limpiar detalle al recargar
            dgvDocentes.DataSource = Nothing
            lblEspSeleccionada.Text = "— Selecciona una especialidad —"
            lblContadorDocentes.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged
        Try
            Dim dt As DataTable
            Select Case cboFiltro.SelectedIndex
                Case 0
                    dt = objLogica.MostrarEspecialidades()
                Case 1
                    dt = objLogica.MostrarFiltradas("vigente")
                Case 2
                    dt = objLogica.MostrarFiltradas("baja")
                Case Else
                    dt = objLogica.MostrarEspecialidades()
            End Select
            dgvEspecialidades.DataSource = dt
            lblContar.Text = "Mostrando " & dt.Rows.Count.ToString() & " especialidad(es)"
            dgvDocentes.DataSource = Nothing
            lblEspSeleccionada.Text = "— Selecciona una especialidad —"
            lblContadorDocentes.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEspecialidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEspecialidades.CellClick
        If e.RowIndex < 0 Then Return

        Dim fila As DataGridViewRow = dgvEspecialidades.Rows(e.RowIndex)
        Dim idEsp As Integer = Convert.ToInt32(fila.Cells("ID").Value)
        Dim nombreEsp As String = fila.Cells("Nombre").Value.ToString()

        lblEspSeleccionada.Text = "Especialidad: " & nombreEsp

        Try
            Dim dt As DataTable = objLogica.MostrarDocentesPorEspecialidad(idEsp)
            dgvDocentes.DataSource = dt
            lblContadorDocentes.Text = dt.Rows.Count.ToString() & " docente(s)"
        Catch ex As Exception
            MessageBox.Show("Error al cargar docentes: " & ex.Message)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
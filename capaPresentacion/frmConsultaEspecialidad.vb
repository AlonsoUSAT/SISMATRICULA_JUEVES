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
        ' Panel contenedor de las 3 tarjetas
        pnlTotal.BackColor = Color.White
        pnlVigentes.BackColor = Color.White
        pnlBajas.BackColor = Color.White

        ' Borde izquierdo de color como acento visual
        ' Total — azul oscuro
        Dim lblLineaTotal As New Label()
        lblLineaTotal.Size = New Size(4, pnlTotal.Height)
        lblLineaTotal.BackColor = Color.FromArgb(139, 0, 0)
        lblLineaTotal.Location = New Point(0, 0)
        pnlTotal.Controls.Add(lblLineaTotal)

        ' Vigentes — verde
        Dim lblLineaVig As New Label()
        lblLineaVig.Size = New Size(4, pnlVigentes.Height)
        lblLineaVig.BackColor = Color.FromArgb(26, 122, 74)
        lblLineaVig.Location = New Point(0, 0)
        pnlVigentes.Controls.Add(lblLineaVig)

        ' Bajas — rojo
        Dim lblLineaBaja As New Label()
        lblLineaBaja.Size = New Size(4, pnlBajas.Height)
        lblLineaBaja.BackColor = Color.FromArgb(153, 27, 27)
        lblLineaBaja.Location = New Point(0, 0)
        pnlBajas.Controls.Add(lblLineaBaja)
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
            Dim total As Integer = objLogica.ContarPorEstado(1) + objLogica.ContarPorEstado(0)
            Dim vigentes As Integer = objLogica.ContarPorEstado(1)
            Dim bajas As Integer = objLogica.ContarPorEstado(0)
            lblTotal.Text = total.ToString()
            lblVigentes.Text = vigentes.ToString()
            lblBajas.Text = bajas.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al cargar resumen: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarListado()
        Try
            Dim dt As DataTable = objLogica.MostrarEspecialidades()
            dgvEspecialidades.DataSource = dt
            lblContador.Text = "Mostrando " & dt.Rows.Count.ToString() & " especialidad(es)"
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
            lblContador.Text = "Mostrando " & dt.Rows.Count.ToString() & " especialidad(es)"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
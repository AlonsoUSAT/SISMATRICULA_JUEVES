Imports capaLogica

Public Class frmConsultaMatriculas



    Dim objLogica As New clsLogConsultaMatriculas()


    Dim _idAnoAcademico As Integer = 0
    Private Sub frmConsultaMatriculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtAno.ReadOnly = True
        txtAno.BackColor = SystemColors.Control


        _idAnoAcademico = objLogica.ObtenerAnoAcademicoActual()
        txtAno.Text = If(_idAnoAcademico > 0, Date.Today.Year.ToString(), "Sin año activo")


        txtTotal.ReadOnly = True
        txtBecados.ReadOnly = True
        txtNoBecados.ReadOnly = True

        CargarNiveles()
        ConfigurarGrid()
        LimpiarResumen()
    End Sub



    Private Sub CargarNiveles()
        RemoveHandler cmbNivel.SelectedIndexChanged, AddressOf cmbNivel_SelectedIndexChanged

        cmbNivel.DataSource = objLogica.ObtenerNiveles(_idAnoAcademico)
        cmbNivel.DisplayMember = "nombre"
        cmbNivel.ValueMember = "id_nivel"
        cmbNivel.SelectedIndex = 0

        AddHandler cmbNivel.SelectedIndexChanged, AddressOf cmbNivel_SelectedIndexChanged
    End Sub

    Private Sub cmbNivel_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cmbNivel.SelectedIndexChanged

        RemoveHandler cmbGrado.SelectedIndexChanged, AddressOf cmbGrado_SelectedIndexChanged
        cmbGrado.DataSource = Nothing
        cmbSeccion.DataSource = Nothing

        Dim idNivel As Integer = 0
        If cmbNivel.SelectedValue IsNot Nothing Then
            Integer.TryParse(cmbNivel.SelectedValue.ToString(), idNivel)
        End If

        If idNivel > 0 Then
            cmbGrado.DataSource = objLogica.ObtenerGradosPorNivel(idNivel, _idAnoAcademico)
            cmbGrado.DisplayMember = "nombre"
            cmbGrado.ValueMember = "id_grado"
            cmbGrado.SelectedIndex = 0
        End If

        AddHandler cmbGrado.SelectedIndexChanged, AddressOf cmbGrado_SelectedIndexChanged
    End Sub

    Private Sub cmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cmbGrado.SelectedIndexChanged

        cmbSeccion.DataSource = Nothing
        If cmbGrado.SelectedValue Is Nothing Then Return

        Dim idGrado As Integer = 0
        Integer.TryParse(cmbGrado.SelectedValue.ToString(), idGrado)

        If idGrado > 0 Then
            cmbSeccion.DataSource = objLogica.ObtenerSeccionesPorGrado(idGrado, _idAnoAcademico)
            cmbSeccion.DisplayMember = "nombre"
            cmbSeccion.ValueMember = "id_seccion"
            cmbSeccion.SelectedIndex = 0
        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim idNivel As Integer = 0
            Dim idGrado As Integer = 0
            Dim idSeccion As Integer = 0

            If cmbNivel.SelectedValue IsNot Nothing Then
                Integer.TryParse(cmbNivel.SelectedValue.ToString(), idNivel)
            End If
            If cmbGrado.SelectedValue IsNot Nothing Then
                Integer.TryParse(cmbGrado.SelectedValue.ToString(), idGrado)
            End If
            If cmbSeccion.SelectedValue IsNot Nothing Then
                Integer.TryParse(cmbSeccion.SelectedValue.ToString(), idSeccion)
            End If

            Dim ano As Integer = objLogica.ValidarAno(txtAno.Text)


            Dim dtMat As DataTable = objLogica.ConsultarMatriculas(idNivel, idGrado, idSeccion, ano)
            dgvMatriculas.DataSource = dtMat


            MostrarResumen(idNivel, idGrado, idSeccion, ano)

            If dtMat.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron matrículas con ese filtro.",
                                "Sin resultados", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub MostrarResumen(idNivel As Integer, idGrado As Integer,
                                idSeccion As Integer, ano As Integer)
        Dim dt As DataTable = objLogica.ObtenerResumen(idNivel, idGrado, idSeccion, ano)
        If dt.Rows.Count = 0 Then Return
        Dim row As DataRow = dt.Rows(0)
        txtTotal.Text = row("total").ToString()
        txtBecados.Text = row("becados").ToString()
        txtNoBecados.Text = row("noBecados").ToString()
    End Sub

    Private Sub LimpiarResumen()
        txtTotal.Text = "0"
        txtBecados.Text = "0"
        txtNoBecados.Text = "0"
        dgvMatriculas.DataSource = Nothing
    End Sub



    Private Sub ConfigurarGrid()
        dgvMatriculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMatriculas.RowHeadersVisible = False
        dgvMatriculas.AllowUserToAddRows = False
        dgvMatriculas.ReadOnly = True
        dgvMatriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        RemoveHandler cmbNivel.SelectedIndexChanged, AddressOf cmbNivel_SelectedIndexChanged
        RemoveHandler cmbGrado.SelectedIndexChanged, AddressOf cmbGrado_SelectedIndexChanged

        cmbNivel.SelectedIndex = 0
        cmbGrado.DataSource = Nothing
        cmbSeccion.DataSource = Nothing

        AddHandler cmbNivel.SelectedIndexChanged, AddressOf cmbNivel_SelectedIndexChanged
        AddHandler cmbGrado.SelectedIndexChanged, AddressOf cmbGrado_SelectedIndexChanged


        LimpiarResumen()
    End Sub
End Class
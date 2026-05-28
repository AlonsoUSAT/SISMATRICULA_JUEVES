Imports capaLogica

Public Class frmApertura
    Dim objLogica As New clApertura()
    Dim LoadingData As Boolean = True

    Private Sub frmApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombosAñosIniciales()
        LlenarComboSeccionesEstatico()
        chkGrado.CheckOnClick = True
        LoadingData = False
        dgvTabla.AllowUserToAddRows = False
    End Sub

    Private Sub LlenarCombosAñosIniciales()
        Try
            Dim dtAnios As DataTable = objLogica.GetAniosDistinct()

            ' Combo Año - Parámetros Generación
            cboAño.DataSource = dtAnios
            cboAño.DisplayMember = "Anio"
            cboAño.ValueMember = "id_anoAcademico"
            cboAño.SelectedIndex = -1

            ' Combo Año - Listado (Clonamos para evitar cruces)
            cboAño2.DataSource = dtAnios.Copy()
            cboAño2.DisplayMember = "Anio"
            cboAño2.ValueMember = "id_anoAcademico"
            cboAño2.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar años: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarComboSeccionesEstatico()
        cboSeccion.Items.Add("A")
        cboSeccion.Items.Add("B")
        cboSeccion.Items.Add("C")
        cboSeccion.Items.Add("Única")
        cboSeccion.SelectedIndex = -1
    End Sub

    ' === Eventos Panel Generación ===

    Private Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged
        ' EL TRUCO ESTÁ AQUÍ: Evitar que falle si el SelectedValue aún es un DataRowView
        If LoadingData OrElse cboAño.SelectedIndex = -1 OrElse TypeOf cboAño.SelectedValue Is DataRowView Then Return

        Try
            ' Ahora sí es seguro convertir el ID a entero
            Dim idAnio As Integer = Convert.ToInt32(cboAño.SelectedValue)

            cboNivel.DataSource = objLogica.GetNivelesPorAnio(idAnio)
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.SelectedIndex = -1

            chkGrado.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar niveles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        If LoadingData OrElse cboNivel.SelectedIndex = -1 OrElse TypeOf cboNivel.SelectedValue Is DataRowView Then Return

        Try
            Dim idNivel As Integer = Convert.ToInt32(cboNivel.SelectedValue)
            chkGrado.DataSource = objLogica.GetGradosPorNivel(idNivel)
            chkGrado.DisplayMember = "nombre"
            chkGrado.ValueMember = "id_grado"
        Catch ex As Exception
            MessageBox.Show("Error al cargar grados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' === Eventos Panel Listado ===

    Private Sub cboAño2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño2.SelectedIndexChanged
        ' LA MISMA CONDICIÓN AQUÍ
        If LoadingData OrElse cboAño2.SelectedIndex = -1 OrElse TypeOf cboAño2.SelectedValue Is DataRowView Then Return

        Try
            Dim idAnio As Integer = Convert.ToInt32(cboAño2.SelectedValue)

            cboNivel2.DataSource = objLogica.GetNivelesPorAnio(idAnio)
            cboNivel2.DisplayMember = "nombre"
            cboNivel2.ValueMember = "id_nivel"
            cboNivel2.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar niveles (Listado): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboAño2.SelectedIndex = -1 Or cboNivel2.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione Año y Nivel para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idAnio As Integer = Convert.ToInt32(cboAño2.SelectedValue)
            Dim idNivel As Integer = Convert.ToInt32(cboNivel2.SelectedValue)

            dgvTabla.DataSource = objLogica.BuscarGruposAsignadosListado(idAnio, idNivel)
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' === Evento Generar ===

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cboAño.SelectedIndex = -1 Or cboNivel.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione Año y Nivel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboSeccion.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cboSeccion.Text) Then
            MessageBox.Show("Seleccione una Sección (A, B, Única).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim aforo As Integer = 30
        If Not String.IsNullOrWhiteSpace(txtAforo.Text) Then
            If Not Integer.TryParse(txtAforo.Text, aforo) Then
                MessageBox.Show("El aforo debe ser un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim listaGrados As New List(Of Integer)()

        For Each item As DataRowView In chkGrado.CheckedItems
            listaGrados.Add(Convert.ToInt32(item("id_grado")))
        Next

        If listaGrados.Count = 0 Then
            MessageBox.Show("Seleccione al menos un Grado en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim resp As DialogResult = MessageBox.Show($"¿Generar sección '{cboSeccion.Text}' para los grados seleccionados?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = DialogResult.Yes Then
            Try
                objLogica.GenerarAperturaMasivaGrados(listaGrados, cboSeccion.Text.Trim(), aforo)

                MessageBox.Show("Secciones generadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar
                cboSeccion.SelectedIndex = -1
                txtAforo.Clear()
                For i As Integer = 0 To chkGrado.Items.Count - 1
                    chkGrado.SetItemChecked(i, False)
                Next

                ' Refrescar tabla si los filtros coinciden
                If cboAño2.SelectedIndex <> -1 And cboNivel2.SelectedIndex <> -1 Then
                    btnBuscar_Click(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al generar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtAforo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAforo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub
End Class
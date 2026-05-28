Imports capaLogica

Public Class frmMantMatricula

    Dim objLogica As New clsLogMantMatricula()
    Dim idMatriculaActual As Integer = 0
    Dim idGradoActual As Integer = 0

    Private Sub frmMantMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtTipos As DataTable = objLogica.ObtenerTiposDocumento()
        cboTipo.DataSource = dtTipos
        cboTipo.DisplayMember = "nombreTipoDocumento"
        cboTipo.ValueMember = "id_tipoDocumento"
        Dim indexDNI As Integer = cboTipo.FindStringExact("DNI")
        If indexDNI <> -1 Then cboTipo.SelectedIndex = indexDNI


        txtEstudiante.ReadOnly = True
        txtNivel.ReadOnly = True
        txtGrado.ReadOnly = True
        txtVacantes.ReadOnly = True
        dtpFecha.Enabled = False
        chkActivo.Enabled = False
        cboSeccion.Enabled = False
        txtObservacion.Enabled = False
        btnActualizar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboTipo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtNro.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el número de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tipoDoc As String = cboTipo.Text.Trim().ToUpper()
        Dim numDoc As String = txtNro.Text.Trim()

        Select Case tipoDoc
            Case "DNI"
                If numDoc.Length <> 8 OrElse Not numDoc.All(Function(c) Char.IsDigit(c)) Then
                    MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "CE"
                If numDoc.Length < 9 OrElse numDoc.Length > 12 OrElse Not numDoc.All(Function(c) Char.IsLetterOrDigit(c)) Then
                    MessageBox.Show("El CE debe tener entre 9 y 12 caracteres alfanuméricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case Else
                MessageBox.Show("Tipo de documento no reconocido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        Try
            Dim dt As DataTable = objLogica.ObtenerMatriculaPorDoc(numDoc)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontró matrícula activa para ese documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
                Return
            End If

            Dim r As DataRow = dt.Rows(0)
            idMatriculaActual = Convert.ToInt32(r("id_matricula"))
            idGradoActual = Convert.ToInt32(r("id_grado"))

            chkActivo.Checked = Convert.ToBoolean(r("estadoMatricula"))
            dtpFecha.Value = Convert.ToDateTime(r("fecha"))
            txtEstudiante.Text = r("estudiante").ToString()
            txtNivel.Text = r("nivel").ToString()
            txtGrado.Text = r("grado").ToString()
            txtObservacion.Text = r("observacionMatricula").ToString()

            CargarSecciones(idGradoActual, Convert.ToInt32(r("id_seccion")))

            cboSeccion.Enabled = True
            txtObservacion.Enabled = True
            btnActualizar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarSecciones(idGrado As Integer, idSeccionActual As Integer)
        RemoveHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged
        Dim dt As DataTable = objLogica.ObtenerSeccionesPorGrado(idGrado)
        cboSeccion.DataSource = dt
        cboSeccion.DisplayMember = "nombre"
        cboSeccion.ValueMember = "id_seccion"
        cboSeccion.SelectedValue = idSeccionActual
        AddHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged
        MostrarVacantes(idSeccionActual)
    End Sub

    Private Sub MostrarVacantes(idSeccion As Integer)
        Dim estado As String = objLogica.VerificarVacantes(idSeccion)
        txtVacantes.Text = estado
        txtVacantes.ForeColor = If(estado.Contains("AGOTADO"), Color.Red, Color.DarkGreen)
    End Sub

    Private Sub cboSeccion_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboSeccion.SelectedValue IsNot Nothing AndAlso IsNumeric(cboSeccion.SelectedValue) Then
            MostrarVacantes(Convert.ToInt32(cboSeccion.SelectedValue))
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If idMatriculaActual = 0 Then
            MessageBox.Show("Busque una matrícula primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cboSeccion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una sección.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtVacantes.Text.Contains("AGOTADO") Then
            MessageBox.Show("La sección no tiene vacantes disponibles.", "Sin vacantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("¿Desea actualizar los datos de la matrícula?",
                                                       "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Try
            objLogica.ActualizarMatricula(idMatriculaActual,
                                          Convert.ToInt32(cboSeccion.SelectedValue),
                                          txtObservacion.Text.Trim())
            MessageBox.Show("Matrícula actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)


            MostrarVacantes(Convert.ToInt32(cboSeccion.SelectedValue))

            btnActualizar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        idMatriculaActual = 0
        idGradoActual = 0
        txtNro.Clear()
        chkActivo.Checked = False
        dtpFecha.Value = DateTime.Now
        txtEstudiante.Clear()
        txtNivel.Clear()
        txtGrado.Clear()
        cboSeccion.DataSource = Nothing
        txtVacantes.Clear()
        txtObservacion.Clear()
        cboSeccion.Enabled = False
        txtObservacion.Enabled = False
        btnActualizar.Enabled = False
        Dim indexDNI As Integer = cboTipo.FindStringExact("DNI")
        If indexDNI <> -1 Then cboTipo.SelectedIndex = indexDNI
    End Sub

    Private Sub txtNro_TextChanged(sender As Object, e As EventArgs) Handles txtNro.TextChanged
        Dim tipoDoc As String = cboTipo.Text.Trim().ToUpper()
        Dim soloNumeros As String = New String(txtNro.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim soloAlfanumerico As String = New String(txtNro.Text.Where(Function(c) Char.IsLetterOrDigit(c)).ToArray())
        Select Case tipoDoc
            Case "DNI"
                If txtNro.Text <> soloNumeros.Substring(0, Math.Min(soloNumeros.Length, 8)) Then
                    txtNro.Text = soloNumeros.Substring(0, Math.Min(soloNumeros.Length, 8))
                    txtNro.SelectionStart = txtNro.Text.Length
                End If
            Case "CE"
                If txtNro.Text <> soloAlfanumerico.Substring(0, Math.Min(soloAlfanumerico.Length, 12)) Then
                    txtNro.Text = soloAlfanumerico.Substring(0, Math.Min(soloAlfanumerico.Length, 12))
                    txtNro.SelectionStart = txtNro.Text.Length
                End If
        End Select
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        txtNro.Enabled = cboTipo.SelectedIndex <> -1
        txtNro.Clear()
    End Sub


End Class
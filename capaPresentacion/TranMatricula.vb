Imports capaLogica

Public Class TranMatricula

    Private objLogicaMatricula As New clsLogMatricula()


    Private _idEstudianteSeleccionado As Integer = 0


    Private cargandoCombos As Boolean = True


    Private Sub TranMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtVacante.ReadOnly = True

        txtCodOperativo.MaxLength = 8
        txtRefBancaria.MaxLength = 12
        TxtDNI.MaxLength = 8

        txtFechaPago.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtFechaPago.ReadOnly = True

        dgvCronograma.Rows.Clear()

        Try

            cargandoCombos = True


            Dim dtDocumentos As DataTable = objLogicaMatricula.ListarTiposDocumento()
            cboTipoDocumento.DataSource = dtDocumentos
            cboTipoDocumento.DisplayMember = "nombreTipoDocumento"
            cboTipoDocumento.ValueMember = "id_tipoDocumento"


            cboGrado.Enabled = False
            cboSeccion.Enabled = False

            Dim dtNivel As DataTable = objLogicaMatricula.ListarNiveles()
            cboNivel.DataSource = dtNivel
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.SelectedIndex = -1


            cargandoCombos = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar las listas: " & ex.Message, "Error Inicial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged

        If cargandoCombos OrElse cboNivel.SelectedIndex = -1 Then Return
        If TypeOf cboNivel.SelectedValue IsNot Integer Then Return

        Try
            Dim idNivel As Integer = Convert.ToInt32(cboNivel.SelectedValue)

            Dim dtGrados As DataTable = objLogicaMatricula.ListarGradosPorNivel(idNivel)
            cboGrado.DataSource = dtGrados
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.SelectedIndex = -1

            cboGrado.Enabled = True
            cboSeccion.DataSource = Nothing
            cboSeccion.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar los grados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged

        If cargandoCombos OrElse cboGrado.SelectedIndex = -1 Then Return
        If TypeOf cboGrado.SelectedValue IsNot Integer Then Return

        Try
            Dim idGrado As Integer = Convert.ToInt32(cboGrado.SelectedValue)

            Dim dtSecciones As DataTable = objLogicaMatricula.ListarSeccionesPorGrado(idGrado)
            cboSeccion.DataSource = dtSecciones
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.SelectedIndex = -1

            cboSeccion.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar las secciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub BtnBuscarEstudiante_Click_1(sender As Object, e As EventArgs) Handles BtnBuscarEstudiante.Click
        Dim dniABuscar As String = TxtDNI.Text.Trim()

        If dniABuscar.Length = 8 Then
            Try
                Dim dtEstudiante As DataTable = objLogicaMatricula.BuscarEstudiantePorDNI(dniABuscar)

                If dtEstudiante.Rows.Count > 0 Then
                    _idEstudianteSeleccionado = Convert.ToInt32(dtEstudiante.Rows(0)("id_estudiante"))
                    txtEstudiante.Text = dtEstudiante.Rows(0)("NombreEstudiante").ToString()
                    txtApoderado.Text = dtEstudiante.Rows(0)("NombreApoderado").ToString()

                    txtEstudiante.ReadOnly = True
                    txtApoderado.ReadOnly = True
                Else
                    MessageBox.Show("No se encontró ningún estudiante con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _idEstudianteSeleccionado = 0
                    txtEstudiante.Clear()
                    txtApoderado.Clear()
                End If

                If dtEstudiante.Rows.Count > 0 Then
                    _idEstudianteSeleccionado = Convert.ToInt32(dtEstudiante.Rows(0)("id_estudiante"))
                    txtEstudiante.Text = dtEstudiante.Rows(0)("NombreEstudiante").ToString()
                    txtApoderado.Text = dtEstudiante.Rows(0)("NombreApoderado").ToString()
                    txtEstudiante.ReadOnly = True
                    txtApoderado.ReadOnly = True
                Else

                    MessageBox.Show("Este DNI no pertenece a ningún estudiante matriculado o activo." & vbCrLf & vbCrLf &
                                    "Por favor, haga clic en el botón 'Agregar estudiante' para registrar sus datos primero.",
                                    "Estudiante No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    _idEstudianteSeleccionado = 0
                    txtEstudiante.Clear()
                    txtApoderado.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar en la BD: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El DNI debe tener 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnProcesarMatricula_Click(sender As Object, e As EventArgs) Handles btnProcesarMatricula.Click

        If _idEstudianteSeleccionado = 0 Then
            MessageBox.Show("Debe buscar y seleccionar un estudiante primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If cboSeccion.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una sección para asignar la vacante.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If txtCodOperativo.Text.Trim().Length < 6 Then
            MessageBox.Show("El Código Operativo del voucher es muy corto. Debe tener al menos 6 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodOperativo.Focus()
            Return
        End If


        If txtRefBancaria.Text.Trim().Length < 6 Then
            MessageBox.Show("La Referencia Bancaria es muy corta. Revise el recibo del banco.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRefBancaria.Focus()
            Return
        End If


        Dim montoIngresado As Decimal = 0

        If Decimal.TryParse(txtMonto.Text, montoIngresado) = False OrElse montoIngresado < 350 Then
            MessageBox.Show("El monto ingresado no es válido. La matrícula mínima es de S/ 350.00", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMonto.Focus()
            Return
        End If


        Try
            Dim idEstudiante As Integer = _idEstudianteSeleccionado
            Dim idSeccion As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
            Dim monto As Decimal = montoIngresado
            Dim codOperativo As String = txtCodOperativo.Text.Trim()
            Dim refBancaria As String = txtRefBancaria.Text.Trim()


            Dim textoObservacion As String = txtObservacion.Text.Trim()


            If textoObservacion = "" Then
                textoObservacion = "Ninguna"
            End If


            Dim exito As Boolean = objLogicaMatricula.ProcesarMatricula(idEstudiante, idSeccion, monto, codOperativo, refBancaria, textoObservacion)

            If exito Then
                MessageBox.Show("¡Matrícula procesada con éxito! Se ha generado el cronograma de pagos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GenerarProyeccionCronograma()

                txtObservacion.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerarProyeccionCronograma()

        dgvCronograma.Columns.Clear()
        dgvCronograma.Rows.Clear()


        dgvCronograma.DefaultCellStyle.ForeColor = Color.Black


        dgvCronograma.Columns.Add("Concepto", "Concepto")
        dgvCronograma.Columns.Add("Vencimiento", "Vencimiento")
        dgvCronograma.Columns.Add("Monto", "Monto (S/)")
        dgvCronograma.Columns.Add("Estado", "Estado")


        dgvCronograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Dim montoCuota As Decimal = 350.0

        For i As Integer = 3 To 12
            Dim conceptoPrension As String = "Pensión " & (i - 2).ToString("D2")
            Dim fechaVencimiento As New DateTime(DateTime.Now.Year, i, 10)


            dgvCronograma.Rows.Add(conceptoPrension, fechaVencimiento.ToString("dd/MM/yyyy"), montoCuota.ToString("C2"), "Pendiente")
        Next
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        If txtMonto.Text = "" Then
            txtMonto.BackColor = Color.LightPink
        Else
            txtMonto.BackColor = Color.White
        End If
    End Sub

    Private Sub txtVacante_TextChanged(sender As Object, e As EventArgs) Handles txtVacante.TextChanged

    End Sub

    Private Sub cboSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeccion.SelectedIndexChanged

        If cargandoCombos OrElse cboSeccion.SelectedIndex = -1 Then
            txtVacante.Clear()
            Return
        End If

        If TypeOf cboSeccion.SelectedValue IsNot Integer Then Return

        Try
            Dim idSeccion As Integer = Convert.ToInt32(cboSeccion.SelectedValue)


            Dim vacantes As Integer = objLogicaMatricula.ObtenerVacantesDisponibles(idSeccion)


            txtVacante.Text = vacantes.ToString() & " vacantes disponibles"


            If vacantes <= 0 Then
                txtVacante.BackColor = Color.LightCoral
                txtVacante.Text = "Sección Llena (0 vacantes)"
            Else
                txtVacante.BackColor = Color.LightGreen
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar las vacantes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CamposNumericos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodOperativo.KeyPress, txtRefBancaria.KeyPress, TxtDNI.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If


        Dim cajaTexto As TextBox = CType(sender, TextBox)
        If (e.KeyChar = "."c OrElse e.KeyChar = ","c) AndAlso (cajaTexto.Text.Contains(".") OrElse cajaTexto.Text.Contains(",")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
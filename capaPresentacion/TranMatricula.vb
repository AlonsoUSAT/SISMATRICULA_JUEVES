Imports capaLogica

Public Class TranMatricula

    Private objLogicaMatricula As New clsLogMatricula()


    Private _idEstudianteSeleccionado As Integer = 0


    Private cargandoCombos As Boolean = True


    Private Sub TranMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtVacante.ReadOnly = True

        txtEstudiante.ReadOnly = True
        txtApoderado.ReadOnly = True


        txtMonto.ReadOnly = True
        txtMonto.BackColor = SystemColors.Control


        txtObservacion.ReadOnly = True
        txtObservacion.BackColor = SystemColors.Control


        txtEstudiante.BackColor = SystemColors.Control
        txtApoderado.BackColor = SystemColors.Control

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



            cboNivel.Enabled = False
            cboGrado.Enabled = False
            cboSeccion.Enabled = False

            cargandoCombos = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar las listas: " & ex.Message, "Error Inicial", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged

        If cargandoCombos OrElse cboNivel.SelectedIndex = -1 Then Return


        Dim idNivel As Integer
        If Integer.TryParse(cboNivel.SelectedValue.ToString(), idNivel) = False Then Return

        Try


            Dim dtGrados As DataTable = objLogicaMatricula.ListarGradosPorNivel(idNivel)
            cboGrado.DataSource = dtGrados
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.SelectedIndex = -1

            cboGrado.Enabled = True
            cboSeccion.DataSource = Nothing
            cboSeccion.Enabled = False


            Dim nombreNivel As String = cboNivel.Text.ToUpper()

            If nombreNivel.Contains("PRIMARIA") Then
                txtMonto.Text = "300.00"
            ElseIf nombreNivel.Contains("SECUNDARIA") Then
                txtMonto.Text = "400.00"
            Else
                txtMonto.Text = "0.00"
            End If


        Catch ex As Exception
            MessageBox.Show("Error al cargar los grados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged

        If cargandoCombos OrElse cboGrado.SelectedIndex = -1 Then Return


        Dim idGrado As Integer
        If Integer.TryParse(cboGrado.SelectedValue.ToString(), idGrado) = False Then Return

        Try


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
                    txtObservacion.ReadOnly = False
                    txtObservacion.BackColor = Color.White

                    _idEstudianteSeleccionado = Convert.ToInt32(dtEstudiante.Rows(0)("id_estudiante"))


                    If objLogicaMatricula.ValidarMatriculaActual(_idEstudianteSeleccionado) Then
                        MessageBox.Show("ALERTA: Este estudiante ya se encuentra matriculado para el año académico actual." & vbCrLf & vbCrLf &
                                        "No se puede realizar una doble matrícula.", "Matrícula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Stop)


                        _idEstudianteSeleccionado = 0
                        txtEstudiante.Clear()
                        txtApoderado.Clear()
                        cboNivel.SelectedIndex = -1


                        Return
                    End If

                    txtEstudiante.Text = dtEstudiante.Rows(0)("NombreEstudiante").ToString()
                    txtApoderado.Text = dtEstudiante.Rows(0)("NombreApoderado").ToString()
                    txtEstudiante.ReadOnly = True
                    txtApoderado.ReadOnly = True


                    cboNivel.Enabled = True


                    Dim dtHistorial As DataTable = objLogicaMatricula.ObtenerUltimoGradoEstudiante(_idEstudianteSeleccionado)

                    If dtHistorial.Rows.Count > 0 Then
                        Dim ultimoIdNivel As Integer = Convert.ToInt32(dtHistorial.Rows(0)("id_nivel"))

                        cboNivel.SelectedValue = ultimoIdNivel
                    Else

                        cboNivel.SelectedIndex = -1
                    End If


                Else

                    MessageBox.Show("Este DNI no pertenece a ningún estudiante matriculado o activo." & vbCrLf & vbCrLf &
                                    "Por favor, haga clic en el botón 'Agregar estudiante' para registrar sus datos primero.",
                                    "Estudiante No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    _idEstudianteSeleccionado = 0
                    txtEstudiante.Clear()
                    txtApoderado.Clear()


                    cargandoCombos = True

                    cboNivel.SelectedIndex = -1
                    cboNivel.Enabled = False



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
        If Decimal.TryParse(txtMonto.Text, montoIngresado) = False OrElse montoIngresado <= 0 Then
            MessageBox.Show("Debe seleccionar un Nivel válido para generar el monto de la matrícula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim codOperativoAVerificar As String = txtCodOperativo.Text.Trim()

        If objLogicaMatricula.ValidarVoucherDuplicado(codOperativoAVerificar) Then
            MessageBox.Show("ALERTA DE SEGURIDAD: Este Código Operativo ya ha sido registrado en otra matrícula." & vbCrLf & vbCrLf &
                            "Por favor, verifique el comprobante físico. No se puede procesar un pago duplicado.",
                            "Voucher Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            txtCodOperativo.Focus()
            txtCodOperativo.SelectAll()
            Return
        End If



        Try
            Dim idEstudiante As Integer = _idEstudianteSeleccionado
            Dim idSeccion As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
            Dim monto As Decimal = montoIngresado
            Dim codOperativo As String = txtCodOperativo.Text.Trim()
            Dim refBancaria As String = txtRefBancaria.Text.Trim()
            Dim textoObservacion As String = txtObservacion.Text.Trim()


            Dim nombreNivel As String = cboNivel.Text.ToUpper()
            Dim montoPension As Decimal = 0

            If nombreNivel.Contains("PRIMARIA") Then
                montoPension = 350.0
            ElseIf nombreNivel.Contains("SECUNDARIA") Then
                montoPension = 450.0
            End If


            If textoObservacion = "" Then
                textoObservacion = "Ninguna"
            End If


            Dim exito As Boolean = objLogicaMatricula.ProcesarMatricula(idEstudiante, idSeccion, monto, codOperativo, refBancaria, textoObservacion)

            If exito Then

                Dim mensaje As String = "¡Matrícula procesada con éxito! Se ha generado el cronograma de pagos." & vbCrLf & vbCrLf &
                                        "¿Desea imprimir la Constancia de Matrícula ahora?"


                Dim respuesta As DialogResult = MessageBox.Show(mensaje, "Proceso Exitoso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                GenerarProyeccionCronograma()
                txtObservacion.Clear()


                Dim idSeccionActual As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
                Dim vacantesRestantes As Integer = objLogicaMatricula.ObtenerVacantesDisponibles(idSeccionActual)
                txtVacante.Text = vacantesRestantes.ToString() & " vacantes disponibles"

                If vacantesRestantes <= 0 Then
                    txtVacante.BackColor = Color.LightCoral
                    txtVacante.Text = "Sección Llena (0 vacantes)"
                Else
                    txtVacante.BackColor = Color.LightGreen
                End If



                If respuesta = DialogResult.Yes Then
                    MessageBox.Show("Abriendo vista previa de la Constancia de Matrícula...", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

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


        Dim nombreNivel As String = cboNivel.Text.ToUpper()
        Dim pensionCalculada As Decimal = 0

        If nombreNivel.Contains("PRIMARIA") Then
            pensionCalculada = 350.0
        ElseIf nombreNivel.Contains("SECUNDARIA") Then
            pensionCalculada = 450.0
        End If


        For i As Integer = 3 To 12
            Dim conceptoPrension As String = "Pensión " & (i - 2).ToString("D2")
            Dim fechaVencimiento As New DateTime(DateTime.Now.Year, i, 10)


            dgvCronograma.Rows.Add(conceptoPrension, fechaVencimiento.ToString("dd/MM/yyyy"), pensionCalculada.ToString("C2"), "Pendiente")
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


        Dim idSeccion As Integer
        If Integer.TryParse(cboSeccion.SelectedValue.ToString(), idSeccion) = False Then Return

        Try



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

    Private Sub btnAgregarEstudiante_Click(sender As Object, e As EventArgs) Handles btnAgregarEstudiante.Click

        Dim hijoUsuarios As New frmMantEstudiante()


        hijoUsuarios.ShowDialog()
    End Sub



    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarFormularioMatricula()


        MessageBox.Show("Formulario listo para una nueva operación.", "Limpieza Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub LimpiarFormularioMatricula()

        _idEstudianteSeleccionado = 0


        TxtDNI.Clear()
        txtEstudiante.Clear()
        txtApoderado.Clear()

        txtObservacion.Clear()
        txtObservacion.ReadOnly = True
        txtObservacion.BackColor = SystemColors.Control


        cargandoCombos = True

        cboNivel.SelectedIndex = -1

        cboGrado.DataSource = Nothing
        cboGrado.Enabled = False

        cboSeccion.DataSource = Nothing
        cboSeccion.Enabled = False

        cargandoCombos = False


        txtVacante.Clear()
        txtVacante.BackColor = Color.White


        txtCodOperativo.Clear()
        txtRefBancaria.Clear()
        txtMonto.Clear()
        txtObservacion.Clear()
        txtMonto.BackColor = Color.White


        dgvCronograma.Columns.Clear()
        dgvCronograma.Rows.Clear()


        TxtDNI.Focus()
    End Sub

End Class
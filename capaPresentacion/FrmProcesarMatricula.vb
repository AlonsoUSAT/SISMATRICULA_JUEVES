Imports capaLogica
Imports System.Drawing

Public Class frmProcesarMatricula


    Dim objLogica As New clsLogProcesarMatricula()


    Dim _montoBase As Decimal = 0
    Dim _porcentajeBeca As Decimal = 0
    Dim _idPagoMatricula As Integer = 0
    Dim _idEstudiante As Integer = 0
    Dim _idSeccion As Integer = 0
    Dim _idAnoAcademico As Integer = 1
    Dim _estadoPago As String = "0"


    Private Sub frmProcesarMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbTipoBusqueda.Items.Clear()
        cmbTipoBusqueda.Items.Add("DNI")
        cmbTipoBusqueda.Items.Add("Cod. Operativo")
        cmbTipoBusqueda.SelectedIndex = 0


        txtEstudiante.ReadOnly = True
        txtApoderado.ReadOnly = True
        txtFechaPago.ReadOnly = True
        txtCodOperativo.ReadOnly = True
        txtMontoPagado.ReadOnly = True
        txtEstado.ReadOnly = True
        txtBecaActiva.ReadOnly = True
        txtDctoPensiones.ReadOnly = True
        txtNivelGradoSeccion.ReadOnly = True
        txtObservaciones.ReadOnly = True

        LimpiarFormulario()

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            LimpiarFormulario()

            Dim tipoBusqueda As String = cmbTipoBusqueda.SelectedItem?.ToString()
            Dim valor As String = txtNro.Text.Trim()

            Dim dtPago As DataTable = objLogica.BuscarPago(tipoBusqueda, valor)

            If dtPago.Rows.Count = 0 Then
                MessageBox.Show("No se encontró ningún pago con ese criterio.",
                            "Sin resultados", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Return
            End If

            Dim row As DataRow = dtPago.Rows(0)


            _idPagoMatricula = Convert.ToInt32(row("id_pagoMatricula"))
            _idEstudiante = Convert.ToInt32(row("id_estudiante"))
            Dim estadoBit As Boolean = Convert.ToBoolean(row("estado"))
            _estadoPago = If(estadoBit, "1", "0")
            _montoBase = Convert.ToDecimal(row("montoBase"))


            txtEstudiante.Text = row("nombreEstudiante").ToString()
            txtApoderado.Text = row("nombreApoderado").ToString()
            txtFechaPago.Text = Convert.ToDateTime(row("fechaEmision")).ToString("dd/MM/yyyy")
            txtCodOperativo.Text = row("codigoOperativo").ToString()
            txtMontoPagado.Text = "S/ " & Convert.ToDecimal(row("montoTotal")).ToString("N2")



            If estadoBit Then
                _estadoPago = "1"
            Else
                _estadoPago = "0"
            End If

            Select Case _estadoPago
                Case "0"
                    txtEstado.Text = "PENDIENTE"
                    txtEstado.ForeColor = Color.Red
                Case "1"
                    txtEstado.Text = "PAGADO"
                    txtEstado.ForeColor = Color.Blue
            End Select

            CargarBecaEstudiante(_idEstudiante)
            CargarNivelGradoSeccion(_idEstudiante)
            CargarCronograma(_idEstudiante)


            txtObservaciones.Text = objLogica.ObtenerObservacionMatricula(_idEstudiante)


            If objLogica.YaEstaMatriculado(_idEstudiante) Then
                txtObservaciones.ReadOnly = True
                MessageBox.Show("Este estudiante ya tiene una matrícula registrada." & vbCrLf &
                            "Solo puede consultar su información.",
                            "Matrícula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnProcesarMatricula.Enabled = False

            Else
                btnProcesarMatricula.Enabled = True
                txtObservaciones.ReadOnly = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CargarBecaEstudiante(idEstudiante As Integer)
        Dim dtBeca As DataTable = objLogica.ObtenerBecaActiva(idEstudiante)

        If dtBeca.Rows.Count > 0 Then
            Dim porcentaje As Decimal = Convert.ToDecimal(dtBeca.Rows(0)("porcentaje_descuento"))
            _porcentajeBeca = porcentaje
            txtBecaActiva.Text = dtBeca.Rows(0)("beca").ToString()
            txtDctoPensiones.Text = porcentaje.ToString("N0") & "%"
        Else
            _porcentajeBeca = 0   ' ← AGREGAR
            txtBecaActiva.Text = "Sin beca"
            txtDctoPensiones.Text = "0%"
        End If
    End Sub


    Private Sub CargarNivelGradoSeccion(idEstudiante As Integer)
        Dim dtNgs As DataTable = objLogica.ObtenerNivelGradoSeccion(idEstudiante)
        txtNivelGradoSeccion.Text = objLogica.FormatearNivelGradoSeccion(dtNgs)


        If dtNgs.Rows.Count > 0 AndAlso dtNgs.Columns.Contains("id_seccion") Then
            _idSeccion = Convert.ToInt32(dtNgs.Rows(0)("id_seccion"))
        End If
    End Sub


    Private Sub CargarCronograma(idEstudiante As Integer)
        Dim dtCrono As DataTable = objLogica.ObtenerCronograma(idEstudiante)
        dgvCronograma.DataSource = dtCrono


        dgvCronograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCronograma.RowHeadersVisible = False
        dgvCronograma.AllowUserToAddRows = False
        dgvCronograma.ReadOnly = True

        dgvCronograma.DefaultCellStyle.ForeColor = Color.Black
    End Sub


    Private Sub btnProcesarMatricula_Click(sender As Object, e As EventArgs) Handles btnProcesarMatricula.Click
        Try

            If _idPagoMatricula = 0 Then
                MessageBox.Show("Primero busque un pago de matrícula.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            If String.IsNullOrWhiteSpace(txtCodOperativo.Text) Then
                MessageBox.Show("Este pago aún no tiene código operativo." & vbCrLf &
                            "El padre debe realizar el pago en el banco primero.",
                            "Pago no confirmado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If




            If objLogica.YaEstaMatriculado(_idEstudiante) Then
                MessageBox.Show("Este estudiante ya tiene una matrícula registrada.",
                    "Matrícula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim confirmar As DialogResult = MessageBox.Show(
                "¿Desea procesar la matrícula del estudiante:" & vbCrLf & txtEstudiante.Text & "?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar <> DialogResult.Yes Then Return


            Dim resultado As Boolean = objLogica.ProcesarMatricula(
    _idPagoMatricula,
    _idEstudiante,
    _idSeccion,
    _idAnoAcademico,
    _estadoPago,
    txtObservaciones.Text.Trim(),
    _montoBase,
    _porcentajeBeca)

            If resultado Then
                MessageBox.Show("¡Matrícula procesada correctamente!",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtEstado.Text = "PROCESADO"
                txtEstado.ForeColor = Color.Green
                _estadoPago = "1"
                CargarCronograma(_idEstudiante)
            Else
                MessageBox.Show("Ocurrió un error al procesar la matrícula.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub LimpiarFormulario()
        txtEstudiante.Text = String.Empty
        txtApoderado.Text = String.Empty
        txtFechaPago.Text = String.Empty
        txtCodOperativo.Text = String.Empty
        txtMontoPagado.Text = String.Empty
        txtEstado.Text = String.Empty
        txtEstado.ForeColor = Color.Black
        txtBecaActiva.Text = String.Empty
        txtDctoPensiones.Text = String.Empty
        txtNivelGradoSeccion.Text = String.Empty
        dgvCronograma.DataSource = Nothing

        txtObservaciones.Text = String.Empty
        txtObservaciones.ReadOnly = True

        _idPagoMatricula = 0
        _idEstudiante = 0
        _idSeccion = 0
        _estadoPago = "0"
        _montoBase = 0
        _porcentajeBeca = 0
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
        txtNro.Text = String.Empty
        txtNro.Focus()
        btnProcesarMatricula.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If _idPagoMatricula = 0 Then
                MessageBox.Show("Primero busque y procese una matrícula.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim confirmar As DialogResult = MessageBox.Show(
            "¿Desea imprimir la constancia de matrícula de:" & vbCrLf & txtEstudiante.Text & "?",
            "Confirmar impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar <> DialogResult.Yes Then Return


            Dim dtCrono As DataTable = objLogica.ObtenerCronograma(_idEstudiante)


            Dim frmConstancia As New frmConstanciaMatricula()
            frmConstancia.CargarDatos(
            txtEstudiante.Text,
            txtApoderado.Text,
            txtFechaPago.Text,
            txtNivelGradoSeccion.Text,
            txtBecaActiva.Text,
            txtDctoPensiones.Text,
            txtCodOperativo.Text,
            txtMontoPagado.Text,
            dtCrono
        )


            frmConstancia.ImprimirSilencioso()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
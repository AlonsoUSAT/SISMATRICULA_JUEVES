Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports capaLogica
Imports capaLogica.capaLogica

Public Class frmAsigBecas

    ' ============================================================
    ' VARIABLES DE ESTADO
    ' ============================================================
    Private _idEstudianteSeleccionado As Integer = 0
    Private _idAnoAcademicoActual As Integer = 0
    Private _idAsignacionBecaActual As Integer = 0
    Private _dtBecadosCompleto As DataTable = Nothing
    Private _porcentajeSeleccionado As Decimal = 0D

    Private ReadOnly _logBecas As New clsLogBecas()

    ' ── Usuario de sesión actual (se puede cambiar al hacer login) ──────
    Public Property UsuarioActual As String = "ADMIN"

    ' ============================================================
    ' CARGA INICIAL
    ' ============================================================
    Private Sub frmAsigBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAnoAcademicoActual()
        CargarComboTiposBeca()
        CargarListadoBecados()
        LimpiarDatosEstudiante()
        txtDNI.Focus()
    End Sub

    ' ============================================================
    ' AÑO ACADÉMICO ACTUAL
    ' ============================================================
    Private Sub CargarAnoAcademicoActual()
        Try
            Dim dt As DataTable = _logBecas.ObtenerAnoAcademicoActual()
            If dt.Rows.Count > 0 Then
                _idAnoAcademicoActual = CInt(dt.Rows(0)("id_anoAcademico"))
                lblAnoAcademico.Text = "Año académico activo: " & dt.Rows(0)("AnoAcademico").ToString()
            Else
                lblAnoAcademico.Text = "⚠ Sin año académico activo"
                _idAnoAcademicoActual = 0
            End If
        Catch ex As Exception
            lblAnoAcademico.Text = "Error al cargar año académico"
        End Try
    End Sub

    ' ============================================================
    ' COMBO TIPOS DE BECA
    ' ============================================================
    Private Sub CargarComboTiposBeca()
        Try
            Dim dt As DataTable = _logBecas.ObtenerTiposBeca()
            cboTipoBeca.DataSource = dt
            cboTipoBeca.DisplayMember = "descripcion"
            cboTipoBeca.ValueMember = "id_tipo_beca"
            cboTipoBeca.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de beca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' BUSCAR ESTUDIANTE
    ' ============================================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LimpiarDatosEstudiante()
        Dim dni As String = txtDNI.Text.Trim()

        If String.IsNullOrWhiteSpace(dni) Then
            MostrarAlerta("Ingrese el DNI del estudiante para buscar.")
            txtDNI.Focus()
            Return
        End If

        Try
            Dim dt As DataTable = _logBecas.BuscarEstudianteParaBeca(dni)

            If dt.Rows.Count = 0 Then
                MostrarAlerta("No se encontró ningún estudiante con DNI: " & dni)
                Return
            End If

            Dim fila As DataRow = dt.Rows(0)
            _idEstudianteSeleccionado = CInt(fila("id_estudiante"))

            ' Poblar datos del estudiante
            txtNombreEstudiante.Text = fila("nombreCompleto").ToString()
            txtNivelGrado.Text = fila("gradoSeccion").ToString()
            txtTipoEstudiante.Text = fila("tipoEstudiante").ToString()

            Dim tieneBecaActiva As Boolean = CBool(fila("tieneBecaActiva"))

            ' Cargar historial (y buscar el ID de la asignación si está activa)
            CargarHistorialBecasEstudiante(_idEstudianteSeleccionado)

            If tieneBecaActiva Then
                lblEstadoBeca.Text = "✔ ESTUDIANTE CON BECA ACTIVA"
                lblEstadoBeca.ForeColor = Color.Green

                ' Modo gestión (sólo suspender/revocar)
                btnAsignar.Enabled = False
                btnSuspender.Enabled = True
                btnRevocar.Enabled = True
                cboTipoBeca.Enabled = False
                txtMotivo.Enabled = False
                txtDescuento.Enabled = False
            Else
                lblEstadoBeca.Text = "○ SIN BECA ACTIVA"
                lblEstadoBeca.ForeColor = Color.Orange

                ' Modo asignación
                btnAsignar.Enabled = True
                btnSuspender.Enabled = False
                btnRevocar.Enabled = False
                cboTipoBeca.Enabled = True
                txtMotivo.Enabled = True
                txtDescuento.Enabled = True
            End If

            pnlDatosEstudiante.Enabled = True
            pnlAsignacion.Enabled = True

        Catch ex As ArgumentException
            MostrarAlerta(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error al buscar estudiante: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' CAMBIO EN COMBO TIPO DE BECA
    ' ============================================================
    Private Sub cboTipoBeca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoBeca.SelectedIndexChanged
        If cboTipoBeca.SelectedIndex < 0 Then
            lblDescripcionTexto.Text = ""
            txtDescuento.Clear()
            txtDescuentoMes.Clear()
            Return
        End If

        Dim rowView As DataRowView = DirectCast(cboTipoBeca.SelectedItem, DataRowView)
        _porcentajeSeleccionado = CDec(rowView("porcentaje_descuento"))

        lblDescripcionTexto.Text = rowView("descripcion").ToString()
        txtDescuento.Text = _porcentajeSeleccionado.ToString("F2")

        Dim descuento As Decimal = _logBecas.CalcularMontoDescuento(_porcentajeSeleccionado)

        ' Mostrar el monto calculado en el nuevo TextBox
        txtDescuentoMes.Text = descuento.ToString("F2")
        ' Es recomendable bloquear el TextBox del monto para que el usuario no lo altere manualmente
        txtDescuentoMes.ReadOnly = True
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        ' Recalcular monto si el usuario edita el textbox de porcentaje manualmente
        Dim pct As Decimal
        If Decimal.TryParse(txtDescuento.Text, pct) Then
            Dim descuento As Decimal = _logBecas.CalcularMontoDescuento(pct)
            ' Mostrar el nuevo monto recalculado en el TextBox de Mes
            txtDescuentoMes.Text = descuento.ToString("F2")
        Else
            txtDescuentoMes.Clear()
        End If
    End Sub

    ' ============================================================
    ' CARGAR HISTORIAL DE BECAS (Grilla inferior)
    ' ============================================================
    Private Sub CargarHistorialBecasEstudiante(idEstudiante As Integer)
        Try
            Dim dt As DataTable = _logBecas.HistorialBecasEstudiante(idEstudiante)
            dgvHistorialBecas.DataSource = dt

            _idAsignacionBecaActual = 0
            ' Rescatamos el ID de la asignación activa para usarlo al suspender o revocar
            For Each row As DataRow In dt.Rows
                If row("Estado").ToString().ToUpper() = "ACTIVA" Then
                    _idAsignacionBecaActual = CInt(row("id_asignacion"))
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub


    ' ============================================================
    ' CARGAR LISTADO DE BECADOS (Tab 2)
    ' ============================================================
    Private Sub CargarListadoBecados()
        Try
            _dtBecadosCompleto = _logBecas.ListarBecadosAnoActual()
            dgvBecadosActivos.DataSource = _dtBecadosCompleto
            lblTotalBecados.Text = "Total becados en el año: " & _dtBecadosCompleto.Rows.Count.ToString()
        Catch ex As Exception
            lblTotalBecados.Text = "Error al cargar listado"
        End Try
    End Sub

    ' ============================================================
    ' ASIGNAR BECA
    ' ============================================================
    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If _idEstudianteSeleccionado <= 0 Then
            MostrarAlerta("Primero busque un estudiante.")
            Return
        End If

        Dim porcentajeFinal As Decimal = 0D
        If Not Decimal.TryParse(txtDescuento.Text, porcentajeFinal) Then
            porcentajeFinal = _porcentajeSeleccionado
        End If

        Dim descuentoMonto As Decimal = _logBecas.CalcularMontoDescuento(porcentajeFinal)

        Dim msg As String = $"¿Confirma la asignación de beca?" & vbCrLf & vbCrLf &
                            $"Estudiante : {txtNombreEstudiante.Text}" & vbCrLf &
                            $"Porcentaje : {porcentajeFinal:F0}%  (S/ {descuentoMonto:F2} / mes)"

        If MessageBox.Show(msg, "Confirmar Asignación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Dim ok As Boolean = _logBecas.AsignarBeca(_idEstudianteSeleccionado, CInt(cboTipoBeca.SelectedValue), _idAnoAcademicoActual,
                                                      txtMotivo.Text.Trim(), porcentajeFinal, descuentoMonto, UsuarioActual)
            If ok Then
                MessageBox.Show("✔ Beca asignada correctamente.", "Asignación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Refrescar datos
                Dim dniGuardado As String = txtDNI.Text
                LimpiarDatosEstudiante()
                txtDNI.Text = dniGuardado
                btnBuscar_Click(sender, e)
                CargarListadoBecados()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ============================================================
    ' REVOCAR BECA
    ' ============================================================
    Private Sub btnRevocar_Click(sender As Object, e As EventArgs) Handles btnRevocar.Click
        If _idAsignacionBecaActual = 0 Then Return

        If MessageBox.Show("¿Está SEGURO de REVOCAR DEFINITIVAMENTE la beca de " & txtNombreEstudiante.Text & "?",
                           "Confirmar Revocación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.No Then Return
        Try
            _logBecas.CambiarEstadoBeca(_idAsignacionBecaActual, clsLogBecas.ESTADO_REVOCADA, UsuarioActual)
            MessageBox.Show("Beca revocada. El estudiante vuelve a tipo REGULAR.", "Revocación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtDNI.Clear()
            LimpiarDatosEstudiante()
            CargarListadoBecados()
        Catch ex As Exception
            MessageBox.Show("Error al revocar beca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' SUSPENDER BECA
    ' ============================================================
    Private Sub btnSuspender_Click(sender As Object, e As EventArgs) Handles btnSuspender.Click
        If _idAsignacionBecaActual = 0 Then Return

        If MessageBox.Show("¿Desea SUSPENDER TEMPORALMENTE la beca de " & txtNombreEstudiante.Text & "?",
                           "Confirmar Suspensión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            _logBecas.CambiarEstadoBeca(_idAsignacionBecaActual, clsLogBecas.ESTADO_SUSPENDIDA, UsuarioActual)
            MessageBox.Show("Beca suspendida temporalmente.", "Suspensión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtDNI.Clear()
            LimpiarDatosEstudiante()
            CargarListadoBecados()
        Catch ex As Exception
            MessageBox.Show("Error al suspender beca: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' FILTRO EN GRILLA DE BECADOS (Tab 2)
    ' ============================================================
    Private Sub txtBuscarEnLista_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEnLista.TextChanged
        If _dtBecadosCompleto Is Nothing Then Return
        Dim filtro As String = txtBuscarEnLista.Text.Trim().ToLower()

        If filtro = "" Then
            dgvBecadosActivos.DataSource = _dtBecadosCompleto
            lblTotalBecados.Text = "Total becados: " & _dtBecadosCompleto.Rows.Count.ToString()
            Return
        End If

        Dim dtF As DataTable = _dtBecadosCompleto.Copy()
        For i As Integer = dtF.Rows.Count - 1 To 0 Step -1
            Dim r As DataRow = dtF.Rows(i)
            Dim enNombre As Boolean = r("Estudiante").ToString().ToLower().Contains(filtro)
            Dim enDNI As Boolean = r("DNI").ToString().Contains(filtro)
            Dim enBeca As Boolean = r("TipoBeca").ToString().ToLower().Contains(filtro)
            If Not (enNombre OrElse enDNI OrElse enBeca) Then dtF.Rows.RemoveAt(i)
        Next
        dgvBecadosActivos.DataSource = dtF
        lblTotalBecados.Text = $"Mostrando: {dtF.Rows.Count} de {_dtBecadosCompleto.Rows.Count}"
    End Sub

    ' ============================================================
    ' LIMPIEZA DE CONTROLES
    ' ============================================================
    Private Sub LimpiarDatosEstudiante()
        _idEstudianteSeleccionado = 0
        _idAsignacionBecaActual = 0
        _porcentajeSeleccionado = 0D

        txtNombreEstudiante.Clear()
        txtNivelGrado.Clear()
        txtTipoEstudiante.Clear()
        txtMotivo.Clear()
        txtDescuento.Clear()
        txtDescuentoMes.Clear() ' Limpiamos el nuevo TextBox
        lblDescripcionTexto.Text = ""

        lblEstadoBeca.Text = "— Busque un estudiante por DNI —"
        lblEstadoBeca.ForeColor = Color.DimGray

        pnlDatosEstudiante.Enabled = False
        pnlAsignacion.Enabled = False

        btnAsignar.Enabled = False
        btnSuspender.Enabled = False
        btnRevocar.Enabled = False
        cboTipoBeca.Enabled = True
        cboTipoBeca.SelectedIndex = -1

        dgvHistorialBecas.DataSource = Nothing
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarDatosEstudiante()
        txtDNI.Clear()
        txtDNI.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' ============================================================
    ' VALIDACIÓN DE TECLAS Y ALERTAS
    ' ============================================================
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDNI.KeyDown
        If e.KeyCode = Keys.Enter Then btnBuscar_Click(sender, e)
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> ","c AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub

    Private Sub MostrarAlerta(mensaje As String)
        MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub lblAnoAcademico_Click(sender As Object, e As EventArgs) Handles lblAnoAcademico.Click

    End Sub
End Class
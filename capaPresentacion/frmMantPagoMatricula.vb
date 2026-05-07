Imports capaLogica

Public Class frmMantPagoMatricula
    Dim objLogica As New clsLogPagoMatricula()

    Private Sub frmMantPagoMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarGrilla()
    End Sub

    Private Sub ListarGrilla()
        Try
            dgvAnos.DataSource = objLogica.Listar()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtCodigo.Clear()
        txtCodigoOperativo.Clear()
        txtMonto.Clear()
        dtpFechaInicio.Value = Now
        chkEstado.Checked = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            ' Validamos que hayan llenado los campos nuevos
            If txtCodigoOperativo.Text = "" Or txtMonto.Text = "" Or txtNumeroReferencia.Text = "" Then
                MsgBox("Por favor llene todos los campos.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            If objLogica.Guardar(dtpFechaInicio.Value, txtCodigoOperativo.Text, CInt(txtMonto.Text), CInt(txtNumeroReferencia.Text)) Then
                MsgBox("Pago registrado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As InvalidCastException
            MsgBox("El Monto y el Número de Referencia deben ser números válidos.", MsgBoxStyle.Exclamation, "Atención")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un pago primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            If objLogica.Modificar(id, dtpFechaInicio.Value, txtCodigoOperativo.Text, CInt(txtMonto.Text), CInt(txtNumeroReferencia.Text), chkEstado.Checked) Then
                MsgBox("Pago actualizado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As InvalidCastException
            MsgBox("El Monto y el Número de Referencia deben ser números válidos.", MsgBoxStyle.Exclamation, "Atención")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un pago primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            If MsgBox("¿Está seguro que desea anular este pago?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar") = MsgBoxResult.Yes Then
                If objLogica.DarDeBaja(id) Then
                    MsgBox("Pago anulado.", MsgBoxStyle.Information, "Éxito")
                    ListarGrilla()
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub dgvAnosAcademicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvAnos.Rows(e.RowIndex)

            txtCodigo.Text = fila.Cells("id_pagoMatricula").Value.ToString()
            dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells("fechaPago").Value)
            txtCodigoOperativo.Text = fila.Cells("codigoOperativo").Value.ToString()
            txtMonto.Text = fila.Cells("monto").Value.ToString()
            txtNumeroReferencia.Text = fila.Cells("numeroReferencia").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("estado").Value)
        End If
    End Sub
End Class

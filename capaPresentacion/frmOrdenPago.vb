Imports capaLogica
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO

Public Class frmOrdenPago


    Dim WithEvents docPrint As New PrintDocument()

    Dim _cip As String = ""
    Dim _vencimiento As String = ""
    Dim _monto As String = ""
    Dim _descuento As String = ""
    Dim _totalPagar As String = ""


    Public Sub CargarDatos(cip As String, vencimiento As String, montoBase As String, descuento As String, total As String)
        _cip = cip
        _vencimiento = vencimiento
        _monto = "S/ " & montoBase
        _descuento = "- S/ " & descuento
        _totalPagar = "S/ " & total

        txtCIP.Text = cip
        txtVencimiento.Text = vencimiento
        txtMontoBase.Text = "S/ " & montoBase
        txtDescuento.Text = "- S/ " & descuento
        txtTotalPagar.Text = "S/ " & total

        txtCIP.ReadOnly = True
        txtVencimiento.ReadOnly = True
        txtMontoBase.ReadOnly = True
        txtDescuento.ReadOnly = True
        txtTotalPagar.ReadOnly = True
    End Sub


    Private Sub txtCIP_TextChanged(sender As Object, e As EventArgs) Handles txtCIP.TextChanged
    End Sub
    Private Sub txtVencimiento_TextChanged(sender As Object, e As EventArgs) Handles txtVencimiento.TextChanged
    End Sub
    Private Sub txtTotalPagar_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPagar.TextChanged
    End Sub


    Dim objLogica As New clsLogGenerarOrdenPago()

    Private Sub btnSimularPago_Click(sender As Object, e As EventArgs) Handles btnSimularPago.Click
        Try
            Dim confirmar As DialogResult = MessageBox.Show(
                "¿Confirmar pago en banco por S/ " & txtTotalPagar.Text & "?",
                "Simular Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar <> DialogResult.Yes Then Return

            objLogica.SimularPagoBanco(txtCIP.Text.Trim())

            MessageBox.Show("¡Pago registrado exitosamente!" & vbCrLf &
                            "El secretario ya puede procesar la matrícula.",
                            "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnSimularPago.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCopiarCip_Click(sender As Object, e As EventArgs) Handles btnCopiarCip.Click
        If txtCIP.Text.Trim() <> "" Then
            Clipboard.SetText(txtCIP.Text.Trim())
            MessageBox.Show("CIP copiado al portapapeles.", "Copiado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim dlg As New PrintDialog()
            dlg.Document = docPrint
            If dlg.ShowDialog() = DialogResult.OK Then
                docPrint.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al imprimir: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            ' ── Nombre automático ──
            Dim nombreArchivo As String = "OrdenPago_" & _cip & "_" &
                                          DateTime.Now.ToString("yyyyMMdd_HHmm") & ".png"

            Dim carpeta As String = Environment.GetFolderPath(
                                        Environment.SpecialFolder.UserProfile) &
                                    "\Downloads"

            Dim rutaCompleta As String = Path.Combine(carpeta, nombreArchivo)

            ' ── Crear imagen en memoria con el mismo diseño ──
            Dim ancho As Integer = 620
            Dim alto As Integer = 520
            Dim bmp As New Bitmap(ancho, alto)
            Dim g As Graphics = Graphics.FromImage(bmp)

            g.Clear(Color.White)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            ' ─ Colores y fuentes ─
            Dim colorRojo As New SolidBrush(Color.FromArgb(139, 0, 0))
            Dim colorNegro As New SolidBrush(Color.Black)
            Dim colorGris As New SolidBrush(Color.FromArgb(245, 245, 245))
            Dim colorLinea As New Pen(Color.FromArgb(200, 200, 200), 1)

            Dim fuenteTitulo As New Font("Arial", 18, FontStyle.Bold)
            Dim fuenteSubtit As New Font("Arial", 9, FontStyle.Regular)
            Dim fuenteLabel As New Font("Arial", 8, FontStyle.Bold)
            Dim fuenteValor As New Font("Arial", 8, FontStyle.Regular)
            Dim fuenteTotal As New Font("Arial", 10, FontStyle.Bold)
            Dim fuentePie As New Font("Arial", 7, FontStyle.Italic)
            Dim fuenteCIP As New Font("Courier New", 13, FontStyle.Bold)

            Dim mx As Integer = 30   ' margen izquierdo
            Dim aw As Integer = 560  ' ancho útil
            Dim y As Integer = 20

            ' ─ CABECERA roja ─
            g.FillRectangle(colorRojo, New Rectangle(mx, y, aw, 50))
            g.DrawString("ORDEN DE PAGO", fuenteTitulo, Brushes.White,
                         New PointF(mx + 10, y + 10))
            y += 58

            ' ─ Subtítulo ─
            g.DrawString("Institución Educativa · I.E.P AMANCIO VARONA",
                         fuenteSubtit, colorNegro, New PointF(mx, y))
            y += 18
            g.DrawLine(colorLinea, mx, y, mx + aw, y)
            y += 10

            ' ─ Función fila ─
            Dim DibujarFila As Action(Of String, String, Boolean) =
                Sub(lbl As String, val As String, sombrear As Boolean)
                    If sombrear Then
                        g.FillRectangle(colorGris, New Rectangle(mx, y, aw, 24))
                    End If
                    g.DrawString(lbl, fuenteLabel, colorNegro, New PointF(mx + 8, y + 5))
                    g.DrawString(val, fuenteValor, colorNegro, New PointF(mx + 220, y + 5))
                    g.DrawLine(colorLinea, mx, y + 24, mx + aw, y + 24)
                    y += 26
                End Sub

            DibujarFila("Código de Pago (CIP):", _cip, True)
            DibujarFila("Fecha de Vencimiento:", _vencimiento, False)
            DibujarFila("Monto Base:", _monto, True)
            DibujarFila("Descuento Aplicado:", _descuento, False)
            y += 6

            ' ─ Fila TOTAL roja ─
            g.FillRectangle(colorRojo, New Rectangle(mx, y, aw, 30))
            g.DrawString("TOTAL A PAGAR:", fuenteTotal, Brushes.White,
                         New PointF(mx + 8, y + 6))
            g.DrawString(_totalPagar, fuenteTotal, Brushes.White,
                         New PointF(mx + 220, y + 6))
            y += 40

            ' ─ CIP destacado ─
            g.DrawString("Presente este código en su banca móvil o agente autorizado:",
                         fuenteSubtit, colorNegro, New PointF(mx, y))
            y += 16
            Dim rectCIP As New Rectangle(mx, y, aw, 36)
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 250, 220)), rectCIP)
            g.DrawRectangle(New Pen(Color.FromArgb(200, 160, 0), 1.5), rectCIP)
            Dim tamCIP As SizeF = g.MeasureString(_cip, fuenteCIP)
            g.DrawString(_cip, fuenteCIP, colorNegro,
                         New PointF(mx + (aw - tamCIP.Width) / 2, y + 7))
            y += 50

            ' ─ Pie ─
            g.DrawLine(colorLinea, mx, y, mx + aw, y)
            y += 6
            g.DrawString("Documento generado el " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") &
                         "  ·  Este documento no requiere firma.",
                         fuentePie, colorNegro, New PointF(mx, y))

            ' ─ Liberar recursos gráficos ─
            g.Dispose()
            colorRojo.Dispose() : colorNegro.Dispose() : colorGris.Dispose()
            colorLinea.Dispose() : fuenteTitulo.Dispose() : fuenteSubtit.Dispose()
            fuenteLabel.Dispose() : fuenteValor.Dispose() : fuenteTotal.Dispose()
            fuentePie.Dispose() : fuenteCIP.Dispose()

            ' ─ Guardar PNG en Descargas ─
            bmp.Save(rutaCompleta, Imaging.ImageFormat.Png)
            bmp.Dispose()

            MessageBox.Show("¡Archivo guardado correctamente!" & vbCrLf &
                            "Ubicación: " & rutaCompleta,
                            "Descarga exitosa", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' ─ Abrir carpeta Descargas ─
            Process.Start("explorer.exe", carpeta)

        Catch ex As Exception
            MessageBox.Show("Error al descargar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub docPrint_PrintPage(sender As Object, e As PrintPageEventArgs) _
        Handles docPrint.PrintPage

        Dim g As Graphics = e.Graphics

        Dim colorRojo As New SolidBrush(Color.FromArgb(139, 0, 0))
        Dim colorNegro As New SolidBrush(Color.Black)
        Dim colorGris As New SolidBrush(Color.FromArgb(245, 245, 245))
        Dim colorLinea As New Pen(Color.FromArgb(200, 200, 200), 1)

        Dim fuenteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fuenteSubtit As New Font("Arial", 10, FontStyle.Regular)
        Dim fuenteLabel As New Font("Arial", 9, FontStyle.Bold)
        Dim fuenteValor As New Font("Arial", 9, FontStyle.Regular)
        Dim fuenteTotal As New Font("Arial", 11, FontStyle.Bold)
        Dim fuentePie As New Font("Arial", 8, FontStyle.Italic)
        Dim fuenteCIP As New Font("Courier New", 14, FontStyle.Bold)

        Dim margenIzq As Integer = 60
        Dim anchoUtil As Integer = 480
        Dim y As Integer = 40

        g.FillRectangle(colorRojo, New Rectangle(margenIzq, y, anchoUtil, 55))
        g.DrawString("ORDEN DE PAGO", fuenteTitulo, Brushes.White,
                     New PointF(margenIzq + 10, y + 12))
        y += 65

        g.DrawString("Institución Educativa · Sistema de Matrícula",
                     fuenteSubtit, colorNegro, New PointF(margenIzq, y))
        y += 20
        g.DrawLine(colorLinea, margenIzq, y, margenIzq + anchoUtil, y)
        y += 12

        Dim DibujarFila As Action(Of String, String, Boolean) =
            Sub(lbl As String, val As String, sombrear As Boolean)
                If sombrear Then
                    g.FillRectangle(colorGris, New Rectangle(margenIzq, y, anchoUtil, 26))
                End If
                g.DrawString(lbl, fuenteLabel, colorNegro, New PointF(margenIzq + 8, y + 6))
                g.DrawString(val, fuenteValor, colorNegro, New PointF(margenIzq + 200, y + 6))
                g.DrawLine(colorLinea, margenIzq, y + 26, margenIzq + anchoUtil, y + 26)
                y += 28
            End Sub

        DibujarFila("Código de Pago (CIP):", _cip, True)
        DibujarFila("Fecha de Vencimiento:", _vencimiento, False)
        DibujarFila("Monto Base:", _monto, True)
        DibujarFila("Descuento Aplicado:", _descuento, False)
        y += 8

        g.FillRectangle(colorRojo, New Rectangle(margenIzq, y, anchoUtil, 32))
        g.DrawString("TOTAL A PAGAR:", fuenteTotal, Brushes.White,
                     New PointF(margenIzq + 8, y + 7))
        g.DrawString(_totalPagar, fuenteTotal, Brushes.White,
                     New PointF(margenIzq + 200, y + 7))
        y += 45

        g.DrawString("Presente este código en su banca móvil o agente autorizado:",
                     fuenteSubtit, colorNegro, New PointF(margenIzq, y))
        y += 18
        Dim rectCIP As New Rectangle(margenIzq, y, anchoUtil, 38)
        g.FillRectangle(New SolidBrush(Color.FromArgb(255, 250, 220)), rectCIP)
        g.DrawRectangle(New Pen(Color.FromArgb(200, 160, 0), 1.5), rectCIP)
        Dim tamCIP As SizeF = g.MeasureString(_cip, fuenteCIP)
        g.DrawString(_cip, fuenteCIP, colorNegro,
                     New PointF(margenIzq + (anchoUtil - tamCIP.Width) / 2, y + 8))
        y += 55

        g.DrawLine(colorLinea, margenIzq, y, margenIzq + anchoUtil, y)
        y += 8
        g.DrawString("Documento generado el " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") &
                     "  ·  Este documento no requiere firma.",
                     fuentePie, colorNegro, New PointF(margenIzq, y))

        colorRojo.Dispose() : colorNegro.Dispose() : colorGris.Dispose()
        colorLinea.Dispose() : fuenteTitulo.Dispose() : fuenteSubtit.Dispose()
        fuenteLabel.Dispose() : fuenteValor.Dispose() : fuenteTotal.Dispose()
        fuentePie.Dispose() : fuenteCIP.Dispose()

        e.HasMorePages = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
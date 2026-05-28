Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmConstanciaMatricula


    Dim WithEvents docPrint As New PrintDocument()

    Dim _estudiante As String = ""
    Dim _apoderado As String = ""
    Dim _fechaMatricula As String = ""
    Dim _nivelGradoSeccion As String = ""
    Dim _becaActiva As String = ""
    Dim _dctoPensiones As String = ""
    Dim _codOperativo As String = ""
    Dim _montoTotal As String = ""
    Dim _cronograma As DataTable = Nothing


    Public Sub CargarDatos(estudiante As String,
                           apoderado As String,
                           fechaMatricula As String,
                           nivelGradoSeccion As String,
                           becaActiva As String,
                           dctoPensiones As String,
                           codOperativo As String,
                           montoTotal As String,
                           cronograma As DataTable)
        _estudiante = estudiante
        _apoderado = apoderado
        _fechaMatricula = fechaMatricula
        _nivelGradoSeccion = nivelGradoSeccion
        _becaActiva = becaActiva
        _dctoPensiones = dctoPensiones
        _codOperativo = codOperativo
        _montoTotal = montoTotal
        _cronograma = cronograma
    End Sub


    Private Sub ImprimirConstancia()
        Try
            Dim dlg As New PrintDialog()
            dlg.Document = docPrint

            If dlg.ShowDialog() = DialogResult.OK Then
                docPrint.Print()
                MessageBox.Show("¡Constancia impresa correctamente!",
                                "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al imprimir: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
        End Try
    End Sub


    Private Sub docPrint_PrintPage(sender As Object, e As PrintPageEventArgs) _
        Handles docPrint.PrintPage

        Dim g As Graphics = e.Graphics

        Dim colorRojo As New SolidBrush(Color.FromArgb(139, 0, 0))
        Dim colorNegro As New SolidBrush(Color.Black)
        Dim colorGris As New SolidBrush(Color.FromArgb(245, 245, 245))
        Dim colorLinea As New Pen(Color.FromArgb(180, 180, 180), 1)
        Dim colorBorde As New Pen(Color.FromArgb(139, 0, 0), 1.5)

        Dim fuenteTitulo As New Font("Arial", 16, FontStyle.Bold)
        Dim fuenteSubtit As New Font("Arial", 9, FontStyle.Regular)
        Dim fuenteSeccion As New Font("Arial", 9, FontStyle.Bold)
        Dim fuenteLabel As New Font("Arial", 8, FontStyle.Bold)
        Dim fuenteValor As New Font("Arial", 8, FontStyle.Regular)
        Dim fuenteTotal As New Font("Arial", 9, FontStyle.Bold)
        Dim fuentePie As New Font("Arial", 7, FontStyle.Italic)
        Dim fuenteFirma As New Font("Arial", 8, FontStyle.Regular)

        Dim mx As Integer = 55
        Dim aw As Integer = 490
        Dim y As Integer = 30

        ' ── CABECERA ──
        g.FillRectangle(colorRojo, New Rectangle(mx, y, aw, 60))
        g.DrawString("CONSTANCIA DE MATRÍCULA", fuenteTitulo, Brushes.White,
                     New PointF(mx + 10, y + 8))
        g.DrawString("Institución Educativa · I.E.P AMANCIO VARONA · Año " &
                     DateTime.Now.Year.ToString(),
                     fuenteSubtit, Brushes.WhiteSmoke, New PointF(mx + 10, y + 38))
        y += 72

        ' ── FUNCIÓN FILA ──
        Dim DibujarFila As Action(Of String, String, Boolean) =
            Sub(lbl As String, val As String, sombrear As Boolean)
                If sombrear Then
                    g.FillRectangle(colorGris, New Rectangle(mx, y, aw, 22))
                End If
                g.DrawString(lbl, fuenteLabel, colorNegro, New PointF(mx + 6, y + 4))
                g.DrawString(val, fuenteValor, colorNegro, New PointF(mx + 180, y + 4))
                g.DrawLine(colorLinea, mx, y + 22, mx + aw, y + 22)
                y += 24
            End Sub

        ' ── DATOS DEL ESTUDIANTE ──
        g.DrawString("► DATOS DEL ESTUDIANTE", fuenteSeccion, colorRojo, New PointF(mx, y))
        y += 16
        g.DrawLine(colorBorde, mx, y, mx + aw, y)
        y += 6

        DibujarFila("Estudiante:", _estudiante, True)
        DibujarFila("Apoderado:", _apoderado, False)
        DibujarFila("Nivel / Grado / Sec:", _nivelGradoSeccion, True)
        DibujarFila("Fecha de Matrícula:", _fechaMatricula, False)
        y += 10

        ' ── CONDICIONES ECONÓMICAS ──
        g.DrawString("► CONDICIONES ECONÓMICAS", fuenteSeccion, colorRojo, New PointF(mx, y))
        y += 16
        g.DrawLine(colorBorde, mx, y, mx + aw, y)
        y += 6

        DibujarFila("Beca Activa:", _becaActiva, True)
        DibujarFila("Descuento Pensiones:", _dctoPensiones, False)
        DibujarFila("Cod. Operativo (Voucher):", _codOperativo, True)


        g.FillRectangle(colorRojo, New Rectangle(mx, y, aw, 24))
        g.DrawString("Monto de Matrícula Pagado:", fuenteTotal, Brushes.White,
                     New PointF(mx + 6, y + 4))
        g.DrawString(_montoTotal, fuenteTotal, Brushes.White,
                     New PointF(mx + 180, y + 4))
        y += 34

        ' ── CRONOGRAMA ──
        y += 6
        g.DrawString("► CRONOGRAMA DE PAGOS DE PENSIONES", fuenteSeccion, colorRojo, New PointF(mx, y))
        y += 16
        g.DrawLine(colorBorde, mx, y, mx + aw, y)
        y += 6

        If _cronograma IsNot Nothing AndAlso _cronograma.Rows.Count > 0 Then
            Dim anchoCol As Integer = aw \ 4
            g.FillRectangle(colorRojo, New Rectangle(mx, y, aw, 20))
            g.DrawString("N° Cuota", fuenteLabel, Brushes.White, New PointF(mx + 6, y + 3))
            g.DrawString("Vencimiento", fuenteLabel, Brushes.White, New PointF(mx + anchoCol + 6, y + 3))
            g.DrawString("Monto", fuenteLabel, Brushes.White, New PointF(mx + anchoCol * 2 + 6, y + 3))
            g.DrawString("Estado", fuenteLabel, Brushes.White, New PointF(mx + anchoCol * 3 + 6, y + 3))
            y += 22

            Dim sombrear As Boolean = True
            For Each row As DataRow In _cronograma.Rows
                If sombrear Then
                    g.FillRectangle(colorGris, New Rectangle(mx, y, aw, 20))
                End If
                g.DrawString(row(0).ToString(), fuenteValor, colorNegro, New PointF(mx + 6, y + 3))
                g.DrawString(row(1).ToString(), fuenteValor, colorNegro, New PointF(mx + anchoCol + 6, y + 3))
                g.DrawString(row(2).ToString(), fuenteValor, colorNegro, New PointF(mx + anchoCol * 2 + 6, y + 3))
                g.DrawString(row(3).ToString(), fuenteValor, colorNegro, New PointF(mx + anchoCol * 3 + 6, y + 3))
                g.DrawLine(colorLinea, mx, y + 20, mx + aw, y + 20)
                y += 22
                sombrear = Not sombrear
            Next
        Else
            g.DrawString("No hay cronograma registrado.", fuenteValor,
                         colorNegro, New PointF(mx + 6, y + 4))
            y += 24
        End If

        ' ── FIRMAS ──
        y += 20
        Dim anchoFirma As Integer = 160
        g.DrawLine(New Pen(Color.Black, 1), mx, y, mx + anchoFirma, y)
        g.DrawString("Director(a)", fuenteFirma, colorNegro, New PointF(mx + 30, y + 4))

        Dim xSec As Integer = mx + aw - anchoFirma
        g.DrawLine(New Pen(Color.Black, 1), xSec, y, xSec + anchoFirma, y)
        g.DrawString("Secretaria", fuenteFirma, colorNegro, New PointF(xSec + 35, y + 4))
        y += 30

        ' ── PIE ──
        g.DrawLine(colorLinea, mx, y, mx + aw, y)
        y += 6
        g.DrawString("Documento generado el " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") &
                     "  ·  Válido con sello institucional.",
                     fuentePie, colorNegro, New PointF(mx, y))

        colorRojo.Dispose() : colorNegro.Dispose() : colorGris.Dispose()
        colorLinea.Dispose() : colorBorde.Dispose()
        fuenteTitulo.Dispose() : fuenteSubtit.Dispose() : fuenteSeccion.Dispose()
        fuenteLabel.Dispose() : fuenteValor.Dispose() : fuenteTotal.Dispose()
        fuentePie.Dispose() : fuenteFirma.Dispose()

        e.HasMorePages = False
    End Sub


    Public Sub ImprimirSilencioso()
        Try
            Dim dlg As New PrintDialog()
            dlg.Document = docPrint

            If dlg.ShowDialog() = DialogResult.OK Then
                docPrint.Print()
                MessageBox.Show("¡Constancia impresa correctamente!",
                                "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al imprimir: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmConstanciaMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class
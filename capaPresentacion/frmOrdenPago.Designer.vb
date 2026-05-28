<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCIP = New System.Windows.Forms.TextBox()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCopiarCip = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtMontoBase = New System.Windows.Forms.TextBox()
        Me.btnSimularPago = New System.Windows.Forms.Button()
        Me.btnDescargar = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 55)
        Me.Panel3.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 321)
        Me.Panel1.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Snow
        Me.Label13.Location = New System.Drawing.Point(9, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ORDEN DE PAGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(51, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Código de pago (CIP):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(52, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Vencimiento:"
        '
        'txtCIP
        '
        Me.txtCIP.Location = New System.Drawing.Point(205, 89)
        Me.txtCIP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCIP.Name = "txtCIP"
        Me.txtCIP.Size = New System.Drawing.Size(173, 20)
        Me.txtCIP.TabIndex = 40
        '
        'txtVencimiento
        '
        Me.txtVencimiento.Location = New System.Drawing.Point(205, 125)
        Me.txtVencimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(173, 20)
        Me.txtVencimiento.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(52, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Total a Pagar:"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(205, 228)
        Me.txtTotalPagar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(173, 20)
        Me.txtTotalPagar.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 50)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Por favor, cancele este monto en su banca móvil o agente autorizado."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCopiarCip
        '
        Me.btnCopiarCip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnCopiarCip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnCopiarCip.Location = New System.Drawing.Point(16, 323)
        Me.btnCopiarCip.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCopiarCip.Name = "btnCopiarCip"
        Me.btnCopiarCip.Size = New System.Drawing.Size(124, 48)
        Me.btnCopiarCip.TabIndex = 45
        Me.btnCopiarCip.Text = "COPIAR CIP"
        Me.btnCopiarCip.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Location = New System.Drawing.Point(152, 326)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(124, 48)
        Me.btnImprimir.TabIndex = 46
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label5.Location = New System.Drawing.Point(52, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Monto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label6.Location = New System.Drawing.Point(51, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Descuento:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(205, 196)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(173, 20)
        Me.txtDescuento.TabIndex = 49
        '
        'txtMontoBase
        '
        Me.txtMontoBase.Location = New System.Drawing.Point(205, 160)
        Me.txtMontoBase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMontoBase.Name = "txtMontoBase"
        Me.txtMontoBase.Size = New System.Drawing.Size(173, 20)
        Me.txtMontoBase.TabIndex = 50
        '
        'btnSimularPago
        '
        Me.btnSimularPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSimularPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnSimularPago.Location = New System.Drawing.Point(91, 393)
        Me.btnSimularPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimularPago.Name = "btnSimularPago"
        Me.btnSimularPago.Size = New System.Drawing.Size(224, 48)
        Me.btnSimularPago.TabIndex = 51
        Me.btnSimularPago.Text = "SIMULAR PAGO EN BANCO"
        Me.btnSimularPago.UseVisualStyleBackColor = False
        '
        'btnDescargar
        '
        Me.btnDescargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDescargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnDescargar.Location = New System.Drawing.Point(296, 323)
        Me.btnDescargar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(124, 48)
        Me.btnDescargar.TabIndex = 52
        Me.btnDescargar.Text = "DESCARGAR"
        Me.btnDescargar.UseVisualStyleBackColor = False
        '
        'frmOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 469)
        Me.Controls.Add(Me.btnDescargar)
        Me.Controls.Add(Me.btnSimularPago)
        Me.Controls.Add(Me.txtMontoBase)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCopiarCip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVencimiento)
        Me.Controls.Add(Me.txtCIP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmOrdenPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCIP As TextBox
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCopiarCip As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtMontoBase As TextBox
    Friend WithEvents btnSimularPago As Button
    Friend WithEvents btnDescargar As Button
End Class

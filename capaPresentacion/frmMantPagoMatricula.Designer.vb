<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPagoMatricula
    Inherits capaPresentacion.frmMantAnoAcademico

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoOperativo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Size = New System.Drawing.Size(452, 29)
        Me.Label4.Text = "Mantenimiento de Pagos de Matrícula"
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.Text = "Fecha de Pago:"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.Text = ""
        Me.Label2.Visible = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(37, 317)
        Me.dtpFechaFin.Size = New System.Drawing.Size(38, 22)
        Me.dtpFechaFin.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cód. Operativo:"
        '
        'txtCodigoOperativo
        '
        Me.txtCodigoOperativo.Location = New System.Drawing.Point(141, 190)
        Me.txtCodigoOperativo.Name = "txtCodigoOperativo"
        Me.txtCodigoOperativo.Size = New System.Drawing.Size(186, 22)
        Me.txtCodigoOperativo.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(142, 221)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(186, 22)
        Me.txtMonto.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 252)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 22)
        Me.TextBox2.TabIndex = 23
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.AutoSize = True
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(33, 255)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(104, 16)
        Me.txtNumeroReferencia.TabIndex = 22
        Me.txtNumeroReferencia.Text = "Nro. Referencia:"
        '
        'frmMantPagoMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(591, 475)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtNumeroReferencia)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodigoOperativo)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmMantPagoMatricula"
        Me.Text = "Mantenimiento de Pagos de Matrícula"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFin, 0)
        Me.Controls.SetChildIndex(Me.chkEstado, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.btnBuscar, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtCodigoOperativo, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtMonto, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroReferencia, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigoOperativo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtNumeroReferencia As Label
End Class

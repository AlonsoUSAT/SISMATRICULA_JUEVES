<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEspecialidad
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlBajas = New System.Windows.Forms.Panel()
        Me.lblBajas = New System.Windows.Forms.Label()
        Me.pnlVigentes = New System.Windows.Forms.Panel()
        Me.lblVigentes = New System.Windows.Forms.Label()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvEspecialidades = New System.Windows.Forms.DataGridView()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBajas.SuspendLayout()
        Me.pnlVigentes.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 55)
        Me.Panel1.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultar especialidades"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pnlBajas)
        Me.Panel2.Controls.Add(Me.pnlVigentes)
        Me.Panel2.Controls.Add(Me.pnlTotal)
        Me.Panel2.Location = New System.Drawing.Point(17, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(537, 113)
        Me.Panel2.TabIndex = 56
        '
        'pnlBajas
        '
        Me.pnlBajas.BackColor = System.Drawing.Color.Snow
        Me.pnlBajas.Controls.Add(Me.Label5)
        Me.pnlBajas.Controls.Add(Me.lblBajas)
        Me.pnlBajas.Location = New System.Drawing.Point(352, 18)
        Me.pnlBajas.Name = "pnlBajas"
        Me.pnlBajas.Size = New System.Drawing.Size(140, 70)
        Me.pnlBajas.TabIndex = 2
        '
        'lblBajas
        '
        Me.lblBajas.AutoSize = True
        Me.lblBajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBajas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblBajas.Location = New System.Drawing.Point(69, 14)
        Me.lblBajas.Name = "lblBajas"
        Me.lblBajas.Size = New System.Drawing.Size(0, 33)
        Me.lblBajas.TabIndex = 2
        Me.lblBajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlVigentes
        '
        Me.pnlVigentes.BackColor = System.Drawing.Color.Snow
        Me.pnlVigentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVigentes.Controls.Add(Me.Label4)
        Me.pnlVigentes.Controls.Add(Me.lblVigentes)
        Me.pnlVigentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnlVigentes.Location = New System.Drawing.Point(189, 18)
        Me.pnlVigentes.Name = "pnlVigentes"
        Me.pnlVigentes.Size = New System.Drawing.Size(140, 70)
        Me.pnlVigentes.TabIndex = 1
        '
        'lblVigentes
        '
        Me.lblVigentes.AutoSize = True
        Me.lblVigentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigentes.Location = New System.Drawing.Point(64, 13)
        Me.lblVigentes.Name = "lblVigentes"
        Me.lblVigentes.Size = New System.Drawing.Size(0, 33)
        Me.lblVigentes.TabIndex = 1
        Me.lblVigentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTotal
        '
        Me.pnlTotal.BackColor = System.Drawing.Color.Snow
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.Label3)
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.Location = New System.Drawing.Point(29, 18)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(140, 70)
        Me.pnlTotal.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotal.Location = New System.Drawing.Point(64, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 33)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Filtrar por estado:"
        '
        'cboFiltro
        '
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(17, 212)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(256, 21)
        Me.cboFiltro.TabIndex = 58
        '
        'dgvEspecialidades
        '
        Me.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecialidades.Location = New System.Drawing.Point(17, 239)
        Me.dgvEspecialidades.Name = "dgvEspecialidades"
        Me.dgvEspecialidades.Size = New System.Drawing.Size(537, 150)
        Me.dgvEspecialidades.TabIndex = 59
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(14, 428)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(0, 13)
        Me.lblContador.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(49, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vigentes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dadas de baja"
        '
        'frmConsultaEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 399)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.dgvEspecialidades)
        Me.Controls.Add(Me.cboFiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmConsultaEspecialidad"
        Me.Text = "Especialidad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlBajas.ResumeLayout(False)
        Me.pnlBajas.PerformLayout()
        Me.pnlVigentes.ResumeLayout(False)
        Me.pnlVigentes.PerformLayout()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlBajas As Panel
    Friend WithEvents pnlVigentes As Panel
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents lblBajas As Label
    Friend WithEvents lblVigentes As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboFiltro As ComboBox
    Friend WithEvents dgvEspecialidades As DataGridView
    Friend WithEvents lblContador As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

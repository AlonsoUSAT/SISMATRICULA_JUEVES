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
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.lblBajas = New System.Windows.Forms.Label()
        Me.pnlVigentes = New System.Windows.Forms.Panel()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.lblVigentes = New System.Windows.Forms.Label()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotall = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblContar = New System.Windows.Forms.Label()
        Me.dgvEspecialidades = New System.Windows.Forms.DataGridView()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblContadorDocentes = New System.Windows.Forms.Label()
        Me.lblEspSeleccionada = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDocentes = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBajas.SuspendLayout()
        Me.pnlVigentes.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(738, 113)
        Me.Panel2.TabIndex = 56
        '
        'pnlBajas
        '
        Me.pnlBajas.BackColor = System.Drawing.Color.Snow
        Me.pnlBajas.Controls.Add(Me.Label4)
        Me.pnlBajas.Controls.Add(Me.lblBaja)
        Me.pnlBajas.Controls.Add(Me.lblBajas)
        Me.pnlBajas.Location = New System.Drawing.Point(488, 18)
        Me.pnlBajas.Name = "pnlBajas"
        Me.pnlBajas.Size = New System.Drawing.Size(213, 70)
        Me.pnlBajas.TabIndex = 2
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaja.Location = New System.Drawing.Point(32, 11)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(201, 31)
        Me.lblBaja.TabIndex = 3
        Me.lblBaja.Text = "Dadas de baja"
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
        Me.pnlVigentes.Controls.Add(Me.Label3)
        Me.pnlVigentes.Controls.Add(Me.lblVigente)
        Me.pnlVigentes.Controls.Add(Me.lblVigentes)
        Me.pnlVigentes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.pnlVigentes.Location = New System.Drawing.Point(257, 18)
        Me.pnlVigentes.Name = "pnlVigentes"
        Me.pnlVigentes.Size = New System.Drawing.Size(213, 70)
        Me.pnlVigentes.TabIndex = 1
        '
        'lblVigente
        '
        Me.lblVigente.AutoSize = True
        Me.lblVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigente.Location = New System.Drawing.Point(28, 11)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(128, 31)
        Me.lblVigente.TabIndex = 2
        Me.lblVigente.Text = "Vigentes"
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
        Me.pnlTotal.Controls.Add(Me.lbl)
        Me.pnlTotal.Controls.Add(Me.lblTotall)
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.Location = New System.Drawing.Point(29, 18)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(213, 70)
        Me.pnlTotal.TabIndex = 0
        '
        'lblTotall
        '
        Me.lblTotall.AutoSize = True
        Me.lblTotall.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotall.ForeColor = System.Drawing.Color.Gray
        Me.lblTotall.Location = New System.Drawing.Point(24, 11)
        Me.lblTotall.Name = "lblTotall"
        Me.lblTotall.Size = New System.Drawing.Size(80, 31)
        Me.lblTotall.TabIndex = 1
        Me.lblTotall.Text = "Total"
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
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(14, 428)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(0, 13)
        Me.lblContador.TabIndex = 60
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblContar)
        Me.Panel3.Controls.Add(Me.dgvEspecialidades)
        Me.Panel3.Controls.Add(Me.cboFiltro)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(17, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(295, 252)
        Me.Panel3.TabIndex = 61
        '
        'lblContar
        '
        Me.lblContar.AutoSize = True
        Me.lblContar.ForeColor = System.Drawing.Color.Snow
        Me.lblContar.Location = New System.Drawing.Point(119, 228)
        Me.lblContar.Name = "lblContar"
        Me.lblContar.Size = New System.Drawing.Size(0, 13)
        Me.lblContar.TabIndex = 3
        '
        'dgvEspecialidades
        '
        Me.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecialidades.Location = New System.Drawing.Point(20, 67)
        Me.dgvEspecialidades.Name = "dgvEspecialidades"
        Me.dgvEspecialidades.Size = New System.Drawing.Size(253, 150)
        Me.dgvEspecialidades.TabIndex = 2
        '
        'cboFiltro
        '
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(20, 39)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(253, 21)
        Me.cboFiltro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(17, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ESPECIALIDADES"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblContadorDocentes)
        Me.Panel4.Controls.Add(Me.lblEspSeleccionada)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.dgvDocentes)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(327, 200)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(428, 252)
        Me.Panel4.TabIndex = 62
        '
        'lblContadorDocentes
        '
        Me.lblContadorDocentes.AutoSize = True
        Me.lblContadorDocentes.ForeColor = System.Drawing.Color.Snow
        Me.lblContadorDocentes.Location = New System.Drawing.Point(331, 228)
        Me.lblContadorDocentes.Name = "lblContadorDocentes"
        Me.lblContadorDocentes.Size = New System.Drawing.Size(0, 13)
        Me.lblContadorDocentes.TabIndex = 6
        '
        'lblEspSeleccionada
        '
        Me.lblEspSeleccionada.AutoSize = True
        Me.lblEspSeleccionada.BackColor = System.Drawing.Color.Snow
        Me.lblEspSeleccionada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEspSeleccionada.Location = New System.Drawing.Point(157, 47)
        Me.lblEspSeleccionada.Name = "lblEspSeleccionada"
        Me.lblEspSeleccionada.Size = New System.Drawing.Size(0, 13)
        Me.lblEspSeleccionada.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Snow
        Me.Label9.Location = New System.Drawing.Point(21, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Especialidad seleccionada:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(139, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 3
        '
        'dgvDocentes
        '
        Me.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvDocentes.Location = New System.Drawing.Point(20, 67)
        Me.dgvDocentes.Name = "dgvDocentes"
        Me.dgvDocentes.Size = New System.Drawing.Size(389, 150)
        Me.dgvDocentes.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(17, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ESPECIALIDADES"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Docente"
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Docente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 146
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Cargas"
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Cargas"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Estado"
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Estado"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(30, 46)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(31, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vigentes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dadas de baja"
        '
        'frmConsultaEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 459)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblContador)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblContador As Label
    Friend WithEvents lblBaja As Label
    Friend WithEvents lblVigente As Label
    Friend WithEvents lblTotall As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvEspecialidades As DataGridView
    Friend WithEvents cboFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblContar As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblEspSeleccionada As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDocentes As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lblContadorDocentes As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label4 As Label
End Class

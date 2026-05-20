<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaAcademica
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.colEliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Panel1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1141, 55)
		Me.Panel1.TabIndex = 35
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Snow
		Me.Label1.Location = New System.Drawing.Point(12, 11)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(312, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Gestión de carga académica"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(22, 74)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 20)
		Me.Label2.TabIndex = 36
		Me.Label2.Text = "Docente:"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(105, 76)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(234, 21)
		Me.ComboBox1.TabIndex = 37
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(453, 79)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(234, 21)
		Me.ComboBox2.TabIndex = 39
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(370, 77)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(74, 20)
		Me.Label3.TabIndex = 38
		Me.Label3.Text = "Sección:"
		'
		'ComboBox3
		'
		Me.ComboBox3.FormattingEnabled = True
		Me.ComboBox3.Location = New System.Drawing.Point(820, 82)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(234, 21)
		Me.ComboBox3.TabIndex = 41
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(737, 80)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 20)
		Me.Label4.TabIndex = 40
		Me.Label4.Text = "Horario:"
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(389, 125)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(331, 36)
		Me.Button1.TabIndex = 42
		Me.Button1.Text = "NUEVA ASIGNACIÓN"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.colEditar, Me.colEliminar})
		Me.DataGridView1.Location = New System.Drawing.Point(26, 179)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1087, 419)
		Me.DataGridView1.TabIndex = 43
		'
		'colEliminar
		'
		Me.colEliminar.Frozen = True
		Me.colEliminar.HeaderText = ""
		Me.colEliminar.Name = "colEliminar"
		Me.colEliminar.ReadOnly = True
		'
		'colEditar
		'
		Me.colEditar.Frozen = True
		Me.colEditar.HeaderText = "Acciones"
		Me.colEditar.Name = "colEditar"
		Me.colEditar.ReadOnly = True
		'
		'Column5
		'
		Me.Column5.Frozen = True
		Me.Column5.HeaderText = "Estado"
		Me.Column5.Name = "Column5"
		Me.Column5.ReadOnly = True
		Me.Column5.Width = 120
		'
		'Column4
		'
		Me.Column4.Frozen = True
		Me.Column4.HeaderText = "Horario"
		Me.Column4.Name = "Column4"
		Me.Column4.ReadOnly = True
		Me.Column4.Width = 200
		'
		'Column3
		'
		Me.Column3.Frozen = True
		Me.Column3.HeaderText = "Sección"
		Me.Column3.Name = "Column3"
		Me.Column3.ReadOnly = True
		Me.Column3.Width = 125
		'
		'Column2
		'
		Me.Column2.Frozen = True
		Me.Column2.HeaderText = "Curso"
		Me.Column2.Name = "Column2"
		Me.Column2.ReadOnly = True
		Me.Column2.Width = 200
		'
		'Column1
		'
		Me.Column1.Frozen = True
		Me.Column1.HeaderText = "Docente"
		Me.Column1.Name = "Column1"
		Me.Column1.ReadOnly = True
		Me.Column1.Width = 200
		'
		'frmCargaAcademica
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1126, 610)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ComboBox3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmCargaAcademica"
		Me.Text = "frmCargaAcademica"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Column5 As DataGridViewTextBoxColumn
	Friend WithEvents colEditar As DataGridViewTextBoxColumn
	Friend WithEvents colEliminar As DataGridViewTextBoxColumn
End Class

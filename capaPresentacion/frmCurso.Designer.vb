<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurso
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.txtNombreCurso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkVigente = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnDarBaja)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(31, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 70)
        Me.Panel2.TabIndex = 35
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(119, 26)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 28)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.Location = New System.Drawing.Point(332, 26)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(96, 28)
        Me.btnDarBaja.TabIndex = 3
        Me.btnDarBaja.Text = "Dar Baja"
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(227, 26)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 28)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(435, 26)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 28)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(12, 26)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 28)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 55)
        Me.Panel1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestiòn de estructura académica"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(46, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Área académica/categorías:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(46, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Estado:"
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboArea.Location = New System.Drawing.Point(228, 173)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(238, 21)
        Me.cboArea.TabIndex = 45
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.Location = New System.Drawing.Point(228, 26)
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(238, 20)
        Me.txtNombreCurso.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(46, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(228, 61)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(238, 102)
        Me.txtDescripcion.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(46, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre del curso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkVigente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombreCurso)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 305)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del curso"
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Location = New System.Drawing.Point(228, 213)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 50
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(228, 254)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(238, 20)
        Me.txtID.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(46, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCursos)
        Me.GroupBox2.Controls.Add(Me.btnFiltrar)
        Me.GroupBox2.Controls.Add(Me.txtBuscarNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 381)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de cursos existentes"
        '
        'dgvCursos
        '
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Location = New System.Drawing.Point(20, 95)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.Size = New System.Drawing.Size(550, 270)
        Me.dgvCursos.TabIndex = 44
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(260, 61)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(96, 28)
        Me.btnFiltrar.TabIndex = 43
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Location = New System.Drawing.Point(237, 26)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(266, 20)
        Me.txtBuscarNombre.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(107, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Buscar por nombre:"
        '
        'frmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCurso"
        Me.Text = "frmCurso"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
	Friend WithEvents btnGuardar As Button
	Friend WithEvents btnDarBaja As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents btnEliminar As Button
	Friend WithEvents btnNuevo As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents cboArea As ComboBox
	Friend WithEvents txtNombreCurso As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtDescripcion As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents chkVigente As CheckBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents dgvCursos As DataGridView
	Friend WithEvents btnFiltrar As Button
	Friend WithEvents txtBuscarNombre As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents Label6 As Label
End Class

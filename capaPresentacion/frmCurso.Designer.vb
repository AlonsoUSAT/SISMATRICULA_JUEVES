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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurso))
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
        Me.btnSafe = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.chkVigente = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.Panel1.Size = New System.Drawing.Size(1129, 55)
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
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(26, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Área académica/categorías:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(27, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Estado:"
        '
        'cboArea
        '
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboArea.ForeColor = System.Drawing.Color.Black
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cboArea.Location = New System.Drawing.Point(226, 210)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(238, 27)
        Me.cboArea.TabIndex = 45
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtNombreCurso.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCurso.Location = New System.Drawing.Point(226, 63)
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(238, 27)
        Me.txtNombreCurso.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(27, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(226, 98)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(238, 102)
        Me.txtDescripcion.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(27, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre del curso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnSafe)
        Me.GroupBox1.Controls.Add(Me.btnBaja)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnNew)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(10, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 453)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del curso"
        '
        'btnSafe
        '
        Me.btnSafe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSafe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSafe.Image = Global.capaPresentacion.My.Resources.Resources.guardar_usuario
        Me.btnSafe.Location = New System.Drawing.Point(174, 344)
        Me.btnSafe.Name = "btnSafe"
        Me.btnSafe.Size = New System.Drawing.Size(131, 38)
        Me.btnSafe.TabIndex = 55
        Me.btnSafe.Text = "GUARDAR"
        Me.btnSafe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSafe.UseVisualStyleBackColor = False
        '
        'btnBaja
        '
        Me.btnBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnBaja.Location = New System.Drawing.Point(76, 399)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(144, 37)
        Me.btnBaja.TabIndex = 54
        Me.btnBaja.Text = "DAR DE BAJA"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.capaPresentacion.My.Resources.Resources.actualizar
        Me.btnUpdate.Location = New System.Drawing.Point(323, 344)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 38)
        Me.btnUpdate.TabIndex = 53
        Me.btnUpdate.Text = "ACTUALIZAR"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.capaPresentacion.My.Resources.Resources.eliminar_amigo
        Me.btnDelete.Location = New System.Drawing.Point(259, 399)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 37)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.Text = "ELIMINAR"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.capaPresentacion.My.Resources.Resources.agregar_usuario
        Me.btnNew.Location = New System.Drawing.Point(31, 344)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(131, 38)
        Me.btnNew.TabIndex = 51
        Me.btnNew.Text = "NUEVO"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.chkVigente.ForeColor = System.Drawing.Color.Black
        Me.chkVigente.Location = New System.Drawing.Point(226, 249)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(79, 24)
        Me.chkVigente.TabIndex = 50
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(226, 291)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(238, 27)
        Me.txtID.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(27, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.dgvCursos)
        Me.GroupBox2.Controls.Add(Me.btnFiltrar)
        Me.GroupBox2.Controls.Add(Me.txtBuscarNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(525, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 453)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de cursos existentes"
        '
        'dgvCursos
        '
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Location = New System.Drawing.Point(21, 93)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.RowHeadersWidth = 51
        Me.dgvCursos.Size = New System.Drawing.Size(550, 343)
        Me.dgvCursos.TabIndex = 44
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnFiltrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrar.ForeColor = System.Drawing.Color.Black
        Me.btnFiltrar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnFiltrar.Location = New System.Drawing.Point(410, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(160, 48)
        Me.btnFiltrar.TabIndex = 43
        Me.btnFiltrar.Text = "BUSCAR"
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtBuscarNombre.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarNombre.Location = New System.Drawing.Point(140, 43)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(266, 27)
        Me.txtBuscarNombre.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Buscar por nombre:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-4, 49)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1135, 486)
        Me.FlowLayoutPanel1.TabIndex = 53
        '
        'frmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
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
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnSafe As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNew As Button
End Class

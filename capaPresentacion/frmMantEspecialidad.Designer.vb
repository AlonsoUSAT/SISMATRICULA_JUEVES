<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantEspecialidad
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevoGuardar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvEspecialidades = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestión de especialidades"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.chkEstado)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(14, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 201)
        Me.Panel2.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DATOS DE LA ESPECIALIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(33, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(235, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(33, 159)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(235, 20)
        Me.txtID.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(33, 112)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(62, 17)
        Me.chkEstado.TabIndex = 7
        Me.chkEstado.Text = "Vigente"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.eliminar_amigo
        Me.btnEliminar.Location = New System.Drawing.Point(173, 301)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 48)
        Me.btnEliminar.TabIndex = 63
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevoGuardar
        '
        Me.btnNuevoGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevoGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevoGuardar.Image = Global.capaPresentacion.My.Resources.Resources.guardar_usuario
        Me.btnNuevoGuardar.Location = New System.Drawing.Point(14, 237)
        Me.btnNuevoGuardar.Name = "btnNuevoGuardar"
        Me.btnNuevoGuardar.Size = New System.Drawing.Size(132, 48)
        Me.btnNuevoGuardar.TabIndex = 60
        Me.btnNuevoGuardar.Text = "NUEVO"
        Me.btnNuevoGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevoGuardar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDarBaja.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnDarBaja.Location = New System.Drawing.Point(14, 301)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(132, 48)
        Me.btnDarBaja.TabIndex = 62
        Me.btnDarBaja.Text = "DAR BAJA"
        Me.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.Image = Global.capaPresentacion.My.Resources.Resources.actualizar
        Me.btnModificar.Location = New System.Drawing.Point(173, 237)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(132, 48)
        Me.btnModificar.TabIndex = 61
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Controls.Add(Me.btnDarBaja)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnNuevoGuardar)
        Me.Panel3.Location = New System.Drawing.Point(12, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 361)
        Me.Panel3.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Buscar por nombre:"
        '
        'cboFiltro
        '
        Me.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(349, 87)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(411, 21)
        Me.cboFiltro.TabIndex = 66
        '
        'dgvEspecialidades
        '
        Me.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecialidades.Location = New System.Drawing.Point(349, 128)
        Me.dgvEspecialidades.Name = "dgvEspecialidades"
        Me.dgvEspecialidades.ReadOnly = True
        Me.dgvEspecialidades.Size = New System.Drawing.Size(411, 294)
        Me.dgvEspecialidades.TabIndex = 68
        '
        'frmMantEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 443)
        Me.Controls.Add(Me.dgvEspecialidades)
        Me.Controls.Add(Me.cboFiltro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmMantEspecialidad"
        Me.Text = "frmMantEspecialidad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevoGuardar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents cboFiltro As ComboBox
    Friend WithEvents dgvEspecialidades As DataGridView
End Class

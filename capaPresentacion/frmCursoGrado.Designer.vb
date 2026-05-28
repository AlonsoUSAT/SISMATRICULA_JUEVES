<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCursoGrado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignacion de Cursos por Grado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboAño)
        Me.GroupBox1.Controls.Add(Me.cboCurso)
        Me.GroupBox1.Controls.Add(Me.cboGrado)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(31, 83)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(434, 171)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Asignación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(87, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Año:"
        '
        'cboAño
        '
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Location = New System.Drawing.Point(168, 37)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(166, 28)
        Me.cboAño.TabIndex = 51
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(168, 105)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(166, 28)
        Me.cboCurso.TabIndex = 50
        '
        'cboGrado
        '
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Location = New System.Drawing.Point(168, 71)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(166, 28)
        Me.cboGrado.TabIndex = 49
        '
        'chkEstado
        '
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkEstado.Location = New System.Drawing.Point(168, 138)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(77, 20)
        Me.chkEstado.TabIndex = 48
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(5, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 19)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Seleccionar Grado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Seleccionar Curso:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(71, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Estado:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnDarBaja)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(471, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 329)
        Me.Panel2.TabIndex = 56
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.capaPresentacion.My.Resources.Resources.guardar_usuario
        Me.btnGuardar.Location = New System.Drawing.Point(37, 99)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(160, 48)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnDarBaja.Location = New System.Drawing.Point(37, 176)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(160, 48)
        Me.btnDarBaja.TabIndex = 3
        Me.btnDarBaja.Text = "DAR DE BAJA"
        Me.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.eliminar_amigo
        Me.btnEliminar.Location = New System.Drawing.Point(37, 251)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 48)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.capaPresentacion.My.Resources.Resources.agregar_usuario
        Me.btnNuevo.Location = New System.Drawing.Point(37, 25)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(160, 48)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(31, 259)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(434, 153)
        Me.dgvTabla.TabIndex = 57
        '
        'frmCursoGrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.dgvTabla)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCursoGrado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvTabla As DataGridView
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Protected WithEvents chkEstado As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboAño As ComboBox
End Class

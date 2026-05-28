<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPagoMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantPagoMatricula))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCodigoOperativo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.dgvAnos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvAnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 47)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANTENIMIENTO PAGO MATRICULA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumeroReferencia)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtCodigoOperativo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(14, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(332, 319)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Pago Matricula"
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(131, 286)
        Me.txtNumeroReferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(142, 26)
        Me.txtNumeroReferencia.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 286)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nro. Referencia:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(131, 242)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(142, 26)
        Me.txtMonto.TabIndex = 15
        '
        'txtCodigoOperativo
        '
        Me.txtCodigoOperativo.Location = New System.Drawing.Point(131, 183)
        Me.txtCodigoOperativo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigoOperativo.Name = "txtCodigoOperativo"
        Me.txtCodigoOperativo.Size = New System.Drawing.Size(142, 26)
        Me.txtCodigoOperativo.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(20, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Monto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cod. Operativo:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.chkEstado.ForeColor = System.Drawing.Color.Black
        Me.chkEstado.Location = New System.Drawing.Point(133, 81)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(70, 24)
        Me.chkEstado.TabIndex = 11
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(133, 136)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(140, 27)
        Me.dtpFechaInicio.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha de pago:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vigencia:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnBuscar.Location = New System.Drawing.Point(213, 29)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(105, 33)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(131, 33)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 26)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnActualizar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnDarBaja)
        Me.Panel2.Location = New System.Drawing.Point(380, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 306)
        Me.Panel2.TabIndex = 17
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.Image = Global.capaPresentacion.My.Resources.Resources.actualizar
        Me.btnActualizar.Location = New System.Drawing.Point(13, 67)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(160, 48)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Image = Global.capaPresentacion.My.Resources.Resources.agregar_usuario
        Me.btnNuevo.Location = New System.Drawing.Point(13, 10)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(160, 48)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Image = Global.capaPresentacion.My.Resources.Resources.borrador
        Me.btnLimpiar.Location = New System.Drawing.Point(13, 242)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 48)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.eliminar_amigo
        Me.btnEliminar.Location = New System.Drawing.Point(13, 124)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 48)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDarBaja.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnDarBaja.Location = New System.Drawing.Point(13, 183)
        Me.btnDarBaja.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(160, 48)
        Me.btnDarBaja.TabIndex = 10
        Me.btnDarBaja.Text = "DAR DE BAJA"
        Me.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'dgvAnos
        '
        Me.dgvAnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnos.Location = New System.Drawing.Point(0, 379)
        Me.dgvAnos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvAnos.Name = "dgvAnos"
        Me.dgvAnos.RowHeadersWidth = 51
        Me.dgvAnos.RowTemplate.Height = 24
        Me.dgvAnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnos.Size = New System.Drawing.Size(599, 198)
        Me.dgvAnos.TabIndex = 18
        '
        'frmMantPagoMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(599, 576)
        Me.Controls.Add(Me.dgvAnos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMantPagoMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvAnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Protected WithEvents btnBuscar As Button
    Friend WithEvents chkEstado As CheckBox
    Protected WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Protected WithEvents btnActualizar As Button
    Protected WithEvents btnNuevo As Button
    Protected WithEvents btnLimpiar As Button
    Protected WithEvents btnEliminar As Button
    Protected WithEvents btnDarBaja As Button
    Protected WithEvents dgvAnos As DataGridView
    Friend WithEvents txtNumeroReferencia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtCodigoOperativo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class

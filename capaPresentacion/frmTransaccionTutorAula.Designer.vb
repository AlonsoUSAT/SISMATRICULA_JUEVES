<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaccionTutorAula
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.checkEstado = New System.Windows.Forms.CheckBox()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.cboDocente = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tblAsignacion = New System.Windows.Forms.DataGridView()
        Me.btnAgregarDocente = New System.Windows.Forms.Button()
        Me.btnAgregarSeccion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tblAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 60)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Asignar Tutor a Sección"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnAgregarSeccion)
        Me.Panel2.Controls.Add(Me.btnAgregarDocente)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.checkEstado)
        Me.Panel2.Controls.Add(Me.cboSeccion)
        Me.Panel2.Controls.Add(Me.cboDocente)
        Me.Panel2.Controls.Add(Me.txtCodigo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-1, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 215)
        Me.Panel2.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(235, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 48
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'checkEstado
        '
        Me.checkEstado.AutoSize = True
        Me.checkEstado.Location = New System.Drawing.Point(93, 173)
        Me.checkEstado.Name = "checkEstado"
        Me.checkEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkEstado.TabIndex = 47
        Me.checkEstado.Text = "Estado"
        Me.checkEstado.UseVisualStyleBackColor = True
        '
        'cboSeccion
        '
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(93, 122)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(185, 21)
        Me.cboSeccion.TabIndex = 46
        '
        'cboDocente
        '
        Me.cboDocente.FormattingEnabled = True
        Me.cboDocente.Location = New System.Drawing.Point(93, 71)
        Me.cboDocente.Name = "cboDocente"
        Me.cboDocente.Size = New System.Drawing.Size(185, 21)
        Me.cboDocente.TabIndex = 45
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(93, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(90, 20)
        Me.txtCodigo.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(17, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Vigencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(15, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Docente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Codigo"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnLimpiar)
        Me.Panel3.Controls.Add(Me.btnDarBaja)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnActualizar)
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Location = New System.Drawing.Point(445, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 215)
        Me.Panel3.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(20, 173)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(297, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Location = New System.Drawing.Point(20, 140)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(297, 23)
        Me.btnDarBaja.TabIndex = 3
        Me.btnDarBaja.Text = "Dar Baja"
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(20, 97)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(297, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnActualizar.Location = New System.Drawing.Point(20, 54)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(297, 23)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevo.Location = New System.Drawing.Point(20, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(297, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'tblAsignacion
        '
        Me.tblAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblAsignacion.Location = New System.Drawing.Point(-1, 278)
        Me.tblAsignacion.Name = "tblAsignacion"
        Me.tblAsignacion.Size = New System.Drawing.Size(800, 253)
        Me.tblAsignacion.TabIndex = 6
        '
        'btnAgregarDocente
        '
        Me.btnAgregarDocente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAgregarDocente.Location = New System.Drawing.Point(308, 71)
        Me.btnAgregarDocente.Name = "btnAgregarDocente"
        Me.btnAgregarDocente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarDocente.TabIndex = 49
        Me.btnAgregarDocente.Text = "+"
        Me.btnAgregarDocente.UseVisualStyleBackColor = False
        '
        'btnAgregarSeccion
        '
        Me.btnAgregarSeccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAgregarSeccion.Location = New System.Drawing.Point(308, 119)
        Me.btnAgregarSeccion.Name = "btnAgregarSeccion"
        Me.btnAgregarSeccion.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarSeccion.TabIndex = 50
        Me.btnAgregarSeccion.Text = "+"
        Me.btnAgregarSeccion.UseVisualStyleBackColor = False
        '
        'frmTransaccionTutorAula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.tblAsignacion)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTransaccionTutorAula"
        Me.Text = "frmTransaccionTutorAula"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.tblAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tblAsignacion As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents checkEstado As CheckBox
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents cboDocente As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregarSeccion As Button
    Friend WithEvents btnAgregarDocente As Button
End Class

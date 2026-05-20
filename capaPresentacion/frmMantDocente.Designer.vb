<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantUsuario
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdDocente = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.btnAgregarPersona = New System.Windows.Forms.Button()
        Me.checkEstado = New System.Windows.Forms.CheckBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.tblDocente = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tblDocente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.checkEstado)
        Me.Panel1.Controls.Add(Me.btnAgregarPersona)
        Me.Panel1.Controls.Add(Me.cboPersona)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtEspecialidad)
        Me.Panel1.Controls.Add(Me.txtIdDocente)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 205)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(28, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Especialidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(28, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenimiento de Docente:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnDarBaja)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnActualizar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(333, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 205)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(28, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Persona"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(28, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Estado"
        '
        'txtIdDocente
        '
        Me.txtIdDocente.Location = New System.Drawing.Point(121, 44)
        Me.txtIdDocente.Name = "txtIdDocente"
        Me.txtIdDocente.Size = New System.Drawing.Size(77, 20)
        Me.txtIdDocente.TabIndex = 8
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(121, 79)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(148, 20)
        Me.txtEspecialidad.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(221, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboPersona
        '
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(121, 120)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(125, 21)
        Me.cboPersona.TabIndex = 11
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.Location = New System.Drawing.Point(252, 117)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(47, 23)
        Me.btnAgregarPersona.TabIndex = 12
        Me.btnAgregarPersona.Text = "+"
        Me.btnAgregarPersona.UseVisualStyleBackColor = True
        '
        'checkEstado
        '
        Me.checkEstado.AutoSize = True
        Me.checkEstado.Location = New System.Drawing.Point(121, 163)
        Me.checkEstado.Name = "checkEstado"
        Me.checkEstado.Size = New System.Drawing.Size(59, 17)
        Me.checkEstado.TabIndex = 13
        Me.checkEstado.Text = "Estado"
        Me.checkEstado.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(26, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(262, 21)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(26, 44)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(262, 25)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(26, 79)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(262, 31)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Location = New System.Drawing.Point(26, 120)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(262, 31)
        Me.btnDarBaja.TabIndex = 5
        Me.btnDarBaja.Text = "Dar de Baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(26, 162)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(262, 31)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'tblDocente
        '
        Me.tblDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblDocente.Location = New System.Drawing.Point(16, 213)
        Me.tblDocente.Name = "tblDocente"
        Me.tblDocente.Size = New System.Drawing.Size(628, 171)
        Me.tblDocente.TabIndex = 2
        '
        'frmMantUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 396)
        Me.Controls.Add(Me.tblDocente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMantUsuario"
        Me.Text = "frmMantUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.tblDocente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtIdDocente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents checkEstado As CheckBox
    Friend WithEvents btnAgregarPersona As Button
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tblDocente As DataGridView
End Class

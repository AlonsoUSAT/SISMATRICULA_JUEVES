<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaAsignacion
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDocente = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboHorario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnGuardarAsignacion = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMensajeCruce = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(8, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(213, 16)
        Me.lblTitulo.TabIndex = 34
        Me.lblTitulo.Text = "Nueva asignación académica"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Docente:"
        '
        'cboDocente
        '
        Me.cboDocente.FormattingEnabled = True
        Me.cboDocente.Location = New System.Drawing.Point(26, 59)
        Me.cboDocente.Name = "cboDocente"
        Me.cboDocente.Size = New System.Drawing.Size(313, 21)
        Me.cboDocente.TabIndex = 36
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(26, 118)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(313, 21)
        Me.cboCurso.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Curso:"
        '
        'cboSeccion
        '
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(26, 178)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(313, 21)
        Me.cboSeccion.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Sección:"
        '
        'cboHorario
        '
        Me.cboHorario.FormattingEnabled = True
        Me.cboHorario.Location = New System.Drawing.Point(26, 237)
        Me.cboHorario.Name = "cboHorario"
        Me.cboHorario.Size = New System.Drawing.Size(313, 21)
        Me.cboHorario.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Horario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Estado:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.ForeColor = System.Drawing.Color.Transparent
        Me.chkEstado.Location = New System.Drawing.Point(66, 242)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(56, 17)
        Me.chkEstado.TabIndex = 44
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnGuardarAsignacion
        '
        Me.btnGuardarAsignacion.Location = New System.Drawing.Point(15, 309)
        Me.btnGuardarAsignacion.Name = "btnGuardarAsignacion"
        Me.btnGuardarAsignacion.Size = New System.Drawing.Size(146, 28)
        Me.btnGuardarAsignacion.TabIndex = 45
        Me.btnGuardarAsignacion.Text = "Guardar asignación"
        Me.btnGuardarAsignacion.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(167, 309)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(161, 28)
        Me.btnCancelar.TabIndex = 46
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMensajeCruce)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.chkEstado)
        Me.Panel1.Controls.Add(Me.btnGuardarAsignacion)
        Me.Panel1.Location = New System.Drawing.Point(11, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 357)
        Me.Panel1.TabIndex = 47
        '
        'lblMensajeCruce
        '
        Me.lblMensajeCruce.AutoSize = True
        Me.lblMensajeCruce.ForeColor = System.Drawing.Color.White
        Me.lblMensajeCruce.Location = New System.Drawing.Point(12, 279)
        Me.lblMensajeCruce.Name = "lblMensajeCruce"
        Me.lblMensajeCruce.Size = New System.Drawing.Size(0, 13)
        Me.lblMensajeCruce.TabIndex = 47
        '
        'frmNuevaAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 399)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboHorario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSeccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDocente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmNuevaAsignacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNuevaAsignación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboDocente As ComboBox
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboHorario As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnGuardarAsignacion As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMensajeCruce As Label
End Class

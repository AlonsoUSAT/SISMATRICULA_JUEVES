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
        Me.cboFiltroDocente = New System.Windows.Forms.ComboBox()
        Me.cboFiltroSeccion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFiltroHorario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNuevaAsignacion = New System.Windows.Forms.Button()
        Me.dgvCargaAcademica = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1521, 68)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestión de carga académica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 26)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Docente:"
        '
        'cboFiltroDocente
        '
        Me.cboFiltroDocente.FormattingEnabled = True
        Me.cboFiltroDocente.Location = New System.Drawing.Point(140, 94)
        Me.cboFiltroDocente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFiltroDocente.Name = "cboFiltroDocente"
        Me.cboFiltroDocente.Size = New System.Drawing.Size(311, 24)
        Me.cboFiltroDocente.TabIndex = 37
        '
        'cboFiltroSeccion
        '
        Me.cboFiltroSeccion.FormattingEnabled = True
        Me.cboFiltroSeccion.Location = New System.Drawing.Point(604, 97)
        Me.cboFiltroSeccion.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFiltroSeccion.Name = "cboFiltroSeccion"
        Me.cboFiltroSeccion.Size = New System.Drawing.Size(311, 24)
        Me.cboFiltroSeccion.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(493, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Sección:"
        '
        'cboFiltroHorario
        '
        Me.cboFiltroHorario.FormattingEnabled = True
        Me.cboFiltroHorario.Location = New System.Drawing.Point(1093, 101)
        Me.cboFiltroHorario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFiltroHorario.Name = "cboFiltroHorario"
        Me.cboFiltroHorario.Size = New System.Drawing.Size(311, 24)
        Me.cboFiltroHorario.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(983, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 26)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Horario:"
        '
        'btnNuevaAsignacion
        '
        Me.btnNuevaAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaAsignacion.Location = New System.Drawing.Point(519, 154)
        Me.btnNuevaAsignacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevaAsignacion.Name = "btnNuevaAsignacion"
        Me.btnNuevaAsignacion.Size = New System.Drawing.Size(441, 44)
        Me.btnNuevaAsignacion.TabIndex = 42
        Me.btnNuevaAsignacion.Text = "NUEVA ASIGNACIÓN"
        Me.btnNuevaAsignacion.UseVisualStyleBackColor = True
        '
        'dgvCargaAcademica
        '
        Me.dgvCargaAcademica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaAcademica.Location = New System.Drawing.Point(22, 243)
        Me.dgvCargaAcademica.Name = "dgvCargaAcademica"
        Me.dgvCargaAcademica.RowHeadersWidth = 51
        Me.dgvCargaAcademica.RowTemplate.Height = 24
        Me.dgvCargaAcademica.Size = New System.Drawing.Size(1312, 325)
        Me.dgvCargaAcademica.TabIndex = 43
        '
        'frmCargaAcademica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1501, 751)
        Me.Controls.Add(Me.dgvCargaAcademica)
        Me.Controls.Add(Me.btnNuevaAsignacion)
        Me.Controls.Add(Me.cboFiltroHorario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboFiltroSeccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFiltroDocente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCargaAcademica"
        Me.Text = "frmCargaAcademica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
	Friend WithEvents cboFiltroDocente As ComboBox
	Friend WithEvents cboFiltroSeccion As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents cboFiltroHorario As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnNuevaAsignacion As Button
    Friend WithEvents dgvCargaAcademica As DataGridView
End Class

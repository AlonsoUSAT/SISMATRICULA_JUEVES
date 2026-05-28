<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectorAnio
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnoActivo = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cboAnios = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 61)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(50, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de gestión académica"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selecciona el año académico con el que vas a trabajar"
        '
        'lblAnoActivo
        '
        Me.lblAnoActivo.AutoSize = True
        Me.lblAnoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoActivo.Location = New System.Drawing.Point(52, 128)
        Me.lblAnoActivo.Name = "lblAnoActivo"
        Me.lblAnoActivo.Size = New System.Drawing.Size(68, 15)
        Me.lblAnoActivo.TabIndex = 2
        Me.lblAnoActivo.Text = "Año activo: "
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(108, 278)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(127, 35)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar al sistema"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cboAnios
        '
        Me.cboAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnios.FormattingEnabled = True
        Me.cboAnios.IntegralHeight = False
        Me.cboAnios.Location = New System.Drawing.Point(49, 185)
        Me.cboAnios.Name = "cboAnios"
        Me.cboAnios.Size = New System.Drawing.Size(250, 21)
        Me.cboAnios.TabIndex = 4
        '
        'frmSelectorAnio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 361)
        Me.Controls.Add(Me.cboAnios)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lblAnoActivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSelectorAnio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAnoActivo As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents cboAnios As ComboBox
End Class

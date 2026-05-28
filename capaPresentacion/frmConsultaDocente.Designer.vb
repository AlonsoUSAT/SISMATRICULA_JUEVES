<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDocente
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
        Me.tblBusqueda = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboAno = New System.Windows.Forms.ComboBox()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDniDocente = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.tblBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(41, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consultar Docente por nivel, sección y grado "
        '
        'tblBusqueda
        '
        Me.tblBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblBusqueda.Location = New System.Drawing.Point(350, 81)
        Me.tblBusqueda.Name = "tblBusqueda"
        Me.tblBusqueda.Size = New System.Drawing.Size(598, 441)
        Me.tblBusqueda.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cboAno)
        Me.Panel2.Controls.Add(Me.cboSeccion)
        Me.Panel2.Controls.Add(Me.cboGrado)
        Me.Panel2.Controls.Add(Me.cboNivel)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.txtDniDocente)
        Me.Panel2.Controls.Add(Me.lblCantidad)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-3, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 441)
        Me.Panel2.TabIndex = 3
        '
        'cboAno
        '
        Me.cboAno.FormattingEnabled = True
        Me.cboAno.Location = New System.Drawing.Point(140, 273)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Size = New System.Drawing.Size(194, 21)
        Me.cboAno.TabIndex = 62
        '
        'cboSeccion
        '
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(140, 207)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(194, 21)
        Me.cboSeccion.TabIndex = 61
        '
        'cboGrado
        '
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Location = New System.Drawing.Point(140, 147)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(194, 21)
        Me.cboGrado.TabIndex = 60
        '
        'cboNivel
        '
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(140, 75)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(194, 21)
        Me.cboNivel.TabIndex = 59
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnBuscar.Location = New System.Drawing.Point(88, 376)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(160, 48)
        Me.btnBuscar.TabIndex = 58
        Me.btnBuscar.Text = "CONSULTAR"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtDniDocente
        '
        Me.txtDniDocente.Location = New System.Drawing.Point(140, 23)
        Me.txtDniDocente.Name = "txtDniDocente"
        Me.txtDniDocente.Size = New System.Drawing.Size(194, 20)
        Me.txtDniDocente.TabIndex = 7
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(137, 348)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "???"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Grado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nivel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI del Docente"
        '
        'frmConsultaDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 517)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tblBusqueda)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmConsultaDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tblBusqueda As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDniDocente As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboAno As ComboBox
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents cboNivel As ComboBox
    Friend WithEvents btnBuscar As Button
End Class

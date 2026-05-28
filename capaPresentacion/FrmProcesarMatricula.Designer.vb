<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProcesarMatricula
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnProcesarMatricula = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvCronograma = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDctoPensiones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNivelGradoSeccion = New System.Windows.Forms.TextBox()
        Me.txtBecaActiva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMontoPagado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodOperativo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaPago = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApoderado = New System.Windows.Forms.TextBox()
        Me.txtEstudiante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(1, 14)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1535, 68)
        Me.Panel3.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Snow
        Me.Label13.Location = New System.Drawing.Point(29, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(596, 31)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "PROCESAR MATRÍCULA Y CRONOGRAMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1535, 661)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.btnProcesarMatricula)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(829, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 638)
        Me.Panel2.TabIndex = 38
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.Image = Global.capaPresentacion.My.Resources.Resources.borrador
        Me.btnImprimir.Location = New System.Drawing.Point(505, 558)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(160, 59)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Image = Global.capaPresentacion.My.Resources.Resources.borrador
        Me.btnLimpiar.Location = New System.Drawing.Point(285, 558)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(214, 59)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObservaciones)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(19, 373)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(662, 166)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(18, 28)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(628, 124)
        Me.txtObservaciones.TabIndex = 0
        '
        'btnProcesarMatricula
        '
        Me.btnProcesarMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnProcesarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnProcesarMatricula.Location = New System.Drawing.Point(19, 558)
        Me.btnProcesarMatricula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcesarMatricula.Name = "btnProcesarMatricula"
        Me.btnProcesarMatricula.Size = New System.Drawing.Size(260, 59)
        Me.btnProcesarMatricula.TabIndex = 11
        Me.btnProcesarMatricula.Text = "PROCESAR MATRÍCULA"
        Me.btnProcesarMatricula.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvCronograma)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(19, 15)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(662, 354)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proyección de cronograma de pago generado"
        '
        'dgvCronograma
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCronograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCronograma.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCronograma.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCronograma.Location = New System.Drawing.Point(18, 36)
        Me.dgvCronograma.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCronograma.Name = "dgvCronograma"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCronograma.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCronograma.RowHeadersWidth = 51
        Me.dgvCronograma.RowTemplate.Height = 24
        Me.dgvCronograma.Size = New System.Drawing.Size(628, 305)
        Me.dgvCronograma.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtDctoPensiones)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtNivelGradoSeccion)
        Me.GroupBox3.Controls.Add(Me.txtBecaActiva)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(20, 446)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(721, 130)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Condiciones del estudiante"
        '
        'txtDctoPensiones
        '
        Me.txtDctoPensiones.Location = New System.Drawing.Point(581, 37)
        Me.txtDctoPensiones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDctoPensiones.Name = "txtDctoPensiones"
        Me.txtDctoPensiones.Size = New System.Drawing.Size(115, 30)
        Me.txtDctoPensiones.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(438, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Dcto Pensiones:"
        '
        'txtNivelGradoSeccion
        '
        Me.txtNivelGradoSeccion.Location = New System.Drawing.Point(231, 85)
        Me.txtNivelGradoSeccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNivelGradoSeccion.Name = "txtNivelGradoSeccion"
        Me.txtNivelGradoSeccion.Size = New System.Drawing.Size(465, 30)
        Me.txtNivelGradoSeccion.TabIndex = 16
        '
        'txtBecaActiva
        '
        Me.txtBecaActiva.Location = New System.Drawing.Point(231, 39)
        Me.txtBecaActiva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBecaActiva.Name = "txtBecaActiva"
        Me.txtBecaActiva.Size = New System.Drawing.Size(189, 30)
        Me.txtBecaActiva.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nivel / Grado / Sección:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Beca Activa:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMontoPagado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCodOperativo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFechaPago)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtApoderado)
        Me.GroupBox2.Controls.Add(Me.txtEstudiante)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(20, 158)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(721, 290)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(231, 254)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(285, 30)
        Me.txtEstado.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Estado:"
        '
        'txtMontoPagado
        '
        Me.txtMontoPagado.Location = New System.Drawing.Point(231, 208)
        Me.txtMontoPagado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMontoPagado.Name = "txtMontoPagado"
        Me.txtMontoPagado.Size = New System.Drawing.Size(285, 30)
        Me.txtMontoPagado.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Monto Pagado:"
        '
        'txtCodOperativo
        '
        Me.txtCodOperativo.Location = New System.Drawing.Point(231, 154)
        Me.txtCodOperativo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodOperativo.Name = "txtCodOperativo"
        Me.txtCodOperativo.Size = New System.Drawing.Size(285, 30)
        Me.txtCodOperativo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cod. Operativo (Voucher):"
        '
        'txtFechaPago
        '
        Me.txtFechaPago.Location = New System.Drawing.Point(231, 112)
        Me.txtFechaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.Size = New System.Drawing.Size(285, 30)
        Me.txtFechaPago.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha de pago:"
        '
        'txtApoderado
        '
        Me.txtApoderado.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtApoderado.ForeColor = System.Drawing.Color.Black
        Me.txtApoderado.Location = New System.Drawing.Point(113, 66)
        Me.txtApoderado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApoderado.Name = "txtApoderado"
        Me.txtApoderado.Size = New System.Drawing.Size(583, 31)
        Me.txtApoderado.TabIndex = 8
        '
        'txtEstudiante
        '
        Me.txtEstudiante.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtEstudiante.ForeColor = System.Drawing.Color.Black
        Me.txtEstudiante.Location = New System.Drawing.Point(113, 30)
        Me.txtEstudiante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstudiante.Name = "txtEstudiante"
        Me.txtEstudiante.Size = New System.Drawing.Size(583, 31)
        Me.txtEstudiante.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Apoderado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estudiante:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtNro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbTipoBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(20, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de pago:"
        '
        'txtNro
        '
        Me.txtNro.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtNro.ForeColor = System.Drawing.Color.Black
        Me.txtNro.Location = New System.Drawing.Point(179, 82)
        Me.txtNro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(183, 31)
        Me.txtNro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnBuscar.Location = New System.Drawing.Point(396, 33)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(148, 43)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbTipoBusqueda
        '
        Me.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBusqueda.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cmbTipoBusqueda.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoBusqueda.FormattingEnabled = True
        Me.cmbTipoBusqueda.Location = New System.Drawing.Point(179, 37)
        Me.cmbTipoBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTipoBusqueda.Name = "cmbTipoBusqueda"
        Me.cmbTipoBusqueda.Size = New System.Drawing.Size(183, 33)
        Me.cmbTipoBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de búsqueda:"
        '
        'frmProcesarMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1540, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmProcesarMatricula"
        Me.Text = "FrmProcesarMatricula"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTipoBusqueda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCodOperativo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaPago As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApoderado As TextBox
    Friend WithEvents txtEstudiante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNivelGradoSeccion As TextBox
    Friend WithEvents txtBecaActiva As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMontoPagado As TextBox
    Friend WithEvents btnProcesarMatricula As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvCronograma As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDctoPensiones As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnImprimir As Button
End Class

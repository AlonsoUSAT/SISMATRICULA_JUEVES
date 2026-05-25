<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TranMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TranMatricula))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFechaPago = New System.Windows.Forms.TextBox()
        Me.txtRefBancaria = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCodOperativo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVacante = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarEstudiante = New System.Windows.Forms.Button()
        Me.txtApoderado = New System.Windows.Forms.TextBox()
        Me.txtEstudiante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscarEstudiante = New System.Windows.Forms.Button()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvCronograma = New System.Windows.Forms.DataGridView()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDeuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnProcesarMatricula = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleName = "dfs"
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(-1, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1331, 683)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFechaPago)
        Me.GroupBox3.Controls.Add(Me.txtRefBancaria)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.txtCodOperativo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(22, 447)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(686, 218)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registrar matricula"
        '
        'txtFechaPago
        '
        Me.txtFechaPago.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtFechaPago.ForeColor = System.Drawing.Color.Black
        Me.txtFechaPago.Location = New System.Drawing.Point(261, 33)
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.Size = New System.Drawing.Size(220, 31)
        Me.txtFechaPago.TabIndex = 8
        '
        'txtRefBancaria
        '
        Me.txtRefBancaria.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtRefBancaria.ForeColor = System.Drawing.Color.Black
        Me.txtRefBancaria.Location = New System.Drawing.Point(261, 166)
        Me.txtRefBancaria.Name = "txtRefBancaria"
        Me.txtRefBancaria.Size = New System.Drawing.Size(220, 31)
        Me.txtRefBancaria.TabIndex = 7
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtMonto.ForeColor = System.Drawing.Color.Black
        Me.txtMonto.Location = New System.Drawing.Point(261, 119)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(220, 31)
        Me.txtMonto.TabIndex = 6
        '
        'txtCodOperativo
        '
        Me.txtCodOperativo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtCodOperativo.ForeColor = System.Drawing.Color.Black
        Me.txtCodOperativo.Location = New System.Drawing.Point(261, 75)
        Me.txtCodOperativo.Name = "txtCodOperativo"
        Me.txtCodOperativo.Size = New System.Drawing.Size(220, 31)
        Me.txtCodOperativo.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Ref. Bancaria:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Monto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cod. Operativo (Voucher):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(19, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVacante)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboSeccion)
        Me.GroupBox2.Controls.Add(Me.cboGrado)
        Me.GroupBox2.Controls.Add(Me.cboNivel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(13, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 213)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Asignación y control de vacante"
        '
        'txtVacante
        '
        Me.txtVacante.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtVacante.ForeColor = System.Drawing.Color.Black
        Me.txtVacante.Location = New System.Drawing.Point(331, 97)
        Me.txtVacante.Name = "txtVacante"
        Me.txtVacante.Size = New System.Drawing.Size(219, 31)
        Me.txtVacante.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(326, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Estado de Vacantes:"
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboSeccion.ForeColor = System.Drawing.Color.Black
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(125, 145)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(177, 33)
        Me.cboSeccion.TabIndex = 5
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboGrado.ForeColor = System.Drawing.Color.Black
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Location = New System.Drawing.Point(125, 95)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(177, 33)
        Me.cboGrado.TabIndex = 4
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboNivel.ForeColor = System.Drawing.Color.Black
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(125, 50)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(177, 33)
        Me.cboNivel.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(24, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Grado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nivel:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnAgregarEstudiante)
        Me.GroupBox1.Controls.Add(Me.txtApoderado)
        Me.GroupBox1.Controls.Add(Me.txtEstudiante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarEstudiante)
        Me.GroupBox1.Controls.Add(Me.TxtDNI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(13, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del estudiante"
        '
        'btnAgregarEstudiante
        '
        Me.btnAgregarEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAgregarEstudiante.Image = Global.capaPresentacion.My.Resources.Resources.agregar_usuario
        Me.btnAgregarEstudiante.Location = New System.Drawing.Point(609, 26)
        Me.btnAgregarEstudiante.Name = "btnAgregarEstudiante"
        Me.btnAgregarEstudiante.Size = New System.Drawing.Size(63, 47)
        Me.btnAgregarEstudiante.TabIndex = 9
        Me.btnAgregarEstudiante.UseVisualStyleBackColor = False
        '
        'txtApoderado
        '
        Me.txtApoderado.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtApoderado.ForeColor = System.Drawing.Color.Black
        Me.txtApoderado.Location = New System.Drawing.Point(125, 115)
        Me.txtApoderado.Name = "txtApoderado"
        Me.txtApoderado.Size = New System.Drawing.Size(547, 31)
        Me.txtApoderado.TabIndex = 8
        '
        'txtEstudiante
        '
        Me.txtEstudiante.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtEstudiante.ForeColor = System.Drawing.Color.Black
        Me.txtEstudiante.Location = New System.Drawing.Point(125, 78)
        Me.txtEstudiante.Name = "txtEstudiante"
        Me.txtEstudiante.Size = New System.Drawing.Size(547, 31)
        Me.txtEstudiante.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apoderado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estudiante"
        '
        'BtnBuscarEstudiante
        '
        Me.BtnBuscarEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BtnBuscarEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscarEstudiante.ForeColor = System.Drawing.Color.Black
        Me.BtnBuscarEstudiante.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.BtnBuscarEstudiante.Location = New System.Drawing.Point(457, 29)
        Me.BtnBuscarEstudiante.Name = "BtnBuscarEstudiante"
        Me.BtnBuscarEstudiante.Size = New System.Drawing.Size(148, 43)
        Me.BtnBuscarEstudiante.TabIndex = 4
        Me.BtnBuscarEstudiante.Text = "BUSCAR"
        Me.BtnBuscarEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBuscarEstudiante.UseVisualStyleBackColor = False
        '
        'TxtDNI
        '
        Me.TxtDNI.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.TxtDNI.ForeColor = System.Drawing.Color.Black
        Me.TxtDNI.Location = New System.Drawing.Point(304, 34)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(138, 31)
        Me.TxtDNI.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(256, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(125, 34)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(125, 33)
        Me.cboTipoDocumento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.dgvCronograma)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(573, 396)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proyección de Deudas (Cronograma de Pagos)"
        '
        'dgvCronograma
        '
        Me.dgvCronograma.AllowUserToAddRows = False
        Me.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCronograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColVencimiento, Me.ColDeuda, Me.ColEstado})
        Me.dgvCronograma.Location = New System.Drawing.Point(6, 32)
        Me.dgvCronograma.Name = "dgvCronograma"
        Me.dgvCronograma.ReadOnly = True
        Me.dgvCronograma.RowHeadersWidth = 51
        Me.dgvCronograma.RowTemplate.Height = 24
        Me.dgvCronograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCronograma.Size = New System.Drawing.Size(561, 350)
        Me.dgvCronograma.TabIndex = 0
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.MinimumWidth = 6
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.ReadOnly = True
        Me.ColConcepto.Visible = False
        Me.ColConcepto.Width = 125
        '
        'ColVencimiento
        '
        Me.ColVencimiento.HeaderText = "Vencimiento"
        Me.ColVencimiento.MinimumWidth = 6
        Me.ColVencimiento.Name = "ColVencimiento"
        Me.ColVencimiento.ReadOnly = True
        Me.ColVencimiento.Visible = False
        Me.ColVencimiento.Width = 125
        '
        'ColDeuda
        '
        Me.ColDeuda.HeaderText = "Deuda Estimada"
        Me.ColDeuda.MinimumWidth = 6
        Me.ColDeuda.Name = "ColDeuda"
        Me.ColDeuda.ReadOnly = True
        Me.ColDeuda.Visible = False
        Me.ColDeuda.Width = 125
        '
        'ColEstado
        '
        Me.ColEstado.HeaderText = "Estado Inicial"
        Me.ColEstado.MinimumWidth = 6
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.ReadOnly = True
        Me.ColEstado.Visible = False
        Me.ColEstado.Width = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.btnProcesarMatricula)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(735, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 663)
        Me.Panel2.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Image = Global.capaPresentacion.My.Resources.Resources.borrador
        Me.btnLimpiar.Location = New System.Drawing.Point(318, 567)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(214, 59)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObservacion)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(12, 422)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(573, 130)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(7, 22)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(560, 96)
        Me.txtObservacion.TabIndex = 0
        '
        'btnProcesarMatricula
        '
        Me.btnProcesarMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnProcesarMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnProcesarMatricula.Location = New System.Drawing.Point(82, 567)
        Me.btnProcesarMatricula.Name = "btnProcesarMatricula"
        Me.btnProcesarMatricula.Size = New System.Drawing.Size(214, 59)
        Me.btnProcesarMatricula.TabIndex = 2
        Me.btnProcesarMatricula.Text = "PROCESAR MATRICULA"
        Me.btnProcesarMatricula.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(-1, 7)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1331, 68)
        Me.Panel3.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Snow
        Me.Label13.Location = New System.Drawing.Point(29, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(261, 31)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Registrar Matricula"
        '
        'TranMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TranMatricula"
        Me.Text = "Registrar Matricula"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarEstudiante As Button
    Friend WithEvents txtApoderado As TextBox
    Friend WithEvents txtEstudiante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscarEstudiante As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents cboNivel As ComboBox
    Friend WithEvents txtVacante As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtCodOperativo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRefBancaria As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvCronograma As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColDeuda As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewTextBoxColumn
    Friend WithEvents txtFechaPago As TextBox
    Friend WithEvents btnProcesarMatricula As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLimpiar As Button
End Class

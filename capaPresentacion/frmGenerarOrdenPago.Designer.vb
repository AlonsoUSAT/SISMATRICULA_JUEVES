<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerarOrdenPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerarOrdenPago))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTipoBeca = New System.Windows.Forms.TextBox()
        Me.txtDescuentoAplicable = New System.Windows.Forms.TextBox()
        Me.chkEstadoBeca = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAnoAcademico = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEstadoVacantes = New System.Windows.Forms.TextBox()
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGenerarOrden = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.txtMontoDescuento = New System.Windows.Forms.TextBox()
        Me.txtMontoRegular = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.GroupBox3.Controls.Add(Me.txtTipoBeca)
        Me.GroupBox3.Controls.Add(Me.txtDescuentoAplicable)
        Me.GroupBox3.Controls.Add(Me.chkEstadoBeca)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(13, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(686, 213)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Verificación de becas"
        '
        'txtTipoBeca
        '
        Me.txtTipoBeca.Location = New System.Drawing.Point(207, 100)
        Me.txtTipoBeca.Name = "txtTipoBeca"
        Me.txtTipoBeca.Size = New System.Drawing.Size(465, 30)
        Me.txtTipoBeca.TabIndex = 11
        '
        'txtDescuentoAplicable
        '
        Me.txtDescuentoAplicable.Location = New System.Drawing.Point(207, 145)
        Me.txtDescuentoAplicable.Name = "txtDescuentoAplicable"
        Me.txtDescuentoAplicable.Size = New System.Drawing.Size(465, 30)
        Me.txtDescuentoAplicable.TabIndex = 9
        '
        'chkEstadoBeca
        '
        Me.chkEstadoBeca.AutoSize = True
        Me.chkEstadoBeca.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.chkEstadoBeca.ForeColor = System.Drawing.Color.Black
        Me.chkEstadoBeca.Location = New System.Drawing.Point(207, 50)
        Me.chkEstadoBeca.Name = "chkEstadoBeca"
        Me.chkEstadoBeca.Size = New System.Drawing.Size(82, 29)
        Me.chkEstadoBeca.TabIndex = 8
        Me.chkEstadoBeca.Text = "Activa"
        Me.chkEstadoBeca.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(24, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Descuento Aplicable:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Tipo de beca:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Estado de beca"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAnoAcademico)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtEstadoVacantes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboSeccion)
        Me.GroupBox2.Controls.Add(Me.cboGrado)
        Me.GroupBox2.Controls.Add(Me.cboNivel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(13, 423)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 213)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Asignación de vacante"
        '
        'txtAnoAcademico
        '
        Me.txtAnoAcademico.Location = New System.Drawing.Point(471, 50)
        Me.txtAnoAcademico.Name = "txtAnoAcademico"
        Me.txtAnoAcademico.Size = New System.Drawing.Size(201, 30)
        Me.txtAnoAcademico.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(326, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Año académico:"
        '
        'txtEstadoVacantes
        '
        Me.txtEstadoVacantes.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtEstadoVacantes.ForeColor = System.Drawing.Color.Black
        Me.txtEstadoVacantes.Location = New System.Drawing.Point(331, 145)
        Me.txtEstadoVacantes.Name = "txtEstadoVacantes"
        Me.txtEstadoVacantes.Size = New System.Drawing.Size(341, 31)
        Me.txtEstadoVacantes.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(326, 103)
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
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNumDoc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTipo)
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
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnBuscar.Location = New System.Drawing.Point(457, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(148, 43)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.txtNumDoc.ForeColor = System.Drawing.Color.Black
        Me.txtNumDoc.Location = New System.Drawing.Point(304, 34)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(138, 31)
        Me.txtNumDoc.TabIndex = 3
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
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cboTipo.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(125, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(125, 33)
        Me.cboTipo.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnGenerarOrden)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(353, 296)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(214, 59)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGenerarOrden
        '
        Me.btnGenerarOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGenerarOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnGenerarOrden.Location = New System.Drawing.Point(22, 296)
        Me.btnGenerarOrden.Name = "btnGenerarOrden"
        Me.btnGenerarOrden.Size = New System.Drawing.Size(312, 59)
        Me.btnGenerarOrden.TabIndex = 2
        Me.btnGenerarOrden.Text = "GENERAR ORDEN DE PAGO"
        Me.btnGenerarOrden.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox4.Controls.Add(Me.txtMontoDescuento)
        Me.GroupBox4.Controls.Add(Me.txtMontoRegular)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(573, 261)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen de la operación"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(276, 189)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(266, 30)
        Me.txtTotalPagar.TabIndex = 5
        '
        'txtMontoDescuento
        '
        Me.txtMontoDescuento.Location = New System.Drawing.Point(276, 122)
        Me.txtMontoDescuento.Name = "txtMontoDescuento"
        Me.txtMontoDescuento.Size = New System.Drawing.Size(266, 30)
        Me.txtMontoDescuento.TabIndex = 4
        '
        'txtMontoRegular
        '
        Me.txtMontoRegular.Location = New System.Drawing.Point(276, 60)
        Me.txtMontoRegular.Name = "txtMontoRegular"
        Me.txtMontoRegular.Size = New System.Drawing.Size(266, 30)
        Me.txtMontoRegular.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 25)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Total a pagar:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 25)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Descuento Beca"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(229, 25)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Monto Matrícula Regular:"
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
        Me.Label13.Size = New System.Drawing.Size(406, 31)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "GENERAR ORDEN DE PAGO"
        '
        'frmGenerarOrdenPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGenerarOrdenPago"
        Me.Text = "SISTEMA"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarEstudiante As Button
    Friend WithEvents txtApoderado As TextBox
    Friend WithEvents txtEstudiante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents cboGrado As ComboBox
    Friend WithEvents cboNivel As ComboBox
    Friend WithEvents txtEstadoVacantes As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGenerarOrden As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkEstadoBeca As CheckBox
    Friend WithEvents txtDescuentoAplicable As TextBox
    Friend WithEvents txtAnoAcademico As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents txtMontoDescuento As TextBox
    Friend WithEvents txtMontoRegular As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTipoBeca As TextBox
End Class

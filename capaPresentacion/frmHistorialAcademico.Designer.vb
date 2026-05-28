<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHistorialAcademico
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    ' ── Declaración de controles ──────────────────────────────
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents lblNombreHeader As System.Windows.Forms.Label

    Friend WithEvents pnlBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button

    Friend WithEvents pnlResumen As System.Windows.Forms.Panel
    Friend WithEvents lblResumenLabel As System.Windows.Forms.Label
    Friend WithEvents lblResumen As System.Windows.Forms.Label

    Friend WithEvents pnlDatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents lblNomCom As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lblDNIDisp As System.Windows.Forms.Label
    Friend WithEvents txtDNIDisplay As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoEst As System.Windows.Forms.Label
    Friend WithEvents txtTipoEstudiante As System.Windows.Forms.TextBox
    Friend WithEvents lblTelf As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox

    Friend WithEvents lblSepApoderado As System.Windows.Forms.Label
    Friend WithEvents lblNomApo As System.Windows.Forms.Label
    Friend WithEvents txtNombreApoderado As System.Windows.Forms.TextBox
    Friend WithEvents lblTelfApo As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoApoderado As System.Windows.Forms.TextBox
    Friend WithEvents lblDNIApo As System.Windows.Forms.Label
    Friend WithEvents txtDniApoderado As System.Windows.Forms.TextBox

    Friend WithEvents tabControlFicha As System.Windows.Forms.TabControl
    Friend WithEvents tabMatriculas As System.Windows.Forms.TabPage
    Friend WithEvents tabCursos As System.Windows.Forms.TabPage
    Friend WithEvents tabBecas As System.Windows.Forms.TabPage

    Friend WithEvents lblTotalMatriculas As System.Windows.Forms.Label
    Friend WithEvents dgvMatriculas As System.Windows.Forms.DataGridView

    Friend WithEvents lblAnoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents btnCargarCursos As System.Windows.Forms.Button
    Friend WithEvents dgvCursos As System.Windows.Forms.DataGridView

    Friend WithEvents lblTotalBecas As System.Windows.Forms.Label
    Friend WithEvents dgvBecas As System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.lblNombreHeader = New System.Windows.Forms.Label()
        Me.pnlBusqueda = New System.Windows.Forms.GroupBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlResumen = New System.Windows.Forms.Panel()
        Me.lblResumenLabel = New System.Windows.Forms.Label()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.pnlDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.lblNomCom = New System.Windows.Forms.Label()
        Me.lblDNIDisp = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblTipoEst = New System.Windows.Forms.Label()
        Me.lblTelf = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtDNIDisplay = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtTipoEstudiante = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblSepApoderado = New System.Windows.Forms.Label()
        Me.lblNomApo = New System.Windows.Forms.Label()
        Me.txtNombreApoderado = New System.Windows.Forms.TextBox()
        Me.lblTelfApo = New System.Windows.Forms.Label()
        Me.txtTelefonoApoderado = New System.Windows.Forms.TextBox()
        Me.lblDNIApo = New System.Windows.Forms.Label()
        Me.txtDniApoderado = New System.Windows.Forms.TextBox()
        Me.tabControlFicha = New System.Windows.Forms.TabControl()
        Me.tabMatriculas = New System.Windows.Forms.TabPage()
        Me.lblTotalMatriculas = New System.Windows.Forms.Label()
        Me.dgvMatriculas = New System.Windows.Forms.DataGridView()
        Me.tabCursos = New System.Windows.Forms.TabPage()
        Me.lblAnoSeleccionado = New System.Windows.Forms.Label()
        Me.btnCargarCursos = New System.Windows.Forms.Button()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.tabBecas = New System.Windows.Forms.TabPage()
        Me.lblTotalBecas = New System.Windows.Forms.Label()
        Me.dgvBecas = New System.Windows.Forms.DataGridView()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        Me.pnlResumen.SuspendLayout()
        Me.pnlDatosPersonales.SuspendLayout()
        Me.tabControlFicha.SuspendLayout()
        Me.tabMatriculas.SuspendLayout()
        CType(Me.dgvMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCursos.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBecas.SuspendLayout()
        CType(Me.dgvBecas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.Firebrick
        Me.pnlEncabezado.Controls.Add(Me.lblTituloForm)
        Me.pnlEncabezado.Controls.Add(Me.lblNombreHeader)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(1262, 64)
        Me.pnlEncabezado.TabIndex = 4
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.White
        Me.lblTituloForm.Location = New System.Drawing.Point(12, 16)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(473, 37)
        Me.lblTituloForm.TabIndex = 0
        Me.lblTituloForm.Text = "FICHA HISTÓRICA DEL ESTUDIANTE"
        '
        'lblNombreHeader
        '
        Me.lblNombreHeader.AutoSize = True
        Me.lblNombreHeader.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblNombreHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblNombreHeader.Location = New System.Drawing.Point(700, 22)
        Me.lblNombreHeader.Name = "lblNombreHeader"
        Me.lblNombreHeader.Size = New System.Drawing.Size(168, 23)
        Me.lblNombreHeader.TabIndex = 1
        Me.lblNombreHeader.Text = "Ficha del Estudiante"
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.BackColor = System.Drawing.Color.White
        Me.pnlBusqueda.Controls.Add(Me.lblDNI)
        Me.pnlBusqueda.Controls.Add(Me.txtDNI)
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Controls.Add(Me.btnLimpiar)
        Me.pnlBusqueda.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.pnlBusqueda.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlBusqueda.Location = New System.Drawing.Point(0, 81)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(1240, 92)
        Me.pnlBusqueda.TabIndex = 3
        Me.pnlBusqueda.TabStop = False
        Me.pnlBusqueda.Text = "Búsqueda por DNI "
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDNI.Location = New System.Drawing.Point(14, 30)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(163, 25)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "DNI del Estudiante:"
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDNI.Location = New System.Drawing.Point(203, 25)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(195, 32)
        Me.txtDNI.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(421, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(142, 43)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(581, 23)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(142, 43)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlResumen
        '
        Me.pnlResumen.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlResumen.Controls.Add(Me.lblResumenLabel)
        Me.pnlResumen.Controls.Add(Me.lblResumen)
        Me.pnlResumen.Location = New System.Drawing.Point(0, 168)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(1240, 32)
        Me.pnlResumen.TabIndex = 2
        '
        'lblResumenLabel
        '
        Me.lblResumenLabel.AutoSize = True
        Me.lblResumenLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblResumenLabel.Location = New System.Drawing.Point(8, 8)
        Me.lblResumenLabel.Name = "lblResumenLabel"
        Me.lblResumenLabel.Size = New System.Drawing.Size(78, 20)
        Me.lblResumenLabel.TabIndex = 0
        Me.lblResumenLabel.Text = "Resumen:"
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblResumen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblResumen.Location = New System.Drawing.Point(80, 8)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(253, 20)
        Me.lblResumen.TabIndex = 1
        Me.lblResumen.Text = "—  Busque un estudiante por DNI  —"
        '
        'pnlDatosPersonales
        '
        Me.pnlDatosPersonales.BackColor = System.Drawing.Color.White
        Me.pnlDatosPersonales.Controls.Add(Me.lblNomCom)
        Me.pnlDatosPersonales.Controls.Add(Me.lblDNIDisp)
        Me.pnlDatosPersonales.Controls.Add(Me.lblSexo)
        Me.pnlDatosPersonales.Controls.Add(Me.lblTipoEst)
        Me.pnlDatosPersonales.Controls.Add(Me.lblTelf)
        Me.pnlDatosPersonales.Controls.Add(Me.lblCorreo)
        Me.pnlDatosPersonales.Controls.Add(Me.txtNombreCompleto)
        Me.pnlDatosPersonales.Controls.Add(Me.txtDNIDisplay)
        Me.pnlDatosPersonales.Controls.Add(Me.txtSexo)
        Me.pnlDatosPersonales.Controls.Add(Me.txtTipoEstudiante)
        Me.pnlDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.pnlDatosPersonales.Controls.Add(Me.txtCorreo)
        Me.pnlDatosPersonales.Controls.Add(Me.lblSepApoderado)
        Me.pnlDatosPersonales.Controls.Add(Me.lblNomApo)
        Me.pnlDatosPersonales.Controls.Add(Me.txtNombreApoderado)
        Me.pnlDatosPersonales.Controls.Add(Me.lblTelfApo)
        Me.pnlDatosPersonales.Controls.Add(Me.txtTelefonoApoderado)
        Me.pnlDatosPersonales.Controls.Add(Me.lblDNIApo)
        Me.pnlDatosPersonales.Controls.Add(Me.txtDniApoderado)
        Me.pnlDatosPersonales.Enabled = False
        Me.pnlDatosPersonales.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.pnlDatosPersonales.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlDatosPersonales.Location = New System.Drawing.Point(4, 206)
        Me.pnlDatosPersonales.Name = "pnlDatosPersonales"
        Me.pnlDatosPersonales.Size = New System.Drawing.Size(1240, 205)
        Me.pnlDatosPersonales.TabIndex = 1
        Me.pnlDatosPersonales.TabStop = False
        Me.pnlDatosPersonales.Text = "Datos Personales y Apoderado "
        '
        'lblNomCom
        '
        Me.lblNomCom.AutoSize = True
        Me.lblNomCom.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblNomCom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomCom.Location = New System.Drawing.Point(387, 32)
        Me.lblNomCom.Name = "lblNomCom"
        Me.lblNomCom.Size = New System.Drawing.Size(82, 25)
        Me.lblNomCom.TabIndex = 0
        Me.lblNomCom.Text = "Nombre:"
        '
        'lblDNIDisp
        '
        Me.lblDNIDisp.AutoSize = True
        Me.lblDNIDisp.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblDNIDisp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDNIDisp.Location = New System.Drawing.Point(53, 30)
        Me.lblDNIDisp.Name = "lblDNIDisp"
        Me.lblDNIDisp.Size = New System.Drawing.Size(47, 25)
        Me.lblDNIDisp.TabIndex = 1
        Me.lblDNIDisp.Text = "DNI:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSexo.Location = New System.Drawing.Point(954, 32)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(54, 25)
        Me.lblSexo.TabIndex = 2
        Me.lblSexo.Text = "Sexo:"
        '
        'lblTipoEst
        '
        Me.lblTipoEst.AutoSize = True
        Me.lblTipoEst.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblTipoEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTipoEst.Location = New System.Drawing.Point(331, 82)
        Me.lblTipoEst.Name = "lblTipoEst"
        Me.lblTipoEst.Size = New System.Drawing.Size(138, 25)
        Me.lblTipoEst.TabIndex = 3
        Me.lblTipoEst.Text = "Tipo estudiante:"
        '
        'lblTelf
        '
        Me.lblTelf.AutoSize = True
        Me.lblTelf.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblTelf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTelf.Location = New System.Drawing.Point(960, 84)
        Me.lblTelf.Name = "lblTelf"
        Me.lblTelf.Size = New System.Drawing.Size(46, 25)
        Me.lblTelf.TabIndex = 4
        Me.lblTelf.Text = "Telf.:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCorreo.Location = New System.Drawing.Point(30, 80)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(70, 25)
        Me.lblCorreo.TabIndex = 5
        Me.lblCorreo.Text = "Correo:"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombreCompleto.Location = New System.Drawing.Point(479, 31)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(443, 27)
        Me.txtNombreCompleto.TabIndex = 6
        '
        'txtDNIDisplay
        '
        Me.txtDNIDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDNIDisplay.Location = New System.Drawing.Point(111, 32)
        Me.txtDNIDisplay.Name = "txtDNIDisplay"
        Me.txtDNIDisplay.ReadOnly = True
        Me.txtDNIDisplay.Size = New System.Drawing.Size(190, 31)
        Me.txtDNIDisplay.TabIndex = 7
        '
        'txtSexo
        '
        Me.txtSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtSexo.Location = New System.Drawing.Point(1018, 24)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.ReadOnly = True
        Me.txtSexo.Size = New System.Drawing.Size(202, 31)
        Me.txtSexo.TabIndex = 8
        '
        'txtTipoEstudiante
        '
        Me.txtTipoEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTipoEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTipoEstudiante.Location = New System.Drawing.Point(479, 80)
        Me.txtTipoEstudiante.Name = "txtTipoEstudiante"
        Me.txtTipoEstudiante.ReadOnly = True
        Me.txtTipoEstudiante.Size = New System.Drawing.Size(307, 27)
        Me.txtTipoEstudiante.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(1018, 80)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(202, 31)
        Me.txtTelefono.TabIndex = 10
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtCorreo.Location = New System.Drawing.Point(111, 77)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(190, 31)
        Me.txtCorreo.TabIndex = 11
        '
        'lblSepApoderado
        '
        Me.lblSepApoderado.AutoSize = True
        Me.lblSepApoderado.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSepApoderado.ForeColor = System.Drawing.Color.Gray
        Me.lblSepApoderado.Location = New System.Drawing.Point(1, 119)
        Me.lblSepApoderado.Name = "lblSepApoderado"
        Me.lblSepApoderado.Size = New System.Drawing.Size(128, 19)
        Me.lblSepApoderado.TabIndex = 12
        Me.lblSepApoderado.Text = "──  Apoderado  ──"
        '
        'lblNomApo
        '
        Me.lblNomApo.AutoSize = True
        Me.lblNomApo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblNomApo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomApo.Location = New System.Drawing.Point(387, 155)
        Me.lblNomApo.Name = "lblNomApo"
        Me.lblNomApo.Size = New System.Drawing.Size(82, 25)
        Me.lblNomApo.TabIndex = 13
        Me.lblNomApo.Text = "Nombre:"
        '
        'txtNombreApoderado
        '
        Me.txtNombreApoderado.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNombreApoderado.Location = New System.Drawing.Point(479, 152)
        Me.txtNombreApoderado.Name = "txtNombreApoderado"
        Me.txtNombreApoderado.ReadOnly = True
        Me.txtNombreApoderado.Size = New System.Drawing.Size(443, 31)
        Me.txtNombreApoderado.TabIndex = 14
        '
        'lblTelfApo
        '
        Me.lblTelfApo.AutoSize = True
        Me.lblTelfApo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblTelfApo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTelfApo.Location = New System.Drawing.Point(965, 155)
        Me.lblTelfApo.Name = "lblTelfApo"
        Me.lblTelfApo.Size = New System.Drawing.Size(46, 25)
        Me.lblTelfApo.TabIndex = 15
        Me.lblTelfApo.Text = "Telf.:"
        '
        'txtTelefonoApoderado
        '
        Me.txtTelefonoApoderado.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTelefonoApoderado.Location = New System.Drawing.Point(1019, 149)
        Me.txtTelefonoApoderado.Name = "txtTelefonoApoderado"
        Me.txtTelefonoApoderado.ReadOnly = True
        Me.txtTelefonoApoderado.Size = New System.Drawing.Size(202, 31)
        Me.txtTelefonoApoderado.TabIndex = 16
        '
        'lblDNIApo
        '
        Me.lblDNIApo.AutoSize = True
        Me.lblDNIApo.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.lblDNIApo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDNIApo.Location = New System.Drawing.Point(10, 152)
        Me.lblDNIApo.Name = "lblDNIApo"
        Me.lblDNIApo.Size = New System.Drawing.Size(90, 25)
        Me.lblDNIApo.TabIndex = 17
        Me.lblDNIApo.Text = "DNI Apo.:"
        '
        'txtDniApoderado
        '
        Me.txtDniApoderado.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDniApoderado.Location = New System.Drawing.Point(111, 152)
        Me.txtDniApoderado.Name = "txtDniApoderado"
        Me.txtDniApoderado.ReadOnly = True
        Me.txtDniApoderado.Size = New System.Drawing.Size(199, 31)
        Me.txtDniApoderado.TabIndex = 18
        '
        'tabControlFicha
        '
        Me.tabControlFicha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControlFicha.Controls.Add(Me.tabMatriculas)
        Me.tabControlFicha.Controls.Add(Me.tabCursos)
        Me.tabControlFicha.Controls.Add(Me.tabBecas)
        Me.tabControlFicha.Enabled = False
        Me.tabControlFicha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tabControlFicha.Location = New System.Drawing.Point(8, 435)
        Me.tabControlFicha.Name = "tabControlFicha"
        Me.tabControlFicha.SelectedIndex = 0
        Me.tabControlFicha.Size = New System.Drawing.Size(1240, 343)
        Me.tabControlFicha.TabIndex = 0
        '
        'tabMatriculas
        '
        Me.tabMatriculas.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabMatriculas.Controls.Add(Me.lblTotalMatriculas)
        Me.tabMatriculas.Controls.Add(Me.dgvMatriculas)
        Me.tabMatriculas.Location = New System.Drawing.Point(4, 29)
        Me.tabMatriculas.Name = "tabMatriculas"
        Me.tabMatriculas.Size = New System.Drawing.Size(1232, 310)
        Me.tabMatriculas.TabIndex = 0
        Me.tabMatriculas.Text = "  📅  Historial de Matrículas  "
        '
        'lblTotalMatriculas
        '
        Me.lblTotalMatriculas.AutoSize = True
        Me.lblTotalMatriculas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalMatriculas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTotalMatriculas.Location = New System.Drawing.Point(10, 8)
        Me.lblTotalMatriculas.Name = "lblTotalMatriculas"
        Me.lblTotalMatriculas.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalMatriculas.TabIndex = 0
        '
        'dgvMatriculas
        '
        Me.dgvMatriculas.AllowUserToAddRows = False
        Me.dgvMatriculas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMatriculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMatriculas.BackgroundColor = System.Drawing.Color.White
        Me.dgvMatriculas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMatriculas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMatriculas.ColumnHeadersHeight = 29
        Me.dgvMatriculas.EnableHeadersVisualStyles = False
        Me.dgvMatriculas.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvMatriculas.Location = New System.Drawing.Point(10, 30)
        Me.dgvMatriculas.Name = "dgvMatriculas"
        Me.dgvMatriculas.ReadOnly = True
        Me.dgvMatriculas.RowHeadersVisible = False
        Me.dgvMatriculas.RowHeadersWidth = 51
        Me.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMatriculas.Size = New System.Drawing.Size(2232, 660)
        Me.dgvMatriculas.TabIndex = 1
        '
        'tabCursos
        '
        Me.tabCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabCursos.Controls.Add(Me.lblAnoSeleccionado)
        Me.tabCursos.Controls.Add(Me.btnCargarCursos)
        Me.tabCursos.Controls.Add(Me.dgvCursos)
        Me.tabCursos.Location = New System.Drawing.Point(4, 29)
        Me.tabCursos.Name = "tabCursos"
        Me.tabCursos.Size = New System.Drawing.Size(1232, 310)
        Me.tabCursos.TabIndex = 1
        Me.tabCursos.Text = "  📚  Cursos y Horarios  "
        '
        'lblAnoSeleccionado
        '
        Me.lblAnoSeleccionado.AutoSize = True
        Me.lblAnoSeleccionado.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAnoSeleccionado.ForeColor = System.Drawing.Color.DimGray
        Me.lblAnoSeleccionado.Location = New System.Drawing.Point(10, 8)
        Me.lblAnoSeleccionado.Name = "lblAnoSeleccionado"
        Me.lblAnoSeleccionado.Size = New System.Drawing.Size(417, 20)
        Me.lblAnoSeleccionado.TabIndex = 0
        Me.lblAnoSeleccionado.Text = "Seleccione un año en 'Historial de Matrículas' (doble clic)"
        '
        'btnCargarCursos
        '
        Me.btnCargarCursos.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCargarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarCursos.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargarCursos.ForeColor = System.Drawing.Color.White
        Me.btnCargarCursos.Location = New System.Drawing.Point(700, 4)
        Me.btnCargarCursos.Name = "btnCargarCursos"
        Me.btnCargarCursos.Size = New System.Drawing.Size(200, 28)
        Me.btnCargarCursos.TabIndex = 1
        Me.btnCargarCursos.Text = "↻ Cargar año seleccionado"
        Me.btnCargarCursos.UseVisualStyleBackColor = False
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCursos.BackgroundColor = System.Drawing.Color.White
        Me.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCursos.ColumnHeadersHeight = 29
        Me.dgvCursos.EnableHeadersVisualStyles = False
        Me.dgvCursos.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvCursos.Location = New System.Drawing.Point(10, 36)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.RowHeadersVisible = False
        Me.dgvCursos.RowHeadersWidth = 51
        Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCursos.Size = New System.Drawing.Size(2232, 650)
        Me.dgvCursos.TabIndex = 2
        '
        'tabBecas
        '
        Me.tabBecas.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabBecas.Controls.Add(Me.lblTotalBecas)
        Me.tabBecas.Controls.Add(Me.dgvBecas)
        Me.tabBecas.Location = New System.Drawing.Point(4, 29)
        Me.tabBecas.Name = "tabBecas"
        Me.tabBecas.Size = New System.Drawing.Size(1232, 310)
        Me.tabBecas.TabIndex = 2
        Me.tabBecas.Text = "  🎓  Historial de Becas  "
        '
        'lblTotalBecas
        '
        Me.lblTotalBecas.AutoSize = True
        Me.lblTotalBecas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBecas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTotalBecas.Location = New System.Drawing.Point(10, 8)
        Me.lblTotalBecas.Name = "lblTotalBecas"
        Me.lblTotalBecas.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalBecas.TabIndex = 0
        '
        'dgvBecas
        '
        Me.dgvBecas.AllowUserToAddRows = False
        Me.dgvBecas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBecas.BackgroundColor = System.Drawing.Color.White
        Me.dgvBecas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBecas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBecas.ColumnHeadersHeight = 29
        Me.dgvBecas.EnableHeadersVisualStyles = False
        Me.dgvBecas.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvBecas.Location = New System.Drawing.Point(10, 30)
        Me.dgvBecas.Name = "dgvBecas"
        Me.dgvBecas.ReadOnly = True
        Me.dgvBecas.RowHeadersVisible = False
        Me.dgvBecas.RowHeadersWidth = 51
        Me.dgvBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBecas.Size = New System.Drawing.Size(2232, 660)
        Me.dgvBecas.TabIndex = 1
        '
        'frmHistorialAcademico
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 813)
        Me.Controls.Add(Me.tabControlFicha)
        Me.Controls.Add(Me.pnlDatosPersonales)
        Me.Controls.Add(Me.pnlResumen)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.pnlEncabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1100, 720)
        Me.Name = "frmHistorialAcademico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Matricula - Amancio Varona "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        Me.pnlBusqueda.ResumeLayout(False)
        Me.pnlBusqueda.PerformLayout()
        Me.pnlResumen.ResumeLayout(False)
        Me.pnlResumen.PerformLayout()
        Me.pnlDatosPersonales.ResumeLayout(False)
        Me.pnlDatosPersonales.PerformLayout()
        Me.tabControlFicha.ResumeLayout(False)
        Me.tabMatriculas.ResumeLayout(False)
        Me.tabMatriculas.PerformLayout()
        CType(Me.dgvMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCursos.ResumeLayout(False)
        Me.tabCursos.PerformLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBecas.ResumeLayout(False)
        Me.tabBecas.PerformLayout()
        CType(Me.dgvBecas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
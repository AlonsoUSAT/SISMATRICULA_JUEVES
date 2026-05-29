<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsigBecas
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

    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAnoAcademico As System.Windows.Forms.Label
    Friend WithEvents lblFechaActual As System.Windows.Forms.Label
    Friend WithEvents tabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAsignacion As System.Windows.Forms.TabPage
    Friend WithEvents tabBecadosActivos As System.Windows.Forms.TabPage
    Friend WithEvents pnlBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents pnlDatosEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents lblNomEst As System.Windows.Forms.Label
    Friend WithEvents txtNombreEstudiante As System.Windows.Forms.TextBox
    Friend WithEvents lblNivelG As System.Windows.Forms.Label
    Friend WithEvents txtNivelGrado As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoEst As System.Windows.Forms.Label
    Friend WithEvents txtTipoEstudiante As System.Windows.Forms.TextBox
    Friend WithEvents lblEstadoBecaActual As System.Windows.Forms.Label
    Friend WithEvents lblEstadoBeca As System.Windows.Forms.Label
    Friend WithEvents pnlAsignacion As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoBeca As System.Windows.Forms.Label
    Friend WithEvents cboTipoBeca As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescripcionBeca As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionTexto As System.Windows.Forms.Label
    Friend WithEvents lblPromedioInfo As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lblDescuentoCalc As System.Windows.Forms.Label
    Friend WithEvents lblMontoDescLabel As System.Windows.Forms.Label
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnSuspender As System.Windows.Forms.Button
    Friend WithEvents btnRevocar As System.Windows.Forms.Button
    Friend WithEvents pnlHistorialBecas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHistorialBecas As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBecadosActivos As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscarEn As System.Windows.Forms.Label
    Friend WithEvents txtBuscarEnLista As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBecados As System.Windows.Forms.Label
    Friend WithEvents dgvBecadosActivos As System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsigBecas))
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAnoAcademico = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAsignacion = New System.Windows.Forms.TabPage()
        Me.pnlBusqueda = New System.Windows.Forms.GroupBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlDatosEstudiante = New System.Windows.Forms.GroupBox()
        Me.lblNomEst = New System.Windows.Forms.Label()
        Me.txtNombreEstudiante = New System.Windows.Forms.TextBox()
        Me.lblNivelG = New System.Windows.Forms.Label()
        Me.txtNivelGrado = New System.Windows.Forms.TextBox()
        Me.lblTipoEst = New System.Windows.Forms.Label()
        Me.txtTipoEstudiante = New System.Windows.Forms.TextBox()
        Me.lblEstadoBecaActual = New System.Windows.Forms.Label()
        Me.lblEstadoBeca = New System.Windows.Forms.Label()
        Me.pnlHistorialBecas = New System.Windows.Forms.GroupBox()
        Me.dgvHistorialBecas = New System.Windows.Forms.DataGridView()
        Me.pnlAsignacion = New System.Windows.Forms.GroupBox()
        Me.txtDescuentoMes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblTipoBeca = New System.Windows.Forms.Label()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.cboTipoBeca = New System.Windows.Forms.ComboBox()
        Me.btnSuspender = New System.Windows.Forms.Button()
        Me.lblDescripcionBeca = New System.Windows.Forms.Label()
        Me.btnRevocar = New System.Windows.Forms.Button()
        Me.lblDescripcionTexto = New System.Windows.Forms.Label()
        Me.lblPromedioInfo = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lblDescuentoCalc = New System.Windows.Forms.Label()
        Me.lblMontoDescLabel = New System.Windows.Forms.Label()
        Me.tabBecadosActivos = New System.Windows.Forms.TabPage()
        Me.pnlBecadosActivos = New System.Windows.Forms.GroupBox()
        Me.lblBuscarEn = New System.Windows.Forms.Label()
        Me.txtBuscarEnLista = New System.Windows.Forms.TextBox()
        Me.lblTotalBecados = New System.Windows.Forms.Label()
        Me.dgvBecadosActivos = New System.Windows.Forms.DataGridView()
        Me.pnlEncabezado.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabAsignacion.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        Me.pnlDatosEstudiante.SuspendLayout()
        Me.pnlHistorialBecas.SuspendLayout()
        CType(Me.dgvHistorialBecas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAsignacion.SuspendLayout()
        Me.tabBecadosActivos.SuspendLayout()
        Me.pnlBecadosActivos.SuspendLayout()
        CType(Me.dgvBecadosActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.BackColor = System.Drawing.Color.Firebrick
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblAnoAcademico)
        Me.pnlEncabezado.Controls.Add(Me.lblFechaActual)
        Me.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(1084, 64)
        Me.pnlEncabezado.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(406, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "  MODULO DE ASIGNACION DE BECAS"
        '
        'lblAnoAcademico
        '
        Me.lblAnoAcademico.AutoSize = True
        Me.lblAnoAcademico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAnoAcademico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnoAcademico.Location = New System.Drawing.Point(700, 18)
        Me.lblAnoAcademico.Name = "lblAnoAcademico"
        Me.lblAnoAcademico.Size = New System.Drawing.Size(106, 15)
        Me.lblAnoAcademico.TabIndex = 1
        Me.lblAnoAcademico.Text = "Año academico: --"
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFechaActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFechaActual.Location = New System.Drawing.Point(700, 40)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(102, 15)
        Me.lblFechaActual.TabIndex = 2
        Me.lblFechaActual.Text = "Fecha: 27/05/2026"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabAsignacion)
        Me.tabControl1.Controls.Add(Me.tabBecadosActivos)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tabControl1.Location = New System.Drawing.Point(0, 64)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1084, 597)
        Me.tabControl1.TabIndex = 0
        '
        'tabAsignacion
        '
        Me.tabAsignacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabAsignacion.Controls.Add(Me.pnlBusqueda)
        Me.tabAsignacion.Controls.Add(Me.pnlDatosEstudiante)
        Me.tabAsignacion.Controls.Add(Me.pnlHistorialBecas)
        Me.tabAsignacion.Controls.Add(Me.pnlAsignacion)
        Me.tabAsignacion.Location = New System.Drawing.Point(4, 24)
        Me.tabAsignacion.Name = "tabAsignacion"
        Me.tabAsignacion.Size = New System.Drawing.Size(1076, 569)
        Me.tabAsignacion.TabIndex = 0
        Me.tabAsignacion.Text = "  Asignar / Gestionar Beca  "
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.BackColor = System.Drawing.Color.White
        Me.pnlBusqueda.Controls.Add(Me.lblDNI)
        Me.pnlBusqueda.Controls.Add(Me.txtDNI)
        Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
        Me.pnlBusqueda.Controls.Add(Me.btnLimpiar)
        Me.pnlBusqueda.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBusqueda.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlBusqueda.Location = New System.Drawing.Point(8, 8)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(1035, 70)
        Me.pnlBusqueda.TabIndex = 0
        Me.pnlBusqueda.TabStop = False
        Me.pnlBusqueda.Text = " Busqueda de Estudiante "
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDNI.Location = New System.Drawing.Point(14, 30)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(136, 20)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "DNI del Estudiante:"
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDNI.Location = New System.Drawing.Point(196, 26)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(198, 27)
        Me.txtDNI.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(404, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 40)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Image = Global.capaPresentacion.My.Resources.Resources.borrador
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.Location = New System.Drawing.Point(543, 21)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(143, 40)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlDatosEstudiante
        '
        Me.pnlDatosEstudiante.BackColor = System.Drawing.Color.White
        Me.pnlDatosEstudiante.Controls.Add(Me.lblNomEst)
        Me.pnlDatosEstudiante.Controls.Add(Me.txtNombreEstudiante)
        Me.pnlDatosEstudiante.Controls.Add(Me.lblNivelG)
        Me.pnlDatosEstudiante.Controls.Add(Me.txtNivelGrado)
        Me.pnlDatosEstudiante.Controls.Add(Me.lblTipoEst)
        Me.pnlDatosEstudiante.Controls.Add(Me.txtTipoEstudiante)
        Me.pnlDatosEstudiante.Controls.Add(Me.lblEstadoBecaActual)
        Me.pnlDatosEstudiante.Controls.Add(Me.lblEstadoBeca)
        Me.pnlDatosEstudiante.Enabled = False
        Me.pnlDatosEstudiante.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosEstudiante.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlDatosEstudiante.Location = New System.Drawing.Point(8, 84)
        Me.pnlDatosEstudiante.Name = "pnlDatosEstudiante"
        Me.pnlDatosEstudiante.Size = New System.Drawing.Size(1035, 124)
        Me.pnlDatosEstudiante.TabIndex = 1
        Me.pnlDatosEstudiante.TabStop = False
        Me.pnlDatosEstudiante.Text = " Datos del Estudiante "
        '
        'lblNomEst
        '
        Me.lblNomEst.AutoSize = True
        Me.lblNomEst.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomEst.Location = New System.Drawing.Point(14, 28)
        Me.lblNomEst.Name = "lblNomEst"
        Me.lblNomEst.Size = New System.Drawing.Size(135, 20)
        Me.lblNomEst.TabIndex = 0
        Me.lblNomEst.Text = "Nombre completo:"
        '
        'txtNombreEstudiante
        '
        Me.txtNombreEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNombreEstudiante.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombreEstudiante.Location = New System.Drawing.Point(191, 27)
        Me.txtNombreEstudiante.Name = "txtNombreEstudiante"
        Me.txtNombreEstudiante.ReadOnly = True
        Me.txtNombreEstudiante.Size = New System.Drawing.Size(380, 25)
        Me.txtNombreEstudiante.TabIndex = 1
        '
        'lblNivelG
        '
        Me.lblNivelG.AutoSize = True
        Me.lblNivelG.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNivelG.Location = New System.Drawing.Point(589, 28)
        Me.lblNivelG.Name = "lblNivelG"
        Me.lblNivelG.Size = New System.Drawing.Size(166, 20)
        Me.lblNivelG.TabIndex = 2
        Me.lblNivelG.Text = "Nivel / Grado / Seccion:"
        '
        'txtNivelGrado
        '
        Me.txtNivelGrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtNivelGrado.Location = New System.Drawing.Point(776, 28)
        Me.txtNivelGrado.Name = "txtNivelGrado"
        Me.txtNivelGrado.ReadOnly = True
        Me.txtNivelGrado.Size = New System.Drawing.Size(220, 27)
        Me.txtNivelGrado.TabIndex = 3
        '
        'lblTipoEst
        '
        Me.lblTipoEst.AutoSize = True
        Me.lblTipoEst.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTipoEst.Location = New System.Drawing.Point(35, 84)
        Me.lblTipoEst.Name = "lblTipoEst"
        Me.lblTipoEst.Size = New System.Drawing.Size(115, 20)
        Me.lblTipoEst.TabIndex = 4
        Me.lblTipoEst.Text = "Tipo estudiante:"
        '
        'txtTipoEstudiante
        '
        Me.txtTipoEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtTipoEstudiante.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTipoEstudiante.Location = New System.Drawing.Point(191, 84)
        Me.txtTipoEstudiante.Name = "txtTipoEstudiante"
        Me.txtTipoEstudiante.ReadOnly = True
        Me.txtTipoEstudiante.Size = New System.Drawing.Size(203, 23)
        Me.txtTipoEstudiante.TabIndex = 5
        '
        'lblEstadoBecaActual
        '
        Me.lblEstadoBecaActual.AutoSize = True
        Me.lblEstadoBecaActual.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoBecaActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstadoBecaActual.Location = New System.Drawing.Point(641, 79)
        Me.lblEstadoBecaActual.Name = "lblEstadoBecaActual"
        Me.lblEstadoBecaActual.Size = New System.Drawing.Size(114, 20)
        Me.lblEstadoBecaActual.TabIndex = 6
        Me.lblEstadoBecaActual.Text = "Estado de beca:"
        '
        'lblEstadoBeca
        '
        Me.lblEstadoBeca.AutoSize = True
        Me.lblEstadoBeca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEstadoBeca.ForeColor = System.Drawing.Color.DimGray
        Me.lblEstadoBeca.Location = New System.Drawing.Point(773, 87)
        Me.lblEstadoBeca.Name = "lblEstadoBeca"
        Me.lblEstadoBeca.Size = New System.Drawing.Size(191, 15)
        Me.lblEstadoBeca.TabIndex = 7
        Me.lblEstadoBeca.Text = "-- Busque un estudiante por DNI --"
        '
        'pnlHistorialBecas
        '
        Me.pnlHistorialBecas.BackColor = System.Drawing.Color.White
        Me.pnlHistorialBecas.Controls.Add(Me.dgvHistorialBecas)
        Me.pnlHistorialBecas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pnlHistorialBecas.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlHistorialBecas.Location = New System.Drawing.Point(632, 214)
        Me.pnlHistorialBecas.Name = "pnlHistorialBecas"
        Me.pnlHistorialBecas.Size = New System.Drawing.Size(411, 322)
        Me.pnlHistorialBecas.TabIndex = 3
        Me.pnlHistorialBecas.TabStop = False
        Me.pnlHistorialBecas.Text = " Historial de Becas del Estudiante "
        '
        'dgvHistorialBecas
        '
        Me.dgvHistorialBecas.AllowUserToAddRows = False
        Me.dgvHistorialBecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorialBecas.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorialBecas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorialBecas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistorialBecas.ColumnHeadersHeight = 29
        Me.dgvHistorialBecas.EnableHeadersVisualStyles = False
        Me.dgvHistorialBecas.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvHistorialBecas.Location = New System.Drawing.Point(6, 22)
        Me.dgvHistorialBecas.Name = "dgvHistorialBecas"
        Me.dgvHistorialBecas.ReadOnly = True
        Me.dgvHistorialBecas.RowHeadersVisible = False
        Me.dgvHistorialBecas.RowHeadersWidth = 51
        Me.dgvHistorialBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorialBecas.Size = New System.Drawing.Size(399, 294)
        Me.dgvHistorialBecas.TabIndex = 0
        '
        'pnlAsignacion
        '
        Me.pnlAsignacion.BackColor = System.Drawing.Color.White
        Me.pnlAsignacion.Controls.Add(Me.txtDescuentoMes)
        Me.pnlAsignacion.Controls.Add(Me.Label1)
        Me.pnlAsignacion.Controls.Add(Me.txtDescuento)
        Me.pnlAsignacion.Controls.Add(Me.lblTipoBeca)
        Me.pnlAsignacion.Controls.Add(Me.btnAsignar)
        Me.pnlAsignacion.Controls.Add(Me.cboTipoBeca)
        Me.pnlAsignacion.Controls.Add(Me.btnSuspender)
        Me.pnlAsignacion.Controls.Add(Me.lblDescripcionBeca)
        Me.pnlAsignacion.Controls.Add(Me.btnRevocar)
        Me.pnlAsignacion.Controls.Add(Me.lblDescripcionTexto)
        Me.pnlAsignacion.Controls.Add(Me.lblPromedioInfo)
        Me.pnlAsignacion.Controls.Add(Me.lblMotivo)
        Me.pnlAsignacion.Controls.Add(Me.txtMotivo)
        Me.pnlAsignacion.Controls.Add(Me.lblDescuentoCalc)
        Me.pnlAsignacion.Controls.Add(Me.lblMontoDescLabel)
        Me.pnlAsignacion.Enabled = False
        Me.pnlAsignacion.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAsignacion.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlAsignacion.Location = New System.Drawing.Point(6, 214)
        Me.pnlAsignacion.Name = "pnlAsignacion"
        Me.pnlAsignacion.Size = New System.Drawing.Size(620, 322)
        Me.pnlAsignacion.TabIndex = 2
        Me.pnlAsignacion.TabStop = False
        Me.pnlAsignacion.Text = " Asignacion / Gestion de Beca "
        '
        'txtDescuentoMes
        '
        Me.txtDescuentoMes.Location = New System.Drawing.Point(218, 210)
        Me.txtDescuentoMes.Name = "txtDescuentoMes"
        Me.txtDescuentoMes.Size = New System.Drawing.Size(337, 27)
        Me.txtDescuentoMes.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(17, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Monto Descuento Mes:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(218, 165)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(337, 27)
        Me.txtDescuento.TabIndex = 18
        '
        'lblTipoBeca
        '
        Me.lblTipoBeca.AutoSize = True
        Me.lblTipoBeca.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoBeca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTipoBeca.Location = New System.Drawing.Point(14, 30)
        Me.lblTipoBeca.Name = "lblTipoBeca"
        Me.lblTipoBeca.Size = New System.Drawing.Size(99, 20)
        Me.lblTipoBeca.TabIndex = 0
        Me.lblTipoBeca.Text = "Tipo de Beca:"
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAsignar.Enabled = False
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAsignar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAsignar.Image = Global.capaPresentacion.My.Resources.Resources.beca
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(25, 258)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(195, 38)
        Me.btnAsignar.TabIndex = 15
        Me.btnAsignar.Text = "ASIGNAR BECA"
        Me.btnAsignar.UseVisualStyleBackColor = False
        '
        'cboTipoBeca
        '
        Me.cboTipoBeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoBeca.Location = New System.Drawing.Point(147, 26)
        Me.cboTipoBeca.Name = "cboTipoBeca"
        Me.cboTipoBeca.Size = New System.Drawing.Size(443, 27)
        Me.cboTipoBeca.TabIndex = 1
        '
        'btnSuspender
        '
        Me.btnSuspender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSuspender.Enabled = False
        Me.btnSuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuspender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSuspender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSuspender.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnSuspender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSuspender.Location = New System.Drawing.Point(226, 258)
        Me.btnSuspender.Name = "btnSuspender"
        Me.btnSuspender.Size = New System.Drawing.Size(170, 38)
        Me.btnSuspender.TabIndex = 16
        Me.btnSuspender.Text = "SUSPENDER"
        Me.btnSuspender.UseVisualStyleBackColor = False
        '
        'lblDescripcionBeca
        '
        Me.lblDescripcionBeca.AutoSize = True
        Me.lblDescripcionBeca.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionBeca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescripcionBeca.Location = New System.Drawing.Point(14, 65)
        Me.lblDescripcionBeca.Name = "lblDescripcionBeca"
        Me.lblDescripcionBeca.Size = New System.Drawing.Size(90, 20)
        Me.lblDescripcionBeca.TabIndex = 2
        Me.lblDescripcionBeca.Text = "Descripcion:"
        '
        'btnRevocar
        '
        Me.btnRevocar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRevocar.Enabled = False
        Me.btnRevocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevocar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRevocar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRevocar.Location = New System.Drawing.Point(420, 258)
        Me.btnRevocar.Name = "btnRevocar"
        Me.btnRevocar.Size = New System.Drawing.Size(170, 38)
        Me.btnRevocar.TabIndex = 17
        Me.btnRevocar.Text = "REVOCAR"
        Me.btnRevocar.UseVisualStyleBackColor = False
        '
        'lblDescripcionTexto
        '
        Me.lblDescripcionTexto.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblDescripcionTexto.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescripcionTexto.Location = New System.Drawing.Point(147, 65)
        Me.lblDescripcionTexto.Name = "lblDescripcionTexto"
        Me.lblDescripcionTexto.Size = New System.Drawing.Size(443, 25)
        Me.lblDescripcionTexto.TabIndex = 3
        '
        'lblPromedioInfo
        '
        Me.lblPromedioInfo.AutoSize = True
        Me.lblPromedioInfo.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPromedioInfo.Location = New System.Drawing.Point(225, 118)
        Me.lblPromedioInfo.Name = "lblPromedioInfo"
        Me.lblPromedioInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblPromedioInfo.TabIndex = 6
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMotivo.Location = New System.Drawing.Point(14, 90)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(248, 20)
        Me.lblMotivo.TabIndex = 7
        Me.lblMotivo.Text = "Motivo / Justificacion (*obligatorio):"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(14, 118)
        Me.txtMotivo.MaxLength = 600
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivo.Size = New System.Drawing.Size(576, 40)
        Me.txtMotivo.TabIndex = 8
        '
        'lblDescuentoCalc
        '
        Me.lblDescuentoCalc.AutoSize = True
        Me.lblDescuentoCalc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoCalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescuentoCalc.Location = New System.Drawing.Point(17, 168)
        Me.lblDescuentoCalc.Name = "lblDescuentoCalc"
        Me.lblDescuentoCalc.Size = New System.Drawing.Size(144, 20)
        Me.lblDescuentoCalc.TabIndex = 11
        Me.lblDescuentoCalc.Text = "Descuento aplicado:"
        '
        'lblMontoDescLabel
        '
        Me.lblMontoDescLabel.AutoSize = True
        Me.lblMontoDescLabel.Location = New System.Drawing.Point(14, 298)
        Me.lblMontoDescLabel.Name = "lblMontoDescLabel"
        Me.lblMontoDescLabel.Size = New System.Drawing.Size(0, 20)
        Me.lblMontoDescLabel.TabIndex = 13
        '
        'tabBecadosActivos
        '
        Me.tabBecadosActivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabBecadosActivos.Controls.Add(Me.pnlBecadosActivos)
        Me.tabBecadosActivos.Location = New System.Drawing.Point(4, 24)
        Me.tabBecadosActivos.Name = "tabBecadosActivos"
        Me.tabBecadosActivos.Size = New System.Drawing.Size(1076, 569)
        Me.tabBecadosActivos.TabIndex = 1
        Me.tabBecadosActivos.Text = "  Becados del Ano Actual  "
        '
        'pnlBecadosActivos
        '
        Me.pnlBecadosActivos.BackColor = System.Drawing.Color.White
        Me.pnlBecadosActivos.Controls.Add(Me.lblBuscarEn)
        Me.pnlBecadosActivos.Controls.Add(Me.txtBuscarEnLista)
        Me.pnlBecadosActivos.Controls.Add(Me.lblTotalBecados)
        Me.pnlBecadosActivos.Controls.Add(Me.dgvBecadosActivos)
        Me.pnlBecadosActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBecadosActivos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pnlBecadosActivos.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlBecadosActivos.Location = New System.Drawing.Point(0, 0)
        Me.pnlBecadosActivos.Name = "pnlBecadosActivos"
        Me.pnlBecadosActivos.Size = New System.Drawing.Size(1076, 569)
        Me.pnlBecadosActivos.TabIndex = 0
        Me.pnlBecadosActivos.TabStop = False
        Me.pnlBecadosActivos.Text = " Listado de Becados - Ano Academico Actual "
        '
        'lblBuscarEn
        '
        Me.lblBuscarEn.AutoSize = True
        Me.lblBuscarEn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblBuscarEn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuscarEn.Location = New System.Drawing.Point(14, 28)
        Me.lblBuscarEn.Name = "lblBuscarEn"
        Me.lblBuscarEn.Size = New System.Drawing.Size(54, 21)
        Me.lblBuscarEn.TabIndex = 0
        Me.lblBuscarEn.Text = "Filtrar:"
        '
        'txtBuscarEnLista
        '
        Me.txtBuscarEnLista.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscarEnLista.Location = New System.Drawing.Point(70, 28)
        Me.txtBuscarEnLista.Name = "txtBuscarEnLista"
        Me.txtBuscarEnLista.Size = New System.Drawing.Size(300, 23)
        Me.txtBuscarEnLista.TabIndex = 1
        '
        'lblTotalBecados
        '
        Me.lblTotalBecados.AutoSize = True
        Me.lblTotalBecados.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTotalBecados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalBecados.Location = New System.Drawing.Point(400, 28)
        Me.lblTotalBecados.Name = "lblTotalBecados"
        Me.lblTotalBecados.Size = New System.Drawing.Size(61, 21)
        Me.lblTotalBecados.TabIndex = 2
        Me.lblTotalBecados.Text = "Total: --"
        '
        'dgvBecadosActivos
        '
        Me.dgvBecadosActivos.AllowUserToAddRows = False
        Me.dgvBecadosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBecadosActivos.BackgroundColor = System.Drawing.Color.White
        Me.dgvBecadosActivos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBecadosActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBecadosActivos.ColumnHeadersHeight = 29
        Me.dgvBecadosActivos.EnableHeadersVisualStyles = False
        Me.dgvBecadosActivos.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvBecadosActivos.Location = New System.Drawing.Point(3, 57)
        Me.dgvBecadosActivos.Name = "dgvBecadosActivos"
        Me.dgvBecadosActivos.ReadOnly = True
        Me.dgvBecadosActivos.RowHeadersVisible = False
        Me.dgvBecadosActivos.RowHeadersWidth = 51
        Me.dgvBecadosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBecadosActivos.Size = New System.Drawing.Size(1063, 505)
        Me.dgvBecadosActivos.TabIndex = 3
        '
        'frmAsigBecas
        '
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.pnlEncabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "frmAsigBecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Matricula - Amancio Varona "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabAsignacion.ResumeLayout(False)
        Me.pnlBusqueda.ResumeLayout(False)
        Me.pnlBusqueda.PerformLayout()
        Me.pnlDatosEstudiante.ResumeLayout(False)
        Me.pnlDatosEstudiante.PerformLayout()
        Me.pnlHistorialBecas.ResumeLayout(False)
        CType(Me.dgvHistorialBecas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAsignacion.ResumeLayout(False)
        Me.pnlAsignacion.PerformLayout()
        Me.tabBecadosActivos.ResumeLayout(False)
        Me.pnlBecadosActivos.ResumeLayout(False)
        Me.pnlBecadosActivos.PerformLayout()
        CType(Me.dgvBecadosActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtDescuentoMes As TextBox
    Friend WithEvents Label1 As Label
End Class
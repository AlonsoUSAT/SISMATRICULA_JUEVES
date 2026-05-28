<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMantBecas
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

    ' ─── DECLARACION DE CONTROLES ───────────────────────────────

    ' Encabezado
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAnoActivo As System.Windows.Forms.Label
    Friend WithEvents lblFechaHoy As System.Windows.Forms.Label

    ' TabControl principal
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabTipos As System.Windows.Forms.TabPage

    ' ── TAB 1: TIPO_BECA ─────────────────────────────────────
    ' Panel izquierdo grilla
    Friend WithEvents pnlIzqTipo As System.Windows.Forms.Panel
    Friend WithEvents lblFiltroTipo As System.Windows.Forms.Label
    Friend WithEvents txtFiltroTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTipos As System.Windows.Forms.Label
    Friend WithEvents dgvTiposBeca As System.Windows.Forms.DataGridView

    ' Panel derecho formulario
    Friend WithEvents pnlDerTipo As System.Windows.Forms.Panel
    Friend WithEvents lblModoTipo As System.Windows.Forms.Label
    Friend WithEvents pnlFormTipo As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescTipo As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblPctTipo As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblPctSufijo As System.Windows.Forms.Label
    Friend WithEvents lblAyudaPct As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAnoActivo = New System.Windows.Forms.Label()
        Me.lblFechaHoy = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabTipos = New System.Windows.Forms.TabPage()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pnlIzqTipo = New System.Windows.Forms.Panel()
        Me.lblFiltroTipo = New System.Windows.Forms.Label()
        Me.txtFiltroTipo = New System.Windows.Forms.TextBox()
        Me.lblTotalTipos = New System.Windows.Forms.Label()
        Me.dgvTiposBeca = New System.Windows.Forms.DataGridView()
        Me.pnlDerTipo = New System.Windows.Forms.Panel()
        Me.lblModoTipo = New System.Windows.Forms.Label()
        Me.pnlFormTipo = New System.Windows.Forms.GroupBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescTipo = New System.Windows.Forms.Label()
        Me.txtDescripcionTipo = New System.Windows.Forms.TextBox()
        Me.lblPctTipo = New System.Windows.Forms.Label()
        Me.txtPorcentajeTipo = New System.Windows.Forms.TextBox()
        Me.lblPctSufijo = New System.Windows.Forms.Label()
        Me.lblAyudaPct = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabTipos.SuspendLayout()
        Me.pnlIzqTipo.SuspendLayout()
        CType(Me.dgvTiposBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDerTipo.SuspendLayout()
        Me.pnlFormTipo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Firebrick
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.lblAnoActivo)
        Me.pnlHeader.Controls.Add(Me.lblFechaHoy)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1082, 64)
        Me.pnlHeader.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(8, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(392, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "  MANTENIMIENTO DE BECAS"
        '
        'lblAnoActivo
        '
        Me.lblAnoActivo.AutoSize = True
        Me.lblAnoActivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAnoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAnoActivo.Location = New System.Drawing.Point(720, 18)
        Me.lblAnoActivo.Name = "lblAnoActivo"
        Me.lblAnoActivo.Size = New System.Drawing.Size(176, 20)
        Me.lblAnoActivo.TabIndex = 1
        Me.lblAnoActivo.Text = "Año academico activo: --"
        '
        'lblFechaHoy
        '
        Me.lblFechaHoy.AutoSize = True
        Me.lblFechaHoy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFechaHoy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFechaHoy.Location = New System.Drawing.Point(720, 40)
        Me.lblFechaHoy.Name = "lblFechaHoy"
        Me.lblFechaHoy.Size = New System.Drawing.Size(130, 20)
        Me.lblFechaHoy.TabIndex = 2
        Me.lblFechaHoy.Text = "Fecha: 27/05/2026"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabTipos)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tabMain.Location = New System.Drawing.Point(0, 64)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1082, 709)
        Me.tabMain.TabIndex = 0
        '
        'tabTipos
        '
        Me.tabTipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tabTipos.Controls.Add(Me.btnNuevo)
        Me.tabTipos.Controls.Add(Me.pnlIzqTipo)
        Me.tabTipos.Controls.Add(Me.pnlDerTipo)
        Me.tabTipos.Controls.Add(Me.Panel1)
        Me.tabTipos.Location = New System.Drawing.Point(4, 29)
        Me.tabTipos.Name = "tabTipos"
        Me.tabTipos.Size = New System.Drawing.Size(1074, 676)
        Me.tabTipos.TabIndex = 0
        Me.tabTipos.Text = "  Tipos de Beca (Catalogo)  "
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(797, 8)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(214, 59)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'pnlIzqTipo
        '
        Me.pnlIzqTipo.BackColor = System.Drawing.Color.White
        Me.pnlIzqTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIzqTipo.Controls.Add(Me.lblFiltroTipo)
        Me.pnlIzqTipo.Controls.Add(Me.txtFiltroTipo)
        Me.pnlIzqTipo.Controls.Add(Me.lblTotalTipos)
        Me.pnlIzqTipo.Controls.Add(Me.dgvTiposBeca)
        Me.pnlIzqTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlIzqTipo.Location = New System.Drawing.Point(15, 315)
        Me.pnlIzqTipo.Name = "pnlIzqTipo"
        Me.pnlIzqTipo.Size = New System.Drawing.Size(750, 353)
        Me.pnlIzqTipo.TabIndex = 0
        '
        'lblFiltroTipo
        '
        Me.lblFiltroTipo.AutoSize = True
        Me.lblFiltroTipo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblFiltroTipo.Location = New System.Drawing.Point(8, 10)
        Me.lblFiltroTipo.Name = "lblFiltroTipo"
        Me.lblFiltroTipo.Size = New System.Drawing.Size(72, 25)
        Me.lblFiltroTipo.TabIndex = 0
        Me.lblFiltroTipo.Text = "Buscar:"
        '
        'txtFiltroTipo
        '
        Me.txtFiltroTipo.Location = New System.Drawing.Point(62, 6)
        Me.txtFiltroTipo.Name = "txtFiltroTipo"
        Me.txtFiltroTipo.Size = New System.Drawing.Size(280, 27)
        Me.txtFiltroTipo.TabIndex = 1
        '
        'lblTotalTipos
        '
        Me.lblTotalTipos.AutoSize = True
        Me.lblTotalTipos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTotalTipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalTipos.Location = New System.Drawing.Point(360, 10)
        Me.lblTotalTipos.Name = "lblTotalTipos"
        Me.lblTotalTipos.Size = New System.Drawing.Size(77, 25)
        Me.lblTotalTipos.TabIndex = 2
        Me.lblTotalTipos.Text = "Total: --"
        '
        'dgvTiposBeca
        '
        Me.dgvTiposBeca.AllowUserToAddRows = False
        Me.dgvTiposBeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTiposBeca.BackgroundColor = System.Drawing.Color.White
        Me.dgvTiposBeca.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTiposBeca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTiposBeca.ColumnHeadersHeight = 29
        Me.dgvTiposBeca.EnableHeadersVisualStyles = False
        Me.dgvTiposBeca.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvTiposBeca.Location = New System.Drawing.Point(4, 36)
        Me.dgvTiposBeca.Name = "dgvTiposBeca"
        Me.dgvTiposBeca.ReadOnly = True
        Me.dgvTiposBeca.RowHeadersVisible = False
        Me.dgvTiposBeca.RowHeadersWidth = 51
        Me.dgvTiposBeca.RowTemplate.Height = 28
        Me.dgvTiposBeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposBeca.Size = New System.Drawing.Size(740, 648)
        Me.dgvTiposBeca.TabIndex = 3
        '
        'pnlDerTipo
        '
        Me.pnlDerTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlDerTipo.Controls.Add(Me.lblModoTipo)
        Me.pnlDerTipo.Controls.Add(Me.pnlFormTipo)
        Me.pnlDerTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pnlDerTipo.Location = New System.Drawing.Point(3, 0)
        Me.pnlDerTipo.Name = "pnlDerTipo"
        Me.pnlDerTipo.Size = New System.Drawing.Size(746, 281)
        Me.pnlDerTipo.TabIndex = 1
        '
        'lblModoTipo
        '
        Me.lblModoTipo.AutoSize = True
        Me.lblModoTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblModoTipo.ForeColor = System.Drawing.Color.DimGray
        Me.lblModoTipo.Location = New System.Drawing.Point(4, 8)
        Me.lblModoTipo.Name = "lblModoTipo"
        Me.lblModoTipo.Size = New System.Drawing.Size(240, 20)
        Me.lblModoTipo.TabIndex = 0
        Me.lblModoTipo.Text = "Seleccione un registro de la lista"
        '
        'pnlFormTipo
        '
        Me.pnlFormTipo.BackColor = System.Drawing.Color.White
        Me.pnlFormTipo.Controls.Add(Me.chkEstado)
        Me.pnlFormTipo.Controls.Add(Me.Label2)
        Me.pnlFormTipo.Controls.Add(Me.Button1)
        Me.pnlFormTipo.Controls.Add(Me.txtCodigo)
        Me.pnlFormTipo.Controls.Add(Me.Label1)
        Me.pnlFormTipo.Controls.Add(Me.lblDescTipo)
        Me.pnlFormTipo.Controls.Add(Me.txtDescripcionTipo)
        Me.pnlFormTipo.Controls.Add(Me.lblPctTipo)
        Me.pnlFormTipo.Controls.Add(Me.txtPorcentajeTipo)
        Me.pnlFormTipo.Controls.Add(Me.lblPctSufijo)
        Me.pnlFormTipo.Controls.Add(Me.lblAyudaPct)
        Me.pnlFormTipo.Enabled = False
        Me.pnlFormTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pnlFormTipo.ForeColor = System.Drawing.Color.Firebrick
        Me.pnlFormTipo.Location = New System.Drawing.Point(4, 32)
        Me.pnlFormTipo.Name = "pnlFormTipo"
        Me.pnlFormTipo.Size = New System.Drawing.Size(739, 246)
        Me.pnlFormTipo.TabIndex = 1
        Me.pnlFormTipo.TabStop = False
        Me.pnlFormTipo.Text = " Datos del Tipo de Beca "
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkEstado.Location = New System.Drawing.Point(274, 199)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(90, 32)
        Me.chkEstado.TabIndex = 10
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(185, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Estado:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(489, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCodigo.Location = New System.Drawing.Point(274, 30)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(165, 30)
        Me.txtCodigo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(183, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id Beca:"
        '
        'lblDescTipo
        '
        Me.lblDescTipo.AutoSize = True
        Me.lblDescTipo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblDescTipo.ForeColor = System.Drawing.Color.Black
        Me.lblDescTipo.Location = New System.Drawing.Point(120, 78)
        Me.lblDescTipo.Name = "lblDescTipo"
        Me.lblDescTipo.Size = New System.Drawing.Size(140, 25)
        Me.lblDescTipo.TabIndex = 0
        Me.lblDescTipo.Text = "Descripcion (*):"
        '
        'txtDescripcionTipo
        '
        Me.txtDescripcionTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDescripcionTipo.Location = New System.Drawing.Point(274, 73)
        Me.txtDescripcionTipo.MaxLength = 100
        Me.txtDescripcionTipo.Name = "txtDescripcionTipo"
        Me.txtDescripcionTipo.Size = New System.Drawing.Size(440, 30)
        Me.txtDescripcionTipo.TabIndex = 1
        '
        'lblPctTipo
        '
        Me.lblPctTipo.AutoSize = True
        Me.lblPctTipo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblPctTipo.ForeColor = System.Drawing.Color.Black
        Me.lblPctTipo.Location = New System.Drawing.Point(12, 130)
        Me.lblPctTipo.Name = "lblPctTipo"
        Me.lblPctTipo.Size = New System.Drawing.Size(248, 25)
        Me.lblPctTipo.TabIndex = 2
        Me.lblPctTipo.Text = "Porcentaje de descuento (*):"
        '
        'txtPorcentajeTipo
        '
        Me.txtPorcentajeTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPorcentajeTipo.Location = New System.Drawing.Point(274, 127)
        Me.txtPorcentajeTipo.MaxLength = 6
        Me.txtPorcentajeTipo.Name = "txtPorcentajeTipo"
        Me.txtPorcentajeTipo.Size = New System.Drawing.Size(90, 30)
        Me.txtPorcentajeTipo.TabIndex = 3
        Me.txtPorcentajeTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPctSufijo
        '
        Me.lblPctSufijo.AutoSize = True
        Me.lblPctSufijo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPctSufijo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPctSufijo.Location = New System.Drawing.Point(395, 127)
        Me.lblPctSufijo.Name = "lblPctSufijo"
        Me.lblPctSufijo.Size = New System.Drawing.Size(29, 28)
        Me.lblPctSufijo.TabIndex = 4
        Me.lblPctSufijo.Text = "%"
        '
        'lblAyudaPct
        '
        Me.lblAyudaPct.AutoSize = True
        Me.lblAyudaPct.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblAyudaPct.ForeColor = System.Drawing.Color.Gray
        Me.lblAyudaPct.Location = New System.Drawing.Point(22, 170)
        Me.lblAyudaPct.Name = "lblAyudaPct"
        Me.lblAyudaPct.Size = New System.Drawing.Size(238, 19)
        Me.lblAyudaPct.TabIndex = 5
        Me.lblAyudaPct.Text = "Rango valido: 1 a 100 (ej: 50 = 50%)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnDarBaja)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Location = New System.Drawing.Point(782, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 348)
        Me.Panel1.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.eliminar_amigo
        Me.btnEliminar.Location = New System.Drawing.Point(15, 279)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(214, 59)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnDarBaja
        '
        Me.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnDarBaja.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.Image = Global.capaPresentacion.My.Resources.Resources.borrar_usuario
        Me.btnDarBaja.Location = New System.Drawing.Point(15, 212)
        Me.btnDarBaja.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(214, 59)
        Me.btnDarBaja.TabIndex = 8
        Me.btnDarBaja.Text = "DAR DE BAJA"
        Me.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDarBaja.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(15, 72)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(214, 59)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(15, 141)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(214, 59)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "ACTUALIZAR"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'frmMantBecas
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1082, 773)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1100, 720)
        Me.Name = "frmMantBecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Matricula - Amancio Varona "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabTipos.ResumeLayout(False)
        Me.pnlIzqTipo.ResumeLayout(False)
        Me.pnlIzqTipo.PerformLayout()
        CType(Me.dgvTiposBeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDerTipo.ResumeLayout(False)
        Me.pnlDerTipo.PerformLayout()
        Me.pnlFormTipo.ResumeLayout(False)
        Me.pnlFormTipo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
End Class
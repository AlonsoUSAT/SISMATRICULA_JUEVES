<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApoderadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñoAcadémicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanDeEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoDeMatrículaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarMatrículaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularMatrículaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsignarVacanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarMensualidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmisiónDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMantenimientoUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.TipoDeDocumentoToolStripMenuItem, Me.EstudianteToolStripMenuItem, Me.ApoderadoToolStripMenuItem, Me.NivelToolStripMenuItem, Me.GradoToolStripMenuItem, Me.SecciónToolStripMenuItem, Me.AñoAcadémicoToolStripMenuItem, Me.PlanDeEstudioToolStripMenuItem, Me.PagoDeMatrículaToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'TipoDeDocumentoToolStripMenuItem
        '
        Me.TipoDeDocumentoToolStripMenuItem.Name = "TipoDeDocumentoToolStripMenuItem"
        Me.TipoDeDocumentoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoDeDocumentoToolStripMenuItem.Text = "Tipo de documento"
        '
        'EstudianteToolStripMenuItem
        '
        Me.EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        Me.EstudianteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EstudianteToolStripMenuItem.Text = "Estudiante"
        '
        'ApoderadoToolStripMenuItem
        '
        Me.ApoderadoToolStripMenuItem.Name = "ApoderadoToolStripMenuItem"
        Me.ApoderadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ApoderadoToolStripMenuItem.Text = "Apoderado"
        '
        'NivelToolStripMenuItem
        '
        Me.NivelToolStripMenuItem.Name = "NivelToolStripMenuItem"
        Me.NivelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NivelToolStripMenuItem.Text = "Nivel"
        '
        'GradoToolStripMenuItem
        '
        Me.GradoToolStripMenuItem.Name = "GradoToolStripMenuItem"
        Me.GradoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GradoToolStripMenuItem.Text = "Grado"
        '
        'SecciónToolStripMenuItem
        '
        Me.SecciónToolStripMenuItem.Name = "SecciónToolStripMenuItem"
        Me.SecciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SecciónToolStripMenuItem.Text = "Sección"
        '
        'AñoAcadémicoToolStripMenuItem
        '
        Me.AñoAcadémicoToolStripMenuItem.Name = "AñoAcadémicoToolStripMenuItem"
        Me.AñoAcadémicoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AñoAcadémicoToolStripMenuItem.Text = "Año Académico"
        '
        'PlanDeEstudioToolStripMenuItem
        '
        Me.PlanDeEstudioToolStripMenuItem.Name = "PlanDeEstudioToolStripMenuItem"
        Me.PlanDeEstudioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PlanDeEstudioToolStripMenuItem.Text = "Plan de Estudio"
        '
        'PagoDeMatrículaToolStripMenuItem
        '
        Me.PagoDeMatrículaToolStripMenuItem.Name = "PagoDeMatrículaToolStripMenuItem"
        Me.PagoDeMatrículaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PagoDeMatrículaToolStripMenuItem.Text = "Pago de Matrícula"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarVacanteToolStripMenuItem, Me.RegistrarMatrículaToolStripMenuItem, Me.AnularMatrículaToolStripMenuItem, Me.ToolStripMenuItem1, Me.RegistrarMensualidadToolStripMenuItem, Me.ToolStripMenuItem2, Me.EmisiónDeToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'RegistrarMatrículaToolStripMenuItem
        '
        Me.RegistrarMatrículaToolStripMenuItem.Name = "RegistrarMatrículaToolStripMenuItem"
        Me.RegistrarMatrículaToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.RegistrarMatrículaToolStripMenuItem.Text = "Registrar Matrícula"
        '
        'AnularMatrículaToolStripMenuItem
        '
        Me.AnularMatrículaToolStripMenuItem.Name = "AnularMatrículaToolStripMenuItem"
        Me.AnularMatrículaToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.AnularMatrículaToolStripMenuItem.Text = "Anular Matrícula"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(260, 6)
        '
        'AsignarVacanteToolStripMenuItem
        '
        Me.AsignarVacanteToolStripMenuItem.Name = "AsignarVacanteToolStripMenuItem"
        Me.AsignarVacanteToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.AsignarVacanteToolStripMenuItem.Text = "Asignar Vacante"
        '
        'RegistrarMensualidadToolStripMenuItem
        '
        Me.RegistrarMensualidadToolStripMenuItem.Name = "RegistrarMensualidadToolStripMenuItem"
        Me.RegistrarMensualidadToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.RegistrarMensualidadToolStripMenuItem.Text = "Registrar Mensualidad"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(260, 6)
        '
        'EmisiónDeToolStripMenuItem
        '
        Me.EmisiónDeToolStripMenuItem.Name = "EmisiónDeToolStripMenuItem"
        Me.EmisiónDeToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.EmisiónDeToolStripMenuItem.Text = "Emisión de Constancia de Matrícula"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMantenimientoUsuario, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 39)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMantenimientoUsuario
        '
        Me.btnMantenimientoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMantenimientoUsuario.Image = CType(resources.GetObject("btnMantenimientoUsuario.Image"), System.Drawing.Image)
        Me.btnMantenimientoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMantenimientoUsuario.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnMantenimientoUsuario.Name = "btnMantenimientoUsuario"
        Me.btnMantenimientoUsuario.Size = New System.Drawing.Size(36, 36)
        Me.btnMantenimientoUsuario.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 535)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.Text = "SISTEMAS DISTRIBUIDOS - APLICACIÓN 2026"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnMantenimientoUsuario As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RegistrarMatrículaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularMatrículaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents AsignarVacanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarMensualidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents EmisiónDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApoderadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NivelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñoAcadémicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanDeEstudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoDeMatrículaToolStripMenuItem As ToolStripMenuItem
End Class

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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñoAcademicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApoderadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsginacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaAcademicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
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
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.TipoDeDocumentoToolStripMenuItem, Me.DocenteToolStripMenuItem, Me.AñoAcademicoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ApoderadoToolStripMenuItem, Me.EstudianteToolStripMenuItem, Me.NGSToolStripMenuItem, Me.AsginacionToolStripMenuItem, Me.CursoToolStripMenuItem, Me.CargaAcademicaToolStripMenuItem, Me.PagoMatriculaToolStripMenuItem, Me.PlanEstudioToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'TipoDeDocumentoToolStripMenuItem
        '
        Me.TipoDeDocumentoToolStripMenuItem.Name = "TipoDeDocumentoToolStripMenuItem"
        Me.TipoDeDocumentoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TipoDeDocumentoToolStripMenuItem.Text = "Tipo de documento"
        '
        'DocenteToolStripMenuItem
        '
        Me.DocenteToolStripMenuItem.Name = "DocenteToolStripMenuItem"
        Me.DocenteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DocenteToolStripMenuItem.Text = "Docente"
        '
        'AñoAcademicoToolStripMenuItem
        '
        Me.AñoAcademicoToolStripMenuItem.Name = "AñoAcademicoToolStripMenuItem"
        Me.AñoAcademicoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AñoAcademicoToolStripMenuItem.Text = "Año Academico"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MantenimientoToolStripMenuItem.Text = "Transaccion"
        '
        'ApoderadoToolStripMenuItem
        '
        Me.ApoderadoToolStripMenuItem.Name = "ApoderadoToolStripMenuItem"
        Me.ApoderadoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ApoderadoToolStripMenuItem.Text = "Apoderado"
        '
        'EstudianteToolStripMenuItem
        '
        Me.EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        Me.EstudianteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EstudianteToolStripMenuItem.Text = "Estudiante"
        '
        'NGSToolStripMenuItem
        '
        Me.NGSToolStripMenuItem.Name = "NGSToolStripMenuItem"
        Me.NGSToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NGSToolStripMenuItem.Text = "NGS"
        '
        'AsginacionToolStripMenuItem
        '
        Me.AsginacionToolStripMenuItem.Name = "AsginacionToolStripMenuItem"
        Me.AsginacionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AsginacionToolStripMenuItem.Text = "Asginacion"
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CursoToolStripMenuItem.Text = "Curso"
        '
        'CargaAcademicaToolStripMenuItem
        '
        Me.CargaAcademicaToolStripMenuItem.Name = "CargaAcademicaToolStripMenuItem"
        Me.CargaAcademicaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CargaAcademicaToolStripMenuItem.Text = "Carga Academica"
        '
        'PagoMatriculaToolStripMenuItem
        '
        Me.PagoMatriculaToolStripMenuItem.Name = "PagoMatriculaToolStripMenuItem"
        Me.PagoMatriculaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PagoMatriculaToolStripMenuItem.Text = "Pago Matricula"
        '
        'PlanEstudioToolStripMenuItem
        '
        Me.PlanEstudioToolStripMenuItem.Name = "PlanEstudioToolStripMenuItem"
        Me.PlanEstudioToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PlanEstudioToolStripMenuItem.Text = "Plan Estudio"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
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
    Friend WithEvents DocenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñoAcademicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApoderadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsginacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaAcademicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanEstudioToolStripMenuItem As ToolStripMenuItem
End Class

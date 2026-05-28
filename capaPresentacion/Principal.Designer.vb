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
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñoAcademicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApoderadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesarMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaAcadémicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaciónTutorAulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DirectAgregarAlumno = New System.Windows.Forms.ToolStripButton()
        Me.DirectProcesarMatricula = New System.Windows.Forms.ToolStripButton()
        Me.DirectCargaAcademica = New System.Windows.Forms.ToolStripButton()
        Me.ConsultarEspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.MantenimientosToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(706, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.cerrar_sesion
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.DocenteToolStripMenuItem, Me.AñoAcademicoToolStripMenuItem, Me.ApoderadoToolStripMenuItem, Me.EstudianteToolStripMenuItem, Me.NGSToolStripMenuItem, Me.CursoToolStripMenuItem, Me.PagoMatriculaToolStripMenuItem, Me.PlanEstudioToolStripMenuItem, Me.EspecialidadToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.usuario
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'DocenteToolStripMenuItem
        '
        Me.DocenteToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.profesor_en_la_pizarra
        Me.DocenteToolStripMenuItem.Name = "DocenteToolStripMenuItem"
        Me.DocenteToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.DocenteToolStripMenuItem.Text = "Docente"
        '
        'AñoAcademicoToolStripMenuItem
        '
        Me.AñoAcademicoToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.academico_anio
        Me.AñoAcademicoToolStripMenuItem.Name = "AñoAcademicoToolStripMenuItem"
        Me.AñoAcademicoToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.AñoAcademicoToolStripMenuItem.Text = "Año Academico"
        '
        'ApoderadoToolStripMenuItem
        '
        Me.ApoderadoToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.apoderado
        Me.ApoderadoToolStripMenuItem.Name = "ApoderadoToolStripMenuItem"
        Me.ApoderadoToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.ApoderadoToolStripMenuItem.Text = "Apoderado"
        '
        'EstudianteToolStripMenuItem
        '
        Me.EstudianteToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.estudiante__2_
        Me.EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        Me.EstudianteToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.EstudianteToolStripMenuItem.Text = "Estudiante"
        '
        'NGSToolStripMenuItem
        '
        Me.NGSToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.escuela
        Me.NGSToolStripMenuItem.Name = "NGSToolStripMenuItem"
        Me.NGSToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.NGSToolStripMenuItem.Text = "Nivel, grado, sección"
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.libro_abierto
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.CursoToolStripMenuItem.Text = "Curso"
        '
        'PagoMatriculaToolStripMenuItem
        '
        Me.PagoMatriculaToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.matricula_pago
        Me.PagoMatriculaToolStripMenuItem.Name = "PagoMatriculaToolStripMenuItem"
        Me.PagoMatriculaToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.PagoMatriculaToolStripMenuItem.Text = "Pago Matricula"
        '
        'PlanEstudioToolStripMenuItem
        '
        Me.PlanEstudioToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.plan_de_estudios
        Me.PlanEstudioToolStripMenuItem.Name = "PlanEstudioToolStripMenuItem"
        Me.PlanEstudioToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.PlanEstudioToolStripMenuItem.Text = "Plan Estudio"
        '
        'EspecialidadToolStripMenuItem
        '
        Me.EspecialidadToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.especialidad
        Me.EspecialidadToolStripMenuItem.Name = "EspecialidadToolStripMenuItem"
        Me.EspecialidadToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.EspecialidadToolStripMenuItem.Text = "Especialidad"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesarMatriculaToolStripMenuItem, Me.CargaAcadémicaToolStripMenuItem, Me.AsignaciónTutorAulaToolStripMenuItem, Me.ConsultarDocenteToolStripMenuItem, Me.ConsultarEstudiantesToolStripMenuItem, Me.ConsultarEspecialidadToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'ProcesarMatriculaToolStripMenuItem
        '
        Me.ProcesarMatriculaToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.procesar_matricula
        Me.ProcesarMatriculaToolStripMenuItem.Name = "ProcesarMatriculaToolStripMenuItem"
        Me.ProcesarMatriculaToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ProcesarMatriculaToolStripMenuItem.Text = "Procesar matricula"
        '
        'CargaAcadémicaToolStripMenuItem
        '
        Me.CargaAcadémicaToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.carga_academica
        Me.CargaAcadémicaToolStripMenuItem.Name = "CargaAcadémicaToolStripMenuItem"
        Me.CargaAcadémicaToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.CargaAcadémicaToolStripMenuItem.Text = "Carga académica"
        '
        'AsignaciónTutorAulaToolStripMenuItem
        '
        Me.AsignaciónTutorAulaToolStripMenuItem.Image = Global.capaPresentacion.My.Resources.Resources.profesor_en_la_pizarra
        Me.AsignaciónTutorAulaToolStripMenuItem.Name = "AsignaciónTutorAulaToolStripMenuItem"
        Me.AsignaciónTutorAulaToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.AsignaciónTutorAulaToolStripMenuItem.Text = "Asignación tutor aula"
        '
        'ConsultarDocenteToolStripMenuItem
        '
        Me.ConsultarDocenteToolStripMenuItem.Name = "ConsultarDocenteToolStripMenuItem"
        Me.ConsultarDocenteToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ConsultarDocenteToolStripMenuItem.Text = "Consultar Docente"
        '
        'ConsultarEstudiantesToolStripMenuItem
        '
        Me.ConsultarEstudiantesToolStripMenuItem.Name = "ConsultarEstudiantesToolStripMenuItem"
        Me.ConsultarEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ConsultarEstudiantesToolStripMenuItem.Text = "Consultar Estudiantes"
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectAgregarAlumno, Me.DirectProcesarMatricula, Me.DirectCargaAcademica})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(706, 39)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DirectAgregarAlumno
        '
        Me.DirectAgregarAlumno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DirectAgregarAlumno.Image = Global.capaPresentacion.My.Resources.Resources.estudiante__1_
        Me.DirectAgregarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DirectAgregarAlumno.Name = "DirectAgregarAlumno"
        Me.DirectAgregarAlumno.Size = New System.Drawing.Size(36, 36)
        Me.DirectAgregarAlumno.Text = "Agregar alumno"
        '
        'DirectProcesarMatricula
        '
        Me.DirectProcesarMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DirectProcesarMatricula.Image = Global.capaPresentacion.My.Resources.Resources.procesar_matricula
        Me.DirectProcesarMatricula.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DirectProcesarMatricula.Name = "DirectProcesarMatricula"
        Me.DirectProcesarMatricula.Size = New System.Drawing.Size(36, 36)
        Me.DirectProcesarMatricula.Text = "Procesar matricula"
        '
        'DirectCargaAcademica
        '
        Me.DirectCargaAcademica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DirectCargaAcademica.Image = Global.capaPresentacion.My.Resources.Resources.carga_academica
        Me.DirectCargaAcademica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DirectCargaAcademica.Name = "DirectCargaAcademica"
        Me.DirectCargaAcademica.Size = New System.Drawing.Size(36, 36)
        Me.DirectCargaAcademica.Text = "Asignar tutor aula"
        '
        'ConsultarEspecialidadToolStripMenuItem
        '
        Me.ConsultarEspecialidadToolStripMenuItem.Name = "ConsultarEspecialidadToolStripMenuItem"
        Me.ConsultarEspecialidadToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ConsultarEspecialidadToolStripMenuItem.Text = "Consultar Especialidad"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.fondo_tuman
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(706, 577)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
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
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DocenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñoAcademicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApoderadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanEstudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesarMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargaAcadémicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectAgregarAlumno As ToolStripButton
    Friend WithEvents DirectProcesarMatricula As ToolStripButton
    Friend WithEvents DirectCargaAcademica As ToolStripButton
    Friend WithEvents AsignaciónTutorAulaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecialidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarDocenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEspecialidadToolStripMenuItem As ToolStripMenuItem
End Class

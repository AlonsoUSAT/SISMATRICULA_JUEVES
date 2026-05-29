Imports System.Windows.Forms

Public Class Principal



    Private Sub btnMantenimientoUsuario_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New frmMantUsuarios()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub


    Private Sub DocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocenteToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantDocente()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub AñoAcademicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñoAcademicoToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantAnoAcademico()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantUsuarios()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New frmTransaccionTutorAula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub ApoderadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApoderadoToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantApoderado()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantEstudiante()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub NGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NGSToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantNGS()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub



    Private Sub TipoDeDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New frmMantTipoDocumento()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub CursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursoToolStripMenuItem.Click
        Dim hijoUsuarios As New frmCurso()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub PagoMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoPagos As New frmMantPagoMatricula()
        hijoPagos.MdiParent = Me
        hijoPagos.Show()
    End Sub

    Private Sub PlanEstudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanEstudioToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantPlanEstudio()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()

    End Sub

    Private Sub ProcesarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New TranMatricula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub CargaAcadémicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaAcadémicaToolStripMenuItem.Click
        Dim selector As New frmSelectorAnio()
        selector.ShowDialog(Me)
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles DirectAgregarAlumno.Click
        Dim hijoUsuarios As New frmMantEstudiante()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles DirectProcesarMatricula.Click
        Dim hijoUsuarios As New TranMatricula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles DirectCargaAcademica.Click
        Dim selector As New frmSelectorAnio()
        selector.ShowDialog(Me)
    End Sub

    Private Sub AsignaciónTutorAulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónTutorAulaToolStripMenuItem.Click
        Dim hijoUsuarios As New frmTransaccionTutorAula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantEspecialidad()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub ConsultarDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarDocenteToolStripMenuItem.Click
        Dim hijoConsultaDocente As New frmConsultaDocente()
        hijoConsultaDocente.MdiParent = Me
        hijoConsultaDocente.Show()
    End Sub

    Private Sub ConsultarEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEstudiantesToolStripMenuItem.Click
        Dim hijoConsultaEstudiante As New frmConsultaEstudiantes()
        hijoConsultaEstudiante.MdiParent = Me
        hijoConsultaEstudiante.Show()
    End Sub

    Private Sub ConsultarEspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEspecialidadToolStripMenuItem.Click
        Dim hijoConsultaEstudiante As New frmConsultaEspecialidad()
        hijoConsultaEstudiante.MdiParent = Me
        hijoConsultaEstudiante.Show()
    End Sub

    Private Sub OperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperacionesToolStripMenuItem.Click

    End Sub

    Private Sub AsignarBecasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarBecasToolStripMenuItem.Click
        Dim hijoAsigBecas As New frmAsigBecas()
        hijoAsigBecas.MdiParent = Me
        hijoAsigBecas.Show()
    End Sub

    Private Sub ConstanciaDeMatrículaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstanciaDeMatrículaToolStripMenuItem.Click
        Dim hijoConstancia As New frmConstanciaMatricula()
        hijoConstancia.MdiParent = Me
        hijoConstancia.Show()
    End Sub

    Private Sub ConsultarTipoDeEstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTipoDeEstudianteToolStripMenuItem.Click
        Dim hijoConsultaTipo As New frmConsultarEstudiantesTipo()
        hijoConsultaTipo.MdiParent = Me
        hijoConsultaTipo.Show()
    End Sub

    Private Sub ConsultarHistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarHistorialToolStripMenuItem.Click
        Dim hijoHistorial As New frmConsultarHistorico()
        hijoHistorial.MdiParent = Me
        hijoHistorial.Show()
    End Sub

    Private Sub GenerarOrdenDelPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarOrdenDelPagoToolStripMenuItem.Click
        Dim frm As New frmGenerarOrdenPago()
        frm.ShowDialog()
    End Sub

    Private Sub ProcesarMatrículaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarMatrículaToolStripMenuItem.Click
        Dim frm As New frmProcesarMatricula()
        frm.ShowDialog()
    End Sub

    Private Sub ConsultarMatrículasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarMatrículasToolStripMenuItem.Click
        Dim hijoUsuarios As New frmConsultaMatriculas()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub MatrículaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New frmMantMatricula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub ConsultarHistorialAcadémicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarHistorialAcadémicoToolStripMenuItem.Click
        Dim hijoUsuarios As New frmHistorialAcademico()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub BecasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BecasToolStripMenuItem.Click
        Dim hijoAsigBecas As New frmAsigBecas()
        hijoAsigBecas.MdiParent = Me
        hijoAsigBecas.Show()
    End Sub

    Private Sub AsignaciónDeCursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónDeCursosToolStripMenuItem.Click
        Dim hijoAsigBecas As New frmCursoGrado()
        hijoAsigBecas.MdiParent = Me
        hijoAsigBecas.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim hijoAsigBecas As New frmApertura()
        hijoAsigBecas.MdiParent = Me
        hijoAsigBecas.Show()
    End Sub

    Private Sub AreaAcadémicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaAcadémicaToolStripMenuItem.Click
        Dim hijoAsigBecas As New frmMantAreaAcademica()
        hijoAsigBecas.MdiParent = Me
        hijoAsigBecas.Show()
    End Sub

    Private Sub CambiarSecciónMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarSecciónMatriculaToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantMatricula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub
End Class

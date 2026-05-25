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

    Private Sub CargaAcademicaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hijoUsuarios As New frmCargaAcademica()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub PagoMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoMatriculaToolStripMenuItem.Click
        Dim hijoPagos As New frmMantPagoMatricula()
        hijoPagos.MdiParent = Me
        hijoPagos.Show()
    End Sub

    Private Sub PlanEstudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanEstudioToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantPlanEstudio()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()

    End Sub

    Private Sub ProcesarMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarMatriculaToolStripMenuItem.Click
        Dim hijoUsuarios As New TranMatricula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub CargaAcadémicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaAcadémicaToolStripMenuItem.Click
        Dim hijoUsuarios As New frmCargaAcademica()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
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
        Dim hijoUsuarios As New frmCargaAcademica()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub AsignaciónTutorAulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónTutorAulaToolStripMenuItem.Click
        Dim hijoUsuarios As New frmTransaccionTutorAula()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub
End Class

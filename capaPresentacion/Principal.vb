Imports System.Windows.Forms

Public Class Principal



    Private Sub btnMantenimientoUsuario_Click(sender As Object, e As EventArgs) Handles btnMantenimientoUsuario.Click
        Dim hijoUsuarios As New frmMantUsuarios()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocenteToolStripMenuItem.Click
        Dim hijoUsuarios As New frmMantDocente()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub
End Class

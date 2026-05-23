Imports System.Windows.Forms

Public Class Principal



    Private Sub btnMantenimientoUsuario_Click(sender As Object, e As EventArgs) Handles btnMantenimientoUsuario.Click
        Dim hijoUsuarios As New frmMantUsuarios()
        hijoUsuarios.MdiParent = Me
        hijoUsuarios.Show()
    End Sub

    Private Sub RegistrarMatrículaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarMatrículaToolStripMenuItem.Click

        Dim frmMatricula As New TranMatricula()


        frmMatricula.ShowDialog()
    End Sub
End Class

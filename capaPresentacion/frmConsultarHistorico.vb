Imports capaLogica

Public Class frmConsultarHistorico

    Dim objLogica As New clsLogMatricula() ' Usa la clase lógica que tenga el ListarNiveles/Anios
    Dim objLogicaReporte As New clsLogMatricula()
    Private Sub frmConsultarHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Cambiamos objLogica por objLogicaReporte si es ahí donde pertenece el método
            cboAnioAcademico.DataSource = objLogicaReporte.MostrarAnosAcademicos()

            ' 2. Apuntamos a los campos correctos del script de Tocto
            cboAnioAcademico.DisplayMember = "Periodo"
            cboAnioAcademico.ValueMember = "id_anoAcademico"

            cboAnioAcademico.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error inicial: " & ex.Message)
        End Try
        dgvHistorico.AllowUserToAddRows = False
    End Sub

    Private Sub cboAnioAcademico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAnioAcademico.SelectedIndexChanged
        If cboAnioAcademico.SelectedIndex = -1 Then Return

        Dim idAno As Integer
        If Integer.TryParse(cboAnioAcademico.SelectedValue.ToString(), idAno) Then
            dgvHistorico.DataSource = objLogicaReporte.ListarHistoricoCarga(idAno)
        End If
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
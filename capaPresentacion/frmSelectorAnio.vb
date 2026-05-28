Imports capaLogica

Public Class frmSelectorAnio
    Dim objLogica As New clCargaAcademica()

    Private Sub frmSelectorAnio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAnios()
    End Sub

    Private Sub CargarAnios()
        Try
            Dim dt As DataTable = objLogica.MostrarAniosAcademicos()
            cboAnios.Items.Clear()
            lblAnoActivo.Text = "Año activo: —"

            For Each fila As DataRow In dt.Rows
                Dim activo As Boolean = Convert.ToBoolean(fila("estado"))
                Dim fechaInicio As DateTime = Convert.ToDateTime(fila("fechaInicio"))
                Dim fechaFin As DateTime = Convert.ToDateTime(fila("fechaFin"))
                Dim nombreAnio As String = fechaInicio.Year.ToString() &
                    " (" & fechaInicio.ToString("dd/MM/yyyy") &
                    " - " & fechaFin.ToString("dd/MM/yyyy") & ")"

                Dim item As New AnoItem(
                    Convert.ToInt32(fila("id_anoAcademico")),
                    nombreAnio,
                    activo
                )
                cboAnios.Items.Add(item)

                If activo Then
                    lblAnoActivo.Text = "Año activo: " & nombreAnio
                    cboAnios.SelectedItem = item
                End If
            Next

            If cboAnios.SelectedIndex = -1 AndAlso cboAnios.Items.Count > 0 Then
                cboAnios.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar años: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If cboAnios.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona un año académico.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim seleccionado As AnoItem = CType(cboAnios.SelectedItem, AnoItem)
        ModuloSesion.idAnoAcademicoActivo = seleccionado.Id
        ModuloSesion.nombreAnoActivo = seleccionado.Nombre

        Dim frm As New frmCargaAcademica()
        frm.MdiParent = My.Application.OpenForms("Principal")
        frm.Show()
        Me.Close()
    End Sub
End Class

Public Class AnoItem
    Public Id As Integer
    Public Nombre As String
    Public Activo As Boolean

    Public Sub New(id As Integer, nombre As String, activo As Boolean)
        Me.Id = id
        Me.Nombre = nombre
        Me.Activo = activo
    End Sub

    Public Overrides Function ToString() As String
        If Activo Then
            Return Nombre & "   ✓ activo"
        Else
            Return Nombre
        End If
    End Function
End Class
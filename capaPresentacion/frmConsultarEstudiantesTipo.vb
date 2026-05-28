Imports capaLogica

Public Class frmConsultarEstudiantesTipo
    Dim objLogicaReporte As New clsLogReportes()
    Private cargando As Boolean = True

    Private Sub frmConsultarEstudiantesTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargando = True

            ' Llenamos el ComboBox con los estados exactos que lee la BD
            cboTipo.Items.Clear()
            cboTipo.Items.Add("TODOS")
            cboTipo.Items.Add("REGULAR")
            cboTipo.Items.Add("BECADO")

            ' Dejamos "TODOS" seleccionado al arrancar
            cboTipo.SelectedIndex = 0

            cargando = False
            RefrescarTabla()
        Catch ex As Exception
            MsgBox("Error al inicializar filtros: " & ex.Message)
        End Try
        dgvEstudiantesTipo.AllowUserToAddRows = False
    End Sub

    ' Método centralizado que actualiza la grilla en tiempo real
    Private Sub RefrescarTabla()
        If cargando Then Return

        Dim filtro As String = cboTipo.Text.Trim().ToUpper()

        Try
            dgvEstudiantesTipo.DataSource = objLogicaReporte.ListarEstudiantesPorTipo(filtro)
        Catch ex As Exception
            MsgBox("Error en búsqueda: " & ex.Message)
        End Try
    End Sub

    ' 🌟 EVENTO: Cada vez que cambien el combo, la tabla se filtra sola sin botones extras
    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        RefrescarTabla()
    End Sub

    ' Botón rápido de reset
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cargando = True
        cboTipo.SelectedIndex = 0
        cargando = False
        RefrescarTabla()
    End Sub
End Class
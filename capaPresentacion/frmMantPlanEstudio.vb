Imports System.Data
Imports capaLogica
Imports capaLogica.capaLogica

Public Class frmMantPlanEstudio
    Private ReadOnly objLogica As New clsLogPlanEstudio()

    ' EVENTO: Cuando carga el formulario
    Private Sub frmMantPlanEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarGrilla()
        LimpiarCampos()
        dgvAnos.AllowUserToAddRows = False
    End Sub

    ' MÉTODO AUXILIAR: Llenar la grilla
    Private Sub ListarGrilla()
        Try
            dgvAnos.DataSource = objLogica.Listar()
        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LimpiarCampos()
        Try
            txtCodigo.Text = objLogica.ObtenerSiguienteId().ToString()
            txtCodigo.ReadOnly = True
        Catch ex As Exception
            txtCodigo.Text = ""
        End Try

        dtpFechaInicio.Value = Now
        chkEstado.Checked = True
    End Sub

    ' BOTÓN: NUEVO / GUARDAR
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If objLogica.Guardar(dtpFechaInicio.Value.Date, chkEstado.Checked) Then
                MsgBox("Plan de Estudio registrado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un registro de la lista primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            If objLogica.Modificar(id, dtpFechaInicio.Value.Date, chkEstado.Checked) Then
                MsgBox("Plan de Estudio actualizado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un registro de la lista primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            If MsgBox("¿Está seguro que desea dar de baja este Plan de Estudio?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar") = MsgBoxResult.Yes Then
                If objLogica.DarDeBaja(id) Then
                    MsgBox("Plan de Estudio dado de baja.", MsgBoxStyle.Information, "Éxito")
                    ListarGrilla()
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    ' BOTÓN: LIMPIAR
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' SELECCIONAR FILA DE LA GRILLA
    Private Sub dgvAnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvAnos.Rows(e.RowIndex)
            ' Asignamos los datos a los controles
            txtCodigo.Text = fila.Cells("id_planEstudio").Value.ToString()
            dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells("año").Value)
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("estado").Value)
        End If
    End Sub

End Class
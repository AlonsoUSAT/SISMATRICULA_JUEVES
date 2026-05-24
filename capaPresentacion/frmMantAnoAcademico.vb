Imports capaLogica

Public Class frmMantAnoAcademico
    Dim objLogica As New clsLogAnoAcademico()

    ' EVENTO: Cuando carga el formulario
    Private Sub frmMantAnoAcademico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.GetType() IsNot GetType(frmMantAnoAcademico) Then Return

        ListarGrilla()
    End Sub

    ' MÉTODO AUXILIAR: Llenar la grilla con datos
    Private Sub ListarGrilla()
        Try
            dgvAnos.DataSource = objLogica.Listar()
        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    ' MÉTODO AUXILIAR: Limpiar las cajas de texto y restaurar valores por defecto
    Private Sub LimpiarCampos()
        txtCodigo.Clear()
        dtpFechaInicio.Value = Now
        dtpFechaFin.Value = Now
        chkEstado.Checked = True
    End Sub

    ' BOTÓN: NUEVO (Guardar)
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Me.GetType() IsNot GetType(frmMantAnoAcademico) Then Return
        Try
            If objLogica.Guardar(dtpFechaInicio.Value, dtpFechaFin.Value) Then
                MsgBox("Año Académico registrado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    ' BOTÓN: ACTUALIZAR
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un registro de la lista inferior primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            If objLogica.Modificar(id, dtpFechaInicio.Value, dtpFechaFin.Value, chkEstado.Checked) Then
                MsgBox("Año Académico actualizado correctamente.", MsgBoxStyle.Information, "Éxito")
                ListarGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    ' BOTÓN: DAR DE BAJA
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Seleccione un registro de la lista inferior primero.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If

            Dim id As Integer = CInt(txtCodigo.Text)
            ' Pedimos confirmación antes de dar de baja
            If MsgBox("¿Está seguro que desea dar de baja este año académico?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar") = MsgBoxResult.Yes Then
                If objLogica.DarDeBaja(id) Then
                    MsgBox("Año Académico dado de baja correctamente.", MsgBoxStyle.Information, "Éxito")
                    ListarGrilla()
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    ' BOTÓN: LIMPIAR CAMPOS
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' EVENTO: Seleccionar la fila para cargar los datos
    Private Sub dgvAnosAcademicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnos.CellClick
        ' Validamos que el clic sea en una fila válida y no en los encabezados
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvAnos.Rows(e.RowIndex)

            ' Pasamos los datos de la fila a los controles de la interfaz
            txtCodigo.Text = fila.Cells("id_planEstudio").Value.ToString()
            dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells("fechaInicio").Value)
            dtpFechaFin.Value = Convert.ToDateTime(fila.Cells("fechaFin").Value)
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("estado").Value)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
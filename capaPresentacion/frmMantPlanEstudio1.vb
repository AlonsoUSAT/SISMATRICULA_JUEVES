Imports capaLogica

Public Class frmMantPlanEstudio1
    ' Instanciamos la clase lógica de Plan de Estudio
    Dim objLogica As New clsLogPlanEstudio()

    ' EVENTO: Cuando carga el formulario
    Private Sub frmMantPlanEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarGrilla()
    End Sub

    ' MÉTODO AUXILIAR: Llenar la grilla
    Private Sub ListarGrilla()
        Try
            dgvAnos.DataSource = objLogica.Listar()
        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' MÉTODO AUXILIAR: Limpiar campos
    Private Sub LimpiarCampos()
        txtCodigo.Clear()
        ' Usamos el nombre original del DateTimePicker
        dtpFechaInicio.Value = Now
        chkEstado.Checked = True
    End Sub

    ' BOTÓN: NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            ' Pasamos solo la fecha del dtpFechaInicio, ya que representa nuestro "Año"
            If objLogica.Guardar(dtpFechaInicio.Value.Date) Then
                MsgBox("Plan de Estudio registrado correctamente.", MsgBoxStyle.Information, "Éxito")
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

    ' BOTÓN: DAR DE BAJA
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("Ingrese un ID para buscar.", MsgBoxStyle.Exclamation, "Atención")
                Return
            End If
            Dim resultado As DataTable = objLogica.Buscar(CInt(txtCodigo.Text))
            If resultado.Rows.Count > 0 Then
                dgvAnos.DataSource = resultado
                Dim fila As DataGridViewRow = dgvAnos.Rows(0)
                txtCodigo.ReadOnly = False
                txtCodigo.Text = fila.Cells("id_planEstudio").Value.ToString()
                txtCodigo.ReadOnly = True
                dtpFechaInicio.Value = New DateTime(Convert.ToInt32(fila.Cells("año").Value), 1, 1)
                chkEstado.Checked = Convert.ToBoolean(fila.Cells("vigencia").Value)
            Else
                MsgBox("No se encontró ningún Plan de Estudio con ese ID.", MsgBoxStyle.Information, "Sin resultados")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
        End Try
    End Sub

    Private Sub dgvAnosAcademicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvAnos.Rows(e.RowIndex)
            ' Asignamos los datos a los controles heredados
            txtCodigo.ReadOnly = False
            txtCodigo.Text = fila.Cells("id_planEstudio").Value.ToString()
            txtCodigo.ReadOnly = True
            dtpFechaInicio.Value = New DateTime(Convert.ToInt32(fila.Cells("año").Value), 1, 1)
            chkEstado.Checked = Convert.ToBoolean(fila.Cells("vigencia").Value)
        End If
    End Sub



End Class

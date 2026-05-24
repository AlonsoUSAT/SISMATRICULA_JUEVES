Imports capaLogica
Imports System.Data

Public Class frmMantTipoDocumento

    Private objLogica As New capaLogica.clsTipoDocumento()
    Private idTipo As Integer = 0
    Private editar As Boolean = False
    Private listoParaGuardar As Boolean = False

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════
    Private Sub frmMantTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDocumentos()
        RestablecerEstadoInicial()
    End Sub

    ' ══════════════════════════════════════════════
    '  MOSTRAR TABLA
    ' ══════════════════════════════════════════════
    Private Sub MostrarDocumentos()
        Try
            tablaTipoDocumento.DataSource = objLogica.MostrarDocumentos()
            If tablaTipoDocumento.Columns.Contains("id_tipoDocumento") Then
                tablaTipoDocumento.Columns("id_tipoDocumento").Visible = False
            End If
            If tablaTipoDocumento.Columns.Contains("nombreTipoDocumento") Then
                tablaTipoDocumento.Columns("nombreTipoDocumento").HeaderText = "Tipo de Documento"
            End If
            If tablaTipoDocumento.Columns.Contains("estado") Then
                tablaTipoDocumento.Columns("estado").HeaderText = "Activo"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  ESTADO INICIAL: campos bloqueados, botón = "Nuevo"
    ' ══════════════════════════════════════════════
    Private Sub RestablecerEstadoInicial()
        txtID.Text = ""
        txtID.ReadOnly = False
        txtID.BackColor = Color.White
        txtTipoDocumento.Clear()
        txtTipoDocumento.Enabled = False
        checkVigencia.Checked = True
        checkVigencia.Enabled = False
        idTipo = 0
        editar = False
        listoParaGuardar = False
        btnGuardar.Text = "Nuevo"
    End Sub

    ' ══════════════════════════════════════════════
    '  HABILITAR FORMULARIO PARA ESCRIBIR
    ' ══════════════════════════════════════════════
    Private Sub HabilitarFormulario()
        txtTipoDocumento.Enabled = True
        checkVigencia.Enabled = True
        listoParaGuardar = True
        btnGuardar.Text = "Guardar"

        ' Si es modo nuevo, mostrar el siguiente ID automático y bloquearlo
        If Not editar Then
            Try
                txtID.Text = objLogica.ObtenerSiguienteID().ToString()
                txtID.ReadOnly = True
                txtID.BackColor = Color.LightGray
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' En modo edición el ID viene del registro, también bloqueado
            txtID.ReadOnly = True
            txtID.BackColor = Color.LightGray
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO / GUARDAR (dual)
    ' ══════════════════════════════════════════════
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' ── Modo "Nuevo": preparar formulario ──
        If Not listoParaGuardar Then
            editar = False
            HabilitarFormulario()
            txtTipoDocumento.Focus()
            Return
        End If

        ' ── Modo "Guardar": insertar o actualizar ──
        Try
            Dim tipoDoc As String = txtTipoDocumento.Text.Trim()
            Dim vigencia As Boolean = checkVigencia.Checked

            If editar Then
                Dim confirm As DialogResult = MessageBox.Show(
                    "¿Desea actualizar este registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                objLogica.EditarDocumento(idTipo, tipoDoc, vigencia)
                MessageBox.Show("Actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim confirm As DialogResult = MessageBox.Show(
                    "¿Desea guardar el nuevo registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                objLogica.InsertarDocumento(tipoDoc, vigencia)
                MessageBox.Show("Guardado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            MostrarDocumentos()
            RestablecerEstadoInicial()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN BUSCAR
    ' ══════════════════════════════════════════════
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim idBuscar As Integer
            If Not Integer.TryParse(txtID.Text.Trim(), idBuscar) OrElse idBuscar <= 0 Then
                MessageBox.Show("Ingrese un código numérico válido para buscar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim dt As DataTable = objLogica.BuscarPorID(idBuscar)
            Dim fila As DataRow = dt.Rows(0)

            idTipo = CInt(fila("id_tipoDocumento"))
            txtID.Text = idTipo.ToString()
            txtTipoDocumento.Text = fila("nombreTipoDocumento").ToString()

            Dim estadoVal = fila("estado")
            checkVigencia.Checked = If(IsDBNull(estadoVal), False, Convert.ToBoolean(estadoVal))

            editar = True
            HabilitarFormulario()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CLICK EN FILA DE LA TABLA → cargar para editar
    ' ══════════════════════════════════════════════
    Private Sub tablaTipoDocumento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaTipoDocumento.CellClick
        If e.RowIndex >= 0 Then
            Try
                idTipo = CInt(tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value)
                txtID.Text = idTipo.ToString()
                txtTipoDocumento.Text = tablaTipoDocumento.CurrentRow.Cells("nombreTipoDocumento").Value.ToString()

                Dim estadoVal = tablaTipoDocumento.CurrentRow.Cells("estado").Value
                checkVigencia.Checked = If(IsDBNull(estadoVal), False, Convert.ToBoolean(estadoVal))

                editar = True
                HabilitarFormulario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ELIMINAR
    ' ══════════════════════════════════════════════
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idTipo <= 0 Then
            MessageBox.Show("Seleccione un registro de la tabla para eliminar.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "¿Desea eliminar este tipo de documento?", "Confirmar eliminación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then Return

        Try
            objLogica.EliminarDocumento(idTipo)
            MessageBox.Show("Eliminado con éxito.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarDocumentos()
            RestablecerEstadoInicial()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN DAR DE BAJA
    ' ══════════════════════════════════════════════
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If idTipo <= 0 Then
            MessageBox.Show("Seleccione un registro de la tabla para dar de baja.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "¿Desea dar de baja este registro? El estado cambiará a inactivo.",
            "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Try
            objLogica.DarBajaDocumento(idTipo)
            MessageBox.Show("Registro dado de baja correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarDocumentos()
            RestablecerEstadoInicial()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ACTUALIZAR (carga fila seleccionada)
    ' ══════════════════════════════════════════════
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If tablaTipoDocumento.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una fila de la tabla para editar.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            idTipo = CInt(tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value)
            txtID.Text = idTipo.ToString()
            txtTipoDocumento.Text = tablaTipoDocumento.CurrentRow.Cells("nombreTipoDocumento").Value.ToString()

            Dim estadoVal = tablaTipoDocumento.CurrentRow.Cells("estado").Value
            checkVigencia.Checked = If(IsDBNull(estadoVal), False, Convert.ToBoolean(estadoVal))

            editar = True
            HabilitarFormulario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
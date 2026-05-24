Imports capaLogica
Imports System.Data

Public Class frmTransaccionTutorAula

    Dim objTutor As New clsTutorAula()
    Dim idSeleccionado As Integer = 0

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════
    Private Sub frmTransaccionTutorAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        LimpiarCampos()
    End Sub

    ' ══════════════════════════════════════════════
    '  CARGAR GRID
    ' ══════════════════════════════════════════════
    Private Sub CargarGrid()
        Try
            tblAsignacion.DataSource = objTutor.MostrarTutores()
            tblAsignacion.AutoGenerateColumns = True

            ' Ocultar columnas técnicas que el usuario no necesita ver
            If tblAsignacion.Columns.Contains("id_docente") Then
                tblAsignacion.Columns("id_docente").Visible = False
            End If
            If tblAsignacion.Columns.Contains("id_seccion") Then
                tblAsignacion.Columns("id_seccion").Visible = False
            End If

            ' Renombrar encabezados para que se lean bien
            If tblAsignacion.Columns.Contains("id_tutor") Then
                tblAsignacion.Columns("id_tutor").HeaderText = "Código"
            End If
            If tblAsignacion.Columns.Contains("NombreDocente") Then
                tblAsignacion.Columns("NombreDocente").HeaderText = "Docente"
            End If
            If tblAsignacion.Columns.Contains("NombreSeccion") Then
                tblAsignacion.Columns("NombreSeccion").HeaderText = "Sección"
            End If
            If tblAsignacion.Columns.Contains("estado") Then
                tblAsignacion.Columns("estado").HeaderText = "Activo"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CARGAR COMBOS
    ' ══════════════════════════════════════════════
    Private Sub CargarComboDocentes()
        Try
            Dim dt As DataTable = objTutor.ListarDocentes()
            cboDocente.DataSource = dt
            cboDocente.DisplayMember = "NombreCompleto"
            cboDocente.ValueMember = "id_docente"
            cboDocente.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboSecciones()
        Try
            Dim dt As DataTable = objTutor.ListarSecciones()
            cboSeccion.DataSource = dt
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  LIMPIAR CAMPOS Y ESTADO DE BOTONES
    ' ══════════════════════════════════════════════
    Private Sub LimpiarCampos()
        txtCodigo.Text = ""
        txtCodigo.ReadOnly = False

        cboDocente.DataSource = Nothing
        cboDocente.Items.Clear()

        cboSeccion.DataSource = Nothing
        cboSeccion.Items.Clear()

        checkEstado.Checked = True
        idSeleccionado = 0

        ' Solo Nuevo y Limpiar habilitados al inicio
        btnNuevo.Enabled = True
        btnActualizar.Enabled = False
        btnActualizar.Text = "Actualizar"
        btnEliminar.Enabled = False
        btnDarBaja.Enabled = False
        btnAgregarDocente.Enabled = False
        btnAgregarSeccion.Enabled = False
    End Sub

    Private Sub HabilitarModoEdicion()
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
        btnDarBaja.Enabled = True
        btnAgregarDocente.Enabled = True
        btnAgregarSeccion.Enabled = True
    End Sub

    Private Sub HabilitarModoNuevo()
        btnActualizar.Enabled = True    ' ← Debe estar habilitado para poder insertar
        btnEliminar.Enabled = False
        btnDarBaja.Enabled = False
        btnAgregarDocente.Enabled = True
        btnAgregarSeccion.Enabled = True
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO
    ' ══════════════════════════════════════════════
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            idSeleccionado = 0
            txtCodigo.ReadOnly = True
            txtCodigo.Text = objTutor.ObtenerSiguienteID().ToString()
            CargarComboDocentes()


            CargarComboSecciones()
            checkEstado.Checked = True
            HabilitarModoNuevo()
            btnActualizar.Text = "Guardar"


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
            If Not Integer.TryParse(txtCodigo.Text.Trim(), idBuscar) OrElse idBuscar <= 0 Then
                MessageBox.Show("Ingrese un código numérico válido para buscar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim dt As DataTable = objTutor.BuscarPorID(idBuscar)
            Dim fila As DataRow = dt.Rows(0)

            idSeleccionado = CInt(fila("id_tutor"))

            CargarComboDocentes()
            CargarComboSecciones()

            cboDocente.SelectedValue = CInt(fila("id_docente"))
            cboSeccion.SelectedValue = CInt(fila("id_seccion"))
            checkEstado.Checked = CBool(fila("estado"))

            HabilitarModoEdicion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO → GUARDAR (insertar)
    '  Reutilizamos btnNuevo como disparador;
    '  el guardado ocurre con btnActualizar en modo nuevo
    '  NO — usamos un botón implícito: cuando idSeleccionado=0
    '  el btnActualizar actúa como Guardar.
    '
    '  NOTA: Si en tu form tienes un botón "Guardar" separado,
    '  renómbralo y conecta este handler. Si no, el flujo es:
    '  btnNuevo rellena el form → usuario llena combos
    '  → btnActualizar detecta idSeleccionado=0 → inserta.
    ' ══════════════════════════════════════════════

    ' ══════════════════════════════════════════════
    '  BOTÓN ACTUALIZAR (también guarda si es nuevo)
    ' ══════════════════════════════════════════════
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If cboDocente.SelectedIndex = -1 OrElse IsNothing(cboDocente.SelectedValue) Then
                MessageBox.Show("Debe seleccionar un docente.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If cboSeccion.SelectedIndex = -1 OrElse IsNothing(cboSeccion.SelectedValue) Then
                MessageBox.Show("Debe seleccionar una sección.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idDoc As Integer = CInt(cboDocente.SelectedValue)
            Dim idSec As Integer = CInt(cboSeccion.SelectedValue)
            Dim estado As Boolean = checkEstado.Checked

            If idSeleccionado = 0 Then
                ' ── MODO NUEVO: insertar ──
                Dim confirm As DialogResult = MessageBox.Show(
                    "¿Desea guardar el nuevo registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                objTutor.Insertar(idDoc, idSec, estado)
                MessageBox.Show("Registro guardado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' ── MODO EDICIÓN: actualizar ──
                Dim confirm As DialogResult = MessageBox.Show(
                    "¿Desea actualizar este registro?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                objTutor.Actualizar(idSeleccionado, idDoc, idSec, estado)
                MessageBox.Show("Registro actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarGrid()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ELIMINAR
    ' ══════════════════════════════════════════════
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If idSeleccionado <= 0 Then
                MessageBox.Show("Primero busque un registro para eliminar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirm As DialogResult = MessageBox.Show(
                "¿Está seguro de eliminar este registro?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.No Then Return

            objTutor.Eliminar(idSeleccionado)
            MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrid()
            LimpiarCampos()

        Catch ex As Exception
            ' Si la BD rechaza por FK, se hace baja lógica automática
            If ex.Message.Contains("REFERENCE") OrElse ex.Message.Contains("FK") OrElse
               ex.Message.Contains("FOREIGN") Then
                Dim aviso As DialogResult = MessageBox.Show(
                    "El registro tiene dependencias y no puede eliminarse físicamente." &
                    Environment.NewLine & "¿Desea dar de baja en su lugar?",
                    "No se puede eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If aviso = DialogResult.Yes Then
                    Try
                        objTutor.DarBaja(idSeleccionado)
                        MessageBox.Show("Se dio de baja al registro correctamente.", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarGrid()
                        LimpiarCampos()
                    Catch ex2 As Exception
                        MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN DAR DE BAJA
    ' ══════════════════════════════════════════════
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If idSeleccionado <= 0 Then
                MessageBox.Show("Primero busque un registro para dar de baja.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirm As DialogResult = MessageBox.Show(
                "¿Desea dar de baja este registro? El estado cambiará a inactivo.",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.No Then Return

            objTutor.DarBaja(idSeleccionado)
            MessageBox.Show("Registro dado de baja correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarGrid()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN LIMPIAR
    ' ══════════════════════════════════════════════
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN "+" DOCENTE → abre frmMantDocente
    ' ══════════════════════════════════════════════
    Private Sub btnAgregarDocente_Click(sender As Object, e As EventArgs) Handles btnAgregarDocente.Click
        Dim frm As New frmMantDocente()
        frm.ShowDialog()
        CargarComboDocentes()
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN "+" SECCIÓN → abre frmMantSeccion
    ' ══════════════════════════════════════════════
    Private Sub btnAgregarSeccion_Click(sender As Object, e As EventArgs) Handles btnAgregarSeccion.Click
        Dim frm As New frmMantNGS()
        frm.ShowDialog()
        CargarComboSecciones()   ' ← Agrega esta línea
    End Sub

End Class
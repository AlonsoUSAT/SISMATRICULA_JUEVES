Imports capaLogica
<<<<<<< HEAD
Imports System.Data

Public Class frmMantDocente
    Private objLogica As New capaLogica.clsDocente()
    Private idDocente As Integer = 0
    Private idPersonaActual As Integer = 0
    Private modoNuevo As Boolean = False
    Private modoEditar As Boolean = False

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════
    Private Sub frmMantDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MostrarDocentes()
            EstadoInicial()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  HELPERS PRIVADOS
    ' ══════════════════════════════════════════════

    Private Sub CargarComboPersonas(Optional idPersonaActualParam As Integer = 0)
        Try
            Dim tabla As DataTable

            If idPersonaActualParam > 0 Then
                tabla = objLogica.ObtenerPersonasParaEdicion(idPersonaActualParam)
            Else
                tabla = objLogica.ObtenerPersonas()
            End If

            cboPersona.DataSource = tabla
            cboPersona.DisplayMember = "nombreCompleto"
            cboPersona.ValueMember = "id_persona"
            cboPersona.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar personas en el listado: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarDocentes()
        Try
            tblDocente.DataSource = objLogica.MostrarDocentes()
            AjustarColumnas()
        Catch ex As Exception
            MessageBox.Show("Error al mostrar docentes: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AjustarColumnas()
        Try
            If tblDocente.Columns.Count = 0 Then Exit Sub

            ' Ocultar columna técnica
            If tblDocente.Columns.Contains("id_persona") Then
                tblDocente.Columns("id_persona").Visible = False
            End If

            ' Renombrar cabeceras
            If tblDocente.Columns.Contains("id_docente") Then tblDocente.Columns("id_docente").HeaderText = "ID"
            If tblDocente.Columns.Contains("nombre") Then tblDocente.Columns("nombre").HeaderText = "Nombres"
            If tblDocente.Columns.Contains("apePaterno") Then tblDocente.Columns("apePaterno").HeaderText = "Ap. Paterno"
            If tblDocente.Columns.Contains("apeMaterno") Then tblDocente.Columns("apeMaterno").HeaderText = "Ap. Materno"
            If tblDocente.Columns.Contains("especialidad") Then tblDocente.Columns("especialidad").HeaderText = "Especialidad"
            If tblDocente.Columns.Contains("telefono") Then tblDocente.Columns("telefono").HeaderText = "Teléfono"
            If tblDocente.Columns.Contains("correo") Then tblDocente.Columns("correo").HeaderText = "Correo"
            If tblDocente.Columns.Contains("sexo") Then tblDocente.Columns("sexo").HeaderText = "Sexo"
            If tblDocente.Columns.Contains("estado") Then tblDocente.Columns("estado").HeaderText = "Vigente"
        Catch ex As Exception
            ' No es crítico si falla el ajuste visual de columnas
        End Try
    End Sub

    Private Sub EstadoInicial()
        ' ── Limpiar campos ──
        txtIdDocente.Clear()
        txtEspecialidad.Clear()
        checkEstado.Checked = False
        cboPersona.DataSource = Nothing
        cboPersona.SelectedIndex = -1

        ' ── Deshabilitar todos los campos de entrada ──
        txtIdDocente.Enabled = False
        txtIdDocente.BackColor = Color.WhiteSmoke
        txtIdDocente.ReadOnly = True

        txtEspecialidad.ReadOnly = True
        txtEspecialidad.BackColor = Color.WhiteSmoke

        cboPersona.Enabled = False
        checkEstado.Enabled = False

        ' ── Resetear botones ──
        btnNuevo.Text = "Nuevo"
        btnNuevo.BackColor = Color.SteelBlue
        btnActualizar.Text = "Actualizar"
        btnActualizar.BackColor = Color.FromArgb(70, 130, 180)

        ' ── Resetear variables de control ──
        modoNuevo = False
        modoEditar = False
        idDocente = 0
        idPersonaActual = 0
    End Sub

    Private Sub HabilitarCampos(habilitar As Boolean)
        txtEspecialidad.ReadOnly = Not habilitar
        txtEspecialidad.BackColor = If(habilitar, Color.White, Color.WhiteSmoke)
        cboPersona.Enabled = habilitar
        checkEstado.Enabled = habilitar
    End Sub

    Private Function ObtenerIdPersonaSeleccionada() As Integer
        Try
            If cboPersona.SelectedValue Is Nothing OrElse
               IsDBNull(cboPersona.SelectedValue) OrElse
               cboPersona.SelectedIndex = -1 Then
                Return -1
            End If
            Return CInt(cboPersona.SelectedValue)
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Function CamposObligatoriosLlenos() As Boolean
        If String.IsNullOrWhiteSpace(txtEspecialidad.Text) Then
            MessageBox.Show("El campo 'Especialidad' es obligatorio.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEspecialidad.Focus()
            Return False
        End If
        If ObtenerIdPersonaSeleccionada() <= 0 Then
            MessageBox.Show("Debe seleccionar una persona del listado.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPersona.Focus()
            Return False
        End If
        Return True
    End Function

    ' Lectura segura de celdas que pueden contener DBNull
    Private Function LeerCeldaSegura(fila As DataGridViewRow, nombreColumna As String,
                                     Optional valorDefault As String = "") As String
        Try
            If fila.Cells(nombreColumna).Value Is Nothing OrElse
               IsDBNull(fila.Cells(nombreColumna).Value) Then
                Return valorDefault
            End If
            Return fila.Cells(nombreColumna).Value.ToString()
        Catch ex As Exception
            Return valorDefault
        End Try
    End Function

    Private Function LeerBooleanoSeguro(fila As DataGridViewRow, nombreColumna As String,
                                        Optional valorDefault As Boolean = False) As Boolean
        Try
            If fila.Cells(nombreColumna).Value Is Nothing OrElse
               IsDBNull(fila.Cells(nombreColumna).Value) Then
                Return valorDefault
            End If
            Return Convert.ToBoolean(fila.Cells(nombreColumna).Value)
        Catch ex As Exception
            Return valorDefault
        End Try
    End Function

    Private Function LeerEnteroSeguro(fila As DataGridViewRow, nombreColumna As String,
                                      Optional valorDefault As Integer = 0) As Integer
        Try
            If fila.Cells(nombreColumna).Value Is Nothing OrElse
               IsDBNull(fila.Cells(nombreColumna).Value) Then
                Return valorDefault
            End If
            Return Convert.ToInt32(fila.Cells(nombreColumna).Value)
        Catch ex As Exception
            Return valorDefault
        End Try
    End Function

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO / GUARDAR
    ' ══════════════════════════════════════════════
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If Not modoNuevo Then
                ' ── Activar modo NUEVO ──
                EstadoInicial()

                txtIdDocente.Text = objLogica.ObtenerSiguienteID().ToString()
                txtIdDocente.Enabled = True
                txtIdDocente.BackColor = Color.WhiteSmoke  ' Visible pero no editable

                CargarComboPersonas()
                HabilitarCampos(True)
                checkEstado.Checked = True
                txtEspecialidad.Focus()

                btnNuevo.Text = "Guardar"
                btnNuevo.BackColor = Color.SeaGreen
                modoNuevo = True
                modoEditar = False
            Else
                ' ── Modo GUARDAR ──
                If Not CamposObligatoriosLlenos() Then Exit Sub

                objLogica.InsertarDocente(
                    txtEspecialidad.Text.Trim(),
                    ObtenerIdPersonaSeleccionada(),
                    checkEstado.Checked
                )

                MessageBox.Show("Docente registrado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarDocentes()
                EstadoInicial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al guardar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ACTUALIZAR / CONFIRMAR
    ' ══════════════════════════════════════════════
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If Not modoEditar Then
                ' ── Primer clic: cargar datos del docente seleccionado ──
                If tblDocente.SelectedRows.Count = 0 Then
                    MessageBox.Show("Seleccione un docente de la tabla para actualizar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim fila As DataGridViewRow = tblDocente.CurrentRow
                idDocente = LeerEnteroSeguro(fila, "id_docente")
                idPersonaActual = LeerEnteroSeguro(fila, "id_persona")

                If idDocente = 0 Then
                    MessageBox.Show("No se pudo obtener el ID del docente seleccionado.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                txtIdDocente.Text = idDocente.ToString()
                txtIdDocente.Enabled = True
                txtIdDocente.BackColor = Color.WhiteSmoke
                txtIdDocente.ReadOnly = True

                txtEspecialidad.Text = LeerCeldaSegura(fila, "especialidad")
                checkEstado.Checked = LeerBooleanoSeguro(fila, "estado")

                CargarComboPersonas(idPersonaActual)
                If idPersonaActual > 0 Then
                    cboPersona.SelectedValue = idPersonaActual
                End If

                HabilitarCampos(True)

                btnActualizar.Text = "Confirmar"
                btnActualizar.BackColor = Color.DarkOrange
                modoEditar = True
                modoNuevo = False
                btnNuevo.Text = "Nuevo"
                btnNuevo.BackColor = Color.SteelBlue

                MessageBox.Show("Datos cargados. Modifique los campos y pulse 'Confirmar'.",
                                "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' ── Segundo clic: confirmar cambios ──
                If Not CamposObligatoriosLlenos() Then Exit Sub

                objLogica.EditarDocente(
                    idDocente,
                    txtEspecialidad.Text.Trim(),
                    ObtenerIdPersonaSeleccionada(),
                    checkEstado.Checked
                )

                MessageBox.Show("Docente actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarDocentes()
                EstadoInicial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al actualizar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ELIMINAR
    ' ══════════════════════════════════════════════
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If tblDocente.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un docente para eliminar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim confirmar As DialogResult = MessageBox.Show(
                "¿Está seguro de eliminar este docente?" & vbNewLine &
                "Si tiene registros relacionados, se realizará una baja lógica automáticamente.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar = DialogResult.Yes Then
                Dim id As Integer = LeerEnteroSeguro(tblDocente.CurrentRow, "id_docente")

                If id = 0 Then
                    MessageBox.Show("No se pudo obtener el ID del docente.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim eliminadoFisicamente As Boolean = objLogica.EliminarDocente(id)

                If eliminadoFisicamente Then
                    MessageBox.Show("Docente eliminado correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El docente tiene registros relacionados." & vbNewLine &
                                    "Se realizó una baja lógica (estado: Inactivo).",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                MostrarDocentes()
                EstadoInicial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al eliminar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN DAR DE BAJA
    ' ══════════════════════════════════════════════
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If tblDocente.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un docente para dar de baja.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim id As Integer = LeerEnteroSeguro(tblDocente.CurrentRow, "id_docente")

            If id = 0 Then
                MessageBox.Show("No se pudo obtener el ID del docente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim confirmar As DialogResult = MessageBox.Show(
                "¿Está seguro de dar de baja a este docente?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar = DialogResult.Yes Then
                objLogica.DarBajaDocente(id)
                MessageBox.Show("El docente ha sido dado de baja (Inactivo).",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarDocentes()
                EstadoInicial()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al dar de baja",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN BUSCAR (por ID)
    ' ══════════════════════════════════════════════
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If String.IsNullOrWhiteSpace(txtIdDocente.Text) Then
                MessageBox.Show("Ingrese un ID para buscar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim buscarId As Integer = 0
            If Not Integer.TryParse(txtIdDocente.Text.Trim(), buscarId) Then
                MessageBox.Show("El ID ingresado no es un número válido.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim tabla As DataTable = objLogica.MostrarDocentes()
            Dim filas() As DataRow = tabla.Select("id_docente = " & buscarId.ToString())

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)

                idDocente = If(IsDBNull(fila("id_docente")), 0, Convert.ToInt32(fila("id_docente")))
                idPersonaActual = If(IsDBNull(fila("id_persona")), 0, Convert.ToInt32(fila("id_persona")))

                txtEspecialidad.Text = If(IsDBNull(fila("especialidad")), "", fila("especialidad").ToString())
                checkEstado.Checked = If(IsDBNull(fila("estado")), False, Convert.ToBoolean(fila("estado")))

                CargarComboPersonas(idPersonaActual)
                If idPersonaActual > 0 Then
                    cboPersona.SelectedValue = idPersonaActual
                End If

                ' Resaltar fila en la tabla
                tblDocente.DataSource = tabla
                AjustarColumnas()
                For Each row As DataGridViewRow In tblDocente.Rows
                    If Not row.IsNewRow AndAlso
                       Not IsDBNull(row.Cells("id_docente").Value) AndAlso
                       Convert.ToInt32(row.Cells("id_docente").Value) = idDocente Then
                        tblDocente.ClearSelection()
                        row.Selected = True
                        tblDocente.FirstDisplayedScrollingRowIndex = row.Index
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No se encontró ningún docente con el ID: " & buscarId.ToString(),
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar docente: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN LIMPIAR
    ' ══════════════════════════════════════════════
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            EstadoInicial()
            MostrarDocentes()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el formulario: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CLIC EN CELDA DE LA TABLA
    ' ══════════════════════════════════════════════
    Private Sub tblDocente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblDocente.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            ' Si estaba en modo activo, resetear
            If modoNuevo OrElse modoEditar Then
                EstadoInicial()
            End If

            Dim fila As DataGridViewRow = tblDocente.CurrentRow
            If fila Is Nothing Then Exit Sub

            idDocente = LeerEnteroSeguro(fila, "id_docente")
            idPersonaActual = LeerEnteroSeguro(fila, "id_persona")

            txtIdDocente.Text = idDocente.ToString()
            txtEspecialidad.Text = LeerCeldaSegura(fila, "especialidad")
            checkEstado.Checked = LeerBooleanoSeguro(fila, "estado")

            ' Mostrar persona en combo (solo lectura, combo deshabilitado)
            CargarComboPersonas(idPersonaActual)
            If idPersonaActual > 0 Then
                cboPersona.SelectedValue = idPersonaActual
            End If

        Catch ex As Exception
            MessageBox.Show("Error al seleccionar el docente: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN "+" → ABRIR FORMULARIO DE PERSONAS
    ' ══════════════════════════════════════════════
    Private Sub btnAgregarPersona_Click(sender As Object, e As EventArgs) Handles btnAgregarPersona.Click
        Try


            ' Al cerrar, recargar el combo para reflejar la nueva persona registrada
            CargarComboPersonas(idPersonaActual)

        Catch ex As Exception
            MessageBox.Show("Error al abrir el formulario de personas: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

=======
Public Class frmMantDocente
    Dim objLogicaDocente As New clPersona()

    Private Sub frmMantDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        Try
            ' El DataGridView se llama dgvDocente
            dgvDocente.DataSource = objLogicaDocente.MostrarDocentes()
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validar que los campos obligatorios no estén vacíos
        If txtNombre.Text = "" Or txtPaterno.Text = "" Or txtMaterno.Text = "" Or txtNumDoc.Text = "" Or txtEspecialidad.Text = "" Then
            MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Capturar los datos del formulario
            Dim nombres As String = txtNombre.Text.Trim()
            Dim apePaterno As String = txtPaterno.Text.Trim()
            Dim apeMaterno As String = txtMaterno.Text.Trim()
            Dim numDoc As String = txtNumDoc.Text.Trim()
            Dim especialidad As String = txtEspecialidad.Text.Trim()

            ' Dependiendo de cómo llenes tu combo box, puedes capturar el texto ("M" o "F", o la palabra completa)
            Dim sexo As String = ""
            Select Case cboSexo.Text.ToUpper()
                Case "MASCULINO", "M"
                    sexo = "M"
                Case "FEMENINO", "F"
                    sexo = "F"
            End Select

            Dim telefono As String = txtTelefono.Text.Trim()
            Dim correo As String = txtCorreo.Text.Trim()

            ' 3. Enviar a la capa lógica para registrar
            objLogicaDocente.InsertarDocente(apeMaterno, apePaterno, nombres, telefono, correo, sexo, numDoc, especialidad)

            ' 4. Confirmación y limpieza
            MessageBox.Show("Docente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarListado()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario() ' Este método ya hace txtNombre.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Try
                Dim sexo As String = ""
                If cboSexo.Text.ToUpper() = "MASCULINO" Then sexo = "M"
                If cboSexo.Text.ToUpper() = "FEMENINO" Then sexo = "F"

                ' Llama a EditarDocente, no a Insertar
                objLogicaDocente.EditarDocente(txtMaterno.Text.Trim(), txtPaterno.Text.Trim(), txtNombre.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), sexo, txtNumDoc.Text.Trim(), txtEspecialidad.Text.Trim())

                MessageBox.Show("Modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Seleccione un registro del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Try
                objLogicaDocente.DarBajaDocente(txtNumDoc.Text.Trim())
                MessageBox.Show("Registro dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarListado()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Seleccione un registro del listado para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar definitivamente a este docente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Try
                    objLogicaDocente.EliminarDocente(txtNumDoc.Text.Trim())
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CargarListado()
                    LimpiarFormulario()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un registro del listado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvDocente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocente.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvDocente.Rows(e.RowIndex)

            txtNombre.Text = fila.Cells("Nombres").Value.ToString()
            txtNumDoc.Text = fila.Cells("Numero_Documento").Value.ToString()
            txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()

            ' Cargar la especialidad
            If dgvDocente.Columns.Contains("Especialidad") Then
                txtEspecialidad.Text = fila.Cells("Especialidad").Value.ToString()
            End If

            Dim apellidos As String = fila.Cells("Apellidos").Value.ToString().Trim()
            Dim espacioIndex As Integer = apellidos.IndexOf(" ")

            If espacioIndex > 0 Then
                txtPaterno.Text = apellidos.Substring(0, espacioIndex)
                txtMaterno.Text = apellidos.Substring(espacioIndex + 1).Trim()
            Else
                txtPaterno.Text = apellidos
                txtMaterno.Clear()
            End If

            ' Para que esto funcione, la query SELECT debe traer "P.sexo as Sexo"
            If dgvDocente.Columns.Contains("Sexo") Then
                Dim sexoBD As String = fila.Cells("Sexo").Value.ToString()
                If sexoBD = "M" Then
                    cboSexo.Text = "MASCULINO"
                ElseIf sexoBD = "F" Then
                    cboSexo.Text = "FEMENINO"
                Else
                    cboSexo.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub LimpiarFormulario()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        txtNumDoc.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtEspecialidad.Clear()
        cboSexo.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
>>>>>>> 166e04f486622e6f761fc54661f01f7298d19a7a
End Class
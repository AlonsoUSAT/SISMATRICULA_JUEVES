Imports capaLogica

Public Class frmMantUsuarios

    Private objLogica As New capaLogica.clsUsuario()
    Private codUsuario As Integer = 0
    Private editar As Boolean = False
    Private modoNuevo As Boolean = False      ' btnNuevo: False="NUEVO" | True="GUARDAR"
    Private modoEditar As Boolean = False     ' btnActualizar: False="ACTUALIZAR" | True="CONFIRMAR"

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════
    Private Sub frmMantUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboSexo()
        MostrarUsuarios()
        EstadoInicial()
    End Sub

    ' ══════════════════════════════════════════════
    '  HELPERS PRIVADOS
    ' ══════════════════════════════════════════════
    Private Sub CargarComboSexo()
        cboSexo.Items.Clear()
        cboSexo.Items.Add("Masculino")
        cboSexo.Items.Add("Femenino")
        cboSexo.SelectedIndex = 0
    End Sub

    Private Sub MostrarUsuarios()
        tablaUsuarios.DataSource = objLogica.MostrarUsuarios()
    End Sub

    Private Sub EstadoInicial()
        ' Limpiar campos
        txtCodigo.Clear()
        txtCodigo.ReadOnly = False
        txtCodigo.BackColor = Color.White
        txtNombres.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtCorreo.Clear()
        txtContra.Clear()
        txtNombreUsuario.Clear()
        txtPregunta.Clear()
        txtRespuesta.Clear()
        checkVigente.Checked = False
        cboSexo.SelectedIndex = 0

        ' Deshabilitar campos
        HabilitarCampos(False)

        ' Resetear botones a estado original
        btnNuevo.Text = "NUEVO"
        btnNuevo.BackColor = Color.SteelBlue
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.BackColor = Color.FromArgb(70, 130, 180)  ' Azul normal

        modoNuevo = False
        modoEditar = False
        editar = False
        codUsuario = 0
    End Sub

    Private Sub HabilitarCampos(habilitar As Boolean)
        ' ReadOnly para TextBox: se ven normales pero no se pueden editar
        txtNombres.ReadOnly = Not habilitar
        txtApellidoPaterno.ReadOnly = Not habilitar
        txtApellidoMaterno.ReadOnly = Not habilitar
        txtCorreo.ReadOnly = Not habilitar
        txtContra.ReadOnly = Not habilitar
        txtNombreUsuario.ReadOnly = Not habilitar
        txtPregunta.ReadOnly = Not habilitar
        txtRespuesta.ReadOnly = Not habilitar
        ' CheckBox y ComboBox no tienen ReadOnly, se usa Enabled
        checkVigente.Enabled = habilitar
        cboSexo.Enabled = habilitar
    End Sub

    Private Function ObtenerSexo() As Char
        If cboSexo.SelectedItem.ToString() = "Masculino" Then
            Return "M"c
        Else
            Return "F"c
        End If
    End Function

    Private Function CamposObligatoriosLlenos() As Boolean
        If String.IsNullOrWhiteSpace(txtNombres.Text) Then
            MessageBox.Show("El campo 'Nombres' es obligatorio.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombres.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtApellidoPaterno.Text) Then
            MessageBox.Show("El campo 'Apellido Paterno' es obligatorio.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellidoPaterno.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtContra.Text) Then
            MessageBox.Show("El campo 'Clave' es obligatorio.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContra.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNombreUsuario.Text) Then
            MessageBox.Show("El campo 'Nombre de Usuario' es obligatorio.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombreUsuario.Focus() : Return False
        End If
        Return True
    End Function

    ' ══════════════════════════════════════════════
    '  BOTÓN NUEVO / GUARDAR
    ' ══════════════════════════════════════════════
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Not modoNuevo Then
            ' ── Modo NUEVO: habilitar formulario ──
            EstadoInicial()
            txtCodigo.Text = objLogica.ObtenerSiguienteID().ToString()
            HabilitarCampos(True)
            checkVigente.Checked = True
            txtNombres.Focus()

            btnNuevo.Text = "GUARDAR"
            btnNuevo.BackColor = Color.SeaGreen
            modoNuevo = True
            modoEditar = False
        Else
            ' ── Modo GUARDAR: validar e insertar ──
            If Not CamposObligatoriosLlenos() Then Exit Sub

            Try
                objLogica.InsertarUsuario(
                    txtNombres.Text.Trim(),
                    txtApellidoPaterno.Text.Trim(),
                    txtApellidoMaterno.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    ObtenerSexo(),
                    txtContra.Text,
                    checkVigente.Checked,
                    txtNombreUsuario.Text.Trim(),
                    txtPregunta.Text.Trim(),
                    txtRespuesta.Text.Trim()
                )
                MessageBox.Show("Usuario registrado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
                EstadoInicial()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ACTUALIZAR / CONFIRMAR EDICIÓN
    ' ══════════════════════════════════════════════
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not modoEditar Then
            ' ── Primer clic: cargar datos de la fila seleccionada ──
            If tablaUsuarios.SelectedRows.Count = 0 Then
                MessageBox.Show("Seleccione un usuario de la tabla para actualizar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim fila As DataGridViewRow = tablaUsuarios.CurrentRow
            codUsuario = Convert.ToInt32(fila.Cells("codusuario").Value)

            txtCodigo.Text = codUsuario.ToString()
            txtCodigo.ReadOnly = True
            txtCodigo.BackColor = Color.White
            txtNombres.Text = fila.Cells("nombres").Value.ToString()
            txtApellidoPaterno.Text = fila.Cells("apellidopaterno").Value.ToString()
            txtApellidoMaterno.Text = If(IsDBNull(fila.Cells("apellidomaterno").Value), "", fila.Cells("apellidomaterno").Value.ToString())
            txtCorreo.Text = If(IsDBNull(fila.Cells("correo").Value), "", fila.Cells("correo").Value.ToString())
            txtContra.Clear()  ' No se muestra la clave por seguridad
            txtNombreUsuario.Text = If(IsDBNull(fila.Cells("nomusuario").Value), "", fila.Cells("nomusuario").Value.ToString())
            txtPregunta.Text = If(IsDBNull(fila.Cells("pregunta").Value), "", fila.Cells("pregunta").Value.ToString())
            txtRespuesta.Text = If(IsDBNull(fila.Cells("respuesta").Value), "", fila.Cells("respuesta").Value.ToString())
            checkVigente.Checked = Convert.ToBoolean(fila.Cells("estado").Value)

            Dim sexoVal As String = If(IsDBNull(fila.Cells("sexo").Value), "M", fila.Cells("sexo").Value.ToString())
            cboSexo.SelectedItem = If(sexoVal = "M", "Masculino", "Femenino")

            HabilitarCampos(True)

            ' Cambiar botón a "CONFIRMAR"
            btnActualizar.Text = "CONFIRMAR"
            btnActualizar.BackColor = Color.DarkOrange
            modoEditar = True
            modoNuevo = False
            btnNuevo.Text = "NUEVO"
            btnNuevo.BackColor = Color.SteelBlue

            MessageBox.Show("Datos cargados. Modifique los campos y pulse 'CONFIRMAR'." &
                            vbNewLine & "Si no desea cambiar la clave, deje ese campo vacío.",
                            "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' ── Segundo clic: confirmar y guardar cambios ──
            If String.IsNullOrWhiteSpace(txtNombres.Text) OrElse
               String.IsNullOrWhiteSpace(txtApellidoPaterno.Text) OrElse
               String.IsNullOrWhiteSpace(txtNombreUsuario.Text) Then
                MessageBox.Show("Nombres, Apellido Paterno y Nombre de Usuario son obligatorios.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                objLogica.EditarUsuario(
                    codUsuario,
                    txtNombres.Text.Trim(),
                    txtApellidoPaterno.Text.Trim(),
                    txtApellidoMaterno.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    ObtenerSexo(),
                    txtContra.Text,
                    checkVigente.Checked,
                    txtNombreUsuario.Text.Trim(),
                    txtPregunta.Text.Trim(),
                    txtRespuesta.Text.Trim()
                )
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
                EstadoInicial()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al actualizar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN ELIMINAR
    ' ══════════════════════════════════════════════
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tablaUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirmar As DialogResult = MessageBox.Show(
            "¿Está seguro de eliminar este usuario? Esta acción no se puede deshacer.",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmar = DialogResult.Yes Then
            Try
                Dim id As Integer = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells("codusuario").Value)
                objLogica.EliminarUsuario(id)
                MessageBox.Show("Usuario eliminado con éxito.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuarios()
                EstadoInicial()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al eliminar",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN DAR DE BAJA
    ' ══════════════════════════════════════════════
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If tablaUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para dar de baja.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim id As Integer = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells("codusuario").Value)
            objLogica.DarBajaUsuario(id, False)
            MessageBox.Show("El usuario ha sido dado de baja (Inactivo).", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarUsuarios()
            EstadoInicial()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  CLIC EN CELDA DE LA TABLA
    ' ══════════════════════════════════════════════
    Private Sub tablaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaUsuarios.CellClick
        If e.RowIndex < 0 Then Exit Sub

        ' Si estaba en modo GUARDAR o CONFIRMAR, resetear botones
        If modoNuevo OrElse modoEditar Then
            EstadoInicial()
        End If

        Dim fila As DataGridViewRow = tablaUsuarios.CurrentRow
        codUsuario = Convert.ToInt32(fila.Cells("codusuario").Value)

        txtCodigo.Text = codUsuario.ToString()
        txtNombres.Text = fila.Cells("nombres").Value.ToString()
        txtApellidoPaterno.Text = fila.Cells("apellidopaterno").Value.ToString()
        txtApellidoMaterno.Text = If(IsDBNull(fila.Cells("apellidomaterno").Value), "", fila.Cells("apellidomaterno").Value.ToString())
        txtCorreo.Text = If(IsDBNull(fila.Cells("correo").Value), "", fila.Cells("correo").Value.ToString())
        txtContra.Clear()
        txtNombreUsuario.Text = If(IsDBNull(fila.Cells("nomusuario").Value), "", fila.Cells("nomusuario").Value.ToString())
        txtPregunta.Text = If(IsDBNull(fila.Cells("pregunta").Value), "", fila.Cells("pregunta").Value.ToString())
        txtRespuesta.Text = If(IsDBNull(fila.Cells("respuesta").Value), "", fila.Cells("respuesta").Value.ToString())
        checkVigente.Checked = Convert.ToBoolean(fila.Cells("estado").Value)

        Dim sexoVal As String = If(IsDBNull(fila.Cells("sexo").Value), "M", fila.Cells("sexo").Value.ToString())
        cboSexo.SelectedItem = If(sexoVal = "M", "Masculino", "Femenino")

        editar = True
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN BUSCAR
    ' ══════════════════════════════════════════════
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrWhiteSpace(txtCodigo.Text) Then
            MessageBox.Show("Ingrese un código para buscar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Buscar en la tabla cargada
        Dim tabla As DataTable = objLogica.MostrarUsuarios()
        Dim filas() As DataRow = tabla.Select("codusuario = " & txtCodigo.Text.Trim())

        If filas.Length > 0 Then
            Dim fila As DataRow = filas(0)

            ' Poblar todos los campos con los datos encontrados
            codUsuario = Convert.ToInt32(fila("codusuario"))
            txtNombres.Text = fila("nombres").ToString()
            txtApellidoPaterno.Text = fila("apellidopaterno").ToString()
            txtApellidoMaterno.Text = If(IsDBNull(fila("apellidomaterno")), "", fila("apellidomaterno").ToString())
            txtCorreo.Text = If(IsDBNull(fila("correo")), "", fila("correo").ToString())
            txtContra.Clear()  ' La clave no se muestra por seguridad
            txtNombreUsuario.Text = If(IsDBNull(fila("nomusuario")), "", fila("nomusuario").ToString())
            txtPregunta.Text = If(IsDBNull(fila("pregunta")), "", fila("pregunta").ToString())
            txtRespuesta.Text = If(IsDBNull(fila("respuesta")), "", fila("respuesta").ToString())
            checkVigente.Checked = Convert.ToBoolean(fila("estado"))

            Dim sexoVal As String = If(IsDBNull(fila("sexo")), "M", fila("sexo").ToString())
            cboSexo.SelectedItem = If(sexoVal = "M", "Masculino", "Femenino")

            ' Resaltar la fila encontrada en la tabla
            tablaUsuarios.DataSource = tabla
            For Each row As DataGridViewRow In tablaUsuarios.Rows
                If Not row.IsNewRow AndAlso Convert.ToInt32(row.Cells("codusuario").Value) = codUsuario Then
                    tablaUsuarios.ClearSelection()
                    row.Selected = True
                    tablaUsuarios.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next

            editar = True
        Else
            MessageBox.Show("No se encontró ningún usuario con el código: " & txtCodigo.Text,
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtCodigo.ReadOnly = False
        txtCodigo.BackColor = Color.White
        txtNombres.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtCorreo.Clear()
        txtContra.Clear()
        txtNombreUsuario.Clear()
        txtPregunta.Clear()
        txtRespuesta.Clear()
        checkVigente.Checked = False
        cboSexo.SelectedIndex = 0
    End Sub
End Class
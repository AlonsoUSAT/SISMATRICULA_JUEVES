Imports capaLogica

Public Class frmMantEstudiante
    Dim objLogicaPersona As New clPersona()
    ' Esta variable guardará el código secreto del apoderado que encontremos
    Dim idApoderadoSeleccionado As Integer = 0

    Private Sub LimpiarFormulario()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        txtNumDoc.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        cboSexo.SelectedIndex = -1
        cboTipoEstudiante.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub frmMantEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListado()
    End Sub

    Private Sub CargarListado()
        Try
            ' Asegúrate de que el DataGridView se llame dgvApoderados
            dgvEstudiantes.DataSource = objLogicaPersona.MostrarEstudiantes()
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario() ' Este método ya hace txtNombres.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validar vacíos (cambiamos a cboTipoEstudiante)
        If txtNombre.Text = "" Or txtPaterno.Text = "" Or txtMaterno.Text = "" Or txtNumDoc.Text = "" Or cboTipoEstudiante.Text = "" Then
            MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Capturar datos
            Dim nombres As String = txtNombre.Text.Trim()
            Dim apePaterno As String = txtPaterno.Text.Trim()
            Dim apeMaterno As String = txtMaterno.Text.Trim()
            Dim numDoc As String = txtNumDoc.Text.Trim()
            Dim telefono As String = txtTelefono.Text.Trim()
            Dim correo As String = txtCorreo.Text.Trim()

            Dim sexo As String = ""
            If cboSexo.Text.ToUpper() = "MASCULINO" Then sexo = "M"
            If cboSexo.Text.ToUpper() = "FEMENINO" Then sexo = "F"

            ' AHORA SÍ: Variable con el nombre correcto
            Dim tipoEstudiante As String = cboTipoEstudiante.Text.Trim().ToUpper() ' "REGULAR" o "BECADO"

            ' El apoderado temporal para que no nos de error de SQL
            Dim idApoderadoTemporal As Integer = 1

            ' 3. Enviar a la capa lógica usando el nombre correcto
            objLogicaPersona.InsertarEstudiante(apeMaterno, apePaterno, nombres, telefono, correo, sexo, numDoc, tipoEstudiante, idApoderadoTemporal)

            ' 4. Confirmación
            MessageBox.Show("Estudiante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarListado()
            LimpiarFormulario()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNumDoc.Text.Trim() <> "" Then
            Try
                Dim sexo As String = ""
                If cboSexo.Text.ToUpper() = "MASCULINO" Then sexo = "M"
                If cboSexo.Text.ToUpper() = "FEMENINO" Then sexo = "F"

                Dim tipoEstudiante As String = cboTipoEstudiante.Text.Trim().ToUpper()

                ' Llamamos al nuevo método exclusivo de estudiantes
                objLogicaPersona.EditarEstudiante(txtMaterno.Text.Trim(), txtPaterno.Text.Trim(), txtNombre.Text.Trim(), txtTelefono.Text.Trim(), txtCorreo.Text.Trim(), sexo, txtNumDoc.Text.Trim(), tipoEstudiante)

                MessageBox.Show("Estudiante modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                objLogicaPersona.DarBajaPersona(txtNumDoc.Text.Trim())
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
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar definitivamente a este estudiante?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                Try
                    ' Llamamos al nuevo método exclusivo para estudiantes
                    objLogicaPersona.EliminarEstudiante(txtNumDoc.Text.Trim())

                    MessageBox.Show("Estudiante eliminado correctamente de ambas tablas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub dgvEstudiantes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiantes.CellClick
        ' Validar que el usuario no haya hecho clic en la cabecera de la tabla
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvEstudiantes.Rows(e.RowIndex)

            ' 1. Cargar las cajas de texto simples
            txtNombre.Text = fila.Cells("Nombres").Value.ToString()
            txtNumDoc.Text = fila.Cells("Numero_Documento").Value.ToString()
            txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
            txtCorreo.Text = fila.Cells("Correo").Value.ToString()

            ' 2. Separar los apellidos (Paterno y Materno)
            Dim apellidos As String = fila.Cells("Apellidos").Value.ToString().Trim()
            Dim espacioIndex As Integer = apellidos.IndexOf(" ")

            If espacioIndex > 0 Then
                txtPaterno.Text = apellidos.Substring(0, espacioIndex)
                txtMaterno.Text = apellidos.Substring(espacioIndex + 1).Trim()
            Else
                txtPaterno.Text = apellidos
                txtMaterno.Clear()
            End If

            ' 3. Cargar el ComboBox de Sexo
            If dgvEstudiantes.Columns.Contains("Sexo") Then
                Dim sexoBD As String = fila.Cells("Sexo").Value.ToString().Trim().ToUpper()
                If sexoBD = "M" Then
                    cboSexo.Text = "MASCULINO"
                ElseIf sexoBD = "F" Then
                    cboSexo.Text = "FEMENINO"
                Else
                    cboSexo.SelectedIndex = -1
                End If
            End If

            ' 4. Cargar el ComboBox de Tipo de Estudiante
            If dgvEstudiantes.Columns.Contains("Tipo_Estudiante") Then
                Dim tipoBD As String = fila.Cells("Tipo_Estudiante").Value.ToString().Trim().ToUpper()
                If tipoBD = "REGULAR" Or tipoBD = "BECADO" Then
                    cboTipoEstudiante.Text = tipoBD
                Else
                    cboTipoEstudiante.SelectedIndex = -1
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtDniApo.Text.Trim() = "" Then
            MessageBox.Show("Ingrese un número de documento para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Buscamos usando tu txtDniApo
            Dim dtApo As DataTable = objLogicaPersona.BuscarApoderadoPorDNI(txtDniApo.Text.Trim())

            If dtApo.Rows.Count > 0 Then
                ' Si lo encuentra, llenamos TUS cajitas y guardamos el ID en memoria
                idApoderadoSeleccionado = Convert.ToInt32(dtApo.Rows(0)("id_apoderado"))
                txtNombresApo.Text = dtApo.Rows(0)("nombre").ToString()
                txtApePatApo.Text = dtApo.Rows(0)("apePaterno").ToString()
                txtApeMatApo.Text = dtApo.Rows(0)("apeMaterno").ToString()
                txtTelApo.Text = dtApo.Rows(0)("telefono").ToString()
                txtCorreoApo.Text = dtApo.Rows(0)("correo").ToString()

                MessageBox.Show("Apoderado encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encontró ningún apoderado con ese documento.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                idApoderadoSeleccionado = 0
                ' Limpiamos TUS cajitas si no existe
                txtNombresApo.Clear() : txtApePatApo.Clear() : txtApeMatApo.Clear() : txtTelApo.Clear() : txtCorreoApo.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        ' Validamos que haya un estudiante a la izquierda (txtNumDoc)
        If txtNumDoc.Text.Trim() = "" Then
            MessageBox.Show("Primero seleccione un estudiante de la lista de abajo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validamos que haya un apoderado válido buscado a la derecha
        If idApoderadoSeleccionado = 0 Then
            MessageBox.Show("Primero busque y encuentre un apoderado válido usando el botón Buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Ejecutamos la asignación (unimos el DNI del alumno con el ID del apoderado)
            objLogicaPersona.ActualizarApoderadoDeEstudiante(txtNumDoc.Text.Trim(), idApoderadoSeleccionado)

            MessageBox.Show("¡Apoderado asignado correctamente al estudiante!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiamos todo el lado derecho usando TUS variables para dejarlo listo para el siguiente
            txtDniApo.Clear() : txtNombresApo.Clear() : txtApePatApo.Clear() : txtApeMatApo.Clear() : txtTelApo.Clear() : txtCorreoApo.Clear()
            idApoderadoSeleccionado = 0

        Catch ex As Exception
            MessageBox.Show("Error al asignar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
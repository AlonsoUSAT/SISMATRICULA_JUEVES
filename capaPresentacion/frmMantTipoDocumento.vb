Imports capaLogica

Public Class frmMantTipoDocumento

    Private objLogica As New capaLogica.clsTipoDocumento()
    Private idTipo As String = Nothing
    Private editar As Boolean = False


    Private Sub MostrarSiguienteID()
        txtID.ReadOnly = True                          ' No editable
        txtID.BackColor = Color.LightGray              ' Pista visual de que es automático
        txtID.Text = objLogica.ObtenerSiguienteID().ToString()
    End Sub

    ' Al cargar el formulario, mostramos los datos en el DataGridView
    Private Sub frmMantTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDocumentos()
        MostrarSiguienteID()
    End Sub

    Private Sub MostrarDocumentos()
        tablaTipoDocumento.DataSource = objLogica.MostrarDocumentos()
    End Sub

    ' Botón Guardar: Sirve para insertar un nuevo registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim tipoDoc As String = txtTipoDocumento.Text
            Dim vigencia As Boolean = checkVigencia.Checked

            objLogica.InsertarDocumento(tipoDoc, vigencia)
            MessageBox.Show("Documento guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MostrarDocumentos()
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Botón Actualizar: Pasa los datos de la tabla a los cuadros de texto para editar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If tablaTipoDocumento.SelectedRows.Count > 0 Then
            editar = True
            ' Suponiendo que tus columnas se llaman id_tipoDocumento y nombreTipoDocumento en el DataTable
            idTipo = tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value.ToString()
            txtID.Text = idTipo
            txtTipoDocumento.Text = tablaTipoDocumento.CurrentRow.Cells("nombreTipoDocumento").Value.ToString()
            checkVigencia.Checked = Convert.ToBoolean(tablaTipoDocumento.CurrentRow.Cells("estado").Value)
        Else
            MessageBox.Show("Seleccione una fila para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Para completar la edición (puedes usar un botón de confirmar o reutilizar el de guardar)
    ' Aquí te agrego la lógica para procesar la edición una vez cargados los datos:
    Private Sub btnConfirmarEdicion_Click(sender As Object, e As EventArgs) ' Podrías crear este botón o unirlo al de Guardar
        If editar Then
            Try
                objLogica.EditarDocumento(Convert.ToInt32(idTipo), txtTipoDocumento.Text, checkVigencia.Checked)
                MessageBox.Show("Actualizado correctamente")
                editar = False
                MostrarDocumentos()
                LimpiarFormulario()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Botón Eliminar: Llama a la lógica con validación que hicimos antes
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tablaTipoDocumento.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar este tipo de documento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Dim id As Integer = Convert.ToInt32(tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value)
                    objLogica.EliminarDocumento(id)
                    MessageBox.Show("Eliminado con éxito")
                    MostrarDocumentos()
                    LimpiarFormulario()
                Catch ex As Exception
                    ' Aquí se mostrará el mensaje de "No se puede eliminar porque existen personas..."
                    MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub

    ' Botón Dar de Baja: Solo cambia la vigencia a False
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If tablaTipoDocumento.SelectedRows.Count > 0 Then
            Try
                Dim id As Integer = Convert.ToInt32(tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value)
                objLogica.DarBajaDocumento(id, False) ' False para desactivar
                MessageBox.Show("El documento ha sido dado de baja (Inactivo)")
                MostrarDocumentos()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub

    ' Botón Buscar: Filtra o busca por ID
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Aquí podrías implementar una lógica de filtrado en el DataGridView
        If txtID.Text <> "" Then
            ' Lógica simple de búsqueda por ID si fuera necesario
        End If
    End Sub


    Private Sub tablaTipoDocumento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaTipoDocumento.CellClick
        ' Validamos que el índice de la fila no sea el encabezado (-1)
        If e.RowIndex >= 0 Then
            editar = True

            ' Extraemos los datos de la fila actual
            idTipo = tablaTipoDocumento.CurrentRow.Cells("id_tipoDocumento").Value.ToString()
            txtID.Text = idTipo
            txtTipoDocumento.Text = tablaTipoDocumento.CurrentRow.Cells("nombreTipoDocumento").Value.ToString()

            ' IMPORTANTE: Usamos "estado" porque es el nombre real en tu SQL Server
            checkVigencia.Checked = Convert.ToBoolean(tablaTipoDocumento.CurrentRow.Cells("estado").Value)
        End If
    End Sub

    Private Sub LimpiarFormulario()
        MostrarSiguienteID()
        txtTipoDocumento.Clear()
        checkVigencia.Checked = False
        idTipo = Nothing
        editar = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
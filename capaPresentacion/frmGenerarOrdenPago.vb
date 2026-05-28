Imports capaLogica

Public Class frmGenerarOrdenPago

    Private Sub frmGenerarOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNivel.Enabled = False
        cboGrado.Enabled = False
        cboSeccion.Enabled = False


        Dim dtTipos As DataTable = objLogica.ObtenerTiposDocumento()
        cboTipo.DataSource = dtTipos
        cboTipo.DisplayMember = "nombreTipoDocumento"
        cboTipo.ValueMember = "id_tipoDocumento"


        Dim indexDNI As Integer = cboTipo.FindStringExact("DNI")
        If indexDNI <> -1 Then
            cboTipo.SelectedIndex = indexDNI
        Else
            cboTipo.SelectedIndex = 0
        End If


        txtEstudiante.ReadOnly = True
        txtApoderado.ReadOnly = True
        txtTipoBeca.ReadOnly = True
        txtDescuentoAplicable.ReadOnly = True
        txtMontoRegular.ReadOnly = True
        txtMontoDescuento.ReadOnly = True
        txtTotalPagar.ReadOnly = True
        txtEstadoVacantes.ReadOnly = True


        chkEstadoBeca.Enabled = False


        Dim idAno As Integer = objLogica.ObtenerAnoAcademicoActual()
        If idAno > 0 Then
            txtAnoAcademico.Text = DateTime.Now.Year.ToString()
        Else
            txtAnoAcademico.Text = "Sin año activo"
        End If
        txtAnoAcademico.Enabled = False

    End Sub

    Dim objLogica As New clsLogGenerarOrdenPago()


    Dim idEstudianteActual As Integer = 0

    Dim precioMatriculaRegular As Decimal = 300.0




    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        If cboTipo.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtNumDoc.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese un número de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tipoDoc As String = cboTipo.Text.Trim().ToUpper()
        Dim numDoc As String = txtNumDoc.Text.Trim()



        Select Case tipoDoc
            Case "DNI"
                If numDoc.Length <> 8 Then
                    MessageBox.Show("El DNI debe tener exactamente 8 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                If Not numDoc.All(Function(c) Char.IsDigit(c)) Then
                    MessageBox.Show("El DNI solo debe contener números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "CE"
                If numDoc.Length < 9 OrElse numDoc.Length > 12 Then
                    MessageBox.Show("El Carnet de Extranjería debe tener entre 9 y 12 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                If Not numDoc.All(Function(c) Char.IsLetterOrDigit(c)) Then
                    MessageBox.Show("El Carnet de Extranjería solo debe contener letras y números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case Else
                MessageBox.Show("Tipo de documento no reconocido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
        End Select

        Try
            Dim dtInfo As DataTable = objLogica.ObtenerDatosEstudiante(txtNumDoc.Text.Trim())

            If dtInfo.Rows.Count = 0 Then
                MessageBox.Show("Estudiante no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
                Return
            End If


            idEstudianteActual = Convert.ToInt32(dtInfo.Rows(0)("id_estudiante"))
            Dim nombreEstudiante As String = dtInfo.Rows(0)("Estudiante").ToString()
            Dim nombreApoderado As String = dtInfo.Rows(0)("Apoderado").ToString()
            txtEstudiante.Text = nombreEstudiante
            txtApoderado.Text = nombreApoderado


            If nombreApoderado = nombreEstudiante Then
                txtApoderado.Text = "Sin apoderado asignado"
                MessageBox.Show("Este estudiante aún no tiene un apoderado asignado. " &
                    "Por favor, actualice sus datos antes de generar la orden.",
                    "Apoderado no asignado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnGenerarOrden.Enabled = False
                Return
            End If


            Dim tipoBeca As String = dtInfo.Rows(0)("TipoBeca").ToString()
            Dim pctDescuento As Decimal = Convert.ToDecimal(dtInfo.Rows(0)("DescuentoBeca"))
            txtTipoBeca.Text = tipoBeca
            txtDescuentoAplicable.Text = pctDescuento.ToString() & "%"
            chkEstadoBeca.Checked = If(tipoBeca <> "NINGUNA", True, False)


            Dim dctoCalculado As Decimal = precioMatriculaRegular * (pctDescuento / 100)
            Dim totalFinal As Decimal = precioMatriculaRegular - dctoCalculado
            txtMontoRegular.Text = "S/ " & precioMatriculaRegular.ToString("0.00")
            txtMontoDescuento.Text = "- S/ " & dctoCalculado.ToString("0.00")
            txtTotalPagar.Text = "S/ " & totalFinal.ToString("0.00")


            If objLogica.EstaMatriculado(idEstudianteActual) Then
                CargarSeccionEnCombos(idEstudianteActual, esOrdenPendiente:=False)
                cboNivel.Enabled = False
                cboGrado.Enabled = False
                cboSeccion.Enabled = False
                btnGenerarOrden.Enabled = False
                MessageBox.Show("Este estudiante ya cuenta con una matrícula activa.",
                "Estudiante ya matriculado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            If objLogica.TieneOrdenPendiente(idEstudianteActual) Then
                CargarSeccionEnCombos(idEstudianteActual, esOrdenPendiente:=True)
                cboNivel.Enabled = False
                cboGrado.Enabled = False
                cboSeccion.Enabled = False
                btnGenerarOrden.Enabled = False
                MessageBox.Show("Este estudiante ya tiene una orden de pago pendiente.",
                "Orden de pago pendiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            CargarCombosVacante()
            btnGenerarOrden.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarSeccionEnCombos(idEstudiante As Integer, esOrdenPendiente As Boolean)
        Try
            Dim dtSec As DataTable

            If esOrdenPendiente Then
                dtSec = objLogica.ObtenerSeccionDeOrdenPendiente(idEstudiante)
            Else

                dtSec = objLogica.ObtenerSeccionDeOrdenPendiente(idEstudiante)
            End If

            If dtSec.Rows.Count = 0 Then Return

            Dim r As DataRow = dtSec.Rows(0)

            RemoveHandler cboNivel.SelectedIndexChanged, AddressOf cboNivel_SelectedIndexChanged
            RemoveHandler cboGrado.SelectedIndexChanged, AddressOf cboGrado_SelectedIndexChanged
            RemoveHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged

            Dim dtNiveles As DataTable = objLogica.ObtenerNiveles()
            cboNivel.DataSource = dtNiveles
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.SelectedValue = Convert.ToInt32(r("id_nivel"))

            Dim dtGrados As DataTable = objLogica.ObtenerGrados(Convert.ToInt32(r("id_nivel")))
            cboGrado.DataSource = dtGrados
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.SelectedValue = Convert.ToInt32(r("id_grado"))

            Dim dtSecciones As DataTable = objLogica.ObtenerSecciones(Convert.ToInt32(r("id_grado")))
            cboSeccion.DataSource = dtSecciones
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.SelectedValue = Convert.ToInt32(r("id_seccion"))

            AddHandler cboNivel.SelectedIndexChanged, AddressOf cboNivel_SelectedIndexChanged
            AddHandler cboGrado.SelectedIndexChanged, AddressOf cboGrado_SelectedIndexChanged
            AddHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged

        Catch ex As Exception
            MessageBox.Show("Error al cargar sección: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerarOrden_Click(sender As Object, e As EventArgs) Handles btnGenerarOrden.Click


        If idEstudianteActual = 0 Then
            MessageBox.Show("Por favor, busque un estudiante primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If objLogica.TieneOrdenPendiente(idEstudianteActual) Then
            MessageBox.Show("Este estudiante ya tiene una orden de pago pendiente. Debe cancelarla antes de generar una nueva.",
                        "Orden existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If cboNivel.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un Nivel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboGrado.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un Grado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboSeccion.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una Sección.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtEstadoVacantes.Text.Contains("AGOTADO") Then
            MessageBox.Show("No hay vacantes disponibles en la sección seleccionada.", "Sin vacantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

            Dim pctDescuento As Decimal = Convert.ToDecimal(txtDescuentoAplicable.Text.Replace("%", "").Trim())


            Dim idSeccionSeleccionada As Integer = Convert.ToInt32(cboSeccion.SelectedValue)

            Dim resultado As Dictionary(Of String, String) = objLogica.ProcesarGeneracionOrden(
    idEstudianteActual,
    precioMatriculaRegular,
    pctDescuento,
    idSeccionSeleccionada)


            Dim frmOrden As New frmOrdenPago()
            frmOrden.CargarDatos(
                    resultado("CIP"),
                    resultado("Vencimiento"),
                    resultado("MontoBase"),
                    resultado("Descuento"),
                    resultado("TotalPagar")
                )
            frmOrden.ShowDialog()


            btnGenerarOrden.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error al generar la orden: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        cboNivel.Enabled = False
        cboGrado.Enabled = False
        cboSeccion.Enabled = False
        btnGenerarOrden.Enabled = False

    End Sub


    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        Try
            If cboNivel.SelectedValue IsNot Nothing AndAlso TypeOf cboNivel.SelectedValue Is Integer Then
                Dim id_nivel_seleccionado As Integer = Convert.ToInt32(cboNivel.SelectedValue)

                Dim dtGrados As DataTable = objLogica.ObtenerGrados(id_nivel_seleccionado)

                RemoveHandler cboGrado.SelectedIndexChanged, AddressOf cboGrado_SelectedIndexChanged

                cboGrado.DataSource = dtGrados
                cboGrado.DisplayMember = "nombre"
                cboGrado.ValueMember = "id_grado"
                cboGrado.SelectedIndex = -1

                AddHandler cboGrado.SelectedIndexChanged, AddressOf cboGrado_SelectedIndexChanged


                cboGrado.Enabled = True
                cboSeccion.Enabled = False
                cboSeccion.DataSource = Nothing
                txtEstadoVacantes.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        Try
            If cboGrado.SelectedValue IsNot Nothing AndAlso TypeOf cboGrado.SelectedValue Is Integer Then
                Dim id_grado_seleccionado As Integer = Convert.ToInt32(cboGrado.SelectedValue)

                Dim dtSecciones As DataTable = objLogica.ObtenerSecciones(id_grado_seleccionado)


                RemoveHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged

                cboSeccion.DataSource = dtSecciones
                cboSeccion.DisplayMember = "nombre"
                cboSeccion.ValueMember = "id_seccion"
                cboSeccion.SelectedIndex = -1

                AddHandler cboSeccion.SelectedIndexChanged, AddressOf cboSeccion_SelectedIndexChanged


                cboSeccion.Enabled = True
                txtEstadoVacantes.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeccion.SelectedIndexChanged
        Try

            If cboSeccion.SelectedValue IsNot Nothing AndAlso IsNumeric(cboSeccion.SelectedValue) Then
                Dim idSeccionSeleccionada As Integer = Convert.ToInt32(cboSeccion.SelectedValue)


                Dim estado As String = objLogica.VerificarEstadoVacante(idSeccionSeleccionada)
                txtEstadoVacantes.Text = estado


                If estado.Contains("AGOTADO") Then
                    txtEstadoVacantes.ForeColor = Color.Red
                Else
                    txtEstadoVacantes.ForeColor = Color.DarkGreen
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al verificar vacantes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub


    Private Sub LimpiarCampos()
        idEstudianteActual = 0
        txtNumDoc.Clear()
        txtEstudiante.Clear()
        txtApoderado.Clear()
        txtTipoBeca.Clear()
        txtDescuentoAplicable.Clear()
        chkEstadoBeca.Checked = False
        txtMontoRegular.Clear()
        txtMontoDescuento.Clear()
        txtTotalPagar.Clear()


        cboNivel.SelectedIndex = -1
        cboGrado.DataSource = Nothing
        cboSeccion.DataSource = Nothing
        txtEstadoVacantes.Clear()



        cboNivel.Enabled = False
        cboGrado.Enabled = False
        cboSeccion.Enabled = False
        btnGenerarOrden.Enabled = True


        Dim indexDNI As Integer = cboTipo.FindStringExact("DNI")
        If indexDNI <> -1 Then cboTipo.SelectedIndex = indexDNI

    End Sub

    Private Sub btnAgregarEstudiante_Click(sender As Object, e As EventArgs) Handles btnAgregarEstudiante.Click
        Dim hijoUsuarios As New frmMantEstudiante()
        hijoUsuarios.ShowDialog()
    End Sub



    Private Sub txtNumDoc_TextChanged(sender As Object, e As EventArgs) Handles txtNumDoc.TextChanged
        Dim tipoDoc As String = cboTipo.Text.Trim().ToUpper()
        Dim soloNumeros As String = New String(txtNumDoc.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
        Dim soloAlfanumerico As String = New String(txtNumDoc.Text.Where(Function(c) Char.IsLetterOrDigit(c)).ToArray())

        Select Case tipoDoc
            Case "DNI"

                If txtNumDoc.Text <> soloNumeros.Substring(0, Math.Min(soloNumeros.Length, 8)) Then
                    txtNumDoc.Text = soloNumeros.Substring(0, Math.Min(soloNumeros.Length, 8))
                    txtNumDoc.SelectionStart = txtNumDoc.Text.Length
                End If

            Case "CE"

                If txtNumDoc.Text <> soloAlfanumerico.Substring(0, Math.Min(soloAlfanumerico.Length, 12)) Then
                    txtNumDoc.Text = soloAlfanumerico.Substring(0, Math.Min(soloAlfanumerico.Length, 12))
                    txtNumDoc.SelectionStart = txtNumDoc.Text.Length
                End If
        End Select
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.SelectedIndex = -1 Then
            txtNumDoc.Enabled = False
            txtNumDoc.Clear()
        Else
            txtNumDoc.Enabled = True
        End If
    End Sub

    Private Sub CargarCombosVacante()
        Dim dtNiveles As DataTable = objLogica.ObtenerNiveles()

        RemoveHandler cboNivel.SelectedIndexChanged, AddressOf cboNivel_SelectedIndexChanged

        cboNivel.DataSource = dtNiveles
        cboNivel.DisplayMember = "nombre"
        cboNivel.ValueMember = "id_nivel"
        cboNivel.SelectedIndex = -1

        AddHandler cboNivel.SelectedIndexChanged, AddressOf cboNivel_SelectedIndexChanged

        cboNivel.Enabled = True
        cboGrado.Enabled = False
        cboSeccion.Enabled = False
        cboGrado.DataSource = Nothing
        cboSeccion.DataSource = Nothing
        txtEstadoVacantes.Text = ""
    End Sub
End Class
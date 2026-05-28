Imports capaLogica
Imports System.Data

Public Class frmConsultaEstudiantes

    Private objLogica As New capaLogica.clsConsultaEstudiante()
    Private cargandoCombos As Boolean = False

    ' ══════════════════════════════════════════════
    '  CARGA DEL FORMULARIO
    ' ══════════════════════════════════════════════
    Private Sub frmConsultaEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarTabla()
        LimpiarTabla()
        CargarNiveles()
        CargarAnosMatricula() ' Solo se carga Nivel al inicio; Grado y Sección esperan al usuario
        tblBusqueda.AllowUserToAddRows = False
    End Sub

    ' ══════════════════════════════════════════════
    '  CONFIGURACIÓN INICIAL DE LA TABLA
    ' ══════════════════════════════════════════════
    Private Sub ConfigurarTabla()
        tblBusqueda.AllowUserToAddRows = False
        tblBusqueda.AllowUserToDeleteRows = False
        tblBusqueda.ReadOnly = True
        tblBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        tblBusqueda.MultiSelect = False
        tblBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        tblBusqueda.RowHeadersVisible = False
        tblBusqueda.BackgroundColor = Color.White
        tblBusqueda.BorderStyle = BorderStyle.None
        tblBusqueda.DefaultCellStyle.SelectionBackColor = Color.FromArgb(139, 0, 0)
        tblBusqueda.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub LimpiarTabla()
        tblBusqueda.DataSource = Nothing
        tblBusqueda.Rows.Clear()
        tblBusqueda.Columns.Clear()
        lblCantidad.Text = "0"
    End Sub

    ' ══════════════════════════════════════════════
    '  HELPER — Resetea y deshabilita un combo
    ' ══════════════════════════════════════════════
    Private Sub ResetearCombo(combo As ComboBox, idField As String, nombreField As String, textoVacio As String)
        Dim tablaVacia As New DataTable()
        tablaVacia.Columns.Add(idField, GetType(Integer))
        tablaVacia.Columns.Add(nombreField, GetType(String))
        Dim fila As DataRow = tablaVacia.NewRow()
        fila(idField) = 0
        fila(nombreField) = textoVacio
        tablaVacia.Rows.Add(fila)
        combo.DataSource = tablaVacia
        combo.DisplayMember = nombreField
        combo.ValueMember = idField
        combo.SelectedIndex = 0
        combo.Enabled = False
    End Sub

    ' ══════════════════════════════════════════════
    '  PASO 1 — NIVEL: se carga al iniciar el form
    ' ══════════════════════════════════════════════


    Private Sub CargarAnosMatricula()
        Try
            Dim tabla As DataTable = objLogica.ObtenerAnosMatricula()

            ' Crear tabla nueva con columna String para poder meter "-- Todos --"
            Dim tablaFinal As New DataTable()
            tablaFinal.Columns.Add("valor", GetType(String))
            tablaFinal.Columns.Add("texto", GetType(String))

            ' Fila vacía al inicio
            Dim filaVacia As DataRow = tablaFinal.NewRow()
            filaVacia("valor") = "0"
            filaVacia("texto") = "-- Todos --"
            tablaFinal.Rows.Add(filaVacia)

            ' Agregar los años reales
            For Each fila As DataRow In tabla.Rows
                Dim nuevaFila As DataRow = tablaFinal.NewRow()
                nuevaFila("valor") = fila("ano").ToString()
                nuevaFila("texto") = fila("ano").ToString()
                tablaFinal.Rows.Add(nuevaFila)
            Next

            cboAno.DataSource = tablaFinal
            cboAno.DisplayMember = "texto"
            cboAno.ValueMember = "valor"
            cboAno.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar años: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarNiveles()
        Try
            cargandoCombos = True

            Dim tabla As DataTable = objLogica.ObtenerNiveles()
            Dim filaVacia As DataRow = tabla.NewRow()
            filaVacia("id_nivel") = 0
            filaVacia("nombre") = "-- Seleccione --"
            tabla.Rows.InsertAt(filaVacia, 0)

            cboNivel.DataSource = tabla
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.SelectedIndex = 0
            cboNivel.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar niveles: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargandoCombos = False
            ' Grado y Sección arrancan deshabilitados hasta que el usuario elija
            ResetearCombo(cboGrado, "id_grado", "nombre", "-- Seleccione nivel --")
            ResetearCombo(cboSeccion, "id_seccion", "nombre", "-- Seleccione grado --")
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  PASO 2 — GRADO: se habilita al elegir un Nivel
    ' ══════════════════════════════════════════════
    Private Sub CargarGrados(id_nivel As Integer)
        Try
            cargandoCombos = True

            ' Resetear Sección mientras cargamos Grado
            ResetearCombo(cboSeccion, "id_seccion", "nombre", "-- Seleccione grado --")

            Dim tabla As DataTable = objLogica.ObtenerGrados(id_nivel)
            Dim filaVacia As DataRow = tabla.NewRow()
            filaVacia("id_grado") = 0
            filaVacia("nombre") = "-- Seleccione --"
            tabla.Rows.InsertAt(filaVacia, 0)

            cboGrado.DataSource = tabla
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.SelectedIndex = 0
            cboGrado.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar grados: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargandoCombos = False
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  PASO 3 — SECCIÓN: se habilita al elegir un Grado
    ' ══════════════════════════════════════════════
    Private Sub CargarSecciones(id_grado As Integer)
        Try
            cargandoCombos = True

            Dim tabla As DataTable = objLogica.ObtenerSecciones(id_grado)
            Dim filaVacia As DataRow = tabla.NewRow()
            filaVacia("id_seccion") = 0
            filaVacia("nombre") = "-- Seleccione --"
            tabla.Rows.InsertAt(filaVacia, 0)

            cboSeccion.DataSource = tabla
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.SelectedIndex = 0
            cboSeccion.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error al cargar secciones: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cargandoCombos = False
        End Try
    End Sub

    ' ══════════════════════════════════════════════
    '  EVENTOS ENCADENADOS
    ' ══════════════════════════════════════════════

    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        If cargandoCombos Then Exit Sub

        Dim id_nivel As Integer = 0
        Integer.TryParse(cboNivel.SelectedValue?.ToString(), id_nivel)

        If id_nivel > 0 Then
            CargarGrados(id_nivel)          ' Nivel elegido → habilitar Grado
        Else
            ResetearCombo(cboGrado, "id_grado", "nombre", "-- Seleccione nivel --")
            ResetearCombo(cboSeccion, "id_seccion", "nombre", "-- Seleccione grado --")
        End If
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        If cargandoCombos Then Exit Sub

        Dim id_grado As Integer = 0
        Integer.TryParse(cboGrado.SelectedValue?.ToString(), id_grado)

        If id_grado > 0 Then
            CargarSecciones(id_grado)       ' Grado elegido → habilitar Sección
        Else
            ResetearCombo(cboSeccion, "id_seccion", "nombre", "-- Seleccione grado --")
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  BOTÓN CONSULTAR
    ' ══════════════════════════════════════════════
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dni As String = txtDniEstudiante.Text.Trim()

            Dim id_nivel As Integer = 0
            Integer.TryParse(cboNivel.SelectedValue?.ToString(), id_nivel)

            Dim id_grado As Integer = 0
            Integer.TryParse(cboGrado.SelectedValue?.ToString(), id_grado)

            Dim id_seccion As Integer = 0
            Integer.TryParse(cboSeccion.SelectedValue?.ToString(), id_seccion)

            Dim ano As String = ""
            If cboAno.SelectedValue IsNot Nothing AndAlso cboAno.SelectedValue.ToString() <> "0" Then
                ano = cboAno.SelectedValue.ToString()
            End If

            ' Al menos un filtro debe estar activo
            If String.IsNullOrWhiteSpace(dni) AndAlso
               id_nivel = 0 AndAlso id_grado = 0 AndAlso
               id_seccion = 0 AndAlso String.IsNullOrWhiteSpace(ano) Then
                MessageBox.Show("Ingrese al menos un filtro para realizar la búsqueda.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim resultado As DataTable = objLogica.ConsultarEstudiantes(
                dni, id_nivel, id_grado, id_seccion, ano)

            tblBusqueda.DataSource = Nothing
            tblBusqueda.DataSource = resultado

            lblCantidad.Text = resultado.Rows.Count.ToString()

            If resultado.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron estudiantes con los filtros aplicados.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la consulta",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
Imports capaLogica

Public Class frmConsultarCargaActual
    Dim objLogicaMatricula As New clsLogMatricula() ' Para reciclar los métodos que cargan combos
    Dim objLogicaReporte As New clsLogReportes()   ' Tu lógica de reportes
    Dim objLogicaDat As New clsLogPagoMatricula() ' Para cargar combo Año Académico
    Private cargando As Boolean = True

    Private Sub frmConsultarCargaActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargando = True

            ' 1. Cargar combo Año Académico (Con el periodo concatenado) 🌟
            cboAnioAcademico.DataSource = objLogicaMatricula.MostrarAnosAcademicos()
            cboAnioAcademico.DisplayMember = "Periodo"
            cboAnioAcademico.ValueMember = "id_anoAcademico"

            ' 2. Cargar combo Docentes (Método propio indexado por id_persona)
            cboDocente.DataSource = objLogicaReporte.ListarMisDocentes()
            cboDocente.DisplayMember = "NombreCompleto"
            cboDocente.ValueMember = "id_persona"

            ' 3. Cargar combo Niveles
            cboNivel.DataSource = objLogicaMatricula.ListarNiveles()
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"

            ' Inicializamos todos sueltos en -1 (Vacíos)
            cboAnioAcademico.SelectedIndex = -1
            cboDocente.SelectedIndex = -1
            cboNivel.SelectedIndex = -1
            cboGrado.SelectedIndex = -1
            cboSeccion.SelectedIndex = -1

            cargando = False
            ' Ejecuta una carga inicial limpia
            RefrescarTabla()
        Catch ex As Exception
            MsgBox("Error al inicializar filtros: " & ex.Message)
        End Try
    End Sub

    ' Método centralizado que lee los combos y actualiza la grilla
    Private Sub RefrescarTabla()
        If cargando Then Return

        Dim doc As Integer = If(cboDocente.SelectedIndex = -1, -1, Convert.ToInt32(cboDocente.SelectedValue))
        Dim niv As Integer = If(cboNivel.SelectedIndex = -1, -1, Convert.ToInt32(cboNivel.SelectedValue))
        Dim gra As Integer = If(cboGrado.SelectedIndex = -1, -1, Convert.ToInt32(cboGrado.SelectedValue))
        Dim sec As Integer = If(cboSeccion.SelectedIndex = -1, -1, Convert.ToInt32(cboSeccion.SelectedValue))
        Dim ano As Integer = If(cboAnioAcademico.SelectedIndex = -1, -1, Convert.ToInt32(cboAnioAcademico.SelectedValue)) ' 👈 CAPTURA EL AÑO

        Try
            ' Se añade el parámetro "ano" a la llamada del método 🌟
            dgvCargaActual.DataSource = objLogicaMatricula.ListarCargaFiltrada(doc, niv, gra, sec, ano)
        Catch ex As Exception
            MsgBox("Error en búsqueda: " & ex.Message)
        End Try
    End Sub

    ' 🌟 EVENTOS: Filtrado automático en tiempo real
    Private Sub cboAnioAcademico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAnioAcademico.SelectedIndexChanged
        RefrescarTabla()
    End Sub

    Private Sub cboDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocente.SelectedIndexChanged
        RefrescarTabla()
    End Sub

    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        If cargando OrElse cboNivel.SelectedIndex = -1 Then Return

        Dim idNivel As Integer
        If Integer.TryParse(cboNivel.SelectedValue.ToString(), idNivel) Then
            Try
                cargando = True

                cboGrado.DataSource = objLogicaMatricula.ListarGradosPorNivel(idNivel)
                cboGrado.DisplayMember = "nombre"
                cboGrado.ValueMember = "id_grado"
                cboGrado.SelectedIndex = -1

                cboSeccion.DataSource = Nothing

                cargando = False
                RefrescarTabla()
            Catch ex As Exception
                MsgBox("Error al cargar grados: " & ex.Message)
                cargando = False
            End Try
        End If
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        If cargando OrElse cboGrado.SelectedIndex = -1 Then Return

        Dim idGrado As Integer
        If Integer.TryParse(cboGrado.SelectedValue.ToString(), idGrado) Then
            Try
                cargando = True

                cboSeccion.DataSource = objLogicaMatricula.ListarSeccionesPorGrado(idGrado)
                cboSeccion.DisplayMember = "nombre"
                cboSeccion.ValueMember = "id_seccion"
                cboSeccion.SelectedIndex = -1

                cargando = False
                RefrescarTabla()
            Catch ex As Exception
                MsgBox("Error al cargar secciones: " & ex.Message)
                cargando = False
            End Try
        End If
    End Sub

    Private Sub cboSeccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeccion.SelectedIndexChanged
        RefrescarTabla()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Evento vacío
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            ' 1. Bloqueamos el RefrescarTabla para que no haga 5 consultas seguidas a la BD
            cargando = True

            ' 2. Regresamos todos los combos a su estado inicial (vacío)
            cboAnioAcademico.SelectedIndex = -1
            cboDocente.SelectedIndex = -1
            cboNivel.SelectedIndex = -1

            ' 3. Como Grado y Sección dependen de Nivel, los desvinculamos por completo
            cboGrado.DataSource = Nothing
            cboSeccion.DataSource = Nothing

            ' 4. Desbloqueamos el flujo
            cargando = False

            ' 5. Mostramos la tabla limpia con toda la carga acumulada original
            RefrescarTabla()

        Catch ex As Exception
            MsgBox("Error al limpiar los filtros: " & ex.Message)
            cargando = False
        End Try


    End Sub

    Private Sub dgvCargaActual_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCargaActual.CellClick
        ' Validamos que no se intente mapear si hacen clic en el encabezado de la columna (-1)
        If e.RowIndex = -1 Then Return

        Try
            ' 1. Congelamos las consultas automáticas a la BD
            cargando = True

            ' 2. Capturamos la fila seleccionada actual
            Dim fila As DataGridViewRow = dgvCargaActual.Rows(e.RowIndex)

            ' 3. Seteamos los combos planos por su propiedad de texto visible
            cboAnioAcademico.Text = fila.Cells("Periodo").Value.ToString()
            cboDocente.Text = fila.Cells("Docente").Value.ToString()
            cboNivel.Text = fila.Cells("Nivel").Value.ToString()

            ' 🌟 CARGA EN CASCADA FORZADA:
            ' Como Grado y Sección dependen de combos dinámicos, debemos cargarlos a mano
            Dim idNivel As Integer = Convert.ToInt32(cboNivel.SelectedValue)
            cboGrado.DataSource = objLogicaMatricula.ListarGradosPorNivel(idNivel)
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.Text = fila.Cells("Grado").Value.ToString() ' Selecciona el grado de la fila

            Dim idGrado As Integer = Convert.ToInt32(cboGrado.SelectedValue)
            cboSeccion.DataSource = objLogicaMatricula.ListarSeccionesPorGrado(idGrado)
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.Text = fila.Cells("Sección").Value.ToString() ' Selecciona la sección de la fila

            ' 4. Devolvemos el estado de escucha a la normalidad
            cargando = False

        Catch ex As Exception
            MsgBox("Error al sincronizar fila con los filtros: " & ex.Message)
            cargando = False
        End Try
    End Sub
End Class
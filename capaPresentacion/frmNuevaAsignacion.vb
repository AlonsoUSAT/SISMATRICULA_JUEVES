Imports capaLogica

Public Class frmNuevaAsignacion
    Dim objLogica As New clCargaAcademica()
    Dim idCargaEditar As Integer = 0

    Public Sub New(idCarga As Integer)
        InitializeComponent()
        idCargaEditar = idCarga
        CargarDiasSemana()
        CargarEspecialidades()
        CargarNiveles()
        CargarCursos()
    End Sub

    '--- CARGA INICIAL ---
    Private Sub CargarDiasSemana()
        cboDia.Items.Clear()
        cboDia.Items.Add("Lunes")
        cboDia.Items.Add("Martes")
        cboDia.Items.Add("Miércoles")
        cboDia.Items.Add("Jueves")
        cboDia.Items.Add("Viernes")
        cboDia.Items.Add("Sábado")
        cboDia.SelectedIndex = -1
    End Sub

    Private Sub CargarEspecialidades()
        Try
            Dim dt As DataTable = objLogica.MostrarEspecialidades()
            cboEspecialidad.DataSource = Nothing
            cboEspecialidad.Items.Clear()
            cboEspecialidad.DisplayMember = "nombre"
            cboEspecialidad.ValueMember = "id_especialidad"
            cboEspecialidad.DataSource = dt
            cboEspecialidad.SelectedIndex = -1
            cboDocente.Enabled = False
            cboDocente.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarNiveles()
        Try
            Dim dt As DataTable = objLogica.MostrarNiveles()
            cboNivel.DisplayMember = "nombre"
            cboNivel.ValueMember = "id_nivel"
            cboNivel.DataSource = dt
            cboNivel.SelectedIndex = -1
            cboGrado.Enabled = False
            cboGrado.DataSource = Nothing
            cboSeccion.Enabled = False
            cboSeccion.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al cargar niveles: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCursos()
        Try
            Dim dt As DataTable = objLogica.MostrarCursos()
            cboCurso.DisplayMember = "nombreCurso"
            cboCurso.ValueMember = "id_curso"
            cboCurso.DataSource = dt
            cboCurso.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        End Try
    End Sub

    '--- CASCADA ESPECIALIDAD > DOCENTE ---
    Private Sub cboEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecialidad.SelectedIndexChanged
        cboDocente.DataSource = Nothing
        cboDocente.Enabled = False
        If cboEspecialidad.SelectedIndex = -1 Then Return

        Try
            Dim idEsp As Integer = Convert.ToInt32(cboEspecialidad.SelectedValue)
            Dim dt As DataTable = objLogica.MostrarDocentesPorEspecialidad(idEsp)
            cboDocente.DisplayMember = "nombre_completo"
            cboDocente.ValueMember = "id_docente"
            cboDocente.DataSource = dt
            cboDocente.SelectedIndex = -1
            cboDocente.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar docentes: " & ex.Message)
        End Try
    End Sub

    '--- CASCADA NIVEL > GRADO > SECCIÓN ---
    Private Sub cboNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNivel.SelectedIndexChanged
        cboGrado.DataSource = Nothing
        cboGrado.Enabled = False
        cboSeccion.DataSource = Nothing
        cboSeccion.Enabled = False
        If cboNivel.SelectedIndex = -1 Then Return

        Try
            Dim idNivel As Integer = Convert.ToInt32(cboNivel.SelectedValue)
            Dim dt As DataTable = objLogica.MostrarGradosPorNivel(idNivel)
            cboGrado.DisplayMember = "nombre"
            cboGrado.ValueMember = "id_grado"
            cboGrado.DataSource = dt
            cboGrado.SelectedIndex = -1
            cboGrado.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar grados: " & ex.Message)
        End Try
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrado.SelectedIndexChanged
        cboSeccion.DataSource = Nothing
        cboSeccion.Enabled = False
        If cboGrado.SelectedIndex = -1 Then Return

        Try
            Dim idGrado As Integer = Convert.ToInt32(cboGrado.SelectedValue)
            Dim dt As DataTable = objLogica.MostrarSeccionesPorGrado(idGrado)
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.DataSource = dt
            cboSeccion.SelectedIndex = -1
            cboSeccion.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar secciones: " & ex.Message)
        End Try
    End Sub

    '--- VERIFICAR CRUCE AL CAMBIAR DOCENTE, DÍA U HORA ---
    Private Sub VerificarCruce()
        lblMensajeCruce.Text = ""
        If cboDocente.SelectedIndex = -1 OrElse cboDia.SelectedIndex = -1 Then Return

        Try
            Dim idDoc As Integer = Convert.ToInt32(cboDocente.SelectedValue)
            Dim dia As String = cboDia.SelectedItem.ToString()
            Dim hIni As String = dtpHoraInicio.Value.ToString("HH:mm")
            Dim hFin As String = dtpHoraFin.Value.ToString("HH:mm")

            Dim hayCruce As Boolean = objLogica.VerificarCruce(idDoc, dia, hIni, hFin, idCargaEditar)

            If hayCruce Then
                lblMensajeCruce.ForeColor = Color.Red
                lblMensajeCruce.Text = "⚠ Cruce detectado: este docente ya tiene clase ese día y horario."
            Else
                lblMensajeCruce.ForeColor = Color.Green
                lblMensajeCruce.Text = "✓ Sin cruces para este docente en este horario."
            End If
        Catch ex As Exception
            lblMensajeCruce.Text = ""
        End Try
    End Sub

    Private Sub cboDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocente.SelectedIndexChanged
        VerificarCruce()
    End Sub

    Private Sub cboDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDia.SelectedIndexChanged
        VerificarCruce()
    End Sub

    Private Sub dtpHoraInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpHoraInicio.ValueChanged
        VerificarCruce()
    End Sub

    Private Sub dtpHoraFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpHoraFin.ValueChanged
        VerificarCruce()
    End Sub

    '--- GUARDAR ---
    Private Sub btnGuardarAsignacion_Click(sender As Object, e As EventArgs) Handles btnGuardarAsignacion.Click
        ' Validar campos obligatorios
        If cboEspecialidad.SelectedIndex = -1 OrElse
           cboDocente.SelectedIndex = -1 OrElse
           cboNivel.SelectedIndex = -1 OrElse
           cboGrado.SelectedIndex = -1 OrElse
           cboSeccion.SelectedIndex = -1 OrElse
           cboCurso.SelectedIndex = -1 OrElse
           cboDia.SelectedIndex = -1 Then
            MessageBox.Show("Complete todos los campos obligatorios.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validar hora
        If dtpHoraFin.Value <= dtpHoraInicio.Value Then
            MessageBox.Show("La hora de fin debe ser mayor a la hora de inicio.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idDoc As Integer = Convert.ToInt32(cboDocente.SelectedValue)
            Dim idCur As Integer = Convert.ToInt32(cboCurso.SelectedValue)
            Dim idSec As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
            Dim dia As String = cboDia.SelectedItem.ToString()
            Dim hIni As String = dtpHoraInicio.Value.ToString("HH:mm")
            Dim hFin As String = dtpHoraFin.Value.ToString("HH:mm")
            Dim estado As Boolean = chkEstado.Checked

            If idCargaEditar = 0 Then
                objLogica.InsertarCarga(idDoc, idCur, idSec,
                    ModuloSesion.idAnoAcademicoActivo, dia, hIni, hFin)
                MessageBox.Show("Asignación registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                objLogica.EditarCarga(idCargaEditar, idDoc, idCur, idSec,
                    dia, hIni, hFin, estado)
                MessageBox.Show("Asignación actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- CANCELAR ---
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
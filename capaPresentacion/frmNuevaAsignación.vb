Imports capaLogica

Public Class frmNuevaAsignacion
    Dim objLogica As New clCargaAcademica()
    Dim idCargaEditar As Integer = 0

    Dim v_docente As String = ""
    Dim v_curso As String = ""
    Dim v_seccion As String = ""
    Dim v_horario As String = ""
    Dim v_estado As Boolean = True

    Public Sub New(idCarga As Integer, Optional docente As String = "", Optional curso As String = "", Optional seccion As String = "", Optional horario As String = "", Optional estado As Boolean = True)
        InitializeComponent()
        idCargaEditar = idCarga
        v_docente = docente
        v_curso = curso
        v_seccion = seccion
        v_horario = horario
        v_estado = estado
    End Sub

    Private Sub frmNuevaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        If idCargaEditar > 0 Then
            lblTitulo.Text = "EDITAR ASIGNACIÓN ACADÉMICA"
            CargarDatosParaEditar()
        Else
            lblTitulo.Text = "NUEVA ASIGNACIÓN ACADÉMICA"
            chkEstado.Checked = True
        End If
    End Sub

    Private Sub CargarCombos()
        Try
            ' Docente
            Dim dtDoc As DataTable = objLogica.MostrarDocentes()
            cboDocente.DisplayMember = "nombre_completo"
            cboDocente.ValueMember = "id_docente"
            cboDocente.DataSource = dtDoc
            cboDocente.SelectedIndex = -1

            ' Curso
            Dim dtCur As DataTable = objLogica.MostrarCursos()
            cboCurso.DisplayMember = "nombreCurso"
            cboCurso.ValueMember = "id_curso"
            cboCurso.DataSource = dtCur
            cboCurso.SelectedIndex = -1

            ' Sección
            Dim dtSec As DataTable = objLogica.MostrarSecciones()
            cboSeccion.DisplayMember = "nombre"
            cboSeccion.ValueMember = "id_seccion"
            cboSeccion.DataSource = dtSec
            cboSeccion.SelectedIndex = -1

            ' Horario
            Dim dtHor As DataTable = objLogica.MostrarHorarios()
            cboHorario.DisplayMember = "descripcion"
            cboHorario.ValueMember = "id_horario"
            cboHorario.DataSource = dtHor
            cboHorario.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar combos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosParaEditar()
        cboDocente.SelectedIndex = cboDocente.FindStringExact(v_docente)
        cboCurso.SelectedIndex = cboCurso.FindStringExact(v_curso)
        cboSeccion.SelectedIndex = cboSeccion.FindStringExact(v_seccion)
        cboHorario.SelectedIndex = cboHorario.FindStringExact(v_horario)
        chkEstado.Checked = v_estado
    End Sub

    Private Sub VerificarCruce()
        If cboDocente.SelectedIndex = -1 Or cboHorario.SelectedIndex = -1 Then
            lblMensajeCruce.Text = ""
            Return
        End If

        Try
            Dim idDoc As Integer = Convert.ToInt32(cboDocente.SelectedValue)
            Dim idHor As Integer = Convert.ToInt32(cboHorario.SelectedValue)
            Dim hayCruce As Boolean = objLogica.VerificarCruceHorario(idDoc, idHor, idCargaEditar)

            If hayCruce Then
                lblMensajeCruce.ForeColor = Color.Red
                lblMensajeCruce.Text = "⚠ Se detectó un cruce de horario para este docente."
            Else
                lblMensajeCruce.ForeColor = Color.Green
                lblMensajeCruce.Text = "✓ No se detectaron cruces para este bloque."
            End If
        Catch ex As Exception
            lblMensajeCruce.Text = ""
        End Try
    End Sub

    Private Sub cboDocente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocente.SelectedIndexChanged
        VerificarCruce()
    End Sub

    Private Sub cboHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHorario.SelectedIndexChanged
        VerificarCruce()
    End Sub

    Private Sub btnGuardarAsignacion_Click(sender As Object, e As EventArgs) Handles btnGuardarAsignacion.Click
        If cboDocente.SelectedIndex = -1 Or cboCurso.SelectedIndex = -1 Or
           cboSeccion.SelectedIndex = -1 Or cboHorario.SelectedIndex = -1 Then
            MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim idDoc As Integer = Convert.ToInt32(cboDocente.SelectedValue)
            Dim idCur As Integer = Convert.ToInt32(cboCurso.SelectedValue)
            Dim idSec As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
            Dim idHor As Integer = Convert.ToInt32(cboHorario.SelectedValue)
            Dim estadoActivo As Boolean = chkEstado.Checked

            If idCargaEditar = 0 Then
                objLogica.InsertarCarga(idDoc, idCur, idSec, idHor)
                MessageBox.Show("Asignación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                objLogica.EditarCarga(idCargaEditar, idDoc, idCur, idSec, idHor, estadoActivo)
                MessageBox.Show("Asignación actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
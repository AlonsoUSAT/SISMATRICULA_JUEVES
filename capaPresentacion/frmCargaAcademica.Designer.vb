<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaAcademica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFiltroNivel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFiltroGrado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFiltroSeccion = New System.Windows.Forms.ComboBox()
        Me.cboFiltroEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFiltroDocente = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevaAsignacion = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvCargaAcademica = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtAnio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 47)
        Me.Panel1.TabIndex = 0
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(918, 12)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(171, 20)
        Me.txtAnio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(866, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nivel"
        '
        'cboFiltroNivel
        '
        Me.cboFiltroNivel.FormattingEnabled = True
        Me.cboFiltroNivel.Location = New System.Drawing.Point(75, 82)
        Me.cboFiltroNivel.Name = "cboFiltroNivel"
        Me.cboFiltroNivel.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltroNivel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grado:"
        '
        'cboFiltroGrado
        '
        Me.cboFiltroGrado.FormattingEnabled = True
        Me.cboFiltroGrado.Location = New System.Drawing.Point(258, 82)
        Me.cboFiltroGrado.Name = "cboFiltroGrado"
        Me.cboFiltroGrado.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltroGrado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sección:"
        '
        'cboFiltroSeccion
        '
        Me.cboFiltroSeccion.FormattingEnabled = True
        Me.cboFiltroSeccion.Location = New System.Drawing.Point(436, 82)
        Me.cboFiltroSeccion.Name = "cboFiltroSeccion"
        Me.cboFiltroSeccion.Size = New System.Drawing.Size(121, 21)
        Me.cboFiltroSeccion.TabIndex = 6
        '
        'cboFiltroEspecialidad
        '
        Me.cboFiltroEspecialidad.FormattingEnabled = True
        Me.cboFiltroEspecialidad.Location = New System.Drawing.Point(622, 82)
        Me.cboFiltroEspecialidad.Name = "cboFiltroEspecialidad"
        Me.cboFiltroEspecialidad.Size = New System.Drawing.Size(155, 21)
        Me.cboFiltroEspecialidad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(610, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Especialidad:"
        '
        'cboFiltroDocente
        '
        Me.cboFiltroDocente.FormattingEnabled = True
        Me.cboFiltroDocente.Location = New System.Drawing.Point(832, 82)
        Me.cboFiltroDocente.Name = "cboFiltroDocente"
        Me.cboFiltroDocente.Size = New System.Drawing.Size(221, 21)
        Me.cboFiltroDocente.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(816, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Docente:"
        '
        'btnNuevaAsignacion
        '
        Me.btnNuevaAsignacion.Location = New System.Drawing.Point(894, 119)
        Me.btnNuevaAsignacion.Name = "btnNuevaAsignacion"
        Me.btnNuevaAsignacion.Size = New System.Drawing.Size(159, 30)
        Me.btnNuevaAsignacion.TabIndex = 11
        Me.btnNuevaAsignacion.Text = "Nueva asignación"
        Me.btnNuevaAsignacion.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(729, 119)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(159, 30)
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dgvCargaAcademica
        '
        Me.dgvCargaAcademica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaAcademica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column10, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.colEditar, Me.colEliminar})
        Me.dgvCargaAcademica.Location = New System.Drawing.Point(26, 155)
        Me.dgvCargaAcademica.Name = "dgvCargaAcademica"
        Me.dgvCargaAcademica.Size = New System.Drawing.Size(1066, 283)
        Me.dgvCargaAcademica.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Docente"
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Docente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Especialidad"
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Especialidad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Curso"
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Curso"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Nivel"
        Me.Column10.Frozen = True
        Me.Column10.HeaderText = "Nivel"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 75
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Grado"
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Grado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Seccion"
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "Sección"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Dia"
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Día"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Hora_Inicio"
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Hora de inicio"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Hora_Fin"
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "Hora de fin"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Estado"
        Me.Column9.Frozen = True
        Me.Column9.HeaderText = "Estado"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 88
        '
        'colEditar
        '
        Me.colEditar.HeaderText = "Editar"
        Me.colEditar.Name = "colEditar"
        Me.colEditar.Width = 75
        '
        'colEliminar
        '
        Me.colEliminar.HeaderText = "Eliminar"
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.Width = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(21, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Carga academica"
        '
        'frmCargaAcademica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 450)
        Me.Controls.Add(Me.dgvCargaAcademica)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevaAsignacion)
        Me.Controls.Add(Me.cboFiltroDocente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboFiltroEspecialidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboFiltroSeccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboFiltroGrado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFiltroNivel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaAcademica"
        Me.Text = "Sistema de Matrícula I.EP Amancio Varona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboFiltroNivel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFiltroGrado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboFiltroSeccion As ComboBox
    Friend WithEvents cboFiltroEspecialidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboFiltroDocente As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevaAsignacion As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgvCargaAcademica As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewTextBoxColumn
    Friend WithEvents colEliminar As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
End Class

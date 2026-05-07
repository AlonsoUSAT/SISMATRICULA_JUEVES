<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantPlanEstudio1
    Inherits capaPresentacion.frmMantAnoAcademico

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Size = New System.Drawing.Size(412, 29)
        Me.Label4.Text = "Mantenimiento de Plan de Estudio"
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.Text = "Año del Plan:"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.Text = ""
        Me.Label2.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "yyyy"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.ShowUpDown = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(58, 356)
        Me.dtpFechaFin.Size = New System.Drawing.Size(10, 22)
        Me.dtpFechaFin.Value = New Date(2026, 5, 5, 21, 44, 4, 0)
        Me.dtpFechaFin.Visible = False
        '
        'frmMantPlanEstudio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(591, 475)
        Me.Name = "frmMantPlanEstudio1"
        Me.Text = "Mantenimiento de Plan de Estudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

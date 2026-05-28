Imports System.Data
Imports capaDatos
Imports capaDatos.capaDatos

Namespace capaLogica

    Public Class clsLogHistorialAcademico

        Private ReadOnly _datFicha As New clsDatHistorial()

        ' ==================================================================
        ' 1. BÚSQUEDA DE ESTUDIANTE COMPLETO
        ' ==================================================================
        Public Function ObtenerDatosEstudianteCompleto(dni As String) As DataTable
            dni = dni.Trim()
            ' Validación de regla de negocio: DNI exacto de 8 dígitos numéricos
            If dni.Length <> 8 OrElse Not Long.TryParse(dni, Nothing) Then
                Throw New ArgumentException("El DNI debe tener exactamente 8 dígitos numéricos.")
            End If
            Return _datFicha.ObtenerDatosEstudianteCompleto(dni)
        End Function

        ' ==================================================================
        ' 2. HISTORIAL DE MATRÍCULAS
        ' ==================================================================
        Public Function ObtenerHistorialMatriculas(idEstudiante As Integer) As DataTable
            If idEstudiante <= 0 Then Return New DataTable()
            Return _datFicha.ObtenerHistorialMatriculas(idEstudiante)
        End Function

        Public Function ObtenerCursosYHorarios(idEstudiante As Integer, idAnoAcademico As Integer) As DataTable
            If idEstudiante <= 0 OrElse idAnoAcademico <= 0 Then Return New DataTable()
            Return _datFicha.ObtenerCursosYHorarios(idEstudiante, idAnoAcademico)
        End Function

        Public Function ObtenerHistorialBecas(idEstudiante As Integer) As DataTable
            If idEstudiante <= 0 Then Return New DataTable()
            Return _datFicha.ObtenerHistorialBecas(idEstudiante)
        End Function

    End Class

End Namespace
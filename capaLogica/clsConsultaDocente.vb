Imports capaDatos
Imports System.Data

Public Class clsConsultaDocente

    Private obj As New capaDatos.clsConsultaDocente()

    ' ══════════════════════════════════════════════
    '  COMBOS
    ' ══════════════════════════════════════════════
    Public Function ObtenerNiveles() As DataTable
        Return obj.ObtenerNiveles()
    End Function

    Public Function ObtenerGrados(Optional id_nivel As Integer = 0) As DataTable
        Return obj.ObtenerGrados(id_nivel)
    End Function

    Public Function ObtenerSecciones(Optional id_grado As Integer = 0) As DataTable
        Return obj.ObtenerSecciones(id_grado)
    End Function

    Public Function ObtenerAnosAcademicos() As DataTable
        Return obj.ObtenerAnosAcademicos()
    End Function

    ' ══════════════════════════════════════════════
    '  CONSULTAR CON VALIDACIÓN
    ' ══════════════════════════════════════════════
    Public Function ConsultarDocentes(
            Optional dni As String = "",
            Optional id_nivel As Integer = 0,
            Optional id_grado As Integer = 0,
            Optional id_seccion As Integer = 0,
            Optional ano As String = "") As DataTable

        If Not String.IsNullOrWhiteSpace(ano) Then
            Dim anoInt As Integer
            If Not Integer.TryParse(ano.Trim(), anoInt) Then
                Throw New Exception("El año ingresado no es válido.")
            End If
            If anoInt < 2000 OrElse anoInt > 2100 Then
                Throw New Exception("El año debe estar entre 2000 y 2100.")
            End If
        End If

        Return obj.ConsultarDocentes(dni, id_nivel, id_grado, id_seccion, ano)
    End Function

End Class
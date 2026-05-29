Imports System.Data
Imports capaDatos
Imports capaDatos.capaDatos

Namespace capaLogica
    Public Class clsLogPlanEstudio
        ' Instanciamos la clase de la capa de datos
        Private ReadOnly objDatos As New clsDatPlanEstudio()

        Public Function Listar() As DataTable
            Return objDatos.ListarPlanes()
        End Function

        Public Function Guardar(año As Date, vigencia As Boolean) As Boolean
            Return objDatos.InsertarPlan(año, vigencia)
        End Function

        Public Function Modificar(id As Integer, año As Date, vigencia As Boolean) As Boolean
            If id <= 0 Then Throw New ArgumentException("Seleccione un registro de la lista.")
            Return objDatos.ActualizarPlan(id, año, vigencia)
        End Function

        Public Function DarDeBaja(id As Integer) As Boolean
            If id <= 0 Then Throw New ArgumentException("Seleccione un registro de la lista.")
            Return objDatos.DarDeBajaPlan(id)
        End Function

        Public Function ObtenerSiguienteId() As Integer
            Return objDatos.ObtenerSiguienteId()
        End Function

    End Class
End Namespace
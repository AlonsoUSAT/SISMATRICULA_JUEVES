Imports capaDatos

Public Class clsLogPlanEstudio
    ' Instanciamos la clase de la capa de datos
    Dim objDatos As New clsDatPlanEstudio()

    ' 1. LISTAR
    Public Function Listar() As DataTable
        Return objDatos.ListarPlanes()
    End Function

    ' 2. GUARDAR NUEVO
    Public Function Guardar(año As Date) As Boolean
        ' Como el Plan de Estudio solo guarda un año, no hay reglas de fecha de inicio vs fin que validar aquí
        Return objDatos.InsertarPlan(año)
    End Function

    ' 3. MODIFICAR EXISTENTE
    Public Function Modificar(id As Integer, año As Date, estado As Boolean) As Boolean
        Return objDatos.ActualizarPlan(id, año, estado)
    End Function

    ' 4. DAR DE BAJA
    Public Function DarDeBaja(id As Integer) As Boolean
        Return objDatos.DarDeBajaPlan(id)
    End Function
End Class

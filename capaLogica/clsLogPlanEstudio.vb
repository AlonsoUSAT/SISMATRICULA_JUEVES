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
        Dim dt As DataTable = objDatos.ListarPlanes()
        For Each fila As DataRow In dt.Rows
            If CInt(fila("año")) = año.Year Then
                Throw New Exception("Ya existe un Plan de Estudio para el año " & año.Year & ".")
            End If
        Next
        Return objDatos.InsertarPlan(año)
    End Function


    Public Function Buscar(id As Integer) As DataTable
        If id <= 0 Then Throw New Exception("Ingrese un ID válido.")
        Return objDatos.BuscarPorId(id)
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

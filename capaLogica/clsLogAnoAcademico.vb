Imports capaDatos

Public Class clsLogAnoAcademico
    Dim objDatos As New clsDatAnoAcademico()

    ' 1. LISTAR
    Public Function Listar() As DataTable
        Return objDatos.ListarAnos()
    End Function

    ' 2. GUARDAR NUEVO
    Public Function Guardar(fechaInicio As Date, fechaFin As Date) As Boolean
        If fechaInicio >= fechaFin Then
            Throw New Exception("La fecha de inicio no puede ser mayor o igual a la fecha de fin.")
        End If

        Return objDatos.InsertarAno(fechaInicio, fechaFin)
    End Function

    ' 3. MODIFICAR 
    Public Function Modificar(id As Integer, fechaInicio As Date, fechaFin As Date, estado As Boolean) As Boolean
        If fechaInicio >= fechaFin Then
            Throw New Exception("La fecha de inicio no puede ser mayor o igual a la fecha de fin.")
        End If

        Return objDatos.ActualizarAno(id, fechaInicio, fechaFin, estado)
    End Function

    ' 4. DAR DE BAJA
    Public Function DarDeBaja(id As Integer) As Boolean
        Return objDatos.DarDeBajaAno(id)
    End Function
End Class

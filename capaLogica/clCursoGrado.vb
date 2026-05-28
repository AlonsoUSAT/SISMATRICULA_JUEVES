Imports System.Data
Imports capaDatos ' Asegúrate de usar el nombre correcto de tu capa de datos

Public Class clCursoGrado
    Dim objCapaDatos As New clsCursoGrado()

    Public Function MostrarAsignaciones() As DataTable
        Try
            Return objCapaDatos.MostrarAsignaciones()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function



    Public Function CargarGrados() As DataTable
        Try
            Return objCapaDatos.CargarGrados()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CargarCursos() As DataTable
        Try
            Return objCapaDatos.CargarCursos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CargarAnios() As DataTable
        Try
            Return objCapaDatos.CargarAnios()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CargarGradosPorAnio(anio As String) As DataTable
        Try
            Return objCapaDatos.CargarGradosPorAnio(anio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarAsignacionesFiltradas(anio As String) As DataTable
        Try
            Return objCapaDatos.MostrarAsignacionesFiltradas(anio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub RegistrarAsignacion(id_grado As Integer, id_curso As Integer, estado As Integer)
        Try
            objCapaDatos.RegistrarAsignacion(id_grado, id_curso, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DarBajaAsignacion(id_grado_curso As Integer)
        Try
            objCapaDatos.DarBajaAsignacion(id_grado_curso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarAsignacion(id_grado_curso As Integer)
        Try
            objCapaDatos.EliminarAsignacion(id_grado_curso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class

Imports System
Imports System.Data
Imports capaDatos

Public Class clCurso
    Dim objCapaDatos As New clsCurso()

    Public Function MostrarCursos() As DataTable
        Try
            Return objCapaDatos.MostrarCursos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarCursosFiltrados(nombre As String) As DataTable
        Try
            Return objCapaDatos.MostrarCursosFiltrados(nombre)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarAreasAcademicas() As DataTable
        Try
            Return objCapaDatos.MostrarAreasAcademicas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub InsertarCurso(nombreCurso As String, descripcion As String, id_area As Integer, id_grado As Integer)
        Try
            objCapaDatos.RegistrarCurso(nombreCurso, descripcion, id_area, id_grado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarCurso(id_curso As Integer, nombreCurso As String, descripcion As String, id_area As Integer)
        Try
            objCapaDatos.EditarCurso(id_curso, nombreCurso, descripcion, id_area)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DarBajaCurso(id_curso As Integer)
        Try
            objCapaDatos.DarBajaCurso(id_curso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarCurso(id_curso As Integer)
        Try
            objCapaDatos.EliminarCurso(id_curso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
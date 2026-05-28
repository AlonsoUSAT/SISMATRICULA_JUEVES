Imports System.Data
Imports capaDatos

Public Class clEspecialidad
    Dim objCapaDatos As New clsEspecialidad()
    Public Function ContarPorEstado(estado As Integer) As Integer
        Try
            Return objCapaDatos.ContarPorEstado(estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function MostrarEspecialidades() As DataTable
        Try
            Return objCapaDatos.MostrarEspecialidades()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarFiltradas(nombre As String) As DataTable
        Try
            Return objCapaDatos.MostrarFiltradas(nombre)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub InsertarEspecialidad(nombre As String)
        Try
            objCapaDatos.Registrar(nombre)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarEspecialidad(id As Integer, nombre As String, estado As Boolean)
        Try
            objCapaDatos.Editar(id, nombre, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DarBajaEspecialidad(id As Integer)
        Try
            objCapaDatos.DarBaja(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarEspecialidad(id As Integer)
        Try
            objCapaDatos.Eliminar(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function MostrarDocentesPorEspecialidad(id_especialidad As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarDocentesPorEspecialidad(id_especialidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
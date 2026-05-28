Imports System.Data
Imports capaDatos

Public Class clApertura
    Dim objCapaDatos As New clsApertura()

    Public Function GetAniosDistinct() As DataTable
        Try
            Return objCapaDatos.GetAniosDistinct()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function GetNivelesPorAnio(idAnio As Integer) As DataTable
        Try
            Return objCapaDatos.GetNivelesPorAnio(idAnio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function GetGradosPorNivel(idNivel As Integer) As DataTable
        Try
            Return objCapaDatos.GetGradosPorNivel(idNivel)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' Bucle para Generación Masiva
    Public Sub GenerarAperturaMasivaGrados(listaIdGrados As List(Of Integer), nombreSeccion As String, aforo As Integer)
        Try
            If listaIdGrados Is Nothing OrElse listaIdGrados.Count = 0 Then
                Throw New Exception("No se han seleccionado grados para generar.")
            End If

            For Each idGrado As Integer In listaIdGrados
                objCapaDatos.RegistrarSeccion(idGrado, nombreSeccion, aforo)
            Next

        Catch ex As Exception
            Throw New Exception("Error en Lógica durante generación masiva: " & ex.Message)
        End Try
    End Sub

    Public Function BuscarGruposAsignadosListado(idAnio As Integer, idNivel As Integer) As DataTable
        Try
            Return objCapaDatos.BuscarGruposAsignadosListado(idAnio, idNivel)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
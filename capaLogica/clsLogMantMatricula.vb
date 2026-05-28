Imports System.Data
Imports capaDatos

Public Class clsLogMantMatricula
    Dim objDatos As New clsDatMantMatricula()

    Public Function ObtenerTiposDocumento() As DataTable
        Try
            Return objDatos.ListarTiposDocumento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerMatriculaPorDoc(numDoc As String) As DataTable
        Try
            Return objDatos.BuscarMatriculaPorDoc(numDoc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerSeccionesPorGrado(idGrado As Integer) As DataTable
        Try
            Return objDatos.ListarSeccionesPorGrado(idGrado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function VerificarVacantes(idSeccion As Integer) As String
        Try
            Dim cantidad As Integer = objDatos.ConsultarVacantes(idSeccion)
            Return If(cantidad > 0, "DISPONIBLE (" & cantidad & " cupos)", "AGOTADO (0 cupos)")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarMatricula(idMatricula As Integer, idSeccion As Integer, observacion As String)
        Try
            objDatos.ActualizarMatricula(idMatricula, idSeccion, observacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
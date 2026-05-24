Imports System.Data
Imports capaDatos ' Ajusta si tu namespace es distinto

Public Class clSeccion
    Dim objDatos As New clsSeccion()

    Public Function ListarNiveles() As DataTable
        Return objDatos.ListarNiveles()
    End Function

    Public Function ListarGrados(id_nivel As Integer) As DataTable
        Return objDatos.ListarGrados(id_nivel)
    End Function

    Public Function ListarSecciones(id_grado As Integer) As DataTable
        Return objDatos.ListarSecciones(id_grado)
    End Function

    Public Sub InsertarSeccion(id_grado As Integer, nombre As String, aforo As Integer, tutor As String)
        objDatos.InsertarSeccion(id_grado, nombre, aforo, tutor)
    End Sub

    Public Sub ModificarSeccion(id_seccion As Integer, nombre As String, aforo As Integer, tutor As String, vigencia As Integer)
        objDatos.ModificarSeccion(id_seccion, nombre, aforo, tutor, vigencia)
    End Sub

    Public Sub EliminarSeccion(id_seccion As Integer)
        objDatos.EliminarSeccion(id_seccion)
    End Sub
    Public Sub DarBajaSeccion(id_seccion As Integer)
        Try
            objDatos.DarBajaSeccion(id_seccion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
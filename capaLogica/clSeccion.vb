' --- CAPA LÓGICA (clSeccion) ---
Imports System.Data
Imports capaDatos

Public Class clSeccion
    Dim objDatos As New clsSeccion()

    ' NUEVO
    Public Function ListarAnosAcademicos() As DataTable
        Return objDatos.ListarAnosAcademicos()
    End Function

    ' MODIFICADO
    Public Function ListarNiveles(id_anoAcademico As Integer) As DataTable
        Return objDatos.ListarNiveles(id_anoAcademico)
    End Function

    Public Function ListarGrados(id_nivel As Integer) As DataTable
        Return objDatos.ListarGrados(id_nivel)
    End Function

    Public Function ListarSecciones(id_grado As Integer) As DataTable
        Return objDatos.ListarSecciones(id_grado)
    End Function

    Public Function ListarTutores() As DataTable
        Return objDatos.ListarTutores()
    End Function

    Public Sub InsertarSeccion(id_grado As Integer, nombre As String, aforo As Integer, id_docente_tutor As Integer)
        objDatos.InsertarSeccion(id_grado, nombre, aforo, id_docente_tutor)
    End Sub

    Public Sub ModificarSeccion(id_seccion As Integer, nombre As String, aforo As Integer, id_docente_tutor As Integer, vigencia As Integer)
        objDatos.ModificarSeccion(id_seccion, nombre, aforo, id_docente_tutor, vigencia)
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
Imports System.Data
Imports capaDatos

Public Class clCargaAcademica
    Dim objCapaDatos As New clsCargaAcademica()

    Public Function MostrarCargaAcademica() As DataTable
        Try
            Return objCapaDatos.MostrarCargaAcademica()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarCargaFiltrada(idDocente As Integer, idSeccion As Integer, idCurso As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarCargaFiltrada(idDocente, idSeccion, idCurso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarDocentes() As DataTable
        Try
            Return objCapaDatos.MostrarDocentes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarCursos() As DataTable
        Try
            Return objCapaDatos.MostrarCursos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarSecciones() As DataTable
        Try
            Return objCapaDatos.MostrarSecciones()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarHorarios() As DataTable
        Try
            Return objCapaDatos.MostrarHorarios()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub InsertarCarga(id_docente As Integer, id_curso As Integer, id_seccion As Integer, id_horario As Integer)
        Try
            objCapaDatos.RegistrarCarga(id_docente, id_curso, id_seccion, id_horario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarCarga(id_carga As Integer, id_docente As Integer, id_curso As Integer, id_seccion As Integer, id_horario As Integer, estado As Boolean)
        Try
            objCapaDatos.EditarCarga(id_carga, id_docente, id_curso, id_seccion, id_horario, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarCarga(id_carga As Integer)
        Try
            objCapaDatos.EliminarCarga(id_carga)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function VerificarCruceHorario(id_docente As Integer, id_horario As Integer, id_carga_excluir As Integer) As Boolean
        Try
            Return objCapaDatos.VerificarCruceHorario(id_docente, id_horario, id_carga_excluir)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class

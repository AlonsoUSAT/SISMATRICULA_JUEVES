Imports System.Data
Imports capaDatos

Public Class clCargaAcademica
    Dim objCapaDatos As New clsCargaAcademica()

    Public Function MostrarAniosAcademicos() As DataTable
        Try
            Return objCapaDatos.MostrarAniosAcademicos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarNiveles() As DataTable
        Try
            Return objCapaDatos.MostrarNiveles()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarGradosPorNivel(id_nivel As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarGradosPorNivel(id_nivel)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarSeccionesPorGrado(id_grado As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarSeccionesPorGrado(id_grado)
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

    Public Function MostrarDocentesPorEspecialidad(id_especialidad As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarDocentesPorEspecialidad(id_especialidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarTodosDocentes() As DataTable
        Try
            Return objCapaDatos.MostrarTodosDocentes()
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

    Public Function MostrarCargaAcademica(id_anoAcademico As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarCargaAcademica(id_anoAcademico)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function MostrarCargaFiltrada(id_anoAcademico As Integer, id_seccion As Integer,
                                          id_especialidad As Integer, id_docente As Integer) As DataTable
        Try
            Return objCapaDatos.MostrarCargaFiltrada(id_anoAcademico, id_seccion, id_especialidad, id_docente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub InsertarCarga(id_docente As Integer, id_curso As Integer,
                              id_seccion As Integer, id_anoAcademico As Integer,
                              diaSemana As String, horaInicio As String, horaFin As String)
        Try
            objCapaDatos.RegistrarCarga(id_docente, id_curso, id_seccion, id_anoAcademico, diaSemana, horaInicio, horaFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarCarga(id_carga As Integer, id_docente As Integer, id_curso As Integer,
                            id_seccion As Integer, diaSemana As String,
                            horaInicio As String, horaFin As String, estado As Boolean)
        Try
            objCapaDatos.EditarCarga(id_carga, id_docente, id_curso, id_seccion, diaSemana, horaInicio, horaFin, estado)
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

    Public Function VerificarCruce(id_docente As Integer, diaSemana As String,
                                    horaInicio As String, horaFin As String,
                                    id_carga_excluir As Integer) As Boolean
        Try
            Return objCapaDatos.VerificarCruce(id_docente, diaSemana, horaInicio, horaFin, id_carga_excluir)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
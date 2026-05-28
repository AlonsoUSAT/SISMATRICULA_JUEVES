Imports System.Data
Imports System.Net
Imports capaDatos

Public Class clsLogMatricula

 

    Public Function BuscarEstudiantePorDNI(dni As String) As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.BuscarEstudiantePorDNI(dni)
    End Function


    Public Function ListarTiposDocumento() As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ListarTiposDocumento()
    End Function

    Public Function ListarNiveles() As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ListarNiveles()
    End Function

    Public Function ListarGradosPorNivel(id_nivel As Integer) As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ListarGradosPorNivel(id_nivel)
    End Function

    Public Function ListarSeccionesPorGrado(id_grado As Integer) As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ListarSeccionesPorGrado(id_grado)
    End Function


    Public Function ObtenerVacantesDisponibles(id_seccion As Integer) As Integer

        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ObtenerVacantesDisponibles(id_seccion)
    End Function



    Public Function ProcesarMatricula(id_estudiante As Integer, id_seccion As Integer, monto As Decimal, codOperativo As String, refBancaria As String, observacion As String) As Boolean
        Dim objDatMatricula As New capaDatos.clsDatMatricula()

        Return objDatMatricula.ProcesarMatricula(id_estudiante, id_seccion, monto, codOperativo, refBancaria, observacion)
    End Function

    Public Function ValidarMatriculaActual(idEstudiante As Integer) As Boolean
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ValidarMatriculaActual(idEstudiante)
    End Function


    Public Function ObtenerUltimoGradoEstudiante(idEstudiante As Integer) As DataTable
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ObtenerUltimoGradoEstudiante(idEstudiante)
    End Function

    Public Function ValidarVoucherDuplicado(codOperativo As String) As Boolean
        Dim objDatMatricula As New capaDatos.clsDatMatricula()
        Return objDatMatricula.ValidarVoucherDuplicado(codOperativo)
    End Function

    Public Function MostrarAnosAcademicos() As DataTable
        ' Instancias la clase de datos donde creaste el "ListarAnosAcademicos"
        Dim objDatos As New clsDatPagoMatricula() ' 👈 Asegúrate de que apunte a tu clase de datos correcta
        Return objDatos.ListarAnosAcademicos()
    End Function
    Public Function ListarHistoricoCarga(idAno As Integer) As DataTable
        Dim objDatos As New ClsDatReportes() ' O el nombre de tu clase de datos
        Return objDatos.ObtenerHistoricoCarga(idAno)
    End Function

    Public Function ListarCargaFiltrada(idDocente As Integer, idNivel As Integer, idGrado As Integer, idSeccion As Integer, idAno As Integer) As DataTable
        Dim objDatos As New clsDatPagoMatricula()
        Return objDatos.ObtenerCargaFiltrada(idDocente, idNivel, idGrado, idSeccion, idAno)
    End Function
End Class

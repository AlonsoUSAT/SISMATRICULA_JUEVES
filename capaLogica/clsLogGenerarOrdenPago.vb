Imports System.Data
Imports capaDatos

Public Class clsLogGenerarOrdenPago

    Dim objDatos As New clsDatGenerarOrdenPago()


    Public Function ObtenerDatosEstudiante(num_doc As String) As DataTable
        Try
            Return objDatos.BuscarEstudianteYBeca(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function ObtenerNiveles() As DataTable
        Try
            Return objDatos.ListarNiveles()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerGrados(id_nivel As Integer) As DataTable
        Try
            Return objDatos.ListarGrados(id_nivel)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerSecciones(id_grado As Integer) As DataTable
        Try
            Return objDatos.ListarSecciones(id_grado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function VerificarEstadoVacante(id_seccion As Integer) As String
        Try
            Dim cantidad As Integer = objDatos.ConsultarVacantesDisponibles(id_seccion)

            If cantidad > 0 Then
                Return "DISPONIBLE (" & cantidad & " cupos)"
            Else
                Return "AGOTADO (0 cupos)"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function ProcesarGeneracionOrden(id_estudiante As Integer,
                                         montoRegular As Decimal,
                                         porcentajeDcto As Decimal,
                                         id_seccion As Integer) As Dictionary(Of String, String)
        Try
            Dim montoDescuento As Decimal = montoRegular * (porcentajeDcto / 100)
            Dim totalAPagar As Decimal = montoRegular - montoDescuento

            Dim codigoCIP As String = DateTime.Now.ToString("yy") &
                              id_estudiante.ToString().PadLeft(6, "0"c) &
                              DateTime.Now.ToString("HHmmss")
            Dim fechaVencimiento As Date = DateTime.Now.AddDays(3)


            objDatos.RegistrarOrdenPago(id_estudiante, codigoCIP, montoRegular,
                                    montoDescuento, totalAPagar, fechaVencimiento, id_seccion)

            Dim resultado As New Dictionary(Of String, String)
            resultado.Add("CIP", codigoCIP)
            resultado.Add("Vencimiento", fechaVencimiento.ToString("dd/MM/yyyy"))
            resultado.Add("MontoBase", montoRegular.ToString("0.00"))
            resultado.Add("Descuento", montoDescuento.ToString("0.00"))
            resultado.Add("TotalPagar", totalAPagar.ToString("0.00"))

            Return resultado
        Catch ex As Exception
            Throw New Exception("Error en la lógica de negocio: " & ex.Message)
        End Try
    End Function

    Public Function ObtenerTiposDocumento() As DataTable
        Try
            Return objDatos.ListarTiposDocumento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function EstaMatriculado(id_estudiante As Integer) As Boolean
        Try
            Return objDatos.VerificarSiYaMatriculado(id_estudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerAnoAcademicoActual() As Integer
        Try
            Return objDatos.ObtenerAnoAcademicoActual()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function TieneOrdenPendiente(id_estudiante As Integer) As Boolean
        Try
            Return objDatos.TieneOrdenPendiente(id_estudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerSeccionDeOrdenPendiente(idEstudiante As Integer) As DataTable
        Try
            Return objDatos.ObtenerSeccionDeOrdenPendiente(idEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub SimularPagoBanco(codigoCIP As String)
        Try
            objDatos.SimularPagoBanco(codigoCIP)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class
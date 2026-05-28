Imports System.Data
Imports capaDatos

Public Class clsLogConsultaMatriculas

    Dim objDatos As New clsDatConsultaMatriculas()

    Private Function AgregarFilaTodos(dt As DataTable,
                                  colId As String,
                                  colNombre As String,
                                  texto As String) As DataTable
        Dim dtNuevo As New DataTable()
        dtNuevo.Columns.Add(colId, GetType(Integer))
        dtNuevo.Columns.Add(colNombre, GetType(String))


        Dim filaTodos As DataRow = dtNuevo.NewRow()
        filaTodos(colId) = 0
        filaTodos(colNombre) = texto
        dtNuevo.Rows.Add(filaTodos)


        For Each fila As DataRow In dt.Rows
            Dim nuevaFila As DataRow = dtNuevo.NewRow()
            nuevaFila(colId) = Convert.ToInt32(fila(colId))
            nuevaFila(colNombre) = fila(colNombre).ToString()
            dtNuevo.Rows.Add(nuevaFila)
        Next

        Return dtNuevo
    End Function

    Public Function ObtenerNiveles(idAno As Integer) As DataTable
        Try
            Return AgregarFilaTodos(objDatos.ObtenerNiveles(idAno),
                                "id_nivel", "nombre", "-- Todos --")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerGradosPorNivel(idNivel As Integer, idAno As Integer) As DataTable
        Try
            Return AgregarFilaTodos(objDatos.ObtenerGradosPorNivel(idNivel, idAno),
                                "id_grado", "nombre", "-- Todos --")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerSeccionesPorGrado(idGrado As Integer, idAno As Integer) As DataTable
        Try
            Return AgregarFilaTodos(objDatos.ObtenerSeccionesPorGrado(idGrado, idAno),
                                "id_seccion", "nombre", "-- Todas --")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ConsultarMatriculas(idNivel As Integer,
                                        idGrado As Integer,
                                        idSeccion As Integer,
                                        ano As Integer) As DataTable
        Try
            Return objDatos.ConsultarMatriculas(idNivel, idGrado, idSeccion, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerResumen(idNivel As Integer,
                                   idGrado As Integer,
                                   idSeccion As Integer,
                                   ano As Integer) As DataTable
        Try
            Return objDatos.ObtenerResumen(idNivel, idGrado, idSeccion, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ValidarAno(txtAno As String) As Integer
        If String.IsNullOrWhiteSpace(txtAno) Then Return 0
        Dim ano As Integer
        If Not Integer.TryParse(txtAno.Trim(), ano) Then
            Throw New Exception("El año debe ser un número válido (ej: 2026).")
        End If
        If ano < 2000 OrElse ano > 2100 Then
            Throw New Exception("Ingrese un año válido entre 2000 y 2100.")
        End If
        Return ano
    End Function


    Public Function ObtenerAnoAcademicoActual() As Integer
        Try
            Return objDatos.ObtenerAnoAcademicoActual()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerAnioTexto(idAno As Integer) As String
        If idAno = 0 Then Return "Sin año activo"

        Try
            Return Date.Today.Year.ToString()
        Catch
            Return idAno.ToString()
        End Try
    End Function

End Class
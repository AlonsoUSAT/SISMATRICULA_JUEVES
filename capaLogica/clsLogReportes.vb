Imports capaDatos

Public Class clsLogReportes

    Public Function ListarMisDocentes() As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()
            ' Consultamos directo a PERSONA filtrando por tipo Docente para no cruzarnos con los IDs de Rodrigo
            Dim query As String = "SELECT id_persona, " &
                             "(nombre + ' ' + apePaterno + ' ' + apeMaterno) AS NombreCompleto " &
                             "FROM PERSONA WHERE UPPER(tipo) = 'DOCENTE' AND vigencia = 1"

            Dim cmd As New SqlClient.SqlCommand(query, objConexion.miConexion)
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error local al listar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarHistoricoCarga(idAno As Integer) As DataTable
        Dim objDatos As New ClsDatReportes() ' O el nombre de tu clase de datos
        Return objDatos.ObtenerHistoricoCarga(idAno)
    End Function
End Class

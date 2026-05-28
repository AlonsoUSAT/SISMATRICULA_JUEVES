Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatGenerarOrdenPago

    Dim objConexion As New clsConectaBD()


    Public Function BuscarEstudianteYBeca(num_doc As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT E.id_estudiante, " &
                                    "E.id_apoderado, " &
                                  "P_Est.nombre + ' ' + P_Est.apePaterno + ' ' + P_Est.apeMaterno AS Estudiante, " &
                                  "P_Apo.nombre + ' ' + P_Apo.apePaterno + ' ' + P_Apo.apeMaterno AS Apoderado, " &
                                  "ISNULL(TB.descripcion, 'NINGUNA') AS TipoBeca, " &
                                  "ISNULL(TB.porcentaje_descuento, 0) AS DescuentoBeca " &
                                  "FROM PERSONA P_Est " &
                                  "INNER JOIN ESTUDIANTE E ON P_Est.id_persona = E.id_persona " &
                                  "LEFT JOIN PERSONA P_Apo ON E.id_apoderado = P_Apo.id_persona " &
                                "LEFT JOIN ASIGNACION_BECA AB ON E.id_estudiante = AB.id_estudiante AND AB.estado = 'ACTIVA' " &
                                  "LEFT JOIN TIPO_BECA TB ON AB.id_tipo_beca = TB.id_tipo_beca " &
                                  "WHERE P_Est.num_doc = @doc AND P_Est.tipo = 'ESTUDIANTE'"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al buscar estudiante: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function


    Public Function ListarNiveles() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim idAno As Integer = ObtenerAnoAcademicoActual()
            Dim query As String = "SELECT id_nivel, nombre FROM NIVEL 
                               WHERE id_anoAcademico = @idAno 
                               ORDER BY nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAno", idAno)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function ListarGrados(id_nivel As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT G.id_grado, G.nombre FROM GRADO G
                               INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel
                               WHERE G.id_nivel = @id_nivel
                               ORDER BY G.nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_nivel", id_nivel)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function ListarSecciones(id_grado As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_seccion, nombre FROM SECCION 
                               WHERE id_grado = @id_grado
                               ORDER BY nombre"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_grado", id_grado)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function


    Public Function ConsultarVacantesDisponibles(id_seccion As Integer) As Integer
        Dim cuposDisponibles As Integer = 0
        Try
            objConexion.conectar()
            Dim query As String = "SELECT S.aforo - COUNT(M.id_matricula) AS VacantesDisponibles " &
                              "FROM SECCION S " &
                              "LEFT JOIN MATRICULA M ON S.id_seccion = M.id_seccion AND M.estadoMatricula = 1 " &
                              "WHERE S.id_seccion = @id_sec " &
                              "GROUP BY S.aforo"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_sec", id_seccion)
            Dim resultado = cmd.ExecuteScalar()
            cuposDisponibles = If(resultado IsNot Nothing, Convert.ToInt32(resultado), 0)
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al consultar vacantes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return cuposDisponibles
    End Function


    Public Sub RegistrarOrdenPago(id_estudiante As Integer, codCIP As String,
                               montoBase As Decimal, descuento As Decimal,
                               montoTotal As Decimal, fechaVenc As Date,
                               id_seccion As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO PAGO_MATRICULA " &
              "(id_estudiante, fechaEmision, fechaVencimiento, montoBase, descuento, montoTotal, numeroReferencia, estado, id_seccion) " &
              "VALUES (@idEst, @fechaEmision, @fechaVenc, @base, @dcto, @total, @ref, 0, @idSec)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", id_estudiante)
            cmd.Parameters.AddWithValue("@fechaEmision", DateTime.Now)
            cmd.Parameters.AddWithValue("@fechaVenc", fechaVenc)
            cmd.Parameters.AddWithValue("@base", montoBase)
            cmd.Parameters.AddWithValue("@dcto", descuento)
            cmd.Parameters.AddWithValue("@total", montoTotal)
            cmd.Parameters.AddWithValue("@ref", codCIP)
            cmd.Parameters.AddWithValue("@idSec", id_seccion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al generar orden: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function ListarTiposDocumento() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_tipoDocumento, nombreTipoDocumento FROM TIPO_DOCUMENTO WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al cargar tipos de documento: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function VerificarSiYaMatriculado(id_estudiante As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "SELECT COUNT(*) FROM MATRICULA WHERE id_estudiante = @idEst AND estadoMatricula = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", id_estudiante)
            Dim cantidad As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return cantidad > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar matrícula: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


    Public Function ObtenerAnoAcademicoActual() As Integer
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_anoAcademico FROM ANO_ACADEMICO " &
                                  "WHERE GETDATE() BETWEEN fechaInicio AND fechaFin " &
                                  "AND estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            Dim resultado = cmd.ExecuteScalar()
            Return If(resultado IsNot Nothing, Convert.ToInt32(resultado), 0)
        Catch ex As Exception
            Throw New Exception("Error al obtener año académico: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


    Public Function TieneOrdenPendiente(id_estudiante As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "SELECT COUNT(*) FROM PAGO_MATRICULA " &
                                  "WHERE id_estudiante = @idEst AND estado = 0"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", id_estudiante)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar orden pendiente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function ObtenerSeccionDeOrdenPendiente(idEstudiante As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT TOP 1
                N.id_nivel,
                G.id_grado,
                S.id_seccion
            FROM PAGO_MATRICULA PM
            INNER JOIN SECCION S ON PM.id_seccion = S.id_seccion
            INNER JOIN GRADO   G ON S.id_grado    = G.id_grado
            INNER JOIN NIVEL   N ON G.id_nivel    = N.id_nivel
            WHERE PM.id_estudiante = @idEst
            ORDER BY PM.id_pagoMatricula DESC"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al obtener sección: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub SimularPagoBanco(codigoCIP As String)
        Try
            objConexion.conectar()
            Dim query As String = "
            UPDATE PAGO_MATRICULA 
            SET codigoOperativo = @codOp,
                estado = 1
            WHERE numeroReferencia = @cip"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@codOp", "OP" & DateTime.Now.ToString("ddMMyyyyHHmmss"))
            cmd.Parameters.AddWithValue("@cip", codigoCIP)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al simular pago: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

End Class
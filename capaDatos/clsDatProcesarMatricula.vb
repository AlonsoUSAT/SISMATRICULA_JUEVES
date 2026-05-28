Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatProcesarMatricula

    Dim objConexion As New clsConectaBD()


    Public Function BuscarPagoPorDNI(numDoc As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
    SELECT TOP 1
        PM.id_pagoMatricula,
        PM.id_estudiante,
        PM.fechaEmision,
        PM.codigoOperativo,
        PM.montoTotal,
        PM.numeroReferencia,
        PM.estado,
        PM.fechaVencimiento,
        PM.montoBase,
        PM.descuento,
        P.nombre  + ' ' + P.apePaterno  + ' ' + P.apeMaterno  AS nombreEstudiante,
        PA.nombre + ' ' + PA.apePaterno + ' ' + PA.apeMaterno AS nombreApoderado
    FROM PAGO_MATRICULA PM
    INNER JOIN ESTUDIANTE E  ON PM.id_estudiante = E.id_estudiante
    INNER JOIN PERSONA    P  ON E.id_persona     = P.id_persona
    INNER JOIN APODERADO  A  ON E.id_apoderado   = A.id_apoderado
    INNER JOIN PERSONA    PA ON A.id_persona     = PA.id_persona
    WHERE P.num_doc = @numDoc
    ORDER BY PM.id_pagoMatricula DESC"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@numDoc", numDoc)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar por DNI: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function BuscarPagoPorCodOperativo(codigoOperativo As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
SELECT TOP 1
    PM.id_pagoMatricula,
    PM.id_estudiante,
    PM.fechaEmision,
    PM.codigoOperativo,
    PM.montoTotal,
    PM.numeroReferencia,
    PM.estado,
    PM.fechaVencimiento,
    PM.montoBase,
    PM.descuento,
    P.nombre  + ' ' + P.apePaterno  + ' ' + P.apeMaterno  AS nombreEstudiante,
    PA.nombre + ' ' + PA.apePaterno + ' ' + PA.apeMaterno AS nombreApoderado
FROM PAGO_MATRICULA PM
INNER JOIN ESTUDIANTE E  ON PM.id_estudiante = E.id_estudiante
INNER JOIN PERSONA    P  ON E.id_persona     = P.id_persona
INNER JOIN APODERADO  A  ON E.id_apoderado   = A.id_apoderado
INNER JOIN PERSONA    PA ON A.id_persona     = PA.id_persona
WHERE PM.codigoOperativo = @codOp
ORDER BY PM.id_pagoMatricula DESC"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@codOp", codigoOperativo)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar por Cód. Operativo: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ObtenerBecaActiva(idEstudiante As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
                SELECT 
                    TB.descripcion          AS beca,
                    TB.porcentaje_descuento
                FROM ASIGNACION_BECA AB
                INNER JOIN TIPO_BECA TB ON AB.id_tipo_beca = TB.id_tipo_beca
                WHERE AB.id_estudiante  = @idEst
               AND AB.estado = 'ACTIVA'"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener beca: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ObtenerNivelGradoSeccion(idEstudiante As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
    SELECT TOP 1
        N.nombre    AS nivel,
        G.nombre    AS grado,
        S.nombre    AS seccion,
        S.id_seccion
  FROM PAGO_MATRICULA PM
LEFT JOIN MATRICULA  M  ON PM.id_estudiante = M.id_estudiante AND M.estadoMatricula = 1
JOIN SECCION S ON ISNULL(M.id_seccion, PM.id_seccion) = S.id_seccion
JOIN GRADO   G ON S.id_grado  = G.id_grado
JOIN NIVEL   N ON G.id_nivel  = N.id_nivel
WHERE PM.id_estudiante = @idEst
ORDER BY PM.id_pagoMatricula DESC"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener Nivel/Grado/Sección: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ObtenerCronograma(idEstudiante As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT 
                CP.concepto          AS [Concepto],
                CP.fechaVencimiento  AS [Vencimiento],
                CP.deuda             AS [Monto],
                CASE CP.estado 
                    WHEN 1 THEN 'PAGADO' 
                    ELSE 'PENDIENTE' 
                END                  AS [Estado]
            FROM CRONOGRAMA_PAGO CP
            INNER JOIN MATRICULA M ON CP.id_matricula = M.id_matricula
            WHERE M.id_estudiante = @idEst
            ORDER BY CP.id_cronograma"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al obtener cronograma: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ProcesarMatricula(idPagoMatricula As Integer,
                                  idEstudiante As Integer,
                                  idSeccion As Integer,
                                  idAnoAcademico As Integer,
                                  observacion As String,
                                  montoBase As Decimal,
                                  porcentajeBeca As Decimal) As Boolean
        Try
            objConexion.conectar()
            Dim tran As SqlTransaction = objConexion.miConexion.BeginTransaction()

            Try

                Dim sqlPago As String = "UPDATE PAGO_MATRICULA SET estado = 1 WHERE id_pagoMatricula = @idPago"
                Dim cmdPago As New SqlCommand(sqlPago, objConexion.miConexion, tran)
                cmdPago.Parameters.AddWithValue("@idPago", idPagoMatricula)
                cmdPago.ExecuteNonQuery()


                Dim sqlMatricula As String = "
    INSERT INTO MATRICULA 
        (id_estudiante, id_seccion, id_pagoMatricula, fecha, observacionMatricula, estadoMatricula)
    VALUES 
        (@idEst, @idSec, @idPago, GETDATE(), @observacion, 1);
    SELECT SCOPE_IDENTITY();"

                Dim cmdMat As New SqlCommand(sqlMatricula, objConexion.miConexion, tran)
                cmdMat.Parameters.AddWithValue("@idEst", idEstudiante)
                cmdMat.Parameters.AddWithValue("@idSec", idSeccion)
                cmdMat.Parameters.AddWithValue("@idPago", idPagoMatricula)
                cmdMat.Parameters.AddWithValue("@observacion", If(String.IsNullOrWhiteSpace(observacion), "Ninguna", observacion))


                Dim idMatricula As Integer = Convert.ToInt32(cmdMat.ExecuteScalar())


                Dim descuento As Decimal = montoBase * (porcentajeBeca / 100)
                Dim montoPension As Decimal = Math.Round(montoBase - descuento, 2)


                For i As Integer = 1 To 10
                    Dim sqlCrono As String = "
                    INSERT INTO CRONOGRAMA_PAGO
                        (id_matricula, fechaVencimiento, fechaPagoRealizado, deuda, estado, concepto)
                    VALUES
                        (@idMat, @fechaVenc, NULL, @deuda, 0, @concepto)"

                    Dim cmdCrono As New SqlCommand(sqlCrono, objConexion.miConexion, tran)
                    cmdCrono.Parameters.AddWithValue("@idMat", idMatricula)
                    cmdCrono.Parameters.AddWithValue("@fechaVenc", New DateTime(2026, i + 2, 10))
                    cmdCrono.Parameters.AddWithValue("@deuda", montoPension)
                    cmdCrono.Parameters.AddWithValue("@concepto", "Pensión " & i.ToString("D2"))
                    cmdCrono.ExecuteNonQuery()
                Next

                tran.Commit()
                Return True

            Catch ex As Exception
                tran.Rollback()
                Throw New Exception("Error en transacción: " & ex.Message)
            End Try

        Catch ex As Exception
            Throw New Exception("Error al procesar matrícula: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function


    Public Function YaEstaMatriculado(idEstudiante As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "SELECT COUNT(*) FROM MATRICULA 
                               WHERE id_estudiante = @idEst 
                               AND estadoMatricula = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            Throw New Exception("Error al verificar matrícula: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function ObtenerObservacionMatricula(idEstudiante As Integer) As String
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT TOP 1 observacionMatricula 
            FROM MATRICULA 
            WHERE id_estudiante = @idEst 
            AND estadoMatricula = 1
            ORDER BY id_matricula DESC"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idEst", idEstudiante)
            Dim resultado = cmd.ExecuteScalar()
            Return If(resultado Is Nothing OrElse IsDBNull(resultado), "", resultado.ToString())
        Catch ex As Exception
            Return ""
        Finally
            objConexion.desconectar()
        End Try
    End Function

End Class
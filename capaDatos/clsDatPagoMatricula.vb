Imports System.Data.SqlClient

Public Class clsDatPagoMatricula
    Dim objConexion As New clsConectaBD()

    ' 1. LISTAR PAGOS
    Public Function ListarPagos() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_pagoMatricula, fechaPago, codigoOperativo, monto, numeroReferencia, estado FROM PAGO_MATRICULA WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar pagos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' 2. INSERTAR NUEVO PAGO
    Public Function InsertarPago(fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "INSERT INTO PAGO_MATRICULA (fechaPago, codigoOperativo, monto, numeroReferencia, estado) VALUES (@fechaPago, @codOperativo, @monto, @numReferencia, 1)"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@fechaPago", fechaPago)
            cmd.Parameters.AddWithValue("@codOperativo", codOperativo)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@numReferencia", numReferencia)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al insertar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 3. ACTUALIZAR PAGO
    Public Function ActualizarPago(id As Integer, fechaPago As Date, codOperativo As String, monto As Integer, numReferencia As Integer, estado As Boolean) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PAGO_MATRICULA SET fechaPago = @fechaPago, codigoOperativo = @codOperativo, monto = @monto, numeroReferencia = @numReferencia, estado = @estado WHERE id_pagoMatricula = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@fechaPago", fechaPago)
            cmd.Parameters.AddWithValue("@codOperativo", codOperativo)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@numReferencia", numReferencia)
            cmd.Parameters.AddWithValue("@estado", estado)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al actualizar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    ' 4. DAR DE BAJA
    Public Function DarDeBajaPago(id As Integer) As Boolean
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE PAGO_MATRICULA SET estado = 0 WHERE id_pagoMatricula = @id"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
            Return filasAfectadas > 0
        Catch ex As Exception
            Throw New Exception("Error al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Function ListarAnosAcademicos() As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()
            ' 🌟 CONCATENAMOS LAS FECHAS: Formato "AAAA-MM-DD / AAAA-MM-DD"
            Dim query As String = "SELECT id_anoAcademico, " &
                                 "(CONVERT(VARCHAR, fechaInicio, 111) + '  al  ' + CONVERT(VARCHAR, fechaFin, 111)) AS Periodo " &
                                 "FROM ANO_ACADEMICO WHERE estado = 1"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al traer años: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ObtenerCargaFiltrada(idDocente As Integer, idNivel As Integer, idGrado As Integer, idSeccion As Integer, idAno As Integer) As DataTable
        Dim dt As New DataTable()
        Dim objConexion As New clsConectaBD()
        Try
            objConexion.conectar()

            ' Query base estructurado (uniendo también la tabla ANO_ACADEMICO)
            ' 🌟 Cambiamos la primera línea para meter el periodo concatenado con el alias [Periodo]
            Dim query As String = "SELECT " &
    "(CONVERT(VARCHAR, AA.fechaInicio, 111) + '  al  ' + CONVERT(VARCHAR, AA.fechaFin, 111)) AS [Periodo], " & ' 👈 ESTA ES LA LÍNEA MODIFICADA
    "(P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno) AS [Docente], " &
    "N.nombre AS [Nivel], G.nombre AS [Grado], S.nombre AS [Sección], " &
    "C.nombreCurso AS [Curso], H.diaSemana AS [Día], " &
    "(CONVERT(VARCHAR(5), H.horaInicio, 108) + ' - ' + CONVERT(VARCHAR(5), H.horaFin, 108)) AS [Horario] " &
    "FROM CARGA_ACADEMICA CA " &
    "INNER JOIN DOCENTE D ON CA.id_docente = D.id_docente " &
    "INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
    "INNER JOIN CURSO C ON CA.id_curso = C.id_curso " &
    "INNER JOIN SECCION S ON CA.id_seccion = S.id_seccion " &
    "INNER JOIN GRADO G ON S.id_grado = G.id_grado " &
    "INNER JOIN NIVEL N ON G.id_nivel = N.id_nivel " &
    "INNER JOIN ANO_ACADEMICO AA ON N.id_anoAcademico = AA.id_anoAcademico " &
    "INNER JOIN HORARIO H ON CA.id_horario = H.id_horario " &
    "WHERE CA.estado = 1 "

            ' 🌟 FILTROS DINÁMICOS
            If idDocente <> -1 Then query &= " AND P.id_persona = @idDocente" ' Usando id_persona de tu método blindado
            If idNivel <> -1 Then query &= " AND G.id_nivel = @idNivel"
            If idGrado <> -1 Then query &= " AND S.id_grado = @idGrado"
            If idSeccion <> -1 Then query &= " AND CA.id_seccion = @idSeccion"
            If idAno <> -1 Then query &= " AND AA.id_anoAcademico = @idAno" ' 👈 NUEVO FILTRO DE AÑO

            Dim cmd As New SqlCommand(query, objConexion.miConexion)

            If idDocente <> -1 Then cmd.Parameters.AddWithValue("@idDocente", idDocente)
            If idNivel <> -1 Then cmd.Parameters.AddWithValue("@idNivel", idNivel)
            If idGrado <> -1 Then cmd.Parameters.AddWithValue("@idGrado", idGrado)
            If idSeccion <> -1 Then cmd.Parameters.AddWithValue("@idSeccion", idSeccion)
            If idAno <> -1 Then cmd.Parameters.AddWithValue("@idAno", idAno) ' 👈 NUEVO PARÁMETRO

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error en consulta de carga: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

End Class

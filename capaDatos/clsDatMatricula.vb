Imports System.Data
Imports System.Data.SqlClient

Public Class clsDatMatricula

    Private objConexion As New clsConectaBD()
    Private comando As New SqlCommand()


    Public Function ListarTiposDocumento() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion


            comando.CommandText = "SELECT id_tipoDocumento, nombreTipoDocumento FROM TIPO_DOCUMENTO"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()

            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al listar tipos de documento: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function



    Public Function BuscarEstudiantePorDNI(dni As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion


            comando.CommandText = "SELECT E.id_estudiante, " &
                                  "(PE.nombre + ' ' + PE.apePaterno + ' ' + PE.apeMaterno) AS NombreEstudiante, " &
                                  "(PA.nombre + ' ' + PA.apePaterno + ' ' + PA.apeMaterno) AS NombreApoderado " &
                                  "FROM ESTUDIANTE E " &
                                  "INNER JOIN PERSONA PE ON E.id_persona = PE.id_persona " &
                                  "INNER JOIN APODERADO A ON E.id_apoderado = A.id_apoderado " &
                                  "INNER JOIN PERSONA PA ON A.id_persona = PA.id_persona " &
                                  "WHERE PE.num_doc = @numeroDocumento"

            comando.CommandType = CommandType.Text

            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@numeroDocumento", dni)

            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error en BD al buscar estudiante: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function



    Public Function ListarNiveles() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT id_nivel, nombre FROM NIVEL"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al listar niveles: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ListarGradosPorNivel(id_nivel As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT id_grado, nombre FROM GRADO WHERE id_nivel = @id_nivel"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id_nivel", id_nivel)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al listar grados: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function


    Public Function ListarSeccionesPorGrado(id_grado As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion
            comando.CommandText = "SELECT id_seccion, nombre FROM SECCION WHERE id_grado = @id_grado AND estado = 1"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id_grado", id_grado)
            Dim leer As SqlDataReader = comando.ExecuteReader()
            dt.Load(leer)
        Catch ex As Exception
            Throw New Exception("Error al listar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function



    Public Function RegistrarTransaccionMatricula(idEstudiante As Integer, idSeccion As Integer, montoPago As Decimal, codOperativo As String, refBancaria As String) As Boolean
        Return True
    End Function

    Public Function ObtenerVacantesDisponibles(id_seccion As Integer) As Integer
        Dim vacantesDisponibles As Integer = 0
        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion


            comando.CommandText = "SELECT (S.aforo - (SELECT COUNT(*) FROM VACANTE WHERE id_seccion = @id_seccion)) AS Disponibles " &
                                  "FROM SECCION S WHERE S.id_seccion = @id_seccion"
            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@id_seccion", id_seccion)

            Dim resultado As Object = comando.ExecuteScalar()
            If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                vacantesDisponibles = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            Throw New Exception("Error al calcular vacantes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return vacantesDisponibles
    End Function


    Public Function ProcesarMatricula(id_estudiante As Integer, id_seccion As Integer, monto As Decimal, codOperativo As String, refBancaria As String, observacion As String) As Boolean
        Dim exito As Boolean = False
        Dim transaccion As SqlTransaction = Nothing

        Try
            objConexion.conectar()
            comando.Connection = objConexion.miConexion

            transaccion = objConexion.miConexion.BeginTransaction()
            comando.Transaction = transaccion


            comando.CommandText = "INSERT INTO PAGO_MATRICULA (fechaPago, codigoOperativo, monto, numeroReferencia) " &
                                  "VALUES (@fechaPago, @codigoOperativo, @monto, @numeroReferencia); " &
                                  "SELECT SCOPE_IDENTITY();"

            comando.CommandType = CommandType.Text
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@fechaPago", DateTime.Now.Date)
            comando.Parameters.AddWithValue("@codigoOperativo", codOperativo)
            comando.Parameters.AddWithValue("@monto", monto)
            comando.Parameters.AddWithValue("@numeroReferencia", refBancaria)

            Dim idPagoGenerado As Integer = Convert.ToInt32(comando.ExecuteScalar())


            comando.CommandText = "INSERT INTO MATRICULA (fecha, observacionMatricula, estadoPagoMatricula, estadoMatricula, id_seccion, id_pagoMatricula, id_estudiante) " &
                                  "VALUES (@fechaMat, @observacion, 1, 1, @id_seccion, @id_pagoMatricula, @id_estudiante); " &
                                  "SELECT SCOPE_IDENTITY();"

            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@fechaMat", DateTime.Now.Date)

            comando.Parameters.AddWithValue("@observacion", observacion)
            comando.Parameters.AddWithValue("@id_seccion", id_seccion)
            comando.Parameters.AddWithValue("@id_pagoMatricula", idPagoGenerado)
            comando.Parameters.AddWithValue("@id_estudiante", id_estudiante)


            Dim idMatriculaGenerada As Integer = Convert.ToInt32(comando.ExecuteScalar())


            comando.CommandText = "INSERT INTO CRONOGRAMA_PAGO (fechaVencimiento, fechaPagoRealizado, deuda, estado, id_matricula, concepto) " &
                                  "VALUES (@fechaVencimiento, NULL, @deuda, 0, @id_matricula, @concepto)"

            Dim montoPension As Decimal = 350.0

            For i As Integer = 3 To 12
                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@fechaVencimiento", New DateTime(DateTime.Now.Year, i, 10))
                comando.Parameters.AddWithValue("@deuda", montoPension)
                comando.Parameters.AddWithValue("@id_matricula", idMatriculaGenerada)
                comando.Parameters.AddWithValue("@concepto", "Pensión " & (i - 2).ToString("D2"))


                comando.ExecuteNonQuery()
            Next

            transaccion.Commit()
            exito = True

        Catch ex As Exception
            If transaccion IsNot Nothing Then
                transaccion.Rollback()
            End If
            Throw New Exception("Error al guardar en la BD: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try

        Return exito
    End Function
End Class
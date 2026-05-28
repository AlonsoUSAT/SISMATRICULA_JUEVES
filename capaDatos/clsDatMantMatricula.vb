Imports System.Data.SqlClient
Imports System.Data

Public Class clsDatMantMatricula
    Dim objConexion As New clsConectaBD()

    Public Function BuscarMatriculaPorDoc(numDoc As String) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT 
                M.id_matricula,
                M.estadoMatricula,
                M.fecha,
                M.observacionMatricula,
                P.nombre + ' ' + P.apePaterno + ' ' + P.apeMaterno AS estudiante,
                N.nombre    AS nivel,
                G.nombre    AS grado,
                S.id_seccion,
                S.nombre    AS seccion,
                G.id_grado
            FROM MATRICULA M
            INNER JOIN ESTUDIANTE E  ON M.id_estudiante = E.id_estudiante
            INNER JOIN PERSONA    P  ON E.id_persona    = P.id_persona
            INNER JOIN SECCION    S  ON M.id_seccion    = S.id_seccion
            INNER JOIN GRADO      G  ON S.id_grado      = G.id_grado
            INNER JOIN NIVEL      N  ON G.id_nivel      = N.id_nivel
            WHERE P.num_doc = @numDoc
            AND M.estadoMatricula = 1
            ORDER BY M.id_matricula DESC"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@numDoc", numDoc)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al buscar matrícula: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarTiposDocumento() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_tipoDocumento, nombreTipoDocumento FROM TIPO_DOCUMENTO WHERE estado = 1"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al cargar tipos de documento: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarSeccionesPorGrado(idGrado As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_seccion, nombre FROM SECCION WHERE id_grado = @idGrado"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idGrado", idGrado)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al listar secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ConsultarVacantes(idSeccion As Integer) As Integer
        Try
            objConexion.conectar()
            Dim query As String = "
            SELECT S.aforo - COUNT(M.id_matricula) AS VacantesDisponibles
            FROM SECCION S
            LEFT JOIN MATRICULA M ON S.id_seccion = M.id_seccion AND M.estadoMatricula = 1
            WHERE S.id_seccion = @idSec
            GROUP BY S.aforo"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idSec", idSeccion)
            Dim resultado = cmd.ExecuteScalar()
            Return If(resultado IsNot Nothing, Convert.ToInt32(resultado), 0)
        Catch ex As Exception
            Throw New Exception("Error al consultar vacantes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Function

    Public Sub ActualizarMatricula(idMatricula As Integer, idSeccion As Integer, observacion As String)
        Try
            objConexion.conectar()
            Dim query As String = "
            UPDATE MATRICULA 
            SET id_seccion = @idSec,
                observacionMatricula = @obs
            WHERE id_matricula = @idMat"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idSec", idSeccion)
            cmd.Parameters.AddWithValue("@obs", If(String.IsNullOrWhiteSpace(observacion), "Ninguna", observacion))
            cmd.Parameters.AddWithValue("@idMat", idMatricula)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al actualizar matrícula: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

End Class
Imports System.Data.SqlClient

Public Class clsApertura
    Dim objConexion As New clsConectaBD()

    ' === Métodos para llenar Combos ===

    Public Function GetAniosDistinct() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' Seleccionamos el ID y extraemos solo el año de la fechaInicio
            Dim query As String = "SELECT id_anoAcademico, YEAR(fechaInicio) AS Anio FROM ano_academico ORDER BY Anio DESC"
            Dim adapter As New SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar años: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function GetNivelesPorAnio(idAnio As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT id_nivel, nombre FROM nivel WHERE id_anoAcademico = @idAnio"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAnio", idAnio)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar niveles por año: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function GetGradosPorNivel(idNivel As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' Asegúrate de usar el campo correcto para estado/vigencia si existe en GRADO
            Dim query As String = "SELECT id_grado, nombre FROM GRADO WHERE id_nivel = @idNivel"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idNivel", idNivel)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al cargar grados por nivel: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    ' === Método de Inserción (Tabla SECCION) ===

    Public Sub RegistrarSeccion(id_grado As Integer, nombreSeccion As String, aforo As Integer)
        Try
            objConexion.conectar()
            ' Verifica si ya existe la misma letra (nombre) para ese grado antes de insertar
            Dim query As String = "IF NOT EXISTS (SELECT 1 FROM SECCION WHERE id_grado = @idGrado AND nombre = @nombreSec) " &
                                  "BEGIN " &
                                  "INSERT INTO SECCION (id_grado, nombre, aforo, vigencia, id_docente_tutor) " &
                                  "VALUES (@idGrado, @nombreSec, @aforo, 1, NULL) " &
                                  "END"
            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idGrado", id_grado)
            cmd.Parameters.AddWithValue("@nombreSec", nombreSeccion)
            cmd.Parameters.AddWithValue("@aforo", aforo)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al registrar sección: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' === Método para Listado (dgvTabla) ===

    Public Function BuscarGruposAsignadosListado(idAnio As Integer, idNivel As Integer) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT " &
                                  "YEAR(AA.fechaInicio) AS Año, " &
                                  "NI.nombre AS Nivel, " &
                                  "GR.nombre AS Grado, " &
                                  "S.nombre AS Sección, " &
                                  "S.aforo AS Aforo, " &
                                  "CASE WHEN S.vigencia = 1 THEN 'VIGENTE' ELSE 'INACTIVA' END AS Estado " &
                                  "FROM SECCION S " &
                                  "INNER JOIN GRADO GR ON S.id_grado = GR.id_grado " &
                                  "INNER JOIN nivel NI ON GR.id_nivel = NI.id_nivel " &
                                  "INNER JOIN ano_academico AA ON NI.id_anoAcademico = AA.id_anoAcademico " &
                                  "WHERE NI.id_anoAcademico = @idAnio AND GR.id_nivel = @idNivel"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idAnio", idAnio)
            cmd.Parameters.AddWithValue("@idNivel", idNivel)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al buscar listado de secciones: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function
End Class
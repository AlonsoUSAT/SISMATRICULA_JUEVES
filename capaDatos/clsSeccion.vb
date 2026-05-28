' --- CAPA DATOS (clsSeccion) ---
Imports System.Data
Imports System.Data.SqlClient

Public Class clsSeccion
    Dim objConexion As New clsConectaBD()

    ' NUEVO: Obtiene los años académicos extrayendo el año de fechaInicio
    Public Function ListarAnosAcademicos() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim da As New SqlDataAdapter("SELECT id_anoAcademico, YEAR(fechaInicio) as Anio FROM ANO_ACADEMICO", objConexion.miConexion)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    ' MODIFICADO: Ahora filtra los niveles por el id_anoAcademico seleccionado
    Public Function ListarNiveles(id_anoAcademico As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("SELECT id_nivel, nombre FROM NIVEL WHERE id_anoAcademico = @id_anoAcademico", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_anoAcademico", id_anoAcademico)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarGrados(id_nivel As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("SELECT id_grado, nombre as Grado_Academico FROM GRADO WHERE id_nivel = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_nivel)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarTutores() As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Selecciona id_docente (para guardar en SECCION) y hace JOIN con PERSONA para el nombre
            Dim cmd As New SqlCommand("SELECT d.id_docente, p.nombre + ' ' + p.apePaterno + ' ' + p.apeMaterno AS NombreCompleto FROM DOCENTE d INNER JOIN PERSONA p ON d.id_persona = p.id_persona", objConexion.miConexion)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Function ListarSecciones(id_grado As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            objConexion.conectar()
            ' Hace el JOIN desde SECCION -> DOCENTE -> PERSONA para obtener el nombre en la grilla
            Dim cmd As New SqlCommand("SELECT s.id_seccion, s.nombre as Nombre, s.aforo as Aforo, s.id_docente_tutor, p.nombre + ' ' + p.apePaterno + ' ' + p.apeMaterno as Tutor, s.vigencia as Vigencia FROM SECCION s LEFT JOIN DOCENTE d ON s.id_docente_tutor = d.id_docente LEFT JOIN PERSONA p ON d.id_persona = p.id_persona WHERE s.id_grado = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_grado)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Finally
            objConexion.desconectar()
        End Try
        Return dt
    End Function

    Public Sub InsertarSeccion(id_grado As Integer, nombre As String, aforo As Integer, id_docente_tutor As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("INSERT INTO SECCION (id_grado, nombre, aforo, id_docente_tutor) VALUES (@id_grado, @nombre, @aforo, @id_docente_tutor)", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_grado", id_grado)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@aforo", aforo)
            cmd.Parameters.AddWithValue("@id_docente_tutor", id_docente_tutor)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub ModificarSeccion(id_seccion As Integer, nombre As String, aforo As Integer, id_docente_tutor As Integer, vigencia As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("UPDATE SECCION SET nombre=@nombre, aforo=@aforo, id_docente_tutor=@id_docente_tutor, vigencia=@vigencia WHERE id_seccion=@id_seccion", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id_seccion", id_seccion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@aforo", aforo)
            cmd.Parameters.AddWithValue("@id_docente_tutor", id_docente_tutor)
            cmd.Parameters.AddWithValue("@vigencia", vigencia)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarSeccion(id_seccion As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("DELETE FROM SECCION WHERE id_seccion=@id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_seccion)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaSeccion(id_seccion As Integer)
        Try
            objConexion.conectar()
            Dim cmd As New SqlCommand("UPDATE SECCION SET vigencia = 0 WHERE id_seccion = @id", objConexion.miConexion)
            cmd.Parameters.AddWithValue("@id", id_seccion)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub
End Class
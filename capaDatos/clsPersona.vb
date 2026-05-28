Imports System.Data.SqlClient

Public Class clsPersona
    ' Instanciamos tu clase de conexión
    Dim objConexion As New clsConectaBD()

    '---------------------------APODERADOS---------------------------'

    Public Sub RegistrarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            objConexion.conectar()

            ' El súper script: Inserta en PERSONA, captura el ID, y al instante lo inserta en APODERADO
            Dim query As String = "DECLARE @id_nueva_persona INT; " &
                                  "INSERT INTO persona (apeMaterno, apePaterno, nombre, telefono, correo, vigencia, tipo, id_tipoDocumento, sexo, num_doc) " &
                                  "VALUES (@apeMaterno, @apePaterno, @nombre, @telefono, @correo, 1, 'APODERADO', 1, @sexo, @num_doc); " &
                                  "SET @id_nueva_persona = SCOPE_IDENTITY(); " &
                                  "INSERT INTO APODERADO (id_persona) VALUES (@id_nueva_persona);"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeMaterno", apeMaterno)
            cmd.Parameters.AddWithValue("@apePaterno", apePaterno)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@num_doc", num_doc)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al registrar apoderado: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function MostrarPersonas() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT apePaterno + ' ' + apeMaterno as Apellidos, nombre as Nombres, num_doc as Numero_Documento, 
                                    telefono as Telefono, correo as Correo, sexo as Sexo, vigencia as Vigencia
                                    FROM persona WHERE tipo = 'APODERADO'"
            Dim adapter As New SqlClient.SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function



    Public Sub EditarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            objConexion.conectar()
            ' Se actualiza usando num_doc en el WHERE
            Dim query As String = "UPDATE persona SET apeMaterno=@apeM, apePaterno=@apeP, nombre=@nom, telefono=@tel, correo=@cor, sexo=@sex WHERE num_doc=@doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeM", apeMaterno)
            cmd.Parameters.AddWithValue("@apeP", apePaterno)
            cmd.Parameters.AddWithValue("@nom", nombre)
            cmd.Parameters.AddWithValue("@tel", telefono)
            cmd.Parameters.AddWithValue("@cor", correo)
            cmd.Parameters.AddWithValue("@sex", sexo)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarPersona(num_doc As String)
        Try
            objConexion.conectar()
            ' Se elimina usando el número de documento como identificador
            Dim query As String = "DELETE FROM persona WHERE num_doc = @doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al eliminar: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaPersona(num_doc As String)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE persona SET vigencia = 0 WHERE num_doc = @doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al dar de baja: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub



    '---------------------------ESTUDIANTES---------------------------'
    Public Function MostrarEstudiantes() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' Hacemos un INNER JOIN para traer los datos de la persona y su tipo de estudiante
            Dim query As String = "SELECT P.apePaterno + ' ' + P.apeMaterno as Apellidos, P.nombre as Nombres, " &
                              "P.num_doc as Numero_Documento, P.telefono as Telefono, E.tipoEstudiante as Tipo_Estudiante,
                              P.correo as Correo, " & "P.sexo as Sexo, P.vigencia as Vigencia " &
                              "FROM PERSONA P " &
                              "INNER JOIN ESTUDIANTE E ON P.id_persona = E.id_persona " &
                              "WHERE P.tipo = 'ESTUDIANTE'"
            Dim adapter As New SqlClient.SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al mostrar estudiantes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub RegistrarEstudiante(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, tipoEstudiante As String, id_apoderado As Integer)
        Try
            objConexion.conectar()

            ' El súper script: Inserta en Persona, captura el ID, y luego inserta en Estudiante
            Dim query As String = "DECLARE @id_nueva_persona INT; " &
                                  "INSERT INTO persona (apeMaterno, apePaterno, nombre, telefono, correo, vigencia, tipo, id_tipoDocumento, sexo, num_doc) " &
                                  "VALUES (@apeMaterno, @apePaterno, @nombre, @telefono, @correo, 1, 'ESTUDIANTE', 1, @sexo, @num_doc); " &
                                  "SET @id_nueva_persona = SCOPE_IDENTITY(); " &
                                  "INSERT INTO ESTUDIANTE (tipoEstudiante, id_apoderado, id_persona) " &
                                  "VALUES (@tipoEstudiante, @idApoderado, @id_nueva_persona);"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeMaterno", apeMaterno)
            cmd.Parameters.AddWithValue("@apePaterno", apePaterno)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@num_doc", num_doc)
            ' Los 2 parámetros nuevos:
            cmd.Parameters.AddWithValue("@tipoEstudiante", tipoEstudiante)
            cmd.Parameters.AddWithValue("@idApoderado", id_apoderado)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al registrar estudiante: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EditarEstudiante(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, tipoEstudiante As String)
        Try
            objConexion.conectar()

            ' Súper script que actualiza PERSONA y también busca al ESTUDIANTE para actualizarle su tipo
            Dim query As String = "UPDATE PERSONA SET apeMaterno=@apeM, apePaterno=@apeP, nombre=@nom, telefono=@tel, correo=@cor, sexo=@sex WHERE num_doc=@doc; " &
                                  "UPDATE E SET E.tipoEstudiante = @tipo FROM ESTUDIANTE E INNER JOIN PERSONA P ON E.id_persona = P.id_persona WHERE P.num_doc=@doc;"

            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeM", apeMaterno)
            cmd.Parameters.AddWithValue("@apeP", apePaterno)
            cmd.Parameters.AddWithValue("@nom", nombre)
            cmd.Parameters.AddWithValue("@tel", telefono)
            cmd.Parameters.AddWithValue("@cor", correo)
            cmd.Parameters.AddWithValue("@sex", sexo)
            cmd.Parameters.AddWithValue("@doc", num_doc)

            ' El nuevo parámetro
            cmd.Parameters.AddWithValue("@tipo", tipoEstudiante)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al editar estudiante: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarEstudiante(num_doc As String)
        Try
            objConexion.conectar()

            ' Súper script: Busca el ID, borra en ESTUDIANTE (hijo) y luego en PERSONA (padre)
            Dim query As String = "DECLARE @id INT; " &
                                  "SELECT @id = id_persona FROM PERSONA WHERE num_doc = @doc; " &
                                  "DELETE FROM ESTUDIANTE WHERE id_persona = @id; " &
                                  "DELETE FROM PERSONA WHERE id_persona = @id;"

            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al eliminar estudiante: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    ' ==========================================================
    ' MÉTODOS PARA EL PANEL DERECHO (BUSCAR Y ASIGNAR APODERADO)
    ' ==========================================================

    Public Function BuscarApoderadoPorDNI(num_doc As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            Dim query As String = "SELECT A.id_apoderado, P.nombre, P.apePaterno, P.apeMaterno, P.telefono, P.correo " &
                                  "FROM PERSONA P INNER JOIN APODERADO A ON P.id_persona = A.id_persona " &
                                  "WHERE P.num_doc = @doc AND P.tipo = 'APODERADO'"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al buscar apoderado: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub ActualizarApoderadoDeEstudiante(num_doc_estudiante As String, id_apoderado_nuevo As Integer)
        Try
            objConexion.conectar()
            Dim query As String = "UPDATE E SET E.id_apoderado = @idApo " &
                                  "FROM ESTUDIANTE E INNER JOIN PERSONA P ON E.id_persona = P.id_persona " &
                                  "WHERE P.num_doc = @docEst"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@idApo", id_apoderado_nuevo)
            cmd.Parameters.AddWithValue("@docEst", num_doc_estudiante)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al asignar apoderado en BD: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    '--------------Docentes-----------'
    Public Function MostrarDocentes() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' INNER JOIN para traer los datos de la persona junto con su especialidad y estado
            Dim query As String = "SELECT P.apePaterno + ' ' + P.apeMaterno as Apellidos, P.nombre as Nombres, " &
                                  "P.num_doc as Numero_Documento, P.telefono as Telefono, " &
                                  "E.nombre as Especialidad, P.correo as Correo, " &
                                  "P.sexo as Sexo, D.estado as Estado " &
                                  "FROM PERSONA P " &
                                  "INNER JOIN DOCENTE D ON P.id_persona = D.id_persona " &
                                  "INNER JOIN Especialidad E ON D.id_especialidad = E.id_especialidad " &
                                  "WHERE P.tipo = 'DOCENTE'"
            Dim adapter As New SqlClient.SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al mostrar docentes: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Sub RegistrarDocente(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, id_especialidad As Integer)
        Try
            objConexion.conectar()

            ' El súper script: Inserta en PERSONA, captura el ID, y al instante lo inserta en DOCENTE
            Dim query As String = "DECLARE @id_nueva_persona INT; " &
                              "INSERT INTO persona (apeMaterno, apePaterno, nombre, telefono, correo, vigencia, tipo, id_tipoDocumento, sexo, num_doc) " &
                              "VALUES (@apeMaterno, @apePaterno, @nombre, @telefono, @correo, 1, 'DOCENTE', 1, @sexo, @num_doc); " &
                              "SET @id_nueva_persona = SCOPE_IDENTITY(); " &
                              "INSERT INTO DOCENTE (id_especialidad, estado, id_persona) " &
                              "VALUES (@id_esp, 1, @id_nueva_persona);"

            Dim cmd As New SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeMaterno", apeMaterno)
            cmd.Parameters.AddWithValue("@apePaterno", apePaterno)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@num_doc", num_doc)
            cmd.Parameters.AddWithValue("@id_esp", id_especialidad)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al registrar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EditarDocente(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, id_especialidad As Integer)
        Try
            objConexion.conectar()

            ' Súper script que actualiza PERSONA y también busca al DOCENTE para actualizarle su especialidad
            Dim query As String = "UPDATE PERSONA SET apeMaterno=@apeM, apePaterno=@apeP, nombre=@nom, telefono=@tel, correo=@cor, sexo=@sex WHERE num_doc=@doc; " &
                                  "UPDATE D SET D.id_especialidad = @id_esp FROM DOCENTE D INNER JOIN PERSONA P ON D.id_persona = P.id_persona WHERE P.num_doc=@doc;"

            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@apeM", apeMaterno)
            cmd.Parameters.AddWithValue("@apeP", apePaterno)
            cmd.Parameters.AddWithValue("@nom", nombre)
            cmd.Parameters.AddWithValue("@tel", telefono)
            cmd.Parameters.AddWithValue("@cor", correo)
            cmd.Parameters.AddWithValue("@sex", sexo)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.Parameters.AddWithValue("@id_esp", id_especialidad)


            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al editar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub EliminarDocente(num_doc As String)
        Try
            objConexion.conectar()

            ' Súper script: Busca el ID, borra en DOCENTE (hijo) y luego en PERSONA (padre)
            Dim query As String = "DECLARE @id INT; " &
                                  "SELECT @id = id_persona FROM PERSONA WHERE num_doc = @doc; " &
                                  "DELETE FROM DOCENTE WHERE id_persona = @id; " &
                                  "DELETE FROM PERSONA WHERE id_persona = @id;"

            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Capa Datos al eliminar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub DarBajaDocente(num_doc As String)
        Try
            objConexion.conectar()
            ' Cambia el estado del docente a 0 (inactivo) usando el num_doc de la persona
            Dim query As String = "UPDATE D SET D.estado = 0 " &
                                  "FROM DOCENTE D INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                                  "WHERE P.num_doc = @doc"

            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al dar de baja al docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Sub ActivarDocente(num_doc As String)
        Try
            objConexion.conectar()
            ' Cambia el estado del docente a 1 (activo)
            Dim query As String = "UPDATE D SET D.estado = 1 " &
                                  "FROM DOCENTE D INNER JOIN PERSONA P ON D.id_persona = P.id_persona " &
                                  "WHERE P.num_doc = @doc"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en Datos al activar al docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
    End Sub

    Public Function BuscarDocentePorDNI(num_doc As String) As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' Se agregó el INNER JOIN para obtener el nombre de la especialidad si se busca un DNI en específico
            Dim query As String = "SELECT D.id_docente, P.nombre, P.apePaterno, P.apeMaterno, " &
                              "P.telefono, P.correo, E.nombre as Especialidad, D.estado " &
                              "FROM PERSONA P INNER JOIN DOCENTE D ON P.id_persona = D.id_persona " &
                              "INNER JOIN Especialidad E ON D.id_especialidad = E.id_especialidad " &
                              "WHERE P.num_doc = @doc AND P.tipo = 'DOCENTE'"
            Dim cmd As New System.Data.SqlClient.SqlCommand(query, objConexion.miConexion)
            cmd.Parameters.AddWithValue("@doc", num_doc)
            Dim adapter As New SqlClient.SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error al buscar docente: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

    Public Function ListarEspecialidades() As DataTable
        Dim tabla As New DataTable()
        Try
            objConexion.conectar()
            ' Ajusta el nombre de la tabla si es necesario (ej: ESPECIALIDAD)
            Dim query As String = "SELECT id_especialidad, nombre FROM Especialidad WHERE estado = 1"
            Dim adapter As New SqlClient.SqlDataAdapter(query, objConexion.miConexion)
            adapter.Fill(tabla)
        Catch ex As Exception
            Throw New Exception("Error en Datos al listar especialidades: " & ex.Message)
        Finally
            objConexion.desconectar()
        End Try
        Return tabla
    End Function

End Class
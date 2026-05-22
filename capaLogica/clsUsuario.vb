Imports capaDatos
Imports BCrypt.Net

Public Class clsUsuario

    Private obj As New capaDatos.clsUsuario()

    ' ══════════════════════════════════════════════
    '  SIGUIENTE ID
    ' ══════════════════════════════════════════════
    Public Function ObtenerSiguienteID() As Integer
        Return obj.ObtenerSiguienteID()
    End Function

    ' ══════════════════════════════════════════════
    '  MOSTRAR
    ' ══════════════════════════════════════════════
    Public Function MostrarUsuarios() As DataTable
        Return obj.Mostrar()
    End Function

    ' ══════════════════════════════════════════════
    '  VALIDACIONES COMPARTIDAS
    ' ══════════════════════════════════════════════
    Private Sub ValidarCamposObligatorios(nombres As String, apellidoPaterno As String,
                                          clave As String, nomUsuario As String)
        If String.IsNullOrWhiteSpace(nombres) Then
            Throw New Exception("El campo 'Nombres' es obligatorio.")
        End If
        If String.IsNullOrWhiteSpace(apellidoPaterno) Then
            Throw New Exception("El campo 'Apellido Paterno' es obligatorio.")
        End If
        If String.IsNullOrWhiteSpace(clave) Then
            Throw New Exception("El campo 'Clave' es obligatorio.")
        End If
        If clave.Length < 6 Then
            Throw New Exception("La clave debe tener al menos 6 caracteres.")
        End If
        If String.IsNullOrWhiteSpace(nomUsuario) Then
            Throw New Exception("El campo 'Nombre de Usuario' es obligatorio.")
        End If
    End Sub

    Private Sub ValidarCorreo(correo As String)
        If Not String.IsNullOrWhiteSpace(correo) Then
            ' Validación básica de formato de correo
            Dim regex As New System.Text.RegularExpressions.Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
            If Not regex.IsMatch(correo) Then
                Throw New Exception("El formato del correo electrónico no es válido.")
            End If
        End If
    End Sub

    ' ══════════════════════════════════════════════
    '  INSERTAR (encripta la clave con BCrypt)
    ' ══════════════════════════════════════════════
    Public Sub InsertarUsuario(nombres As String, apellidoPaterno As String,
                                apellidoMaterno As String, correo As String,
                                sexo As Char, clave As String, estado As Boolean,
                                nomUsuario As String, pregunta As String, respuesta As String)

        ' 1. Validar campos obligatorios
        ValidarCamposObligatorios(nombres, apellidoPaterno, clave, nomUsuario)
        ValidarCorreo(correo)

        ' 2. Verificar duplicados
        If Not String.IsNullOrWhiteSpace(correo) AndAlso obj.ExisteCorreo(correo) Then
            Throw New Exception("Ya existe un usuario registrado con ese correo electrónico.")
        End If
        If obj.ExisteNomUsuario(nomUsuario) Then
            Throw New Exception("El nombre de usuario '" & nomUsuario & "' ya está en uso.")
        End If

        ' 3. Encriptar la clave con BCrypt (factor de coste 12 = muy seguro)
        Dim claveHash As String = BCrypt.Net.BCrypt.HashPassword(clave, workFactor:=12)

        ' 4. Insertar en BD
        obj.Insertar(nombres, apellidoPaterno, apellidoMaterno, correo,
                     sexo, claveHash, estado, nomUsuario, pregunta, respuesta)
    End Sub

    ' ══════════════════════════════════════════════
    '  EDITAR
    '  Si clave viene vacía, se conserva la anterior (no se re-encripta)
    ' ══════════════════════════════════════════════
    Public Sub EditarUsuario(id As Integer, nombres As String, apellidoPaterno As String,
                              apellidoMaterno As String, correo As String, sexo As Char,
                              clave As String, estado As Boolean, nomUsuario As String,
                              pregunta As String, respuesta As String)

        ' Validar campos (clave puede ser vacía en edición = no cambiar)
        If String.IsNullOrWhiteSpace(nombres) Then Throw New Exception("El campo 'Nombres' es obligatorio.")
        If String.IsNullOrWhiteSpace(apellidoPaterno) Then Throw New Exception("El campo 'Apellido Paterno' es obligatorio.")
        If String.IsNullOrWhiteSpace(nomUsuario) Then Throw New Exception("El campo 'Nombre de Usuario' es obligatorio.")
        ValidarCorreo(correo)

        ' Validar duplicados excluyendo el propio registro
        If Not String.IsNullOrWhiteSpace(correo) AndAlso obj.ExisteCorreo(correo, id) Then
            Throw New Exception("Ya existe otro usuario con ese correo electrónico.")
        End If
        If obj.ExisteNomUsuario(nomUsuario, id) Then
            Throw New Exception("El nombre de usuario '" & nomUsuario & "' ya está en uso por otro usuario.")
        End If

        ' Encriptar solo si se ingresó nueva clave
        Dim claveHash As String = ""
        If Not String.IsNullOrWhiteSpace(clave) Then
            If clave.Length < 6 Then Throw New Exception("La nueva clave debe tener al menos 6 caracteres.")
            claveHash = BCrypt.Net.BCrypt.HashPassword(clave, workFactor:=12)
        End If

        obj.Editar(id, nombres, apellidoPaterno, apellidoMaterno, correo,
                   sexo, claveHash, estado, nomUsuario, pregunta, respuesta)
    End Sub

    ' ══════════════════════════════════════════════
    '  DAR DE BAJA
    ' ══════════════════════════════════════════════
    Public Sub DarBajaUsuario(id As Integer, estado As Boolean)
        obj.DarBaja(id, estado)
    End Sub

    ' ══════════════════════════════════════════════
    '  ELIMINAR
    ' ══════════════════════════════════════════════
    Public Sub EliminarUsuario(id As Integer)
        obj.Eliminar(id)
    End Sub

    ' ══════════════════════════════════════════════
    '  AUTENTICAR: verifica usuario + BCrypt
    '  Retorna: 0=no existe/inactivo, 1=clave incorrecta, 2=OK (devuelve pregunta y respuestaHash)
    ' ══════════════════════════════════════════════
    Public Function AutenticarUsuario(nomUsuario As String, clave As String,
                                       ByRef pregunta As String,
                                       ByRef respuestaHash As String) As Integer
        If String.IsNullOrWhiteSpace(nomUsuario) OrElse String.IsNullOrWhiteSpace(clave) Then
            Throw New Exception("Debe ingresar usuario y contraseña.")
        End If

        Dim fila As DataRow = obj.ObtenerUsuarioLogin(nomUsuario)

        ' Usuario no encontrado o inactivo
        If fila Is Nothing Then Return 0
        If Not CBool(fila("estado")) Then Return 0

        ' Verificar clave con BCrypt
        Dim claveHashBD As String = fila("clave").ToString()
        If Not BCrypt.Net.BCrypt.Verify(clave, claveHashBD) Then Return 1

        ' Clave correcta → devolver pregunta y hash de respuesta
        pregunta = If(IsDBNull(fila("pregunta")), "", fila("pregunta").ToString())
        respuestaHash = If(IsDBNull(fila("respuesta")), "", fila("respuesta").ToString())
        Return 2
    End Function

    ' ══════════════════════════════════════════════
    '  VERIFICAR RESPUESTA
    ' ══════════════════════════════════════════════
    Public Function VerificarRespuesta(respuestaIngresada As String, respuestaHash As String) As Boolean
        If String.IsNullOrWhiteSpace(respuestaIngresada) Then Return False
        Return String.Equals(respuestaIngresada.Trim().ToLower(),
                             respuestaHash.Trim().ToLower(),
                             StringComparison.OrdinalIgnoreCase)
    End Function



End Class

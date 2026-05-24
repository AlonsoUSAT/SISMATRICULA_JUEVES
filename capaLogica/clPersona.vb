Imports System
Imports System.Data ' Importante agregar esto para poder usar "DataTable"
Imports capaDatos

Public Class clPersona
    Dim objCapaDatos As New clsPersona()

    '---------------------------APODERADOS---------------------------'


    ' --- EL MÉTODO QUE YA TENÍAS ---
    Public Sub InsertarApoderado(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            ' Aquí podrías validar reglas de negocio (ej. que el documento tenga 8 dígitos)
            objCapaDatos.RegistrarPersona(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------
    ' --- NUEVOS MÉTODOS PARA SOLUCIONAR TUS ERRORES DE COMPILACIÓN ---
    ' -------------------------------------------------------------------

    ' 1. Mostrar Personas (Generalmente devuelve una tabla para llenar tu DataGridView)


    ' 2. Insertar Persona (Asumo parámetros básicos, ajústalos si tu formulario envía más o menos datos)
    Public Sub InsertarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            ' Descomenta la siguiente línea cuando crees el método en clsPersona (Capa Datos)
            ' objCapaDatos.InsertarPersona(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 3. Editar Persona (Requiere el ID para saber a quién actualizar)
    Public Sub EditarPersona(id_persona As Integer, apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            ' Descomenta la siguiente línea cuando crees el método en clsPersona (Capa Datos)
            ' objCapaDatos.EditarPersona(id_persona, apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 4. Eliminar Persona (Solo requiere el ID)
    Public Sub EliminarPersona(id_persona As Integer)
        Try
            ' Descomenta la siguiente línea cuando crees el método en clsPersona (Capa Datos)
            ' objCapaDatos.EliminarPersona(id_persona)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function MostrarPersonas() As DataTable
        Try
            Return objCapaDatos.MostrarPersonas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub DarBajaPersona(id_persona As Integer)
        Try
            objCapaDatos.DarBajaPersona(id_persona)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarPersona(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String)
        Try
            objCapaDatos.EditarPersona(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarPersona(num_doc As String)
        Try
            ' Validaciones adicionales pueden ir aquí
            objCapaDatos.EliminarPersona(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DarBajaPersona(num_doc As String)
        Try
            objCapaDatos.DarBajaPersona(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    '---------------------------ESTUDIANTES---------------------------'
    Public Function MostrarEstudiantes() As DataTable
        Try
            Return objCapaDatos.MostrarEstudiantes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Sub InsertarEstudiante(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, tipoEstudiante As String, id_apoderado As Integer)
        Try
            ' Pasamos todo a la capa de datos usando el nombre correcto
            objCapaDatos.RegistrarEstudiante(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc, tipoEstudiante, id_apoderado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EditarEstudiante(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, tipoEstudiante As String)
        Try
            objCapaDatos.EditarEstudiante(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc, tipoEstudiante)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub EliminarEstudiante(num_doc As String)
        Try
            objCapaDatos.EliminarEstudiante(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscarApoderadoPorDNI(num_doc As String) As DataTable
        Try
            Return objCapaDatos.BuscarApoderadoPorDNI(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarApoderadoDeEstudiante(num_doc_estudiante As String, id_apoderado_nuevo As Integer)
        Try
            objCapaDatos.ActualizarApoderadoDeEstudiante(num_doc_estudiante, id_apoderado_nuevo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    '---------------------------Docente---------------------------'
    ' 1. Mostrar Docentes (devuelve la tabla para llenar tu DataGridView)
    Public Function MostrarDocentes() As DataTable
        Try
            Return objCapaDatos.MostrarDocentes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' 2. Insertar / Registrar Docente
    Public Sub InsertarDocente(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, especialidad As String)
        Try
            ' Aquí podrías validar reglas de negocio (ej. que el documento tenga 8 dígitos)
            objCapaDatos.RegistrarDocente(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc, especialidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 3. Editar Docente
    Public Sub EditarDocente(apeMaterno As String, apePaterno As String, nombre As String, telefono As String, correo As String, sexo As String, num_doc As String, especialidad As String)
        Try
            objCapaDatos.EditarDocente(apeMaterno, apePaterno, nombre, telefono, correo, sexo, num_doc, especialidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 4. Eliminar Docente (usa el número de documento como identificador)
    Public Sub EliminarDocente(num_doc As String)
        Try
            ' Validaciones adicionales pueden ir aquí
            objCapaDatos.EliminarDocente(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 5. Dar de baja al Docente (estado = 0)
    Public Sub DarBajaDocente(num_doc As String)
        Try
            objCapaDatos.DarBajaDocente(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 6. Activar al Docente (estado = 1)
    Public Sub ActivarDocente(num_doc As String)
        Try
            objCapaDatos.ActivarDocente(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' 7. Buscar Docente por DNI
    Public Function BuscarDocentePorDNI(num_doc As String) As DataTable
        Try
            Return objCapaDatos.BuscarDocentePorDNI(num_doc)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
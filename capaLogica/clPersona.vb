Imports System
Imports System.Data ' Importante agregar esto para poder usar "DataTable"
Imports capaDatos

Public Class clPersona
    Dim objCapaDatos As New clsPersona()

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

End Class
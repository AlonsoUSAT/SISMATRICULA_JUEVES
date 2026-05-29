Imports System.Data
Imports capaDatos

Public Class clsLogMantAreaAcademica

    Dim objDatos As New clsDatMantAreaAcademica()

    Public Function Listar() As DataTable
        Try
            Return objDatos.Listar()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub Insertar(nombre As String)
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New Exception("El nombre del área no puede estar vacío.")
        End If
        If objDatos.ExisteNombre(nombre.Trim(), 0) Then
            Throw New Exception("Ya existe un área académica con ese nombre.")
        End If
        Try
            objDatos.Insertar(nombre.Trim().ToUpper())
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar(idArea As Integer, nombre As String, activo As Boolean)
        If idArea <= 0 Then
            Throw New Exception("Seleccione un área de la tabla para modificar.")
        End If
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New Exception("El nombre del área no puede estar vacío.")
        End If
        If objDatos.ExisteNombre(nombre.Trim(), idArea) Then
            Throw New Exception("Ya existe otra área académica con ese nombre.")
        End If
        Try
            objDatos.Actualizar(idArea, nombre.Trim().ToUpper(), activo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DarBaja(idArea As Integer)
        If idArea <= 0 Then
            Throw New Exception("Seleccione un área de la tabla para dar de baja.")
        End If
        Try
            objDatos.DarBaja(idArea)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar(idArea As Integer)
        If idArea <= 0 Then
            Throw New Exception("Seleccione un área de la tabla para eliminar.")
        End If
        Try
            objDatos.Eliminar(idArea)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ObtenerSiguienteId() As Integer
        Try
            Return objDatos.ObtenerSiguienteId()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TieneCursosAsociados(idArea As Integer) As Boolean
        Try
            Return objDatos.TieneCursosAsociados(idArea)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
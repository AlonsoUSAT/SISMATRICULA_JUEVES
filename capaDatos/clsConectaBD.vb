'importaciones de espacios de nombre
'Imports System.Data 'ADO Net 
Imports System.Data.SqlClient

Public Class clsConectaBD
    Private cn As SqlConnection

    Sub New()

        cn = New SqlConnection
        'BDLocal - Autenticaciòn windows
        cn.ConnectionString = "Data Source=localhost\SQLExpress;Initial Catalog=SistemaMatricula;Integrated Security=SSPI;Language=Spanish"
        'BDLocal - Autenticaciòn SQL Server
        'cn.ConnectionString = "Server=localhost;Database=SistemaMatricula;Integrated Security=True;"
        'BD en la nube somee.com
        'cn.ConnectionString = "workstation id=BDPersonal2024.mssql.somee.com;packet size=4096;user id=cdelcastillo_SQLLogin_1;pwd=wptf98uw6j;data source=BDPersonal2024.mssql.somee.com;persist security info=False;initial catalog=BDPersonal2024;language=spanish"


    End Sub

    Public Sub conectar()
        Try
            If cn.State = Data.ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectar a BD: " & ex.Message)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            If cn.State <> Data.ConnectionState.Closed Then
                cn.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectar a BD: " & ex.Message)
        End Try
    End Sub

    Public ReadOnly Property estadoCN() As String
        Get
            If cn.State = Data.ConnectionState.Open Then
                Return "BD está abierta."

            Else
                Return "BD está cerrada."
            End If
        End Get
    End Property

    Public ReadOnly Property miConexion() As SqlConnection
        Get
            Return cn
        End Get
    End Property

    Public ReadOnly Property Servidor() As String
        Get
            Return cn.DataSource.ToString
        End Get
    End Property

    Public Sub abrirconexion()
        Try
            'transaccion = False
            If cn.State <> Data.ConnectionState.Open Then ' SI EL ESTADO DE  LA CONEXION ES DIFERENTE DE ABIERTO ENTONCES ABRE LA CONEXION
                cn.ConnectionString = "Data Source=localhost\SQLExpress;Initial Catalog=SistemaMatricula;Integrated Security=SSPI;Language=Spanish"
                cn.Open()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Public Sub cerrarconexion()
        Try
            'transaccion = False
            If cn.State = Data.ConnectionState.Open Then
                cn.Close()
                cn.Dispose()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Public Sub abrirconexionTrans()
        'Try
        '    If transaccion <> True Then
        '        abrirconexion()
        '        tsql = cn.BeginTransaction()
        '        transaccion = True
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try

    End Sub

    Public Sub cerrarconexionTrans()
        'Try
        '    If transaccion = True Then
        '        tsql.Commit()
        '        cerrarconexion()
        '        transaccion = False
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try
    End Sub

    Public Sub cancelarconexionTrans()
        'Try
        '    If transaccion = True Then
        '        tsql.Rollback()
        '        cerrarconexion()
        '        transaccion = False
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, Err.Source, Err.Description)
        'End Try
    End Sub
End Class

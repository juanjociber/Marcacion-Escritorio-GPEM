Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class ConexGesman
    'Public cnxgesman As MySqlConnection = New MySqlConnection(ConfigurationManager.ConnectionStrings("gesmanmysql").ToString)
    'Public Function abrirConexion() As MySqlConnection
    '    If cnxgesman.State = ConnectionState.Closed Then
    '        cnxgesman.Open()
    '    End If
    '    Return cnxgesman
    'End Function

    'Public Function cerrarConexion() As MySqlConnection
    '    If cnxgesman.State = ConnectionState.Open Then
    '        cnxgesman.Close()
    '    End If
    '    Return cnxgesman
    'End Function



    Private cadena As String = ConfigurationManager.ConnectionStrings("gesmanmysql").ToString
    Protected cnxgesman As New MySqlConnection
    Public cmb As MySqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As MySqlDataAdapter

    Protected Function conectar()
        Try
            cnxgesman = New MySqlConnection(cadena)
            cnxgesman.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Excepcion")
            Return False
        End Try
    End Function

    Protected Function desconectar()
        Try
            If cnxgesman.State = ConnectionState.Open Then
                cnxgesman.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Excepcion")
            Return False
        End Try
    End Function
End Class
Public Class ConexionGesman
    Private Shared connectionString As String = ConfigurationManager.ConnectionStrings("gesmanmysql").ToString
    Public Shared Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class

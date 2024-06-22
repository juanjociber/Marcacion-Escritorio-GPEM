Imports System.Configuration
Imports Npgsql

Public Class ConexOdoo
    ' Public cnxodoo As NpgsqlConnection = New NpgsqlConnection(ConfigurationManager.ConnectionStrings("gpempgsql").ToString)
    'Public cmb As NpgsqlCommandBuilder
    'Public ds As DataSet = New DataSet()
    'Public da As NpgsqlDataAdapter

    Private cadena As String = ConfigurationManager.ConnectionStrings("gpempgsql").ToString
    Protected cnxodoo As New NpgsqlConnection
    Protected Function conectar()
        Try
            cnxodoo = New NpgsqlConnection(cadena)
            cnxodoo.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Excepcion")
            Return False
        End Try
    End Function

    Protected Function desconectar()
        Try
            If cnxodoo.State = ConnectionState.Open Then
                cnxodoo.Close()
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

Public Class ConexionOdoo
    Private Shared connectionString As String = ConfigurationManager.ConnectionStrings("gpempgsql").ToString
    Public Shared Function ObtenerConexion() As NpgsqlConnection
        Return New NpgsqlConnection(connectionString)
    End Function
End Class

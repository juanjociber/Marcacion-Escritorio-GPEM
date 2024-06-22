Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class ConexionBD
    Private Shared connectionString As String = ConfigurationManager.ConnectionStrings("gpemmysql").ToString
    Public Shared Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class

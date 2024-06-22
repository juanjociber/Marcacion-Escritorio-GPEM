Imports MySql.Data.MySqlClient

Public Class fnManActividades
    Inherits ConexGesman
    Public Function fnBuscar(ByVal query As String) As DataTable
        Dim dt As New DataTable
        Try
            conectar()
            Dim da As New MySqlDataAdapter(query, cnxgesman)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
            'MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function
End Class

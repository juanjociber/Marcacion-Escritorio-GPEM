Imports MySql.Data.MySqlClient

Public Class fnPatioOts
    Inherits ConexGesman
    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        Try
            Dim ds As DataSet = New DataSet()
            Dim da As MySqlDataAdapter
            Dim cmb As MySqlCommandBuilder
            ds.Tables.Clear()
            cnxgesman.Open()
            da = New MySqlDataAdapter(sql, cnxgesman)
            cmb = New MySqlCommandBuilder(da)
            da.Fill(ds, tabla)
        Catch ex As Exception
            MsgBox("ERROR EN LA CONSULTA." & Environment.NewLine &
                  ex.Message, MsgBoxStyle.Critical, "ERROR")
        Finally
            cnxgesman.Close()
        End Try
    End Sub
    Public Function Consultas(ByVal query As String) As DataTable
        Dim Tabla As New DataTable
        Try
            conectar()
            Dim da As New MySqlDataAdapter(query, cnxgesman)
            da.Fill(Tabla)
            Return Tabla
        Catch ex As Exception
            Return Nothing
            'MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Function

End Class

Imports Npgsql

Public Class fnOdooConsultas
    Inherits ConexOdoo
    'Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
    '    Try
    '        ds.Tables.Clear()
    '        cnxodoo.Open()
    '        da = New NpgsqlDataAdapter(sql, cnxodoo)
    '        cmb = New NpgsqlCommandBuilder(da)
    '        da.Fill(ds, tabla)
    '    Catch ex As Exception
    '        MessageBox.Show("Error al Conectar: " & ex.Message)
    '    Finally
    '        cnxodoo.Close()
    '    End Try
    'End Sub
End Class

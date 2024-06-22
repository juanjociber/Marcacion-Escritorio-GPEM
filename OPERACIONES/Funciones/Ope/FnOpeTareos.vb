Imports MySql.Data.MySqlClient

Public Class FnOpeTareos
    Inherits ConexGesman
    'Function FnBuscarTareo(ByVal vTareo As Integer) As clsManTareos
    '    Dim TAREO As New clsManTareos
    '    Try
    '        conectar()
    '        Dim cmd As MySqlCommand
    '        cmd = New MySqlCommand("select idot, idpersonal, fecha, personal, dni, ingreso, tmin, estado from man_tareos where idtareo=@IdTareo;", cnxgesman)
    '        cmd.Parameters.AddWithValue("@IdTareo", vTareo)
    '        Dim Lector As MySqlDataReader = cmd.ExecuteReader()
    '        If Lector.Read = True Then
    '            TAREO.IdOt = Lector.GetInt32("idot")
    '            TAREO.IdPersonal = Lector.GetInt32("idpersonal")
    '            TAREO.Fecha = Lector.GetDateTime("fecha")
    '            TAREO.Personal = Lector.GetString("personal")
    '            TAREO.Dni = Lector.GetString("dni")
    '            TAREO.FechaIngreso = Lector.GetDateTime("ingreso")
    '            TAREO.TMin = Lector.GetInt32("tmin")
    '        Else
    '            TAREO = Nothing
    '        End If
    '    Catch ex As Exception
    '        TAREO = Nothing
    '    Finally
    '        desconectar()
    '    End Try
    '    Return TAREO
    'End Function
End Class

Imports MySql.Data.MySqlClient

Public Class fnGhuPersonal
    Inherits ConexGesman
    Function fnBuscarPersonalPorDni(ByVal dni As String) As clsPersonal
        Try
            conectar()
            Dim PERSONAL As New clsPersonal
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("select idpersonal, dni, nombres, apellidos, alias, cargo from ghu_personal where estado=2 and dni=@dni", cnxgesman)
            cmd.Parameters.AddWithValue("@dni", dni)
            Dim Lector As MySqlDataReader = cmd.ExecuteReader()
            If Lector.Read = True Then
                PERSONAL.Id = Lector.GetInt32("idpersonal")
                PERSONAL.Dni = Lector.GetString("dni")
                PERSONAL.Nombres = Lector.GetString("nombres")
                PERSONAL.Apellidos = Lector.GetString("Apellidos")
                PERSONAL.Apellidos = Lector.GetString("alias")
                PERSONAL.Cargo = Lector.GetString("cargo")
                Return PERSONAL
            Else
                PERSONAL = Nothing
            End If
            Return PERSONAL
        Catch ex As Exception
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class

Imports MySql.Data.MySqlClient

Public Class fnManMovimientos
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
            MsgBox("ERROR EN LA FUNCION DE CONSULTA." & Environment.NewLine &
                 ex.Message, MsgBoxStyle.Critical, "ERROR")
        Finally
            cnxgesman.Close()
        End Try
    End Sub
    Public Function fnMontarComponente(ByVal dts As clsManMovimientos) As Integer
        Try
            Dim cmd As MySqlCommand
            cnxgesman.Open()
            cmd = New MySqlCommand("spman_movimientos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idcaso", 2)
            cmd.Parameters.AddWithValue("@_idmovimiento", dts.IDMOVIMIENTO)
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idactivo", dts.IDACTIVO)
            cmd.Parameters.AddWithValue("@_idot", dts.IDOT)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_activo", dts.ACTIVO)
            cmd.Parameters.AddWithValue("@_ot", dts.OT)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_observaciones", dts.OBSERVACIONES)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            'Catch ex As Data.MySqlClient.MySqlException
            MsgBox("ERROR EN LA FUNCION DE ACTUALIZACION." & Environment.NewLine &
                  ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            cnxgesman.Close()
        End Try
    End Function
    Public Function fnDesmontarComponente(ByVal dts As clsManMovimientos) As Integer
        Try
            Dim cmd As MySqlCommand
            cnxgesman.Open()
            cmd = New MySqlCommand("spman_movimientos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idcaso", 3)
            cmd.Parameters.AddWithValue("@_idmovimiento", dts.IDMOVIMIENTO)
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idactivo", dts.IDACTIVO)
            cmd.Parameters.AddWithValue("@_idot", dts.IDOT)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_activo", dts.ACTIVO)
            cmd.Parameters.AddWithValue("@_ot", dts.OT)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_observaciones", dts.OBSERVACIONES)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR EN LA FUNCION DE ACTUALIZACION." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            cnxgesman.Close()
        End Try
    End Function

    Public Function fnRepararComponente(ByVal dts As clsManMovimientos) As Integer
        Try
            Dim cmd As MySqlCommand
            cnxgesman.Open()
            cmd = New MySqlCommand("spman_movimientos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idcaso", 4)
            cmd.Parameters.AddWithValue("@_idmovimiento", dts.IDMOVIMIENTO)
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idactivo", dts.IDACTIVO)
            cmd.Parameters.AddWithValue("@_idot", dts.IDOT)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_activo", dts.ACTIVO)
            cmd.Parameters.AddWithValue("@_ot", dts.OT)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_observaciones", dts.OBSERVACIONES)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR EN LA FUNCION DE ACTUALIZACION" & Environment.NewLine &
                  ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            cnxgesman.Close()
        End Try
    End Function

    Public Function fnBajaComponente(ByVal dts As clsManMovimientos) As Integer
        Try
            Dim cmd As MySqlCommand
            cnxgesman.Open()
            cmd = New MySqlCommand("spman_movimientos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idcaso", 5)
            cmd.Parameters.AddWithValue("@_idmovimiento", dts.IDMOVIMIENTO)
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idactivo", dts.IDACTIVO)
            cmd.Parameters.AddWithValue("@_idot", dts.IDOT)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_activo", dts.ACTIVO)
            cmd.Parameters.AddWithValue("@_ot", dts.OT)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_observaciones", dts.OBSERVACIONES)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR EN LA FUNCION DE ACTUALIZACION" & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            cnxgesman.Close()
        End Try
    End Function
End Class

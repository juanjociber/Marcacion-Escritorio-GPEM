Imports MySql.Data.MySqlClient

Public Class fnManMonitoreos
    Inherits ConexGesman
    Public Function fnBuscar(ByVal query As String) As DataTable
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

    Public Function fnManAgregarMonitoreos(ByVal dts As clsManMonitoreos) As Integer
        Try
            Dim cmd As MySqlCommand
            cnxgesman.Open()
            cmd = New MySqlCommand("spman_monitoreos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idot", dts.IDOT)
            cmd.Parameters.AddWithValue("@_idactivo", dts.IDACTIVO)
            cmd.Parameters.AddWithValue("@_ideval", dts.IDEVAL)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_ot", dts.OT)
            cmd.Parameters.AddWithValue("@_activo", dts.ACTIVO)
            cmd.Parameters.AddWithValue("@_tipoot", dts.TIPOOT)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_observaciones", dts.OBSERVACIONES)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)
            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR DE FUNCION AGREGAR_SEGUIMIENTO." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            cnxgesman.Close()
        End Try
    End Function

    Public Function fnListarMonitoreos() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("VALOPCIONES", GetType(Integer)))
        dt.Columns.Add(New DataColumn("NOMOPCIONES", GetType(String)))
        dt.Rows.Add(0, "[0] Seleccionar")
        dt.Rows.Add(1, "[1] OPTIMO]")
        dt.Rows.Add(2, "[2] LEVE")
        dt.Rows.Add(3, "[3] GRAVE")
        Return dt
    End Function
End Class

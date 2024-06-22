Imports MySql.Data.MySqlClient
Public Class fnManComponentes
    Inherits ConexGesman
    Dim cmd As New MySqlCommand

    'https://es.stackoverflow.com/questions/193269/seguridad-en-mi-conexion-sqlserver-y-vb-net
    'https://www.youtube.com/watch?v=Cb9dUQfe_eY
    'http://pabletoreto.blogspot.com/2012/12/tres-capas-en-vbnet.html
    'https://www.iteramos.com/pregunta/69824/retornar-datatable-visual-basic
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
            MsgBox("ERROR GENERAL EN LA CONSULTA." & Environment.NewLine &
                 ex.Message, MsgBoxStyle.Critical, "ERROR")
        Finally
            cnxgesman.Close()
        End Try
    End Sub
    Public Function fnManAgregarComponente(ByVal dts As clsManComponentes) As Integer
        Try
            Dim cmd As MySqlCommand
            conectar()
            cmd = New MySqlCommand("spman_componentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idevento", 1) 'REGISTRAR COMPONENTE
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idcliente", dts.IDCLIENTE)
            cmd.Parameters.AddWithValue("@_idsistema", dts.IDSISTEMA)
            cmd.Parameters.AddWithValue("@_codigo", dts.CODIGO)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_serie", dts.SERIE)
            cmd.Parameters.AddWithValue("@_marca", dts.MARCA)
            cmd.Parameters.AddWithValue("@_modelo", dts.MODELO)
            cmd.Parameters.AddWithValue("@_sistema", dts.SISTEMA)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR EN LA FUNCION fnManAgregarComponente" & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function
    Public Function fnManHabilitarComponente(ByVal dts As clsManComponentes) As Integer
        Try
            Dim cmd As MySqlCommand
            conectar()
            cmd = New MySqlCommand("spman_componentes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnxgesman
            cmd.Parameters.AddWithValue("@_idevento", 4) 'HABILITAR COMPONENTE
            cmd.Parameters.AddWithValue("@_idcomponente", dts.IDCOMPONENTE)
            cmd.Parameters.AddWithValue("@_idcliente", dts.IDCLIENTE)
            cmd.Parameters.AddWithValue("@_idsistema", dts.IDSISTEMA)
            cmd.Parameters.AddWithValue("@_codigo", dts.CODIGO)
            cmd.Parameters.AddWithValue("@_componente", dts.COMPONENTE)
            cmd.Parameters.AddWithValue("@_serie", dts.SERIE)
            cmd.Parameters.AddWithValue("@_marca", dts.MARCA)
            cmd.Parameters.AddWithValue("@_modelo", dts.MODELO)
            cmd.Parameters.AddWithValue("@_sistema", dts.SISTEMA)
            cmd.Parameters.AddWithValue("@_km", dts.KM)
            cmd.Parameters.AddWithValue("@_usuario", dts.USUARIO)

            Dim param As MySqlParameter = cmd.Parameters.Add("@_retorno", MySqlDbType.Int32)
            param.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            Dim value As Integer = cmd.Parameters("@_retorno").Value
            Return value
        Catch ex As Exception
            MsgBox("ERROR EN LA FUNCION fnManHabilitarComponente" & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function
    Function fnBuscarComponente(ByVal id As Integer) As List(Of clsManComponentes)
        Try
            Dim cmd As MySqlCommand
            conectar()
            Dim Resumen As New List(Of clsManComponentes)
            cmd = New MySqlCommand("select activo, sistema, codigo, componente, serie, marca, modelo, disponible, estado from man_componentes where idcomponente=@id", cnxgesman)
            cmd.Parameters.AddWithValue("@id", id)
            Dim Lector As MySqlDataReader = cmd.ExecuteReader()
            If Lector.Read = True Then
                Dim fila As New clsManComponentes()
                If Lector("activo") IsNot DBNull.Value Then
                    fila.ACTIVO = Lector("activo")
                End If
                fila.SISTEMA = Lector("sistema")
                fila.COMPONENTE = Lector("componente")
                fila.SERIE = Lector("serie")
                fila.SERIE = Lector("marca")
                fila.MARCA = Lector("marca")
                fila.MODELO = Lector("modelo")
                fila.CODIGO = Lector("codigo")
                fila.DISPONIBLE = Lector("disponible")
                fila.ESTADO = Lector("estado")
                Resumen.Add(fila)
                Return Resumen
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function fnListarDisponibilidad() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("VALOPCIONES", GetType(Integer)))
        dt.Columns.Add(New DataColumn("NOMOPCIONES", GetType(String)))
        dt.Rows.Add(0, "[0] Seleccionar")
        dt.Rows.Add(1, "[1] NO DISPONIBLE")
        dt.Rows.Add(2, "[2] DISPONIBLE")
        Return dt
    End Function
    Public Function fnListarEstados() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("VALOPCIONES", GetType(Integer)))
        dt.Columns.Add(New DataColumn("NOMOPCIONES", GetType(String)))
        dt.Rows.Add(0, "[0] Seleccionar")
        dt.Rows.Add(1, "[1] ANULADO")
        dt.Rows.Add(2, "[2] ACTIVO")
        dt.Rows.Add(3, "[3] DE BAJA")
        Return dt
    End Function
End Class

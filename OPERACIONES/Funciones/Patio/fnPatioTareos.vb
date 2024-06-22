Imports MySql.Data.MySqlClient
Public Class fnPatioTareos
    'Inherits ConexGesman
    'Public Function fnBuscar(ByVal query As String) As DataTable
    '    Dim Tabla As New DataTable
    '    Try
    '        conectar()
    '        Dim da As New MySqlDataAdapter(query, cnxgesman)
    '        da.Fill(Tabla)
    '        Return Tabla
    '    Catch ex As Exception
    '        Return Nothing
    '        'MsgBox(ex.Message)
    '    Finally
    '        desconectar()
    '    End Try
    'End Function

    Function FnBuscarTareosPorFecha(personal As Integer, fecha As Date) As List(Of OrdenTareo)
        Dim tareos As New List(Of OrdenTareo)
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT t.idtareo, t.idot, o.ot, o.activo, t.ingreso, t.salida, o.actividad, t.estado FROM man_tareos t INNER JOIN man_ots o ON t.idot=o.idot WHERE t.idpersonal=@IdPersonal AND DATE_FORMAT(t.ingreso, '%Y-%m-%d')=@Fecha;", conn)
                    cmd.Parameters.AddWithValue("@IdPersonal", personal)
                    cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"))
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim tareo As New OrdenTareo()
                            tareo.Id = dr("idtareo")
                            tareo.OrdenId = dr("idot")
                            tareo.OrdenNombre = dr("ot")
                            tareo.EquipoNombre = dr("activo")
                            tareo.OrdenActividad = dr("actividad")
                            If dr("ingreso") IsNot DBNull.Value Then
                                tareo.FechaIngreso = dr("ingreso")
                            End If
                            If dr("salida") IsNot DBNull.Value Then
                                tareo.FechaSalida = dr("salida")
                            End If
                            tareo.Estado = dr("estado")
                            tareos.Add(tareo)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return tareos
    End Function

    Function FnBuscarOrdenTareos(idOrden As Integer) As List(Of Tareo)
        Dim tareos As New List(Of Tareo)()
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT idtareo, idpersonal, personal, ingreso, salida, tmin, estado from man_tareos where idot=@IdOrden;", conn)
                    cmd.Parameters.AddWithValue("@IdOrden", idOrden)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim tareo As New Tareo()
                            tareo.Id = dr("idtareo")
                            tareo.PersonalId = dr("idpersonal")
                            tareo.PersonalNombre = dr("personal")
                            tareo.FechaIngreso = dr("ingreso")
                            If dr("salida") IsNot DBNull.Value Then
                                tareo.FechaSalida = dr("salida")
                            End If
                            tareo.Minutos = dr("tmin")
                            tareo.Estado = dr("estado")
                            tareos.Add(tareo)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return tareos
    End Function

    Public Function FnTareosMin(idEvento As Integer, idTareo As Integer, idOrden As Integer, dni As String) As Integer
        Dim id As Integer = 0
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("spman_tareosmin", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@_idevento", idEvento) '1:Ingreso, 2:Salida
                    cmd.Parameters.AddWithValue("@_idtareo", idTareo)
                    cmd.Parameters.AddWithValue("@_idot", idOrden)
                    cmd.Parameters.AddWithValue("@_dni", dni)
                    Dim param As New MySqlParameter("@_retorno", MySqlDbType.Int32)
                    param.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    id = Convert.ToInt32(cmd.Parameters("@_retorno").Value)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function

    Public Function FnCerrarTareo(tareo As OrdenTareo) As Boolean
        Dim res As Boolean
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("spope_tareos", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@_idevento", 2) '2:CERRAR TAREO
                    cmd.Parameters.AddWithValue("@_idtareo", tareo.Id)
                    cmd.Parameters.AddWithValue("@_idot", tareo.OrdenId)
                    cmd.Parameters.AddWithValue("@_idpersonal", tareo.PersonalId)
                    cmd.Parameters.AddWithValue("@_descripcion", tareo.OrdenDescripcion)
                    cmd.Parameters.AddWithValue("@_observacion", tareo.OrdenObservacion)
                    Dim param As New MySqlParameter("@_retorno", MySqlDbType.Int32)
                    param.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    If Not Convert.ToInt32(cmd.Parameters("@_retorno").Value) = 1 Then
                        Throw New Exception("Error guardando el Tareo.")
                    End If
                    res = True
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return res
    End Function
End Class


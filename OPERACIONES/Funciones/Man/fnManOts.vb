Imports MySql.Data.MySqlClient

Public Class fnManOts
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

    Function FnBuscarOrden(id As Integer) As Orden
        Dim orden As New Orden
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select idot, idactivo, ot, activo, tipoot, fechainicial, actividad, descripcion, observaciones, km, supervisor, cliente, estado from man_ots where idot=@Id;", conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    Using Lector As MySqlDataReader = cmd.ExecuteReader()
                        If Lector.Read = True Then
                            orden.Id = Lector("idot")
                            orden.IdActivo = Lector("idactivo")
                            orden.Orden = Lector("ot")
                            orden.Activo = Lector("activo")
                            orden.TipoOrden = Lector("tipoot")
                            orden.Fecha = Lector("fechainicial")
                            If Lector("actividad") IsNot DBNull.Value Then
                                orden.Actividad = Lector("actividad")
                            End If
                            If Lector("descripcion") IsNot DBNull.Value Then
                                orden.Descripcion = Lector("descripcion")
                            End If
                            If Lector("observaciones") IsNot DBNull.Value Then
                                orden.Observacion = Lector("observaciones")
                            End If
                            orden.Km = Lector("km")
                            orden.Supervisor = Lector("supervisor")
                            orden.Cliente = Lector("cliente")
                            orden.Estado = Lector("estado")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return orden
    End Function

    Function FnBuscarOrdenes(ot As String, fecha As Date, pagina As Integer) As List(Of Orden)
        Dim ordenes As New List(Of Orden)()
        Dim query As String = ""
        If ot.Length > 0 Then
            query = " where ot='" & ot & "'"
        Else
            query = " where fechainicial='" & fecha.ToString("yyyy-MM-dd") & "'"
        End If
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select idot, idactividad, ot, activo, tipoot, origen, fechainicial, actividad, estado from man_ots" & query & " limit @Pagina, 50;", conn)
                    cmd.Parameters.AddWithValue("@Pagina", pagina)
                    Using Lector As MySqlDataReader = cmd.ExecuteReader()
                        While Lector.Read()
                            Dim orden As New Orden()
                            orden.Id = Lector("idot")
                            orden.IdActividad = Lector("idactividad")
                            orden.Orden = Lector("ot")
                            orden.Activo = Lector("activo")
                            orden.TipoOrden = Lector("tipoot")
                            orden.Fecha = Lector("fechainicial")
                            orden.Actividad = Lector("actividad")
                            orden.Estado = Lector("estado")
                            ordenes.Add(orden)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return ordenes
    End Function

End Class

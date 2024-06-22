Imports MySql.Data.MySqlClient

Public Class FnManProductos

    Shared Function FnBuscarActividadProductos(actId As Integer) As List(Of Productos)
        Dim data As New List(Of Productos)()
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select codigo, nombre, cantidad, medida from tblproductosprogramados where idactividad=@ActId and estado=2;", conn)
                    cmd.Parameters.AddWithValue("@ActId", actId)
                    Using Lector As MySqlDataReader = cmd.ExecuteReader()
                        While Lector.Read()
                            Dim producto As New Productos()
                            producto.Codigo = Lector("codigo")
                            producto.Nombre = Lector("nombre")
                            producto.Cantidad = Lector("cantidad")
                            producto.Medida = Lector("medida")
                            data.Add(producto)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return data
    End Function

End Class

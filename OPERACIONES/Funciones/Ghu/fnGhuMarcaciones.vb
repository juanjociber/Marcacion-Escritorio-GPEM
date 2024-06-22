Imports MySql.Data.MySqlClient
Public Class fnGhuMarcaciones

    'Funcion buscar personal por dni de database "bdgesman"
    Function FnBuscarPersonal(dni As String) As clsPersonal
        Dim personal As New clsPersonal
        Try
            Using conn As MySqlConnection = ConexionGesman.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select p.idpersonal, p.nombres, p.apellidos, p.dni, p.alias, c.cargo from ghu_personal p inner join ghu_cargos c on p.idcargo=c.idcargo where p.dni=@Dni and p.estado=2;", conn)
                    cmd.Parameters.AddWithValue("@Dni", dni)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read = True Then
                            personal.Id = dr("idpersonal")
                            personal.Nombres = dr("nombres")
                            personal.Apellidos = dr("apellidos")
                            personal.Apodo = dr("alias")
                            personal.Dni = dr("dni")
                            personal.Cargo = dr("cargo")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return personal
    End Function

    'Funcion buscar personal por dni de database "gpemsac"
    Shared Function FnBuscarPersonalGpemsac(dni As String) As clsPersonal
        Dim personal As New clsPersonal
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select p.pers_codigo, p.pers_nombres, p.pers_apellidos, p.pers_dni, p.pers_alias, c.cargo from tblpersonal p inner join rh_cargos c on p.idcargo=c.idcargo where p.pers_dni=@Dni and p.pers_estado=1;", conn)
                    cmd.Parameters.AddWithValue("@Dni", dni)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read = True Then
                            personal.Id = dr("pers_codigo")
                            personal.Nombres = dr("pers_nombres")
                            personal.Apellidos = dr("pers_apellidos")
                            personal.Apodo = dr("pers_alias")
                            personal.Dni = dr("pers_dni")
                            personal.Cargo = dr("cargo")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return personal
    End Function

    Shared Function FnBuscarMarcacionEnProceso(idPersonal As Integer) As programacion
        Dim programacion As New programacion
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select idmarcacion, fecha, turnofinal, programacion1, programacion2, asistencia1, asistencia2, refrigerio1, refrigerio2, tecnicosino from rh_marcaciones where idpersonal=@IdPersonal and tecnicosino>0 order by fecha desc limit 1;", conn)
                    cmd.Parameters.AddWithValue("@IdPersonal", idPersonal)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read = True Then
                            programacion.Id = dr("idmarcacion")
                            programacion.Fecha = dr("fecha")
                            programacion.Turno = dr("turnofinal")
                            programacion.Programacion1 = dr("programacion1")
                            programacion.Programacion2 = dr("programacion2")
                            If dr("asistencia1") IsNot DBNull.Value Then
                                programacion.Asistencia1 = dr("asistencia1")
                            End If
                            If dr("asistencia2") IsNot DBNull.Value Then
                                programacion.Asistencia2 = dr("asistencia2")
                            End If
                            If dr("refrigerio1") IsNot DBNull.Value Then
                                programacion.Refrigerio1 = dr("refrigerio1")
                            End If
                            If dr("refrigerio2") IsNot DBNull.Value Then
                                programacion.Refrigerio2 = dr("refrigerio2")
                            End If
                            programacion.Tecnicosino = dr("tecnicosino")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return programacion
    End Function

    Shared Function FnBuscarUltimaMarcacionAbierta(perId As Integer, fecha As String) As programacion
        Dim programacion As New programacion
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select idmarcacion, programacion1, programacion2, asistencia1, asistencia2, refrigerio1, refrigerio2, estado, tecnicosino from rh_marcaciones where idpersonal=@PerId and fecha=@Fecha limit 1;", conn)
                    cmd.Parameters.AddWithValue("@PerId", perId)
                    cmd.Parameters.AddWithValue("@Fecha", fecha)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read = True Then
                            programacion.Id = dr("idmarcacion")
                            programacion.Programacion1 = dr("programacion1")
                            programacion.Programacion2 = dr("programacion2")
                            If dr("asistencia1") IsNot DBNull.Value Then
                                programacion.Asistencia1 = dr("asistencia1")
                            End If
                            If dr("asistencia2") IsNot DBNull.Value Then
                                programacion.Asistencia2 = dr("asistencia2")
                            End If
                            If dr("refrigerio1") IsNot DBNull.Value Then
                                programacion.Refrigerio1 = dr("refrigerio1")
                            End If
                            If dr("refrigerio2") IsNot DBNull.Value Then
                                programacion.Refrigerio2 = dr("refrigerio2")
                            End If
                            programacion.Estado = dr("estado")
                            programacion.Tecnicosino = dr("tecnicosino")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return programacion
    End Function

    Shared Function FnBuscarProgramacionAbiertaHoy(perId As Integer, fecha As String) As programacion
        Dim programacion As New programacion
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("select idmarcacion, programacion1, programacion2, asistencia1, asistencia2, refrigerio1, refrigerio2, estado, tecnicosino from rh_marcaciones where idpersonal=@PerId and fecha=@Fecha and tecnicosino=0 limit 1;", conn)
                    cmd.Parameters.AddWithValue("@PerId", perId)
                    cmd.Parameters.AddWithValue("@Fecha", fecha)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read = True Then
                            programacion.Id = dr("idmarcacion")
                            programacion.Programacion1 = dr("programacion1")
                            programacion.Programacion2 = dr("programacion2")
                            If dr("asistencia1") IsNot DBNull.Value Then
                                programacion.Asistencia1 = dr("asistencia1")
                            End If
                            If dr("asistencia2") IsNot DBNull.Value Then
                                programacion.Asistencia2 = dr("asistencia2")
                            End If
                            If dr("refrigerio1") IsNot DBNull.Value Then
                                programacion.Refrigerio1 = dr("refrigerio1")
                            End If
                            If dr("refrigerio2") IsNot DBNull.Value Then
                                programacion.Refrigerio2 = dr("refrigerio2")
                            End If
                            programacion.Estado = dr("estado")
                            'programacion.Tecnicosino = dr("tecnicosino")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return programacion
    End Function

    Shared Function FnRegistrarAsistencia(perId As Integer, eveId As Integer) As Integer
        Dim res As Integer = 0
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("spghu_registrarasistencia", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@_eveid", eveId)
                    cmd.Parameters.AddWithValue("@_perid", perId)
                    Dim param As New MySqlParameter("@_retorno", MySqlDbType.Int32)
                    param.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    res = Convert.ToInt32(cmd.Parameters("@_retorno").Value)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return res
    End Function

    Shared Function FnRegistrarAlmuerzo(perId As Integer, eveId As Integer) As Integer
        Dim res As Integer = 0
        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                conn.Open()
                Using cmd As New MySqlCommand("spghu_registrarrefrigerio", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@_eveid", eveId)
                    cmd.Parameters.AddWithValue("@_perid", perId)
                    Dim param As New MySqlParameter("@_retorno", MySqlDbType.Int32)
                    param.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    res = Convert.ToInt32(cmd.Parameters("@_retorno").Value)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        Return res
    End Function
End Class

Public Class frmPatioActualizarOt
    Public Event EstadoTareoFinal As EventHandler(Of Boolean)
    Public Property IdOrden As Integer = 0
    Public Property IdActivo As Integer = 0
    Public Property IdTareo As Integer = 0
    Public Property EstadoOrden As Integer = 0
    Public Property EstadoTareo As Integer = 1 'iniciar como tareo cerrado
    Public personal As clsPersonal

    Private Sub frmPatioActualizarOt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IdOrden > 0 Then
                lblTecnico.Text = personal.Apellidos & ", " & personal.Nombres
                Dim db As New fnManOts
                Dim orden As New Orden
                orden = db.FnBuscarOrden(IdOrden)
                If orden.Id > 0 Then
                    IdActivo = orden.IdActivo
                    lblOt.Text = orden.Orden
                    lblActivo.Text = orden.Activo
                    lblTipo.Text = orden.TipoOrden
                    lblCliente.Text = orden.Cliente
                    lblFecha.Text = orden.Fecha
                    lblActividad.Text = orden.Actividad
                    rtbTrabajosOld.Text = orden.Descripcion
                    rtbObservacionesOld.Text = orden.Observacion
                    lblKm.Text = orden.Km
                    EstadoOrden = orden.Estado
                    Select Case orden.Estado
                        Case 0 'OPTIMO
                            lblEstado.Text = "ANULADA"
                            lblEstado.BackColor = Color.LightPink
                        Case 1 'LEVE
                            lblEstado.Text = "ABIERTA"
                            lblEstado.BackColor = Color.White
                        Case 2 'GRAVE
                            lblEstado.Text = "PROCESO"
                            lblEstado.BackColor = Color.LightBlue
                        Case 3 'GRAVE
                            lblEstado.Text = "CERRADA"
                            lblEstado.BackColor = Color.LightGreen
                        Case 4
                            lblEstado.Text = "OBSERVADA"
                            lblEstado.BackColor = Color.Yellow
                        Case Else
                            lblEstado.Text = "UNKNOWN"
                            lblEstado.BackColor = Color.LightGray
                    End Select

                    If EstadoTareo = 0 And orden.Estado = 2 Then 'si el tareo esta abierto y la orden esta en proceso
                        rtbTrabajos.Enabled = True
                        rtbObservaciones.Enabled = True
                        btnGuardar.Enabled = True
                    End If
                Else
                    MsgBox("NO SE ENCONTRO LA ORDEN," & Environment.NewLine &
                        "Consulte con el Administrador.", MsgBoxStyle.Critical, "ERROR")
                End If
            Else
                MsgBox("LA ORDEN NO ES VALIDA," & Environment.NewLine &
                   "Consulte con el Administrador.", MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
                     ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If rtbTrabajos.Text.Length > 5 Then
                btnGuardar.Enabled = False
                Dim db As New fnPatioTareos
                Dim tareo As New OrdenTareo
                Dim trabajos As String = ""
                Dim observaciones As String = ""
                If rtbTrabajosOld.Text.Length > 2 Then
                    trabajos = ". " & personal.Apodo & ", " & rtbTrabajos.Text.ToUpper()
                Else
                    trabajos = personal.Apodo & ", " & rtbTrabajos.Text.ToUpper()
                End If
                If rtbObservaciones.Text.Length > 2 Then
                    If rtbObservacionesOld.Text.Length > 2 Then
                        observaciones = ". " & personal.Apodo & ", " & rtbObservaciones.Text.ToUpper()
                    Else
                        observaciones = personal.Apodo & ", " & rtbObservaciones.Text.ToUpper()
                    End If
                End If
                tareo.OrdenId = IdOrden
                tareo.Id = IdTareo
                tareo.PersonalId = personal.Id
                tareo.OrdenDescripcion = trabajos
                tareo.OrdenObservacion = observaciones
                If db.FnCerrarTareo(tareo) Then
                    MsgBox("SE GUARDO CORRECTAMENTE", MsgBoxStyle.Information, "CONFIRMADO")
                    EstadoTareo = 1 'tareo cerrado
                    RaiseEvent EstadoTareoFinal(Me, True)
                Else
                    Throw New Exception("ERROR CERRANDO EL TAREO")
                End If
            Else
                MsgBox("NO HAY NADA QUE REGISTRAR," & Environment.NewLine &
                       "El contenido debe ser mayor a 5 caracteres.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine &
                    "Consulte con el Administrador.", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnObtenerListaDeComponentes_Click(sender As Object, e As EventArgs) Handles btnObtenerListaDeComponentes.Click
        ListarComponentesPorActivo()
        ListarComponentesPorOt()
        If EstadoTareo = 0 And EstadoOrden = 2 Then
            btnMontarComponente.Enabled = True
            btnRepararComponente.Enabled = True
            btnBajaComponente.Enabled = True
        End If
        btnObtenerListaDeComponentes.Enabled = False
    End Sub

    Private Sub dgvComponentes1_DoubleClick(sender As Object, e As EventArgs) Handles dgvComponentes1.DoubleClick
        Try
            If Me.dgvComponentes1.RowCount <> 0 Then
                Dim row As DataGridViewRow = dgvComponentes1.CurrentRow
                Dim frm As New frmManDesmontarComponente
                AddOwnedForm(frm)
                frm.vlIdOt = IdOrden
                frm.vlIdActivo = IdActivo
                frm.vlIdComponente = CInt(row.Cells(0).Value)
                frm.vlIdMovimiento = CInt(row.Cells(4).Value)
                frm.lblCodigoComponente.Text = CStr(row.Cells(1).Value)
                frm.lblComponente.Text = CStr(row.Cells(2).Value)
                frm.lblActivo.Text = lblActivo.Text
                frm.lblOt.Text = lblOt.Text
                frm.lblKmAnterior.Text = row.Cells(5).Value
                frm.nudKmActual.Value = CInt(lblKm.Text)
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL ENVIAR LOS DATOS DEL COMPONENTE" & Environment.NewLine &
                  "Consulte con el Administrador" & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnMontarComponente_Click(sender As Object, e As EventArgs) Handles btnMontarComponente.Click
        Try
            Dim frm As New frmManMontarComponente
            frm.vlIdActivo = IdActivo
            frm.vlIdOt = IdOrden
            frm.lblActivo.Text = lblActivo.Text
            frm.lblOt.Text = lblOt.Text
            frm.nudKm.Value = CInt(lblKm.Text)
            AddOwnedForm(frm)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("ERROR AL ENVIAR LOS DATOS DE LA OT." & Environment.NewLine &
                    ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnRepararComponente_Click(sender As Object, e As EventArgs) Handles btnRepararComponente.Click
        Dim frm As New frmManRepararComponente
        frm.vlIdActivo = IdActivo
        frm.vlIdOt = IdOrden
        frm.lblActivo.Text = lblActivo.Text
        frm.lblOt.Text = lblOt.Text
        frm.nudKm.Value = CInt(lblKm.Text)
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnBajaComponente_Click(sender As Object, e As EventArgs) Handles btnBajaComponente.Click
        Dim frm As New frmManBajaComponente
        frm.vlIdActivo = IdActivo
        frm.vlIdOt = IdOrden
        frm.lblActivo.Text = lblActivo.Text
        frm.lblOt.Text = lblOt.Text
        frm.nudKm.Value = CInt(lblKm.Text)
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Public Sub ListarComponentesPorActivo()
        Try
            If IdActivo > 0 Then
                Dim bdGesman As New fnManOts
                Dim dt As New DataTable
                dt = bdGesman.fnBuscar("select c.idcomponente, c.codinterno, c.componente, c.sistema, m.idmovimiento, m.kminicial, m.kmfinal from man_movimientos m inner join man_componentes c on m.idcomponente=c.idcomponente where m.caso=2 and m.estado=2 and m.idactivo=" & IdActivo & ";")
                If (dt.Rows.Count > 0) Then
                    dgvComponentes1.Columns.Clear()
                    dgvComponentes1.DataSource = dt
                    With dgvComponentes1
                        .Columns(0).Visible = False
                        .Columns(4).Visible = False
                    End With
                Else
                    MsgBox("NO SE ENCONTRO RESULTADOS." & Environment.NewLine &
                    "Verifique e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            Else
                MsgBox("NO SE RECONOCE EL ID DEL ACTIVO." & Environment.NewLine &
                     "Consulte con el Administrador.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS COMPONENTES." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Public Sub ListarComponentesPorOt()
        Try
            If IdActivo > 0 Then
                Dim bdGesman As New fnManOts
                Dim dt As New DataTable
                dt = bdGesman.fnBuscar("select m.idmovimiento, m.caso, c.codinterno, c.componente, m.kminicial, m.kmfinal, m.estado from man_movimientos m inner join man_componentes c on m.idcomponente=c.idcomponente where m.idotinicial=" & IdOrden & ";")
                If (dt.Rows.Count > 0) Then
                    dgvComponentes2.Columns.Clear()
                    dgvComponentes2.DataSource = dt
                    With dgvComponentes2
                        .Columns(0).Visible = False
                        .Columns(1).Visible = False
                        .Columns(6).Visible = False
                    End With

                    For Each Row As DataGridViewRow In dgvComponentes2.Rows
                        Select Case Row.Cells(1).Value
                            Case 1 'ALTA
                                Row.DefaultCellStyle.BackColor = Color.LightGreen
                            Case 2 'MONTAR
                                Row.DefaultCellStyle.BackColor = Color.LightBlue
                            Case 3 'DESMONTAR
                                Row.DefaultCellStyle.BackColor = Color.Yellow
                            Case 4 'REPARAR
                                Row.DefaultCellStyle.BackColor = Color.Gold
                            Case 5 'BAJA
                                Row.DefaultCellStyle.BackColor = Color.LightPink
                        End Select
                    Next
                Else
                    MsgBox("NO SE ENCONTRO RESULTADOS." & Environment.NewLine &
                    "Verifique e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            Else
                MsgBox("NO SE RECONOCE EL ID DEL ACTIVO." & Environment.NewLine &
                     "Consulte con el Administrador.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS COMPONENTES DE LA OT." & Environment.NewLine &
                   "Consulte Con El Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Public Sub ListarComponentesEnSeguimiento()
        Try
            If IdActivo > 0 Then
                Dim bdGesman As New fnManMonitoreos
                Dim dt As New DataTable
                dt = bdGesman.fnBuscar("select idcomponente, activo, sistema, codinterno, componente, serie, obsmonitoreo from man_componentes where idactivo=" & IdActivo & " and monitoreo=2 and estado=2;")
                If (dt.Rows.Count > 0) Then
                    dgvSeguimientos1.Columns.Clear()
                    dgvSeguimientos1.DataSource = dt
                    With dgvSeguimientos1
                        .Columns(0).Visible = False
                    End With
                Else
                    MsgBox("NO SE ENCONTRO COMPONENTES EN SEGUIMIENTO." & Environment.NewLine &
                    "Verifique e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            Else
                MsgBox("NO SE RECONOCE EL ID DEL ACTIVO." & Environment.NewLine &
                     "Consulte con el Administrador.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL MOSTRAR LOS SEGUIMIENTOS." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Public Sub ListarSeguimientosDeLaOt()
        Try
            If IdOrden > 0 Then
                Dim bdGesman As New fnManMonitoreos
                Dim dt As New DataTable
                dt = bdGesman.fnBuscar("select ideval, componente, ot, activo, tipoot, fecha, kms, observaciones from man_monitoreos where idot=" & IdOrden & ";")
                If (dt.Rows.Count > 0) Then
                    dgvSeguimientos2.Columns.Clear()
                    dgvSeguimientos2.DataSource = dt
                    With dgvSeguimientos2
                        .Columns(0).Visible = False
                    End With
                    For Each Row As DataGridViewRow In dgvSeguimientos2.Rows
                        Select Case Row.Cells(0).Value
                            Case 1 'OPTIMO
                                Row.DefaultCellStyle.BackColor = Color.LightGreen
                            Case 2 'LEVE
                                Row.DefaultCellStyle.BackColor = Color.Gold
                            Case 3 'GRAVE
                                Row.DefaultCellStyle.BackColor = Color.LightPink
                            Case 4 'GRAVE
                                Row.DefaultCellStyle.BackColor = Color.LightBlue
                        End Select
                    Next
                Else
                    MsgBox("NO SE ENCONTRO SEGUIMIENTOS EN LA OT." & Environment.NewLine &
                    "Verifique e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            Else
                MsgBox("NO SE RECONOCE EL ID DE LA OT." & Environment.NewLine &
                     "Consulte con el Administrador.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS SEGUIMIENTOS." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnRecuperarSeguimientos_Click(sender As Object, e As EventArgs) Handles btnRecuperarSeguimientos.Click
        btnRecuperarSeguimientos.Enabled = False
        If EstadoTareo = 0 And EstadoOrden = 2 Then
            btnNuevoSeguimiento.Enabled = True
        End If
        ListarComponentesEnSeguimiento()
        ListarSeguimientosDeLaOt()
    End Sub

    Private Sub dgvSeguimientos1_DoubleClick(sender As Object, e As EventArgs) Handles dgvSeguimientos1.DoubleClick
        Try
            If dgvSeguimientos1.RowCount <> 0 Then
                Dim row As DataGridViewRow = dgvSeguimientos1.CurrentRow
                Dim frm As New frmManCorregirMonitoreo
                AddOwnedForm(frm)
                frm.vlidot = IdOrden
                frm.vlidactivo = IdActivo
                frm.vlidcomponente = CInt(row.Cells(0).Value)
                frm.lblSistema.Text = CStr(row.Cells(2).Value)
                frm.lblCodigo.Text = CStr(row.Cells(3).Value)
                frm.lblComponente.Text = CStr(row.Cells(4).Value)
                frm.lblActivo.Text = lblActivo.Text
                frm.nudKm.Value = CInt(lblKm.Text)
                frm.lblOt.Text = lblOt.Text
                frm.lblTipoOt.Text = lblTipo.Text
                If row.Cells(6).Value IsNot DBNull.Value Then
                    frm.rtbObservaciones.Text = CStr(row.Cells(6).Value)
                End If
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL ENVIAR LOS DATOS DEL COMPONENTE" & Environment.NewLine &
                  "Consulte con el Administrador" & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnNuevoSeguimiento_Click(sender As Object, e As EventArgs) Handles btnNuevoSeguimiento.Click
        Try
            Dim frm As New frmManAgregarSeguimiento
            frm.vlidactivo = IdActivo
            frm.vlidot = IdOrden
            frm.lblActivo.Text = lblActivo.Text
            frm.lblOt.Text = lblOt.Text
            frm.nudKm.Value = CInt(lblKm.Text)
            frm.lblTipoOt.Text = lblTipo.Text
            AddOwnedForm(frm)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("ERROR AL ENVIAR LOS DATOS DE LA OT." & Environment.NewLine &
                    ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
Public Class frmManMisOts
    Dim personal As clsPersonal

    Private Sub frmManMisOts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BuscarTareos()
        Try
            Dim db As New fnPatioTareos
            Dim tareos As New List(Of OrdenTareo)
            dgvOts.Rows.Clear()
            tareos = db.FnBuscarTareosPorFecha(personal.Id, dtpFecha.Value)
            If (tareos.Count > 0) Then
                For Each tareo As OrdenTareo In tareos
                    dgvOts.Rows.Add(tareo.Id, tareo.OrdenId, tareo.EquipoNombre, tareo.OrdenNombre, tareo.FechaIngreso, tareo.FechaSalida, tareo.OrdenActividad, tareo.Estado)
                Next
                dgvOts.Select()
            Else
                MsgBox("NO SE ENCONTRO RESULTADOS.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnOts_Click(sender As Object, e As EventArgs) Handles btnOts.Click
        btnOts.Enabled = False
        Try
            If Not personal.Id > 0 Then
                Throw New Exception("EL DNI NO ESTA DISPONIBLE.")
                txtDni.Focus()
            End If
            BuscarTareos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub txtDni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDni.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If txtDni.Text.Length = 8 Then
                    Dim bd As New fnGhuMarcaciones
                    personal = bd.FnBuscarPersonal(txtDni.Text)
                    If personal.Id > 0 Then
                        lblPersonal.Text = personal.Apellidos & ", " & personal.Nombres
                        lblCargo.Text = personal.Cargo
                        btnOts.Enabled = True
                        dtpFecha.Select()
                    Else
                        MsgBox("NO SE ENCONTRO EL DOCUMENTO," & Environment.NewLine &
                               "Verifique su Documento de Identidad.", MsgBoxStyle.Exclamation, "VERIFICAR")
                    End If
                    txtDni.Text = ""
                Else
                    MsgBox("EL DOCUMENTO NO ES VALIDO," & Environment.NewLine &
                          "Verifique antes de continuar.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
                ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        btnOts.Enabled = True
    End Sub

    Private Sub dgvOts_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvOts.RowPrePaint
        If e.RowIndex >= 0 Then
            If dgvOts.Rows(e.RowIndex).Cells("estado").Value = 1 Then
                dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
            End If
        End If
    End Sub

    Private Sub dgvOts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOts.CellMouseDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim frm As New frmPatioActualizarOt
                frm.personal = personal
                frm.IdOrden = dgvOts.Rows(e.RowIndex).Cells("idorden").Value
                frm.IdTareo = dgvOts.Rows(e.RowIndex).Cells("idtareo").Value
                frm.lblIngreso.Text = dgvOts.Rows(e.RowIndex).Cells("ingreso").Value.ToString
                frm.EstadoTareo = dgvOts.Rows(e.RowIndex).Cells("estado").Value
                AddHandler frm.EstadoTareoFinal,
                    Sub(senderObj, ValorModificado)
                        If ValorModificado Then
                            BuscarTareos()
                        End If
                        'dgvOts.Rows(e.RowIndex).Cells("estado").Value = ValorModificado
                    End Sub
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvOts_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOts.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                If dgvOts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1 Then
                    dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
                End If
            End If
        End If
    End Sub
End Class
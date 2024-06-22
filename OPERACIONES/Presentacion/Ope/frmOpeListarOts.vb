Public Class frmOpeListarOts
    Dim CodigoOrden As String = ""
    Dim FechaOrden As Date
    Dim PaginasTotal As Integer = 0
    Dim PaginaActual As Integer = 0

    Private Sub frmOpeListarOts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            txtOt.Enabled = False
            btnBuscar.Enabled = False

            CodigoOrden = txtOt.Text
            FechaOrden = dtpFecha.Value

            PaginasTotal = 0
            PaginaActual = 0

            BuscarOrdenes()

            txtOt.Text = ""
            txtOt.Enabled = True
            btnBuscar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Public Sub BuscarOrdenes()
        Try
            Dim db As New fnManOts
            Dim ordenes As New List(Of Orden)
            Dim cantidad As Integer = 0
            dgvOts.Rows.Clear()
            ordenes = db.FnBuscarOrdenes(CodigoOrden, FechaOrden, PaginasTotal)
            cantidad = ordenes.Count
            If (cantidad > 0) Then
                For Each orden As Orden In ordenes
                    dgvOts.Rows.Add(orden.Id, orden.IdActividad, orden.Fecha, orden.Orden, orden.Activo, orden.TipoOrden, orden.Actividad, orden.Estado)
                Next
                Paginacion(cantidad)
            Else
                Throw New Exception("No se encontró resultados.")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Paginacion(cantidad As Integer)
        Try
            PaginaActual += 1 'Aumenta la página actual en 1

            If cantidad = 50 Then
                PaginasTotal += 50 'Aumentar el total de páginas en 50
                llblSiguiente.Enabled = True
            Else
                llblSiguiente.Enabled = False
            End If

            If PaginaActual > 1 Then
                llblPrimero.Enabled = True
            Else
                llblPrimero.Enabled = False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtOt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOt.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If txtOt.Text.Length > 0 Then
                    CodigoOrden = txtOt.Text
                    FechaOrden = dtpFecha.Value
                    PaginasTotal = 0
                    PaginaActual = 0
                    BuscarOrdenes()
                Else
                    MsgBox("NO HA INGRESADO UNA ORDEN", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvOts_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvOts.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                Select Case dgvOts.Rows(e.RowIndex).Cells("estado").Value
                    Case 0
                        dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightPink
                    Case 2
                        dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
                    Case 3
                        dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                    Case 4
                        dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                    Case Else
                        dgvOts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvOts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOts.CellMouseDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim frm As New frmPatioTecnicosXOt
                frm.ORD_ID = dgvOts.Rows(e.RowIndex).Cells("id").Value
                frm.ACT_ID = dgvOts.Rows(e.RowIndex).Cells("idactividad").Value
                frm.ORD_ESTADO = dgvOts.Rows(e.RowIndex).Cells("estado").Value
                frm.lblOt.Text = dgvOts.Rows(e.RowIndex).Cells("orden").Value
                frm.lblActivo.Text = dgvOts.Rows(e.RowIndex).Cells("activo").Value
                frm.lblTipoOt.Text = dgvOts.Rows(e.RowIndex).Cells("tipo").Value
                frm.lblActividad.Text = dgvOts.Rows(e.RowIndex).Cells("actividad").Value
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub llblSiguiente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSiguiente.LinkClicked
        Try
            BuscarOrdenes()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub llblPrimero_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblPrimero.LinkClicked
        Try
            PaginasTotal = 0
            PaginaActual = 0
            BuscarOrdenes()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
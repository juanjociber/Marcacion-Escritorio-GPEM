Public Class frmPatioTecnicosXOt
    Public Property ORD_ID As Integer = 0
    Public Property ORD_ESTADO As Integer = 0
    Public Property ACT_ID As Integer = 0

    Private Sub frmPatioTecnicosXOt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case ORD_ESTADO
                Case 0
                    lblEstado.Text = "ANULADA"
                    lblEstado.BackColor = Color.LightPink
                Case 1
                    lblEstado.Text = "ABIERTA"
                    lblEstado.BackColor = Color.White
                    btnAgregar.Enabled = True
                Case 2
                    lblEstado.Text = "PROCESO"
                    lblEstado.BackColor = Color.LightBlue
                    btnAgregar.Enabled = True
                Case 3
                    lblEstado.Text = "CERRADA"
                    lblEstado.BackColor = Color.LightGreen
                Case 4
                    lblEstado.Text = "OBSERVADA"
                    lblEstado.BackColor = Color.Yellow
                    btnAgregar.Enabled = True
                Case Else
                    lblEstado.Text = "UNKNOWN"
            End Select

            BuscarTareos()

            If ACT_ID > 0 Then
                btnProductos.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Public Sub BuscarProductos()
        Try
            Dim productos As List(Of Productos) = FnManProductos.FnBuscarActividadProductos(ACT_ID)
            If productos.Count > 0 Then
                For Each producto As Productos In productos
                    dgvProductos.Rows.Add(producto.Codigo, producto.Nombre, producto.Cantidad, producto.Medida)
                Next
            Else
                MsgBox("NO SE ENCONTRO RESULTADOS.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub BuscarTareos()
        Try
            Dim db As New fnPatioTareos
            Dim tareos As New List(Of Tareo)
            dgvTecnicos.Rows.Clear()
            tareos = db.FnBuscarOrdenTareos(ORD_ID)
            If (tareos.Count > 0) Then
                For Each tareo As Tareo In tareos
                    If tareo.FechaSalida = DateTime.MinValue Then
                        dgvTecnicos.Rows.Add(tareo.Id, tareo.PersonalNombre, tareo.FechaIngreso, "", tareo.Minutos, tareo.Estado)
                    Else
                        dgvTecnicos.Rows.Add(tareo.Id, tareo.PersonalNombre, tareo.FechaIngreso, tareo.FechaSalida, tareo.Minutos, tareo.Estado)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmPatioRegistrarTareo
            frm.OrdenId = ORD_ID
            frm.lblOt.Text = lblOt.Text
            frm.lblActivo.Text = lblActivo.Text
            frm.lblTipoOt.Text = lblTipoOt.Text
            If frm.ShowDialog() = DialogResult.OK Then
                BuscarTareos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        btnProductos.Enabled = False
        Try
            BuscarProductos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvTecnicos_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvTecnicos.RowPrePaint
        Try
            If e.RowIndex >= 0 Then
                If dgvTecnicos.Rows(e.RowIndex).Cells("estadotareo").Value = 1 Then
                    dgvTecnicos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    dgvTecnicos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
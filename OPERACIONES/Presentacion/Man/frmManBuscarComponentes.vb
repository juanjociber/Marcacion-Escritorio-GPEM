Public Class frmManBuscarComponentes
    Dim funciones As New fnManComponentes
    Public vlIdActivo As Integer = 0
    Public vlIdForm As Integer = 0
    Private Sub frmManBuscarComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If vlIdForm = 1 Then
            BuscarComponentesNoDisponiblesPorActivo("")
        ElseIf vlIdForm = 2 Then
            BuscarComponentesDisponiblesPorActivo("")
        ElseIf vlIdForm = 4 Then
            BuscarComponentesDisponiblesPorActivo("")
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtComponente.Text.Length > 2 Then
            If vlIdForm = 1 Then
                BuscarComponentesNoDisponiblesPorActivo(" and concat(codinterno, serie) like '%" & txtComponente.Text & "%'")
            ElseIf vlIdForm = 2 Then
                BuscarComponentesDisponiblesPorActivo(" and concat(codinterno, serie) like '%" & txtComponente.Text & "%'")
            ElseIf vlIdForm = 3 Then
                BuscarComponentesDisponibles(" and concat(codinterno, serie) like '%" & txtComponente.Text & "%'")
            ElseIf vlIdForm = 4 Then
                BuscarComponentesDisponiblesPorActivo(" and concat(codinterno, serie) like '%" & txtComponente.Text & "%'")
            End If
        Else
            If vlIdForm = 1 Then
                BuscarComponentesNoDisponiblesPorActivo("")
            ElseIf vlIdForm = 2 Then
                BuscarComponentesDisponiblesPorActivo("")
            ElseIf vlIdForm = 4 Then
                BuscarComponentesDisponiblesPorActivo("")
            End If
        End If
    End Sub
    'Agregar seguimiento
    Public Sub BuscarComponentesNoDisponiblesPorActivo(ByVal query As String)
        Try
            funciones.Consulta("select idcomponente, activo, sistema, codinterno, componente, serie from man_componentes where idactivo=" & vlIdActivo & " and disponible=1 and estado=2" & query & ";", "man_componentes")
            dgvComponentes.Columns.Clear()
            dgvComponentes.DataSource = funciones.ds.Tables("man_componentes")
            With dgvComponentes
                .Columns(0).Visible = False
            End With
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS COMPONENTES." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    'Montar componentes
    Public Sub BuscarComponentesDisponibles(ByVal query As String)
        Try
            funciones.Consulta("select idcomponente, activo, sistema, codinterno, componente, serie from man_componentes where disponible=2 and monitoreo!=2 and estado=2" & query & ";", "man_componentes")
            dgvComponentes.Columns.Clear()
            dgvComponentes.DataSource = funciones.ds.Tables("man_componentes")
            With dgvComponentes
                .Columns(0).Visible = False
            End With
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS COMPONENTES." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    'Baja de componentes, reparar componente
    Public Sub BuscarComponentesDisponiblesPorActivo(ByVal query As String)
        Try
            funciones.Consulta("select idcomponente, activo, sistema, codinterno, componente, serie, monitoreo, obsmonitoreo from man_componentes where idactivo=" & vlIdActivo & " and disponible=2 and estado=2" & query & ";", "man_componentes")
            dgvComponentes.Columns.Clear()
            dgvComponentes.DataSource = funciones.ds.Tables("man_componentes")
            With dgvComponentes
                .Columns(0).Visible = False
                .Columns(6).Visible = False
            End With
        Catch ex As Exception
            MsgBox("ERROR AL LISTAR LOS COMPONENTES." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub dgvComponentes_DoubleClick(sender As Object, e As EventArgs) Handles dgvComponentes.DoubleClick
        Try
            If Me.dgvComponentes.RowCount <> 0 Then
                Dim row As DataGridViewRow = dgvComponentes.CurrentRow
                If vlIdForm = 1 Then
                    Dim frm As frmManAgregarSeguimiento = CType(Owner, frmManAgregarSeguimiento)
                    frm.lblId.Text = CStr(row.Cells(0).Value)
                    frm.lblCodigo.Text = CStr(row.Cells(3).Value)
                    frm.lblComponente.Text = CStr(row.Cells(4).Value)
                    frm.lblSerie.Text = CStr(row.Cells(5).Value)
                    frm.Select()
                ElseIf vlIdForm = 2 Then
                    Dim frm As frmManRepararComponente = CType(Owner, frmManRepararComponente)
                    frm.lblId.Text = CStr(row.Cells(0).Value)
                    frm.lblCodigo.Text = CStr(row.Cells(3).Value)
                    frm.lblComponente.Text = CStr(row.Cells(4).Value)
                    frm.lblSerie.Text = CStr(row.Cells(5).Value)
                    frm.vlMonitoreo = CInt(row.Cells(6).Value)
                    frm.rtbReporteAnterior.Text = CStr(row.Cells(7).Value)
                    frm.Select()
                ElseIf vlIdForm = 3 Then
                    Dim frm As frmManMontarComponente = CType(Owner, frmManMontarComponente)
                    frm.lblId.Text = CStr(row.Cells(0).Value)
                    frm.lblCodigo.Text = CStr(row.Cells(3).Value)
                    frm.lblComponente.Text = CStr(row.Cells(4).Value)
                    frm.lblSerie.Text = CStr(row.Cells(5).Value)
                    frm.Select()
                ElseIf vlIdForm = 4 Then
                    Dim frm As frmManBajaComponente = CType(Owner, frmManBajaComponente)
                    frm.lblId.Text = CStr(row.Cells(0).Value)
                    frm.lblCodigo.Text = CStr(row.Cells(3).Value)
                    frm.lblComponente.Text = CStr(row.Cells(4).Value)
                    frm.lblSerie.Text = CStr(row.Cells(5).Value)
                    frm.Select()
                End If
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL RETORNAR LOS DATOS DEL COMPONENTE." & Environment.NewLine &
                   "Consulte con el Administrador." & Environment.NewLine &
                   ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
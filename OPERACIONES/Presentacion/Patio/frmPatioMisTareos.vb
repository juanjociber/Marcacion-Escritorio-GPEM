Public Class frmPatioMisTareos
    Dim fnmysql As fnPatioTareos = New fnPatioTareos
    Private Sub frmPatioMisTareos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Public Sub BuscarTareos(ByVal dni As String)
    '    Try
    '        Dim bdGesman As New fnPatioTareos
    '        Dim dt As New DataTable
    '        dt = bdGesman.fnBuscar("SELECT t.idtareo, t.idot, o.ot, o.activo, o.tipoot, t.ingreso, t.salida, t.tmin, o.actividad, t.estado " &
    '                           "FROM man_ots o INNER JOIN man_tareos t ON o.idot=t.idot WHERE t.dni='" & dni & "' AND t.fecha='" & dtpFecha.Value.ToString("yyyy-MM-dd") & "';")
    '        dgvTareos.DataSource = dt
    '        With dgvTareos
    '            .Columns("idtareo").Visible = False
    '            .Columns("idot").Visible = False
    '            .Columns("estado").Visible = False
    '        End With
    '        For Each Row As DataGridViewRow In dgvTareos.Rows
    '            If Row.Cells("estado").Value = 1 Then
    '                Row.DefaultCellStyle.BackColor = Color.LightGreen
    '            Else
    '                Row.DefaultCellStyle.BackColor = Color.LightBlue
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox("ERROR AL CARGAR LOS TAREOS." & Environment.NewLine &
    '               "Consulte con el Administrador." & Environment.NewLine &
    '                                   ex.Message, MsgBoxStyle.Critical, "ERROR")
    '    End Try
    '    dgvTareos.Select()
    'End Sub

    Private Sub txtDni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDni.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtDni.Text.Length = 8 Then
                'BuscarTareos(txtDni.Text)
            Else
                MsgBox("DNI INCORRECTO." & Environment.NewLine &
                      "Verifique su DNI e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        End If
    End Sub

    Private Sub dgvTareos_DoubleClick(sender As Object, e As EventArgs) Handles dgvTareos.DoubleClick
        'Try
        '    If dgvTareos.RowCount > 0 Then
        '        Dim row As DataGridViewRow = dgvTareos.CurrentRow
        '        If row.Cells("estado").Value = 0 Then
        '            Dim frm As New frmOpeCerrarTareo
        '            AddOwnedForm(frm)
        '            frm.vIdTareo = CInt(row.Cells("idtareo").Value)
        '            frm.ShowDialog()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("ERROR AL PROCESAR LOS DATOS" & Environment.NewLine &
        '           "Consulte con el Administrador" & Environment.NewLine &
        '           ex.Message, MsgBoxStyle.Critical, "ERROR")
        'End Try
    End Sub
End Class
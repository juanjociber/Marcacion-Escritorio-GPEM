Public Class frmManAgregarSeguimiento
    Public vlidot As Integer = 0
    Public vlidactivo As Integer = 0
    Private Sub frmManAgregarSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEvaluaciones()
    End Sub

    Private Sub btnComponentes_Click(sender As Object, e As EventArgs) Handles btnComponentes.Click
        Dim frm As New frmManBuscarComponentes
        frm.vlIdActivo = vlidactivo
        frm.vlIdForm = 1
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Sub ListarEvaluaciones()
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("VALOPCIONES", GetType(Integer)))
        dt.Columns.Add(New DataColumn("NOMOPCIONES", GetType(String)))
        dt.Rows.Add(1, "[1] OPTIMO")
        dt.Rows.Add(2, "[2] LEVE")
        dt.Rows.Add(3, "[3] GRAVE")
        cbEvaluaciones.DisplayMember = "NOMOPCIONES"
        cbEvaluaciones.ValueMember = "VALOPCIONES"
        cbEvaluaciones.DataSource = dt
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If vlidactivo > 0 And vlidot > 0 And CInt(lblId.Text) > 0 Then
                Dim funciones As New fnManMonitoreos
                Dim variable As Integer
                Dim logica As New clsManMonitoreos
                logica.IDCOMPONENTE = lblId.Text
                logica.IDOT = vlidot
                logica.IDACTIVO = vlidactivo
                logica.IDEVAL = cbEvaluaciones.SelectedValue
                logica.COMPONENTE = lblCodigo.Text
                logica.OT = lblOt.Text
                logica.ACTIVO = lblActivo.Text
                logica.TIPOOT = lblTipoOt.Text
                logica.KM = nudKm.Value
                logica.OBSERVACIONES = rtbObservaciones.Text
                logica.USUARIO = vgusuario
                variable = funciones.fnManAgregarMonitoreos(logica)
                If variable = 1 Then
                    MsgBox("SE REGISTRO CORRECTAMENTE EL SEGUIMIENTO.", MsgBoxStyle.Information, "CONFIRMADO")
                    Dim frm As frmPatioActualizarOt = CType(Owner, frmPatioActualizarOt)
                    frm.ListarComponentesEnSeguimiento()
                    frm.ListarSeguimientosDeLaOt()
                    frm.Select()
                    Me.Dispose()
                Else
                    MsgBox("NO SE REGISTRO. ERROR INTERNO EN LA BD." & Environment.NewLine &
                           "Consulte con el Administrador", MsgBoxStyle.Critical, "ERROR")
                End If
            Else
                MsgBox("LA INFORMACION ESTA INCOMPLETA." & Environment.NewLine &
                       "Revise la informacón antes de continuar.", MsgBoxStyle.Exclamation, "REVISAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL ENVIAR LA INFORMACION." & Environment.NewLine &
                    ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
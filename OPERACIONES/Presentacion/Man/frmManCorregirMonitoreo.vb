Public Class frmManCorregirMonitoreo
    Public vlidcomponente As Integer = 0
    Public vlidot As Integer = 0
    Public vlidactivo As Integer = 0
    Private Sub frmManCorregirMonitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCorregir_Click(sender As Object, e As EventArgs) Handles btnCorregir.Click
        If vlidcomponente > 0 And vlidactivo > 0 And vlidot > 0 Then
            Try
                Dim funciones As New fnManMonitoreos
                Dim variable As Integer
                Dim logica As New clsManMonitoreos
                logica.IDCOMPONENTE = vlidcomponente
                logica.IDOT = vlidot
                logica.IDACTIVO = vlidactivo
                logica.IDEVAL = 4 'CORREGIDO
                logica.COMPONENTE = lblCodigo.Text
                logica.OT = lblOt.Text
                logica.ACTIVO = lblActivo.Text
                logica.TIPOOT = lblTipoOt.Text
                logica.KM = nudKm.Value
                logica.OBSERVACIONES = rtbObservaciones2.Text
                logica.USUARIO = vgusuario
                variable = funciones.fnManAgregarMonitoreos(logica)
                If variable = 1 Then
                    MsgBox("SE GUARDO CORRECTAMENTE.", MsgBoxStyle.Information, "CONFIRMADO")
                    Dim frm As frmPatioActualizarOt = CType(Owner, frmPatioActualizarOt)
                    frm.ListarComponentesEnSeguimiento()
                    frm.ListarSeguimientosDeLaOt()
                    frm.Select()
                    Me.Dispose()
                Else
                    MsgBox("NO SE REGISTRO. ERROR INTERNO EN LA BD." & Environment.NewLine &
                               "Consulte con el Administrador", MsgBoxStyle.Critical, "ERROR")
                End If
            Catch ex As Exception
                MsgBox("ERROR AL ENVIAR LA INFORMACION." & Environment.NewLine &
                        ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        Else
            MsgBox("LA INFORMACION NO ESTA COMPLETA." & Environment.NewLine &
                   "Cierre esta ventana e intente nuevamente.", MsgBoxStyle.Exclamation, "VERIFICAR")
        End If
    End Sub
End Class
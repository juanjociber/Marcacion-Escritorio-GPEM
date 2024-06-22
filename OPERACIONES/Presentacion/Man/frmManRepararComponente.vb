Public Class frmManRepararComponente
    Public vlIdOt As Integer = 0
    Public vlIdActivo As Integer = 0
    Public vlMonitoreo As Integer = 0

    Private Sub frmManRepararComponente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New frmManBuscarComponentes
        frm.vlIdActivo = vlIdActivo
        frm.vlIdForm = 2
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnReparar_Click(sender As Object, e As EventArgs) Handles btnReparar.Click
        Try
            If vlIdActivo > 0 And vlIdOt > 0 And CInt(lblId.Text) > 0 Then
                Dim funciones As New fnManMovimientos
                Dim logica As New clsManMovimientos
                logica.IDMOVIMIENTO = 0
                logica.IDCOMPONENTE = CInt(lblId.Text)
                logica.IDACTIVO = vlIdActivo
                logica.IDOT = vlIdOt
                logica.COMPONENTE = lblCodigo.Text
                logica.ACTIVO = lblActivo.Text
                logica.OT = lblOt.Text
                logica.KM = nudKm.Value
                logica.OBSERVACIONES = rtbObservaciones.Text
                logica.USUARIO = vgusuario
                Dim variable As Integer = funciones.fnRepararComponente(logica)
                If variable = 1 Then
                    If vlMonitoreo = 2 Then
                        Dim funciones2 As New fnManMonitoreos
                        Dim logica2 As New clsManMonitoreos
                        logica2.IDCOMPONENTE = CInt(lblId.Text)
                        logica2.IDOT = vlIdOt
                        logica2.IDACTIVO = vlIdActivo
                        logica2.IDEVAL = 4 'CORREGIDO
                        logica2.COMPONENTE = lblCodigo.Text
                        logica2.OT = lblOt.Text
                        logica2.ACTIVO = lblActivo.Text
                        logica2.TIPOOT = lblTipoOt.Text
                        logica2.KM = nudKm.Value
                        logica2.OBSERVACIONES = rtbObservaciones.Text
                        logica2.USUARIO = vgusuario
                        Dim variable2 As Integer = funciones2.fnManAgregarMonitoreos(logica2)
                        If variable2 = 1 Then
                            MsgBox("SE GUARDO CORRECTAMENTE." & Environment.NewLine &
                                   "Se hizo la reparacion y se corrigio las observaciones.", MsgBoxStyle.Information, "CONFIRMADO")

                        Else
                            MsgBox("NO SE PUDO CORREGIR LAS OBSERVACIONES." & Environment.NewLine &
                                       "Haga esta correcccion manualmente en la pestaña SEGUIMIENTOS.", MsgBoxStyle.Exclamation, "VERIFICAR")
                        End If
                    End If

                    Dim frm As frmPatioActualizarOt = CType(Owner, frmPatioActualizarOt)
                    frm.ListarComponentesPorOt()
                    frm.ListarComponentesEnSeguimiento()
                    frm.ListarSeguimientosDeLaOt()
                    frm.Select()
                    Me.Dispose()
                Else
                    MsgBox("NO SE PUDO EJECUTAR LA REPARACION." & Environment.NewLine &
                           "Consulte con el Administrador", MsgBoxStyle.Critical, "ERROR")
                End If
            Else
                MsgBox("LA INFORMACION ESTA INCOMPLETA." & Environment.NewLine &
                       "Revise la informacón antes de continuar.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End If
        Catch ex As Exception
            MsgBox("ERROR GENERAL AL EJECUTAR LA REPARACION." & Environment.NewLine &
                    "Consulte con el Administrador." & Environment.NewLine &
                    ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
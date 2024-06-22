Public Class frmManBajaComponente
    Public vlIdOt As Integer = 0
    Public vlIdActivo As Integer = 0
    Private Sub frmManBajaComponente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New frmManBuscarComponentes
        frm.vlIdActivo = vlIdActivo
        frm.vlIdForm = 4
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            If vlIdActivo > 0 And vlIdOt > 0 And CInt(lblId.Text) > 0 Then
                Dim funciones As New fnManMovimientos
                Dim variable As Integer
                Dim logica As New clsManMovimientos
                logica.IDMOVIMIENTO = 0
                logica.IDCOMPONENTE = lblId.Text
                logica.IDACTIVO = vlIdActivo
                logica.IDOT = vlIdOt
                logica.COMPONENTE = lblCodigo.Text
                logica.ACTIVO = lblActivo.Text
                logica.OT = lblOt.Text
                logica.KM = nudKm.Value
                logica.USUARIO = vgusuario
                variable = funciones.fnBajaComponente(logica)
                If variable = 1 Then
                    MsgBox("SE ACTUALIZO CORRECTAMENTE.", MsgBoxStyle.Information, "CONFIRMADO")
                    Dim frm As frmPatioActualizarOt = CType(Owner, frmPatioActualizarOt)
                    frm.ListarComponentesPorOt()
                    frm.Select()
                    Me.Dispose()
                Else
                    MsgBox("ERROR INTERNO EN LA ACTUALIZACION." & Environment.NewLine &
                           "Consulte con el Administrador", MsgBoxStyle.Critical, "ERROR")
                End If
            Else
                MsgBox("LA INFORMACION ESTA INCOMPLETA." & Environment.NewLine &
                       "Revise la informacón antes de continuar.", MsgBoxStyle.Exclamation, "REVISAR")
            End If

        Catch ex As Exception
            MsgBox("ERROR GENERAL DE ACTUALIZACION." & Environment.NewLine &
                    ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
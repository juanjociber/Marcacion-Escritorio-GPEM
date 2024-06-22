Public Class frmManMontarComponente
    Public vlIdOt As Integer = 0
    Public vlIdActivo As Integer = 0
    Private Sub frmManMontarComponente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New frmManBuscarComponentes
        frm.vlIdForm = 3
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub

    Private Sub btnMontar_Click(sender As Object, e As EventArgs) Handles btnMontar.Click
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
                variable = funciones.fnMontarComponente(logica)
                If variable = 1 Then
                    MsgBox("SE REGISTRO CORRECTAMENTE EL MOVIMIENTO.", MsgBoxStyle.Information, "CONFIRMADO")
                    Dim frm As frmPatioActualizarOt = CType(Owner, frmPatioActualizarOt)
                    frm.ListarComponentesPorActivo()
                    frm.ListarComponentesPorOt()
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
Public Class frmManDesmontarComponente
    Dim funciones As New fnManMovimientos
    Public vlIdMovimiento As Integer = 0
    Public vlIdActivo As Integer = 0
    Public vlIdComponente As Integer = 0
    Public vlIdOt As Integer = 0
    Private Sub frmManDesmontarComponente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDesmontar.Enabled = True
    End Sub
    Private Sub btnDesmontar_Click(sender As Object, e As EventArgs) Handles btnDesmontar.Click
        Try
            If vlIdMovimiento > 0 And vlIdActivo > 0 And vlIdComponente > 0 And vlIdOt > 0 Then
                Dim variable As Integer
                Dim logica As New clsManMovimientos
                logica.IDMOVIMIENTO = vlIdMovimiento
                logica.IDCOMPONENTE = vlIdComponente
                logica.IDACTIVO = vlIdActivo
                logica.IDOT = vlIdOt
                logica.COMPONENTE = lblCodigoComponente.Text
                logica.ACTIVO = lblActivo.Text
                logica.OT = lblOt.Text
                logica.KM = nudKmActual.Value
                logica.USUARIO = vgusuario
                variable = funciones.fnDesmontarComponente(logica)
                If variable = 1 Then
                    MsgBox("EL COMPONENTE SE DESMONTO CORRECTAMENTE." & Environment.NewLine &
                           "El componente se encuentra disponible.", MsgBoxStyle.Information, "CONFIRMADO")
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
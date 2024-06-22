Public Class frmPatioRegistrarTareo
    Public OrdenId As Integer = 0

    Private Sub frmPatioRegistrarTareo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtDni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDni.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If OrdenId > 0 And txtDni.Text.Length = 8 Then
                    Dim db As New fnPatioTareos
                    Dim res As Integer
                    res = db.FnTareosMin(1, 0, OrdenId, txtDni.Text) '1:ABRIR TAREO, 2:CERRAR TAREO
                    Select Case res
                        Case 0
                            lblMensaje.Text = "ERROR: NO SE REGISTRO EL TAREO."
                        Case 1
                            Me.DialogResult = DialogResult.OK
                        Case 2
                            lblMensaje.Text = "VERIFIQUE: USTED YA TIENE UNA OT ABIERTA."
                        Case 3
                            lblMensaje.Text = "VERIFIQUE: EL DNI NO EXISTE."
                        Case Else
                            lblMensaje.Text = "EROR: DESCONOCIDO."
                    End Select
                Else
                    MsgBox("La Información esta incompleta.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class
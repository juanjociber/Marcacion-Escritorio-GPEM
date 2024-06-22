Public Class frmGhuOpcionesDeMarcado
    Public Property PER_ID As Integer = 0
    Public Property vlTipoMarcacion As Integer = 0 '1:Asistencia, 2:Refrigerio
    Public Property LAB_INGRESO As Boolean
    Public Property LAB_SALIDA As Boolean
    Public Property REF_INGRESO As Boolean
    Public Property REF_SALIDA As Boolean

    Private Sub frmGhuOpcionesDeMarcado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not PER_ID > 0 Then
            Throw New Exception("NO SE RECONOCE EL DNI.")
        End If

        If vlTipoMarcacion = 1 Then 'ASISTENCIA
            btnIngreso.Enabled = True
            btnSalida.Enabled = True
            btnIngreso.Text = "INGRESO LABORES"
            btnSalida.Text = "SALIDA LABORES"


        ElseIf vlTipoMarcacion = 2 Then 'REFRIGERIO
            If REF_INGRESO Then
                btnIngreso.Enabled = True
            End If
            If REF_SALIDA Then
                btnSalida.Enabled = True
            End If
            btnIngreso.Text = "INGRESO REFRIGERIO"
            btnSalida.Text = "SALIDA REFRIGERIO"
        Else
            Throw New Exception("NO SE RECONOCE EL EVENTO.")
        End If
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Try
            Dim res As Integer = 0

            btnIngreso.Enabled = False
            btnSalida.Enabled = False

            If vlTipoMarcacion = 1 Then
                res = fnGhuMarcaciones.FnRegistrarAsistencia(PER_ID, 1)
            ElseIf vlTipoMarcacion = 2 Then
                res = fnGhuMarcaciones.FnRegistrarAlmuerzo(PER_ID, 1) '1: Ingreso
            Else
                Throw New Exception("TIPO DE MARCACION DESCONOCIDA.")
            End If

            Select Case res
                Case 1 'Ok
                    Me.DialogResult = DialogResult.OK
                Case 2 'Sin programación
                    MsgBox("LA PROGRAMACION NO ESTA DISPONIBLE.", MsgBoxStyle.Exclamation, "VERIFICAR")
                Case Else 'Otro error
                    MsgBox("ERROR GUARDANDO LA MARCACION.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Try
            Dim res As Integer = 0

            btnIngreso.Enabled = False
            btnSalida.Enabled = False

            If vlTipoMarcacion = 1 Then '1:Asistencia
                res = fnGhuMarcaciones.FnRegistrarAsistencia(PER_ID, 2) '2: Salida
            ElseIf vlTipoMarcacion = 2 Then '2:Refrigerio
                res = fnGhuMarcaciones.FnRegistrarAlmuerzo(PER_ID, 2) '2: Salida
            End If

            Select Case res
                Case 1 'Ok
                    Me.DialogResult = DialogResult.OK
                Case 2 'Sin programación
                    MsgBox("LA PROGRAMACION NO ESTA DISPONIBLE.", MsgBoxStyle.Exclamation, "VERIFICAR")
                Case Else 'Otro error
                    MsgBox("ERROR GUARDANDO LA MARCACION.", MsgBoxStyle.Exclamation, "VERIFICAR")
            End Select

        Catch ex As Exception
            MsgBox("ERROR DE PROCEDIMIENTO," & Environment.NewLine &
                   "Favor, consulte con el Administrador", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnIngreso_MouseEnter(sender As Object, e As EventArgs) Handles btnIngreso.MouseEnter
        btnIngreso.BackColor = Color.Green
        btnIngreso.Font = New Font(btnIngreso.Font, FontStyle.Bold)
    End Sub
    Private Sub btnIngreso_MouseLeave(sender As Object, e As EventArgs) Handles btnIngreso.MouseLeave
        btnIngreso.BackColor = Color.LimeGreen
        btnIngreso.Font = New Font(btnIngreso.Font, FontStyle.Regular)
    End Sub
    Private Sub btnSalida_MouseEnter(sender As Object, e As EventArgs) Handles btnSalida.MouseEnter
        btnSalida.BackColor = Color.DarkRed
        btnSalida.Font = New Font(btnSalida.Font, FontStyle.Bold)
    End Sub
    Private Sub btnSalida_MouseLeave(sender As Object, e As EventArgs) Handles btnSalida.MouseLeave
        btnSalida.BackColor = Color.Red
        btnSalida.Font = New Font(btnSalida.Font, FontStyle.Regular)
    End Sub
End Class
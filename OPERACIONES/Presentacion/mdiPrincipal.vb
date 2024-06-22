Imports System.Threading
Imports System.Windows.Forms
Public Class mdiPrincipal
    Private Sub tsbAsistencia_Click(sender As Object, e As EventArgs)
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmGhuMarcaciones" Then
                f.WindowState = FormWindowState.Normal
                f.Select()
                Exit Sub
            End If
        Next
        Dim frmChild As New frmGhuMarcaciones
        frmChild.MdiParent = Me
        frmChild.WindowState = FormWindowState.Normal
        frmChild.Show()
    End Sub
    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define un nombre único para el mutex
        Dim mutexName As String = "MyGesmanTaller"

        ' Intenta crear un nuevo mutex
        Dim createdNew As Boolean
        Dim mutex As New Mutex(True, mutexName, createdNew)

        ' Si el mutex ya existía, significa que otra instancia de la aplicación ya está en ejecución
        If Not createdNew Then
            MessageBox.Show("LA APLICACION YA SE ESTA EJECUTANDO.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        tslHora.Text = Format(Date.Now, "dd/MM/yyyy HH:mm")
    End Sub

    Private Sub tsbOts_Click_1(sender As Object, e As EventArgs) Handles tsbOts.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmOpeListarOts" Then
                f.WindowState = FormWindowState.Normal
                f.Select()
                Exit Sub
            End If
        Next
        Dim frmChild As New frmOpeListarOts
        frmChild.MdiParent = Me
        frmChild.WindowState = FormWindowState.Normal
        frmChild.Show()
    End Sub
    Private Sub tsbTareos_Click(sender As Object, e As EventArgs) Handles tsbTareos.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmManMisOts" Then
                f.WindowState = FormWindowState.Normal
                f.Select()
                Exit Sub
            End If
        Next
        Dim frmChild As New frmManMisOts
        frmChild.MdiParent = Me
        frmChild.WindowState = FormWindowState.Normal
        frmChild.Show()
    End Sub

    Private Sub tsbMarcador_Click(sender As Object, e As EventArgs) Handles tsbMarcador.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmGhuMarcaciones" Then
                f.WindowState = FormWindowState.Normal
                f.Select()
                f.Location = New Point((Me.Width - f.Width) / 2, (Me.Height - f.Height) / 2)
                'f.StartPosition = FormStartPosition.CenterScreen
                Exit Sub
            End If
        Next
        Dim frmChild As New frmGhuMarcaciones
        frmChild.MdiParent = Me
        frmChild.WindowState = FormWindowState.Normal
        frmChild.Show()
    End Sub

    Private Sub mdiPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Verificar si el cierre del formulario fue solicitado por el usuario al hacer clic en el botón de cerrar ('X')
        If e.CloseReason = CloseReason.UserClosing Then
            ' Cancelar el cierre para deshabilitar el botón de cerrar
            e.Cancel = True
        End If
    End Sub
End Class

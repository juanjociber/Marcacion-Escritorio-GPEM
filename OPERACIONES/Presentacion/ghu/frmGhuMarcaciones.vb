Imports System.Configuration
Imports System.IO
Imports System.Net

Public Class frmGhuMarcaciones
    Dim gpemUrlPhotos As String = ConfigurationManager.AppSettings("gpem_url_photos")
    Dim programacionTiempo As programacion
    Dim LAB_INGRESO As Boolean
    Dim LAB_SALIDA As Boolean
    Dim REF_INGRESO As Boolean
    Dim REF_SALIDA As Boolean
    Private Sub frmGhuMarcaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrReloj.Start()
        lblFechaSistema.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy")
        lblHoraSistema.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
    Sub LimpiarDatos()
        pbFoto.Image = Nothing
        lblCodigo.Text = ""
        lblDni.Text = ""
        lblNombres.Text = ""
        lblApellidos.Text = ""
        lblCargo.Text = ""
        lblIngresoLabores.Visible = False
        lblIngresoRefrigerio.Visible = False
        lblSalidaLabores.Visible = False
        lblSalidaRefrigerio.Visible = False
        lblFechaMarcacion.Text = "-*-"
        lblHorarioMarcacion.Text = "-*-"
    End Sub

    Private Async Function FnBuscarPersonalAsync(dni As String) As Task
        Try
            Dim personal As New clsPersonal

            personal = fnGhuMarcaciones.FnBuscarPersonalGpemsac(dni)

            If personal.Id = 0 Then
                Throw New Exception("NO SE ENCONTRO EL DNI.")
            End If

            Await FnDescargarFotoAsync(personal.Id)

            LAB_INGRESO = False
            LAB_SALIDA = False
            REF_INGRESO = False
            REF_SALIDA = False
            btnRefrigerio.Enabled = False

            programacionTiempo = fnGhuMarcaciones.FnBuscarMarcacionEnProceso(personal.Id)
            If programacionTiempo.Tecnicosino = 1 Then 'Generar procedimiento para cerrar ultima marcacion abierta (anterior)'

                LAB_SALIDA = True

                If programacionTiempo.Refrigerio2 Is Nothing Then
                    btnRefrigerio.Enabled = True
                    If programacionTiempo.Refrigerio1 Is Nothing Then
                        REF_INGRESO = True
                    Else
                        REF_SALIDA = True
                    End If
                End If

            Else 'Generar una marcacion nueva

                LAB_INGRESO = True

                Dim programacionTiempo2 As programacion = fnGhuMarcaciones.FnBuscarUltimaMarcacionAbierta(personal.Id, DateTime.Now.ToString("yyyy-MM-dd"))

                If programacionTiempo2 IsNot Nothing Then
                    Dim fechaHActual As DateTime = DateTime.Now
                    Dim horaActual As String = fechaHActual.ToString("HH:mm:ss")

                    ' Calcular la diferencia en minutos entre la hora de ingreso permitida y la hora actual
                    Dim diferenciaMinutos As TimeSpan = fechaHActual - programacionTiempo2.Programacion1

                    ' Calcular el valor absoluto de la diferencia en minutos
                    Dim valor As Integer = CInt(diferenciaMinutos.Minutes)

                    ' Verificar si el usuario intenta ingresar más de 5 minutos antes de su hora de ingreso
                    If valor < -8 Then
                        Dim horas As String = programacionTiempo2.Programacion1.ToString("HH:mm:ss")
                        Dim fechaHoraActual As String = DateTime.Now.ToString("dd/MM/yyyy")
                        MsgBox($"Solo puede marcar su ingreso desde 5 minutos antes hasta después de las {horas} Hrs., del día {fechaHoraActual}.", MsgBoxStyle.Information, "Información de Marcación")
                        Return
                    End If
                Else
                    MsgBox("USTED NO TIENE PROGRAMACION PARA HOY.", MsgBoxStyle.Exclamation, "VERIFICAR")
                End If
            End If

            lblCodigo.Text = personal.Id
            lblDni.Text = personal.Dni
            lblNombres.Text = personal.Nombres
            lblApellidos.Text = personal.Apellidos
            lblCargo.Text = personal.Cargo
            txtDni.Text = ""
            btnAsistencia.Focus()

            MostrarMarcacion(programacionTiempo)

        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Function

    Private Async Function FnDescargarFotoAsync(idPersonal As Integer) As Task
        Try
            ' Crea una instancia de WebClient para descargar la imagen
            Using webClient As New WebClient()
                ' Descarga la imagen en un arreglo de bytes de forma asincrónica

                'Dim imageData As Byte() = Await webClient.DownloadDataTaskAsync(gpemUrlPhotos & "?idfoto=" & idPersonal)

                ' Crea un MemoryStream para almacenar la imagen desde los datos descargados
                'Using stream As New MemoryStream(imageData)
                'pbFoto.Image = Image.FromStream(stream) ' Carga la imagen desde el MemoryStream al PictureBox
                'End Using
            End Using
        Catch ex As Exception
            pbFoto.Image = My.Resources.default_user
        End Try
    End Function

    Sub BuscarUltimaMarcacionEnProceso(perId As Integer)
        Try
            Dim programacion As programacion = fnGhuMarcaciones.FnBuscarMarcacionEnProceso(perId)
            If programacion IsNot Nothing Then
                MostrarMarcacion(programacion)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub MostrarMarcacion(programacion As programacion)
        Try
            If programacion IsNot Nothing Then

                lblFechaMarcacion.Text = programacion.Fecha
                lblHorarioMarcacion.Text = programacion.Turno

                If Not IsNothing(programacion.Asistencia1) Then
                    lblIngresoLabores.Visible = True
                Else
                    lblIngresoLabores.Visible = False
                End If

                If Not IsNothing(programacion.Asistencia2) Then
                    lblSalidaLabores.Visible = True
                Else
                    lblSalidaLabores.Visible = False
                End If

                If Not IsNothing(programacion.Refrigerio1) Then
                    lblIngresoRefrigerio.Visible = True
                Else
                    lblIngresoRefrigerio.Visible = False
                End If

                If Not IsNothing(programacion.Refrigerio2) Then
                    lblSalidaRefrigerio.Visible = True
                Else
                    lblSalidaRefrigerio.Visible = False
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    'Private Sub mostrarImg(ByVal url As String)
    '    Try
    '        Dim fs As System.IO.FileStream
    '        If File.Exists("D:\GPEMSYSTEM\RRHH\FOTOS\" & url & ".jpg") Then
    '            fs = New System.IO.FileStream("D:\GPEMSYSTEM\RRHH\FOTOS\" & url & ".jpg",
    '                 IO.FileMode.Open, IO.FileAccess.Read)
    '            pbFoto.Image = System.Drawing.Image.FromStream(fs)
    '            fs.Close()
    '        Else
    '            pbFoto.Image = Image.FromFile("D:\GPEMSYSTEM\RRHH\FOTOS\0.png")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
    '             ex.Message, MsgBoxStyle.Critical, "ERROR")
    '    End Try
    'End Sub


    Private Async Sub txtDni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDni.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    e.SuppressKeyPress = True
                    LimpiarDatos()
                    'btnAsistencia.Enabled = False
                    If txtDni.Text.Length = 8 Then
                        Await FnBuscarPersonalAsync(txtDni.Text)
                    Else
                        MsgBox("EL DOCUMENTO NO ES VALIDO.", MsgBoxStyle.Exclamation, "VERIFICAR")
                    End If
                    'e.Handled = True
            End Select
        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
                 ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnRefrigerio_Click(sender As Object, e As EventArgs) Handles btnRefrigerio.Click
        Try
            Dim bd As New fnGhuMarcaciones
            Dim personal As New clsPersonal

            If lblCodigo.Text = "" Then
                MsgBox("NO SE RECONOCE EL DNI," & Environment.NewLine & "Verifique antes de continuar.", MsgBoxStyle.Exclamation, "VERIFICAR")
                LimpiarDatos()
            Else
                personal.Id = Integer.Parse(lblCodigo.Text)



                If programacionTiempo.Tecnicosino = 1 Then
                    Dim diferenciaMinutos As Double = 45
                    If Not IsNothing(programacionTiempo.Refrigerio1) Then
                        ' Calcular la diferencia en minutos entre la hora de salida al refrigerio y la hora actual
                        diferenciaMinutos = (DateTime.Now - Convert.ToDateTime(programacionTiempo.Refrigerio1)).TotalMinutes
                    End If
                    ' Verificar si han pasado al menos 45 minutos
                    If diferenciaMinutos < 45 Then
                        MsgBox($"Debe esperar al menos 45 minutos antes de marcar su regreso. Puede marcar su ingreso a partir de las {Convert.ToDateTime(programacionTiempo.Refrigerio1).AddMinutes(45).ToString("HH:mm:ss")} Hrs.", MsgBoxStyle.Information, "Información de Marcación")
                        Return
                    End If
                End If



                ' Continuar con el proceso de marcación
                Dim frm As New frmGhuOpcionesDeMarcado()
                frm.PER_ID = personal.Id
                frm.vlTipoMarcacion = 2 ' Indicador de Refrigerio
                frm.REF_INGRESO = REF_INGRESO
                frm.REF_SALIDA = REF_SALIDA
                If frm.ShowDialog() = DialogResult.OK Then
                    BuscarUltimaMarcacionEnProceso(personal.Id)
                    lblCodigo.Text = ""
                End If
            End If
            txtDni.Focus()

        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        Try
            If lblCodigo.Text = "" Then
                MsgBox("NO SE RECONOCE EL DNI." & Environment.NewLine &
                        "Verifique antes de continuar.", MsgBoxStyle.Exclamation, "VERIFICAR")
                LimpiarDatos()
            Else
                Dim frm As New frmGhuOpcionesDeMarcado()
                frm.PER_ID = Integer.Parse(lblCodigo.Text)
                frm.vlTipoMarcacion = 1 'Indicador de Asistencia
                frm.LAB_INGRESO = LAB_INGRESO
                frm.LAB_SALIDA = LAB_SALIDA
                If frm.ShowDialog() = DialogResult.OK Then
                    BuscarUltimaMarcacionEnProceso(Integer.Parse(lblCodigo.Text))
                    lblCodigo.Text = ""
                End If
            End If
            txtDni.Focus()
        Catch ex As Exception
            MsgBox("ERROR DEL SISTEMA." & Environment.NewLine &
                ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnAsistencia_MouseEnter(sender As Object, e As EventArgs) Handles btnAsistencia.MouseEnter
        btnAsistencia.BackColor = Color.DarkBlue
        btnAsistencia.Font = New Font(btnAsistencia.Font, FontStyle.Bold)
    End Sub

    Private Sub btnAsistencia_MouseLeave(sender As Object, e As EventArgs) Handles btnAsistencia.MouseLeave
        btnAsistencia.BackColor = Color.Blue
        btnAsistencia.Font = New Font(btnAsistencia.Font, FontStyle.Regular)
    End Sub

    Private Sub btnRefrigerio_MouseEnter(sender As Object, e As EventArgs) Handles btnRefrigerio.MouseEnter
        btnRefrigerio.BackColor = Color.DarkOrange
        btnRefrigerio.Font = New Font(btnRefrigerio.Font, FontStyle.Bold)
    End Sub

    Private Sub btnRefrigerio_MouseLeave(sender As Object, e As EventArgs) Handles btnRefrigerio.MouseLeave
        btnRefrigerio.BackColor = Color.Orange
        btnRefrigerio.Font = New Font(btnRefrigerio.Font, FontStyle.Regular)
    End Sub

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        lblFechaSistema.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy")
        lblHoraSistema.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
End Class
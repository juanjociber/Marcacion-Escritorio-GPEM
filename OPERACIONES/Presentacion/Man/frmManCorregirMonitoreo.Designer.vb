<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManCorregirMonitoreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbObservaciones = New System.Windows.Forms.GroupBox()
        Me.rtbObservaciones2 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCorregir = New System.Windows.Forms.Button()
        Me.gbBody = New System.Windows.Forms.GroupBox()
        Me.rtbObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoOt = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.nudKm = New System.Windows.Forms.NumericUpDown()
        Me.gbObservaciones.SuspendLayout()
        Me.gbBody.SuspendLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbObservaciones
        '
        Me.gbObservaciones.Controls.Add(Me.rtbObservaciones2)
        Me.gbObservaciones.Controls.Add(Me.Label9)
        Me.gbObservaciones.Location = New System.Drawing.Point(5, 252)
        Me.gbObservaciones.Name = "gbObservaciones"
        Me.gbObservaciones.Size = New System.Drawing.Size(462, 100)
        Me.gbObservaciones.TabIndex = 8
        Me.gbObservaciones.TabStop = False
        '
        'rtbObservaciones2
        '
        Me.rtbObservaciones2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObservaciones2.Location = New System.Drawing.Point(8, 31)
        Me.rtbObservaciones2.Name = "rtbObservaciones2"
        Me.rtbObservaciones2.Size = New System.Drawing.Size(446, 61)
        Me.rtbObservaciones2.TabIndex = 18
        Me.rtbObservaciones2.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "OBSERVACIONES:"
        '
        'btnCorregir
        '
        Me.btnCorregir.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorregir.Location = New System.Drawing.Point(5, 356)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(462, 35)
        Me.btnCorregir.TabIndex = 7
        Me.btnCorregir.Text = "CORREGIR"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.nudKm)
        Me.gbBody.Controls.Add(Me.rtbObservaciones)
        Me.gbBody.Controls.Add(Me.Label8)
        Me.gbBody.Controls.Add(Me.Label7)
        Me.gbBody.Controls.Add(Me.Label6)
        Me.gbBody.Controls.Add(Me.Label5)
        Me.gbBody.Controls.Add(Me.Label4)
        Me.gbBody.Controls.Add(Me.Label3)
        Me.gbBody.Controls.Add(Me.Label2)
        Me.gbBody.Controls.Add(Me.Label1)
        Me.gbBody.Controls.Add(Me.lblTipoOt)
        Me.gbBody.Controls.Add(Me.lblOt)
        Me.gbBody.Controls.Add(Me.lblActivo)
        Me.gbBody.Controls.Add(Me.lblSistema)
        Me.gbBody.Controls.Add(Me.lblComponente)
        Me.gbBody.Controls.Add(Me.lblCodigo)
        Me.gbBody.Location = New System.Drawing.Point(5, 3)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(462, 248)
        Me.gbBody.TabIndex = 6
        Me.gbBody.TabStop = False
        '
        'rtbObservaciones
        '
        Me.rtbObservaciones.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObservaciones.Location = New System.Drawing.Point(8, 191)
        Me.rtbObservaciones.Name = "rtbObservaciones"
        Me.rtbObservaciones.ReadOnly = True
        Me.rtbObservaciones.Size = New System.Drawing.Size(446, 49)
        Me.rtbObservaciones.TabIndex = 16
        Me.rtbObservaciones.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "REPORTE ANTERIOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TIPO OT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "OT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "KM:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ACTIVO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SISTEMA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "COMPONENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CODIGO:"
        '
        'lblTipoOt
        '
        Me.lblTipoOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoOt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOt.Location = New System.Drawing.Point(151, 138)
        Me.lblTipoOt.Name = "lblTipoOt"
        Me.lblTipoOt.Size = New System.Drawing.Size(130, 20)
        Me.lblTipoOt.TabIndex = 6
        Me.lblTipoOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.Location = New System.Drawing.Point(7, 138)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(118, 20)
        Me.lblOt.TabIndex = 5
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(7, 83)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(118, 20)
        Me.lblActivo.TabIndex = 3
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSistema
        '
        Me.lblSistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSistema.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.Location = New System.Drawing.Point(308, 138)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(146, 20)
        Me.lblSistema.TabIndex = 2
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComponente
        '
        Me.lblComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComponente.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponente.Location = New System.Drawing.Point(151, 32)
        Me.lblComponente.Name = "lblComponente"
        Me.lblComponente.Size = New System.Drawing.Size(303, 20)
        Me.lblComponente.TabIndex = 1
        Me.lblComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(7, 32)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(118, 20)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudKm
        '
        Me.nudKm.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKm.ForeColor = System.Drawing.Color.Red
        Me.nudKm.Location = New System.Drawing.Point(151, 82)
        Me.nudKm.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudKm.Name = "nudKm"
        Me.nudKm.Size = New System.Drawing.Size(132, 21)
        Me.nudKm.TabIndex = 17
        Me.nudKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmManCorregirMonitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(471, 394)
        Me.Controls.Add(Me.gbObservaciones)
        Me.Controls.Add(Me.btnCorregir)
        Me.Controls.Add(Me.gbBody)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManCorregirMonitoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CORREGIR SEGUIMIENTO"
        Me.gbObservaciones.ResumeLayout(False)
        Me.gbObservaciones.PerformLayout()
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbObservaciones As GroupBox
    Friend WithEvents rtbObservaciones2 As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCorregir As Button
    Friend WithEvents gbBody As GroupBox
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTipoOt As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents lblSistema As Label
    Friend WithEvents lblComponente As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents nudKm As NumericUpDown
End Class

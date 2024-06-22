<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManRepararComponente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbBody = New System.Windows.Forms.GroupBox()
        Me.rtbReporteAnterior = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReparar = New System.Windows.Forms.Button()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTipoOt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.nudKm = New System.Windows.Forms.NumericUpDown()
        Me.gbBody.SuspendLayout()
        Me.gbHeader.SuspendLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.rtbReporteAnterior)
        Me.gbBody.Controls.Add(Me.Label10)
        Me.gbBody.Controls.Add(Me.rtbObservaciones)
        Me.gbBody.Controls.Add(Me.Label4)
        Me.gbBody.Controls.Add(Me.lblComponente)
        Me.gbBody.Controls.Add(Me.lblCodigo)
        Me.gbBody.Controls.Add(Me.lblSerie)
        Me.gbBody.Controls.Add(Me.lblId)
        Me.gbBody.Controls.Add(Me.Label7)
        Me.gbBody.Controls.Add(Me.btnBuscar)
        Me.gbBody.Controls.Add(Me.Label5)
        Me.gbBody.Controls.Add(Me.Label6)
        Me.gbBody.Location = New System.Drawing.Point(5, 114)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(468, 262)
        Me.gbBody.TabIndex = 25
        Me.gbBody.TabStop = False
        '
        'rtbReporteAnterior
        '
        Me.rtbReporteAnterior.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReporteAnterior.Location = New System.Drawing.Point(8, 142)
        Me.rtbReporteAnterior.Name = "rtbReporteAnterior"
        Me.rtbReporteAnterior.ReadOnly = True
        Me.rtbReporteAnterior.Size = New System.Drawing.Size(451, 42)
        Me.rtbReporteAnterior.TabIndex = 19
        Me.rtbReporteAnterior.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "REPORTE ANTERIOR:"
        '
        'rtbObservaciones
        '
        Me.rtbObservaciones.Location = New System.Drawing.Point(8, 212)
        Me.rtbObservaciones.Name = "rtbObservaciones"
        Me.rtbObservaciones.Size = New System.Drawing.Size(451, 44)
        Me.rtbObservaciones.TabIndex = 17
        Me.rtbObservaciones.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "OBSERVACIONES:"
        '
        'lblComponente
        '
        Me.lblComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComponente.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponente.Location = New System.Drawing.Point(51, 33)
        Me.lblComponente.Name = "lblComponente"
        Me.lblComponente.Size = New System.Drawing.Size(373, 20)
        Me.lblComponente.TabIndex = 10
        Me.lblComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(8, 86)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(175, 20)
        Me.lblCodigo.TabIndex = 15
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSerie
        '
        Me.lblSerie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerie.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(250, 86)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(209, 20)
        Me.lblSerie.TabIndex = 9
        Me.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Location = New System.Drawing.Point(8, 33)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(40, 20)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "0"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SERIE:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(428, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(31, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "COMPONENTE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CODIGO:"
        '
        'btnReparar
        '
        Me.btnReparar.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReparar.Location = New System.Drawing.Point(6, 380)
        Me.btnReparar.Name = "btnReparar"
        Me.btnReparar.Size = New System.Drawing.Size(467, 37)
        Me.btnReparar.TabIndex = 24
        Me.btnReparar.Text = "REPARAR COMPONENTE"
        Me.btnReparar.UseVisualStyleBackColor = True
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.nudKm)
        Me.gbHeader.Controls.Add(Me.Label8)
        Me.gbHeader.Controls.Add(Me.lblTipoOt)
        Me.gbHeader.Controls.Add(Me.Label3)
        Me.gbHeader.Controls.Add(Me.Label2)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Controls.Add(Me.lblOt)
        Me.gbHeader.Controls.Add(Me.lblActivo)
        Me.gbHeader.Location = New System.Drawing.Point(5, 1)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Size = New System.Drawing.Size(468, 112)
        Me.gbHeader.TabIndex = 23
        Me.gbHeader.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "TIPO OT:"
        '
        'lblTipoOt
        '
        Me.lblTipoOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoOt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOt.Location = New System.Drawing.Point(287, 30)
        Me.lblTipoOt.Name = "lblTipoOt"
        Me.lblTipoOt.Size = New System.Drawing.Size(172, 20)
        Me.lblTipoOt.TabIndex = 7
        Me.lblTipoOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "KM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ACTIVO:"
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.Location = New System.Drawing.Point(8, 30)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(175, 20)
        Me.lblOt.TabIndex = 1
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(8, 79)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(175, 20)
        Me.lblActivo.TabIndex = 0
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudKm
        '
        Me.nudKm.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKm.ForeColor = System.Drawing.Color.Red
        Me.nudKm.Location = New System.Drawing.Point(287, 78)
        Me.nudKm.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudKm.Name = "nudKm"
        Me.nudKm.Size = New System.Drawing.Size(132, 21)
        Me.nudKm.TabIndex = 17
        Me.nudKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmManRepararComponente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(477, 420)
        Me.Controls.Add(Me.gbBody)
        Me.Controls.Add(Me.btnReparar)
        Me.Controls.Add(Me.gbHeader)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManRepararComponente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPARAR COMPONENTE"
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents rtbReporteAnterior As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblComponente As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReparar As Button
    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTipoOt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents nudKm As NumericUpDown
End Class

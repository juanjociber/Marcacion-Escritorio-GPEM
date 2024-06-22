<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManAgregarSeguimiento
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbComponente = New System.Windows.Forms.GroupBox()
        Me.cbEvaluaciones = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbObservaciones = New System.Windows.Forms.RichTextBox()
        Me.btnComponentes = New System.Windows.Forms.Button()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.gbOt = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTipoOt = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.nudKm = New System.Windows.Forms.NumericUpDown()
        Me.gbComponente.SuspendLayout()
        Me.gbOt.SuspendLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(5, 320)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(554, 35)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbComponente
        '
        Me.gbComponente.Controls.Add(Me.cbEvaluaciones)
        Me.gbComponente.Controls.Add(Me.Label8)
        Me.gbComponente.Controls.Add(Me.Label9)
        Me.gbComponente.Controls.Add(Me.lblSerie)
        Me.gbComponente.Controls.Add(Me.Label7)
        Me.gbComponente.Controls.Add(Me.lblCodigo)
        Me.gbComponente.Controls.Add(Me.Label2)
        Me.gbComponente.Controls.Add(Me.Label1)
        Me.gbComponente.Controls.Add(Me.rtbObservaciones)
        Me.gbComponente.Controls.Add(Me.btnComponentes)
        Me.gbComponente.Controls.Add(Me.lblComponente)
        Me.gbComponente.Controls.Add(Me.lblId)
        Me.gbComponente.Location = New System.Drawing.Point(5, 77)
        Me.gbComponente.Name = "gbComponente"
        Me.gbComponente.Size = New System.Drawing.Size(554, 237)
        Me.gbComponente.TabIndex = 4
        Me.gbComponente.TabStop = False
        '
        'cbEvaluaciones
        '
        Me.cbEvaluaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEvaluaciones.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEvaluaciones.FormattingEnabled = True
        Me.cbEvaluaciones.Location = New System.Drawing.Point(392, 88)
        Me.cbEvaluaciones.Name = "cbEvaluaciones"
        Me.cbEvaluaciones.Size = New System.Drawing.Size(153, 23)
        Me.cbEvaluaciones.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "EVALUACION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(197, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "SERIE:"
        '
        'lblSerie
        '
        Me.lblSerie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerie.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(194, 88)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(158, 20)
        Me.lblSerie.TabIndex = 10
        Me.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CODIGO:"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(9, 88)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(141, 20)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "OBSERVACIONES:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "COMPONENTE:"
        '
        'rtbObservaciones
        '
        Me.rtbObservaciones.Location = New System.Drawing.Point(9, 143)
        Me.rtbObservaciones.Name = "rtbObservaciones"
        Me.rtbObservaciones.Size = New System.Drawing.Size(536, 85)
        Me.rtbObservaciones.TabIndex = 5
        Me.rtbObservaciones.Text = ""
        '
        'btnComponentes
        '
        Me.btnComponentes.Location = New System.Drawing.Point(515, 30)
        Me.btnComponentes.Name = "btnComponentes"
        Me.btnComponentes.Size = New System.Drawing.Size(32, 23)
        Me.btnComponentes.TabIndex = 4
        Me.btnComponentes.Text = "..."
        Me.btnComponentes.UseVisualStyleBackColor = True
        '
        'lblComponente
        '
        Me.lblComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComponente.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponente.Location = New System.Drawing.Point(49, 33)
        Me.lblComponente.Name = "lblComponente"
        Me.lblComponente.Size = New System.Drawing.Size(461, 20)
        Me.lblComponente.TabIndex = 3
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblId.Location = New System.Drawing.Point(9, 33)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(34, 20)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "0"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbOt
        '
        Me.gbOt.Controls.Add(Me.nudKm)
        Me.gbOt.Controls.Add(Me.Label6)
        Me.gbOt.Controls.Add(Me.Label5)
        Me.gbOt.Controls.Add(Me.Label4)
        Me.gbOt.Controls.Add(Me.Label3)
        Me.gbOt.Controls.Add(Me.lblTipoOt)
        Me.gbOt.Controls.Add(Me.lblActivo)
        Me.gbOt.Controls.Add(Me.lblOt)
        Me.gbOt.Location = New System.Drawing.Point(5, 2)
        Me.gbOt.Name = "gbOt"
        Me.gbOt.Size = New System.Drawing.Size(554, 72)
        Me.gbOt.TabIndex = 3
        Me.gbOt.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "KM:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TIPO OT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "EQUIPO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OT:"
        '
        'lblTipoOt
        '
        Me.lblTipoOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoOt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOt.Location = New System.Drawing.Point(406, 31)
        Me.lblTipoOt.Name = "lblTipoOt"
        Me.lblTipoOt.Size = New System.Drawing.Size(139, 20)
        Me.lblTipoOt.TabIndex = 2
        Me.lblTipoOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(131, 31)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(105, 20)
        Me.lblActivo.TabIndex = 1
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.Location = New System.Drawing.Point(7, 31)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(95, 20)
        Me.lblOt.TabIndex = 0
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudKm
        '
        Me.nudKm.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKm.ForeColor = System.Drawing.Color.Red
        Me.nudKm.Location = New System.Drawing.Point(265, 30)
        Me.nudKm.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudKm.Name = "nudKm"
        Me.nudKm.Size = New System.Drawing.Size(111, 21)
        Me.nudKm.TabIndex = 17
        Me.nudKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmManAgregarSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(564, 357)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbComponente)
        Me.Controls.Add(Me.gbOt)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManAgregarSeguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR SEGUIMIENTO"
        Me.gbComponente.ResumeLayout(False)
        Me.gbComponente.PerformLayout()
        Me.gbOt.ResumeLayout(False)
        Me.gbOt.PerformLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents gbComponente As GroupBox
    Friend WithEvents cbEvaluaciones As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSerie As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents btnComponentes As Button
    Friend WithEvents lblComponente As Label
    Friend WithEvents lblId As Label
    Friend WithEvents gbOt As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTipoOt As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents nudKm As NumericUpDown
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManMontarComponente
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
        Me.gbBody = New System.Windows.Forms.GroupBox()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMontar = New System.Windows.Forms.Button()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
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
        Me.gbBody.Controls.Add(Me.lblComponente)
        Me.gbBody.Controls.Add(Me.lblCodigo)
        Me.gbBody.Controls.Add(Me.lblSerie)
        Me.gbBody.Controls.Add(Me.lblId)
        Me.gbBody.Controls.Add(Me.Label7)
        Me.gbBody.Controls.Add(Me.btnBuscar)
        Me.gbBody.Controls.Add(Me.Label5)
        Me.gbBody.Controls.Add(Me.Label6)
        Me.gbBody.Location = New System.Drawing.Point(5, 88)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(534, 141)
        Me.gbBody.TabIndex = 19
        Me.gbBody.TabStop = False
        '
        'lblComponente
        '
        Me.lblComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComponente.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponente.Location = New System.Drawing.Point(51, 37)
        Me.lblComponente.Name = "lblComponente"
        Me.lblComponente.Size = New System.Drawing.Size(436, 20)
        Me.lblComponente.TabIndex = 10
        Me.lblComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(8, 93)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(220, 20)
        Me.lblCodigo.TabIndex = 15
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSerie
        '
        Me.lblSerie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerie.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(303, 93)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(218, 20)
        Me.lblSerie.TabIndex = 9
        Me.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId
        '
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Location = New System.Drawing.Point(8, 37)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(40, 20)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "0"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SERIE:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(490, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(31, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "COMPONENTE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CODIGO:"
        '
        'btnMontar
        '
        Me.btnMontar.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMontar.Location = New System.Drawing.Point(5, 235)
        Me.btnMontar.Name = "btnMontar"
        Me.btnMontar.Size = New System.Drawing.Size(534, 37)
        Me.btnMontar.TabIndex = 18
        Me.btnMontar.Text = "MONTAR COMPONENTE"
        Me.btnMontar.UseVisualStyleBackColor = True
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.nudKm)
        Me.gbHeader.Controls.Add(Me.Label3)
        Me.gbHeader.Controls.Add(Me.Label2)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Controls.Add(Me.lblOt)
        Me.gbHeader.Controls.Add(Me.lblActivo)
        Me.gbHeader.Location = New System.Drawing.Point(5, 3)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Size = New System.Drawing.Size(534, 83)
        Me.gbHeader.TabIndex = 17
        Me.gbHeader.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "KM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ACTIVO:"
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.Location = New System.Drawing.Point(377, 30)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(144, 20)
        Me.lblOt.TabIndex = 1
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(6, 30)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(158, 20)
        Me.lblActivo.TabIndex = 0
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudKm
        '
        Me.nudKm.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKm.ForeColor = System.Drawing.Color.Red
        Me.nudKm.Location = New System.Drawing.Point(204, 29)
        Me.nudKm.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudKm.Name = "nudKm"
        Me.nudKm.Size = New System.Drawing.Size(132, 21)
        Me.nudKm.TabIndex = 16
        Me.nudKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmManMontarComponente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(543, 275)
        Me.Controls.Add(Me.gbBody)
        Me.Controls.Add(Me.btnMontar)
        Me.Controls.Add(Me.gbHeader)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManMontarComponente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONTAR COMPONENTE"
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        CType(Me.nudKm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents lblComponente As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnMontar As Button
    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents nudKm As NumericUpDown
End Class

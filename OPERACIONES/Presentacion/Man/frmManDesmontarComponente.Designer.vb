<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManDesmontarComponente
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
        Me.btnDesmontar = New System.Windows.Forms.Button()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.nudKmActual = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.lblCodigoComponente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKmAnterior = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.gbHeader.SuspendLayout()
        CType(Me.nudKmActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDesmontar
        '
        Me.btnDesmontar.Enabled = False
        Me.btnDesmontar.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesmontar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnDesmontar.Location = New System.Drawing.Point(6, 183)
        Me.btnDesmontar.Name = "btnDesmontar"
        Me.btnDesmontar.Size = New System.Drawing.Size(416, 39)
        Me.btnDesmontar.TabIndex = 3
        Me.btnDesmontar.Text = "DESMONTAR"
        Me.btnDesmontar.UseVisualStyleBackColor = True
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.nudKmActual)
        Me.gbHeader.Controls.Add(Me.Label7)
        Me.gbHeader.Controls.Add(Me.lblOt)
        Me.gbHeader.Controls.Add(Me.lblComponente)
        Me.gbHeader.Controls.Add(Me.lblCodigoComponente)
        Me.gbHeader.Controls.Add(Me.Label6)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Controls.Add(Me.Label2)
        Me.gbHeader.Controls.Add(Me.lblKmAnterior)
        Me.gbHeader.Controls.Add(Me.Label5)
        Me.gbHeader.Controls.Add(Me.lblActivo)
        Me.gbHeader.Location = New System.Drawing.Point(6, 4)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Size = New System.Drawing.Size(416, 174)
        Me.gbHeader.TabIndex = 2
        Me.gbHeader.TabStop = False
        '
        'nudKmActual
        '
        Me.nudKmActual.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudKmActual.ForeColor = System.Drawing.Color.Red
        Me.nudKmActual.Location = New System.Drawing.Point(265, 133)
        Me.nudKmActual.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudKmActual.Name = "nudKmActual"
        Me.nudKmActual.Size = New System.Drawing.Size(132, 21)
        Me.nudKmActual.TabIndex = 24
        Me.nudKmActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ORDEN DE TRABAJO:"
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.Location = New System.Drawing.Point(265, 32)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(132, 20)
        Me.lblOt.TabIndex = 23
        '
        'lblComponente
        '
        Me.lblComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComponente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponente.Location = New System.Drawing.Point(139, 82)
        Me.lblComponente.Name = "lblComponente"
        Me.lblComponente.Size = New System.Drawing.Size(263, 20)
        Me.lblComponente.TabIndex = 20
        '
        'lblCodigoComponente
        '
        Me.lblCodigoComponente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigoComponente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoComponente.Location = New System.Drawing.Point(10, 82)
        Me.lblCodigoComponente.Name = "lblCodigoComponente"
        Me.lblCodigoComponente.Size = New System.Drawing.Size(123, 20)
        Me.lblCodigoComponente.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "COMPONENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ACTIVO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "KM ACTUAL:"
        '
        'lblKmAnterior
        '
        Me.lblKmAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKmAnterior.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmAnterior.Location = New System.Drawing.Point(10, 134)
        Me.lblKmAnterior.Name = "lblKmAnterior"
        Me.lblKmAnterior.Size = New System.Drawing.Size(153, 20)
        Me.lblKmAnterior.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "KM ANTERIOR:"
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(10, 32)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(130, 20)
        Me.lblActivo.TabIndex = 10
        '
        'frmManDesmontarComponente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(425, 225)
        Me.Controls.Add(Me.btnDesmontar)
        Me.Controls.Add(Me.gbHeader)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManDesmontarComponente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESMONTAR COMPONENTE"
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        CType(Me.nudKmActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDesmontar As Button
    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblComponente As Label
    Friend WithEvents lblCodigoComponente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKmAnterior As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents nudKmActual As NumericUpDown
End Class

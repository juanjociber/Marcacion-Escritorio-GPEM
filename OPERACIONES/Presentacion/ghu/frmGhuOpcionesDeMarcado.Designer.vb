<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGhuOpcionesDeMarcado
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
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.gbBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.btnSalida)
        Me.gbBody.Controls.Add(Me.btnIngreso)
        Me.gbBody.Location = New System.Drawing.Point(4, 2)
        Me.gbBody.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbBody.Size = New System.Drawing.Size(497, 125)
        Me.gbBody.TabIndex = 0
        Me.gbBody.TabStop = False
        '
        'btnSalida
        '
        Me.btnSalida.BackColor = System.Drawing.Color.Red
        Me.btnSalida.Enabled = False
        Me.btnSalida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalida.ForeColor = System.Drawing.Color.White
        Me.btnSalida.Location = New System.Drawing.Point(263, 19)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(210, 90)
        Me.btnSalida.TabIndex = 1
        Me.btnSalida.Text = "No disponible"
        Me.btnSalida.UseVisualStyleBackColor = False
        '
        'btnIngreso
        '
        Me.btnIngreso.BackColor = System.Drawing.Color.LimeGreen
        Me.btnIngreso.Enabled = False
        Me.btnIngreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.ForeColor = System.Drawing.Color.White
        Me.btnIngreso.Location = New System.Drawing.Point(23, 19)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(210, 90)
        Me.btnIngreso.TabIndex = 0
        Me.btnIngreso.Text = "No disponible"
        Me.btnIngreso.UseVisualStyleBackColor = False
        '
        'frmGhuOpcionesDeMarcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(507, 131)
        Me.Controls.Add(Me.gbBody)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGhuOpcionesDeMarcado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones de marcación"
        Me.gbBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnSalida As Button
End Class

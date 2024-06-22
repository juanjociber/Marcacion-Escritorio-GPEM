<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatioRegistrarTareo
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
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTipoOt = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.gbBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.lblMensaje)
        Me.gbBody.Controls.Add(Me.Label3)
        Me.gbBody.Controls.Add(Me.lblTipoOt)
        Me.gbBody.Controls.Add(Me.lblOt)
        Me.gbBody.Controls.Add(Me.lblActivo)
        Me.gbBody.Controls.Add(Me.Label5)
        Me.gbBody.Controls.Add(Me.Label4)
        Me.gbBody.Controls.Add(Me.Label2)
        Me.gbBody.Controls.Add(Me.txtDni)
        Me.gbBody.Location = New System.Drawing.Point(6, 1)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(587, 155)
        Me.gbBody.TabIndex = 0
        Me.gbBody.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(12, 123)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(563, 16)
        Me.lblMensaje.TabIndex = 12
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DNI:"
        '
        'lblTipoOt
        '
        Me.lblTipoOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoOt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoOt.Location = New System.Drawing.Point(383, 37)
        Me.lblTipoOt.Name = "lblTipoOt"
        Me.lblTipoOt.Size = New System.Drawing.Size(192, 24)
        Me.lblTipoOt.TabIndex = 10
        Me.lblTipoOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOt.Location = New System.Drawing.Point(13, 37)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(143, 24)
        Me.lblOt.TabIndex = 9
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActivo.Location = New System.Drawing.Point(184, 37)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(168, 24)
        Me.lblActivo.TabIndex = 7
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "OT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TIPO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ACTIVO:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(187, 80)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(253, 32)
        Me.txtDni.TabIndex = 0
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPatioRegistrarTareo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(598, 161)
        Me.Controls.Add(Me.gbBody)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatioRegistrarTareo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRAR TAREO"
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMensaje As Label
    Public WithEvents lblTipoOt As Label
    Public WithEvents lblOt As Label
    Public WithEvents lblActivo As Label
End Class

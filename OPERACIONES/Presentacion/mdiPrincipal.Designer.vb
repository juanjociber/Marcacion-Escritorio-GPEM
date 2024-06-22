<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbTareos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbOts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.stbHora = New System.Windows.Forms.ToolStripLabel()
        Me.tslHora = New System.Windows.Forms.ToolStripLabel()
        Me.tsbMarcador = New System.Windows.Forms.ToolStripButton()
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.ssEstado = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbTareos, Me.ToolStripSeparator1, Me.tsbOts, Me.ToolStripSeparator2, Me.stbHora, Me.tslHora, Me.tsbMarcador})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(684, 39)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsbTareos
        '
        Me.tsbTareos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbTareos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsbTareos.Image = CType(resources.GetObject("tsbTareos.Image"), System.Drawing.Image)
        Me.tsbTareos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbTareos.Name = "tsbTareos"
        Me.tsbTareos.Size = New System.Drawing.Size(99, 36)
        Me.tsbTareos.Text = "TAREOS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbOts
        '
        Me.tsbOts.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbOts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tsbOts.Image = CType(resources.GetObject("tsbOts.Image"), System.Drawing.Image)
        Me.tsbOts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOts.Name = "tsbOts"
        Me.tsbOts.Size = New System.Drawing.Size(109, 36)
        Me.tsbOts.Text = "ORDENES"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'stbHora
        '
        Me.stbHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.stbHora.Name = "stbHora"
        Me.stbHora.Size = New System.Drawing.Size(0, 36)
        '
        'tslHora
        '
        Me.tslHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslHora.AutoSize = False
        Me.tslHora.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tslHora.Name = "tslHora"
        Me.tslHora.Size = New System.Drawing.Size(200, 36)
        Me.tslHora.Text = "00/00/0000 00:00"
        '
        'tsbMarcador
        '
        Me.tsbMarcador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbMarcador.Image = CType(resources.GetObject("tsbMarcador.Image"), System.Drawing.Image)
        Me.tsbMarcador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbMarcador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMarcador.Name = "tsbMarcador"
        Me.tsbMarcador.Size = New System.Drawing.Size(120, 36)
        Me.tsbMarcador.Text = "MARCADOR"
        '
        'tmrReloj
        '
        Me.tmrReloj.Enabled = True
        Me.tmrReloj.Interval = 10000
        '
        'ssEstado
        '
        Me.ssEstado.Location = New System.Drawing.Point(0, 475)
        Me.ssEstado.Name = "ssEstado"
        Me.ssEstado.Size = New System.Drawing.Size(684, 22)
        Me.ssEstado.TabIndex = 8
        Me.ssEstado.Text = "StatusStrip1"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 497)
        Me.Controls.Add(Me.ssEstado)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 536)
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESMAN-TALLER - v3.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsbTareos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbOts As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tslHora As ToolStripLabel
    Friend WithEvents stbHora As ToolStripLabel
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents tsbMarcador As ToolStripButton
    Friend WithEvents ssEstado As StatusStrip
End Class

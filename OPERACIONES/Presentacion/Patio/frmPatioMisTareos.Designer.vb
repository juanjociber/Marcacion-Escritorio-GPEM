<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatioMisTareos
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
        Me.dgvTareos = New System.Windows.Forms.DataGridView()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.gbBody.SuspendLayout()
        CType(Me.dgvTareos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.dgvTareos)
        Me.gbBody.Location = New System.Drawing.Point(5, 61)
        Me.gbBody.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBody.Size = New System.Drawing.Size(940, 435)
        Me.gbBody.TabIndex = 3
        Me.gbBody.TabStop = False
        '
        'dgvTareos
        '
        Me.dgvTareos.AllowUserToAddRows = False
        Me.dgvTareos.AllowUserToDeleteRows = False
        Me.dgvTareos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvTareos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareos.Location = New System.Drawing.Point(3, 12)
        Me.dgvTareos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTareos.MultiSelect = False
        Me.dgvTareos.Name = "dgvTareos"
        Me.dgvTareos.ReadOnly = True
        Me.dgvTareos.RowHeadersVisible = False
        Me.dgvTareos.RowTemplate.Height = 35
        Me.dgvTareos.Size = New System.Drawing.Size(932, 415)
        Me.dgvTareos.TabIndex = 0
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.dtpFecha)
        Me.gbHeader.Controls.Add(Me.Label2)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Controls.Add(Me.txtDni)
        Me.gbHeader.Location = New System.Drawing.Point(5, 1)
        Me.gbHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Padding = New System.Windows.Forms.Padding(2)
        Me.gbHeader.Size = New System.Drawing.Size(940, 57)
        Me.gbHeader.TabIndex = 2
        Me.gbHeader.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(486, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(194, 26)
        Me.dtpFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TAREO CERRADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TAREO EN PROCESO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(708, 14)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(221, 35)
        Me.txtDni.TabIndex = 0
        '
        'frmPatioMisTareos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(950, 497)
        Me.Controls.Add(Me.gbBody)
        Me.Controls.Add(Me.gbHeader)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatioMisTareos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA DE TAREOS POR TECNICO"
        Me.gbBody.ResumeLayout(False)
        CType(Me.dgvTareos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents dgvTareos As DataGridView
    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDni As TextBox
End Class

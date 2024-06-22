<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManBuscarComponentes
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
        Me.dgvComponentes = New System.Windows.Forms.DataGridView()
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComponente = New System.Windows.Forms.TextBox()
        Me.gbBody.SuspendLayout()
        CType(Me.dgvComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.dgvComponentes)
        Me.gbBody.Location = New System.Drawing.Point(5, 64)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(475, 250)
        Me.gbBody.TabIndex = 7
        Me.gbBody.TabStop = False
        '
        'dgvComponentes
        '
        Me.dgvComponentes.AllowUserToAddRows = False
        Me.dgvComponentes.AllowUserToDeleteRows = False
        Me.dgvComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponentes.Location = New System.Drawing.Point(5, 12)
        Me.dgvComponentes.Name = "dgvComponentes"
        Me.dgvComponentes.ReadOnly = True
        Me.dgvComponentes.RowHeadersVisible = False
        Me.dgvComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvComponentes.Size = New System.Drawing.Size(462, 232)
        Me.dgvComponentes.TabIndex = 0
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.btnBuscar)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Controls.Add(Me.txtComponente)
        Me.gbHeader.Location = New System.Drawing.Point(5, 3)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Size = New System.Drawing.Size(475, 60)
        Me.gbHeader.TabIndex = 6
        Me.gbHeader.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(392, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CODIGO / SERIE"
        '
        'txtComponente
        '
        Me.txtComponente.Location = New System.Drawing.Point(13, 29)
        Me.txtComponente.Name = "txtComponente"
        Me.txtComponente.Size = New System.Drawing.Size(372, 20)
        Me.txtComponente.TabIndex = 0
        '
        'frmManBuscarComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(484, 316)
        Me.Controls.Add(Me.gbBody)
        Me.Controls.Add(Me.gbHeader)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManBuscarComponentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR COMPONENTES"
        Me.gbBody.ResumeLayout(False)
        CType(Me.dgvComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBody As GroupBox
    Friend WithEvents dgvComponentes As DataGridView
    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtComponente As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatioTecnicosXOt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatioTecnicosXOt))
        Me.gbBody = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoOt = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblActividad02 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcOt = New System.Windows.Forms.TabControl()
        Me.tpTareos = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvTecnicos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tpProductos = New System.Windows.Forms.TabPage()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.idtareo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tecniconombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ingresotareo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salidatareo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempotareo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadotareo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medida2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbBody.SuspendLayout()
        Me.tcOt.SuspendLayout()
        Me.tpTareos.SuspendLayout()
        CType(Me.dgvTecnicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.lblEstado)
        Me.gbBody.Controls.Add(Me.Label1)
        Me.gbBody.Controls.Add(Me.lblTipoOt)
        Me.gbBody.Controls.Add(Me.lblOt)
        Me.gbBody.Controls.Add(Me.lblActividad)
        Me.gbBody.Controls.Add(Me.lblActivo)
        Me.gbBody.Controls.Add(Me.Label5)
        Me.gbBody.Controls.Add(Me.Label4)
        Me.gbBody.Controls.Add(Me.lblActividad02)
        Me.gbBody.Controls.Add(Me.Label2)
        Me.gbBody.Location = New System.Drawing.Point(5, 2)
        Me.gbBody.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbBody.Size = New System.Drawing.Size(531, 110)
        Me.gbBody.TabIndex = 2
        Me.gbBody.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstado.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(411, 31)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(112, 19)
        Me.lblEstado.TabIndex = 14
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(414, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ESTADO:"
        '
        'lblTipoOt
        '
        Me.lblTipoOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoOt.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTipoOt.Location = New System.Drawing.Point(264, 31)
        Me.lblTipoOt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoOt.Name = "lblTipoOt"
        Me.lblTipoOt.Size = New System.Drawing.Size(133, 19)
        Me.lblTipoOt.TabIndex = 10
        Me.lblTipoOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOt
        '
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOt.Location = New System.Drawing.Point(9, 31)
        Me.lblOt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(99, 19)
        Me.lblOt.TabIndex = 9
        Me.lblOt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActividad
        '
        Me.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActividad.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActividad.Location = New System.Drawing.Point(9, 75)
        Me.lblActividad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(512, 19)
        Me.lblActividad.TabIndex = 8
        Me.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActivo
        '
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActivo.Location = New System.Drawing.Point(132, 31)
        Me.lblActivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(112, 19)
        Me.lblActivo.TabIndex = 7
        Me.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ORDEN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(267, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TIPO:"
        '
        'lblActividad02
        '
        Me.lblActividad02.AutoSize = True
        Me.lblActividad02.ForeColor = System.Drawing.Color.Gray
        Me.lblActividad02.Location = New System.Drawing.Point(12, 57)
        Me.lblActividad02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActividad02.Name = "lblActividad02"
        Me.lblActividad02.Size = New System.Drawing.Size(57, 15)
        Me.lblActividad02.TabIndex = 3
        Me.lblActividad02.Text = "ACTIVIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(135, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ACTIVO:"
        '
        'tcOt
        '
        Me.tcOt.Controls.Add(Me.tpTareos)
        Me.tcOt.Controls.Add(Me.tpProductos)
        Me.tcOt.Location = New System.Drawing.Point(4, 119)
        Me.tcOt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tcOt.Name = "tcOt"
        Me.tcOt.SelectedIndex = 0
        Me.tcOt.Size = New System.Drawing.Size(531, 364)
        Me.tcOt.TabIndex = 4
        '
        'tpTareos
        '
        Me.tpTareos.Controls.Add(Me.Label6)
        Me.tpTareos.Controls.Add(Me.dgvTecnicos)
        Me.tpTareos.Controls.Add(Me.Label3)
        Me.tpTareos.Controls.Add(Me.btnAgregar)
        Me.tpTareos.Location = New System.Drawing.Point(4, 24)
        Me.tpTareos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tpTareos.Name = "tpTareos"
        Me.tpTareos.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tpTareos.Size = New System.Drawing.Size(523, 336)
        Me.tpTareos.TabIndex = 0
        Me.tpTareos.Text = "TAREOS"
        Me.tpTareos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(111, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CERRADO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTecnicos
        '
        Me.dgvTecnicos.AllowUserToAddRows = False
        Me.dgvTecnicos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTecnicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTecnicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idtareo, Me.tecniconombre, Me.ingresotareo, Me.salidatareo, Me.tiempotareo, Me.estadotareo})
        Me.dgvTecnicos.Location = New System.Drawing.Point(5, 52)
        Me.dgvTecnicos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvTecnicos.Name = "dgvTecnicos"
        Me.dgvTecnicos.ReadOnly = True
        Me.dgvTecnicos.RowHeadersVisible = False
        Me.dgvTecnicos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTecnicos.RowTemplate.Height = 30
        Me.dgvTecnicos.Size = New System.Drawing.Size(512, 279)
        Me.dgvTecnicos.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ABIERTO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Blue
        Me.btnAgregar.Location = New System.Drawing.Point(382, 8)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(135, 35)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "REGISTRAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tpProductos
        '
        Me.tpProductos.Controls.Add(Me.dgvProductos)
        Me.tpProductos.Controls.Add(Me.btnProductos)
        Me.tpProductos.Location = New System.Drawing.Point(4, 24)
        Me.tpProductos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tpProductos.Name = "tpProductos"
        Me.tpProductos.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tpProductos.Size = New System.Drawing.Size(523, 336)
        Me.tpProductos.TabIndex = 1
        Me.tpProductos.Text = "PRODUCTOS"
        Me.tpProductos.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo2, Me.nombre2, Me.cantidad2, Me.medida2})
        Me.dgvProductos.Location = New System.Drawing.Point(5, 52)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.RowTemplate.Height = 30
        Me.dgvProductos.Size = New System.Drawing.Size(512, 279)
        Me.dgvProductos.TabIndex = 1
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProductos.Enabled = False
        Me.btnProductos.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.Blue
        Me.btnProductos.Location = New System.Drawing.Point(6, 6)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(170, 40)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "RECUPERAR PRODUCTOS"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'idtareo
        '
        Me.idtareo.HeaderText = "idtareo"
        Me.idtareo.Name = "idtareo"
        Me.idtareo.ReadOnly = True
        Me.idtareo.Visible = False
        Me.idtareo.Width = 40
        '
        'tecniconombre
        '
        Me.tecniconombre.HeaderText = "NOMBRE"
        Me.tecniconombre.Name = "tecniconombre"
        Me.tecniconombre.ReadOnly = True
        Me.tecniconombre.Width = 200
        '
        'ingresotareo
        '
        Me.ingresotareo.HeaderText = "INGRESO"
        Me.ingresotareo.Name = "ingresotareo"
        Me.ingresotareo.ReadOnly = True
        Me.ingresotareo.Width = 110
        '
        'salidatareo
        '
        Me.salidatareo.HeaderText = "SALIDA"
        Me.salidatareo.Name = "salidatareo"
        Me.salidatareo.ReadOnly = True
        Me.salidatareo.Width = 110
        '
        'tiempotareo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tiempotareo.DefaultCellStyle = DataGridViewCellStyle2
        Me.tiempotareo.HeaderText = "MINUTOS"
        Me.tiempotareo.Name = "tiempotareo"
        Me.tiempotareo.ReadOnly = True
        Me.tiempotareo.Width = 60
        '
        'estadotareo
        '
        Me.estadotareo.HeaderText = "estadotareo"
        Me.estadotareo.Name = "estadotareo"
        Me.estadotareo.ReadOnly = True
        Me.estadotareo.Visible = False
        Me.estadotareo.Width = 79
        '
        'codigo2
        '
        Me.codigo2.HeaderText = "CODIGO"
        Me.codigo2.Name = "codigo2"
        Me.codigo2.ReadOnly = True
        Me.codigo2.Width = 90
        '
        'nombre2
        '
        Me.nombre2.HeaderText = "NOMBRE"
        Me.nombre2.Name = "nombre2"
        Me.nombre2.ReadOnly = True
        Me.nombre2.Width = 250
        '
        'cantidad2
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cantidad2.DefaultCellStyle = DataGridViewCellStyle3
        Me.cantidad2.HeaderText = "CANTIDAD"
        Me.cantidad2.Name = "cantidad2"
        Me.cantidad2.ReadOnly = True
        Me.cantidad2.Width = 70
        '
        'medida2
        '
        Me.medida2.HeaderText = "MEDIDA"
        Me.medida2.Name = "medida2"
        Me.medida2.ReadOnly = True
        Me.medida2.Width = 80
        '
        'frmPatioTecnicosXOt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(538, 485)
        Me.Controls.Add(Me.tcOt)
        Me.Controls.Add(Me.gbBody)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatioTecnicosXOt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECURSOS DE LA ORDEN DE TRABAJO"
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        Me.tcOt.ResumeLayout(False)
        Me.tpTareos.ResumeLayout(False)
        CType(Me.dgvTecnicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpProductos.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBody As GroupBox
    Friend WithEvents lblTipoOt As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents lblActividad As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblActividad02 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tcOt As TabControl
    Friend WithEvents tpTareos As TabPage
    Friend WithEvents tpProductos As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvTecnicos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents idtareo As DataGridViewTextBoxColumn
    Friend WithEvents tecniconombre As DataGridViewTextBoxColumn
    Friend WithEvents ingresotareo As DataGridViewTextBoxColumn
    Friend WithEvents salidatareo As DataGridViewTextBoxColumn
    Friend WithEvents tiempotareo As DataGridViewTextBoxColumn
    Friend WithEvents estadotareo As DataGridViewTextBoxColumn
    Friend WithEvents codigo2 As DataGridViewTextBoxColumn
    Friend WithEvents nombre2 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad2 As DataGridViewTextBoxColumn
    Friend WithEvents medida2 As DataGridViewTextBoxColumn
End Class

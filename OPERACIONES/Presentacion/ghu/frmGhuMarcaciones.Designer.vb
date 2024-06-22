<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGhuMarcaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGhuMarcaciones))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFechaMarcacion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHorarioMarcacion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblIngresoLabores = New System.Windows.Forms.Label()
        Me.lblIngresoRefrigerio = New System.Windows.Forms.Label()
        Me.lblSalidaRefrigerio = New System.Windows.Forms.Label()
        Me.lblSalidaLabores = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefrigerio = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFechaSistema = New System.Windows.Forms.Label()
        Me.lblHoraSistema = New System.Windows.Forms.Label()
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel13, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(979, 506)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(726, 498)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 312)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(718, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Último registro"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(710, 159)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblFechaMarcacion, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblHorarioMarcacion, 4, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(702, 55)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lblFechaMarcacion
        '
        Me.lblFechaMarcacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaMarcacion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMarcacion.Location = New System.Drawing.Point(111, 0)
        Me.lblFechaMarcacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaMarcacion.Name = "lblFechaMarcacion"
        Me.lblFechaMarcacion.Size = New System.Drawing.Size(152, 55)
        Me.lblFechaMarcacion.TabIndex = 21
        Me.lblFechaMarcacion.Text = "-*-"
        Me.lblFechaMarcacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 55)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "FECHA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(359, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 55)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "HORARIO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHorarioMarcacion
        '
        Me.lblHorarioMarcacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHorarioMarcacion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarioMarcacion.Location = New System.Drawing.Point(479, 0)
        Me.lblHorarioMarcacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorarioMarcacion.Name = "lblHorarioMarcacion"
        Me.lblHorarioMarcacion.Size = New System.Drawing.Size(219, 55)
        Me.lblHorarioMarcacion.TabIndex = 23
        Me.lblHorarioMarcacion.Text = "-*-"
        Me.lblHorarioMarcacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 7
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblIngresoLabores, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblIngresoRefrigerio, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSalidaRefrigerio, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSalidaLabores, 6, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 67)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(702, 88)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'lblIngresoLabores
        '
        Me.lblIngresoLabores.BackColor = System.Drawing.Color.Blue
        Me.lblIngresoLabores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIngresoLabores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIngresoLabores.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoLabores.ForeColor = System.Drawing.Color.White
        Me.lblIngresoLabores.Location = New System.Drawing.Point(4, 0)
        Me.lblIngresoLabores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngresoLabores.Name = "lblIngresoLabores"
        Me.lblIngresoLabores.Size = New System.Drawing.Size(139, 88)
        Me.lblIngresoLabores.TabIndex = 14
        Me.lblIngresoLabores.Text = "INGRESO LABORES"
        Me.lblIngresoLabores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIngresoLabores.Visible = False
        '
        'lblIngresoRefrigerio
        '
        Me.lblIngresoRefrigerio.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIngresoRefrigerio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIngresoRefrigerio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIngresoRefrigerio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoRefrigerio.ForeColor = System.Drawing.Color.White
        Me.lblIngresoRefrigerio.Location = New System.Drawing.Point(193, 0)
        Me.lblIngresoRefrigerio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngresoRefrigerio.Name = "lblIngresoRefrigerio"
        Me.lblIngresoRefrigerio.Size = New System.Drawing.Size(132, 88)
        Me.lblIngresoRefrigerio.TabIndex = 16
        Me.lblIngresoRefrigerio.Text = "INGRESO REFRIGERIO"
        Me.lblIngresoRefrigerio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblIngresoRefrigerio.Visible = False
        '
        'lblSalidaRefrigerio
        '
        Me.lblSalidaRefrigerio.BackColor = System.Drawing.Color.DarkOrange
        Me.lblSalidaRefrigerio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalidaRefrigerio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalidaRefrigerio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidaRefrigerio.ForeColor = System.Drawing.Color.White
        Me.lblSalidaRefrigerio.Location = New System.Drawing.Point(375, 0)
        Me.lblSalidaRefrigerio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalidaRefrigerio.Name = "lblSalidaRefrigerio"
        Me.lblSalidaRefrigerio.Size = New System.Drawing.Size(132, 88)
        Me.lblSalidaRefrigerio.TabIndex = 17
        Me.lblSalidaRefrigerio.Text = "SALIDA REFRIGERIO"
        Me.lblSalidaRefrigerio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSalidaRefrigerio.Visible = False
        '
        'lblSalidaLabores
        '
        Me.lblSalidaLabores.BackColor = System.Drawing.Color.Blue
        Me.lblSalidaLabores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalidaLabores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalidaLabores.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalidaLabores.ForeColor = System.Drawing.Color.White
        Me.lblSalidaLabores.Location = New System.Drawing.Point(557, 0)
        Me.lblSalidaLabores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalidaLabores.Name = "lblSalidaLabores"
        Me.lblSalidaLabores.Size = New System.Drawing.Size(141, 88)
        Me.lblSalidaLabores.TabIndex = 18
        Me.lblSalidaLabores.Text = "SALIDA LABORES"
        Me.lblSalidaLabores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSalidaLabores.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(718, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del usuario"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.pbFoto, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(710, 277)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbFoto.Location = New System.Drawing.Point(4, 4)
        Me.pbFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(240, 269)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 1
        Me.pbFoto.TabStop = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel10, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel11, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel12, 0, 4)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(252, 4)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 5
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(454, 269)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lblCodigo, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(446, 45)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodigo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(137, 0)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(305, 45)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.lblNombres, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(4, 57)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(446, 45)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'lblNombres
        '
        Me.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombres.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNombres.Location = New System.Drawing.Point(137, 0)
        Me.lblNombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(305, 45)
        Me.lblNombres.TabIndex = 8
        Me.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.lblApellidos, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(4, 110)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(446, 45)
        Me.TableLayoutPanel10.TabIndex = 2
        '
        'lblApellidos
        '
        Me.lblApellidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApellidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApellidos.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblApellidos.Location = New System.Drawing.Point(137, 0)
        Me.lblApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(305, 45)
        Me.lblApellidos.TabIndex = 9
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.lblDni, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(4, 163)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(446, 45)
        Me.TableLayoutPanel11.TabIndex = 3
        '
        'lblDni
        '
        Me.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDni.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDni.Location = New System.Drawing.Point(137, 0)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(305, 45)
        Me.lblDni.TabIndex = 10
        Me.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 45)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DNI:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.lblCargo, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(4, 216)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(446, 49)
        Me.TableLayoutPanel12.TabIndex = 4
        '
        'lblCargo
        '
        Me.lblCargo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCargo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCargo.Location = New System.Drawing.Point(137, 0)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(305, 49)
        Me.lblCargo.TabIndex = 11
        Me.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(4, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 49)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cargo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.TableLayoutPanel15, 0, 1)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(738, 4)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 2
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(237, 498)
        Me.TableLayoutPanel13.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel14)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(229, 315)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btnRefrigerio, 0, 5)
        Me.TableLayoutPanel14.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.txtDni, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.btnAsistencia, 0, 3)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(4, 19)
        Me.TableLayoutPanel14.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 6
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(221, 292)
        Me.TableLayoutPanel14.TabIndex = 0
        '
        'btnRefrigerio
        '
        Me.btnRefrigerio.BackColor = System.Drawing.Color.Orange
        Me.btnRefrigerio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRefrigerio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.btnRefrigerio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnRefrigerio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrigerio.ForeColor = System.Drawing.Color.White
        Me.btnRefrigerio.Location = New System.Drawing.Point(4, 207)
        Me.btnRefrigerio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefrigerio.Name = "btnRefrigerio"
        Me.btnRefrigerio.Size = New System.Drawing.Size(213, 80)
        Me.btnRefrigerio.TabIndex = 13
        Me.btnRefrigerio.Text = "REFRIGERIO"
        Me.btnRefrigerio.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(4, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "N° DNI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDni
        '
        Me.txtDni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDni.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(4, 33)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(213, 42)
        Me.txtDni.TabIndex = 11
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackColor = System.Drawing.Color.Blue
        Me.btnAsistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAsistencia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencia.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAsistencia.Location = New System.Drawing.Point(4, 105)
        Me.btnAsistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(213, 79)
        Me.btnAsistencia.TabIndex = 12
        Me.btnAsistencia.Text = "ASISTENCIA"
        Me.btnAsistencia.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.lblFechaSistema, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.lblHoraSistema, 0, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(4, 327)
        Me.TableLayoutPanel15.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(229, 167)
        Me.TableLayoutPanel15.TabIndex = 1
        '
        'lblFechaSistema
        '
        Me.lblFechaSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaSistema.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSistema.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFechaSistema.Location = New System.Drawing.Point(4, 83)
        Me.lblFechaSistema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaSistema.Name = "lblFechaSistema"
        Me.lblFechaSistema.Size = New System.Drawing.Size(221, 84)
        Me.lblFechaSistema.TabIndex = 12
        Me.lblFechaSistema.Text = "Fecha"
        Me.lblFechaSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoraSistema
        '
        Me.lblHoraSistema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraSistema.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSistema.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHoraSistema.Location = New System.Drawing.Point(4, 0)
        Me.lblHoraSistema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraSistema.Name = "lblHoraSistema"
        Me.lblHoraSistema.Size = New System.Drawing.Size(221, 83)
        Me.lblHoraSistema.TabIndex = 11
        Me.lblHoraSistema.Text = "Hora"
        Me.lblHoraSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrReloj
        '
        Me.tmrReloj.Interval = 60000
        '
        'frmGhuMarcaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 506)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(994, 542)
        Me.Name = "frmGhuMarcaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE MARCACIONES"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblFechaMarcacion As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHorarioMarcacion As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblIngresoLabores As Label
    Friend WithEvents lblIngresoRefrigerio As Label
    Friend WithEvents lblSalidaRefrigerio As Label
    Friend WithEvents lblSalidaLabores As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents btnAsistencia As Button
    Friend WithEvents btnRefrigerio As Button
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents lblHoraSistema As Label
    Friend WithEvents lblFechaSistema As Label
    Friend WithEvents tmrReloj As Timer
End Class

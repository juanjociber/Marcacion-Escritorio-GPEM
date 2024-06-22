<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatioActualizarOt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatioActualizarOt))
        Me.gbHeader = New System.Windows.Forms.GroupBox()
        Me.lblKm = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.rtbObservacionesOld = New System.Windows.Forms.RichTextBox()
        Me.rtbTrabajosOld = New System.Windows.Forms.RichTextBox()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblOt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBody = New System.Windows.Forms.GroupBox()
        Me.lblIngreso = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rtbObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbTrabajos = New System.Windows.Forms.RichTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tcOt = New System.Windows.Forms.TabControl()
        Me.tpOt = New System.Windows.Forms.TabPage()
        Me.tpComponentes = New System.Windows.Forms.TabPage()
        Me.btnBajaComponente = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnObtenerListaDeComponentes = New System.Windows.Forms.Button()
        Me.btnRepararComponente = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnMontarComponente = New System.Windows.Forms.Button()
        Me.dgvComponentes2 = New System.Windows.Forms.DataGridView()
        Me.dgvComponentes1 = New System.Windows.Forms.DataGridView()
        Me.tpSeguimientos = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.dgvSeguimientos1 = New System.Windows.Forms.DataGridView()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnRecuperarSeguimientos = New System.Windows.Forms.Button()
        Me.btnNuevoSeguimiento = New System.Windows.Forms.Button()
        Me.dgvSeguimientos2 = New System.Windows.Forms.DataGridView()
        Me.gbHeader.SuspendLayout()
        Me.gbBody.SuspendLayout()
        Me.tcOt.SuspendLayout()
        Me.tpOt.SuspendLayout()
        Me.tpComponentes.SuspendLayout()
        CType(Me.dgvComponentes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComponentes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSeguimientos.SuspendLayout()
        CType(Me.dgvSeguimientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSeguimientos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbHeader
        '
        Me.gbHeader.Controls.Add(Me.lblKm)
        Me.gbHeader.Controls.Add(Me.Label18)
        Me.gbHeader.Controls.Add(Me.lblEstado)
        Me.gbHeader.Controls.Add(Me.lblFecha)
        Me.gbHeader.Controls.Add(Me.rtbObservacionesOld)
        Me.gbHeader.Controls.Add(Me.rtbTrabajosOld)
        Me.gbHeader.Controls.Add(Me.lblActividad)
        Me.gbHeader.Controls.Add(Me.Label11)
        Me.gbHeader.Controls.Add(Me.lblCliente)
        Me.gbHeader.Controls.Add(Me.lblTipo)
        Me.gbHeader.Controls.Add(Me.lblActivo)
        Me.gbHeader.Controls.Add(Me.lblOt)
        Me.gbHeader.Controls.Add(Me.Label9)
        Me.gbHeader.Controls.Add(Me.Label8)
        Me.gbHeader.Controls.Add(Me.Label7)
        Me.gbHeader.Controls.Add(Me.Label6)
        Me.gbHeader.Controls.Add(Me.Label5)
        Me.gbHeader.Controls.Add(Me.Label4)
        Me.gbHeader.Controls.Add(Me.Label3)
        Me.gbHeader.Controls.Add(Me.Label1)
        Me.gbHeader.Location = New System.Drawing.Point(5, 4)
        Me.gbHeader.Name = "gbHeader"
        Me.gbHeader.Size = New System.Drawing.Size(888, 284)
        Me.gbHeader.TabIndex = 1
        Me.gbHeader.TabStop = False
        '
        'lblKm
        '
        Me.lblKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKm.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKm.Location = New System.Drawing.Point(204, 73)
        Me.lblKm.Name = "lblKm"
        Me.lblKm.Size = New System.Drawing.Size(124, 20)
        Me.lblKm.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(207, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 15)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Km:"
        '
        'lblEstado
        '
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(609, 73)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(166, 20)
        Me.lblEstado.TabIndex = 19
        '
        'lblFecha
        '
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(6, 73)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(143, 18)
        Me.lblFecha.TabIndex = 18
        '
        'rtbObservacionesOld
        '
        Me.rtbObservacionesOld.Location = New System.Drawing.Point(578, 166)
        Me.rtbObservacionesOld.Name = "rtbObservacionesOld"
        Me.rtbObservacionesOld.ReadOnly = True
        Me.rtbObservacionesOld.Size = New System.Drawing.Size(302, 110)
        Me.rtbObservacionesOld.TabIndex = 17
        Me.rtbObservacionesOld.Text = ""
        '
        'rtbTrabajosOld
        '
        Me.rtbTrabajosOld.Location = New System.Drawing.Point(6, 166)
        Me.rtbTrabajosOld.Name = "rtbTrabajosOld"
        Me.rtbTrabajosOld.ReadOnly = True
        Me.rtbTrabajosOld.Size = New System.Drawing.Size(566, 110)
        Me.rtbTrabajosOld.TabIndex = 16
        Me.rtbTrabajosOld.Text = ""
        '
        'lblActividad
        '
        Me.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActividad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividad.Location = New System.Drawing.Point(6, 118)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(874, 20)
        Me.lblActividad.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(612, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Estado:"
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCliente.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Red
        Me.lblCliente.Location = New System.Drawing.Point(609, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(271, 20)
        Me.lblCliente.TabIndex = 12
        '
        'lblTipo
        '
        Me.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(382, 30)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(190, 20)
        Me.lblTipo.TabIndex = 11
        '
        'lblActivo
        '
        Me.lblActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblActivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.ForeColor = System.Drawing.Color.Red
        Me.lblActivo.Location = New System.Drawing.Point(204, 30)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(140, 20)
        Me.lblActivo.TabIndex = 10
        '
        'lblOt
        '
        Me.lblOt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblOt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOt.ForeColor = System.Drawing.Color.Red
        Me.lblOt.Location = New System.Drawing.Point(6, 30)
        Me.lblOt.Name = "lblOt"
        Me.lblOt.Size = New System.Drawing.Size(145, 20)
        Me.lblOt.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(612, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(581, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Observaciones:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Trabajos realizados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Actividad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(385, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(207, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Activo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Órden:"
        '
        'gbBody
        '
        Me.gbBody.Controls.Add(Me.lblIngreso)
        Me.gbBody.Controls.Add(Me.Label17)
        Me.gbBody.Controls.Add(Me.lblTecnico)
        Me.gbBody.Controls.Add(Me.Label12)
        Me.gbBody.Controls.Add(Me.Label14)
        Me.gbBody.Controls.Add(Me.rtbObservaciones)
        Me.gbBody.Controls.Add(Me.Label2)
        Me.gbBody.Controls.Add(Me.rtbTrabajos)
        Me.gbBody.Location = New System.Drawing.Point(5, 291)
        Me.gbBody.Name = "gbBody"
        Me.gbBody.Size = New System.Drawing.Size(888, 188)
        Me.gbBody.TabIndex = 0
        Me.gbBody.TabStop = False
        '
        'lblIngreso
        '
        Me.lblIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIngreso.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreso.ForeColor = System.Drawing.Color.Red
        Me.lblIngreso.Location = New System.Drawing.Point(630, 16)
        Me.lblIngreso.Name = "lblIngreso"
        Me.lblIngreso.Size = New System.Drawing.Size(250, 20)
        Me.lblIngreso.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(582, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Ingreso:"
        '
        'lblTecnico
        '
        Me.lblTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTecnico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTecnico.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTecnico.ForeColor = System.Drawing.Color.Red
        Me.lblTecnico.Location = New System.Drawing.Point(63, 16)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(509, 20)
        Me.lblTecnico.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(11, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(581, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Nuevas observaciones:"
        '
        'rtbObservaciones
        '
        Me.rtbObservaciones.Enabled = False
        Me.rtbObservaciones.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObservaciones.Location = New System.Drawing.Point(578, 63)
        Me.rtbObservaciones.Name = "rtbObservaciones"
        Me.rtbObservaciones.Size = New System.Drawing.Size(302, 117)
        Me.rtbObservaciones.TabIndex = 2
        Me.rtbObservaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nuevos trabajos:"
        '
        'rtbTrabajos
        '
        Me.rtbTrabajos.Enabled = False
        Me.rtbTrabajos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTrabajos.Location = New System.Drawing.Point(6, 63)
        Me.rtbTrabajos.Name = "rtbTrabajos"
        Me.rtbTrabajos.Size = New System.Drawing.Size(566, 117)
        Me.rtbTrabajos.TabIndex = 0
        Me.rtbTrabajos.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(6, 484)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(890, 46)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tcOt
        '
        Me.tcOt.Controls.Add(Me.tpOt)
        Me.tcOt.Controls.Add(Me.tpComponentes)
        Me.tcOt.Controls.Add(Me.tpSeguimientos)
        Me.tcOt.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcOt.Location = New System.Drawing.Point(3, 3)
        Me.tcOt.Name = "tcOt"
        Me.tcOt.SelectedIndex = 0
        Me.tcOt.Size = New System.Drawing.Size(909, 565)
        Me.tcOt.TabIndex = 3
        '
        'tpOt
        '
        Me.tpOt.Controls.Add(Me.gbHeader)
        Me.tpOt.Controls.Add(Me.btnGuardar)
        Me.tpOt.Controls.Add(Me.gbBody)
        Me.tpOt.Location = New System.Drawing.Point(4, 25)
        Me.tpOt.Name = "tpOt"
        Me.tpOt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOt.Size = New System.Drawing.Size(901, 536)
        Me.tpOt.TabIndex = 0
        Me.tpOt.Text = "ORDEN DE TRABAJO"
        Me.tpOt.UseVisualStyleBackColor = True
        '
        'tpComponentes
        '
        Me.tpComponentes.Controls.Add(Me.btnBajaComponente)
        Me.tpComponentes.Controls.Add(Me.Label31)
        Me.tpComponentes.Controls.Add(Me.Label29)
        Me.tpComponentes.Controls.Add(Me.Label27)
        Me.tpComponentes.Controls.Add(Me.Label25)
        Me.tpComponentes.Controls.Add(Me.Label26)
        Me.tpComponentes.Controls.Add(Me.btnObtenerListaDeComponentes)
        Me.tpComponentes.Controls.Add(Me.btnRepararComponente)
        Me.tpComponentes.Controls.Add(Me.Label28)
        Me.tpComponentes.Controls.Add(Me.Label24)
        Me.tpComponentes.Controls.Add(Me.btnMontarComponente)
        Me.tpComponentes.Controls.Add(Me.dgvComponentes2)
        Me.tpComponentes.Controls.Add(Me.dgvComponentes1)
        Me.tpComponentes.Location = New System.Drawing.Point(4, 25)
        Me.tpComponentes.Name = "tpComponentes"
        Me.tpComponentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpComponentes.Size = New System.Drawing.Size(901, 536)
        Me.tpComponentes.TabIndex = 1
        Me.tpComponentes.Text = "COMPONENTES"
        Me.tpComponentes.UseVisualStyleBackColor = True
        '
        'btnBajaComponente
        '
        Me.btnBajaComponente.Enabled = False
        Me.btnBajaComponente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaComponente.Location = New System.Drawing.Point(669, 273)
        Me.btnBajaComponente.Name = "btnBajaComponente"
        Me.btnBajaComponente.Size = New System.Drawing.Size(224, 35)
        Me.btnBajaComponente.TabIndex = 50
        Me.btnBajaComponente.Text = "BAJA DE COMPONENTE"
        Me.btnBajaComponente.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.LightPink
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(507, 316)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 20)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "[5] BAJA"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.LightBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label29.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(132, 316)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 20)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "[2] MONTAR"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.LightGreen
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 316)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 20)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "[1] ALTA"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Gold
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(382, 316)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 20)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "[4] REPARAR"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Yellow
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(257, 316)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 20)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "[3] DESMONTAR"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnObtenerListaDeComponentes
        '
        Me.btnObtenerListaDeComponentes.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerListaDeComponentes.Location = New System.Drawing.Point(669, 8)
        Me.btnObtenerListaDeComponentes.Name = "btnObtenerListaDeComponentes"
        Me.btnObtenerListaDeComponentes.Size = New System.Drawing.Size(224, 37)
        Me.btnObtenerListaDeComponentes.TabIndex = 40
        Me.btnObtenerListaDeComponentes.Text = "ACTUALIZAR COMPONENTES"
        Me.btnObtenerListaDeComponentes.UseVisualStyleBackColor = True
        '
        'btnRepararComponente
        '
        Me.btnRepararComponente.Enabled = False
        Me.btnRepararComponente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepararComponente.Location = New System.Drawing.Point(333, 273)
        Me.btnRepararComponente.Name = "btnRepararComponente"
        Me.btnRepararComponente.Size = New System.Drawing.Size(285, 35)
        Me.btnRepararComponente.TabIndex = 44
        Me.btnRepararComponente.Text = "REPARAR UN COMPONENTE"
        Me.btnRepararComponente.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 255)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(177, 15)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "COMPONENTE ASOCIADOS A LA OT:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(267, 15)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "COMPONENTES MONTADOS ACTUALMENTE EN EL BUS:"
        '
        'btnMontarComponente
        '
        Me.btnMontarComponente.Enabled = False
        Me.btnMontarComponente.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMontarComponente.Location = New System.Drawing.Point(7, 273)
        Me.btnMontarComponente.Name = "btnMontarComponente"
        Me.btnMontarComponente.Size = New System.Drawing.Size(279, 35)
        Me.btnMontarComponente.TabIndex = 43
        Me.btnMontarComponente.Text = "MONTAR UN COMPONENTE"
        Me.btnMontarComponente.UseVisualStyleBackColor = True
        '
        'dgvComponentes2
        '
        Me.dgvComponentes2.AllowUserToAddRows = False
        Me.dgvComponentes2.AllowUserToDeleteRows = False
        Me.dgvComponentes2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvComponentes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponentes2.Location = New System.Drawing.Point(7, 339)
        Me.dgvComponentes2.Name = "dgvComponentes2"
        Me.dgvComponentes2.ReadOnly = True
        Me.dgvComponentes2.RowHeadersVisible = False
        Me.dgvComponentes2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvComponentes2.Size = New System.Drawing.Size(886, 189)
        Me.dgvComponentes2.TabIndex = 39
        '
        'dgvComponentes1
        '
        Me.dgvComponentes1.AllowUserToAddRows = False
        Me.dgvComponentes1.AllowUserToDeleteRows = False
        Me.dgvComponentes1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvComponentes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponentes1.Location = New System.Drawing.Point(7, 51)
        Me.dgvComponentes1.Name = "dgvComponentes1"
        Me.dgvComponentes1.ReadOnly = True
        Me.dgvComponentes1.RowHeadersVisible = False
        Me.dgvComponentes1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvComponentes1.Size = New System.Drawing.Size(886, 185)
        Me.dgvComponentes1.TabIndex = 38
        '
        'tpSeguimientos
        '
        Me.tpSeguimientos.Controls.Add(Me.Label16)
        Me.tpSeguimientos.Controls.Add(Me.Label37)
        Me.tpSeguimientos.Controls.Add(Me.Label36)
        Me.tpSeguimientos.Controls.Add(Me.dgvSeguimientos1)
        Me.tpSeguimientos.Controls.Add(Me.Label35)
        Me.tpSeguimientos.Controls.Add(Me.Label34)
        Me.tpSeguimientos.Controls.Add(Me.Label32)
        Me.tpSeguimientos.Controls.Add(Me.btnRecuperarSeguimientos)
        Me.tpSeguimientos.Controls.Add(Me.btnNuevoSeguimiento)
        Me.tpSeguimientos.Controls.Add(Me.dgvSeguimientos2)
        Me.tpSeguimientos.Location = New System.Drawing.Point(4, 25)
        Me.tpSeguimientos.Name = "tpSeguimientos"
        Me.tpSeguimientos.Size = New System.Drawing.Size(901, 536)
        Me.tpSeguimientos.TabIndex = 2
        Me.tpSeguimientos.Text = "SEGUIMIENTOS"
        Me.tpSeguimientos.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(412, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "[3] CORREGIR"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(10, 268)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(137, 16)
        Me.Label37.TabIndex = 49
        Me.Label37.Text = "SEGUIMIENTOS DE LA OT:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 21)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(177, 16)
        Me.Label36.TabIndex = 48
        Me.Label36.Text = "COMPONENTES EN SEGUIMIENTO:"
        '
        'dgvSeguimientos1
        '
        Me.dgvSeguimientos1.AllowUserToAddRows = False
        Me.dgvSeguimientos1.AllowUserToDeleteRows = False
        Me.dgvSeguimientos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSeguimientos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguimientos1.Location = New System.Drawing.Point(8, 45)
        Me.dgvSeguimientos1.Name = "dgvSeguimientos1"
        Me.dgvSeguimientos1.ReadOnly = True
        Me.dgvSeguimientos1.RowHeadersVisible = False
        Me.dgvSeguimientos1.Size = New System.Drawing.Size(887, 205)
        Me.dgvSeguimientos1.TabIndex = 47
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.LightPink
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(277, 289)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 20)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "[3] GRAVE"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Gold
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(143, 289)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(120, 20)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "[2] LEVE"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.LightGreen
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 289)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 20)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "[1] OPTIMO"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRecuperarSeguimientos
        '
        Me.btnRecuperarSeguimientos.BackColor = System.Drawing.Color.Transparent
        Me.btnRecuperarSeguimientos.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarSeguimientos.Location = New System.Drawing.Point(693, 5)
        Me.btnRecuperarSeguimientos.Name = "btnRecuperarSeguimientos"
        Me.btnRecuperarSeguimientos.Size = New System.Drawing.Size(200, 34)
        Me.btnRecuperarSeguimientos.TabIndex = 42
        Me.btnRecuperarSeguimientos.Text = "RECUPERAR SEGUIMIENTOS"
        Me.btnRecuperarSeguimientos.UseVisualStyleBackColor = False
        '
        'btnNuevoSeguimiento
        '
        Me.btnNuevoSeguimiento.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoSeguimiento.Enabled = False
        Me.btnNuevoSeguimiento.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoSeguimiento.Location = New System.Drawing.Point(694, 273)
        Me.btnNuevoSeguimiento.Name = "btnNuevoSeguimiento"
        Me.btnNuevoSeguimiento.Size = New System.Drawing.Size(200, 34)
        Me.btnNuevoSeguimiento.TabIndex = 43
        Me.btnNuevoSeguimiento.Text = "NUEVO SEGUIMIENTO"
        Me.btnNuevoSeguimiento.UseVisualStyleBackColor = False
        '
        'dgvSeguimientos2
        '
        Me.dgvSeguimientos2.AllowUserToAddRows = False
        Me.dgvSeguimientos2.AllowUserToDeleteRows = False
        Me.dgvSeguimientos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSeguimientos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeguimientos2.Location = New System.Drawing.Point(7, 313)
        Me.dgvSeguimientos2.Name = "dgvSeguimientos2"
        Me.dgvSeguimientos2.ReadOnly = True
        Me.dgvSeguimientos2.RowHeadersVisible = False
        Me.dgvSeguimientos2.Size = New System.Drawing.Size(887, 215)
        Me.dgvSeguimientos2.TabIndex = 41
        '
        'frmPatioActualizarOt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(915, 571)
        Me.Controls.Add(Me.tcOt)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatioActualizarOt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CERRAR TAREO"
        Me.gbHeader.ResumeLayout(False)
        Me.gbHeader.PerformLayout()
        Me.gbBody.ResumeLayout(False)
        Me.gbBody.PerformLayout()
        Me.tcOt.ResumeLayout(False)
        Me.tpOt.ResumeLayout(False)
        Me.tpComponentes.ResumeLayout(False)
        Me.tpComponentes.PerformLayout()
        CType(Me.dgvComponentes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComponentes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSeguimientos.ResumeLayout(False)
        Me.tpSeguimientos.PerformLayout()
        CType(Me.dgvSeguimientos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSeguimientos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbHeader As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbBody As GroupBox
    Friend WithEvents rtbTrabajos As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rtbObservacionesOld As RichTextBox
    Friend WithEvents rtbTrabajosOld As RichTextBox
    Friend WithEvents lblActividad As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblActivo As Label
    Friend WithEvents lblOt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTecnico As Label
    Friend WithEvents lblIngreso As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tcOt As TabControl
    Friend WithEvents tpOt As TabPage
    Friend WithEvents tpComponentes As TabPage
    Friend WithEvents tpSeguimientos As TabPage
    Friend WithEvents btnBajaComponente As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnObtenerListaDeComponentes As Button
    Friend WithEvents btnRepararComponente As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnMontarComponente As Button
    Friend WithEvents dgvComponentes2 As DataGridView
    Friend WithEvents dgvComponentes1 As DataGridView
    Friend WithEvents lblKm As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents dgvSeguimientos1 As DataGridView
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents btnRecuperarSeguimientos As Button
    Friend WithEvents btnNuevoSeguimiento As Button
    Friend WithEvents dgvSeguimientos2 As DataGridView
    Friend WithEvents Label16 As Label
End Class

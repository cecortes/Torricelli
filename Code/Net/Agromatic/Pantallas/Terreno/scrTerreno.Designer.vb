<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrTerreno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTerreno))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlWrp = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.BunifuGauge1 = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pnlGraf = New System.Windows.Forms.Panel()
        Me.chrtTotal = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTop3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pnlHuman = New System.Windows.Forms.Panel()
        Me.GauHuman = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlTop2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlTempSoil = New System.Windows.Forms.Panel()
        Me.GauTempSoil = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.pnlPa = New System.Windows.Forms.Panel()
        Me.GauPa = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pnlHr = New System.Windows.Forms.Panel()
        Me.GauHr = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pnlTemp = New System.Windows.Forms.Panel()
        Me.GauTemp = New Bunifu.Framework.UI.BunifuGauge()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.lblIni = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlCultivoInfo1 = New System.Windows.Forms.Panel()
        Me.rnkCultivo = New Bunifu.Framework.UI.BunifuRating()
        Me.lblCultivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlSepVer1 = New System.Windows.Forms.Panel()
        Me.pnlImg = New System.Windows.Forms.Panel()
        Me.pbImg1 = New System.Windows.Forms.PictureBox()
        Me.pnlMenuBar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTablas = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGraf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnDel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWrp.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        Me.pnlGraf.SuspendLayout()
        CType(Me.chrtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop3.SuspendLayout()
        Me.pnlHuman.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlTempSoil.SuspendLayout()
        Me.pnlPa.SuspendLayout()
        Me.pnlHr.SuspendLayout()
        Me.pnlTemp.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlCultivoInfo1.SuspendLayout()
        Me.pnlImg.SuspendLayout()
        CType(Me.pbImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlWrp
        '
        Me.pnlWrp.Controls.Add(Me.Panel6)
        Me.pnlWrp.Controls.Add(Me.pnlTop2)
        Me.pnlWrp.Controls.Add(Me.Panel5)
        Me.pnlWrp.Controls.Add(Me.pnlTop)
        Me.pnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrp.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrp.Name = "pnlWrp"
        Me.pnlWrp.Size = New System.Drawing.Size(1024, 660)
        Me.pnlWrp.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.pnlProgress)
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Controls.Add(Me.pnlGraf)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.pnlHuman)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 431)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1024, 170)
        Me.Panel6.TabIndex = 3
        '
        'pnlProgress
        '
        Me.pnlProgress.Controls.Add(Me.BunifuGauge1)
        Me.pnlProgress.Controls.Add(Me.Label9)
        Me.pnlProgress.Controls.Add(Me.BunifuSeparator8)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlProgress.Location = New System.Drawing.Point(222, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(200, 170)
        Me.pnlProgress.TabIndex = 8
        '
        'BunifuGauge1
        '
        Me.BunifuGauge1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGauge1.BackgroundImage = CType(resources.GetObject("BunifuGauge1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGauge1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGauge1.ForeColor = System.Drawing.Color.White
        Me.BunifuGauge1.Location = New System.Drawing.Point(4, 37)
        Me.BunifuGauge1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuGauge1.Name = "BunifuGauge1"
        Me.BunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray
        Me.BunifuGauge1.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BunifuGauge1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuGauge1.Size = New System.Drawing.Size(196, 129)
        Me.BunifuGauge1.Suffix = " %"
        Me.BunifuGauge1.TabIndex = 2
        Me.BunifuGauge1.Thickness = 30
        Me.BunifuGauge1.Value = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Progreso:"
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 1
        Me.BunifuSeparator8.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator8.TabIndex = 1
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = False
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(422, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(15, 170)
        Me.Panel10.TabIndex = 7
        '
        'pnlGraf
        '
        Me.pnlGraf.Controls.Add(Me.chrtTotal)
        Me.pnlGraf.Controls.Add(Me.pnlTop3)
        Me.pnlGraf.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlGraf.Location = New System.Drawing.Point(437, 0)
        Me.pnlGraf.Name = "pnlGraf"
        Me.pnlGraf.Size = New System.Drawing.Size(587, 170)
        Me.pnlGraf.TabIndex = 6
        '
        'chrtTotal
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtTotal.ChartAreas.Add(ChartArea2)
        Me.chrtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chrtTotal.Legends.Add(Legend2)
        Me.chrtTotal.Location = New System.Drawing.Point(0, 28)
        Me.chrtTotal.Name = "chrtTotal"
        Series5.ChartArea = "ChartArea1"
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.Legend = "Legend1"
        Series5.Name = "Riego"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Combustible"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Fertilizante"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Pesticida"
        Me.chrtTotal.Series.Add(Series5)
        Me.chrtTotal.Series.Add(Series6)
        Me.chrtTotal.Series.Add(Series7)
        Me.chrtTotal.Series.Add(Series8)
        Me.chrtTotal.Size = New System.Drawing.Size(587, 142)
        Me.chrtTotal.TabIndex = 1
        Me.chrtTotal.Text = "Chart1"
        '
        'pnlTop3
        '
        Me.pnlTop3.Controls.Add(Me.Label8)
        Me.pnlTop3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop3.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop3.Name = "pnlTop3"
        Me.pnlTop3.Size = New System.Drawing.Size(587, 28)
        Me.pnlTop3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(250, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Gráficas:"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(200, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(15, 170)
        Me.Panel8.TabIndex = 5
        '
        'pnlHuman
        '
        Me.pnlHuman.Controls.Add(Me.GauHuman)
        Me.pnlHuman.Controls.Add(Me.Label7)
        Me.pnlHuman.Controls.Add(Me.BunifuSeparator7)
        Me.pnlHuman.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHuman.Location = New System.Drawing.Point(0, 0)
        Me.pnlHuman.Name = "pnlHuman"
        Me.pnlHuman.Size = New System.Drawing.Size(200, 170)
        Me.pnlHuman.TabIndex = 4
        '
        'GauHuman
        '
        Me.GauHuman.BackColor = System.Drawing.Color.Transparent
        Me.GauHuman.BackgroundImage = CType(resources.GetObject("GauHuman.BackgroundImage"), System.Drawing.Image)
        Me.GauHuman.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GauHuman.ForeColor = System.Drawing.Color.White
        Me.GauHuman.Location = New System.Drawing.Point(4, 37)
        Me.GauHuman.Margin = New System.Windows.Forms.Padding(4)
        Me.GauHuman.Name = "GauHuman"
        Me.GauHuman.ProgressBgColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GauHuman.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GauHuman.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GauHuman.Size = New System.Drawing.Size(196, 129)
        Me.GauHuman.Suffix = " %"
        Me.GauHuman.TabIndex = 2
        Me.GauHuman.Thickness = 30
        Me.GauHuman.Value = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Recursos Humanos:"
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 1
        Me.BunifuSeparator7.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator7.TabIndex = 1
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = False
        '
        'pnlTop2
        '
        Me.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop2.Location = New System.Drawing.Point(0, 320)
        Me.pnlTop2.Name = "pnlTop2"
        Me.pnlTop2.Size = New System.Drawing.Size(1024, 111)
        Me.pnlTop2.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.pnlTempSoil)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.pnlPa)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.pnlHr)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.pnlTemp)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 150)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1024, 170)
        Me.Panel5.TabIndex = 1
        '
        'pnlTempSoil
        '
        Me.pnlTempSoil.Controls.Add(Me.GauTempSoil)
        Me.pnlTempSoil.Controls.Add(Me.Label6)
        Me.pnlTempSoil.Controls.Add(Me.BunifuSeparator6)
        Me.pnlTempSoil.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlTempSoil.Location = New System.Drawing.Point(789, 0)
        Me.pnlTempSoil.Name = "pnlTempSoil"
        Me.pnlTempSoil.Size = New System.Drawing.Size(200, 170)
        Me.pnlTempSoil.TabIndex = 9
        '
        'GauTempSoil
        '
        Me.GauTempSoil.BackColor = System.Drawing.Color.Transparent
        Me.GauTempSoil.BackgroundImage = CType(resources.GetObject("GauTempSoil.BackgroundImage"), System.Drawing.Image)
        Me.GauTempSoil.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GauTempSoil.ForeColor = System.Drawing.Color.White
        Me.GauTempSoil.Location = New System.Drawing.Point(4, 37)
        Me.GauTempSoil.Margin = New System.Windows.Forms.Padding(4)
        Me.GauTempSoil.Name = "GauTempSoil"
        Me.GauTempSoil.ProgressBgColor = System.Drawing.Color.DimGray
        Me.GauTempSoil.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GauTempSoil.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GauTempSoil.Size = New System.Drawing.Size(196, 129)
        Me.GauTempSoil.Suffix = " °C"
        Me.GauTempSoil.TabIndex = 2
        Me.GauTempSoil.Thickness = 30
        Me.GauTempSoil.Value = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Temperatura Suelo:"
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator6.TabIndex = 1
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(989, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(35, 170)
        Me.Panel11.TabIndex = 8
        '
        'pnlPa
        '
        Me.pnlPa.Controls.Add(Me.GauPa)
        Me.pnlPa.Controls.Add(Me.Label5)
        Me.pnlPa.Controls.Add(Me.BunifuSeparator5)
        Me.pnlPa.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlPa.Location = New System.Drawing.Point(470, 0)
        Me.pnlPa.Name = "pnlPa"
        Me.pnlPa.Size = New System.Drawing.Size(200, 170)
        Me.pnlPa.TabIndex = 7
        '
        'GauPa
        '
        Me.GauPa.BackColor = System.Drawing.Color.Transparent
        Me.GauPa.BackgroundImage = CType(resources.GetObject("GauPa.BackgroundImage"), System.Drawing.Image)
        Me.GauPa.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GauPa.ForeColor = System.Drawing.Color.White
        Me.GauPa.Location = New System.Drawing.Point(4, 37)
        Me.GauPa.Margin = New System.Windows.Forms.Padding(4)
        Me.GauPa.Name = "GauPa"
        Me.GauPa.ProgressBgColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.GauPa.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GauPa.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.GauPa.Size = New System.Drawing.Size(196, 129)
        Me.GauPa.Suffix = " %"
        Me.GauPa.TabIndex = 2
        Me.GauPa.Thickness = 30
        Me.GauPa.Value = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Presión Atm:"
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator5.TabIndex = 1
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(435, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(35, 170)
        Me.Panel9.TabIndex = 6
        '
        'pnlHr
        '
        Me.pnlHr.Controls.Add(Me.GauHr)
        Me.pnlHr.Controls.Add(Me.Label2)
        Me.pnlHr.Controls.Add(Me.BunifuSeparator4)
        Me.pnlHr.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlHr.Location = New System.Drawing.Point(235, 0)
        Me.pnlHr.Name = "pnlHr"
        Me.pnlHr.Size = New System.Drawing.Size(200, 170)
        Me.pnlHr.TabIndex = 5
        '
        'GauHr
        '
        Me.GauHr.BackColor = System.Drawing.Color.Transparent
        Me.GauHr.BackgroundImage = CType(resources.GetObject("GauHr.BackgroundImage"), System.Drawing.Image)
        Me.GauHr.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GauHr.ForeColor = System.Drawing.Color.White
        Me.GauHr.Location = New System.Drawing.Point(4, 37)
        Me.GauHr.Margin = New System.Windows.Forms.Padding(4)
        Me.GauHr.Name = "GauHr"
        Me.GauHr.ProgressBgColor = System.Drawing.Color.Gray
        Me.GauHr.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GauHr.ProgressColor2 = System.Drawing.Color.DarkSeaGreen
        Me.GauHr.Size = New System.Drawing.Size(196, 129)
        Me.GauHr.Suffix = " %"
        Me.GauHr.TabIndex = 2
        Me.GauHr.Thickness = 30
        Me.GauHr.Value = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Humedad Relativa:"
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator4.TabIndex = 1
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(200, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(35, 170)
        Me.Panel7.TabIndex = 4
        '
        'pnlTemp
        '
        Me.pnlTemp.Controls.Add(Me.GauTemp)
        Me.pnlTemp.Controls.Add(Me.Label4)
        Me.pnlTemp.Controls.Add(Me.BunifuSeparator3)
        Me.pnlTemp.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTemp.Location = New System.Drawing.Point(0, 0)
        Me.pnlTemp.Name = "pnlTemp"
        Me.pnlTemp.Size = New System.Drawing.Size(200, 170)
        Me.pnlTemp.TabIndex = 3
        '
        'GauTemp
        '
        Me.GauTemp.BackColor = System.Drawing.Color.Transparent
        Me.GauTemp.BackgroundImage = CType(resources.GetObject("GauTemp.BackgroundImage"), System.Drawing.Image)
        Me.GauTemp.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GauTemp.ForeColor = System.Drawing.Color.White
        Me.GauTemp.Location = New System.Drawing.Point(4, 37)
        Me.GauTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.GauTemp.Name = "GauTemp"
        Me.GauTemp.ProgressBgColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GauTemp.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GauTemp.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GauTemp.Size = New System.Drawing.Size(196, 129)
        Me.GauTemp.Suffix = " °C"
        Me.GauTemp.TabIndex = 2
        Me.GauTemp.Thickness = 30
        Me.GauTemp.Value = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Temperatura:"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(0, 1)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(200, 43)
        Me.BunifuSeparator3.TabIndex = 1
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.Panel4)
        Me.pnlTop.Controls.Add(Me.Panel3)
        Me.pnlTop.Controls.Add(Me.Panel2)
        Me.pnlTop.Controls.Add(Me.pnlCultivoInfo1)
        Me.pnlTop.Controls.Add(Me.pnlSepVer1)
        Me.pnlTop.Controls.Add(Me.pnlImg)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1024, 150)
        Me.pnlTop.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblFin)
        Me.Panel4.Controls.Add(Me.lblIni)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BunifuSeparator2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(675, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 150)
        Me.Panel4.TabIndex = 4
        '
        'lblFin
        '
        Me.lblFin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblFin.AutoSize = True
        Me.lblFin.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.ForeColor = System.Drawing.Color.White
        Me.lblFin.Location = New System.Drawing.Point(55, 111)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(45, 29)
        Me.lblFin.TabIndex = 4
        Me.lblFin.Text = "NA"
        '
        'lblIni
        '
        Me.lblIni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIni.AutoSize = True
        Me.lblIni.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIni.ForeColor = System.Drawing.Color.White
        Me.lblIni.Location = New System.Drawing.Point(55, 58)
        Me.lblIni.Name = "lblIni"
        Me.lblIni.Size = New System.Drawing.Size(45, 29)
        Me.lblIni.TabIndex = 3
        Me.lblIni.Text = "NA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Periódo Ocupación:"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(-12, 19)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(488, 43)
        Me.BunifuSeparator2.TabIndex = 1
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(954, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(70, 150)
        Me.Panel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(549, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 150)
        Me.Panel2.TabIndex = 3
        '
        'pnlCultivoInfo1
        '
        Me.pnlCultivoInfo1.Controls.Add(Me.rnkCultivo)
        Me.pnlCultivoInfo1.Controls.Add(Me.lblCultivo)
        Me.pnlCultivoInfo1.Controls.Add(Me.Label1)
        Me.pnlCultivoInfo1.Controls.Add(Me.BunifuSeparator1)
        Me.pnlCultivoInfo1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCultivoInfo1.Location = New System.Drawing.Point(270, 0)
        Me.pnlCultivoInfo1.Name = "pnlCultivoInfo1"
        Me.pnlCultivoInfo1.Size = New System.Drawing.Size(279, 150)
        Me.pnlCultivoInfo1.TabIndex = 2
        '
        'rnkCultivo
        '
        Me.rnkCultivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rnkCultivo.BackColor = System.Drawing.Color.Transparent
        Me.rnkCultivo.Font = New System.Drawing.Font("Corbel", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rnkCultivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.rnkCultivo.Location = New System.Drawing.Point(36, 106)
        Me.rnkCultivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rnkCultivo.Name = "rnkCultivo"
        Me.rnkCultivo.Size = New System.Drawing.Size(208, 28)
        Me.rnkCultivo.TabIndex = 3
        Me.rnkCultivo.Value = 4
        '
        'lblCultivo
        '
        Me.lblCultivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCultivo.AutoSize = True
        Me.lblCultivo.Font = New System.Drawing.Font("Corbel", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCultivo.ForeColor = System.Drawing.Color.White
        Me.lblCultivo.Location = New System.Drawing.Point(120, 62)
        Me.lblCultivo.Name = "lblCultivo"
        Me.lblCultivo.Size = New System.Drawing.Size(45, 29)
        Me.lblCultivo.TabIndex = 2
        Me.lblCultivo.Text = "NA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Cultivo:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 19)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(279, 43)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'pnlSepVer1
        '
        Me.pnlSepVer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSepVer1.Location = New System.Drawing.Point(200, 0)
        Me.pnlSepVer1.Name = "pnlSepVer1"
        Me.pnlSepVer1.Size = New System.Drawing.Size(70, 150)
        Me.pnlSepVer1.TabIndex = 1
        '
        'pnlImg
        '
        Me.pnlImg.Controls.Add(Me.pbImg1)
        Me.pnlImg.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlImg.Location = New System.Drawing.Point(0, 0)
        Me.pnlImg.Name = "pnlImg"
        Me.pnlImg.Size = New System.Drawing.Size(200, 150)
        Me.pnlImg.TabIndex = 0
        '
        'pbImg1
        '
        Me.pbImg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImg1.Image = Global.Agromatic.My.Resources.Resources.Terreno
        Me.pbImg1.Location = New System.Drawing.Point(0, 0)
        Me.pbImg1.Name = "pbImg1"
        Me.pbImg1.Size = New System.Drawing.Size(200, 150)
        Me.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImg1.TabIndex = 0
        Me.pbImg1.TabStop = False
        '
        'pnlMenuBar
        '
        Me.pnlMenuBar.Controls.Add(Me.Panel1)
        Me.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMenuBar.Location = New System.Drawing.Point(0, 615)
        Me.pnlMenuBar.Name = "pnlMenuBar"
        Me.pnlMenuBar.Size = New System.Drawing.Size(1024, 45)
        Me.pnlMenuBar.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTablas)
        Me.Panel1.Controls.Add(Me.btnGraf)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnTablas
        '
        Me.btnTablas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnTablas.Image = Global.Agromatic.My.Resources.Resources.archivo
        Me.btnTablas.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnTablas.Location = New System.Drawing.Point(574, 5)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(35, 35)
        Me.btnTablas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnTablas.TabIndex = 4
        Me.btnTablas.TabStop = False
        Me.btnTablas.Zoom = 10
        '
        'btnGraf
        '
        Me.btnGraf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGraf.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGraf.Image = Global.Agromatic.My.Resources.Resources.tablero
        Me.btnGraf.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnGraf.Location = New System.Drawing.Point(630, 5)
        Me.btnGraf.Name = "btnGraf"
        Me.btnGraf.Size = New System.Drawing.Size(35, 35)
        Me.btnGraf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnGraf.TabIndex = 3
        Me.btnGraf.TabStop = False
        Me.btnGraf.Zoom = 10
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnDel.Image = Global.Agromatic.My.Resources.Resources.Cancel
        Me.btnDel.ImageActive = CType(resources.GetObject("btnDel.ImageActive"), System.Drawing.Image)
        Me.btnDel.Location = New System.Drawing.Point(420, 5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(35, 35)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDel.TabIndex = 2
        Me.btnDel.TabStop = False
        Me.btnDel.Zoom = 10
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnEdit.Image = Global.Agromatic.My.Resources.Resources.lapiz
        Me.btnEdit.ImageActive = CType(resources.GetObject("btnEdit.ImageActive"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(366, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 35)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.TabStop = False
        Me.btnEdit.Zoom = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnAdd.Image = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnAdd.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnAdd.Location = New System.Drawing.Point(312, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 35)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.TabStop = False
        Me.btnAdd.Zoom = 10
        '
        'scrTerreno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 660)
        Me.Controls.Add(Me.pnlMenuBar)
        Me.Controls.Add(Me.pnlWrp)
        Me.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "scrTerreno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scrTerreno"
        Me.pnlWrp.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlProgress.PerformLayout()
        Me.pnlGraf.ResumeLayout(False)
        CType(Me.chrtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop3.ResumeLayout(False)
        Me.pnlTop3.PerformLayout()
        Me.pnlHuman.ResumeLayout(False)
        Me.pnlHuman.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.pnlTempSoil.ResumeLayout(False)
        Me.pnlTempSoil.PerformLayout()
        Me.pnlPa.ResumeLayout(False)
        Me.pnlPa.PerformLayout()
        Me.pnlHr.ResumeLayout(False)
        Me.pnlHr.PerformLayout()
        Me.pnlTemp.ResumeLayout(False)
        Me.pnlTemp.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlCultivoInfo1.ResumeLayout(False)
        Me.pnlCultivoInfo1.PerformLayout()
        Me.pnlImg.ResumeLayout(False)
        CType(Me.pbImg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlWrp As Panel
    Friend WithEvents pnlMenuBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGraf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTablas As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlImg As Panel
    Friend WithEvents pbImg1 As PictureBox
    Friend WithEvents pnlCultivoInfo1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlSepVer1 As Panel
    Friend WithEvents rnkCultivo As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents lblCultivo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblFin As Label
    Friend WithEvents lblIni As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlTemp As Panel
    Friend WithEvents GauTemp As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlPa As Panel
    Friend WithEvents GauPa As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel9 As Panel
    Friend WithEvents pnlHr As Panel
    Friend WithEvents GauHr As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pnlTempSoil As Panel
    Friend WithEvents GauTempSoil As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlTop2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pnlHuman As Panel
    Friend WithEvents GauHuman As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlGraf As Panel
    Friend WithEvents pnlTop3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents chrtTotal As DataVisualization.Charting.Chart
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents BunifuGauge1 As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel10 As Panel
End Class

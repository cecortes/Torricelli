<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrMain))
        Me.DragTop = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlWrapp = New System.Windows.Forms.Panel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnRecur = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMetro = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCultivos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTerr = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlMenu.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DragTop
        '
        Me.DragTop.Fixed = True
        Me.DragTop.Horizontal = True
        Me.DragTop.TargetControl = Me.pnlTop
        Me.DragTop.Vertical = True
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnRecur)
        Me.pnlMenu.Controls.Add(Me.btnMetro)
        Me.pnlMenu.Controls.Add(Me.btnCultivos)
        Me.pnlMenu.Controls.Add(Me.btnTerr)
        Me.pnlMenu.Controls.Add(Me.BunifuSeparator2)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 40)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1024, 67)
        Me.pnlMenu.TabIndex = 1
        '
        'pnlWrapp
        '
        Me.pnlWrapp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrapp.Location = New System.Drawing.Point(0, 107)
        Me.pnlWrapp.Name = "pnlWrapp"
        Me.pnlWrapp.Size = New System.Drawing.Size(1024, 661)
        Me.pnlWrapp.TabIndex = 2
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(4, 49)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(1020, 25)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'btnRecur
        '
        Me.btnRecur.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnRecur.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecur.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnRecur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecur.BorderRadius = 7
        Me.btnRecur.ButtonText = "Recursos"
        Me.btnRecur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecur.DisabledColor = System.Drawing.Color.Gray
        Me.btnRecur.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRecur.Iconimage = Global.Agromatic.My.Resources.Resources.tractor__1_
        Me.btnRecur.Iconimage_right = Nothing
        Me.btnRecur.Iconimage_right_Selected = Nothing
        Me.btnRecur.Iconimage_Selected = Nothing
        Me.btnRecur.IconMarginLeft = 0
        Me.btnRecur.IconMarginRight = 0
        Me.btnRecur.IconRightVisible = True
        Me.btnRecur.IconRightZoom = 0R
        Me.btnRecur.IconVisible = True
        Me.btnRecur.IconZoom = 80.0R
        Me.btnRecur.IsTab = False
        Me.btnRecur.Location = New System.Drawing.Point(423, 12)
        Me.btnRecur.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.btnRecur.Name = "btnRecur"
        Me.btnRecur.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnRecur.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.btnRecur.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRecur.selected = False
        Me.btnRecur.Size = New System.Drawing.Size(145, 43)
        Me.btnRecur.TabIndex = 3
        Me.btnRecur.Text = "Recursos"
        Me.btnRecur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecur.Textcolor = System.Drawing.Color.White
        Me.btnRecur.TextFont = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnMetro
        '
        Me.btnMetro.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnMetro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMetro.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMetro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMetro.BorderRadius = 7
        Me.btnMetro.ButtonText = "Metrología"
        Me.btnMetro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMetro.DisabledColor = System.Drawing.Color.Gray
        Me.btnMetro.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMetro.Iconimage = Global.Agromatic.My.Resources.Resources.sensor__1_
        Me.btnMetro.Iconimage_right = Nothing
        Me.btnMetro.Iconimage_right_Selected = Nothing
        Me.btnMetro.Iconimage_Selected = Nothing
        Me.btnMetro.IconMarginLeft = 0
        Me.btnMetro.IconMarginRight = 0
        Me.btnMetro.IconRightVisible = True
        Me.btnMetro.IconRightZoom = 0R
        Me.btnMetro.IconVisible = True
        Me.btnMetro.IconZoom = 80.0R
        Me.btnMetro.IsTab = False
        Me.btnMetro.Location = New System.Drawing.Point(270, 12)
        Me.btnMetro.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.btnMetro.Name = "btnMetro"
        Me.btnMetro.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMetro.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.btnMetro.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMetro.selected = False
        Me.btnMetro.Size = New System.Drawing.Size(145, 43)
        Me.btnMetro.TabIndex = 2
        Me.btnMetro.Text = "Metrología"
        Me.btnMetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMetro.Textcolor = System.Drawing.Color.White
        Me.btnMetro.TextFont = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCultivos
        '
        Me.btnCultivos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCultivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCultivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnCultivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCultivos.BorderRadius = 7
        Me.btnCultivos.ButtonText = "Cultivos"
        Me.btnCultivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCultivos.DisabledColor = System.Drawing.Color.Gray
        Me.btnCultivos.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCultivos.Iconimage = Global.Agromatic.My.Resources.Resources.arbol
        Me.btnCultivos.Iconimage_right = Nothing
        Me.btnCultivos.Iconimage_right_Selected = Nothing
        Me.btnCultivos.Iconimage_Selected = Nothing
        Me.btnCultivos.IconMarginLeft = 0
        Me.btnCultivos.IconMarginRight = 0
        Me.btnCultivos.IconRightVisible = True
        Me.btnCultivos.IconRightZoom = 0R
        Me.btnCultivos.IconVisible = True
        Me.btnCultivos.IconZoom = 60.0R
        Me.btnCultivos.IsTab = False
        Me.btnCultivos.Location = New System.Drawing.Point(143, 12)
        Me.btnCultivos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCultivos.Name = "btnCultivos"
        Me.btnCultivos.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnCultivos.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.btnCultivos.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCultivos.selected = False
        Me.btnCultivos.Size = New System.Drawing.Size(119, 43)
        Me.btnCultivos.TabIndex = 1
        Me.btnCultivos.Text = "Cultivos"
        Me.btnCultivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCultivos.Textcolor = System.Drawing.Color.White
        Me.btnCultivos.TextFont = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTerr
        '
        Me.btnTerr.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTerr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTerr.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnTerr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerr.BorderRadius = 7
        Me.btnTerr.ButtonText = "Terreno"
        Me.btnTerr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerr.DisabledColor = System.Drawing.Color.Gray
        Me.btnTerr.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTerr.Iconimage = Global.Agromatic.My.Resources.Resources.campo__1_
        Me.btnTerr.Iconimage_right = Nothing
        Me.btnTerr.Iconimage_right_Selected = Nothing
        Me.btnTerr.Iconimage_Selected = Nothing
        Me.btnTerr.IconMarginLeft = 0
        Me.btnTerr.IconMarginRight = 0
        Me.btnTerr.IconRightVisible = True
        Me.btnTerr.IconRightZoom = 0R
        Me.btnTerr.IconVisible = True
        Me.btnTerr.IconZoom = 60.0R
        Me.btnTerr.IsTab = False
        Me.btnTerr.Location = New System.Drawing.Point(16, 12)
        Me.btnTerr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTerr.Name = "btnTerr"
        Me.btnTerr.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnTerr.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.btnTerr.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTerr.selected = False
        Me.btnTerr.Size = New System.Drawing.Size(119, 43)
        Me.btnTerr.TabIndex = 0
        Me.btnTerr.Text = "Terreno"
        Me.btnTerr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerr.Textcolor = System.Drawing.Color.White
        Me.btnTerr.TextFont = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.btnMax)
        Me.pnlTop.Controls.Add(Me.btnMin)
        Me.pnlTop.Controls.Add(Me.BunifuSeparator1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.pnlTop.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(1024, 40)
        Me.pnlTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AGROMATIC"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Agromatic.My.Resources.Resources.Cancel
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(976, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Image = Global.Agromatic.My.Resources.Resources.Max
        Me.btnMax.ImageActive = Nothing
        Me.btnMax.Location = New System.Drawing.Point(933, 4)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(32, 32)
        Me.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMax.TabIndex = 1
        Me.btnMax.TabStop = False
        Me.btnMax.Zoom = 10
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = Global.Agromatic.My.Resources.Resources.Min
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(881, 4)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(32, 32)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 0
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(170, 16)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(852, 20)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'scrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlWrapp)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Gentium Book Basic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "scrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agromatic Ver 0.1a"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMax As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents DragTop As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlWrapp As Panel
    Friend WithEvents btnTerr As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCultivos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnMetro As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRecur As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
End Class

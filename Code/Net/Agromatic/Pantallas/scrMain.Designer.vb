<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrMain))
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMax = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnClose
        '
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
        'scrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Gentium Book Basic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "scrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agromatic Ver 0.1a"
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
End Class

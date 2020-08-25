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
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.btnMin)
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
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Image = Global.Agromatic.My.Resources.Resources.Min
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(904, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(32, 32)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 0
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
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
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
End Class

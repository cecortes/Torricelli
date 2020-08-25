<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrRecursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrRecursos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlWrp = New System.Windows.Forms.Panel()
        Me.btnProd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGas = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGraf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRiego = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaq = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHuman = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRiego, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProd)
        Me.Panel1.Controls.Add(Me.btnGas)
        Me.Panel1.Controls.Add(Me.btnGraf)
        Me.Panel1.Controls.Add(Me.btnRiego)
        Me.Panel1.Controls.Add(Me.btnMaq)
        Me.Panel1.Controls.Add(Me.btnHuman)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 45)
        Me.Panel1.TabIndex = 5
        '
        'pnlWrp
        '
        Me.pnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrp.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrp.Name = "pnlWrp"
        Me.pnlWrp.Size = New System.Drawing.Size(1024, 660)
        Me.pnlWrp.TabIndex = 4
        '
        'btnProd
        '
        Me.btnProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnProd.Image = Global.Agromatic.My.Resources.Resources.fertilizante
        Me.btnProd.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnProd.Location = New System.Drawing.Point(517, 5)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(35, 35)
        Me.btnProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnProd.TabIndex = 5
        Me.btnProd.TabStop = False
        Me.btnProd.Zoom = 10
        '
        'btnGas
        '
        Me.btnGas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGas.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGas.Image = Global.Agromatic.My.Resources.Resources.combustible
        Me.btnGas.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnGas.Location = New System.Drawing.Point(574, 5)
        Me.btnGas.Name = "btnGas"
        Me.btnGas.Size = New System.Drawing.Size(35, 35)
        Me.btnGas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnGas.TabIndex = 4
        Me.btnGas.TabStop = False
        Me.btnGas.Zoom = 10
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
        'btnRiego
        '
        Me.btnRiego.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnRiego.Image = Global.Agromatic.My.Resources.Resources.agua
        Me.btnRiego.ImageActive = CType(resources.GetObject("btnRiego.ImageActive"), System.Drawing.Image)
        Me.btnRiego.Location = New System.Drawing.Point(420, 5)
        Me.btnRiego.Name = "btnRiego"
        Me.btnRiego.Size = New System.Drawing.Size(35, 35)
        Me.btnRiego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnRiego.TabIndex = 2
        Me.btnRiego.TabStop = False
        Me.btnRiego.Zoom = 10
        '
        'btnMaq
        '
        Me.btnMaq.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnMaq.Image = Global.Agromatic.My.Resources.Resources.tractor__2_
        Me.btnMaq.ImageActive = CType(resources.GetObject("btnMaq.ImageActive"), System.Drawing.Image)
        Me.btnMaq.Location = New System.Drawing.Point(366, 5)
        Me.btnMaq.Name = "btnMaq"
        Me.btnMaq.Size = New System.Drawing.Size(35, 35)
        Me.btnMaq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMaq.TabIndex = 1
        Me.btnMaq.TabStop = False
        Me.btnMaq.Zoom = 10
        '
        'btnHuman
        '
        Me.btnHuman.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnHuman.Image = Global.Agromatic.My.Resources.Resources.avatar
        Me.btnHuman.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnHuman.Location = New System.Drawing.Point(312, 5)
        Me.btnHuman.Name = "btnHuman"
        Me.btnHuman.Size = New System.Drawing.Size(35, 35)
        Me.btnHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnHuman.TabIndex = 0
        Me.btnHuman.TabStop = False
        Me.btnHuman.Zoom = 10
        '
        'ScrRecursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlWrp)
        Me.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ScrRecursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrRecursos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRiego, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGas As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGraf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRiego As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaq As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnHuman As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWrp As Panel
End Class

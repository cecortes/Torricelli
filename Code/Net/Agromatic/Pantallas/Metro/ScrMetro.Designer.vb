<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrMetro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrMetro))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTablas = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGraf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnDel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlWrp = New System.Windows.Forms.Panel()
        Me.btnDash = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDash)
        Me.Panel1.Controls.Add(Me.btnTablas)
        Me.Panel1.Controls.Add(Me.btnGraf)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 45)
        Me.Panel1.TabIndex = 3
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
        'pnlWrp
        '
        Me.pnlWrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrp.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrp.Name = "pnlWrp"
        Me.pnlWrp.Size = New System.Drawing.Size(1024, 660)
        Me.pnlWrp.TabIndex = 2
        '
        'btnDash
        '
        Me.btnDash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDash.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnDash.Image = Global.Agromatic.My.Resources.Resources.satelite
        Me.btnDash.ImageActive = Global.Agromatic.My.Resources.Resources.anadir
        Me.btnDash.Location = New System.Drawing.Point(517, 5)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(35, 35)
        Me.btnDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnDash.TabIndex = 5
        Me.btnDash.TabStop = False
        Me.btnDash.Zoom = 10
        '
        'ScrMetro
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
        Me.Name = "ScrMetro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScrMetro"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDash As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTablas As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnGraf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlWrp As Panel
End Class

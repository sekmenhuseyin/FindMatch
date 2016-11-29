<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbLevels = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiLevel1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 316)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(444, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(60, 17)
        Me.tslStatus.Text = "Click Start"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFile, Me.tsbLevels, Me.tsmiFile})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(444, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbFile
        '
        Me.tsbFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.ToolStripMenuItem1, Me.tsbExit})
        Me.tsbFile.Name = "tsbFile"
        Me.tsbFile.Size = New System.Drawing.Size(37, 25)
        Me.tsbFile.Text = "File"
        '
        'tsbNew
        '
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsbNew.Size = New System.Drawing.Size(122, 22)
        Me.tsbNew.Text = "New"
        '
        'tsbOpen
        '
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.tsbOpen.Size = New System.Drawing.Size(122, 22)
        Me.tsbOpen.Text = "Open"
        '
        'tsbSave
        '
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.tsbSave.Size = New System.Drawing.Size(122, 22)
        Me.tsbSave.Text = "Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
        '
        'tsbExit
        '
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.ShortcutKeyDisplayString = "Esc"
        Me.tsbExit.Size = New System.Drawing.Size(122, 22)
        Me.tsbExit.Text = "Exit"
        '
        'tsbLevels
        '
        Me.tsbLevels.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLevel1, Me.tsmiLevel2, Me.tsmiLevel3, Me.tsmiLevel4, Me.tsmiLevel5})
        Me.tsbLevels.Name = "tsbLevels"
        Me.tsbLevels.Size = New System.Drawing.Size(56, 22)
        Me.tsbLevels.Text = "Level 1"
        Me.tsbLevels.ToolTipText = "Levels"
        '
        'tsmiLevel1
        '
        Me.tsmiLevel1.Checked = True
        Me.tsmiLevel1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiLevel1.Name = "tsmiLevel1"
        Me.tsmiLevel1.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel1.Text = "Level 1"
        '
        'tsmiLevel2
        '
        Me.tsmiLevel2.Name = "tsmiLevel2"
        Me.tsmiLevel2.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel2.Text = "Level 2"
        '
        'tsmiLevel3
        '
        Me.tsmiLevel3.Name = "tsmiLevel3"
        Me.tsmiLevel3.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel3.Text = "Level 3"
        '
        'tsmiLevel4
        '
        Me.tsmiLevel4.Name = "tsmiLevel4"
        Me.tsmiLevel4.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel4.Text = "Level 4"
        '
        'tsmiLevel5
        '
        Me.tsmiLevel5.Name = "tsmiLevel5"
        Me.tsmiLevel5.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel5.Text = "Level 5"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.tsmiOpen})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(44, 25)
        Me.tsmiFile.Text = "Help"
        '
        'tsmiNew
        '
        Me.tsmiNew.Name = "tsmiNew"
        Me.tsmiNew.Size = New System.Drawing.Size(170, 22)
        Me.tsmiNew.Text = "How to"
        '
        'tsmiOpen
        '
        Me.tsmiOpen.Name = "tsmiOpen"
        Me.tsmiOpen.Size = New System.Drawing.Size(170, 22)
        Me.tsmiOpen.Text = "About Find Match"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Background.jpg")
        Me.imageList1.Images.SetKeyName(1, "black.png")
        Me.imageList1.Images.SetKeyName(2, "blue.png")
        Me.imageList1.Images.SetKeyName(3, "brown.png")
        Me.imageList1.Images.SetKeyName(4, "green.png")
        Me.imageList1.Images.SetKeyName(5, "indigo.png")
        Me.imageList1.Images.SetKeyName(6, "lime.png")
        Me.imageList1.Images.SetKeyName(7, "orange.png")
        Me.imageList1.Images.SetKeyName(8, "pink.png")
        Me.imageList1.Images.SetKeyName(9, "purple.png")
        Me.imageList1.Images.SetKeyName(10, "red.png")
        Me.imageList1.Images.SetKeyName(11, "turquoise.png")
        Me.imageList1.Images.SetKeyName(12, "white.png")
        Me.imageList1.Images.SetKeyName(13, "yellow.png")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 338)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Find Match"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsbLevels As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiLevel1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tsbFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOpen As System.Windows.Forms.ToolStripMenuItem

End Class

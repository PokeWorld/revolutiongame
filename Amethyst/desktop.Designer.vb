<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelBar = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSiteAnaylytics = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSiteController = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDodgeTheAd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmShutdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDayAdvance = New System.Windows.Forms.Button()
        Me.lblDayCount = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.tmData = New System.Windows.Forms.Timer(Me.components)
        Me.panelBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBar
        '
        Me.panelBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.panelBar.Location = New System.Drawing.Point(0, 576)
        Me.panelBar.Name = "panelBar"
        Me.panelBar.Size = New System.Drawing.Size(800, 24)
        Me.panelBar.TabIndex = 0
        Me.panelBar.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNotes, Me.tsmSiteAnaylytics, Me.tsmSiteController, Me.tsmDodgeTheAd, Me.ToolStripSeparator1, Me.tsmShutdown})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'tsmNotes
        '
        Me.tsmNotes.Name = "tsmNotes"
        Me.tsmNotes.Size = New System.Drawing.Size(161, 22)
        Me.tsmNotes.Text = "Notes"
        '
        'tsmSiteAnaylytics
        '
        Me.tsmSiteAnaylytics.Name = "tsmSiteAnaylytics"
        Me.tsmSiteAnaylytics.Size = New System.Drawing.Size(161, 22)
        Me.tsmSiteAnaylytics.Text = "Analytics"
        '
        'tsmSiteController
        '
        Me.tsmSiteController.Name = "tsmSiteController"
        Me.tsmSiteController.Size = New System.Drawing.Size(161, 22)
        Me.tsmSiteController.Text = "Control Panel"
        '
        'tsmDodgeTheAd
        '
        Me.tsmDodgeTheAd.Name = "tsmDodgeTheAd"
        Me.tsmDodgeTheAd.Size = New System.Drawing.Size(161, 22)
        Me.tsmDodgeTheAd.Text = "Dodge The Ad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'tsmShutdown
        '
        Me.tsmShutdown.Name = "tsmShutdown"
        Me.tsmShutdown.Size = New System.Drawing.Size(161, 22)
        Me.tsmShutdown.Text = "Shutdown"
        '
        'btnDayAdvance
        '
        Me.btnDayAdvance.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.btnDayAdvance.Location = New System.Drawing.Point(80, 8)
        Me.btnDayAdvance.Name = "btnDayAdvance"
        Me.btnDayAdvance.Size = New System.Drawing.Size(100, 23)
        Me.btnDayAdvance.TabIndex = 1
        Me.btnDayAdvance.Text = "Day Advance"
        Me.btnDayAdvance.UseVisualStyleBackColor = True
        '
        'lblDayCount
        '
        Me.lblDayCount.AutoSize = True
        Me.lblDayCount.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.lblDayCount.Location = New System.Drawing.Point(13, 13)
        Me.lblDayCount.Name = "lblDayCount"
        Me.lblDayCount.Size = New System.Drawing.Size(61, 11)
        Me.lblDayCount.TabIndex = 2
        Me.lblDayCount.Text = "Day Null"
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.btnRestart.Location = New System.Drawing.Point(186, 8)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(93, 23)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Reset Game"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.lblMoney.Location = New System.Drawing.Point(13, 37)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(82, 11)
        Me.lblMoney.TabIndex = 4
        Me.lblMoney.Text = "Money: $NaN"
        '
        'tmData
        '
        Me.tmData.Enabled = True
        '
        'desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblDayCount)
        Me.Controls.Add(Me.btnDayAdvance)
        Me.Controls.Add(Me.panelBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.panelBar
        Me.Name = "desktop"
        Me.Text = "desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelBar.ResumeLayout(False)
        Me.panelBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelBar As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmNotes As ToolStripMenuItem
    Friend WithEvents tsmSiteController As ToolStripMenuItem
    Friend WithEvents tsmShutdown As ToolStripMenuItem
    Friend WithEvents tsmSiteAnaylytics As ToolStripMenuItem
    Friend WithEvents btnDayAdvance As Button
    Friend WithEvents lblDayCount As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblMoney As Label
    Friend WithEvents tsmDodgeTheAd As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tmData As Timer
End Class

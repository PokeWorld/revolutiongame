<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class desktop
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
        Me.panelBar = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DummyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiteAnalyticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiteControllerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodgeTheAdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAmethystToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDayAdvance = New System.Windows.Forms.Button()
        Me.lblDayCount = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DummyToolStripMenuItem, Me.SiteAnalyticsToolStripMenuItem, Me.SiteControllerToolStripMenuItem, Me.DodgeTheAdToolStripMenuItem, Me.ToolStripSeparator1, Me.ShutdownToolStripMenuItem, Me.AboutAmethystToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'DummyToolStripMenuItem
        '
        Me.DummyToolStripMenuItem.Name = "DummyToolStripMenuItem"
        Me.DummyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DummyToolStripMenuItem.Text = "Dummy"
        '
        'SiteAnalyticsToolStripMenuItem
        '
        Me.SiteAnalyticsToolStripMenuItem.Name = "SiteAnalyticsToolStripMenuItem"
        Me.SiteAnalyticsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SiteAnalyticsToolStripMenuItem.Text = "Site Analytics"
        '
        'SiteControllerToolStripMenuItem
        '
        Me.SiteControllerToolStripMenuItem.Name = "SiteControllerToolStripMenuItem"
        Me.SiteControllerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SiteControllerToolStripMenuItem.Text = "Site Controller"
        '
        'DodgeTheAdToolStripMenuItem
        '
        Me.DodgeTheAdToolStripMenuItem.Name = "DodgeTheAdToolStripMenuItem"
        Me.DodgeTheAdToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DodgeTheAdToolStripMenuItem.Text = "Dodge The Ad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'AboutAmethystToolStripMenuItem
        '
        Me.AboutAmethystToolStripMenuItem.Name = "AboutAmethystToolStripMenuItem"
        Me.AboutAmethystToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutAmethystToolStripMenuItem.Text = "About Amethyst"
        '
        'btnDayAdvance
        '
        Me.btnDayAdvance.Location = New System.Drawing.Point(66, 8)
        Me.btnDayAdvance.Name = "btnDayAdvance"
        Me.btnDayAdvance.Size = New System.Drawing.Size(82, 23)
        Me.btnDayAdvance.TabIndex = 1
        Me.btnDayAdvance.Text = "Day Advance"
        Me.btnDayAdvance.UseVisualStyleBackColor = True
        '
        'lblDayCount
        '
        Me.lblDayCount.AutoSize = True
        Me.lblDayCount.Location = New System.Drawing.Point(13, 13)
        Me.lblDayCount.Name = "lblDayCount"
        Me.lblDayCount.Size = New System.Drawing.Size(47, 13)
        Me.lblDayCount.TabIndex = 2
        Me.lblDayCount.Text = "Day Null"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(154, 8)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(82, 23)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Reset Game"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(13, 37)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(73, 13)
        Me.lblMoney.TabIndex = 4
        Me.lblMoney.Text = "Money: $NaN"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
    Friend WithEvents DummyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiteControllerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiteAnalyticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDayAdvance As Button
    Friend WithEvents lblDayCount As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblMoney As Label
    Friend WithEvents DodgeTheAdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AboutAmethystToolStripMenuItem As ToolStripMenuItem
End Class

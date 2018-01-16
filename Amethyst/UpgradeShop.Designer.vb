<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpgradeShop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbUpgrades = New System.Windows.Forms.ListBox()
        Me.lblUpgradeTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPointcount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbUpgrades
        '
        Me.lbUpgrades.FormattingEnabled = True
        Me.lbUpgrades.Location = New System.Drawing.Point(17, 70)
        Me.lbUpgrades.Name = "lbUpgrades"
        Me.lbUpgrades.Size = New System.Drawing.Size(363, 446)
        Me.lbUpgrades.TabIndex = 0
        '
        'lblUpgradeTitle
        '
        Me.lblUpgradeTitle.AutoSize = True
        Me.lblUpgradeTitle.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.lblUpgradeTitle.Location = New System.Drawing.Point(17, 24)
        Me.lblUpgradeTitle.Name = "lblUpgradeTitle"
        Me.lblUpgradeTitle.Size = New System.Drawing.Size(204, 27)
        Me.lblUpgradeTitle.TabIndex = 1
        Me.lblUpgradeTitle.Text = "Upgrade Shop"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(386, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 583)
        Me.Panel1.TabIndex = 2
        '
        'lblPointcount
        '
        Me.lblPointcount.AutoSize = True
        Me.lblPointcount.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.lblPointcount.Location = New System.Drawing.Point(17, 539)
        Me.lblPointcount.Name = "lblPointcount"
        Me.lblPointcount.Size = New System.Drawing.Size(124, 27)
        Me.lblPointcount.TabIndex = 3
        Me.lblPointcount.Text = "Cash: $"
        '
        'UpgradeShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblPointcount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblUpgradeTitle)
        Me.Controls.Add(Me.lbUpgrades)
        Me.Name = "UpgradeShop"
        Me.Size = New System.Drawing.Size(843, 589)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUpgrades As ListBox
    Friend WithEvents lblUpgradeTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPointcount As Label
End Class

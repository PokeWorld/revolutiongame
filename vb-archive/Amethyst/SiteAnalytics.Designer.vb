<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SiteAnalytics
    Inherits System.Windows.Forms.UserControl

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
        Me.lblSiteName = New System.Windows.Forms.Label()
        Me.tmData = New System.Windows.Forms.Timer(Me.components)
        Me.lblAdIntensity = New System.Windows.Forms.Label()
        Me.lblUserCount = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSiteName
        '
        Me.lblSiteName.AutoSize = True
        Me.lblSiteName.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblSiteName.Location = New System.Drawing.Point(14, 109)
        Me.lblSiteName.Name = "lblSiteName"
        Me.lblSiteName.Size = New System.Drawing.Size(151, 14)
        Me.lblSiteName.TabIndex = 0
        Me.lblSiteName.Text = "Network Name: null"
        '
        'tmData
        '
        Me.tmData.Enabled = True
        Me.tmData.Interval = 10
        '
        'lblAdIntensity
        '
        Me.lblAdIntensity.AutoSize = True
        Me.lblAdIntensity.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblAdIntensity.Location = New System.Drawing.Point(14, 95)
        Me.lblAdIntensity.Name = "lblAdIntensity"
        Me.lblAdIntensity.Size = New System.Drawing.Size(159, 14)
        Me.lblAdIntensity.TabIndex = 1
        Me.lblAdIntensity.Text = "Ad Intensity = null"
        '
        'lblUserCount
        '
        Me.lblUserCount.AutoSize = True
        Me.lblUserCount.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblUserCount.Location = New System.Drawing.Point(14, 81)
        Me.lblUserCount.Name = "lblUserCount"
        Me.lblUserCount.Size = New System.Drawing.Size(95, 14)
        Me.lblUserCount.TabIndex = 2
        Me.lblUserCount.Text = "Users: null"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.lblTitle.Location = New System.Drawing.Point(12, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(156, 27)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Analytics"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Lucida Console", 12.5!)
        Me.lblDesc.Location = New System.Drawing.Point(14, 44)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(508, 17)
        Me.lblDesc.TabIndex = 4
        Me.lblDesc.Text = "Here, you will find the ""numbers"" of your network."
        '
        'SiteAnalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUserCount)
        Me.Controls.Add(Me.lblAdIntensity)
        Me.Controls.Add(Me.lblSiteName)
        Me.Name = "SiteAnalytics"
        Me.Size = New System.Drawing.Size(747, 491)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSiteName As Label
    Friend WithEvents tmData As Timer
    Friend WithEvents lblAdIntensity As Label
    Friend WithEvents lblUserCount As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDesc As Label
End Class

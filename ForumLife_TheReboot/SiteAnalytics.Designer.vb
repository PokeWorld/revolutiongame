<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiteAnalytics
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
        Me.lblSiteName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAdIntensity = New System.Windows.Forms.Label()
        Me.lblUserCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSiteName
        '
        Me.lblSiteName.AutoSize = True
        Me.lblSiteName.Location = New System.Drawing.Point(13, 13)
        Me.lblSiteName.Name = "lblSiteName"
        Me.lblSiteName.Size = New System.Drawing.Size(100, 13)
        Me.lblSiteName.TabIndex = 0
        Me.lblSiteName.Text = "Network Name: null"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'lblAdIntensity
        '
        Me.lblAdIntensity.AutoSize = True
        Me.lblAdIntensity.Location = New System.Drawing.Point(12, 42)
        Me.lblAdIntensity.Name = "lblAdIntensity"
        Me.lblAdIntensity.Size = New System.Drawing.Size(90, 13)
        Me.lblAdIntensity.TabIndex = 1
        Me.lblAdIntensity.Text = "Ad Intensity = null"
        '
        'lblUserCount
        '
        Me.lblUserCount.AutoSize = True
        Me.lblUserCount.Location = New System.Drawing.Point(12, 69)
        Me.lblUserCount.Name = "lblUserCount"
        Me.lblUserCount.Size = New System.Drawing.Size(56, 13)
        Me.lblUserCount.TabIndex = 2
        Me.lblUserCount.Text = "Users: null"
        '
        'SiteAnalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 491)
        Me.Controls.Add(Me.lblUserCount)
        Me.Controls.Add(Me.lblAdIntensity)
        Me.Controls.Add(Me.lblSiteName)
        Me.Name = "SiteAnalytics"
        Me.Text = "Site Analytics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSiteName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblAdIntensity As Label
    Friend WithEvents lblUserCount As Label
End Class

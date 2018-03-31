<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SiteControl
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
        Me.lblSiteName = New System.Windows.Forms.Label()
        Me.txtbxsetSiteName = New System.Windows.Forms.TextBox()
        Me.btnSetName = New System.Windows.Forms.Button()
        Me.trackbarAdIntense = New System.Windows.Forms.TrackBar()
        Me.lblAdIntense = New System.Windows.Forms.Label()
        Me.btnSetIntensity = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.trackbarAdIntense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSiteName
        '
        Me.lblSiteName.AutoSize = True
        Me.lblSiteName.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblSiteName.Location = New System.Drawing.Point(13, 87)
        Me.lblSiteName.Name = "lblSiteName"
        Me.lblSiteName.Size = New System.Drawing.Size(303, 14)
        Me.lblSiteName.TabIndex = 0
        Me.lblSiteName.Text = "Enter the name of your network below."
        '
        'txtbxsetSiteName
        '
        Me.txtbxsetSiteName.Location = New System.Drawing.Point(16, 104)
        Me.txtbxsetSiteName.Name = "txtbxsetSiteName"
        Me.txtbxsetSiteName.Size = New System.Drawing.Size(186, 20)
        Me.txtbxsetSiteName.TabIndex = 1
        '
        'btnSetName
        '
        Me.btnSetName.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.btnSetName.Location = New System.Drawing.Point(208, 103)
        Me.btnSetName.Name = "btnSetName"
        Me.btnSetName.Size = New System.Drawing.Size(108, 21)
        Me.btnSetName.TabIndex = 2
        Me.btnSetName.Text = "Set Name"
        Me.btnSetName.UseVisualStyleBackColor = True
        '
        'trackbarAdIntense
        '
        Me.trackbarAdIntense.Location = New System.Drawing.Point(16, 144)
        Me.trackbarAdIntense.Maximum = 3
        Me.trackbarAdIntense.Minimum = 1
        Me.trackbarAdIntense.Name = "trackbarAdIntense"
        Me.trackbarAdIntense.Size = New System.Drawing.Size(268, 45)
        Me.trackbarAdIntense.TabIndex = 3
        Me.trackbarAdIntense.Value = 1
        '
        'lblAdIntense
        '
        Me.lblAdIntense.AutoSize = True
        Me.lblAdIntense.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblAdIntense.Location = New System.Drawing.Point(13, 127)
        Me.lblAdIntense.Name = "lblAdIntense"
        Me.lblAdIntense.Size = New System.Drawing.Size(175, 14)
        Me.lblAdIntense.TabIndex = 4
        Me.lblAdIntense.Text = "Advertising Intensity"
        '
        'btnSetIntensity
        '
        Me.btnSetIntensity.Font = New System.Drawing.Font("Lucida Console", 9.0!)
        Me.btnSetIntensity.Location = New System.Drawing.Point(290, 144)
        Me.btnSetIntensity.Name = "btnSetIntensity"
        Me.btnSetIntensity.Size = New System.Drawing.Size(110, 20)
        Me.btnSetIntensity.TabIndex = 5
        Me.btnSetIntensity.Text = "Set Intensity"
        Me.btnSetIntensity.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.lblTitle.Location = New System.Drawing.Point(11, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 27)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Control Panel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 12.5!)
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Control your site here. From intensity of ads, to the name of your network."
        '
        'SiteControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSetIntensity)
        Me.Controls.Add(Me.lblAdIntense)
        Me.Controls.Add(Me.trackbarAdIntense)
        Me.Controls.Add(Me.btnSetName)
        Me.Controls.Add(Me.txtbxsetSiteName)
        Me.Controls.Add(Me.lblSiteName)
        Me.Name = "SiteControl"
        Me.Size = New System.Drawing.Size(927, 537)
        CType(Me.trackbarAdIntense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSiteName As Label
    Friend WithEvents txtbxsetSiteName As TextBox
    Friend WithEvents btnSetName As Button
    Friend WithEvents trackbarAdIntense As TrackBar
    Friend WithEvents lblAdIntense As Label
    Friend WithEvents btnSetIntensity As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
End Class

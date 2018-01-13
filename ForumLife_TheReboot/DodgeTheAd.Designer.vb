<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DodgeTheAd
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
        Me.lblAd = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.comboxYesOrNo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Font = New System.Drawing.Font("Lucida Console", 15.0!)
        Me.lblAd.Location = New System.Drawing.Point(8, 21)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(561, 20)
        Me.lblAd.TabIndex = 0
        Me.lblAd.Text = "Ad for the newest version of Microsoft Windows"
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Lucida Console", 12.0!)
        Me.btnCheck.Location = New System.Drawing.Point(449, 63)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(144, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(580, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(13, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        '
        'comboxYesOrNo
        '
        Me.comboxYesOrNo.FormattingEnabled = True
        Me.comboxYesOrNo.Items.AddRange(New Object() {"Yes", "No"})
        Me.comboxYesOrNo.Location = New System.Drawing.Point(12, 65)
        Me.comboxYesOrNo.Name = "comboxYesOrNo"
        Me.comboxYesOrNo.Size = New System.Drawing.Size(121, 21)
        Me.comboxYesOrNo.TabIndex = 4
        Me.comboxYesOrNo.Text = "Select an option."
        '
        'DodgeTheAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 100)
        Me.Controls.Add(Me.comboxYesOrNo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblAd)
        Me.Name = "DodgeTheAd"
        Me.Text = "Dodge The Ad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAd As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents comboxYesOrNo As ComboBox
End Class

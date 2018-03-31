<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DodgeTheAd
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Lucida Console", 12.0!)
        Me.btnCheck.Location = New System.Drawing.Point(449, 53)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(144, 42)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.TabStop = False
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.lblScore.Location = New System.Drawing.Point(580, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(15, 14)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        '
        'comboxYesOrNo
        '
        Me.comboxYesOrNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxYesOrNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboxYesOrNo.Items.AddRange(New Object() {"Select An Option", "Yes", "No"})
        Me.comboxYesOrNo.Location = New System.Drawing.Point(12, 65)
        Me.comboxYesOrNo.Name = "comboxYesOrNo"
        Me.comboxYesOrNo.Size = New System.Drawing.Size(121, 21)
        Me.comboxYesOrNo.TabIndex = 4
        Me.comboxYesOrNo.TabStop = False
        '
        'DodgeTheAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.comboxYesOrNo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblAd)
        Me.Name = "DodgeTheAd"
        Me.Size = New System.Drawing.Size(605, 100)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAd As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents comboxYesOrNo As ComboBox
End Class

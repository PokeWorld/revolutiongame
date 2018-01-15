<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuScreen
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
        Me.LblAmethyst = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmText = New System.Windows.Forms.Timer(Me.components)
        Me.btnGraphic = New System.Windows.Forms.Button()
        Me.lblGraphic = New System.Windows.Forms.Label()
        Me.lblGraphicValue = New System.Windows.Forms.Label()
        Me.tmGraphic = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblAmethyst
        '
        Me.LblAmethyst.AutoSize = True
        Me.LblAmethyst.Font = New System.Drawing.Font("Lucida Console", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmethyst.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblAmethyst.Location = New System.Drawing.Point(19, 19)
        Me.LblAmethyst.Name = "LblAmethyst"
        Me.LblAmethyst.Size = New System.Drawing.Size(252, 48)
        Me.LblAmethyst.TabIndex = 0
        Me.LblAmethyst.Text = "Amethyst"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Font = New System.Drawing.Font("Lucida Console", 18.0!)
        Me.lblAdvice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAdvice.Location = New System.Drawing.Point(22, 208)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(402, 24)
        Me.lblAdvice.TabIndex = 2
        Me.lblAdvice.Text = "More gameplay than ForumLife"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Purple
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Lucida Console", 14.0!)
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlay.Location = New System.Drawing.Point(27, 103)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(244, 40)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Purple
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Lucida Console", 14.0!)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(27, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(244, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close Game"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tmText
        '
        Me.tmText.Enabled = True
        Me.tmText.Interval = 10000
        '
        'btnGraphic
        '
        Me.btnGraphic.BackColor = System.Drawing.Color.Purple
        Me.btnGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraphic.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraphic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGraphic.Location = New System.Drawing.Point(277, 103)
        Me.btnGraphic.Name = "btnGraphic"
        Me.btnGraphic.Size = New System.Drawing.Size(244, 40)
        Me.btnGraphic.TabIndex = 5
        Me.btnGraphic.Text = "Toggle Graphics Friendly Mode"
        Me.btnGraphic.UseVisualStyleBackColor = False
        '
        'lblGraphic
        '
        Me.lblGraphic.AutoSize = True
        Me.lblGraphic.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphic.ForeColor = System.Drawing.Color.White
        Me.lblGraphic.Location = New System.Drawing.Point(23, 67)
        Me.lblGraphic.Name = "lblGraphic"
        Me.lblGraphic.Size = New System.Drawing.Size(196, 19)
        Me.lblGraphic.TabIndex = 6
        Me.lblGraphic.Text = "Graphic Friendly:"
        '
        'lblGraphicValue
        '
        Me.lblGraphicValue.AutoSize = True
        Me.lblGraphicValue.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicValue.ForeColor = System.Drawing.Color.White
        Me.lblGraphicValue.Location = New System.Drawing.Point(225, 67)
        Me.lblGraphicValue.Name = "lblGraphicValue"
        Me.lblGraphicValue.Size = New System.Drawing.Size(64, 19)
        Me.lblGraphicValue.TabIndex = 7
        Me.lblGraphicValue.Text = "False"
        '
        'tmGraphic
        '
        Me.tmGraphic.Interval = 1
        '
        'menuScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblGraphicValue)
        Me.Controls.Add(Me.lblGraphic)
        Me.Controls.Add(Me.btnGraphic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.LblAmethyst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuScreen"
        Me.Text = "Project Amethyst"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAmethyst As Label
    Friend WithEvents lblAdvice As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tmText As Timer
    Friend WithEvents btnGraphic As Button
    Friend WithEvents lblGraphic As Label
    Friend WithEvents lblGraphicValue As Label
    Friend WithEvents tmGraphic As Timer
End Class

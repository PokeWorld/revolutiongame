﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notes
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
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbText
        '
        Me.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbText.Location = New System.Drawing.Point(3, 3)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.Size = New System.Drawing.Size(357, 329)
        Me.rtbText.TabIndex = 0
        Me.rtbText.Text = ""
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rtbText)
        Me.Name = "Notes"
        Me.Size = New System.Drawing.Size(363, 335)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbText As RichTextBox
End Class

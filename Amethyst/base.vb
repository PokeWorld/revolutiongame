Public Class base
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub tmClose_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles tmClose.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then Dispose()
    End Sub

    Private Sub tmOpen_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles tmOpen.Tick
        Me.Opacity += 0.1
        If Me.Opacity = 1 Then tmOpen.Enabled = False
    End Sub

    Private Sub base_Close(ByVal sender As System.Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.graphicsFriendly = True Then Dispose()
        tmClose.Enabled = True
        e.Cancel = True
    End Sub
    Private Sub base_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        tmOpen.Enabled = True
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub base_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitle.MouseDown, lblProg.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub
    Private Sub base_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitle.MouseMove, lblProg.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub base_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitle.MouseUp, lblProg.MouseUp
        drag = False
    End Sub

    Private Sub base_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If My.Settings.graphicsFriendly = True Then Return
        pnlTitle.BackColor = Color.White
        lblProg.ForeColor = SystemColors.ControlText
        lblProg.BackColor = pnlTitle.BackColor
    End Sub

    Private Sub base_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If My.Settings.graphicsFriendly = True Then Return
        pnlTitle.BackColor = Color.WhiteSmoke
        lblProg.ForeColor = SystemColors.ControlDark
        lblProg.BackColor = pnlTitle.BackColor
    End Sub
End Class
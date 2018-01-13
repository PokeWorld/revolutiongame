Public Class base
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity -= 0.05
        If Me.Opacity = 0 Then Me.Dispose()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity += 0.05
        If Me.Opacity = 1 Then Timer2.Enabled = False
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object,
                ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                Handles MyBase.FormClosing
        Timer1.Enabled = True
        e.Cancel = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub base_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub
    Private Sub base_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub base_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
End Class
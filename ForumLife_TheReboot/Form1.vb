Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        desktop.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim upperbound = 10
        Dim lowerbound = 1
        Dim randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd()))
        If randomvalue = 10 Then
            lblAdvice.Text = "I promise this will be finished by mid 2019"
        ElseIf randomvalue = 9 Then
            lblAdvice.Text = "Puzzled? Go to the 'Site Controller' application to get started."
        ElseIf randomvalue = 8 Then
            lblAdvice.Text = "Still in VB, and VERY CLOSED SOURCE."
        ElseIf randomvalue = 7 Then
            lblAdvice.Text = "Hi! I am a bug. Just kidding."
        ElseIf randomvalue = 6 Then
            lblAdvice.Text = "If Rylan was a developer, this would be Google Cod. :fish:"
        ElseIf randomvalue = 5 Then
            lblAdvice.Text = "we want forumlife back."
        ElseIf randomvalue = 4 Then
            lblAdvice.Text = "Does VB support Discord Rich Presence? If so, it will be here (eventually)"
        ElseIf randomvalue = 4 Then
            lblAdvice.Text = "bytes and bits"
        ElseIf randomvalue = 3 Then
            lblAdvice.Text = "Tech Demo 1. (c) Pallet Games"
        ElseIf randomvalue = 2 Then
            lblAdvice.Text = "hi im out of ideas"
        Else
            lblAdvice.Text = "ideameme"
        End If
    End Sub
End Class

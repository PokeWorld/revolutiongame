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
        Dim randomvalue = CInt(Math.Floor((10) * Rnd()))
        Select Case CInt(Math.Floor((10) * Rnd()))
            Case 10
                lblAdvice.Text = "I promise this will be finished by mid 2019"
            Case 9
                lblAdvice.Text = "Puzzled? Go to the 'Site Controller' application to get started."
            Case 8
                lblAdvice.Text = "Still in VB, and VERY CLOSED SOURCE."
            Case 7
                lblAdvice.Text = "Hi! I am a bug. Just kidding."
            Case 6
                lblAdvice.Text = "If Rylan was a developer, this would be Google Cod. :fish:"
            Case 5
                lblAdvice.Text = "Seriously, don't run this at ANYTHING higher than 1080p"
            Case 4
                lblAdvice.Text = "Does VB support Discord Rich Presence? If so, it will be here (eventually)"
            Case 3
                lblAdvice.Text = "bytes and bits"
            Case 2
                lblAdvice.Text = "Tech Demo 1. (c) Pallet Games"
            Case Else
                lblAdvice.Text = "hi im out of ideas"
        End Select
    End Sub
End Class

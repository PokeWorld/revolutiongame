Public Class notes
    Private Sub rtbText_TextChanged(sender As Object, e As EventArgs) Handles rtbText.TextChanged
        My.Settings.dummyText = rtbText.Text
    End Sub

    Private Sub notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbText.Text = My.Settings.dummyText
    End Sub
End Class
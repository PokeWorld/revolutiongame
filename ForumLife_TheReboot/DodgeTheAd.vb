Public Class DodgeTheAd
    Dim score As Integer = 0
    Dim items As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim question As Boolean = items.Item(lblAd.Text)
        Dim answer As Boolean
        If comboxYesOrNo.Text = "Yes" Then
            answer = True
        Else
            answer = False
        End If
        If question = answer Then
            reset(True)
        Else
            reset(False)
        End If
        lblScore.Text = score
        lblAd.Text = items.Keys(CInt(Math.Floor(5 * Rnd())))
    End Sub

    Public Sub reset(correct As Boolean)
        If correct = True Then
            score += 1
            comboxYesOrNo.Text = "Select an option."
            My.Settings.CashCount += 1
        Else
            comboxYesOrNo.Text = "Select an option."
        End If
    End Sub

    Private Sub DodgeTheAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        items.Add("Ad for the newest version of Microsoft Windows", True)
        items.Add("Ad for the new Facebook network", True)
        items.Add("Ad for your site, " + My.Settings.SiteName, True)
        items.Add("Ad for the Pirate Bay torrenting site.", False)
        items.Add("adf.ly link that is not trusted", False)
    End Sub
End Class
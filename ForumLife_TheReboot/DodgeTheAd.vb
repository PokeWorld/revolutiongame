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
        lblAd.Text = items.Keys(CInt(Math.Floor(13 * Rnd())))
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
        items.Add("Link to a fishy forum that you do not like", False)
        items.Add("eBay link", True)
        items.Add("Windows Blue-Screen In Browser Pop-Up", False)
        items.Add("A link to a media converter", False)
        items.Add("Link to small software site", False)
        items.Add("Custom Themes for Windows on Microsoft Site", True)
        items.Add("Link to site where PC games are sold on disk", True)
        items.Add("Link to a some-what fishy looking 'AVG'", True)
    End Sub
End Class
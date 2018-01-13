Public Class DodgeTheAd
    Dim score As Integer = 0

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If My.Settings.LastQuestionDodge = 5 Then
            If comboxYesOrNo.Text = "Yes" Then
                score += 1
                comboxYesOrNo.Text = "Select an option."
                My.Settings.CashCount += 1
            End If
        ElseIf My.Settings.LastQuestionDodge = 4 Then
            If comboxYesOrNo.Text = "No" Then
                score += 1
                comboxYesOrNo.Text = "Select an option."
                My.Settings.CashCount += 1
            End If
        ElseIf My.Settings.LastQuestionDodge = 3 Then
            If comboxYesOrNo.Text = "Yes" Then
                score += 1
                comboxYesOrNo.Text = "Select an option."
                My.Settings.CashCount += 1
            End If
        ElseIf My.Settings.LastQuestionDodge = 2 Then
            If comboxYesOrNo.Text = "No" Then
                score += 1
                comboxYesOrNo.Text = "Select an option."
                My.Settings.CashCount += 1
            End If
        Else
            If comboxYesOrNo.Text = "Yes" Then
                score += 1
                comboxYesOrNo.Text = "Select an option."
                My.Settings.CashCount += 1
            End If
        End If
        lblScore.Text = score
        Dim upperbound = 5
        Dim lowerbound = 1
        Dim randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd()))
        If randomvalue = 5 Then
            lblAd.Text = "Ad for the newest version of Microsoft Windows"
        ElseIf randomvalue = 4 Then
            lblAd.Text = "adf.ly link that is not trusted"
        ElseIf randomvalue = 3 Then
            lblAd.Text = "Ad for the new Facebook network"
        ElseIf randomvalue = 2 Then
            lblAd.Text = "Ad for the Pirate Bay torrenting site."
        Else
            lblAd.Text = "Ad for your site, " & My.Settings.SiteName
        End If
        My.Settings.LastQuestionDodge = randomvalue
    End Sub

    Private Sub DodgeTheAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.LastQuestionDodge = 5
    End Sub
End Class
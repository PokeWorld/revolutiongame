Public Class siteControl
    Private Sub btnSetName_Click(sender As Object, e As EventArgs) Handles btnSetName.Click
        My.Settings.SiteName = txtbxsetSiteName.Text
    End Sub

    Private Sub trackbarAdIntense_ValueChanged(sender As Object, e As EventArgs)
        My.Settings.AdIntensity = trackbarAdIntense.Value
    End Sub

    Private Sub siteControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxsetSiteName.Text = My.Settings.SiteName
        trackbarAdIntense.Value = My.Settings.AdIntensity
    End Sub

    Private Sub btnSetIntensity_Click(sender As Object, e As EventArgs) Handles btnSetIntensity.Click
        My.Settings.AdIntensity = trackbarAdIntense.Value
    End Sub
End Class
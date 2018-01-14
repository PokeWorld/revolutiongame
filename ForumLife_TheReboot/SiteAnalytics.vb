Public Class SiteAnalytics
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblSiteName.Text = "Network Name: " & My.Settings.SiteName
        lblAdIntensity.Text = "Advertising Intensity: " & My.Settings.AdIntensity.ToString()
        lblUserCount.Text = "Users: " & My.Settings.Users.ToString()
    End Sub
End Class
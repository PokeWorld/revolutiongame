Public Class SiteAnalytics
    Private Sub tmData_Tick(sender As Object, e As EventArgs) Handles tmData.Tick
        lblSiteName.Text = "Network Name: " & My.Settings.SiteName
        lblAdIntensity.Text = "Advertising Intensity: " & My.Settings.AdIntensity.ToString()
        lblUserCount.Text = "Users: " & My.Settings.Users.ToString()
    End Sub
End Class
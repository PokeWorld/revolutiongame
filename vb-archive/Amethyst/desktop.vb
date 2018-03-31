Public Class desktop
    Dim wm As New windowManager
#Region "load"
    Private Sub desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDayCount.Text = "Day " & My.Settings.DayCount.ToString
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub
#End Region
#Region "buttons"
    Private Sub btnDayAdvance_Click(sender As Object, e As EventArgs) Handles btnDayAdvance.Click
        My.Settings.DayCount += 1
        lblDayCount.Text = "Day " & My.Settings.DayCount.ToString()
        My.Settings.Users += My.Settings.AdIntensity * 2
        My.Settings.CashCount -= My.Settings.AdIntensity
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        My.Settings.DayCount = 1
        lblDayCount.Text = "Day " & My.Settings.DayCount.ToString()
        My.Settings.SiteName = "Undefined"
        My.Settings.AdIntensity = 1
        My.Settings.Users = 10
        My.Settings.CashCount = 100
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub
#End Region
#Region "Menu items"
    Private Sub tmData_Tick(sender As Object, e As EventArgs) Handles tmData.Tick
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub

    Private Sub tsmNotes_Click(sender As Object, e As EventArgs) Handles tsmNotes.Click
        wm.createWindow(New Notes, "Notes")
    End Sub

    Private Sub tsmShutdown_Click(sender As Object, e As EventArgs) Handles tsmShutdown.Click
        Close()
    End Sub

    Private Sub tsmSiteController_Click(sender As Object, e As EventArgs) Handles tsmSiteController.Click
        wm.createWindow(New SiteControl, "Control Panel")
    End Sub

    Private Sub tsmSiteAnaylytics_Click(sender As Object, e As EventArgs) Handles tsmSiteAnaylytics.Click
        wm.createWindow(New SiteAnalytics, "Analytics")
    End Sub

    Private Sub tsmDodgeTheAd_Click(sender As Object, e As EventArgs) Handles tsmDodgeTheAd.Click
        wm.createWindow(New DodgeTheAd, "Dodge The Ad")
    End Sub
#End Region
End Class
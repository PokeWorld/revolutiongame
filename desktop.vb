Public Class desktop
    Private Sub DummyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DummyToolStripMenuItem.Click
        Dummy.Show()
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SiteControllerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiteControllerToolStripMenuItem.Click
        SiteControl.Show()
    End Sub

    Private Sub SiteAnalyticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiteAnalyticsToolStripMenuItem.Click
        SiteAnalytics.Show()
    End Sub

    Private Sub desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lblDayCount.Text = "Day " & My.Settings.DayCount.ToString
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub

    Private Sub btnDayAdvance_Click(sender As Object, e As EventArgs) Handles btnDayAdvance.Click
        My.Settings.DayCount += 1
        lblDayCount.Text = "Day " & My.Settings.DayCount.ToString()
        If My.Settings.AdIntensity = 1 Then
            My.Settings.Users += 2
            My.Settings.CashCount -= 1
        ElseIf My.Settings.AdIntensity = 2 Then
            My.Settings.Users += 4
            My.Settings.CashCount -= 2
        ElseIf My.Settings.AdIntensity = 3 Then
            My.Settings.Users += 6
            My.Settings.CashCount -= 3
        Else
            My.Settings.Users += 1
            My.Settings.CashCount -= 1
        End If
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

    Private Sub DodgeTheAdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgeTheAdToolStripMenuItem.Click
        DodgeTheAd.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMoney.Text = "Money: $" & My.Settings.CashCount
    End Sub

    Private Sub AboutAmethystToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAmethystToolStripMenuItem.Click
        AboutAmethyst.Show()
    End Sub
End Class
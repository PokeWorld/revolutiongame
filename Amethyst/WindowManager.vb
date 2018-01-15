Public Class windowManager
    Public Sub createWindow(program As UserControl, name As String)
        Dim window As New base
        window.Height = program.Height + 30
        window.Width = program.Width
        program.Parent = window.pnlContent
        program.BringToFront()
        program.Dock = DockStyle.Fill
        window.lblProg.Text = name
        If My.Settings.graphicsFriendly = False Then window.Opacity = 0
        window.TopMost = True
        window.Show()
    End Sub
End Class

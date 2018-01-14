Public Class WindowManager
    Public Sub createWindow(program As UserControl, name As String)
        Dim window As New base
        window.Height = program.Height + 30
        window.Width = program.Width
        program.Parent = window.content
        program.BringToFront()
        program.Dock = DockStyle.Fill
        window.Label1.Text = name
        window.Opacity = 0
        window.TopMost = True
        window.Show()
    End Sub

End Class

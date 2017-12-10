Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitle.Top = (Me.ClientSize.Height / 2) - (lblTitle.Height / 2)
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)

    End Sub
End Class

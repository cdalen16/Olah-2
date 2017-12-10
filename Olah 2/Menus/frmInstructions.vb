Public Class frmInstructions

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnBack.Top = (Me.ClientSize.Height / 2) - (btnBack.Height / 2 - 220)
        btnBack.Left = (Me.ClientSize.Width / 2) - (btnBack.Width / 2)

        Me.Icon = My.Resources.Icon

    End Sub

End Class
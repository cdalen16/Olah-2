Public Class frmFairUse

    Private Sub frmFairUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFairUse.Top = (Me.ClientSize.Height / 2) - (lblFairUse.Height / 2)
        lblFairUse.Left = (Me.ClientSize.Width / 2) - (lblFairUse.Width / 2)

        btnBack.Top = (Me.ClientSize.Height / 2) - (btnBack.Height / 2 - 200)
        btnBack.Left = (Me.ClientSize.Width / 2) - (btnBack.Width / 2)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

End Class
Public Class frmMapSelect

    Friend mapSelected As Single = 1

    Private Sub frmFairUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Icon

        lblSelectMap.Top = (Me.ClientSize.Height / 2) - (lblSelectMap.Height / 2 + 200)
        lblSelectMap.Left = (Me.ClientSize.Width / 2) - (lblSelectMap.Width / 2)

    End Sub

    Private Sub btnMidship_Click(sender As Object, e As EventArgs) Handles btnMidship.Click

        mapSelected = 1

        frmGameSetup.Show()
        Me.Hide()

    End Sub

    Private Sub btnSanctuary_Click(sender As Object, e As EventArgs) Handles btnSanctuary.Click

        mapSelected = 2

        frmGameSetup.Show()
        Me.Hide()

    End Sub

    Private Sub btnDesolation_Click(sender As Object, e As EventArgs) Handles btnDesolation.Click

        mapSelected = 3

        frmGameSetup.Show()
        Me.Hide()

    End Sub
End Class
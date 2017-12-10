Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class frmGameSetup

    Private Sub frmGameSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Icon

        lblOlah2.Text = vbNewLine & vbNewLine & "   Game Setup"
        lblOlah2.Location = New Drawing.Point(-50, -50)
        lblOlah2.Font = New Font("halo", 70)

    End Sub

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click

        frmMapSelect.Show()
        Me.Hide()

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

        frmGameOptions.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If frmMapSelect.mapSelected = 1 Then

            frmMidship.Show()
            Me.Hide()

        ElseIf frmMapSelect.mapSelected = 2 Then

            frmSanctuary.Show()
            Me.Hide()

        ElseIf frmMapSelect.mapSelected = 3 Then

            frmDesolation.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub timPics_Tick(sender As Object, e As EventArgs) Handles timPics.Tick

        picPlayer1.BackgroundImage = frmMainMenu.picPlayer1.BackgroundImage
        picPlayer2.BackgroundImage = frmMainMenu.picPlayer2.BackgroundImage
        picPlayer3.BackgroundImage = frmMainMenu.picPlayer3.BackgroundImage
        picPlayer4.BackgroundImage = frmMainMenu.picPlayer4.BackgroundImage

    End Sub

End Class
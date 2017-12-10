Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class frmPostGameStats

    Private Sub frmPostGameStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Icon

        Cursor.Show()

        picPlayer1.BackgroundImage = frmMainMenu.picPlayer1.BackgroundImage
        picPlayer2.BackgroundImage = frmMainMenu.picPlayer2.BackgroundImage
        picPlayer3.BackgroundImage = frmMainMenu.picPlayer3.BackgroundImage
        picPlayer4.BackgroundImage = frmMainMenu.picPlayer4.BackgroundImage

        lblSignInPlayer1.Text = frmMainMenu.txtPlayer1.Text
        lblSignInPlayer2.Text = frmMainMenu.txtPlayer2.Text
        lblSignInPlayer3.Text = frmMainMenu.txtPlayer3.Text
        lblSignInPlayer4.Text = frmMainMenu.txtPlayer4.Text

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If currentState3.IsConnected = False Then

            picPlayer3.Visible = False

            lblP3Kills.Visible = False

            lblP3Deaths.Visible = False

            btnMainMenu3.Visible = False

            lblSignInPlayer3.Visible = False

        End If

        If currentState4.IsConnected = False Then

            picPlayer4.Visible = False

            lblP4Kills.Visible = False

            lblP4Deaths.Visible = False

            btnMainMenu4.Visible = False

            lblSignInPlayer4.Visible = False

        End If

        If frmMapSelect.mapSelected = 1 Then

            frmMidship.lblCountdown.Visible = True

            lblP1Kills.Text = frmMidship.lblP1Kills.Text
            lblP2Kills.Text = frmMidship.lblP2Kills.Text
            lblP3Kills.Text = frmMidship.lblP3Kills.Text
            lblP4Kills.Text = frmMidship.lblP4Kills.Text

            lblP1Deaths.Text = frmMidship.lblP1Deaths.Text
            lblP2Deaths.Text = frmMidship.lblP2Deaths.Text
            lblP3Deaths.Text = frmMidship.lblP3Deaths.Text
            lblP4Deaths.Text = frmMidship.lblP4Deaths.Text

            If frmMidship.lblP1Deaths.Text = "Deaths: 0" Then

                lblP1Deaths.Text = "Deaths: 0"

            End If

            If frmMidship.lblP2Deaths.Text = "Deaths: 0" Then

                lblP2Deaths.Text = "Deaths: 0"

            End If

            If frmMidship.lblP3Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmMidship.lblP4Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmMidship.p1kills > frmMidship.p2kills And frmMidship.p1kills > frmMidship.p3kills And frmMidship.p1kills > frmMidship.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer1.Text & " Wins!"

            End If

            If frmMidship.p2kills > frmMidship.p1kills And frmMidship.p2kills > frmMidship.p3kills And frmMidship.p2kills > frmMidship.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer2.Text & " Wins!"

            End If

            If frmMidship.p3kills > frmMidship.p1kills And frmMidship.p3kills > frmMidship.p2kills And frmMidship.p3kills > frmMidship.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer3.Text & " Wins!"

            End If

            If frmMidship.p4kills > frmMidship.p1kills And frmMidship.p4kills > frmMidship.p2kills And frmMidship.p4kills > frmMidship.p3kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer4.Text & " Wins!"

            End If

        End If

        If frmMapSelect.mapSelected = 2 Then

            frmSanctuary.lblCountdown.Visible = True

            lblP1Kills.Text = frmSanctuary.lblP1Kills.Text
            lblP2Kills.Text = frmSanctuary.lblP2Kills.Text
            lblP3Kills.Text = frmSanctuary.lblP3Kills.Text
            lblP4Kills.Text = frmSanctuary.lblP4Kills.Text

            lblP1Deaths.Text = frmSanctuary.lblP1Deaths.Text
            lblP2Deaths.Text = frmSanctuary.lblP2Deaths.Text
            lblP3Deaths.Text = frmSanctuary.lblP3Deaths.Text
            lblP4Deaths.Text = frmSanctuary.lblP4Deaths.Text

            If frmSanctuary.lblP1Deaths.Text = "Deaths: 0" Then

                lblP1Deaths.Text = "Deaths: 0"

            End If

            If frmSanctuary.lblP2Deaths.Text = "Deaths: 0" Then

                lblP2Deaths.Text = "Deaths: 0"

            End If

            If frmSanctuary.lblP3Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmSanctuary.lblP4Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmSanctuary.p1kills > frmSanctuary.p2kills And frmSanctuary.p1kills > frmSanctuary.p3kills And frmSanctuary.p1kills > frmSanctuary.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer1.Text & " Wins!"

            End If

            If frmSanctuary.p2kills > frmSanctuary.p1kills And frmSanctuary.p2kills > frmSanctuary.p3kills And frmSanctuary.p2kills > frmSanctuary.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer2.Text & " Wins!"

            End If

            If frmSanctuary.p3kills > frmSanctuary.p1kills And frmSanctuary.p3kills > frmSanctuary.p2kills And frmSanctuary.p3kills > frmSanctuary.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer3.Text & " Wins!"

            End If

            If frmSanctuary.p4kills > frmSanctuary.p1kills And frmSanctuary.p4kills > frmSanctuary.p2kills And frmSanctuary.p4kills > frmSanctuary.p3kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer4.Text & " Wins!"

            End If

        End If

        If frmMapSelect.mapSelected = 3 Then

            frmDesolation.lblCountdown.Visible = True

            lblP1Kills.Text = frmDesolation.lblP1Kills.Text
            lblP2Kills.Text = frmDesolation.lblP2Kills.Text
            lblP3Kills.Text = frmDesolation.lblP3Kills.Text
            lblP4Kills.Text = frmDesolation.lblP4Kills.Text

            lblP1Deaths.Text = frmDesolation.lblP1Deaths.Text
            lblP2Deaths.Text = frmDesolation.lblP2Deaths.Text
            lblP3Deaths.Text = frmDesolation.lblP3Deaths.Text
            lblP4Deaths.Text = frmDesolation.lblP4Deaths.Text

            If frmDesolation.lblP1Deaths.Text = "Deaths: 0" Then

                lblP1Deaths.Text = "Deaths: 0"

            End If

            If frmDesolation.lblP2Deaths.Text = "Deaths: 0" Then

                lblP2Deaths.Text = "Deaths: 0"

            End If

            If frmDesolation.lblP3Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmDesolation.lblP4Deaths.Text = "Deaths: 0" Then

                lblP3Deaths.Text = "Deaths: 0"

            End If

            If frmDesolation.p1kills > frmDesolation.p2kills And frmDesolation.p1kills > frmDesolation.p3kills And frmDesolation.p1kills > frmDesolation.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer1.Text & " Wins!"

            End If

            If frmDesolation.p2kills > frmDesolation.p1kills And frmDesolation.p2kills > frmDesolation.p3kills And frmDesolation.p2kills > frmDesolation.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer2.Text & " Wins!"

            End If

            If frmDesolation.p3kills > frmDesolation.p1kills And frmDesolation.p3kills > frmDesolation.p2kills And frmDesolation.p3kills > frmDesolation.p4kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer3.Text & " Wins!"

            End If

            If frmDesolation.p4kills > frmDesolation.p1kills And frmDesolation.p4kills > frmDesolation.p2kills And frmDesolation.p4kills > frmDesolation.p3kills Then

                lblPostGameWinner.Text = frmMainMenu.txtPlayer4.Text & " Wins!"

            End If

        End If

        lblPostGameWinner.Top = (Me.ClientSize.Height / 2) - (lblPostGameWinner.Height / 2 + 300)
        lblPostGameWinner.Left = (Me.ClientSize.Width / 2) - (lblPostGameWinner.Width / 2)

        My.Computer.Audio.Play(My.Resources.Game_Over, AudioPlayMode.WaitToComplete)

        timStopItStocks.Start()

    End Sub

    Private Sub btnMainMenu4_Click(sender As Object, e As EventArgs) Handles btnMainMenu4.Click

        frmMidship.Close()
        frmSanctuary.Close()
        frmDesolation.Close()
        frmInstructions.Close()
        frmFairUse.Close()
        frmGameOptions.Close()
        frmGameOptions.Close()
        frmMapSelect.Close()
        frmGameOptions.Close()

        frmMainMenu.Show()
        Me.Close()

        My.Computer.Audio.Play(My.Resources.Olah_2_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnMainMenu2_Click(sender As Object, e As EventArgs) Handles btnMainMenu2.Click

        frmMidship.Close()
        frmSanctuary.Close()
        frmDesolation.Close()
        frmInstructions.Close()
        frmFairUse.Close()
        frmGameOptions.Close()
        frmGameOptions.Close()
        frmMapSelect.Close()
        frmGameOptions.Close()

        frmMainMenu.Show()
        Me.Close()

        My.Computer.Audio.Play(My.Resources.Olah_2_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnMainMenu3_Click(sender As Object, e As EventArgs) Handles btnMainMenu3.Click

        frmMidship.Close()
        frmSanctuary.Close()
        frmDesolation.Close()
        frmInstructions.Close()
        frmFairUse.Close()
        frmGameOptions.Close()
        frmGameOptions.Close()
        frmMapSelect.Close()
        frmGameOptions.Close()

        frmMainMenu.Show()
        Me.Close()

        My.Computer.Audio.Play(My.Resources.Olah_2_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnMainMenu1_Click(sender As Object, e As EventArgs) Handles btnMainMenu1.Click

        frmMidship.Close()
        frmSanctuary.Close()
        frmDesolation.Close()
        frmInstructions.Close()
        frmFairUse.Close()
        frmGameOptions.Close()
        frmGameOptions.Close()
        frmMapSelect.Close()
        frmGameOptions.Close()

        frmMainMenu.Show()
        Me.Close()

        My.Computer.Audio.Play(My.Resources.Olah_2_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub timStopItStocks_Tick(sender As Object, e As EventArgs) Handles timStopItStocks.Tick

        My.Computer.Audio.Stop()

    End Sub

End Class
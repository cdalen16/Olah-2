Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class frmMainMenu

    Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
    Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
    Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
    Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

    Private Sub frmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If lblOlah2.Text = "Olah 2" Then

            If e.KeyCode = Windows.Forms.Keys.Enter Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                picPlayer1.Show()
                txtPlayer1.Show()
                btnSavePlayer1.Show()

                picPlayer2.Show()
                txtPlayer2.Show()
                btnSavePlayer2.Show()

                picPlayer3.Show()
                txtPlayer3.Show()
                btnSavePlayer3.Show()

                picPlayer4.Show()
                txtPlayer4.Show()
                btnSavePlayer4.Show()

            End If

        End If

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblOlah2.Top = (Me.ClientSize.Height / 2) - (lblOlah2.Height / 2 + 50)
        lblOlah2.Left = (Me.ClientSize.Width / 2) - (lblOlah2.Width / 2)

        lblStartorEnter.Top = (Me.ClientSize.Height / 2) - (lblStartorEnter.Height / 2 - 100)
        lblStartorEnter.Left = (Me.ClientSize.Width / 2) - (lblStartorEnter.Width / 2)

        'My.Computer.Audio.Play(My.Resources.Olah_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnSavePlayer1_Click(sender As Object, e As EventArgs) Handles btnSavePlayer1.Click

        'below is players signing out

        If txtPlayer1.Text = Nothing Then

            lblSignInPlayer1.Text = "Not signed in"

            picPlayer3.Show()
            txtPlayer3.Show()
            btnSavePlayer3.Show()

            picPlayer4.Show()
            txtPlayer4.Show()
            btnSavePlayer4.Show()

        End If

        'below is player 1 and 2 joining with keyboard

        If txtPlayer1.Text <> Nothing And currentState1.IsConnected = False Then

            lblSignInPlayer1.Text = "Signed in as:" & vbNewLine & txtPlayer1.Text

            picPlayer3.Hide()
            txtPlayer3.Hide()
            btnSavePlayer3.Hide()

            picPlayer4.Hide()
            txtPlayer4.Hide()
            btnSavePlayer4.Hide()

        End If

        'below is player 1 2 3 4 joining with controller

        If txtPlayer1.Text <> Nothing And currentState1.IsConnected = True Then

            lblSignInPlayer1.Text = "Signed in as:" & vbNewLine & txtPlayer1.Text

        End If

    End Sub

    Private Sub btnSavePlayer2_Click(sender As Object, e As EventArgs) Handles btnSavePlayer2.Click

        If txtPlayer2.Text = Nothing Then

            lblSignInPlayer2.Text = "Not signed in"

            picPlayer3.Show()
            txtPlayer3.Show()
            btnSavePlayer3.Show()

            picPlayer4.Show()
            txtPlayer4.Show()
            btnSavePlayer4.Show()

        End If

        If txtPlayer2.Text <> Nothing And currentState2.IsConnected = False Then

            lblSignInPlayer2.Text = "Signed in as:" & vbNewLine & txtPlayer2.Text

            picPlayer3.Hide()
            txtPlayer3.Hide()
            btnSavePlayer3.Hide()

            picPlayer4.Hide()
            txtPlayer4.Hide()
            btnSavePlayer4.Hide()

        End If

        If txtPlayer2.Text <> Nothing And currentState2.IsConnected = True Then

            lblSignInPlayer2.Text = "Signed in as:" & vbNewLine & txtPlayer2.Text

        End If

    End Sub

    Private Sub btnSavePlayer3_Click(sender As Object, e As EventArgs) Handles btnSavePlayer3.Click

        If txtPlayer3.Text = Nothing Then

            lblSignInPlayer1.Text = "Not signed in"

        End If

        If txtPlayer3.Text <> Nothing And currentState3.IsConnected = True Then

            lblSignInPlayer3.Text = "Signed in as:" & vbNewLine & txtPlayer3.Text

        End If

    End Sub

    Private Sub btnSavePlayer4_Click(sender As Object, e As EventArgs) Handles btnSavePlayer4.Click

        If txtPlayer4.Text = Nothing Then

            lblSignInPlayer1.Text = "Not signed in"

        End If

        If txtPlayer4.Text <> Nothing And currentState4.IsConnected = True Then

            lblSignInPlayer4.Text = "Signed in as:" & vbNewLine & txtPlayer4.Text

        End If

    End Sub

    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click

        frmGameSetup.Show()
        Me.Hide()

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click

    End Sub

    Private Sub btnFairUse_Click(sender As Object, e As EventArgs) Handles btnFairUse.Click

        frmFairUse.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub timControllers_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timControllers.Tick

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If currentState1.IsConnected And lblOlah2.Text = "Olah 2" Then

            If currentState1.Buttons.Start Or currentState1.Buttons.A = ButtonState.Pressed Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer1.Show()
                txtPlayer1.Show()
                btnSavePlayer1.Show()

                picPlayer2.Show()
                txtPlayer2.Show()
                btnSavePlayer2.Show()

                picPlayer3.Show()
                txtPlayer3.Show()
                btnSavePlayer3.Show()

                picPlayer4.Show()
                txtPlayer4.Show()
                btnSavePlayer4.Show()

            End If

        End If

        If currentState2.IsConnected And lblOlah2.Text = "Olah 2" Then

            If currentState2.Buttons.Start Or currentState2.Buttons.A = ButtonState.Pressed Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer1.Show()
                txtPlayer1.Show()
                btnSavePlayer1.Show()

                picPlayer2.Show()
                txtPlayer2.Show()
                btnSavePlayer2.Show()

                picPlayer3.Show()
                txtPlayer3.Show()
                btnSavePlayer3.Show()

                picPlayer4.Show()
                txtPlayer4.Show()
                btnSavePlayer4.Show()

            End If

        End If

        If currentState3.IsConnected And lblOlah2.Text = "Olah 2" Then

            If currentState3.Buttons.Start Or currentState3.Buttons.A = ButtonState.Pressed Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer1.Show()
                txtPlayer1.Show()
                btnSavePlayer1.Show()

                picPlayer2.Show()
                txtPlayer2.Show()
                btnSavePlayer2.Show()

                picPlayer3.Show()
                txtPlayer3.Show()
                btnSavePlayer3.Show()

                picPlayer4.Show()
                txtPlayer4.Show()
                btnSavePlayer4.Show()

            End If

        End If

        If currentState4.IsConnected And lblOlah2.Text = "Olah 2" Then

            If currentState4.Buttons.Start Or currentState4.Buttons.A = ButtonState.Pressed Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                btnPlay.Show()
                btnStats.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer1.Show()
                txtPlayer1.Show()
                btnSavePlayer1.Show()

                picPlayer2.Show()
                txtPlayer2.Show()
                btnSavePlayer2.Show()

                picPlayer3.Show()
                txtPlayer3.Show()
                btnSavePlayer3.Show()

                picPlayer4.Show()
                txtPlayer4.Show()
                btnSavePlayer4.Show()

            End If

        End If

    End Sub

End Class

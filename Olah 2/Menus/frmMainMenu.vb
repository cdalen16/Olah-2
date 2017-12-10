Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class frmMainMenu

    Friend Event loadMainMenu As EventHandler

    Friend P1Color As Single = 0
    Friend P2Color As Single = 0
    Friend P3Color As Single = 0
    Friend P4Color As Single = 0

    Friend blnKeyboard As Boolean

    Private Sub frmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If lblOlah2.Text = "Olah 2" Then

            If e.KeyCode = Keys.Enter Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                lblP1Press.Show()
                lblP2Press.Show()

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

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)

        If e.KeyCode = Keys.Q And currentState1.IsConnected = False Then

            P1Color += 1

            lblP1Press.Hide()

            If P1Color = 1 Then

                picPlayer1.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P1Color = 2

                picPlayer1.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P1Color = 3

                picPlayer1.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P1Color = 4

                picPlayer1.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P1Color > 4 Then

            P1Color = 1

        End If

        If P1Color = 1 Then

            picPlayer1.BackgroundImage = My.Resources.Red_Spartan

        End If

        If e.KeyCode = Keys.Y And currentState2.IsConnected = False Then

            P2Color += 1

            lblP2Press.Hide()

            If P2Color = 1 Then

                picPlayer2.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P2Color = 2

                picPlayer2.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P2Color = 3

                picPlayer2.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P2Color = 4

                picPlayer2.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P2Color > 4 Then

            P2Color = 1

        End If

        If P2Color = 1 Then

            picPlayer2.BackgroundImage = My.Resources.Red_Spartan

        End If

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmLoading.Show()

        Me.Icon = My.Resources.Icon

        My.Computer.Audio.Play(My.Resources.Olah_2_Theme, AudioPlayMode.BackgroundLoop)

        lblOlah2.Top = (Me.ClientSize.Height / 2) - (lblOlah2.Height / 2 + 50)
        lblOlah2.Left = (Me.ClientSize.Width / 2) - (lblOlah2.Width / 2)

        lblStartorEnter.Top = (Me.ClientSize.Height / 2) - (lblStartorEnter.Height / 2 - 100)
        lblStartorEnter.Left = (Me.ClientSize.Width / 2) - (lblStartorEnter.Width / 2)

    End Sub

    Private Sub btnSavePlayer1_Click(sender As Object, e As EventArgs) Handles btnSavePlayer1.Click

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)

        'below is players signing out

        If txtPlayer1.Text = Nothing Then

            lblSignInPlayer1.Text = "Not signed in"

            picPlayer3.Show()
            txtPlayer3.Show()
            btnSavePlayer3.Show()
            lblSignInPlayer3.Show()

            picPlayer4.Show()
            txtPlayer4.Show()
            btnSavePlayer4.Show()
            lblSignInPlayer4.Show()

        End If

        If txtPlayer1.Text <> Nothing And currentState1.IsConnected = False Then

            lblSignInPlayer1.Text = "Signed in as:" & vbNewLine & txtPlayer1.Text

            blnKeyboard = True

            picPlayer3.Hide()
            txtPlayer3.Hide()
            btnSavePlayer3.Hide()
            lblSignInPlayer3.Hide()

            picPlayer4.Hide()
            txtPlayer4.Hide()
            btnSavePlayer4.Hide()
            lblSignInPlayer4.Hide()

        End If

        If txtPlayer1.Text <> Nothing And currentState1.IsConnected = True Then

            lblSignInPlayer1.Text = "Signed in as:" & vbNewLine & txtPlayer1.Text

            blnKeyboard = False

        End If

    End Sub

    Private Sub btnSavePlayer2_Click(sender As Object, e As EventArgs) Handles btnSavePlayer2.Click

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)

        If txtPlayer2.Text = Nothing Then

            lblSignInPlayer2.Text = "Not signed in"

            picPlayer3.Show()
            txtPlayer3.Show()
            btnSavePlayer3.Show()
            lblSignInPlayer3.Show()

            picPlayer4.Show()
            txtPlayer4.Show()
            btnSavePlayer4.Show()
            lblSignInPlayer4.Show()

        End If

        If txtPlayer2.Text <> Nothing And currentState2.IsConnected = False Then

            lblSignInPlayer2.Text = "Signed in as:" & vbNewLine & txtPlayer2.Text

            blnKeyboard = True

            picPlayer3.Hide()
            txtPlayer3.Hide()
            btnSavePlayer3.Hide()
            lblSignInPlayer3.Hide()

            picPlayer4.Hide()
            txtPlayer4.Hide()
            btnSavePlayer4.Hide()
            lblSignInPlayer4.Hide()

        End If

        If txtPlayer2.Text <> Nothing And currentState1.IsConnected = True And currentState2.IsConnected = True Then

            lblSignInPlayer2.Text = "Signed in as:" & vbNewLine & txtPlayer2.Text

            blnKeyboard = False

        End If

    End Sub

    Private Sub btnSavePlayer3_Click(sender As Object, e As EventArgs) Handles btnSavePlayer3.Click

        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)

        If txtPlayer3.Text = Nothing Then

            lblSignInPlayer3.Text = "Not signed in"

        End If

        If txtPlayer3.Text <> Nothing And currentState3.IsConnected = True Then

            lblSignInPlayer3.Text = "Signed in as:" & vbNewLine & txtPlayer3.Text

            blnKeyboard = False

        End If

    End Sub

    Private Sub btnSavePlayer4_Click(sender As Object, e As EventArgs) Handles btnSavePlayer4.Click

        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If txtPlayer4.Text = Nothing Then

            lblSignInPlayer4.Text = "Not signed in"

        End If

        If txtPlayer4.Text <> Nothing And currentState4.IsConnected = True Then

            lblSignInPlayer4.Text = "Signed in as:" & vbNewLine & txtPlayer4.Text

            blnKeyboard = False

        End If

    End Sub

    Private Sub timChangeTem_Tick(sender As Object, e As EventArgs) Handles timChangeTem.Tick

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        Console.WriteLine(P1Color)

        If currentState1.IsConnected = True And currentState2.IsConnected = True And currentState3.IsConnected = True And currentState4.IsConnected = True Then

            txtPlayer1.Enabled = True
            txtPlayer2.Enabled = True
            txtPlayer3.Enabled = True
            txtPlayer4.Enabled = True

        End If

        If currentState3.IsConnected = False Then

            txtPlayer3.Enabled = False

            txtPlayer3.Text = Nothing

            lblSignInPlayer3.Text = "Not signed in"

            picPlayer3.BackgroundImage = Nothing

        Else

            txtPlayer3.Enabled = True

        End If

        If currentState4.IsConnected = False Then

            txtPlayer4.Enabled = False

            txtPlayer4.Text = Nothing

            lblSignInPlayer4.Text = "Not signed in"

            picPlayer4.BackgroundImage = Nothing

        Else

            txtPlayer4.Enabled = True

        End If

        If Me.Visible = True And currentState1.Buttons.X Then

            P1Color += 1

            If P1Color = 1 Then

                picPlayer1.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P1Color = 2 Then

                picPlayer1.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P1Color = 3 Then

                picPlayer1.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P1Color = 4 Then

                picPlayer1.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P1Color > 4 Then

            P1Color = 1

        End If

        If P1Color = 1 Then

            picPlayer1.BackgroundImage = My.Resources.Red_Spartan

        End If

        If Me.Visible = True And currentState2.Buttons.X Then

            P2Color += 1

            If P2Color = 1 Then

                picPlayer2.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P2Color = 2 Then

                picPlayer2.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P2Color = 3 Then

                picPlayer2.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P2Color = 4 Then

                picPlayer2.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P2Color > 4 Then

            P2Color = 1

        End If

        If P2Color = 1 Then

            picPlayer2.BackgroundImage = My.Resources.Red_Spartan

        End If

        If Me.Visible = True And currentState3.Buttons.X Then

            P3Color += 1

            If P3Color = 1 Then

                picPlayer3.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P3Color = 2 Then

                picPlayer3.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P3Color = 3 Then

                picPlayer3.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P3Color = 4 Then

                picPlayer3.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P3Color > 4 Then

            P3Color = 1

        End If

        If P3Color = 1 Then

            picPlayer3.BackgroundImage = My.Resources.Red_Spartan

        End If

        If Me.Visible = True And currentState4.Buttons.X Then

            P4Color += 1

            If P4Color = 1 Then

                picPlayer4.BackgroundImage = My.Resources.Red_Spartan

            ElseIf P4Color = 2 Then

                picPlayer4.BackgroundImage = My.Resources.Blue_Spartan

            ElseIf P4Color = 3 Then

                picPlayer4.BackgroundImage = My.Resources.Green_Spartan

            ElseIf P4Color = 4 Then

                picPlayer4.BackgroundImage = My.Resources.Yellow_Spartan

            End If

        End If

        If P4Color > 4 Then

            P4Color = 1

        End If

        If P4Color = 1 Then

            picPlayer4.BackgroundImage = My.Resources.Red_Spartan

        End If

    End Sub

    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click

        frmGameSetup.Show()
        Me.Hide()

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click

        frmInstructions.Show()
        Me.Hide()

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

        If btnPlay.Visible = True And P1Color = 0 Then

            lblP1Con.Hide()
            lblP2Con.Hide()
            lblP3Con.Hide()
            lblP4Con.Hide()

            lblP1Press.Show()

        End If

        If btnPlay.Visible = True And P2Color = 0 Then

            lblP1Con.Hide()
            lblP2Con.Hide()
            lblP3Con.Hide()
            lblP4Con.Hide()

            lblP2Press.Show()

        End If

        If btnPlay.Visible = True And (currentState1.IsConnected = True Or currentState2.IsConnected = True Or currentState3.IsConnected = True Or currentState4.IsConnected) = True Then

            lblP1Con.Show()
            lblP2Con.Show()
            lblP3Con.Show()
            lblP4Con.Show()

            lblP1Press.Hide()
            lblP2Press.Hide()

        Else

            lblP1Con.Hide()
            lblP2Con.Hide()
            lblP3Con.Hide()
            lblP4Con.Hide()

        End If

        If currentState1.IsConnected = True Then

            lblP1Con.Text = "P1:  Connected"

        Else

            lblP1Con.Text = "P1:  Disconnected"

        End If

        If currentState2.IsConnected Then

            lblP2Con.Text = "P2: Connected"

        Else

            lblP2Con.Text = "P2: Disconnected"

        End If

        If currentState3.IsConnected Then

            lblP3Con.Text = "P3: Connected"

        Else

            lblP3Con.Text = "P3: Disconnected"

        End If

        If currentState4.IsConnected Then

            lblP4Con.Text = "P4: Connected"

        Else

            lblP4Con.Text = "P4: Disconnected"

        End If

        If currentState1.IsConnected And lblOlah2.Text = "Olah 2" Then

            If currentState1.Buttons.Start Or currentState1.Buttons.A = ButtonState.Pressed Then

                lblOlah2.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah2.Location = New Drawing.Point(-50, -50)
                lblOlah2.Font = New Font("halo", 70)

                lblStartorEnter.Hide()

                btnPlay.Show()
                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                lblP1Press.Show()
                lblP2Press.Show()

                btnPlay.Show()
                btnInstructions.Show()
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
                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                lblP1Press.Show()
                lblP2Press.Show()

                btnPlay.Show()
                btnInstructions.Show()
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
                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                lblP1Press.Show()
                lblP2Press.Show()

                btnPlay.Show()
                btnInstructions.Show()
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
                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                lblSignInPlayer1.Show()
                lblSignInPlayer2.Show()
                lblSignInPlayer3.Show()
                lblSignInPlayer4.Show()

                lblP1Press.Show()
                lblP2Press.Show()

                btnPlay.Show()
                btnInstructions.Show()
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

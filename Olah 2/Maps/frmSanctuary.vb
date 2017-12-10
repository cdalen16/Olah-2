Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class frmSanctuary

    Dim red1 As Single
    Dim blue1 As Single
    Dim green1 As Single
    Dim yellow1 As Single

    Dim red2 As Single
    Dim blue2 As Single
    Dim green2 As Single
    Dim yellow2 As Single

    Dim red3 As Single
    Dim blue3 As Single
    Dim green3 As Single
    Dim yellow3 As Single

    Dim red4 As Single
    Dim blue4 As Single
    Dim green4 As Single
    Dim yellow4 As Single

    Dim Looking As Single
    Dim looking2 As Single
    Dim looking3 As Single
    Dim looking4 As Single

    Dim JumpTimeP1 As Single
    Dim JumpTimeP2 As Single
    Dim JumpTimeP3 As Single
    Dim JumpTimeP4 As Single

    Dim SpawnPointTop1 As Integer
    Dim SpawnPointTop2 As Integer
    Dim SpawnPointTop3 As Integer
    Dim SpawnPointTop4 As Integer

    Dim SpawnPointleft1 As Integer
    Dim SpawnPointleft2 As Integer
    Dim SpawnPointleft3 As Integer
    Dim SpawnPointleft4 As Integer

    Friend p1deaths As Single = 0
    Friend p2deaths As Single = 0
    Friend p3deaths As Single = 0
    Friend p4deaths As Single = 0

    Friend p1kills As Single = 0
    Friend p2kills As Single = 0
    Friend p3kills As Single = 0
    Friend p4kills As Single = 0

    Dim leftDir1 As Boolean
    Dim rightDir1 As Boolean
    Dim leftDir2 As Boolean
    Dim rightDir2 As Boolean

    Dim Min As Integer
    Dim Sec As Integer

    Dim Time As Integer
    Friend Mins As Single

    Private Sub frmMidship_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Icon

        Cursor.Hide()

        SpawnPointTop1 = picSpawnTopLeft.Top
        SpawnPointTop2 = picSpawnTopRight.Top
        SpawnPointTop3 = picSpawnBotLeft.Top
        SpawnPointTop4 = picSpawnBotRight.Top

        SpawnPointleft1 = picSpawnTopLeft.Left
        SpawnPointleft2 = picSpawnTopRight.Left
        SpawnPointleft3 = picSpawnBotLeft.Left
        SpawnPointleft4 = picSpawnBotRight.Left

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        'timGameTimer.Start()
        timGameTime.Start()
        timLives.Start()

        lblP1Name.Text = frmMainMenu.txtPlayer1.Text
        lblP2Name.Text = frmMainMenu.txtPlayer2.Text
        lblP3Name.Text = frmMainMenu.txtPlayer3.Text
        lblP4Name.Text = frmMainMenu.txtPlayer4.Text

        My.Computer.Audio.Stop()

        'If currentState1.IsConnected Then

        If frmMainMenu.P1Color = 1 Then

            Do
                Randomize()
                red1 = Int(Rnd() * 4) + 1
            Loop Until red1 <> red2 And red1 <> blue2 And red1 <> green2 And red1 <> yellow2 And red1 <> red3 And red1 <> blue3 And red1 <> green3 And red1 <> yellow3 And red1 <> red4 And red1 <> blue4 And red1 <> green4 And red1 <> yellow4

            If red1 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Red_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf red1 = 2 Then
                picSpawnTopRight.Image = My.Resources.Red_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf red1 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Red_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf red1 = 4 Then
                picSpawnBotRight.Image = My.Resources.Red_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If


        If frmMainMenu.P1Color = 2 Then
            Do
                Randomize()
                blue1 = Int(Rnd() * 4) + 1
            Loop Until blue1 <> red2 And blue1 <> blue2 And blue1 <> green2 And blue1 <> yellow2 And blue1 <> red3 And blue1 <> blue3 And blue1 <> green3 And blue1 <> yellow3 And blue1 <> red4 And blue1 <> blue4 And blue1 <> green4 And blue1 <> yellow4

            If blue1 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Blue_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf blue1 = 2 Then
                picSpawnTopRight.Image = My.Resources.Blue_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf blue1 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Blue_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf blue1 = 4 Then
                picSpawnBotRight.Image = My.Resources.Blue_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If


        If frmMainMenu.P1Color = 3 Then
            Do
                Randomize()
                green1 = Int(Rnd() * 4) + 1
            Loop Until green1 <> red2 And green1 <> blue2 And green1 <> green2 And green1 <> yellow2 And green1 <> red3 And green1 <> blue3 And green1 <> green3 And green1 <> yellow3 And green1 <> red4 And green1 <> blue4 And green1 <> green4 And green1 <> yellow4

            If green1 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Green_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf green1 = 2 Then
                picSpawnTopRight.Image = My.Resources.Green_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf green1 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Green_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf green1 = 4 Then
                picSpawnBotRight.Image = My.Resources.Green_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If


        If frmMainMenu.P1Color = 4 Then
            Do
                Randomize()
                yellow1 = Int(Rnd() * 4) + 1
            Loop Until yellow1 <> red2 And yellow1 <> blue2 And yellow1 <> green2 And yellow1 <> yellow2 And yellow1 <> red3 And yellow1 <> blue3 And yellow1 <> green3 And yellow1 <> yellow3 And yellow1 <> red4 And yellow1 <> blue4 And yellow1 <> green4 And yellow1 <> yellow4

            If yellow1 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Yellow_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow1 = 2 Then
                picSpawnTopRight.Image = My.Resources.Yellow_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow1 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Yellow_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow1 = 4 Then
                picSpawnBotRight.Image = My.Resources.Yellow_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If

        'End If







        'If currentState2.IsConnected Then

        If frmMainMenu.P2Color = 1 Then
            Do
                Randomize()
                red2 = Int(Rnd() * 4) + 1
            Loop Until red2 <> red1 And red2 <> blue1 And red2 <> green1 And red2 <> yellow1 And red2 <> red3 And red2 <> blue3 And red2 <> green3 And red2 <> yellow3 And red2 <> red4 And red2 <> blue4 And red2 <> green4 And red2 <> yellow4

            If red2 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Red_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf red2 = 2 Then
                picSpawnTopRight.Image = My.Resources.Red_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf red2 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Red_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf red2 = 4 Then
                picSpawnBotRight.Image = My.Resources.Red_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If


        If frmMainMenu.P2Color = 2 Then
            Do
                Randomize()
                blue2 = Int(Rnd() * 4) + 1
            Loop Until blue2 <> red1 And blue2 <> blue1 And blue2 <> green1 And blue2 <> yellow1 And blue2 <> red3 And blue2 <> blue3 And blue2 <> green3 And blue2 <> yellow3 And blue2 <> red4 And blue2 <> blue4 And blue2 <> green4 And blue2 <> yellow4

            If blue2 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Blue_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf blue2 = 2 Then
                picSpawnTopRight.Image = My.Resources.Blue_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf blue2 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Blue_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf blue2 = 4 Then
                picSpawnBotRight.Image = My.Resources.Blue_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If



        If frmMainMenu.P2Color = 3 Then
            Do
                Randomize()
                green2 = Int(Rnd() * 4) + 1
            Loop Until green2 <> red1 And green2 <> blue1 And green2 <> green1 And green2 <> yellow1 And green2 <> red3 And green2 <> blue3 And green2 <> green3 And green2 <> yellow3 And green2 <> red4 And green2 <> blue4 And green2 <> green4 And green2 <> yellow4

            If green2 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Green_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf green2 = 2 Then
                picSpawnTopRight.Image = My.Resources.Green_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf green2 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Green_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf green2 = 4 Then
                picSpawnBotRight.Image = My.Resources.Green_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If



        If frmMainMenu.P2Color = 4 Then

            Do
                Randomize()
                yellow2 = Int(Rnd() * 4) + 1
            Loop Until yellow2 <> red1 And yellow2 <> blue1 And yellow2 <> green1 And yellow2 <> yellow1 And yellow2 <> red3 And yellow2 <> blue3 And yellow2 <> green3 And yellow2 <> yellow3 And yellow2 <> red4 And yellow2 <> blue4 And yellow2 <> green4 And yellow2 <> yellow4

            If yellow2 = 1 Then
                picSpawnTopLeft.Image = My.Resources.Yellow_Spartan
                picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow2 = 2 Then
                picSpawnTopRight.Image = My.Resources.Yellow_Spartan2
                picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow2 = 3 Then
                picSpawnBotLeft.Image = My.Resources.Yellow_Spartan
                picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
            ElseIf yellow2 = 4 Then
                picSpawnBotRight.Image = My.Resources.Yellow_Spartan2
                picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
            End If
        End If

        'End If




        If currentState3.IsConnected Then

            If frmMainMenu.P3Color = 1 Then
                Do
                    Randomize()
                    red3 = Int(Rnd() * 4) + 1
                Loop Until red3 <> red1 And red3 <> blue1 And red3 <> green1 And red3 <> yellow1 And red3 <> red2 And red3 <> blue2 And red3 <> green2 And red3 <> yellow2 And red3 <> red4 And red3 <> blue4 And red3 <> green4 And red3 <> yellow4

                If red3 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Red_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf red3 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Red_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf red3 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Red_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf red3 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Red_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P3Color = 2 Then
                Do
                    Randomize()
                    blue3 = Int(Rnd() * 4) + 1
                Loop Until blue3 <> red1 And blue3 <> blue1 And blue3 <> green1 And blue3 <> yellow1 And blue3 <> red2 And blue3 <> blue2 And blue3 <> green2 And blue3 <> yellow2 And blue3 <> red4 And blue3 <> blue4 And blue3 <> green4 And blue3 <> yellow4

                If blue3 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Blue_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf blue3 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Blue_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf blue3 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Blue_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf blue3 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Blue_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P3Color = 3 Then
                Do
                    Randomize()
                    green3 = Int(Rnd() * 4) + 1
                Loop Until green3 <> red1 And green3 <> blue1 And green3 <> green1 And green3 <> yellow1 And green3 <> red2 And green3 <> blue2 And green3 <> green2 And green3 <> yellow2 And green3 <> red4 And green3 <> blue4 And green3 <> green4 And green3 <> yellow4

                If green3 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Green_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf green3 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Green_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf green3 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Green_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf green3 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Green_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P3Color = 4 Then
                Do
                    Randomize()
                    yellow3 = Int(Rnd() * 4) + 1
                Loop Until yellow3 <> red1 And yellow3 <> blue1 And yellow3 <> green1 And yellow3 <> yellow1 And yellow3 <> red2 And yellow3 <> blue2 And yellow3 <> green2 And yellow3 <> yellow2 And yellow3 <> red4 And yellow3 <> blue4 And yellow3 <> green4 And yellow3 <> yellow4

                If yellow3 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Yellow_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow3 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Yellow_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow3 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Yellow_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow3 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Yellow_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If

        End If





        If currentState4.IsConnected Then

            If frmMainMenu.P4Color = 1 Then
                Do
                    Randomize()
                    red4 = Int(Rnd() * 4) + 1
                Loop Until red4 <> red1 And red4 <> blue1 And red4 <> green1 And red4 <> yellow1 And red4 <> red2 And red4 <> blue2 And red4 <> green2 And red4 <> yellow2 And red4 <> red3 And red4 <> blue3 And red4 <> green3 And red4 <> yellow3

                If red4 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Red_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf red4 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Red_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf red4 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Red_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf red4 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Red_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P4Color = 2 Then
                Do
                    Randomize()
                    blue4 = Int(Rnd() * 4) + 1
                Loop Until blue4 <> red1 And blue4 <> blue1 And blue4 <> green1 And blue4 <> yellow1 And blue4 <> red2 And blue4 <> blue2 And blue4 <> green2 And blue4 <> yellow2 And blue4 <> red3 And blue4 <> blue3 And blue4 <> green3 And blue4 <> yellow3

                If blue4 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Blue_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf blue4 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Blue_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf blue4 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Blue_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf blue4 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Blue_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P4Color = 3 Then
                Do
                    Randomize()
                    green4 = Int(Rnd() * 4) + 1
                Loop Until green4 <> red1 And green4 <> blue1 And green4 <> green1 And green4 <> yellow1 And green4 <> red2 And green4 <> blue2 And green4 <> green2 And green4 <> yellow2 And green4 <> red3 And green4 <> blue3 And green4 <> green3 And green4 <> yellow3

                If green4 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Green_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf green4 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Green_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf green4 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Green_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf green4 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Green_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If


            If frmMainMenu.P4Color = 4 Then
                Do
                    Randomize()
                    yellow4 = Int(Rnd() * 4) + 1
                Loop Until yellow4 <> red1 And yellow4 <> blue1 And yellow4 <> green1 And yellow4 <> yellow1 And yellow4 <> red2 And yellow4 <> blue2 And yellow4 <> green2 And yellow4 <> yellow2 And yellow4 <> red3 And yellow4 <> blue3 And yellow4 <> green3 And yellow4 <> yellow3

                If yellow4 = 1 Then
                    picSpawnTopLeft.Image = My.Resources.Yellow_Spartan
                    picSpawnTopLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow4 = 2 Then
                    picSpawnTopRight.Image = My.Resources.Yellow_Spartan2
                    picSpawnTopRight.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow4 = 3 Then
                    picSpawnBotLeft.Image = My.Resources.Yellow_Spartan
                    picSpawnBotLeft.BackColor = Drawing.Color.DarkGreen
                ElseIf yellow4 = 4 Then
                    picSpawnBotRight.Image = My.Resources.Yellow_Spartan2
                    picSpawnBotRight.BackColor = Drawing.Color.DarkGreen
                End If
            End If

        End If

        Select Case picSpawnTopLeft.BackColor

            Case Drawing.Color.Red

                picSpawnTopLeft.Visible = False

        End Select

        Select Case picSpawnTopRight.BackColor

            Case Drawing.Color.Red

                picSpawnTopRight.Visible = False

        End Select

        Select Case picSpawnBotLeft.BackColor

            Case Drawing.Color.Red

                picSpawnBotLeft.Visible = False

        End Select

        Select Case picSpawnBotRight.BackColor

            Case Drawing.Color.Red

                picSpawnBotRight.Visible = False

        End Select

        'Select Case frmGameOptions.txtTimeOrLives.Text

        '    Case "1"

        '        Time = 60

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "2"

        '        Time = 120

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "3"

        '        Time = 180

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "4"

        '        Time = 240

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "5"

        '        Time = 300

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "6"

        '        Time = 360

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "7"

        '        Time = 420

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "8"

        '        Time = 480

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "9"

        '        Time = 540

        '        lblGameTimer.Text = GetTime(Time)

        '    Case "10"

        '        Time = 600

        '        lblGameTimer.Text = GetTime(Time)

        'End Select

    End Sub

    Private Sub frmMidship_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Call KeyJumpP1(e)
        Call KeyMoveP1(sender, e)
        Call KeyshootP1(e)

        Call KeyJumpP2(e)
        Call KeyMoveP2(sender, e)
        Call KeyshootP2(e)

    End Sub

    Private Sub frmMidship_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.A Then

            leftDir1 = False

        End If

        If e.KeyCode = Keys.D Then

            rightDir1 = False

        End If

        If e.KeyCode = Keys.L Then

            leftDir2 = False

        End If

        If e.KeyCode = Keys.OemQuotes Then

            rightDir2 = False

        End If

    End Sub

    Private Sub timKeyMove_Tick(sender As Object, e As EventArgs) Handles timKeyMove1.Tick

        'below is player 1 moving left

        If leftDir1 = True And red1 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir1 = True And red1 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir1 = True And red1 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir1 = True And red1 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir1 = True And blue1 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir1 = True And blue1 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir1 = True And blue1 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir1 = True And blue1 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir1 = True And green1 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir1 = True And green1 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir1 = True And green1 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir1 = True And green1 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir1 = True And yellow1 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir1 = True And yellow1 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir1 = True And yellow1 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir1 = True And yellow1 = 4 Then

            picSpawnBotRight.Left -= 15

        End If

        'below is player 1 moving right

        If rightDir1 = True And red1 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir1 = True And red1 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir1 = True And red1 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir1 = True And red1 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir1 = True And blue1 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir1 = True And blue1 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir1 = True And blue1 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir1 = True And blue1 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir1 = True And green1 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir1 = True And green1 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir1 = True And green1 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir1 = True And green1 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir1 = True And yellow1 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir1 = True And yellow1 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir1 = True And yellow1 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir1 = True And yellow1 = 4 Then

            picSpawnBotRight.Left += 15

        End If

    End Sub

    Private Sub timKeyMove2_Tick(sender As Object, e As EventArgs) Handles timKeyMove2.Tick

        'below is player 2 moving left

        If leftDir2 = True And red2 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir2 = True And red2 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir2 = True And red2 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir2 = True And red2 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir2 = True And blue2 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir2 = True And blue2 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir2 = True And blue2 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir2 = True And blue2 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir2 = True And green2 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir2 = True And green2 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir2 = True And green2 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir2 = True And green2 = 4 Then

            picSpawnBotRight.Left -= 15

        End If



        If leftDir2 = True And yellow2 = 1 Then

            picSpawnTopLeft.Left -= 15

        End If

        If leftDir2 = True And yellow2 = 2 Then

            picSpawnTopRight.Left -= 15

        End If

        If leftDir2 = True And yellow2 = 3 Then

            picSpawnBotLeft.Left -= 15

        End If

        If leftDir2 = True And yellow2 = 4 Then

            picSpawnBotRight.Left -= 15

        End If

        'below is player 2 moving right

        If rightDir2 = True And red2 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir2 = True And red2 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir2 = True And red2 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir2 = True And red2 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir2 = True And blue2 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir2 = True And blue2 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir2 = True And blue2 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir2 = True And blue2 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir2 = True And green2 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir2 = True And green2 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir2 = True And green2 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir2 = True And green2 = 4 Then

            picSpawnBotRight.Left += 15

        End If



        If rightDir2 = True And yellow2 = 1 Then

            picSpawnTopLeft.Left += 15

        End If

        If rightDir2 = True And yellow2 = 2 Then

            picSpawnTopRight.Left += 15

        End If

        If rightDir2 = True And yellow2 = 3 Then

            picSpawnBotLeft.Left += 15

        End If

        If rightDir2 = True And yellow2 = 4 Then

            picSpawnBotRight.Left += 15

        End If

    End Sub

    Sub KeyJumpP1(e As KeyEventArgs)

        'below is player 1 jumping

        If lblCountdown.Visible = False Then

            If red1 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If red1 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If red1 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If red1 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If blue1 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If blue1 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If blue1 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If blue1 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If green1 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If green1 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If green1 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If green1 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If yellow1 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If yellow1 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If yellow1 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

            If yellow1 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP1.Stop()

                End If

                If e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP1.Start()

                ElseIf e.KeyCode = Keys.W And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP1.Start()

                End If

            End If

        End If

    End Sub

    Sub KeyJumpP2(e As KeyEventArgs)

        'below is player 2 jumping

        If lblCountdown.Visible = False Then

            If red2 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If red2 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If red2 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If red2 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If blue2 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If blue2 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If blue2 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If blue2 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If green2 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If green2 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If green2 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If green2 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If yellow2 = 1 Then

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                    picSpawnTopLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If yellow2 = 2 Then

                If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                    picSpawnTopRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If yellow2 = 3 Then

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                    picSpawnBotLeft.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

            If yellow2 = 4 Then

                If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                    picSpawnBotRight.Top += 60

                    timJumpedP2.Stop()

                End If

                If e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                    timJumpedP2.Start()

                ElseIf e.KeyCode = Keys.P And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                    timJumpedP2.Start()

                End If

            End If

        End If

    End Sub

    Sub KeyMoveP1(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'below is player 1 moving

        If lblCountdown.Visible = False Then

            If frmMainMenu.P1Color = 1 Then

                If red1 = 1 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If red1 = 2 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If red1 = 3 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If red1 = 4 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

            End If

            If frmMainMenu.P1Color = 2 Then

                If blue1 = 1 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If blue1 = 2 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If blue1 = 3 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If blue1 = 4 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

            End If

            If frmMainMenu.P1Color = 3 Then

                If green1 = 1 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If green1 = 2 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If green1 = 3 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If green1 = 4 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

            End If

            If frmMainMenu.P1Color = 4 Then

                If yellow1 = 1 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If yellow1 = 2 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If yellow1 = 3 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

                If yellow1 = 4 Then

                    If e.KeyCode = Keys.D Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        rightDir1 = True

                        Looking = 1

                    End If

                    If e.KeyCode = Keys.A Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        leftDir1 = True

                        Looking = 2

                    End If

                End If

            End If

        End If

    End Sub

    Sub KeyMoveP2(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'below is player 2 moving

        If lblCountdown.Visible = False Then

            If frmMainMenu.P2Color = 1 Then

                If red2 = 1 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If red2 = 2 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If red2 = 3 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If red2 = 4 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

            End If

            If frmMainMenu.P2Color = 2 Then

                If blue2 = 1 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If blue2 = 2 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If blue2 = 3 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If blue2 = 4 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

            End If

            If frmMainMenu.P2Color = 3 Then

                If green2 = 1 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If green2 = 2 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If green2 = 3 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If green2 = 4 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

            End If

            If frmMainMenu.P2Color = 4 Then

                If yellow2 = 1 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If yellow2 = 2 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If yellow2 = 3 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

                If yellow2 = 4 Then

                    If e.KeyCode = Keys.OemQuotes Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        rightDir2 = True

                        looking2 = 1

                    End If

                    If e.KeyCode = Keys.L Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        leftDir2 = True

                        looking2 = 2

                    End If

                End If

            End If

        End If

    End Sub

    Sub KeyshootP1(e As KeyEventArgs)

        'below is red1 shooting

        If lblCountdown.Visible = False Then

            If red1 = 1 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red1 = 2 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red1 = 3 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red1 = 4 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is blue1 shooting

        If lblCountdown.Visible = False Then

            If blue1 = 1 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue1 = 2 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue1 = 3 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue1 = 4 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is green1 shooting

        If lblCountdown.Visible = False Then

            If green1 = 1 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green1 = 2 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green1 = 3 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green1 = 4 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is yellow1 shooting

        If lblCountdown.Visible = False Then

            If yellow1 = 1 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow1 = 2 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow1 = 3 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow1 = 4 Then

                If picP1Shot1.Visible = False Then

                    If Looking = 1 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                            picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP1Shot2.Visible = False Then

                    If Looking = 2 Then

                        If e.KeyCode = Keys.Space Then

                            picP1Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                            picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Sub KeyshootP2(e As KeyEventArgs)

        'below is red2 shooting

        If lblCountdown.Visible = False Then

            If red2 = 1 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red2 = 2 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red2 = 3 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If red2 = 4 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is blue2 shooting

        If lblCountdown.Visible = False Then

            If blue2 = 1 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue2 = 2 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue2 = 3 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If blue2 = 4 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is green2 shooting

        If lblCountdown.Visible = False Then

            If green2 = 1 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green2 = 2 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green2 = 3 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If green2 = 4 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

        'below is yellow2 shooting

        If lblCountdown.Visible = False Then

            If yellow2 = 1 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow2 = 2 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow2 = 3 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

            If yellow2 = 4 Then

                If picP2Shot1.Visible = False Then

                    If looking2 = 1 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot1.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                            picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                        End If

                    End If

                End If

                If picP2Shot2.Visible = False Then

                    If looking2 = 2 Then

                        If e.KeyCode = Keys.Apps Then

                            picP2Shot2.Show()

                            My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                            picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                            picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub timController1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController1.Tick

        Dim prevy1 As Integer = picSpawnTopLeft.Top
        Dim prevx1 As Integer = picSpawnTopLeft.Left
        Dim prevy2 As Integer = picSpawnTopRight.Top
        Dim prevx2 As Integer = picSpawnTopRight.Left
        Dim prevy3 As Integer = picSpawnBotLeft.Top
        Dim prevx3 As Integer = picSpawnBotLeft.Left
        Dim prevy4 As Integer = picSpawnBotRight.Top
        Dim prevx4 As Integer = picSpawnBotRight.Left

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)

        If lblCountdown.Visible = False Then

            If frmMainMenu.P1Color = 1 Then

                If red1 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If


                If red1 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red1 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red1 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If





        If lblCountdown.Visible = False Then

            If frmMainMenu.P1Color = 2 Then

                If blue1 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If


                If blue1 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue1 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue1 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P1Color = 3 Then

                If green1 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green1 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green1 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green1 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P1Color = 4 Then

                If yellow1 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow1 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnTopRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow1 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotLeft.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow1 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP1.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP1.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP1.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        Looking = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        Looking = 2

                    End If

                    If picP1Shot1.Visible = False Then

                        If Looking = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP1Shot1.Width / 2

                                picP1Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP1Shot2.Visible = False Then

                        If Looking = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP1Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP1Shot2.Left = picSpawnBotRight.Left - picP1Shot2.Width / 2

                                picP1Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP1Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If

        'Spawn Top Left Collision
        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopLeft(picSpawnTopLeft, picTopLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopRight(picSpawnTopLeft, picTopRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidLeft(picSpawnTopLeft, picMidLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidRight(picSpawnTopLeft, picMidRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotLeft(picSpawnTopLeft, picBotLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotRight(picSpawnTopLeft, picBotRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotSBlocker(picSpawnTopLeft, picBotSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBottom(picSpawnTopLeft, picBottom) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If



        'Spawn Top Right Collision
        If TRCollisionTopBlocker(picSpawnTopRight, picTopSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2
        End If

        If TRCollisionTopLeft(picSpawnTopRight, picTopLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionTopRight(picSpawnTopRight, picTopRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidLeft(picSpawnTopRight, picMidLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidRight(picSpawnTopRight, picMidRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotLeft(picSpawnTopRight, picBotLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotRight(picSpawnTopRight, picBotRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotSBlocker(picSpawnTopRight, picBotSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBottom(picSpawnTopRight, picBottom) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If




        'Spawn Bot Left Collision
        If BLCollisionTopBlocker(picSpawnBotLeft, picTopSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3
        End If

        If BLCollisionTopLeft(picSpawnBotLeft, picTopLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionTopRight(picSpawnBotLeft, picTopRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidLeft(picSpawnBotLeft, picMidLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidRight(picSpawnBotLeft, picMidRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotLeft(picSpawnBotLeft, picBotLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotRight(picSpawnBotLeft, picBotRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotSBlocker(picSpawnBotLeft, picBotSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBottom(picSpawnBotLeft, picBottom) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If



        'Spawn Top Right Collision
        If BRCollisionTopBlocker(picSpawnBotRight, picTopSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4
        End If

        If BRCollisionTopLeft(picSpawnBotRight, picTopLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionTopRight(picSpawnBotRight, picTopRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidLeft(picSpawnBotRight, picMidLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidRight(picSpawnBotRight, picMidRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotLeft(picSpawnBotRight, picBotLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotRight(picSpawnBotRight, picBotRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotSBlocker(picSpawnBotRight, picBotSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBottom(picSpawnBotRight, picBottom) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If




        If picP1Shot1.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picMidRight.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picTopRight.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP1Shot1.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP1Shot1.Visible = False

            picP1Shot1.Location = New Drawing.Point(-31415, -31415)

        End If

        If picP1Shot2.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picMidRight.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picTopRight.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP1Shot2.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP1Shot2.Visible = False

            picP1Shot2.Location = New Drawing.Point(-31415, -31415)

        End If



        If picP2Shot1.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picMidRight.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picTopRight.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP2Shot1.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP2Shot1.Visible = False

            picP2Shot1.Location = New Drawing.Point(-31415, -31415)

        End If

        If picP2Shot2.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picMidRight.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picTopRight.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP2Shot2.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP2Shot2.Visible = False

            picP2Shot2.Location = New Drawing.Point(-31415, -31415)

        End If



        If picP3Shot1.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picMidRight.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picTopRight.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP3Shot1.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP3Shot1.Visible = False

            picP3Shot1.Location = New Drawing.Point(-31415, -31415)

        End If

        If picP3Shot2.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picMidRight.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picTopRight.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP3Shot2.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP3Shot2.Visible = False

            picP3Shot2.Location = New Drawing.Point(-31415, -31415)

        End If



        If picP4Shot1.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picBottom.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picMidRight.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picTopRight.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP4Shot1.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP4Shot1.Visible = False

            picP4Shot1.Location = New Drawing.Point(-31415, -31415)

        End If

        If picP4Shot2.Bounds.IntersectsWith(picTopLeft.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picBotLeft.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picBottom.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picMidLeft.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picMidRight.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picTopSBlocker.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picTopRight.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picBotSBlocker.Bounds) Or picP4Shot2.Bounds.IntersectsWith(picBotRight.Bounds) Then

            picP4Shot2.Visible = False

            picP4Shot2.Location = New Drawing.Point(-31415, -31415)

        End If

        If picSpawnTopLeft.Left < Me.ClientRectangle.Left Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top < Me.ClientRectangle.Top Then

            picSpawnTopLeft.Top = prevy1

        End If

        If picSpawnTopLeft.Left + picSpawnTopLeft.Width > Me.ClientRectangle.Right Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top + picSpawnTopLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopLeft.Top = prevy1

        End If





        If picSpawnTopRight.Left < Me.ClientRectangle.Left Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top < Me.ClientRectangle.Top Then

            picSpawnTopRight.Top = prevy2

        End If

        If picSpawnTopRight.Left + picSpawnTopRight.Width > Me.ClientRectangle.Right Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top + picSpawnTopRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopRight.Top = prevy2

        End If




        If picSpawnBotLeft.Left < Me.ClientRectangle.Left Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top < Me.ClientRectangle.Top Then

            picSpawnBotLeft.Top = prevy3

        End If

        If picSpawnBotLeft.Left + picSpawnBotLeft.Width > Me.ClientRectangle.Right Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top + picSpawnBotLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotLeft.Top = prevy3

        End If





        If picSpawnBotRight.Left < Me.ClientRectangle.Left Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top < Me.ClientRectangle.Top Then

            picSpawnBotRight.Top = prevy4

        End If

        If picSpawnBotRight.Left + picSpawnBotRight.Width > Me.ClientRectangle.Right Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top + picSpawnBotRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotRight.Top = prevy4

        End If

    End Sub

    Private Sub timController2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController2.Tick

        Dim prevy1 As Integer = picSpawnTopLeft.Top
        Dim prevx1 As Integer = picSpawnTopLeft.Left
        Dim prevy2 As Integer = picSpawnTopRight.Top
        Dim prevx2 As Integer = picSpawnTopRight.Left
        Dim prevy3 As Integer = picSpawnBotLeft.Top
        Dim prevx3 As Integer = picSpawnBotLeft.Left
        Dim prevy4 As Integer = picSpawnBotRight.Top
        Dim prevx4 As Integer = picSpawnBotRight.Left

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Two)

        If lblCountdown.Visible = False Then

            If frmMainMenu.P2Color = 1 Then

                If red2 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red2 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red2 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red2 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P2Color = 2 Then

                If blue2 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue2 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue2 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue2 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If


            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P2Color = 3 Then

                If green2 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green2 = 2 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green2 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green2 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P2Color = 4 Then

                If yellow2 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow2 = 2 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnTopRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow2 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotLeft.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow2 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP2.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP2.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP2.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking2 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking2 = 2

                    End If

                    If picP2Shot1.Visible = False Then

                        If looking2 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP2Shot1.Width / 2

                                picP2Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP2Shot2.Visible = False Then

                        If looking2 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP2Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP2Shot2.Left = picSpawnBotRight.Left - picP2Shot2.Width / 2

                                picP2Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP2Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If


        'Spawn Top Left Collision
        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopLeft(picSpawnTopLeft, picTopLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopRight(picSpawnTopLeft, picTopRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidLeft(picSpawnTopLeft, picMidLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidRight(picSpawnTopLeft, picMidRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotLeft(picSpawnTopLeft, picBotLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotRight(picSpawnTopLeft, picBotRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotSBlocker(picSpawnTopLeft, picBotSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBottom(picSpawnTopLeft, picBottom) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If



        'Spawn Top Right Collision
        If TRCollisionTopBlocker(picSpawnTopRight, picTopSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2
        End If

        If TRCollisionTopLeft(picSpawnTopRight, picTopLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionTopRight(picSpawnTopRight, picTopRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidLeft(picSpawnTopRight, picMidLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidRight(picSpawnTopRight, picMidRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotLeft(picSpawnTopRight, picBotLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotRight(picSpawnTopRight, picBotRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotSBlocker(picSpawnTopRight, picBotSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBottom(picSpawnTopRight, picBottom) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If




        'Spawn Bot Left Collision
        If BLCollisionTopBlocker(picSpawnBotLeft, picTopSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3
        End If

        If BLCollisionTopLeft(picSpawnBotLeft, picTopLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionTopRight(picSpawnBotLeft, picTopRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidLeft(picSpawnBotLeft, picMidLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidRight(picSpawnBotLeft, picMidRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotLeft(picSpawnBotLeft, picBotLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotRight(picSpawnBotLeft, picBotRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotSBlocker(picSpawnBotLeft, picBotSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBottom(picSpawnBotLeft, picBottom) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If



        'Spawn Top Right Collision
        If BRCollisionTopBlocker(picSpawnBotRight, picTopSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4
        End If

        If BRCollisionTopLeft(picSpawnBotRight, picTopLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionTopRight(picSpawnBotRight, picTopRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidLeft(picSpawnBotRight, picMidLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidRight(picSpawnBotRight, picMidRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotLeft(picSpawnBotRight, picBotLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotRight(picSpawnBotRight, picBotRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotSBlocker(picSpawnBotRight, picBotSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBottom(picSpawnBotRight, picBottom) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnTopLeft.Left < Me.ClientRectangle.Left Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top < Me.ClientRectangle.Top Then

            picSpawnTopLeft.Top = prevy1

        End If

        If picSpawnTopLeft.Left + picSpawnTopLeft.Width > Me.ClientRectangle.Right Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top + picSpawnTopLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopLeft.Top = prevy1

        End If





        If picSpawnTopRight.Left < Me.ClientRectangle.Left Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top < Me.ClientRectangle.Top Then

            picSpawnTopRight.Top = prevy2

        End If

        If picSpawnTopRight.Left + picSpawnTopRight.Width > Me.ClientRectangle.Right Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top + picSpawnTopRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopRight.Top = prevy2

        End If




        If picSpawnBotLeft.Left < Me.ClientRectangle.Left Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top < Me.ClientRectangle.Top Then

            picSpawnBotLeft.Top = prevy3

        End If

        If picSpawnBotLeft.Left + picSpawnBotLeft.Width > Me.ClientRectangle.Right Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top + picSpawnBotLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotLeft.Top = prevy3

        End If





        If picSpawnBotRight.Left < Me.ClientRectangle.Left Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top < Me.ClientRectangle.Top Then

            picSpawnBotRight.Top = prevy4

        End If

        If picSpawnBotRight.Left + picSpawnBotRight.Width > Me.ClientRectangle.Right Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top + picSpawnBotRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotRight.Top = prevy4

        End If
    End Sub

    Private Sub timController3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController3.Tick

        Dim prevy1 As Integer = picSpawnTopLeft.Top
        Dim prevx1 As Integer = picSpawnTopLeft.Left
        Dim prevy2 As Integer = picSpawnTopRight.Top
        Dim prevx2 As Integer = picSpawnTopRight.Left
        Dim prevy3 As Integer = picSpawnBotLeft.Top
        Dim prevx3 As Integer = picSpawnBotLeft.Left
        Dim prevy4 As Integer = picSpawnBotRight.Top
        Dim prevx4 As Integer = picSpawnBotRight.Left

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Three)

        If lblCountdown.Visible = False Then

            If frmMainMenu.P3Color = 1 Then

                If red3 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red3 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red3 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red3 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P3Color = 2 Then

                If blue3 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue3 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue3 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue3 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If


            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P3Color = 3 Or frmMainMenu.P3Color = 0 Then

                If green3 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green3 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green3 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green3 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P3Color = 4 Then

                If yellow3 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow3 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnTopRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow3 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotLeft.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow3 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP3.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP3.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP3.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking3 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking3 = 2

                    End If

                    If picP3Shot1.Visible = False Then

                        If looking3 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP3Shot1.Width / 2

                                picP3Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP3Shot2.Visible = False Then

                        If looking3 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP3Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP3Shot2.Left = picSpawnBotRight.Left - picP3Shot2.Width / 2

                                picP3Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP3Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If


        'Spawn Top Left Collision
        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopLeft(picSpawnTopLeft, picTopLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopRight(picSpawnTopLeft, picTopRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidLeft(picSpawnTopLeft, picMidLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidRight(picSpawnTopLeft, picMidRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotLeft(picSpawnTopLeft, picBotLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotRight(picSpawnTopLeft, picBotRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotSBlocker(picSpawnTopLeft, picBotSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBottom(picSpawnTopLeft, picBottom) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If



        'Spawn Top Right Collision
        If TRCollisionTopBlocker(picSpawnTopRight, picTopSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2
        End If

        If TRCollisionTopLeft(picSpawnTopRight, picTopLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionTopRight(picSpawnTopRight, picTopRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidLeft(picSpawnTopRight, picMidLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidRight(picSpawnTopRight, picMidRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotLeft(picSpawnTopRight, picBotLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotRight(picSpawnTopRight, picBotRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotSBlocker(picSpawnTopRight, picBotSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBottom(picSpawnTopRight, picBottom) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If




        'Spawn Bot Left Collision
        If BLCollisionTopBlocker(picSpawnBotLeft, picTopSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3
        End If

        If BLCollisionTopLeft(picSpawnBotLeft, picTopLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionTopRight(picSpawnBotLeft, picTopRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidLeft(picSpawnBotLeft, picMidLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidRight(picSpawnBotLeft, picMidRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotLeft(picSpawnBotLeft, picBotLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotRight(picSpawnBotLeft, picBotRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotSBlocker(picSpawnBotLeft, picBotSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBottom(picSpawnBotLeft, picBottom) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If



        'Spawn Top Right Collision
        If BRCollisionTopBlocker(picSpawnBotRight, picTopSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4
        End If

        If BRCollisionTopLeft(picSpawnBotRight, picTopLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionTopRight(picSpawnBotRight, picTopRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidLeft(picSpawnBotRight, picMidLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidRight(picSpawnBotRight, picMidRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotLeft(picSpawnBotRight, picBotLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotRight(picSpawnBotRight, picBotRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotSBlocker(picSpawnBotRight, picBotSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBottom(picSpawnBotRight, picBottom) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnTopLeft.Left < Me.ClientRectangle.Left Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top < Me.ClientRectangle.Top Then

            picSpawnTopLeft.Top = prevy1

        End If

        If picSpawnTopLeft.Left + picSpawnTopLeft.Width > Me.ClientRectangle.Right Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top + picSpawnTopLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopLeft.Top = prevy1

        End If





        If picSpawnTopRight.Left < Me.ClientRectangle.Left Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top < Me.ClientRectangle.Top Then

            picSpawnTopRight.Top = prevy2

        End If

        If picSpawnTopRight.Left + picSpawnTopRight.Width > Me.ClientRectangle.Right Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top + picSpawnTopRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopRight.Top = prevy2

        End If




        If picSpawnBotLeft.Left < Me.ClientRectangle.Left Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top < Me.ClientRectangle.Top Then

            picSpawnBotLeft.Top = prevy3

        End If

        If picSpawnBotLeft.Left + picSpawnBotLeft.Width > Me.ClientRectangle.Right Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top + picSpawnBotLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotLeft.Top = prevy3

        End If





        If picSpawnBotRight.Left < Me.ClientRectangle.Left Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top < Me.ClientRectangle.Top Then

            picSpawnBotRight.Top = prevy4

        End If

        If picSpawnBotRight.Left + picSpawnBotRight.Width > Me.ClientRectangle.Right Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top + picSpawnBotRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotRight.Top = prevy4

        End If
    End Sub

    Private Sub timController4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController4.Tick

        Dim prevy1 As Integer = picSpawnTopLeft.Top
        Dim prevx1 As Integer = picSpawnTopLeft.Left
        Dim prevy2 As Integer = picSpawnTopRight.Top
        Dim prevx2 As Integer = picSpawnTopRight.Left
        Dim prevy3 As Integer = picSpawnBotLeft.Top
        Dim prevx3 As Integer = picSpawnBotLeft.Left
        Dim prevy4 As Integer = picSpawnBotRight.Top
        Dim prevx4 As Integer = picSpawnBotRight.Left

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If lblCountdown.Visible = False Then

            If frmMainMenu.P4Color = 1 Then

                If red4 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Red_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red4 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Red_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red4 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Red_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If red4 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Red_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P4Color = 2 Then

                If blue4 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue4 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Blue_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue4 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Blue_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If blue4 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Blue_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking4 = 1

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If


            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P4Color = 3 Then

                If green4 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Green_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green4 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Green_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green4 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Green_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If green4 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Green_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If




        If lblCountdown.Visible = False Then

            If frmMainMenu.P4Color = 4 Or frmMainMenu.P4Color = 0 Then

                If yellow4 = 1 Then

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopLeft.Top < picTopLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopLeft.Top < picTopRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopLeft.Top < picBotLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopLeft.Top < picBotRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopLeft.Top < picMidLeft.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopLeft.Top < picMidRight.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopLeft.Top > picBotSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopLeft.Top > picTopSBlocker.Top Then

                        picSpawnTopLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopLeft.Top And picSpawnTopLeft.Right > picTopLeft.Left And picSpawnTopLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picTopRight.Top And picSpawnTopLeft.Right > picTopRight.Left And picSpawnTopLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotRight.Top And picSpawnTopLeft.Right > picBotRight.Left And picSpawnTopLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidLeft.Top And picSpawnTopLeft.Right > picMidLeft.Left And picSpawnTopLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picMidRight.Top And picSpawnTopLeft.Right > picMidRight.Left And picSpawnTopLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBotSBlocker.Top And picSpawnTopLeft.Right > picBotSBlocker.Left And picSpawnTopLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopLeft.Bottom = picBottom.Top And picSpawnTopLeft.Right > picBottom.Left And picSpawnTopLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopLeft.Left = picSpawnTopLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopLeft.Left + (picSpawnTopLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopLeft.Top + (picSpawnTopLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow4 = 2 Then

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnTopRight.Top < picTopLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnTopRight.Top < picTopRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnTopRight.Top < picBotLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnTopRight.Top < picBotRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnTopRight.Top < picMidLeft.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnTopRight.Top < picMidRight.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnTopRight.Top > picBotSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnTopRight.Top > picTopSBlocker.Top Then

                        picSpawnTopRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopLeft.Top And picSpawnTopRight.Right > picTopLeft.Left And picSpawnTopRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picTopRight.Top And picSpawnTopRight.Right > picTopRight.Left And picSpawnTopRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnTopRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotRight.Top And picSpawnTopRight.Right > picBotRight.Left And picSpawnTopRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidLeft.Top And picSpawnTopRight.Right > picMidLeft.Left And picSpawnTopRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picMidRight.Top And picSpawnTopRight.Right > picMidRight.Left And picSpawnTopRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBotSBlocker.Top And picSpawnTopRight.Right > picBotSBlocker.Left And picSpawnTopRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnTopRight.Bottom = picBottom.Top And picSpawnTopRight.Right > picBottom.Left And picSpawnTopRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan

                        picSpawnTopRight.Left = picSpawnTopRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnTopRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnTopRight.Left = picSpawnTopRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnTopRight.Left + (picSpawnTopRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnTopRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnTopRight.Top + (picSpawnTopRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow4 = 3 Then

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotLeft.Top < picTopLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotLeft.Top < picTopRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotLeft.Top < picBotLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotLeft.Top < picBotRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotLeft.Top < picMidLeft.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotLeft.Top < picMidRight.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotLeft.Top > picBotSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotLeft.Top > picTopSBlocker.Top Then

                        picSpawnBotLeft.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopLeft.Top And picSpawnBotLeft.Right > picTopLeft.Left And picSpawnBotLeft.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picTopRight.Top And picSpawnBotLeft.Right > picTopRight.Left And picSpawnBotLeft.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotLeft.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotRight.Top And picSpawnBotLeft.Right > picBotRight.Left And picSpawnBotLeft.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidLeft.Top And picSpawnBotLeft.Right > picMidLeft.Left And picSpawnBotLeft.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picMidRight.Top And picSpawnBotLeft.Right > picMidRight.Left And picSpawnBotLeft.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBotSBlocker.Top And picSpawnBotLeft.Right > picBotSBlocker.Left And picSpawnBotLeft.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotLeft.Bottom = picBottom.Top And picSpawnBotLeft.Right > picBottom.Left And picSpawnBotLeft.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotLeft.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotLeft.Left = picSpawnBotLeft.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotLeft.Left + (picSpawnBotLeft.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotLeft.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotLeft.Top + (picSpawnBotLeft.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

                If yellow4 = 4 Then

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) And picSpawnBotRight.Top < picTopLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) And picSpawnBotRight.Top < picTopRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) And picSpawnBotRight.Top < picBotLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) And picSpawnBotRight.Top < picBotRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) And picSpawnBotRight.Top < picMidLeft.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) And picSpawnBotRight.Top < picMidRight.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) And picSpawnBotRight.Top > picBotSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) And picSpawnBotRight.Top > picTopSBlocker.Top Then

                        picSpawnBotRight.Top += 60

                        timJumpedP4.Stop()

                    End If

                    If currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopLeft.Top And picSpawnBotRight.Right > picTopLeft.Left And picSpawnBotRight.Left < picTopLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picTopRight.Top And picSpawnBotRight.Right > picTopRight.Left And picSpawnBotRight.Left < picTopRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotLeft.Top And picSpawnBotLeft.Right > picBotLeft.Left And picSpawnBotRight.Left < picBotLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotRight.Top And picSpawnBotRight.Right > picBotRight.Left And picSpawnBotRight.Left < picBotRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidLeft.Top And picSpawnBotRight.Right > picMidLeft.Left And picSpawnBotRight.Left < picMidLeft.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picMidRight.Top And picSpawnBotRight.Right > picMidRight.Left And picSpawnBotRight.Left < picMidRight.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBotSBlocker.Top And picSpawnBotRight.Right > picBotSBlocker.Left And picSpawnBotRight.Left < picBotSBlocker.Right Then

                        timJumpedP4.Start()

                    ElseIf currentState.Buttons.A = ButtonState.Pressed And picSpawnBotRight.Bottom = picBottom.Top And picSpawnBotRight.Right > picBottom.Left And picSpawnBotRight.Left < picBottom.Right Then

                        timJumpedP4.Start()

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X > 0 And currentState.ThumbSticks.Left.X <= 1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan

                        picSpawnBotRight.Left = picSpawnBotRight.Left + 15

                        looking4 = 1

                    End If

                    If currentState.ThumbSticks.Left.X And currentState.ThumbSticks.Left.X < 0 And currentState.ThumbSticks.Left.X >= -1 Then

                        picSpawnBotRight.Image = My.Resources.Yellow_Spartan2

                        picSpawnBotRight.Left = picSpawnBotRight.Left - 15

                        looking4 = 2

                    End If

                    If picP4Shot1.Visible = False Then

                        If looking4 = 1 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot1.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot1.Left = picSpawnBotRight.Left + (picSpawnBotRight.Width) - picP4Shot1.Width / 2

                                picP4Shot1.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot1.Height / 2 - 7

                            End If

                        End If

                    End If

                    If picP4Shot2.Visible = False Then

                        If looking4 = 2 Then

                            If currentState.Triggers.Right = ButtonState.Pressed Then

                                picP4Shot2.Show()

                                My.Computer.Audio.Play(My.Resources.Magnum_Shot, AudioPlayMode.Background)

                                picP4Shot2.Left = picSpawnBotRight.Left - picP4Shot2.Width / 2

                                picP4Shot2.Top = picSpawnBotRight.Top + (picSpawnBotRight.Height / 2) - picP4Shot2.Height / 2 - 7

                            End If

                        End If

                    End If

                End If

            End If

        End If


        'Spawn Top Left Collision
        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopLeft(picSpawnTopLeft, picTopLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopRight(picSpawnTopLeft, picTopRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidLeft(picSpawnTopLeft, picMidLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionMidRight(picSpawnTopLeft, picMidRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotLeft(picSpawnTopLeft, picBotLeft) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotRight(picSpawnTopLeft, picBotRight) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBotSBlocker(picSpawnTopLeft, picBotSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionBottom(picSpawnTopLeft, picBottom) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If

        If TLCollisionTopBlocker(picSpawnTopLeft, picTopSBlocker) = True Then

            picSpawnTopLeft.Top = prevy1
            picSpawnTopLeft.Left = prevx1

        End If



        'Spawn Top Right Collision
        If TRCollisionTopBlocker(picSpawnTopRight, picTopSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2
        End If

        If TRCollisionTopLeft(picSpawnTopRight, picTopLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionTopRight(picSpawnTopRight, picTopRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidLeft(picSpawnTopRight, picMidLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionMidRight(picSpawnTopRight, picMidRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotLeft(picSpawnTopRight, picBotLeft) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotRight(picSpawnTopRight, picBotRight) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBotSBlocker(picSpawnTopRight, picBotSBlocker) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If

        If TRCollisionBottom(picSpawnTopRight, picBottom) = True Then

            picSpawnTopRight.Top = prevy2
            picSpawnTopRight.Left = prevx2

        End If




        'Spawn Bot Left Collision
        If BLCollisionTopBlocker(picSpawnBotLeft, picTopSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3
        End If

        If BLCollisionTopLeft(picSpawnBotLeft, picTopLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionTopRight(picSpawnBotLeft, picTopRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidLeft(picSpawnBotLeft, picMidLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionMidRight(picSpawnBotLeft, picMidRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotLeft(picSpawnBotLeft, picBotLeft) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotRight(picSpawnBotLeft, picBotRight) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBotSBlocker(picSpawnBotLeft, picBotSBlocker) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If

        If BLCollisionBottom(picSpawnBotLeft, picBottom) = True Then

            picSpawnBotLeft.Top = prevy3
            picSpawnBotLeft.Left = prevx3

        End If



        'Spawn Top Right Collision
        If BRCollisionTopBlocker(picSpawnBotRight, picTopSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4
        End If

        If BRCollisionTopLeft(picSpawnBotRight, picTopLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionTopRight(picSpawnBotRight, picTopRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidLeft(picSpawnBotRight, picMidLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionMidRight(picSpawnBotRight, picMidRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotLeft(picSpawnBotRight, picBotLeft) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotRight(picSpawnBotRight, picBotRight) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBotSBlocker(picSpawnBotRight, picBotSBlocker) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If BRCollisionBottom(picSpawnBotRight, picBottom) = True Then

            picSpawnBotRight.Top = prevy4
            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnTopLeft.Left < Me.ClientRectangle.Left Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top < Me.ClientRectangle.Top Then

            picSpawnTopLeft.Top = prevy1

        End If

        If picSpawnTopLeft.Left + picSpawnTopLeft.Width > Me.ClientRectangle.Right Then

            picSpawnTopLeft.Left = prevx1

        End If

        If picSpawnTopLeft.Top + picSpawnTopLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopLeft.Top = prevy1

        End If





        If picSpawnTopRight.Left < Me.ClientRectangle.Left Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top < Me.ClientRectangle.Top Then

            picSpawnTopRight.Top = prevy2

        End If

        If picSpawnTopRight.Left + picSpawnTopRight.Width > Me.ClientRectangle.Right Then

            picSpawnTopRight.Left = prevx2

        End If

        If picSpawnTopRight.Top + picSpawnTopRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnTopRight.Top = prevy2

        End If




        If picSpawnBotLeft.Left < Me.ClientRectangle.Left Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top < Me.ClientRectangle.Top Then

            picSpawnBotLeft.Top = prevy3

        End If

        If picSpawnBotLeft.Left + picSpawnBotLeft.Width > Me.ClientRectangle.Right Then

            picSpawnBotLeft.Left = prevx3

        End If

        If picSpawnBotLeft.Top + picSpawnBotLeft.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotLeft.Top = prevy3

        End If





        If picSpawnBotRight.Left < Me.ClientRectangle.Left Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top < Me.ClientRectangle.Top Then

            picSpawnBotRight.Top = prevy4

        End If

        If picSpawnBotRight.Left + picSpawnBotRight.Width > Me.ClientRectangle.Right Then

            picSpawnBotRight.Left = prevx4

        End If

        If picSpawnBotRight.Top + picSpawnBotRight.Height > Me.ClientRectangle.Bottom Then

            picSpawnBotRight.Top = prevy4

        End If

    End Sub
    'Spawn Top Left Collision
    Private Function TLCollisionTopBlocker(ByVal SpawnTopLeft As PictureBox, ByVal TopBlocker As PictureBox) As Boolean

        If SpawnTopLeft.Top < TopBlocker.Bottom And SpawnTopLeft.Left < TopBlocker.Right And SpawnTopLeft.Bottom > TopBlocker.Top And SpawnTopLeft.Right > TopBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionTopLeft(ByVal SpawnTopLeft As PictureBox, ByVal TopLeft As PictureBox) As Boolean

        If SpawnTopLeft.Top < TopLeft.Bottom And SpawnTopLeft.Left < TopLeft.Right And SpawnTopLeft.Bottom > TopLeft.Top And SpawnTopLeft.Right > TopLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionTopRight(ByVal SpawnTopLeft As PictureBox, ByVal TopRight As PictureBox) As Boolean

        If SpawnTopLeft.Top < TopRight.Bottom And SpawnTopLeft.Left < TopRight.Right And SpawnTopLeft.Bottom > TopRight.Top And SpawnTopLeft.Right > TopRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionMidLeft(ByVal SpawnTopLeft As PictureBox, ByVal MidLeft As PictureBox) As Boolean

        If SpawnTopLeft.Top < MidLeft.Bottom And SpawnTopLeft.Left < MidLeft.Right And SpawnTopLeft.Bottom > MidLeft.Top And SpawnTopLeft.Right > MidLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionMidRight(ByVal SpawnTopLeft As PictureBox, ByVal MidRight As PictureBox) As Boolean

        If SpawnTopLeft.Top < MidRight.Bottom And SpawnTopLeft.Left < MidRight.Right And SpawnTopLeft.Bottom > MidRight.Top And SpawnTopLeft.Right > MidRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionBotLeft(ByVal SpawnTopLeft As PictureBox, ByVal BotLeft As PictureBox) As Boolean

        If SpawnTopLeft.Top < BotLeft.Bottom And SpawnTopLeft.Left < BotLeft.Right And SpawnTopLeft.Bottom > BotLeft.Top And SpawnTopLeft.Right > BotLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionBotRight(ByVal SpawnTopLeft As PictureBox, ByVal BotRight As PictureBox) As Boolean

        If SpawnTopLeft.Top < BotRight.Bottom And SpawnTopLeft.Left < BotRight.Right And SpawnTopLeft.Bottom > BotRight.Top And SpawnTopLeft.Right > BotRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionBotSBlocker(ByVal SpawnTopLeft As PictureBox, ByVal BotSBlocker As PictureBox) As Boolean

        If SpawnTopLeft.Top < BotSBlocker.Bottom And SpawnTopLeft.Left < BotSBlocker.Right And SpawnTopLeft.Bottom > BotSBlocker.Top And SpawnTopLeft.Right > BotSBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TLCollisionBottom(ByVal SpawnTopLeft As PictureBox, ByVal Bottom As PictureBox) As Boolean

        If SpawnTopLeft.Top < Bottom.Bottom And SpawnTopLeft.Left < Bottom.Right And SpawnTopLeft.Bottom > Bottom.Top And SpawnTopLeft.Right > Bottom.Left Then

            Return True

        End If
        Return False

    End Function
    'Spawn Top Right Collision
    Private Function TRCollisionTopBlocker(ByVal SpawnTopRight As PictureBox, ByVal TopBlocker As PictureBox) As Boolean

        If SpawnTopRight.Top < TopBlocker.Bottom And SpawnTopRight.Left < TopBlocker.Right And SpawnTopRight.Bottom > TopBlocker.Top And SpawnTopRight.Right > TopBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionTopLeft(ByVal SpawnTopRight As PictureBox, ByVal TopLeft As PictureBox) As Boolean

        If SpawnTopRight.Top < TopLeft.Bottom And SpawnTopRight.Left < TopLeft.Right And SpawnTopRight.Bottom > TopLeft.Top And SpawnTopRight.Right > TopLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionTopRight(ByVal SpawnTopRight As PictureBox, ByVal TopRight As PictureBox) As Boolean

        If SpawnTopRight.Top < TopRight.Bottom And SpawnTopRight.Left < TopRight.Right And SpawnTopRight.Bottom > TopRight.Top And SpawnTopRight.Right > TopRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionMidLeft(ByVal SpawnTopRight As PictureBox, ByVal MidLeft As PictureBox) As Boolean

        If SpawnTopRight.Top < MidLeft.Bottom And SpawnTopRight.Left < MidLeft.Right And SpawnTopRight.Bottom > MidLeft.Top And SpawnTopRight.Right > MidLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionMidRight(ByVal SpawnTopRight As PictureBox, ByVal MidRight As PictureBox) As Boolean

        If SpawnTopRight.Top < MidRight.Bottom And SpawnTopRight.Left < MidRight.Right And SpawnTopRight.Bottom > MidRight.Top And SpawnTopRight.Right > MidRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionBotLeft(ByVal SpawnTopRight As PictureBox, ByVal BoTReft As PictureBox) As Boolean

        If SpawnTopRight.Top < BoTReft.Bottom And SpawnTopRight.Left < BoTReft.Right And SpawnTopRight.Bottom > BoTReft.Top And SpawnTopRight.Right > BoTReft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionBotRight(ByVal SpawnTopRight As PictureBox, ByVal BotRight As PictureBox) As Boolean

        If SpawnTopRight.Top < BotRight.Bottom And SpawnTopRight.Left < BotRight.Right And SpawnTopRight.Bottom > BotRight.Top And SpawnTopRight.Right > BotRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionBotSBlocker(ByVal SpawnTopRight As PictureBox, ByVal BotSBlocker As PictureBox) As Boolean

        If SpawnTopRight.Top < BotSBlocker.Bottom And SpawnTopRight.Left < BotSBlocker.Right And SpawnTopRight.Bottom > BotSBlocker.Top And SpawnTopRight.Right > BotSBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function TRCollisionBottom(ByVal SpawnTopRight As PictureBox, ByVal Bottom As PictureBox) As Boolean

        If SpawnTopRight.Top < Bottom.Bottom And SpawnTopRight.Left < Bottom.Right And SpawnTopRight.Bottom > Bottom.Top And SpawnTopRight.Right > Bottom.Left Then

            Return True

        End If
        Return False

    End Function
    'Spawn Bot Left Collision
    Private Function BLCollisionTopBlocker(ByVal SpawnBotLeft As PictureBox, ByVal TopBlocker As PictureBox) As Boolean

        If SpawnBotLeft.Top < TopBlocker.Bottom And SpawnBotLeft.Left < TopBlocker.Right And SpawnBotLeft.Bottom > TopBlocker.Top And SpawnBotLeft.Right > TopBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionTopLeft(ByVal SpawnBotLeft As PictureBox, ByVal TopLeft As PictureBox) As Boolean

        If SpawnBotLeft.Top < TopLeft.Bottom And SpawnBotLeft.Left < TopLeft.Right And SpawnBotLeft.Bottom > TopLeft.Top And SpawnBotLeft.Right > TopLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionTopRight(ByVal SpawnBotLeft As PictureBox, ByVal TopRight As PictureBox) As Boolean

        If SpawnBotLeft.Top < TopRight.Bottom And SpawnBotLeft.Left < TopRight.Right And SpawnBotLeft.Bottom > TopRight.Top And SpawnBotLeft.Right > TopRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionMidLeft(ByVal SpawnBotLeft As PictureBox, ByVal MidLeft As PictureBox) As Boolean

        If SpawnBotLeft.Top < MidLeft.Bottom And SpawnBotLeft.Left < MidLeft.Right And SpawnBotLeft.Bottom > MidLeft.Top And SpawnBotLeft.Right > MidLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionMidRight(ByVal SpawnBotLeft As PictureBox, ByVal MidRight As PictureBox) As Boolean

        If SpawnBotLeft.Top < MidRight.Bottom And SpawnBotLeft.Left < MidRight.Right And SpawnBotLeft.Bottom > MidRight.Top And SpawnBotLeft.Right > MidRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionBotLeft(ByVal SpawnBotLeft As PictureBox, ByVal BoTReft As PictureBox) As Boolean

        If SpawnBotLeft.Top < BoTReft.Bottom And SpawnBotLeft.Left < BoTReft.Right And SpawnBotLeft.Bottom > BoTReft.Top And SpawnBotLeft.Right > BoTReft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionBotRight(ByVal SpawnBotLeft As PictureBox, ByVal BotRight As PictureBox) As Boolean

        If SpawnBotLeft.Top < BotRight.Bottom And SpawnBotLeft.Left < BotRight.Right And SpawnBotLeft.Bottom > BotRight.Top And SpawnBotLeft.Right > BotRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionBotSBlocker(ByVal SpawnBotLeft As PictureBox, ByVal BotSBlocker As PictureBox) As Boolean

        If SpawnBotLeft.Top < BotSBlocker.Bottom And SpawnBotLeft.Left < BotSBlocker.Right And SpawnBotLeft.Bottom > BotSBlocker.Top And SpawnBotLeft.Right > BotSBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BLCollisionBottom(ByVal SpawnBotLeft As PictureBox, ByVal Bottom As PictureBox) As Boolean

        If SpawnBotLeft.Top < Bottom.Bottom And SpawnBotLeft.Left < Bottom.Right And SpawnBotLeft.Bottom > Bottom.Top And SpawnBotLeft.Right > Bottom.Left Then

            Return True

        End If
        Return False

    End Function
    'Spawn Bot Right Collision
    Private Function BRCollisionTopBlocker(ByVal SpawnBotRight As PictureBox, ByVal TopBlocker As PictureBox) As Boolean

        If SpawnBotRight.Top < TopBlocker.Bottom And SpawnBotRight.Left < TopBlocker.Right And SpawnBotRight.Bottom > TopBlocker.Top And SpawnBotRight.Right > TopBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionTopLeft(ByVal SpawnBotRight As PictureBox, ByVal TopLeft As PictureBox) As Boolean

        If SpawnBotRight.Top < TopLeft.Bottom And SpawnBotRight.Left < TopLeft.Right And SpawnBotRight.Bottom > TopLeft.Top And SpawnBotRight.Right > TopLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionTopRight(ByVal SpawnBotRight As PictureBox, ByVal TopRight As PictureBox) As Boolean

        If SpawnBotRight.Top < TopRight.Bottom And SpawnBotRight.Left < TopRight.Right And SpawnBotRight.Bottom > TopRight.Top And SpawnBotRight.Right > TopRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionMidLeft(ByVal SpawnBotRight As PictureBox, ByVal MidLeft As PictureBox) As Boolean

        If SpawnBotRight.Top < MidLeft.Bottom And SpawnBotRight.Left < MidLeft.Right And SpawnBotRight.Bottom > MidLeft.Top And SpawnBotRight.Right > MidLeft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionMidRight(ByVal SpawnBotRight As PictureBox, ByVal MidRight As PictureBox) As Boolean

        If SpawnBotRight.Top < MidRight.Bottom And SpawnBotRight.Left < MidRight.Right And SpawnBotRight.Bottom > MidRight.Top And SpawnBotRight.Right > MidRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionBotLeft(ByVal SpawnBotRight As PictureBox, ByVal BoTReft As PictureBox) As Boolean

        If SpawnBotRight.Top < BoTReft.Bottom And SpawnBotRight.Left < BoTReft.Right And SpawnBotRight.Bottom > BoTReft.Top And SpawnBotRight.Right > BoTReft.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionBotRight(ByVal SpawnBotRight As PictureBox, ByVal BotRight As PictureBox) As Boolean

        If SpawnBotRight.Top < BotRight.Bottom And SpawnBotRight.Left < BotRight.Right And SpawnBotRight.Bottom > BotRight.Top And SpawnBotRight.Right > BotRight.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionBotSBlocker(ByVal SpawnBotRight As PictureBox, ByVal BotSBlocker As PictureBox) As Boolean

        If SpawnBotRight.Top < BotSBlocker.Bottom And SpawnBotRight.Left < BotSBlocker.Right And SpawnBotRight.Bottom > BotSBlocker.Top And SpawnBotRight.Right > BotSBlocker.Left Then

            Return True

        End If
        Return False

    End Function

    Private Function BRCollisionBottom(ByVal SpawnBotRight As PictureBox, ByVal Bottom As PictureBox) As Boolean

        If SpawnBotRight.Top < Bottom.Bottom And SpawnBotRight.Left < Bottom.Right And SpawnBotRight.Bottom > Bottom.Top And SpawnBotRight.Right > Bottom.Left Then

            Return True

        End If
        Return False

    End Function

    Private Sub timGrav_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGrav.Tick

        If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) = False And picSpawnTopLeft.Bounds.IntersectsWith(picBottom.Bounds) = False Then

            picSpawnTopLeft.Top += 15

        End If

        If picSpawnTopLeft.Bounds.IntersectsWith(picTopLeft.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picTopRight.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picBotLeft.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picBotRight.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picMidRight.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picMidLeft.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) = True Or picSpawnTopLeft.Bounds.IntersectsWith(picBottom.Bounds) = True Then

            picSpawnTopLeft.Top = picSpawnTopLeft.Top - 15
        End If



        If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) = False And picSpawnTopRight.Bounds.IntersectsWith(picBottom.Bounds) = False Then

            picSpawnTopRight.Top += 15

        End If

        If picSpawnTopRight.Bounds.IntersectsWith(picTopLeft.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picTopRight.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picBotLeft.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picBotRight.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picMidRight.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picMidLeft.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) = True Or picSpawnTopRight.Bounds.IntersectsWith(picBottom.Bounds) = True Then

            picSpawnTopRight.Top = picSpawnTopRight.Top - 15

        End If



        If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) = False And picSpawnBotLeft.Bounds.IntersectsWith(picBottom.Bounds) = False Then

            picSpawnBotLeft.Top += 15

        End If

        If picSpawnBotLeft.Bounds.IntersectsWith(picTopLeft.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picTopRight.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picBotLeft.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picBotRight.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picMidRight.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picMidLeft.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picBotSBlocker.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picTopSBlocker.Bounds) = True Or picSpawnBotLeft.Bounds.IntersectsWith(picBottom.Bounds) = True Then

            picSpawnBotLeft.Top = picSpawnBotLeft.Top - 15

        End If



        If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) = False And picSpawnBotRight.Bounds.IntersectsWith(picBottom.Bounds) = False Then

            picSpawnBotRight.Top += 15

        End If

        If picSpawnBotRight.Bounds.IntersectsWith(picTopLeft.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picTopRight.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picBotLeft.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picBotRight.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picMidRight.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picMidLeft.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picBotSBlocker.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picTopSBlocker.Bounds) = True Or picSpawnBotRight.Bounds.IntersectsWith(picBottom.Bounds) = True Then

            picSpawnBotRight.Top = picSpawnBotRight.Top - 15

        End If

    End Sub

    Private Sub timLives_Tick(sender As Object, e As EventArgs) Handles timLives.Tick

    End Sub

    Public Function GetTime() As String

        Sec = Time Mod 60

        Min = ((Time - Sec) / 60) Mod 60

        Return Format(Min, "0") & ":" & Format(Sec, "00")

    End Function

    Private Sub timGameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGameTimer.Tick

        Time -= 1

    End Sub

    Private Sub timGameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timGameTime.Tick

        Dim TimeCounter As Integer = frmGameOptions.txtTimeOrLives.Text

        Dim currentState1 As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim currentState2 As GamePadState = GamePad.GetState(PlayerIndex.Two)
        Dim currentState3 As GamePadState = GamePad.GetState(PlayerIndex.Three)
        Dim currentState4 As GamePadState = GamePad.GetState(PlayerIndex.Four)

        Mins += 1

        'below is 1 min remaining

        If TimeCounter = 2 And Mins = 1 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 3 And Mins = 2 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 4 And Mins = 3 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 5 And Mins = 4 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 6 And Mins = 5 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 7 And Mins = 6 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 8 And Mins = 7 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 9 And Mins = 8 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        If TimeCounter = 10 And Mins = 9 Then

            My.Computer.Audio.Play(My.Resources._1_Minute_Left, AudioPlayMode.Background)

        End If

        'Below is game over

        If TimeCounter = 1 And Mins = 1 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 2 And Mins = 2 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 3 And Mins = 3 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 4 And Mins = 4 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 5 And Mins = 5 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 6 And Mins = 6 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 7 And Mins = 7 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 8 And Mins = 8 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 9 And Mins = 9 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

        If TimeCounter = 10 And Mins = 10 Then

            Me.Hide()
            frmPostGameStats.Show()

            timGameTime.Stop()

        End If

    End Sub

    Private Sub timShootP1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timShootP1.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)



        picP1Shot1.Left += 30

        picP1Shot2.Left -= 30



        If picP1Shot1.Left + (picP1Shot1.Width) > Me.ClientRectangle.Right Then

            picP1Shot1.Visible = False

        End If

        If picP1Shot2.Left < Me.ClientRectangle.Left Then

            picP1Shot2.Visible = False

        End If





    End Sub

    Private Sub timShootP2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timShootP2.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Two)



        picP2Shot1.Left += 30

        picP2Shot2.Left -= 30



        If picP2Shot1.Left + (picP2Shot1.Width) > Me.ClientRectangle.Right Then

            picP2Shot1.Visible = False

        End If

        If picP2Shot2.Left < Me.ClientRectangle.Left Then

            picP2Shot2.Visible = False

        End If





    End Sub

    Private Sub timShootP3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timShootP3.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Three)



        picP3Shot1.Left += 30

        picP3Shot2.Left -= 30



        If picP3Shot1.Left + (picP3Shot1.Width) > Me.ClientRectangle.Right Then

            picP3Shot1.Visible = False

        End If

        If picP3Shot2.Left < Me.ClientRectangle.Left Then

            picP3Shot2.Visible = False

        End If





    End Sub

    Private Sub timShootP4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timShootP4.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Four)



        picP4Shot1.Left += 30

        picP4Shot2.Left -= 30



        If picP4Shot1.Left + (picP4Shot1.Width) > Me.ClientRectangle.Right Then

            picP4Shot1.Visible = False

        End If

        If picP4Shot2.Left < Me.ClientRectangle.Left Then

            picP4Shot2.Visible = False

        End If





    End Sub

    Private Sub timDeath_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDeath.Tick

        Dim p1respawn As Integer
        Dim p2respawn As Integer
        Dim p3respawn As Integer
        Dim p4respawn As Integer

        lblP1Deaths.Text = "Deaths: " & p1deaths
        lblP2Deaths.Text = "Deaths: " & p2deaths
        lblP3Deaths.Text = "Deaths: " & p3deaths
        lblP4Deaths.Text = "Deaths: " & p4deaths

        lblP1Kills.Text = "Kills: " & p1kills
        lblP2Kills.Text = "Kills: " & p2kills
        lblP3Kills.Text = "Kills: " & p3kills
        lblP4Kills.Text = "Kills: " & p4kills

        If red1 = 1 Or blue1 = 1 Or green1 = 1 Or yellow1 = 1 Then

            If picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red1 = 2 Or blue1 = 2 Or green1 = 2 Or yellow1 = 2 Then

            If picSpawnTopRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If


            If picSpawnTopRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If
        End If

        If red1 = 3 Or blue1 = 3 Or green1 = 3 Or yellow1 = 3 Then

            If picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red1 = 4 Or blue1 = 4 Or green1 = 4 Or yellow1 = 4 Then

            If picSpawnBotRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p1deaths += 1

                Randomize()
                p1respawn = Int(Rnd() * 4) + 1

                If p1respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p1respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p1respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p1respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

        End If









        If red2 = 1 Or blue2 = 1 Or green2 = 1 Or yellow2 = 1 Then

            If picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red2 = 2 Or blue2 = 2 Or green2 = 2 Or yellow2 = 2 Then

            If picSpawnTopRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

        End If

        If red2 = 3 Or blue2 = 3 Or green2 = 3 Or yellow2 = 3 Then

            If picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red2 = 4 Or blue2 = 4 Or green2 = 4 Or yellow2 = 4 Then

            If picSpawnBotRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If


            If picSpawnBotRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p2deaths += 1

                Randomize()
                p2respawn = Int(Rnd() * 4) + 1

                If p2respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p2respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p2respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p2respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If


        End If









        If red3 = 1 Or blue3 = 1 Or green3 = 1 Or yellow3 = 1 Then

            If picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If


            If picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If


            If picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If


        End If

        If red3 = 2 Or blue3 = 2 Or green3 = 2 Or yellow3 = 2 Then

            If picSpawnTopRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If


            If picSpawnTopRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

        End If

        If red3 = 3 Or blue3 = 3 Or green3 = 3 Or yellow3 = 3 Then

            If picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red3 = 4 Or blue3 = 4 Or green3 = 4 Or yellow3 = 4 Then

            If picSpawnBotRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP4Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP4Shot2.Bounds) Then


                p4kills += 1

                p3deaths += 1

                Randomize()
                p3respawn = Int(Rnd() * 4) + 1

                If p3respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p3respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p3respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p3respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

        End If









        If red4 = 1 Or blue4 = 1 Or green4 = 1 Or yellow4 = 1 Then

            If picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopLeft.Top = SpawnPointTop1
                    picSpawnTopLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopLeft.Top = SpawnPointTop2
                    picSpawnTopLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopLeft.Top = SpawnPointTop3
                    picSpawnTopLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopLeft.Top = SpawnPointTop4
                    picSpawnTopLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red4 = 2 Or blue4 = 2 Or green4 = 2 Or yellow4 = 2 Then

            If picSpawnTopRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnTopRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnTopRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnTopRight.Top = SpawnPointTop1
                    picSpawnTopRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnTopRight.Top = SpawnPointTop2
                    picSpawnTopRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnTopRight.Top = SpawnPointTop3
                    picSpawnTopRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnTopRight.Top = SpawnPointTop4
                    picSpawnTopRight.Left = SpawnPointleft4

                End If
            End If

        End If

        If red4 = 3 Or blue4 = 3 Or green4 = 3 Or yellow4 = 3 Then

            If picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotLeft.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotLeft.Top = SpawnPointTop1
                    picSpawnBotLeft.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotLeft.Top = SpawnPointTop2
                    picSpawnBotLeft.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotLeft.Top = SpawnPointTop3
                    picSpawnBotLeft.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotLeft.Top = SpawnPointTop4
                    picSpawnBotLeft.Left = SpawnPointleft4

                End If
            End If

        End If

        If red4 = 4 Or blue4 = 4 Or green4 = 4 Or yellow4 = 4 Then

            If picSpawnBotRight.Bounds.IntersectsWith(picP1Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP1Shot2.Bounds) Then


                p1kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP2Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP2Shot2.Bounds) Then


                p2kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

            If picSpawnBotRight.Bounds.IntersectsWith(picP3Shot1.Bounds) Or picSpawnBotRight.Bounds.IntersectsWith(picP3Shot2.Bounds) Then


                p3kills += 1

                p4deaths += 1

                Randomize()
                p4respawn = Int(Rnd() * 4) + 1

                If p4respawn = 1 Then

                    picSpawnBotRight.Top = SpawnPointTop1
                    picSpawnBotRight.Left = SpawnPointleft1

                End If

                If p4respawn = 2 Then

                    picSpawnBotRight.Top = SpawnPointTop2
                    picSpawnBotRight.Left = SpawnPointleft2

                End If

                If p4respawn = 3 Then

                    picSpawnBotRight.Top = SpawnPointTop3
                    picSpawnBotRight.Left = SpawnPointleft3

                End If

                If p4respawn = 4 Then

                    picSpawnBotRight.Top = SpawnPointTop4
                    picSpawnBotRight.Left = SpawnPointleft4

                End If
            End If

        End If

    End Sub

    Private Sub timMove_Tick(sender As Object, e As EventArgs)

        If picSpawnTopLeft.Top + picSpawnTopLeft.Height >= picTopLeft.Top And picSpawnTopLeft.Top <= picTopLeft.Bottom And picSpawnTopLeft.Left <= picTopLeft.Right And picSpawnTopLeft.Bottom >= picTopLeft.Top And picSpawnTopLeft.Right >= picTopLeft.Left Then

            timGrav.Enabled = False

            If picSpawnTopLeft.Top + picSpawnTopLeft.Height > picTopLeft.Top Then

                picSpawnTopLeft.Top = picTopLeft.Top - picSpawnTopLeft.Height

            End If

        ElseIf red1 = 1 Or red2 = 1 Or red3 = 1 Or red4 = 1 Or blue1 = 1 Or blue2 = 1 Or blue3 = 1 Or blue4 = 1 Or green1 = 1 Or green2 = 1 Or green3 = 1 Or green4 = 1 Or yellow1 = 1 Or yellow2 = 1 Or yellow3 = 1 Or yellow4 = 1 And TLCollisionTopLeft(picSpawnTopLeft, picTopLeft) = False Then

            timGrav.Enabled = True

        End If



        If picSpawnTopLeft.Top + picSpawnTopLeft.Height >= picMidLeft.Top And picSpawnTopLeft.Top <= picMidLeft.Bottom And picSpawnTopLeft.Left <= picMidLeft.Right And picSpawnTopLeft.Bottom >= picMidLeft.Top And picSpawnTopLeft.Right >= picMidLeft.Left Then

            timGrav.Enabled = False

            If picSpawnTopLeft.Top + picSpawnTopLeft.Height > picMidLeft.Top Then

                picSpawnTopLeft.Top = picMidLeft.Top - picSpawnTopLeft.Height

            End If

        ElseIf red1 = 1 Or red2 = 1 Or red3 = 1 Or red4 = 1 Or blue1 = 1 Or blue2 = 1 Or blue3 = 1 Or blue4 = 1 Or green1 = 1 Or green2 = 1 Or green3 = 1 Or green4 = 1 Or yellow1 = 1 Or yellow2 = 1 Or yellow3 = 1 Or yellow4 = 1 And TLCollisionTopLeft(picSpawnTopLeft, picMidLeft) = False Then

            timGrav.Enabled = True

        End If



        If picSpawnTopLeft.Top + picSpawnTopLeft.Height >= picMidRight.Top And picSpawnTopLeft.Top <= picMidRight.Bottom And picSpawnTopLeft.Left <= picMidRight.Right And picSpawnTopLeft.Bottom >= picMidRight.Top And picSpawnTopLeft.Right >= picMidRight.Left Then

            timGrav.Enabled = False

            If picSpawnTopLeft.Top + picSpawnTopLeft.Height > picMidRight.Top Then

                picSpawnTopLeft.Top = picMidRight.Top - picSpawnTopLeft.Height

            End If

        ElseIf red1 = 1 Or red2 = 1 Or red3 = 1 Or red4 = 1 Or blue1 = 1 Or blue2 = 1 Or blue3 = 1 Or blue4 = 1 Or green1 = 1 Or green2 = 1 Or green3 = 1 Or green4 = 1 Or yellow1 = 1 Or yellow2 = 1 Or yellow3 = 1 Or yellow4 = 1 And TLCollisionTopLeft(picSpawnTopLeft, picMidRight) = False Then

            timGrav.Enabled = True

        End If



        If picSpawnTopLeft.Top + picSpawnTopLeft.Height >= picTopRight.Top And picSpawnTopLeft.Top <= picTopRight.Bottom And picSpawnTopLeft.Left <= picTopRight.Right And picSpawnTopLeft.Bottom >= picTopRight.Top And picSpawnTopLeft.Right >= picTopRight.Left Then

            timGrav.Enabled = False

            If picSpawnTopLeft.Top + picSpawnTopLeft.Height > picTopRight.Top Then

                picSpawnTopLeft.Top = picTopRight.Top - picSpawnTopLeft.Height

            End If

        ElseIf red1 = 1 Or red2 = 1 Or red3 = 1 Or red4 = 1 Or blue1 = 1 Or blue2 = 1 Or blue3 = 1 Or blue4 = 1 Or green1 = 1 Or green2 = 1 Or green3 = 1 Or green4 = 1 Or yellow1 = 1 Or yellow2 = 1 Or yellow3 = 1 Or yellow4 = 1 And TLCollisionTopLeft(picSpawnTopLeft, picTopRight) = False Then

            timGrav.Enabled = True

        End If

    End Sub

    Private Sub timJumpedP1_Tick(sender As Object, e As EventArgs) Handles timJumpedP1.Tick

        If red1 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf red1 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf red1 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf red1 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If blue1 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf blue1 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf blue1 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf blue1 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If green1 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf green1 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf green1 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf green1 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If yellow1 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf yellow1 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf yellow1 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf yellow1 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        JumpTimeP1 += 1

        If JumpTimeP1 = 15 Then

            JumpTimeP1 = 0

            timJumpedP1.Stop()

        End If

    End Sub

    Private Sub timJumpedP2_Tick(sender As Object, e As EventArgs) Handles timJumpedP2.Tick

        If red2 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf red2 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf red2 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf red2 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If blue2 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf blue2 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf blue2 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf blue2 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If green2 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf green2 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf green2 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf green2 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If yellow2 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf yellow2 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf yellow2 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf yellow2 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        JumpTimeP2 += 1

        If JumpTimeP2 = 15 Then

            JumpTimeP2 = 0

            timJumpedP2.Stop()

        End If

    End Sub

    Private Sub timJumpedP3_Tick(sender As Object, e As EventArgs) Handles timJumpedP3.Tick

        If red3 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf red3 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf red3 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf red3 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If blue3 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf blue3 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf blue3 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf blue3 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If green3 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf green3 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf green3 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf green3 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If yellow3 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf yellow3 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf yellow3 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf yellow3 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        JumpTimeP3 += 1

        If JumpTimeP3 = 15 Then

            JumpTimeP3 = 0

            timJumpedP3.Stop()

        End If

    End Sub

    Private Sub timJumpedP4_Tick(sender As Object, e As EventArgs) Handles timJumpedP4.Tick

        If red4 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf red4 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf red4 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf red4 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If blue4 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf blue4 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf blue4 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf blue4 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If green4 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf green4 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf green4 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf green4 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        If yellow4 = 1 Then

            picSpawnTopLeft.Top -= 30

        ElseIf yellow4 = 2 Then

            picSpawnTopRight.Top -= 30

        ElseIf yellow4 = 3 Then

            picSpawnBotLeft.Top -= 30

        ElseIf yellow4 = 4 Then

            picSpawnBotRight.Top -= 30

        End If



        JumpTimeP4 += 1

        If JumpTimeP4 = 15 Then

            JumpTimeP4 = 0

            timJumpedP4.Stop()

        End If

    End Sub

End Class
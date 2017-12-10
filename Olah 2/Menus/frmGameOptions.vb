Public Class frmGameOptions

    'false = time
    'true = lives

    Dim blnTimeOrLives As Boolean

    Private Sub timBack_Tick(sender As Object, e As EventArgs) Handles timBack.Tick

        Try

            If txtTimeOrLives.Text > 0 And txtTimeOrLives.Text < 11 Then

                btnBack.Enabled = True

            Else

                btnBack.Enabled = False

            End If

        Catch ex As Exception

            btnBack.Enabled = False

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmGameSetup.Show()
        Me.Hide()

    End Sub

    'Private Sub btnTimeOrLives_Click(sender As Object, e As EventArgs) Handles btnTimeOrLives.Click

    '    If btnTimeOrLives.Text = "Minutes" Then

    '        btnTimeOrLives.Text = "Lives"

    '        blnTimeOrLives = True

    '    ElseIf btnTimeOrLives.Text = "Lives" Then

    '        btnTimeOrLives.Text = "Minutes"

    '        blnTimeOrLives = False

    '    End If

    'End Sub

    Private Sub frmGameOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.Icon

    End Sub

End Class
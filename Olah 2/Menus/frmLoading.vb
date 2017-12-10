Public Class frmLoading

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblLoading.Top = (Me.ClientSize.Height / 2) - (lblLoading.Height / 2)
        lblLoading.Left = (Me.ClientSize.Width / 2) - (lblLoading.Width / 2)

    End Sub

End Class
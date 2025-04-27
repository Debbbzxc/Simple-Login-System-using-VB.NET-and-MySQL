Public Class Form4
    Public Property LoggedInUsername As String
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = $"Welcome {LoggedInUsername}!"

        If Form1.Visible Or Form2.Visible Or Form3.Visible Then
            Me.Close()
        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=root; database=login_db;")

    Public Function ComputeSHA256Hash(ByVal rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query As String = "SELECT role, status FROM users_tbl WHERE username=@username AND password=@password"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtPassword.Text))

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Dim role As String = reader("role").ToString()
                Dim status As String = reader("status").ToString()

                If status = "Reject" Then
                    MessageBox.Show("Sorry, your account has been rejected.", "Account Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    conn.Close()
                    Exit Sub
                ElseIf status = "Pending" Then
                    MessageBox.Show("Your account is currently pending activation. Please wait for admin confirmation.", "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    conn.Close()
                    Exit Sub
                End If

                MessageBox.Show("Login successful", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()

                If role = "Admin" Then
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Form3.Show()
                ElseIf role = "User" Then
                    Form4.LoggedInUsername = txtUsername.Text
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Form4.Show()
                Else
                    MessageBox.Show("Unknown role: " & role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.Visible Or Form3.Visible Or Form4.Visible Then
            Me.Hide()
        End If
    End Sub
End Class

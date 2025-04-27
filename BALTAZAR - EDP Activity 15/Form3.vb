Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim query = "SELECT * FROM users_tbl WHERE id=@id;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=login_db;")
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
                    Using reader = cmd.ExecuteReader
                        If reader.Read Then
                            txtUsername.Text = reader("Username").ToString
                            cbStatus.Text = reader("Status").ToString
                            cbRole.Text = reader("Role").ToString
                            txtUsername.Enabled = True
                            cbStatus.Enabled = True
                            cbRole.Enabled = True
                            btnUpdate.Enabled = True
                        Else
                            MessageBox.Show($"User with ID: {txtID.Text} doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtID.Enabled = True
                            btnFind.Enabled = True
                            txtUsername.Enabled = False
                            cbStatus.Enabled = False
                            cbRole.Enabled = False
                            btnUpdate.Enabled = False
                            txtUsername.Text = ""
                            cbStatus.Text = ""
                            cbRole.Text = ""
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnViewUsers_Click(sender As Object, e As EventArgs) Handles btnViewUsers.Click
        Dim query = "SELECT ID, Username, Status, Role FROM `login_db`.`users_tbl`"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=login_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE users_tbl SET username=@username, status=@status, role=@role WHERE id=@id"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=login_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@role", cbRole.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtID.Enabled = True
                    btnFind.Enabled = True
                    txtUsername.Enabled = False
                    cbStatus.Enabled = False
                    cbRole.Enabled = False
                    btnUpdate.Enabled = False
                    txtID.Text = ""
                    txtUsername.Text = ""
                    cbStatus.Text = ""
                    cbRole.Text = ""
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Visible Or Form2.Visible Or Form4.Visible Then
            Me.Close()
        End If

        txtID.Enabled = True
        btnFind.Enabled = True
        txtUsername.Enabled = False
        cbStatus.Enabled = False
        cbRole.Enabled = False
        btnUpdate.Enabled = False
    End Sub
End Class
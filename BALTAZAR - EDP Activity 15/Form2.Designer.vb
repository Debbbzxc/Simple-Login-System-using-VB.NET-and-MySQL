<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        btnSignup = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        txtConfirmPassword = New TextBox()
        btnBackToLogin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(42, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(249, 37)
        Label4.TabIndex = 15
        Label4.Text = "Create Your Account"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.add_user
        PictureBox1.Location = New Point(93, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 301)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 12
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 11
        Label1.Text = "Username"
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.BlueViolet
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(41, 392)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(250, 42)
        btnSignup.TabIndex = 10
        btnSignup.Text = "Signup"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(42, 319)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(249, 23)
        txtPassword.TabIndex = 9
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(42, 275)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(249, 23)
        txtUsername.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 17
        Label3.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Location = New Point(42, 363)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "•"c
        txtConfirmPassword.Size = New Size(249, 23)
        txtConfirmPassword.TabIndex = 16
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.White
        btnBackToLogin.FlatStyle = FlatStyle.Flat
        btnBackToLogin.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackToLogin.Location = New Point(42, 440)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(250, 42)
        btnBackToLogin.TabIndex = 18
        btnBackToLogin.Text = "Back to Login"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 511)
        Controls.Add(btnBackToLogin)
        Controls.Add(Label3)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSignup)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "Form2"
        Text = "Create Your Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnBackToLogin As Button
End Class

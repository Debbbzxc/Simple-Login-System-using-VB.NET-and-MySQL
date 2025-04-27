<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        txtID = New TextBox()
        btnUpdate = New Button()
        txtUsername = New TextBox()
        Label2 = New Label()
        cbStatus = New ComboBox()
        cbRole = New ComboBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        btnFind = New Button()
        GroupBox1 = New GroupBox()
        btnLogout = New Button()
        GroupBox2 = New GroupBox()
        btnViewUsers = New Button()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(84, 22)
        txtID.Name = "txtID"
        txtID.Size = New Size(103, 23)
        txtID.TabIndex = 2
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.BlueViolet
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(84, 138)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(198, 34)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(84, 51)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(198, 23)
        txtUsername.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 5
        Label2.Text = "ID"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Active", "Pending", "Reject"})
        cbStatus.Location = New Point(84, 80)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(198, 23)
        cbStatus.TabIndex = 6
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Admin", "User"})
        cbRole.Location = New Point(84, 109)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(198, 23)
        cbRole.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.admin_panel
        PictureBox1.Location = New Point(16, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 16
        Label3.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 17
        Label4.Text = "Role"
        ' 
        ' btnFind
        ' 
        btnFind.BackColor = Color.White
        btnFind.FlatStyle = FlatStyle.Flat
        btnFind.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFind.ForeColor = Color.BlueViolet
        btnFind.Location = New Point(193, 22)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(90, 23)
        btnFind.TabIndex = 18
        btnFind.Text = "Find"
        btnFind.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(185, 188)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.BlueViolet
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(12, 535)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(497, 38)
        btnLogout.TabIndex = 20
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtID)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(btnUpdate)
        GroupBox2.Controls.Add(btnFind)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(cbStatus)
        GroupBox2.Controls.Add(cbRole)
        GroupBox2.Location = New Point(203, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(306, 188)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        ' 
        ' btnViewUsers
        ' 
        btnViewUsers.BackColor = Color.White
        btnViewUsers.FlatStyle = FlatStyle.Flat
        btnViewUsers.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewUsers.ForeColor = Color.BlueViolet
        btnViewUsers.Location = New Point(12, 206)
        btnViewUsers.Name = "btnViewUsers"
        btnViewUsers.Size = New Size(497, 23)
        btnViewUsers.TabIndex = 19
        btnViewUsers.Text = "View Users"
        btnViewUsers.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 235)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(497, 294)
        DataGridView1.TabIndex = 22
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 586)
        Controls.Add(DataGridView1)
        Controls.Add(btnViewUsers)
        Controls.Add(GroupBox2)
        Controls.Add(btnLogout)
        Controls.Add(GroupBox1)
        Name = "Form3"
        Text = "Admin Control"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnViewUsers As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

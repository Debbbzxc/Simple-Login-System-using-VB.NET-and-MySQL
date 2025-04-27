<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblWelcome = New Label()
        Label4 = New Label()
        btnLogout = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.work_in_progress
        PictureBox1.Location = New Point(72, 109)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.BlueViolet
        Label1.Location = New Point(178, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 23)
        Label1.TabIndex = 8
        Label1.Text = "Opps!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.BlueViolet
        Label2.Location = New Point(178, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(301, 23)
        Label2.TabIndex = 9
        Label2.Text = "This feature is still work in progress."
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.BlueViolet
        lblWelcome.Location = New Point(12, 28)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(524, 23)
        lblWelcome.TabIndex = 10
        lblWelcome.Text = "Welcome!"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.BlueViolet
        Label4.Location = New Point(12, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(524, 23)
        Label4.TabIndex = 11
        Label4.Text = "______________________________________________________________"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.BlueViolet
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(72, 234)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(407, 44)
        btnLogout.TabIndex = 12
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(546, 302)
        Controls.Add(btnLogout)
        Controls.Add(Label4)
        Controls.Add(lblWelcome)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Welcome!"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogout As Button
End Class

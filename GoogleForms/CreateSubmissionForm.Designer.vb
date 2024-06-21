<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubRepo = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        lblStopwatch = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubRepo = New Label()
        Timer1 = New Timer(components)
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(150, 42)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 88)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(150, 138)
        txtPhoneNumber.Margin = New Padding(3, 4, 3, 4)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(200, 27)
        txtPhoneNumber.TabIndex = 6
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(150, 188)
        txtGitHubRepo.Margin = New Padding(3, 4, 3, 4)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(200, 27)
        txtGitHubRepo.TabIndex = 7
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Goldenrod
        btnToggleStopwatch.Location = New Point(30, 238)
        btnToggleStopwatch.Margin = New Padding(3, 4, 3, 4)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(129, 38)
        btnToggleStopwatch.TabIndex = 8
        btnToggleStopwatch.Text = "Start (Ctrl+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SteelBlue
        btnSubmit.Location = New Point(121, 303)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(140, 38)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit (Ctrl+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(215, 247)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(30, 45)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 91)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(30, 141)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(111, 20)
        lblPhoneNumber.TabIndex = 2
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' lblGitHubRepo
        ' 
        lblGitHubRepo.AutoSize = True
        lblGitHubRepo.Location = New Point(30, 191)
        lblGitHubRepo.Name = "lblGitHubRepo"
        lblGitHubRepo.Size = New Size(98, 20)
        lblGitHubRepo.TabIndex = 3
        lblGitHubRepo.Text = "GitHub Repo:"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(333, 27)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Krish Prasad, Slidely task-2-View Submissions"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 375)
        Controls.Add(TextBox1)
        Controls.Add(lblName)
        Controls.Add(lblEmail)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblGitHubRepo)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtGitHubRepo)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubRepo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class

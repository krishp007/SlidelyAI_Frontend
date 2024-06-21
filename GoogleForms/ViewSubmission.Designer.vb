<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubRepo = New Label()
        lblStopwatch = New Label()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Goldenrod
        btnPrevious.Location = New Point(39, 291)
        btnPrevious.Margin = New Padding(3, 4, 3, 4)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(131, 38)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous (Ctrl+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SteelBlue
        btnNext.Location = New Point(228, 291)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(122, 38)
        btnNext.TabIndex = 1
        btnNext.Text = "Next (Ctrl+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(50, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 2
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(50, 88)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(49, 20)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email:"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(50, 138)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(111, 20)
        lblPhoneNumber.TabIndex = 4
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' lblGitHubRepo
        ' 
        lblGitHubRepo.AutoSize = True
        lblGitHubRepo.Location = New Point(50, 188)
        lblGitHubRepo.Name = "lblGitHubRepo"
        lblGitHubRepo.Size = New Size(98, 20)
        lblGitHubRepo.TabIndex = 5
        lblGitHubRepo.Text = "GitHub Repo:"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(50, 234)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(116, 20)
        lblStopwatch.TabIndex = 6
        lblStopwatch.Text = "Stopwatch Time"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 375)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGitHubRepo)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubRepo As Label
    Friend WithEvents lblStopwatch As Label
End Class

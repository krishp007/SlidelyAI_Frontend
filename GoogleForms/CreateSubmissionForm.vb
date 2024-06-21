Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private stopwatchRunning As Boolean = False

    Public Sub New()
        InitializeComponent()
        ' Enable key preview
        Me.KeyPreview = True
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnSubmit.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            btnToggleStopwatch.Text = "Start"
        Else
            stopwatch.Start()
            btnToggleStopwatch.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            UpdateStopwatchDisplay()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Gather form data
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim gitHubRepo As String = txtGitHubRepo.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        ' Create the submission object
        Dim newSubmission As New With {
            .name = name,
            .email = email,
            .phone = phoneNumber,
            .github_link = gitHubRepo,
            .stopwatch_time = stopwatchTime
        }

        ' Serialize the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(newSubmission)

        ' Post the submission to the backend
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission added successfully!")
            Else
                MessageBox.Show("Failed to add submission.")
            End If
        End Using

        Me.Close()
    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click

    End Sub
End Class

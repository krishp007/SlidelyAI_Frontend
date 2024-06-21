Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0

    Public Sub New()
        InitializeComponent()
        ' Enable key preview
        Me.KeyPreview = True
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetTotalSubmissions()
        If totalSubmissions = 0 Then
            MessageBox.Show("No submissions available.")
            Me.Close()
        Else
            Await ShowSubmission(currentIndex)
            UpdateButtonStates()
        End If
    End Sub

    Private Async Function GetTotalSubmissions() As Task
        Using client As New HttpClient()
            Dim response = Await client.GetAsync("http://localhost:3000/total")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                totalSubmissions = Integer.Parse(json)
            Else
                MessageBox.Show("Error retrieving total submissions count.")
                Me.Close()
            End If
        End Using
    End Function

    Private Async Function ShowSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission = JsonConvert.DeserializeObject(Of Submission)(json)
                lblName.Text = "Name: " & submission.Name
                lblEmail.Text = "Email: " & submission.Email
                lblPhoneNumber.Text = "Phone Number: " & submission.Phone
                lblGitHubRepo.Text = "GitHub Repo: " & submission.Github_link
                lblStopwatch.Text = "StopWatch Time: " & submission.Stopwatch_Time

            Else
                MessageBox.Show("No submission available.")
            End If
        End Using
        UpdateButtonStates()
    End Function

    Private Sub UpdateButtonStates()
        btnPrevious.Enabled = currentIndex > 0
        btnNext.Enabled = currentIndex < totalSubmissions - 1
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await ShowSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnPrevious.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnNext.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property Github_link As String
    Public Property Stopwatch_Time As String
End Class

Imports System.Net.Http

Public Class Form1

    Public Sub New()
        InitializeComponent()
        ' Enable key preview
        Me.KeyPreview = True
    End Sub

    Private Async Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        ' Check if there are any submissions before showing the form
        If Await HasSubmissions() Then
            viewForm.Show()
        Else
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Async Function HasSubmissions() As Task(Of Boolean)
        Using client As New HttpClient()
            Dim response = Await client.GetAsync("http://localhost:3000/total")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim totalSubmissions = Integer.Parse(json)
                Return totalSubmissions > 0
            Else
                MessageBox.Show("Error checking submissions.")
                Return False
            End If
        End Using
    End Function

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnViewSubmissions.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            e.SuppressKeyPress = True ' Prevent default behavior
            btnCreateSubmission.PerformClick()
        End If
    End Sub
End Class

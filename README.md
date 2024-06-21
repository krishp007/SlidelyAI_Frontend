Frontend - Windows Forms Application
Description
This is a Windows Forms application that allows users to create and view submissions with a stopwatch timer.

Features
Create submissions with details such as name, email, phone number, GitHub repository link, and stopwatch time.
View existing submissions.
Navigate through submissions using previous and next buttons.
Keyboard shortcuts for form actions (Ctrl+S to submit, Ctrl+T to toggle stopwatch, Ctrl+V to view submissions, Ctrl+N to create submission).
Prerequisites
.NET Framework (4.8 or later)
Visual Studio (2019 or later)
Setup
Clone the repository:

sh
Copy code
git clone <repository-url>
cd <repository-name>/frontend
Open the project in Visual Studio.

Restore NuGet packages if needed:

sh
Copy code
dotnet restore
Ensure the forms are properly configured and the backend server URL is correct in the code.

Build and run the project.

Usage
Create Submission
Click on "Create Submission" or press Ctrl+N.
Fill in the details.
Start/pause the stopwatch by clicking the "Start" button or pressing Ctrl+T.
Click "Submit" or press Ctrl+S to submit the form.
View Submissions
Click on "View Submissions" or press Ctrl+V.
Navigate through submissions using "Previous" and "Next" buttons or Ctrl+P and Ctrl+N respectively.

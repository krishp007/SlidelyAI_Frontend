

# Frontend - Windows Forms Application

## Description
This is a Windows Forms application that allows users to create and view submissions with a stopwatch timer.

## Features
- Create submissions with details such as name, email, phone number, GitHub repository link, and stopwatch time.
- View existing submissions.
- Navigate through submissions using previous and next buttons.
- Keyboard shortcuts for form actions (Ctrl+S to submit, Ctrl+T to toggle stopwatch, Ctrl+V to view submissions, Ctrl+N to create submission).

## Prerequisites
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (4.8 or later)
- Visual Studio (2019 or later)

## Setup

1. Clone the repository:
    ```sh
    git clone <repository-url>
    cd <repository-name>/frontend
    ```

2. Open the project in Visual Studio.

3. Restore NuGet packages if needed:
    ```sh
    dotnet restore
    ```

4. Ensure the forms are properly configured and the backend server URL is correct in the code.

5. Build and run the project.

## Usage

### Create Submission
1. Click on "Create Submission" or press `Ctrl+N`.
2. Fill in the details.
3. Start/pause the stopwatch by clicking the "Start" button or pressing `Ctrl+T`.
4. Click "Submit" or press `Ctrl+S` to submit the form.

### View Submissions
1. Click on "View Submissions" or press `Ctrl+V`.
2. Navigate through submissions using "Previous" and "Next" buttons or `Ctrl+P` and `Ctrl+N` respectively.


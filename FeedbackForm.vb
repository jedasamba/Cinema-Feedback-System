Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate input
        Dim name As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim movieWatched As String = txtMovieWatched.Text.Trim()
        Dim rating As Integer = Convert.ToInt32(numRating.Value)
        Dim comments As String = txtComments.Text.Trim()

        ' Validate email format (if email is entered)
        If Not String.IsNullOrEmpty(email) AndAlso Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save to database (adjust connection string and query accordingly)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Feedback (Name, Email, MovieWatched, Rating, Comments, CreatedAt) " &
                                  "VALUES (@Name, @Email, @MovieWatched, @Rating, @Comments, @CreatedAt)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", If(String.IsNullOrEmpty(name), DBNull.Value, name))
                command.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(email), DBNull.Value, email))
                command.Parameters.AddWithValue("@MovieWatched", movieWatched)
                command.Parameters.AddWithValue("@Rating", rating)
                command.Parameters.AddWithValue("@Comments", comments)
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now)

                command.ExecuteNonQuery()
            End Using
        End Using

        ' Show confirmation message
        MessageBox.Show("Thank you for your feedback! We appreciate your input and will use it to improve our services.")

        ' Optionally clear form fields or close the form
        ' ClearForm()
    End Sub

    Private Sub btnAdminPortal_Click(sender As Object, e As EventArgs) Handles btnAdminPortal.Click
        ' Prompt for password
        Dim password As String = InputBox("Enter password to access Admin Portal", "Password Required")

        ' Check if the entered password is correct
        If password = "Kmovies@254" Then
            ' Show the Admin Portal form if the password is correct
            Dim adminPortal As New AdminPortal()
            adminPortal.Show()
        Else
            ' Show error message if the password is incorrect
            MessageBox.Show("Incorrect password. Access denied.")
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Simple email validation logic
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern)
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

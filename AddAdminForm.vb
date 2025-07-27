Imports System.Data.SqlClient
Imports System.Configuration
Imports BCrypt.Net

Public Class AddAdminForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Check if username or password fields are empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and password cannot be empty.")
            Return
        End If

        ' Hash the password for secure storage
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Admins (Username, Password) VALUES (@Username, @Password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", hashedPassword)

                    ' Execute the insert command
                    command.ExecuteNonQuery()
                End Using

                ' Notify the user and close the form
                MessageBox.Show("Admin added successfully.")
                Me.Close()
            Catch ex As Exception
                ' Show an error message if something goes wrong
                MessageBox.Show("Error adding admin: " & ex.Message)
            End Try
        End Using
    End Sub
End Class

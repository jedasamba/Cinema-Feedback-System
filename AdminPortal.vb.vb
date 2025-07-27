Imports System.Configuration
Imports System.Data.SqlClient

Public Class AdminPortal
    ' This event fires when the form loads
    Private Sub AdminPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFeedbackData()  ' Load feedback data into DataGridView
        LoadMovieFilters()  ' Load distinct movies into the filter dropdown
        InitializeStatusDropdown()  ' Initialize status dropdown
    End Sub

    ' Method to initialize the status dropdown
    Private Sub InitializeStatusDropdown()
        cmbStatus.Items.AddRange(New String() {"Pending", "Reviewed", "Resolved"})
    End Sub

    ' Method to load feedback data from the database and display it in DataGridView
    Private Sub LoadFeedbackData()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Feedback"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Method to load distinct movies into the filter dropdown
    Private Sub LoadMovieFilters()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT DISTINCT MovieWatched FROM Feedback"
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    cmbFilter.Items.Clear()
                    cmbFilter.Items.Add("All")  ' Add "All" option to show all feedback entries
                    While reader.Read()
                        cmbFilter.Items.Add(reader("MovieWatched").ToString())
                    End While
                End Using
            End Using
        End Using
        cmbFilter.SelectedIndex = 0  ' Default to "All"
    End Sub

    ' Method to save the admin's response to the selected feedback entry
    Private Sub btnSaveResponse_Click(sender As Object, e As EventArgs) Handles btnSaveResponse.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a feedback entry to respond to.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim feedbackId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)
        Dim adminResponse As String = txtAdminResponse.Text.Trim()

        If String.IsNullOrEmpty(adminResponse) Then
            MessageBox.Show("Please enter a response.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Feedback SET AdminResponse = @AdminResponse WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AdminResponse", adminResponse)
                command.Parameters.AddWithValue("@Id", feedbackId)
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Response saved successfully.")
        LoadFeedbackData()  ' Refresh feedback data to show updated response
        txtAdminResponse.Clear()  ' Clear the response text box
    End Sub

    ' Method to filter feedback entries by selected movie
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim filter As String = cmbFilter.SelectedItem.ToString()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Dim query As String
            If filter = "All" Then
                query = "SELECT * FROM Feedback"
            Else
                query = "SELECT * FROM Feedback WHERE MovieWatched = @MovieWatched"
            End If
            Using command As New SqlCommand(query, connection)
                If filter <> "All" Then
                    command.Parameters.AddWithValue("@MovieWatched", filter)
                End If
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        End Using
    End Sub

    ' Method to delete the selected feedback entry
    Private Sub btnDeleteFeedback_Click(sender As Object, e As EventArgs) Handles btnDeleteFeedback.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a feedback entry to delete.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim feedbackId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this feedback entry?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Feedback WHERE Id = @Id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Id", feedbackId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Feedback entry deleted successfully.")
            LoadFeedbackData()  ' Refresh feedback data to show updated list
        End If
    End Sub

    ' Method to update the status of the selected feedback entry
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a feedback entry to update the status.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim feedbackId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)
        Dim newStatus As String = cmbStatus.SelectedItem.ToString()

        If String.IsNullOrEmpty(newStatus) Then
            MessageBox.Show("Please select a status.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Feedback SET Status = @Status WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Status", newStatus)
                command.Parameters.AddWithValue("@Id", feedbackId)
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Status updated successfully.")
        LoadFeedbackData()  ' Refresh feedback data to show updated status
    End Sub

    ' Method to open the Dashboard form
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard As New Dashboard()
        dashboard.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        LoadFeedbackData()  ' Load feedback data into DataGridView
        LoadMovieFilters()  ' Load distinct movies into the filter dropdown
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
End Class

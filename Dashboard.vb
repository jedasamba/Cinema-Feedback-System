Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    ' This event fires when the form loads
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFeedbackData()  ' Load feedback data into DataGridView
        LoadTopRatedMovies()  ' Load top-rated movies into Chart
    End Sub

    ' Method to load feedback data from the database and display it in DataGridView
    Private Sub LoadFeedbackData()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Load all feedback data into the DataGridView
            Dim query As String = "SELECT * FROM Feedback"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dataGridViewFeedback.DataSource = table

            ' Update the total number of feedback entries
            lblTotalFeedback.Text = "Total Feedback: " & table.Rows.Count.ToString()

            ' Calculate pending and resolved feedback counts
            Dim pendingCount As Integer = table.AsEnumerable().Count(Function(row) row.Field(Of String)("Status") = "Pending")
            Dim resolvedCount As Integer = table.AsEnumerable().Count(Function(row) row.Field(Of String)("Status") = "Resolved")

            lblPendingFeedback.Text = "Pending Feedback: " & pendingCount.ToString()
            lblResolvedFeedback.Text = "Resolved Feedback: " & resolvedCount.ToString()
        End Using
    End Sub

    ' Method to load top-rated movies into Chart
    Private Sub LoadTopRatedMovies()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("CinemaFeedbackDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT MovieWatched, AVG(Rating) AS AvgRating FROM Feedback GROUP BY MovieWatched ORDER BY AvgRating DESC"
            Dim command As New SqlCommand(query, connection)
            Using reader As SqlDataReader = command.ExecuteReader()
                chartFeedback.Series.Clear()
                Dim series As New Series("Top Rated Movies")
                series.ChartType = SeriesChartType.Column
                While reader.Read()
                    series.Points.AddXY(reader("MovieWatched").ToString(), Convert.ToDouble(reader("AvgRating")))
                End While
                chartFeedback.Series.Add(series)
            End Using
        End Using
    End Sub

    ' Event handler for the Refresh button click
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadFeedbackData()
        LoadTopRatedMovies()
    End Sub

    ' Event handler for the Back button click
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminPortal.Show()
    End Sub

    ' Event handler for the Add Admin button click
    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Dim addAdminForm As New AddAdminForm()
        addAdminForm.Show()
    End Sub
End Class

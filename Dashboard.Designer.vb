<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        dataGridViewFeedback = New DataGridView()
        lblTitle = New Label()
        btnRefresh = New Button()
        btnBack = New Button()
        chartFeedback = New DataVisualization.Charting.Chart()
        lblTotalFeedback = New Label()
        lblPendingFeedback = New Label()
        lblResolvedFeedback = New Label()
        btnAddAdmin = New Button()
        CType(dataGridViewFeedback, ComponentModel.ISupportInitialize).BeginInit()
        CType(chartFeedback, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridViewFeedback
        ' 
        dataGridViewFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewFeedback.Location = New Point(12, 72)
        dataGridViewFeedback.Name = "dataGridViewFeedback"
        dataGridViewFeedback.Size = New Size(793, 300)
        dataGridViewFeedback.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(344, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(103, 15)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Admin Dashboard"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(446, 526)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(344, 526)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' chartFeedback
        ' 
        ChartArea1.Name = "ChartArea1"
        chartFeedback.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        chartFeedback.Legends.Add(Legend1)
        chartFeedback.Location = New Point(12, 392)
        chartFeedback.Name = "chartFeedback"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chartFeedback.Series.Add(Series1)
        chartFeedback.Size = New Size(311, 240)
        chartFeedback.TabIndex = 5
        chartFeedback.Text = "Chart1"
        ' 
        ' lblTotalFeedback
        ' 
        lblTotalFeedback.AutoSize = True
        lblTotalFeedback.Location = New Point(12, 24)
        lblTotalFeedback.Name = "lblTotalFeedback"
        lblTotalFeedback.Size = New Size(97, 15)
        lblTotalFeedback.TabIndex = 6
        lblTotalFeedback.Text = "Total Feedback: 0"
        ' 
        ' lblPendingFeedback
        ' 
        lblPendingFeedback.AutoSize = True
        lblPendingFeedback.Location = New Point(12, 39)
        lblPendingFeedback.Name = "lblPendingFeedback"
        lblPendingFeedback.Size = New Size(116, 15)
        lblPendingFeedback.TabIndex = 7
        lblPendingFeedback.Text = "Pending Feedback: 0"
        ' 
        ' lblResolvedFeedback
        ' 
        lblResolvedFeedback.AutoSize = True
        lblResolvedFeedback.Location = New Point(12, 54)
        lblResolvedFeedback.Name = "lblResolvedFeedback"
        lblResolvedFeedback.Size = New Size(119, 15)
        lblResolvedFeedback.TabIndex = 8
        lblResolvedFeedback.Text = "Resolved Feedback: 0"
        ' 
        ' btnAddAdmin
        ' 
        btnAddAdmin.Location = New Point(610, 402)
        btnAddAdmin.Name = "btnAddAdmin"
        btnAddAdmin.Size = New Size(114, 23)
        btnAddAdmin.TabIndex = 10
        btnAddAdmin.Text = "Add Admin"
        btnAddAdmin.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        ClientSize = New Size(817, 644)
        Controls.Add(btnAddAdmin)
        Controls.Add(lblResolvedFeedback)
        Controls.Add(lblPendingFeedback)
        Controls.Add(lblTotalFeedback)
        Controls.Add(chartFeedback)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(lblTitle)
        Controls.Add(dataGridViewFeedback)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(dataGridViewFeedback, ComponentModel.ISupportInitialize).EndInit()
        CType(chartFeedback, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dataGridViewFeedback As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents chartFeedback As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblTotalFeedback As System.Windows.Forms.Label
    Friend WithEvents lblPendingFeedback As System.Windows.Forms.Label
    Friend WithEvents lblResolvedFeedback As System.Windows.Forms.Label
    Friend WithEvents btnAddAdmin As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPortal
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
        DataGridView1 = New DataGridView()
        cmbFilter = New ComboBox()
        txtAdminResponse = New TextBox()
        btnSaveResponse = New Button()
        btnDeleteFeedback = New Button()
        btnDashboard = New Button()
        cmbStatus = New ComboBox()
        btnUpdateStatus = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 41)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(842, 281)
        DataGridView1.TabIndex = 0
        ' 
        ' cmbFilter
        ' 
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {"All", "Movie 1", "Movie 2", "Movie 3"})
        cmbFilter.Location = New Point(12, 12)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(121, 23)
        cmbFilter.TabIndex = 1
        ' 
        ' txtAdminResponse
        ' 
        txtAdminResponse.Location = New Point(12, 328)
        txtAdminResponse.Multiline = True
        txtAdminResponse.Name = "txtAdminResponse"
        txtAdminResponse.Size = New Size(207, 100)
        txtAdminResponse.TabIndex = 2
        ' 
        ' btnSaveResponse
        ' 
        btnSaveResponse.Location = New Point(225, 405)
        btnSaveResponse.Name = "btnSaveResponse"
        btnSaveResponse.Size = New Size(75, 23)
        btnSaveResponse.TabIndex = 3
        btnSaveResponse.Text = "Save Response"
        btnSaveResponse.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteFeedback
        ' 
        btnDeleteFeedback.Location = New Point(321, 405)
        btnDeleteFeedback.Name = "btnDeleteFeedback"
        btnDeleteFeedback.Size = New Size(75, 23)
        btnDeleteFeedback.TabIndex = 4
        btnDeleteFeedback.Text = "Delete"
        btnDeleteFeedback.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(451, 390)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(150, 52)
        btnDashboard.TabIndex = 5
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(895, 41)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 6
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Location = New Point(895, 148)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(117, 23)
        btnUpdateStatus.TabIndex = 7
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' AdminPortal
        ' 
        ClientSize = New Size(1157, 469)
        Controls.Add(btnUpdateStatus)
        Controls.Add(cmbStatus)
        Controls.Add(btnDashboard)
        Controls.Add(btnDeleteFeedback)
        Controls.Add(btnSaveResponse)
        Controls.Add(txtAdminResponse)
        Controls.Add(cmbFilter)
        Controls.Add(DataGridView1)
        Name = "AdminPortal"
        Text = "Admin Portal"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtAdminResponse As TextBox
    Friend WithEvents btnSaveResponse As Button
    Friend WithEvents btnDeleteFeedback As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnUpdateStatus As Button
End Class

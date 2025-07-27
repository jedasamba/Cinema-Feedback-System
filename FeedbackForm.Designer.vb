<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnAdminPortal = New Button()
        txtComments = New TextBox()
        txtMovieWatched = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        numRating = New NumericUpDown()
        btnSubmit = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(numRating, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdminPortal
        ' 
        btnAdminPortal.BackColor = Color.RosyBrown
        btnAdminPortal.Dock = DockStyle.Right
        btnAdminPortal.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdminPortal.Location = New Point(620, 0)
        btnAdminPortal.Name = "btnAdminPortal"
        btnAdminPortal.Size = New Size(116, 124)
        btnAdminPortal.TabIndex = 11
        btnAdminPortal.Text = "Admin"
        btnAdminPortal.UseVisualStyleBackColor = False
        ' 
        ' txtComments
        ' 
        txtComments.BackColor = SystemColors.ActiveBorder
        txtComments.Location = New Point(407, 6)
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(210, 88)
        txtComments.TabIndex = 10
        ' 
        ' txtMovieWatched
        ' 
        txtMovieWatched.Location = New Point(363, 23)
        txtMovieWatched.Name = "txtMovieWatched"
        txtMovieWatched.Size = New Size(157, 23)
        txtMovieWatched.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(363, 95)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(157, 23)
        txtEmail.TabIndex = 8
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(363, 33)
        txtName.Name = "txtName"
        txtName.Size = New Size(157, 23)
        txtName.TabIndex = 7
        ' 
        ' numRating
        ' 
        numRating.Location = New Point(400, 92)
        numRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        numRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numRating.Name = "numRating"
        numRating.Size = New Size(120, 23)
        numRating.TabIndex = 6
        numRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.IndianRed
        btnSubmit.Dock = DockStyle.Left
        btnSubmit.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(0, 0)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(133, 124)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(148, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(224, 42)
        Label5.TabIndex = 4
        Label5.Text = "Tell us more on how we can " & vbCrLf & "improve your experience"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(374, 21)
        Label4.TabIndex = 3
        Label4.Text = "How do you Rate the movie (1 poor-5 excellent)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(148, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 2
        Label3.Text = "Movie watched"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(148, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 21)
        Label2.TabIndex = 1
        Label2.Text = "Email(optional)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(145, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 21)
        Label1.TabIndex = 0
        Label1.Text = "Name(optional)"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(736, 100)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Controls.Add(Label7)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 100)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(736, 46)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SlateGray
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(txtName)
        Panel4.Controls.Add(txtEmail)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 146)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(736, 130)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Controls.Add(Label8)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 276)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(736, 39)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.SlateGray
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(txtMovieWatched)
        Panel6.Controls.Add(numRating)
        Panel6.Controls.Add(Label4)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 315)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(736, 127)
        Panel6.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Controls.Add(Label9)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 442)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(736, 47)
        Panel7.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.SlateGray
        Panel8.Controls.Add(Label5)
        Panel8.Controls.Add(txtComments)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 489)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(736, 100)
        Panel8.TabIndex = 7
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.ActiveCaptionText
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 589)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(736, 36)
        Panel9.TabIndex = 8
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.SlateGray
        Panel10.Controls.Add(btnAdminPortal)
        Panel10.Controls.Add(btnSubmit)
        Panel10.Dock = DockStyle.Fill
        Panel10.Location = New Point(0, 625)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(736, 124)
        Panel10.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(314, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(303, 35)
        Label6.TabIndex = 1
        Label6.Text = "MEGA CINEMA FEEDBACK"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonShadow
        Label7.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(262, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(258, 23)
        Label7.TabIndex = 2
        Label7.Text = "PERSONAL INFORMATION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ButtonShadow
        Label8.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(274, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(169, 23)
        Label8.TabIndex = 2
        Label8.Text = "MOVIE FEEDBACK"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ButtonShadow
        Label9.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(351, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 23)
        Label9.TabIndex = 2
        Label9.Text = "COMMENTS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 749)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(numRating, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel10.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numRating As NumericUpDown
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents txtMovieWatched As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdminPortal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class

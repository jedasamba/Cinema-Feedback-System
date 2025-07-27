' Admin.vb
Public Class Admin
    Public Property ID As Integer
    Public Property Username As String

    Public Overrides Function ToString() As String
        Return Username ' This will display the username in the ComboBox
    End Function
End Class

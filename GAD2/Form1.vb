Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        user = TextBox1.Text
        Dim pass As String
        pass = TextBox2.Text
        If user = "user1" And pass = "pass1" Or user = "user2" And pass = "pass2" Then
            MsgBox("Login successful", 0 + 64, "Login Portal")
            Me.Hide()
            Form2.Show()
        Else : MsgBox("Login Unsuccessful. Please try again.")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

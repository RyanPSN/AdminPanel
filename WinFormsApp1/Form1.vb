Public Class Form1

    Private Sub Form1_Load()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim UserName As String = RichTextBox1.Text
        Dim Password As String = RichTextBox2.Text

        If (UserName.Equals("Admin") And Password.Equals("Admin")) Then
            Label1.Text = "Signed In as: " + UserName
            Label2.Text = "Username: " + UserName
            Form2.Show()

        End If

        If (UserName.Equals("User") And Password.Equals("User")) Then
            Label1.Text = "Signed In as: " + UserName
            Label2.Text = "Username: " + UserName
            Form2.Show()

        End If

        If (Not UserName.Equals("Admin") And Not Password.Equals("Admin")) Then

            Label1.Text = "Sorry Can't Sign In As Admin"
        End If




    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

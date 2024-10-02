Public Class Form1

    Private Sub Form1_Load()

    End Sub

    Function Add(ByVal a, ByVal b)
        Return a + b

    End Function

    Function Subtract(ByVal a, ByVal b)
        Return a - b

    End Function



    Function Num()

        Dim M As System.Random = New Random()

        Return M.Next(0, 10)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim UserName As String = RichTextBox1.Text
        Dim Password As String = RichTextBox2.Text

        Dim Num1 = Num()
        Dim Num2 = Num()

        If (UserName.Equals("Admin") And Password.Equals("Admin")) Then
            Label1.Text = "Signed In as: " + UserName
            Label2.Text = "Username: " + UserName
            Form2.Show()

        End If

        If (Not UserName.Equals("Admin") And Not Password.Equals("Admin")) Then


            Label1.Text = "Sorry Can't Sign In Wrong Login"
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

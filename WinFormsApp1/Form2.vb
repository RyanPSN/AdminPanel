Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Hide()
    End Sub
    Public Num1 = Num()
    Public Num2 = Num()
    Public Op = New ArrayList()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Public Function Add(ByVal a, ByVal b)
        Return a + b

    End Function

    Public Function Subtract(ByVal a, ByVal b)
        Return a - b

    End Function


    Public Function Num()

        Dim M As System.Random = New Random()

        Return M.Next(0, 10)

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub RichTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Dim TextBox As Integer = RichTextBox1.Text


        If TextBox.Equals(Add(Num1, Num2)) Then
            Label1.Text = "Correct"

        End If

        If (TextBox.Equals(Subtract(Num1, Num2))) Then
            Label1.Text = "Correct"

        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Label2.Text = Num1 & " + " & Num2

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class
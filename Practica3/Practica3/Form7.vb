Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, i As Integer

        num = Val(TextBox1.Text)

        For i = 1 To num - 1

            num = num * i
        Next

        If num = 0 Then
            num = 1
        End If

        Label2.Text = num

    End Sub
End Class
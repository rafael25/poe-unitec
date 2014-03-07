Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To 100 Step 5
            Me.ListBox1.Items.Add(i)
        Next

        For i = 100 To 0 Step -5
            Me.ListBox2.Items.Add(i)
        Next
    End Sub
End Class
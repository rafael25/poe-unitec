﻿Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contador As Integer
        For contador = 1 To 5
            CheckedListBox1.Items.Add(contador)
        Next
    End Sub
End Class
Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim operacion As String
        Dim text1 As Double
        Dim text2 As Double
        Dim resultado As Double

        operacion = ComboBox1.Text
        text1 = Convert.ToDouble(TextBox1.Text)
        text2 = Convert.ToDouble(TextBox2.Text)

        If operacion = "Suma" Then
            resultado = text1 + text2

        ElseIf operacion = "Resta" Then
            resultado = text1 - text2

        ElseIf operacion = "Multiplicacion" Then
            resultado = text1 * text2

        ElseIf operacion = "Divicion" Then
            resultado = text1 / text2

        End If

        TextBox3.Text = resultado

    End Sub
End Class

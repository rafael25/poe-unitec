Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nombre_text.Text = Nothing Or especialidad_text.Text = Nothing Or grupo_text.Text = Nothing Or sexo_text.Text = Nothing Then
            MsgBox("Debes ingresar tus datos", MsgBoxStyle.Critical)
        Else
            MsgBox("Tus datos se han almacenado correctamente", MsgBoxStyle.Information)
            If especialidad_text.SelectedIndex = 0 Then
                matematicas_form.Show()
            ElseIf especialidad_text.SelectedIndex = 1 Then
                español_form.Show()
            ElseIf especialidad_text.SelectedIndex = 2 Then
                matematicas_form.Show()
            ElseIf especialidad_text.SelectedIndex = 3 Then
                prescolar_form.Show()
            End If
            Me.Hide()
        End If
    End Sub

    Private Sub load_image_Click(sender As Object, e As EventArgs) Handles load_image.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.OpenFile()
        image.ImageLocation = OpenFileDialog1.FileName
        image.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class

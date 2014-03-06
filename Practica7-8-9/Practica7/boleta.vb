Public Class boleta

    Private Sub boleta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = Form1.OpenFileDialog1.FileName
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
Public Class biologia_form
    Dim resultado As Integer

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resultado = 0
        Timer1.Start()

        nombre_lab.Text = "Nombre: " & Form1.nombre_text.Text
        especialidad_lab.Text = "Especialidad: " & Form1.especialidad_text.Text
        grupo_lab.Text = "Grupo: " & Form1.grupo_text.Text

        imagen.ImageLocation = Form1.OpenFileDialog1.FileName
        imagen.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub r1_Click(sender As Object, e As EventArgs) Handles r_1a.Click, r_1b.Click, r_1c.Click
        r_1a.Enabled = False
        r_1b.Enabled = False
        r_1c.Enabled = False
        Timer1.Stop()
        Timer2.Start()

        If sender.Equals(r_1a) Then
            r_1a.Enabled = True
            resultado_1.Text = "Resultado: 0"

        ElseIf sender.Equals(r_1b) Then
            r_1b.Enabled = True
            resultado_1.Text = "Resultado: 0"

        ElseIf sender.Equals(r_1c) Then
            r_1c.Enabled = True
            resultado_1.Text = "Resultado: 1"
            resultado += 1

        Else
            resultado_1.Text = "Resultado: 0"

        End If
    End Sub

    Private Sub r2_Click(sender As Object, e As EventArgs) Handles r_2a.Click, r_2b.Click, r_2c.Click
        r_2a.Enabled = False
        r_2b.Enabled = False
        r_2c.Enabled = False
        Timer2.Stop()

        If sender.Equals(r_2a) Then
            r_2a.Enabled = True
            resultado_2.Text = "Resultado: 0"

        ElseIf sender.Equals(r_2b) Then
            r_2b.Enabled = True
            resultado_2.Text = "Resultado: 1"
            resultado += 1

        ElseIf sender.Equals(r_2c) Then
            r_2c.Enabled = True
            resultado_2.Text = "Resultado: 0"

        Else
            resultado_2.Text = "Resultado: 0"

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            r1_Click(sender, e)
        Else
            ProgressBar1.PerformStep()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            r2_Click(sender, e)
        Else
            ProgressBar2.PerformStep()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        boleta.lb_nombre.Text = "Nombre: " & Form1.nombre_text.Text
        boleta.lb_especialidad.Text = "Especialidad: " & Form1.especialidad_text.Text
        boleta.lb_grupo.Text = "Grupo: " & Form1.grupo_text.Text
        boleta.lb_sexo.Text = "Sexo: " & Form1.sexo_text.Text
        boleta.lb_resultado.Text = "Resultado: " & resultado

        boleta.Show()
        Me.Hide()
    End Sub
End Class
Public Class Form1
    Private Sub activar_Click(sender As Object, e As EventArgs) Handles activar.Click
        If suma.Checked = True Then
            resultado.Text = "Resultado: " & Single.Parse(TextBox1.Text) + Single.Parse(TextBox2.Text)
        ElseIf resta.Checked = True Then
            resultado.Text = "Resultado: " & Single.Parse(TextBox1.Text) - Single.Parse(TextBox2.Text)
        ElseIf divicion.Checked = True Then
            resultado.Text = "Resultado: " & Single.Parse(TextBox1.Text) / Single.Parse(TextBox2.Text)
        ElseIf multiplicacion.Checked Then
            resultado.Text = "Resultado: " & Single.Parse(TextBox1.Text) * Single.Parse(TextBox2.Text)
        End If
    End Sub

    Private Sub depurar_Click(sender As Object, e As EventArgs) Handles depurar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        suma.Checked = False
        resta.Checked = False
        divicion.Checked = False
        multiplicacion.Checked = False
    End Sub

    Private Sub suma_CheckedChanged(sender As Object, e As EventArgs) Handles suma.CheckedChanged
        If suma.Checked = True Then
            resta.Checked = False
            divicion.Checked = False
            multiplicacion.Checked = False
        End If
    End Sub

    Private Sub resta_CheckedChanged(sender As Object, e As EventArgs) Handles resta.CheckedChanged
        If resta.Checked = True Then
            suma.Checked = False
            divicion.Checked = False
            multiplicacion.Checked = False
        End If
    End Sub

    Private Sub divicion_CheckedChanged(sender As Object, e As EventArgs) Handles divicion.CheckedChanged
        If divicion.Checked = True Then
            suma.Checked = False
            resta.Checked = False
            multiplicacion.Checked = False
        End If
    End Sub

    Private Sub multiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles multiplicacion.CheckedChanged
        If multiplicacion.Checked = True Then
            suma.Checked = False
            divicion.Checked = False
            resta.Checked = False
        End If
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Application.Exit()
    End Sub
End Class

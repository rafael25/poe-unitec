Public Class Form1

    Private Sub Calc_btn_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim factorial As Integer
        Dim i As Integer

        factorial = Val(datos.Text)

        For i = 1 To factorial - 1
            factorial *= i
        Next

        If factorial = 0 Then
            factorial = 1
        End If

        resultado.Text = "Resultado: " & factorial

        datos.Enabled = False
        calcular.Enabled = False
        cargar.Enabled = True
        salir.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calcular.Enabled = False
        cargar.Enabled = False
        salir.Enabled = False
    End Sub

    Private Sub Datos_TextChanged(sender As Object, e As EventArgs) Handles datos.TextChanged
        calcular.Enabled = True
    End Sub

    Private Sub cargar_Click(sender As Object, e As EventArgs) Handles cargar.Click
        datos.Clear()
        datos.Enabled = True
        calcular.Enabled = False
        cargar.Enabled = False
        salir.Enabled = False
        resultado.Text = "Resultado: "
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class

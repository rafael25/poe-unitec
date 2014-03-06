Public Class Form2
    Dim sueldo As Single
    Dim bonificacion As Single
    Dim descuento As Single

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        sueldo = 0
        bonificacion = 0
        descuento = 0

        If _sueldo.Checked Then
            sueldo = Single.Parse(sueldo_text.Text)
        End If

        If _bonificacion.Checked Then
            bonificacion = Single.Parse(bonificacion_text.Text)
        End If

        If _descuento.Checked Then
            descuento = Single.Parse(descuento_text.Text)
        End If

        resultado.Text = sueldo + bonificacion - descuento
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
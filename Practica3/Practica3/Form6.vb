Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a, i, num As Integer

        num = Val(InputBox("Ingresa el dato"))

        For i = 1 To 10
            a = num * 1

            MsgBox("Tabla de multiplicar para: " & num & Microsoft.VisualBasic.vbCrLf & num & " * " & i)

            ListBox1.Items.Add(num & " * " & i & " = " & a)
        Next i

        Me.Show()
    End Sub
End Class
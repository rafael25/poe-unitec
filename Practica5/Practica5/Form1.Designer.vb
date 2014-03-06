<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.datos = New System.Windows.Forms.TextBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.cargar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'datos
        '
        Me.datos.Location = New System.Drawing.Point(158, 109)
        Me.datos.Name = "datos"
        Me.datos.Size = New System.Drawing.Size(100, 20)
        Me.datos.TabIndex = 0
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(26, 55)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 1
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'cargar
        '
        Me.cargar.Location = New System.Drawing.Point(30, 132)
        Me.cargar.Name = "cargar"
        Me.cargar.Size = New System.Drawing.Size(75, 23)
        Me.cargar.TabIndex = 2
        Me.cargar.Text = "Cargar"
        Me.cargar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(30, 213)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 3
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Location = New System.Drawing.Point(158, 179)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(58, 13)
        Me.resultado.TabIndex = 4
        Me.resultado.Text = "Resultado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.cargar)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.datos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datos As System.Windows.Forms.TextBox
    Friend WithEvents calcular As System.Windows.Forms.Button
    Friend WithEvents cargar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents resultado As System.Windows.Forms.Label

End Class

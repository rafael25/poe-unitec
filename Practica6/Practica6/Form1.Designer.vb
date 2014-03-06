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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.multiplicacion = New System.Windows.Forms.CheckBox()
        Me.divicion = New System.Windows.Forms.CheckBox()
        Me.resta = New System.Windows.Forms.CheckBox()
        Me.suma = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.activar = New System.Windows.Forms.Button()
        Me.depurar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.multiplicacion)
        Me.GroupBox1.Controls.Add(Me.divicion)
        Me.GroupBox1.Controls.Add(Me.resta)
        Me.GroupBox1.Controls.Add(Me.suma)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'multiplicacion
        '
        Me.multiplicacion.AutoSize = True
        Me.multiplicacion.Location = New System.Drawing.Point(7, 92)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.multiplicacion.TabIndex = 3
        Me.multiplicacion.Text = "Multiplicacion"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'divicion
        '
        Me.divicion.AutoSize = True
        Me.divicion.Location = New System.Drawing.Point(7, 68)
        Me.divicion.Name = "divicion"
        Me.divicion.Size = New System.Drawing.Size(64, 17)
        Me.divicion.TabIndex = 2
        Me.divicion.Text = "Divicion"
        Me.divicion.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(7, 44)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(54, 17)
        Me.resta.TabIndex = 1
        Me.resta.Text = "Resta"
        Me.resta.UseVisualStyleBackColor = True
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(7, 20)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(53, 17)
        Me.suma.TabIndex = 0
        Me.suma.Text = "Suma"
        Me.suma.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese un dígito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese un dígito"
        '
        'activar
        '
        Me.activar.Location = New System.Drawing.Point(83, 189)
        Me.activar.Name = "activar"
        Me.activar.Size = New System.Drawing.Size(75, 23)
        Me.activar.TabIndex = 5
        Me.activar.Text = "Activar"
        Me.activar.UseVisualStyleBackColor = True
        '
        'depurar
        '
        Me.depurar.Location = New System.Drawing.Point(164, 189)
        Me.depurar.Name = "depurar"
        Me.depurar.Size = New System.Drawing.Size(75, 23)
        Me.depurar.TabIndex = 6
        Me.depurar.Text = "Depurar"
        Me.depurar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(245, 189)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 7
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Location = New System.Drawing.Point(13, 152)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(58, 13)
        Me.resultado.TabIndex = 8
        Me.resultado.Text = "Resultado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 224)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.depurar)
        Me.Controls.Add(Me.activar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents multiplicacion As System.Windows.Forms.CheckBox
    Friend WithEvents divicion As System.Windows.Forms.CheckBox
    Friend WithEvents resta As System.Windows.Forms.CheckBox
    Friend WithEvents suma As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents activar As System.Windows.Forms.Button
    Friend WithEvents depurar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents resultado As System.Windows.Forms.Label

End Class

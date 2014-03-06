<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me._sueldo = New System.Windows.Forms.CheckBox()
        Me._bonificacion = New System.Windows.Forms.CheckBox()
        Me._descuento = New System.Windows.Forms.CheckBox()
        Me.sueldo_text = New System.Windows.Forms.TextBox()
        Me.bonificacion_text = New System.Windows.Forms.TextBox()
        Me.descuento_text = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_sueldo
        '
        Me._sueldo.AutoSize = True
        Me._sueldo.Location = New System.Drawing.Point(13, 69)
        Me._sueldo.Name = "_sueldo"
        Me._sueldo.Size = New System.Drawing.Size(59, 17)
        Me._sueldo.TabIndex = 0
        Me._sueldo.Text = "Sueldo"
        Me._sueldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._sueldo.UseVisualStyleBackColor = True
        '
        '_bonificacion
        '
        Me._bonificacion.AutoSize = True
        Me._bonificacion.Location = New System.Drawing.Point(13, 113)
        Me._bonificacion.Name = "_bonificacion"
        Me._bonificacion.Size = New System.Drawing.Size(84, 17)
        Me._bonificacion.TabIndex = 1
        Me._bonificacion.Text = "Bonificacion"
        Me._bonificacion.UseVisualStyleBackColor = True
        '
        '_descuento
        '
        Me._descuento.AutoSize = True
        Me._descuento.Location = New System.Drawing.Point(13, 157)
        Me._descuento.Name = "_descuento"
        Me._descuento.Size = New System.Drawing.Size(78, 17)
        Me._descuento.TabIndex = 2
        Me._descuento.Text = "Descuento"
        Me._descuento.UseVisualStyleBackColor = True
        '
        'sueldo_text
        '
        Me.sueldo_text.Location = New System.Drawing.Point(100, 67)
        Me.sueldo_text.Name = "sueldo_text"
        Me.sueldo_text.Size = New System.Drawing.Size(172, 20)
        Me.sueldo_text.TabIndex = 3
        '
        'bonificacion_text
        '
        Me.bonificacion_text.Location = New System.Drawing.Point(100, 111)
        Me.bonificacion_text.Name = "bonificacion_text"
        Me.bonificacion_text.Size = New System.Drawing.Size(172, 20)
        Me.bonificacion_text.TabIndex = 4
        '
        'descuento_text
        '
        Me.descuento_text.Location = New System.Drawing.Point(100, 155)
        Me.descuento_text.Name = "descuento_text"
        Me.descuento_text.Size = New System.Drawing.Size(172, 20)
        Me.descuento_text.TabIndex = 5
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(100, 211)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(172, 20)
        Me.resultado.TabIndex = 6
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(13, 208)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 7
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.descuento_text)
        Me.Controls.Add(Me.bonificacion_text)
        Me.Controls.Add(Me.sueldo_text)
        Me.Controls.Add(Me._descuento)
        Me.Controls.Add(Me._bonificacion)
        Me.Controls.Add(Me._sueldo)
        Me.Name = "Form2"
        Me.Text = "Trabajando con controles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _sueldo As System.Windows.Forms.CheckBox
    Friend WithEvents _bonificacion As System.Windows.Forms.CheckBox
    Friend WithEvents _descuento As System.Windows.Forms.CheckBox
    Friend WithEvents sueldo_text As System.Windows.Forms.TextBox
    Friend WithEvents bonificacion_text As System.Windows.Forms.TextBox
    Friend WithEvents descuento_text As System.Windows.Forms.TextBox
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents calcular As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boleta
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.lb_especialidad = New System.Windows.Forms.Label()
        Me.lb_grupo = New System.Windows.Forms.Label()
        Me.lb_sexo = New System.Windows.Forms.Label()
        Me.lb_resultado = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 144)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lb_nombre
        '
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.Location = New System.Drawing.Point(169, 13)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(50, 13)
        Me.lb_nombre.TabIndex = 1
        Me.lb_nombre.Text = "Nombre: "
        '
        'lb_especialidad
        '
        Me.lb_especialidad.AutoSize = True
        Me.lb_especialidad.Location = New System.Drawing.Point(169, 59)
        Me.lb_especialidad.Name = "lb_especialidad"
        Me.lb_especialidad.Size = New System.Drawing.Size(73, 13)
        Me.lb_especialidad.TabIndex = 2
        Me.lb_especialidad.Text = "Especialidad: "
        '
        'lb_grupo
        '
        Me.lb_grupo.AutoSize = True
        Me.lb_grupo.Location = New System.Drawing.Point(169, 105)
        Me.lb_grupo.Name = "lb_grupo"
        Me.lb_grupo.Size = New System.Drawing.Size(42, 13)
        Me.lb_grupo.TabIndex = 3
        Me.lb_grupo.Text = "Grupo: "
        '
        'lb_sexo
        '
        Me.lb_sexo.AutoSize = True
        Me.lb_sexo.Location = New System.Drawing.Point(172, 151)
        Me.lb_sexo.Name = "lb_sexo"
        Me.lb_sexo.Size = New System.Drawing.Size(37, 13)
        Me.lb_sexo.TabIndex = 4
        Me.lb_sexo.Text = "Sexo: "
        '
        'lb_resultado
        '
        Me.lb_resultado.AutoSize = True
        Me.lb_resultado.Location = New System.Drawing.Point(13, 189)
        Me.lb_resultado.Name = "lb_resultado"
        Me.lb_resultado.Size = New System.Drawing.Size(61, 13)
        Me.lb_resultado.TabIndex = 5
        Me.lb_resultado.Text = "Resultado: "
        '
        'boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 229)
        Me.Controls.Add(Me.lb_resultado)
        Me.Controls.Add(Me.lb_sexo)
        Me.Controls.Add(Me.lb_grupo)
        Me.Controls.Add(Me.lb_especialidad)
        Me.Controls.Add(Me.lb_nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "boleta"
        Me.Text = "Boleta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lb_nombre As System.Windows.Forms.Label
    Friend WithEvents lb_especialidad As System.Windows.Forms.Label
    Friend WithEvents lb_grupo As System.Windows.Forms.Label
    Friend WithEvents lb_sexo As System.Windows.Forms.Label
    Friend WithEvents lb_resultado As System.Windows.Forms.Label
End Class

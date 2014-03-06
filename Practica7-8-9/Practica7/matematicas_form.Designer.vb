<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class matematicas_form
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
        Me.components = New System.ComponentModel.Container()
        Me.nombre_lab = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grupo_lab = New System.Windows.Forms.Label()
        Me.especialidad_lab = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.r_1a = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.resultado_1 = New System.Windows.Forms.Label()
        Me.r_1c = New System.Windows.Forms.Button()
        Me.r_1b = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.resultado_2 = New System.Windows.Forms.Label()
        Me.r_2c = New System.Windows.Forms.Button()
        Me.r_2b = New System.Windows.Forms.Button()
        Me.r_2a = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'nombre_lab
        '
        Me.nombre_lab.AutoSize = True
        Me.nombre_lab.Location = New System.Drawing.Point(6, 29)
        Me.nombre_lab.Name = "nombre_lab"
        Me.nombre_lab.Size = New System.Drawing.Size(47, 13)
        Me.nombre_lab.TabIndex = 0
        Me.nombre_lab.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grupo_lab)
        Me.GroupBox1.Controls.Add(Me.especialidad_lab)
        Me.GroupBox1.Controls.Add(Me.nombre_lab)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'grupo_lab
        '
        Me.grupo_lab.AutoSize = True
        Me.grupo_lab.Location = New System.Drawing.Point(590, 29)
        Me.grupo_lab.Name = "grupo_lab"
        Me.grupo_lab.Size = New System.Drawing.Size(36, 13)
        Me.grupo_lab.TabIndex = 2
        Me.grupo_lab.Text = "Grupo"
        '
        'especialidad_lab
        '
        Me.especialidad_lab.AutoSize = True
        Me.especialidad_lab.Location = New System.Drawing.Point(362, 29)
        Me.especialidad_lab.Name = "especialidad_lab"
        Me.especialidad_lab.Size = New System.Drawing.Size(67, 13)
        Me.especialidad_lab.TabIndex = 1
        Me.especialidad_lab.Text = "Especialidad"
        '
        'imagen
        '
        Me.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagen.Location = New System.Drawing.Point(597, 85)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(126, 110)
        Me.imagen.TabIndex = 2
        Me.imagen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Debes de comprender los temas de este bloque"
        '
        'r_1a
        '
        Me.r_1a.Location = New System.Drawing.Point(9, 28)
        Me.r_1a.Name = "r_1a"
        Me.r_1a.Size = New System.Drawing.Size(126, 23)
        Me.r_1a.TabIndex = 4
        Me.r_1a.Text = "a) Sistema Digestivo"
        Me.r_1a.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.resultado_1)
        Me.GroupBox2.Controls.Add(Me.r_1c)
        Me.GroupBox2.Controls.Add(Me.r_1b)
        Me.GroupBox2.Controls.Add(Me.r_1a)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 64)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "1. Sistema biológico utilizado por seres vivos para inalar y exalar oxigeno"
        '
        'resultado_1
        '
        Me.resultado_1.AutoSize = True
        Me.resultado_1.Location = New System.Drawing.Point(485, 33)
        Me.resultado_1.Name = "resultado_1"
        Me.resultado_1.Size = New System.Drawing.Size(58, 13)
        Me.resultado_1.TabIndex = 7
        Me.resultado_1.Text = "Resultado:"
        '
        'r_1c
        '
        Me.r_1c.Location = New System.Drawing.Point(318, 28)
        Me.r_1c.Name = "r_1c"
        Me.r_1c.Size = New System.Drawing.Size(133, 23)
        Me.r_1c.TabIndex = 6
        Me.r_1c.Text = "c) Sistema Respiratorio"
        Me.r_1c.UseVisualStyleBackColor = True
        '
        'r_1b
        '
        Me.r_1b.Location = New System.Drawing.Point(160, 28)
        Me.r_1b.Name = "r_1b"
        Me.r_1b.Size = New System.Drawing.Size(133, 23)
        Me.r_1b.TabIndex = 5
        Me.r_1b.Text = "b) Sistema Nervioso"
        Me.r_1b.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.resultado_2)
        Me.GroupBox3.Controls.Add(Me.r_2c)
        Me.GroupBox3.Controls.Add(Me.r_2b)
        Me.GroupBox3.Controls.Add(Me.r_2a)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(578, 79)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2. Los seres vivos se pueden clasificar en flora y ..."
        '
        'resultado_2
        '
        Me.resultado_2.AutoSize = True
        Me.resultado_2.Location = New System.Drawing.Point(485, 43)
        Me.resultado_2.Name = "resultado_2"
        Me.resultado_2.Size = New System.Drawing.Size(55, 13)
        Me.resultado_2.TabIndex = 3
        Me.resultado_2.Text = "Resultado"
        '
        'r_2c
        '
        Me.r_2c.Location = New System.Drawing.Point(318, 33)
        Me.r_2c.Name = "r_2c"
        Me.r_2c.Size = New System.Drawing.Size(96, 23)
        Me.r_2c.TabIndex = 2
        Me.r_2c.Text = "c) Aire"
        Me.r_2c.UseVisualStyleBackColor = True
        '
        'r_2b
        '
        Me.r_2b.Location = New System.Drawing.Point(160, 33)
        Me.r_2b.Name = "r_2b"
        Me.r_2b.Size = New System.Drawing.Size(101, 23)
        Me.r_2b.TabIndex = 1
        Me.r_2b.Text = "b) Fauna"
        Me.r_2b.UseVisualStyleBackColor = True
        '
        'r_2a
        '
        Me.r_2a.Location = New System.Drawing.Point(9, 33)
        Me.r_2a.Name = "r_2a"
        Me.r_2a.Size = New System.Drawing.Size(87, 23)
        Me.r_2a.TabIndex = 0
        Me.r_2a.Text = "a) Tierra"
        Me.r_2a.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 212)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(579, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(13, 337)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(579, 10)
        Me.ProgressBar2.TabIndex = 8
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(631, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Mostrar Boleta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'matematicas_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 387)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "matematicas_form"
        Me.Text = "Matemáticas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nombre_lab As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grupo_lab As System.Windows.Forms.Label
    Friend WithEvents especialidad_lab As System.Windows.Forms.Label
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents r_1a As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents r_1c As System.Windows.Forms.Button
    Friend WithEvents r_1b As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents r_2c As System.Windows.Forms.Button
    Friend WithEvents r_2b As System.Windows.Forms.Button
    Friend WithEvents resultado_1 As System.Windows.Forms.Label
    Friend WithEvents resultado_2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents r_2a As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

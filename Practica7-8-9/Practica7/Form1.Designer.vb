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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sexo_text = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grupo_text = New System.Windows.Forms.ComboBox()
        Me.especialidad_text = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre_text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.load_image = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.sexo_text)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.grupo_text)
        Me.GroupBox1.Controls.Add(Me.especialidad_text)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nombre_text)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Captura de Datos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cargar los datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sexo"
        '
        'sexo_text
        '
        Me.sexo_text.FormattingEnabled = True
        Me.sexo_text.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.sexo_text.Location = New System.Drawing.Point(103, 170)
        Me.sexo_text.Name = "sexo_text"
        Me.sexo_text.Size = New System.Drawing.Size(121, 21)
        Me.sexo_text.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Grupo"
        '
        'grupo_text
        '
        Me.grupo_text.FormattingEnabled = True
        Me.grupo_text.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.grupo_text.Location = New System.Drawing.Point(103, 125)
        Me.grupo_text.Name = "grupo_text"
        Me.grupo_text.Size = New System.Drawing.Size(121, 21)
        Me.grupo_text.TabIndex = 4
        '
        'especialidad_text
        '
        Me.especialidad_text.FormattingEnabled = True
        Me.especialidad_text.Items.AddRange(New Object() {"Biología", "Españo", "Matematicas", "Prescolar"})
        Me.especialidad_text.Location = New System.Drawing.Point(103, 80)
        Me.especialidad_text.Name = "especialidad_text"
        Me.especialidad_text.Size = New System.Drawing.Size(121, 21)
        Me.especialidad_text.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Especialidad"
        '
        'nombre_text
        '
        Me.nombre_text.Location = New System.Drawing.Point(103, 36)
        Me.nombre_text.Name = "nombre_text"
        Me.nombre_text.Size = New System.Drawing.Size(263, 20)
        Me.nombre_text.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'image
        '
        Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image.Location = New System.Drawing.Point(13, 13)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(153, 140)
        Me.image.TabIndex = 1
        Me.image.TabStop = False
        '
        'load_image
        '
        Me.load_image.Location = New System.Drawing.Point(13, 179)
        Me.load_image.Name = "load_image"
        Me.load_image.Size = New System.Drawing.Size(153, 23)
        Me.load_image.TabIndex = 2
        Me.load_image.Text = "Selccionar imagen"
        Me.load_image.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 254)
        Me.Controls.Add(Me.load_image)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sexo_text As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grupo_text As System.Windows.Forms.ComboBox
    Friend WithEvents especialidad_text As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre_text As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents load_image As System.Windows.Forms.Button

End Class

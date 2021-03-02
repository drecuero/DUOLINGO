<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_user1 = New System.Windows.Forms.TextBox()
        Me.txt_pass1 = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user1
        '
        Me.txt_user1.Location = New System.Drawing.Point(39, 126)
        Me.txt_user1.Name = "txt_user1"
        Me.txt_user1.Size = New System.Drawing.Size(150, 20)
        Me.txt_user1.TabIndex = 0
        '
        'txt_pass1
        '
        Me.txt_pass1.Location = New System.Drawing.Point(39, 165)
        Me.txt_pass1.Name = "txt_pass1"
        Me.txt_pass1.Size = New System.Drawing.Size(150, 20)
        Me.txt_pass1.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(39, 207)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(150, 23)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Ingresar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "¿Olvidaste tu Contraseña?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PROYECTOTERE.My.Resources.Resources.Screenshot_4
        Me.PictureBox1.Location = New System.Drawing.Point(63, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 308)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pass1)
        Me.Controls.Add(Me.txt_user1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_user1 As TextBox
    Friend WithEvents txt_pass1 As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

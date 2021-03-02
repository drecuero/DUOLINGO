<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtContra = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chk_Basic = New System.Windows.Forms.CheckBox()
        Me.Chk_Admin = New System.Windows.Forms.CheckBox()
        Me.Chk_Premium = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(28, 105)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(175, 20)
        Me.TxtUser.TabIndex = 1
        '
        'TxtContra
        '
        Me.TxtContra.Location = New System.Drawing.Point(28, 153)
        Me.TxtContra.Name = "TxtContra"
        Me.TxtContra.Size = New System.Drawing.Size(175, 20)
        Me.TxtContra.TabIndex = 2
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(58, 196)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(108, 27)
        Me.Register.TabIndex = 3
        Me.Register.Text = "Registro"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "¿Ya tienes una cuenta? Inicia Sesión"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PROYECTOTERE.My.Resources.Resources.Screenshot_5
        Me.PictureBox1.Location = New System.Drawing.Point(-33, -18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 86)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña:"
        '
        'Chk_Basic
        '
        Me.Chk_Basic.AutoSize = True
        Me.Chk_Basic.Location = New System.Drawing.Point(83, 242)
        Me.Chk_Basic.Name = "Chk_Basic"
        Me.Chk_Basic.Size = New System.Drawing.Size(58, 17)
        Me.Chk_Basic.TabIndex = 8
        Me.Chk_Basic.Text = "Basico"
        Me.Chk_Basic.UseVisualStyleBackColor = True
        '
        'Chk_Admin
        '
        Me.Chk_Admin.AutoSize = True
        Me.Chk_Admin.Location = New System.Drawing.Point(12, 242)
        Me.Chk_Admin.Name = "Chk_Admin"
        Me.Chk_Admin.Size = New System.Drawing.Size(55, 17)
        Me.Chk_Admin.TabIndex = 9
        Me.Chk_Admin.Text = "Admin"
        Me.Chk_Admin.UseVisualStyleBackColor = True
        '
        'Chk_Premium
        '
        Me.Chk_Premium.AutoSize = True
        Me.Chk_Premium.Location = New System.Drawing.Point(155, 242)
        Me.Chk_Premium.Name = "Chk_Premium"
        Me.Chk_Premium.Size = New System.Drawing.Size(66, 17)
        Me.Chk_Premium.TabIndex = 10
        Me.Chk_Premium.Text = "Premium"
        Me.Chk_Premium.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 304)
        Me.Controls.Add(Me.Chk_Premium)
        Me.Controls.Add(Me.Chk_Admin)
        Me.Controls.Add(Me.Chk_Basic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.TxtContra)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtContra As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chk_Basic As CheckBox
    Friend WithEvents Chk_Admin As CheckBox
    Friend WithEvents Chk_Premium As CheckBox
End Class

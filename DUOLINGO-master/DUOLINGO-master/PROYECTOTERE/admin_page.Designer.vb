<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_page
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_User2 = New System.Windows.Forms.TextBox()
        Me.Txt_Pass2 = New System.Windows.Forms.TextBox()
        Me.Txt_Valor = New System.Windows.Forms.TextBox()
        Me.Btn_Leer = New System.Windows.Forms.Button()
        Me.Btn_Modify = New System.Windows.Forms.Button()
        Me.Btn_borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN"
        '
        'Txt_User2
        '
        Me.Txt_User2.Location = New System.Drawing.Point(117, 78)
        Me.Txt_User2.Name = "Txt_User2"
        Me.Txt_User2.Size = New System.Drawing.Size(189, 20)
        Me.Txt_User2.TabIndex = 1
        '
        'Txt_Pass2
        '
        Me.Txt_Pass2.Location = New System.Drawing.Point(117, 113)
        Me.Txt_Pass2.Name = "Txt_Pass2"
        Me.Txt_Pass2.Size = New System.Drawing.Size(189, 20)
        Me.Txt_Pass2.TabIndex = 2
        '
        'Txt_Valor
        '
        Me.Txt_Valor.Location = New System.Drawing.Point(117, 152)
        Me.Txt_Valor.Name = "Txt_Valor"
        Me.Txt_Valor.Size = New System.Drawing.Size(189, 20)
        Me.Txt_Valor.TabIndex = 3
        '
        'Btn_Leer
        '
        Me.Btn_Leer.Location = New System.Drawing.Point(41, 192)
        Me.Btn_Leer.Name = "Btn_Leer"
        Me.Btn_Leer.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Leer.TabIndex = 4
        Me.Btn_Leer.Text = "Leer"
        Me.Btn_Leer.UseVisualStyleBackColor = True
        '
        'Btn_Modify
        '
        Me.Btn_Modify.Location = New System.Drawing.Point(180, 192)
        Me.Btn_Modify.Name = "Btn_Modify"
        Me.Btn_Modify.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Modify.TabIndex = 5
        Me.Btn_Modify.Text = "Modificar"
        Me.Btn_Modify.UseVisualStyleBackColor = True
        '
        'Btn_borrar
        '
        Me.Btn_borrar.Location = New System.Drawing.Point(307, 192)
        Me.Btn_borrar.Name = "Btn_borrar"
        Me.Btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_borrar.TabIndex = 6
        Me.Btn_borrar.Text = "Eliminar"
        Me.Btn_borrar.UseVisualStyleBackColor = True
        '
        'admin_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 245)
        Me.Controls.Add(Me.Btn_borrar)
        Me.Controls.Add(Me.Btn_Modify)
        Me.Controls.Add(Me.Btn_Leer)
        Me.Controls.Add(Me.Txt_Valor)
        Me.Controls.Add(Me.Txt_Pass2)
        Me.Controls.Add(Me.Txt_User2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "admin_page"
        Me.Text = "admin_page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_User2 As TextBox
    Friend WithEvents Txt_Pass2 As TextBox
    Friend WithEvents Txt_Valor As TextBox
    Friend WithEvents Btn_Leer As Button
    Friend WithEvents Btn_Modify As Button
    Friend WithEvents Btn_borrar As Button
End Class

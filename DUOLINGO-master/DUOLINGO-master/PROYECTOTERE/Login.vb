Imports System.IO

Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mail.Show()
        Me.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim Leer As New StreamReader("usuarios.txt", True)
        btn_login.Enabled = False
        Dim CarLeido As Integer
        Dim usuario_txt As String = ""
        Dim pass_txt As String = ""
        Dim valor As Integer

        CarLeido = Leer.Read
        Do While Not (CarLeido = -1)
            Do While Not Chr(CarLeido) = ";"
                usuario_txt = usuario_txt & Chr(CarLeido)
                CarLeido = Leer.Read
            Loop
            CarLeido = Leer.Read
            Do While Not Chr(CarLeido) = ";"
                pass_txt = pass_txt & Chr(CarLeido)
                CarLeido = Leer.Read
            Loop
            CarLeido = Leer.Read
            Do While Not Chr(CarLeido) = ";"
                valor = Integer.Parse(Chr(CarLeido))
                CarLeido = Leer.Read
            Loop
            CarLeido = Leer.Read
        Loop

        MessageBox.Show("Final archivo")
        btn_login.Enabled = True
        Leer.Close()
        If usuario_txt.Equals(txt_user1.Text) And pass_txt.Equals(txt_pass1.Text) Then
            CarLeido = -1 & MessageBox.Show("Bienvenido " & usuario_txt)
            If valor = 1 Then
                MessageBox.Show("Eres Admin")
                admin_page.Show()
                Me.Hide()

            ElseIf valor = 2 Then
                MessageBox.Show("Eres Basico")
            Else
                MessageBox.Show("Eres Premium")
            End If

        Else
            usuario_txt = "" & pass_txt = ""
        End If
    End Sub
End Class
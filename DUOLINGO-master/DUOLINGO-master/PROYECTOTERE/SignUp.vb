Imports System.IO

Public Class SignUp

    Dim Usuario As String
    Dim Password As String
    Dim valor As Byte
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim Escribir As New StreamWriter("usuarios.txt", True)
        Usuario = TxtUser.Text
        Password = TxtContra.Text

        If Chk_Admin.Checked = True Then
            valor = 1
        ElseIf Chk_Basic.Checked = True Then
            valor = 2
        ElseIf Chk_Premium.Checked = True Then
            valor = 3
            MessageBox.Show("Disfruta de las ventajas Premium!!", "Premium", MessageBoxButtons.OK)
        Else valor = 0


        End If

        Escribir.Write(Usuario & ";" & Password & ";" & valor & ";")
        TxtUser.Text = ""
        TxtContra.Text = ""
        Escribir.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Basic.CheckedChanged

    End Sub
End Class
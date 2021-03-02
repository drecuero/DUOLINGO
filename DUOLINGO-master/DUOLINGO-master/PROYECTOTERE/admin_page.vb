Imports System.IO

Public Class admin_page
    Dim user As String
    Dim passw As String
    Dim valor As String
    Dim varlarga As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Modify.Click
        Dim Leer As New StreamReader("usuarios.txt", True)
        Dim CarLeido As Integer

        CarLeido = Leer.Read
        Do While Not (CarLeido = -1)
            varlarga = varlarga & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop
        Leer.Close()


        Do While Chr(varlarga) = ";"
            user = user & Chr(varlarga)
            If user.Equals(Txt_User2) Then
                Do While Chr(varlarga) = ";"

                Loop
                Do While Chr(varlarga) = ";"

                Loop
            End If
        Loop



        Do While Not Chr(CarLeido) = ";"
            passw = passw & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop

        Do While Not Chr(CarLeido) = ";"
            valor = valor & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Leer.Click
        Dim Leer As New StreamReader("usuarios.txt", True)
        user = Txt_User2.Text
        passw = Txt_Pass2.Text
        valor = Txt_Valor.Text

        Dim CarLeido As Integer

        CarLeido = Leer.Read

        Do While Not Chr(CarLeido) = ";"
            user = user & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop

        Txt_User2.Text = user
        CarLeido = Leer.Read

        Do While Not Chr(CarLeido) = ";"
            passw = passw & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop

        Do While Not Chr(CarLeido) = ";"
            valor = valor & Chr(CarLeido)
            CarLeido = Leer.Read
        Loop


    End Sub
End Class
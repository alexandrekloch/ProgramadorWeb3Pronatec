Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, ef As EventArgs) Handles Button1.Click
        Dim valor As String = TextBox1.Text
        Dim contador As Integer
        Dim teste As Char
        Dim soma, index As Integer
        Dim temp As Double



        contador = valor.Length()

        For index = 0 To contador - 1
            teste = valor.Substring(index)

            If teste = "a" Then
                soma = soma + 1
            End If

            If teste = "b" Then
                soma = soma + 2
            End If

            If teste = "c" Then
                soma = soma + 3
            End If

            If teste = "d" Then
                soma = soma + 4
            End If

            If teste = "e" Then
                soma = soma + 5
            End If

            If teste = "f" Then
                soma = soma + 6
            End If

            If teste = "g" Then
                soma = soma + 7
            End If

            If teste = "h" Then
                soma = soma + 8
            End If

            If teste = "i" Then
                soma = soma + 9
            End If

            If teste = "j" Then
                soma = soma + 10
            End If

            If teste = "k" Then
                soma = soma + 11
            End If

            If teste = "l" Then
                soma = soma + 12
            End If

            If teste = "m" Then
                soma = soma + 13
            End If

            If teste = "n" Then
                soma = soma + 14
            End If

            If teste = "o" Then
                soma = soma + 15
            End If

            If teste = "p" Then
                soma = soma + 16
            End If

            If teste = "q" Then
                soma = soma + 17
            End If

            If teste = "r" Then
                soma = soma + 18
            End If

            If teste = "s" Then
                soma = soma + 19
            End If

            If teste = "t" Then
                soma = soma + 20
            End If

            If teste = "u" Then
                soma = soma + 21
            End If

            If teste = "v" Then
                soma = soma + 22
            End If

            If teste = "w" Then
                soma = soma + 23
            End If

            If teste = "x" Then
                soma = soma + 24
            End If

            If teste = "y" Then
                soma = soma + 25
            End If

            If teste = "z" Then
                soma = soma + 26
            End If

        Next

        Label1.Text = soma
        Label2.Text = "Numero é primo"
        index = 2


        While index < soma
            temp = soma Mod index
            If temp = 0 And index <> soma Then
                Label2.Text = "Numero não é primo"
                index = soma + 1
            End If

            index = index + 1

        End While







    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
Public Class CondicionalSe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saldo As Decimal = 50.0
        Dim saque As Decimal = TextBox1.Text
        Dim limite As Decimal = 100.0
        Dim L As New Literal()
        If saldo >= saque Then
            L.Text = "Retire seu Dinheiro!!!"
        Else
            If (saldo + limite) >= saque Then
                L.Text = "Dinheiro liberado com o uso do limite!"
            Else
                L.Text = "Saldo insuficiente!!! Tente um Valor menor!"
            End If


        End If
        form1.Controls.Add(L)


    End Sub
End Class
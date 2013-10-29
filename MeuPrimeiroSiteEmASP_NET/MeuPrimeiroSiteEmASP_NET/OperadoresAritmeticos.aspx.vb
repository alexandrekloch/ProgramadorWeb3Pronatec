Public Class OperadoresAritmeticos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "+"

        lblResultado.Text = valor1 + valor2
    End Sub

    Protected Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "-"

        lblResultado.Text = valor1 - valor2
    End Sub

    Protected Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "*"

        lblResultado.Text = valor1 * valor2
    End Sub

    Protected Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "/"

        lblResultado.Text = valor1 / valor2
    End Sub

    Protected Sub bntParteIntDiv_Click(sender As Object, e As EventArgs) Handles bntParteIntDiv.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "\"

        lblResultado.Text = valor1 \ valor2
    End Sub

    Protected Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "Mod"

        lblResultado.Text = valor1 Mod valor2
    End Sub

    Protected Sub btnPotenciacao_Click(sender As Object, e As EventArgs) Handles btnPotenciacao.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = "^"

        lblResultado.Text = valor1 ^ valor2
    End Sub
End Class
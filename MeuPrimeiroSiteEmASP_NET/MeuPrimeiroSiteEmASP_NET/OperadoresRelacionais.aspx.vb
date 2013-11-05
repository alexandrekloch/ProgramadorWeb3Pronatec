Public Class OperadoresRelacionais
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnMaiorQue_Click(sender As Object, e As EventArgs) Handles btnMaiorQue.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text

        lblOperador.Text = " > "

        lblResultado.Text = valor1 > valor2
    End Sub
End Class
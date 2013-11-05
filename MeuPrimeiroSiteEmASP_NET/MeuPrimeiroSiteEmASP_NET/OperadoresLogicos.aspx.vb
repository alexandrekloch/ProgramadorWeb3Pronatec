Public Class OperadoresLogicos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim valor1 As Integer = txtValor1.Text
        Dim valor2 As Integer = txtValor2.Text
        Dim valor3 As Integer = txtValor3.Text
        Dim valor4 As Integer = txtValor4.Text
        lblPrimeira.Text = (valor1 > valor2)
        lblSegunda.Text = (valor3 > valor4)

        lblresultado.Text = (valor1 > valor2) And (valor3 > valor4)

    End Sub

    Protected Sub btnNao_Click(sender As Object, e As EventArgs) Handles btnNao.Click

        Try
            Dim valor1 As Boolean = lblresultado.Text
            lblresultado.Text = Not (valor1)
        Catch ex As Exception
            lblresultado.Text = "Execute uma Operação AND ou OR primeiro!"
        End Try





    End Sub
End Class
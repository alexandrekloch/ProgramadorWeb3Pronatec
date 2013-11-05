Public Class ExercicioCondicionaisSe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Entra de Dados
        Dim nota1 As Decimal = txtNota1.Text
        Dim nota2 As Decimal = txtNota2.Text
        Dim nota3 As Decimal = txtNota3.Text
        Dim nota4 As Decimal = txtNota4.Text

        'Processamento dos dados de entrada
        Dim media As Decimal = (nota1 + nota2 + nota3 + nota4) / 4

        If media >= 6 Then
            'Saida
            lblResultado.Text = "Aprovado" & "- Média: " & media
            lblResultado.ForeColor = Drawing.Color.Blue

        Else
            If media < 4 Then
                'Saida
                lblResultado.Text = "Reprovado" & "- Média: " & media
                lblResultado.ForeColor = Drawing.Color.Red
            Else
                lblResultado.Text = "Em Recuperação" & "- Média: " & media
                lblResultado.ForeColor = Drawing.Color.DarkOrange
            End If
        End If





    End Sub
End Class
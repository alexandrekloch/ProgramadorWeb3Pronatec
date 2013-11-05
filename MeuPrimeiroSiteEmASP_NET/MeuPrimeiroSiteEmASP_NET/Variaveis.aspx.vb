Public Class Variaveis
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed2_Click(sender As Object, e As EventArgs)
        'Integer Armazena numeros Inteiros
        '-2.147.483.648 a 2.147.483.647
        Dim valor1 As Integer
        'Double Armazena numeros reais
        'com dupla precisao de ponto flutuante
        Dim valorReal As Double
        'Decimal tem precisão de até 28 casas
        'decimais
        Dim valorDecimal As Decimal
        'char Armazena apena um caracter
        Dim valorLiteral As Char
        'String armazena texto.
        Dim valorLiteral1 As String
        'Boolena armazena apenas valores
        '"Verdadeiro" ou falso
        Dim valorLogico As Boolean

        Const valorConstante As Integer = 1






        'Atribuição Corretas
        valor1 = 12
        valorReal = 5.555555
        valorDecimal = 12.76
        valorLiteral = "c"
        valorLiteral1 = "Alexandre Luis Kloch"
        valorLogico = False

        'atribuição Errada
        valor1 = 4
        valorReal = 45.979999999999997
        valorDecimal = 12.76
        valorLiteral = "caracter"
        valorLiteral1 = 36
        valorLogico = False



    End Sub
End Class
Public Class WebForm1
    Inherits System.Web.UI.Page
    Structure Pessoa
        Dim nome As String
        Dim dataNascimento As Date
        Dim rg As String
        Dim cpf As String
    End Structure
    Dim novaPessoa As Pessoa
    Dim novaPessoa2 As Pessoa


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        novaPessoa.nome = "Alexandre"
        novaPessoa.dataNascimento = New Date(1977, 12, 20)
        novaPessoa.rg = "000000000"
        novaPessoa.cpf = "1982983219837"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = novaPessoa.nome
        Label2.Text = novaPessoa.dataNascimento
        Label3.Text = novaPessoa.rg
        Label4.Text = novaPessoa.cpf
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        novaPessoa2.nome = "Alexandre"
        novaPessoa2.dataNascimento = New Date(1977, 12, 20)
        novaPessoa2.rg = "000000000"
        novaPessoa2.cpf = "1982983219837"

        Label1.Text = novaPessoa2.nome
        Label2.Text = novaPessoa2.dataNascimento
        Label3.Text = novaPessoa2.rg
        Label4.Text = novaPessoa2.cpf
    End Sub
End Class
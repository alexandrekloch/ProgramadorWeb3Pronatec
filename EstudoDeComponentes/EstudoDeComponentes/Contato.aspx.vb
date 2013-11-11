Imports System.Net.Mail
Imports System.Net

Public Class Contato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim assunto As String = "Contato Site : " & txtEmail.Text & txtNome.Text & " - " & txtTelefone.Text & " - " & Date.Now.ToString()
        Dim contatoSite As New MailMessage()

        contatoSite.From = New MailAddress(txtEmail.Text)
        contatoSite.To.Add("alexandrekloch@windowslive.com")
        contatoSite.Subject = assunto
        contatoSite.Body = txtMensagem.Text

        Dim emaliCliente As New SmtpClient("smtp.live.com", 587)
        emaliCliente.EnableSsl = True
        emaliCliente.Credentials = New NetworkCredential("alexandrekloch@windowslive.com", "")

        emaliCliente.Send(contatoSite)




    End Sub
End Class
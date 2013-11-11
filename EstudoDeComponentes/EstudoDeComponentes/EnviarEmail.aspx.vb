Imports System.Net.Mail
Imports System.Net
Imports System.IO

Public Class EnviarEmail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim arquivo As New MemoryStream(FileUpload1.FileBytes)




        Dim mesagem As New MailMessage("alexandrekloch@windowslive.com", txtDestino.Text, txtAssunto.Text, txtMensagem.Text)

        mesagem.Attachments.Add(New Attachment(arquivo, FileUpload1.FileName))
        Dim emailClient As New SmtpClient("smtp.live.com", 587)
        emailClient.EnableSsl = True
        emailClient.Credentials = New NetworkCredential("alexandrekloch@windowslive.com", "@LK190708")

        emailClient.Send(mesagem)
    End Sub
End Class
Imports System.IO

Public Class Upload
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim label1 As New Label

        If Not fupArquivo.FileName = "" Then
            Dim arquivo As String = fupArquivo.FileName
            Dim diretorio As New DirectoryInfo("D:\SENAI\Aulas\Tecnicas de Programação\EstudoDeComponentes\EstudoDeComponentes\Arquivos")
            fupArquivo.SaveAs(diretorio.FullName & "/" & arquivo)
            label1.Text = "Upload concluido com sucesso!"
        Else
            label1.Text = "Selecioner um arquivo para envia ao servidor!"
        End If
        form1.Controls.Add(label1)





    End Sub
End Class
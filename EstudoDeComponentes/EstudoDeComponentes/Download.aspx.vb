Imports System.IO

Public Class Download
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim diretorio As New DirectoryInfo("D:\SENAI\Aulas\Tecnicas de Programação\EstudoDeComponentes\EstudoDeComponentes\Arquivos")
        Dim listaArquivos As FileInfo() = diretorio.GetFiles()

        lsbArquivosDiretorio.Items.Clear()
        lsbArquivosDiretorio.DataSource = listaArquivos
        lsbArquivosDiretorio.DataBind()




    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pasta As New DirectoryInfo("D:\SENAI\Aulas\Tecnicas de Programação\EstudoDeComponentes\EstudoDeComponentes\Arquivos")
        Dim arquivo As New FileInfo(pasta.FullName & "\" & lsbArquivosDiretorio.SelectedValue)

        My.Computer.Network.DownloadFile(arquivo.FullName, "D:\" & lsbArquivosDiretorio.SelectedValue)

    End Sub
End Class
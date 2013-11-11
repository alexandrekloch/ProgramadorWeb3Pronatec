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

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim diretorio As New DirectoryInfo("D:\SENAI\Aulas\Tecnicas de Programação\EstudoDeComponentes\EstudoDeComponentes\Arquivos")
        Dim arquivos As New FileInfo(diretorio.FullName & "\" & lsbArquivosDiretorio.SelectedValue)

        Response.Clear()

        Response.ContentType = "application/octet-strem"
        Response.AddHeader("Content-Disposition", "attachment; filename=" & arquivos.Name & "")
        Response.Flush()
        Response.TransmitFile(arquivos.FullName)

    End Sub

    Protected Sub lsbArquivosDiretorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbArquivosDiretorio.SelectedIndexChanged
        imgDownload.ImageUrl = "~/Arquivos/" & lsbArquivosDiretorio.SelectedValue

    End Sub
End Class
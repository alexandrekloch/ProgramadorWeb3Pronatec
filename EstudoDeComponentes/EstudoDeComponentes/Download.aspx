<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Download.aspx.vb" Inherits="EstudoDeComponentes.Download" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lsbArquivosDiretorio" runat="server" Height="139px" Width="204px" AutoPostBack="True"></asp:ListBox>
        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" />
        <asp:Button ID="btnDownload" runat="server" Text="Download" />
        <br />

        <br />
        <asp:Image ID="imgDownload" runat="server" />
    </div>
    </form>
</body>
</html>

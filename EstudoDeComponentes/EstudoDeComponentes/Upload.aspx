<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Upload.aspx.vb" Inherits="EstudoDeComponentes.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="fupArquivo" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar Arquivo" />
    
    </div>
    </form>
</body>
</html>

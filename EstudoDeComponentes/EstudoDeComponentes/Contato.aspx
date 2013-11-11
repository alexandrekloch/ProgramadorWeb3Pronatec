<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Contato.aspx.vb" Inherits="EstudoDeComponentes.Contato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Nome:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server" Width="336px"></asp:TextBox>
        <br />
        <br />
        E-mail:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" Width="343px"></asp:TextBox>
        <br />
        <br />
        Telefone:
        <asp:TextBox ID="txtTelefone" runat="server" Width="343px"></asp:TextBox>
        <br />
        <br />
        Mensagem<br />
        <asp:TextBox ID="txtMensagem" runat="server" Height="143px" TextMode="MultiLine" Width="399px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
    
    </div>
    </form>
</body>
</html>

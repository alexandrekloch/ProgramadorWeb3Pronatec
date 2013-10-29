<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="MeuPrimeiroSiteEmASP_NET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Minha Primeira pagina em Asp.net</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:BulletedList ID="BulletedList1" runat="server">
            <asp:ListItem>Teste</asp:ListItem>
            <asp:ListItem>Teste</asp:ListItem>
            <asp:ListItem>Teste</asp:ListItem>
        </asp:BulletedList>
        <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        
    </div>
    </form>
</body>
</html>

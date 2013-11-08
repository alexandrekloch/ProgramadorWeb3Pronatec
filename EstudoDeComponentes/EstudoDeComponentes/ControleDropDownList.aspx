<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ControleDropDownList.aspx.vb" Inherits="EstudoDeComponentes.ControleDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Altura<br />
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Enabled="False">
            <asp:ListItem>Selecione o Sexo</asp:ListItem>
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Feminino</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OperadoresLogicos.aspx.vb" Inherits="MeuPrimeiroSiteEmASP_NET.OperadoresLogicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:yellow">
        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        >
        <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        <asp:Label ID="lblPrimeira" runat="server" Text="Label"></asp:Label>
    </div>

    <div style="background-color:grey">

        <asp:TextBox ID="txtValor3" runat="server"></asp:TextBox>
        >
        <asp:TextBox ID="txtValor4" runat="server"></asp:TextBox>
        <asp:Label ID="lblSegunda" runat="server" Text="Label"></asp:Label>
    </div>
        <asp:Label ID="lblresultado" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnE" runat="server" Text="E (and)" />
        <asp:Button ID="btnOu" runat="server" Text="Ou (OR)" />
        <asp:Button ID="btnNao" runat="server" Text="Não (NOT)"/>
    </form>
</body>
</html>

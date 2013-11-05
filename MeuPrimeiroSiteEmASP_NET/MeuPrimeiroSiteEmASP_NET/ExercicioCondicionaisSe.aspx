<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ExercicioCondicionaisSe.aspx.vb" Inherits="MeuPrimeiroSiteEmASP_NET.ExercicioCondicionaisSe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nota 1<asp:TextBox ID="txtNota1" runat="server"></asp:TextBox>
        <br />
        Nota 2<asp:TextBox ID="txtNota2" runat="server"></asp:TextBox>
        <br />
        Nota 3<asp:TextBox ID="txtNota3" runat="server"></asp:TextBox>
        <br />
        Nota 4<asp:TextBox ID="txtNota4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

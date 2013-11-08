<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CotroleTextBox.aspx.vb" Inherits="EstudoDeComponentes.CotroleTextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" ToolTip="Digite o nome da pessoa!"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>

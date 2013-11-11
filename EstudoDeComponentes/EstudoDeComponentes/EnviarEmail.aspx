<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EnviarEmail.aspx.vb" Inherits="EstudoDeComponentes.EnviarEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        Destino:
        <asp:TextBox ID="txtDestino" runat="server" Width="347px"></asp:TextBox>
        <br />
        <br />
        Assunto:
        <asp:TextBox ID="txtAssunto" runat="server" Width="343px"></asp:TextBox>
        <br />
        <br />
        Mensagem<br />
        <asp:TextBox ID="txtMensagem" runat="server" Height="143px" TextMode="MultiLine" Width="399px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;
        
    </div>
    </form>
</body>
</html>

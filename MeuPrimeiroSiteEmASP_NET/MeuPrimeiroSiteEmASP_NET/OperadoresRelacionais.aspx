<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OperadoresRelacionais.aspx.vb" Inherits="MeuPrimeiroSiteEmASP_NET.OperadoresRelacionais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <th colspan="2">Operadores Relacionais </th>
            </tr>
            <tr>
                <th>Operador</th>
                <th>Ação</th>
            </tr>
                        <tr>
                <th>></th>
                <th>Maior</th>
            </tr>
            <tr>
                <th><</th>
                <th>Menor</th>
            </tr>
            <tr>
                <th>=</th>
                <th>Igual</th>
            </tr>
            <tr>
                <th><></th>
                <th>Diferente</th>
            </tr>
            <tr>
                <th>>=</th>
                <th>Maior ou Igual</th>
            </tr>
            <tr>
                <th><</th>
                <th>Menor ou Igual</th>
            </tr>
        </table>


        <br />
        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        <asp:Label ID="lblOperador" runat="server" Text=""></asp:Label>
        <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        =<asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnMaiorQue" runat="server" Text="Maior que ( &gt; )" />


        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:Button ID="Button4" runat="server" Text="Button" />
        <asp:Button ID="Button5" runat="server" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />


    </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OperadoresAritmeticos.aspx.vb" Inherits="MeuPrimeiroSiteEmASP_NET.OperadoresAritmeticos" %>

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
                <th colspan="2">Operadores Aritméticos </th>
            </tr>
            <tr>
                <th>Operador</th>
                <th>Ação</th>
            </tr>
                        <tr>
                <th>+</th>
                <th>Soma</th>
            </tr>
            <tr>
                <th>-</th>
                <th>Subtração</th>
            </tr>
            <tr>
                <th>*</th>
                <th>Multiplicação</th>
            </tr>
            <tr>
                <th>/</th>
                <th>Divisão</th>
            </tr>
            <tr>
                <th>\</th>
                <th>Parte Inteira da Divisão</th>
            </tr>
            <tr>
                <th>mod</th>
                <th>Resto da Divisão</th>
            </tr>
            <tr>
                <th>^</th>
                <th>Potenciação</th>
            </tr>
        </table>
        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        <asp:Label ID="lblOperador" runat="server"></asp:Label>
        <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        =<asp:Label ID="lblResultado" runat="server"></asp:Label>
        <br /> 
        <asp:Button ID="btnSoma" runat="server" Text="Soma (+)" />

        <asp:Button ID="btnSubtracao" runat="server" Text="Subtração (-)" />
        <asp:Button ID="btnMultiplicacao" runat="server" Text="Multiplicação (*)" />
        <asp:Button ID="btnDivisao" runat="server" Text="Divisão (/)" />
        <asp:Button ID="bntParteIntDiv" runat="server" Text="Inteiro da Divisâo (\)" />
        <asp:Button ID="btnMod" runat="server" Text="MOD" />
        <asp:Button ID="btnPotenciacao" runat="server" Text="Potenciação (^)" />

    </div>
    </form>
</body>
</html>

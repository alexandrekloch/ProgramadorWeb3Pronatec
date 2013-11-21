<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AniversarianteBD.aspx.vb" Inherits="CalendarioAniversariantes.AniversarianteBD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Aniversario" HeaderText="Aniversario" SortExpression="Aniversario" />
                <asp:BoundField DataField="RedeSocial" HeaderText="RedeSocial" SortExpression="RedeSocial" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Table] ([Nome], [Aniversario], [RedeSocial]) VALUES (@Nome, @Aniversario, @RedeSocial)" SelectCommand="SELECT [Id], [Nome], [Aniversario], [RedeSocial] FROM [Table]" UpdateCommand="UPDATE [Table] SET [Nome] = @Nome, [Aniversario] = @Aniversario, [RedeSocial] = @RedeSocial WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Aniversario" Type="DateTime" />
                <asp:Parameter Name="RedeSocial" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Aniversario" Type="DateTime" />
                <asp:Parameter Name="RedeSocial" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
    </div>
    </form>
</body>
</html>

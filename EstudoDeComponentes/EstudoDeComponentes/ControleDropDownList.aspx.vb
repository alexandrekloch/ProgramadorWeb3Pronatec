Public Class ControleDropDownList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim altura As Decimal = TextBox1.Text
        Dim peso As Decimal

        If DropDownList1.SelectedItem.Text = "Masculino" Then
            peso = (72.700000000000003 * altura) - 58
        End If

        If DropDownList1.SelectedItem.Text = "Feminino" Then
            peso = (61.100000000000001 * altura) - 44.700000000000003
        End If

        Dim literal1 As New Literal()
        literal1.Text = peso
        form1.Controls.Add(literal1)
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 0 Then
            DropDownList1.Enabled = True
        Else
            DropDownList1.Enabled = False
            TextBox1.Focus()
        End If
    End Sub
End Class
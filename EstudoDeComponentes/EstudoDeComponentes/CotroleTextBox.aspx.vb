Public Class CotroleTextBox
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.ToolTip = "Digite o nome da Pessoa (Via código)"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ForeColor = Drawing.Color.Red
        TextBox1.Focus()
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text.Length > 0 Then
            TextBox1.BorderColor = Drawing.Color.Green
        Else
            TextBox1.BorderColor = Drawing.Color.Red

            Dim label1 As New Label()
            label1.Text = "Preencha o campo!!!"
            label1.ForeColor = Drawing.Color.Red
            form1.Controls.Add(label1)

            TextBox1.Focus()
        End If




    End Sub
End Class
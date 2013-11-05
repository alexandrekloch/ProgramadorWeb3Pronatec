Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num As Integer = TextBox1.Text
        Dim total As Integer

        For index = 1 To 10
            Dim literal1 As New Literal
            form1.Controls.Add(literal1)
            total = Num * index
            literal1.Text = Num & "x" & index & "=" & total & "<br/>"
        Next

    End Sub
End Class
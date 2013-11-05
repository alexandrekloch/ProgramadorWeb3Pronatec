Public Class LacosDeRepeticao
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim passos As Integer = TextBox1.Text
        Dim valor As Integer = 0

        'Enquanto (While)
        While valor < passos
            Dim literal1 As New Literal()
            literal1.Text = valor & "<BR/>"
            form1.Controls.Add(literal1)
            valor = valor + 1
        End While

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim passos As Long = TextBox1.Text
        Dim valor As Long = 0

        'Até que (do While)
        Do
            Dim literal1 As New Literal()
            literal1.Text = valor
            form1.Controls.Add(literal1)
            valor = valor + 1
        Loop While valor < passos







    End Sub
End Class
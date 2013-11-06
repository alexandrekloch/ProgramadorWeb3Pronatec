Public Class TrabalhandoVetores
    Inherits System.Web.UI.Page

    Dim vetor(3) As Integer
    Dim vetor2() As String = {"a", "b", "c", "d", "e", "f"}

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        vetor(0) = 10
        vetor(1) = 50
        vetor(2) = 100
        vetor(3) = 1000
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        For index = 0 To vetor.Length - 1
            total += vetor(index)
        Next


        Dim label1 As New Label
        label1.Text = total
        form1.Controls.Add(label1)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim texto As String = TextBox1.Text
        Dim soma As Integer = 0
        For indexTexto = 0 To texto.Length - 1
            For indexVetor = 0 To vetor2.Length - 1
                If texto.Substring(indexTexto, 1) = vetor2(indexVetor) Then
                    soma += indexVetor + 1
                    Exit For
                End If
            Next
        Next

        Dim label1 As New Label
        label1.Text = soma
        form1.Controls.Add(label1)


    End Sub
End Class
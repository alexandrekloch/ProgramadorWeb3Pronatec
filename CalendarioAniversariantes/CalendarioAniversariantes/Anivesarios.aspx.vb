Public Class Anivesarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Dim literal1 As New Literal()
        literal1.Text = Calendar1.SelectedDate
        form1.Controls.Add(literal1)
    End Sub

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        Dim aniversariante As String = AniversariantesDaSala(e.Day.Date)

        If aniversariante <> Nothing Then
            Dim literal1 As New Literal()
            literal1.Text = "<br/>"
            e.Cell.Controls.Add(literal1)

            Dim link As New HyperLink()
            link.Text = aniversariante
            link.NavigateUrl = "http://www.facebook.com"
            e.Cell.Controls.Add(link)

        End If

    End Sub

    Function AniversariantesDaSala(dia As Date) As String
        Select Case dia
            Case New Date(2013, 11, 27)
                Return "Viviane"
            Case New Date(2013, 12, 20)
                Return "Alexandre"
            Case New Date(2014, 2, 25)
                Return "Marcelo"
            Case Else
                Return Nothing
        End Select

    End Function
End Class
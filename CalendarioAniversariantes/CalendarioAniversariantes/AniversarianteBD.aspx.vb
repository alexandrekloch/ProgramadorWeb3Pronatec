Imports System.Data.SqlClient

Public Class AniversarianteBD
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        Dim datas As DataTable = PesquisaBd(e.Day.Date)

    End Sub

    Private Function PesquisaBd(dia As Date) As DataTable
        Dim meuSqlConnection As New SqlConnection()
        Dim meuDataAdapter As New SqlDataAdapter()
        Dim meuDataTable As New DataTable()

        Try
            meuSqlConnection.ConnectionString = My.Settings.cs
            meuDataAdapter.SelectCommand = New SqlCommand()
            meuDataAdapter.SelectCommand.Connection = meuSqlConnection
            meuDataAdapter.SelectCommand.CommandType = CommandType.Text
            meuDataAdapter.SelectCommand.CommandText = "SELECT * From [Table] where Aniversario = '1977/12/20'"

            meuDataAdapter.Fill(meuDataTable)
            Return meuDataTable

        Catch ex As Exception

        End Try




    End Function

End Class
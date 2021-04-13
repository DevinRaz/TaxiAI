Public Class Parts
    Inherits System.Web.UI.Page
    Dim TaxiAPI As New TaxiREST.Client
    Dim NoResults As New List(Of TaxiREST.Client.Part)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.BindGrid(NoResults)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindGrid(TaxiAPI.PartSearch(part_no.Text, category.Text, compatible_model.Text, part_desc.Text).ToList)
    End Sub


    Private Sub BindGrid(ByVal Parts As List(Of TaxiREST.Client.Part))
        gvParts.DataSource = Parts
        gvParts.DataBind()
    End Sub



End Class
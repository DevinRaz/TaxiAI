Public Class Cars
    Inherits System.Web.UI.Page
    Dim TaxiAPI As New TaxiREST.Client
    Dim NoResults As New List(Of TaxiREST.Client.Vehicle)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.BindGrid(NoResults)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindGrid(TaxiAPI.CarSearch(vin.Text, plate.Text, "", model.Text, color.Text).ToList)
    End Sub

    Private Sub BindGrid(ByVal Vehicles As List(Of TaxiREST.Client.Vehicle))
        gvVehicles.DataSource = Vehicles
        gvVehicles.DataBind()
        fixthumbs()
        If gvVehicles.Rows.Count = 0 Then
            Label1.Text = "No Results Found"
        Else
            Label1.Text = ""
        End If
    End Sub

    Sub fixthumbs()
        For Each row As GridViewRow In gvVehicles.Rows
            Dim Image As Image = row.Cells.Item(0).FindControl("imgID")
            Image.ImageUrl = "~/Images/Model" & row.Cells.Item(4).Text & "-Trans.png"
            Image.BackColor = Drawing.Color.FromName(row.Cells.Item(5).Text)
        Next
    End Sub


End Class
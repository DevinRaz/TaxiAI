Public Class Car
    Inherits System.Web.UI.Page
    Dim TaxiAPI As New TaxiREST.Client
    Dim NoResults As New List(Of TaxiREST.Client.Vehicle)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub




End Class
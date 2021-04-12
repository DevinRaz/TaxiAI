Public Class Parts
    Inherits System.Web.UI.Page
    Dim TaxiAPI As New TaxiREST.Client
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim found As TaxiREST.Client.Part = TaxiAPI.GetPartFromID(TextBox1.Text)
        If found Is Nothing Then
            Label1.Text = "No Part Found"
        Else
            Label1.Text = found.part_description
        End If
    End Sub
End Class
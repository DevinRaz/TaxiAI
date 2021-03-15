Public Class Cars
    Inherits System.Web.UI.Page
    Dim TaxiAPI As New TaxiREST.Client
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FoundCar = TaxiAPI.GetCarFromID(TextBox1.Text)
        If FoundCar Is Nothing Then
            Label1.Text = "No Car Under ID:" & TextBox1.Text
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            imgCar.Visible = False
        Else
            Label1.Text = "Make:" & FoundCar.Make
            Label2.Text = "Model:" & FoundCar.Model
            Label3.Text = "Plate:" & FoundCar.Plate
            Label4.Text = "Color:" & FoundCar.Color
            If FoundCar.Model = "Model 3" Then
                imgCar.ImageUrl = "Images/Model3-Trans.png"

            ElseIf FoundCar.Model = "Model S" Then
                imgCar.ImageUrl = "Images/ModelS-Trans.png"
            End If
            imgCar.BackColor = System.Drawing.Color.FromName(FoundCar.Color)
            imgCar.Visible = True
        End If

    End Sub
End Class
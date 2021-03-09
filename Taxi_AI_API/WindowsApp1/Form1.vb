Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim taxiapi As New TaxiAI_Object_Lib.TaxiAI_REST
        taxiapi.GetCarFromID("1")
    End Sub
End Class

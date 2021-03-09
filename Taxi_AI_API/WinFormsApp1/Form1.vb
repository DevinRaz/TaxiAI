Public Class Form1
    Dim TaxiAPI As New TaxiAI_Object_Lib.TaxiAI_REST

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaxiAPI.GetCarFromID(1)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim taxiapi As New TaxiREST.Client

        taxiapi.GetCarFromID("1")


    End Sub

End Module

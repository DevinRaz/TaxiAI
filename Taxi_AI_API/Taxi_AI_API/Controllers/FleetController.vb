Imports System.Net
Imports System.Web.Http
Imports Taxi_AI_DB
Namespace Controllers
    Public Class FleetController
        Inherits ApiController


        ' EX http://localhost:59922/api/parts/Search/=%partno=%25104%25

        <HttpGet>
        <Route("api/cars/Search/{vin=%}/{make=%}/{model=%}/{color=%}/{plate=%}")>
        Public Function GetValue(ByVal Optional vin As String = "%", ByVal Optional make As String = "%", ByVal Optional model As String = "%", ByVal Optional color As String = "%", ByVal Optional plate As String = "%") As String
            Dim TaxiAI As New TaxiDB("TaxiAPI", "vjM9vo9HYh^D9$*D")
            Dim temp As DataTable = TaxiAI.QueryRetDT(Queries.SearchVehicles(vin, make, model, color, plate))

            Dim json As String = TaxiAI.DatatabletoJSON(temp)

            Return json
        End Function



    End Class
End Namespace
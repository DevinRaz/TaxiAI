Imports System.Net
Imports System.Web.Http
Imports Taxi_AI_DB
Namespace Controllers
    Public Class PartsController
        Inherits ApiController


        ' EX http://localhost:59922/api/parts/Search/?partno=%25104%25

        <HttpGet>
        <Route("api/parts/Search/{partno?}/{partsum?}/{partdescription?}/{manufacturer?}/{model?}/{partid?}/{category?}")>
        Public Function GetValue(ByVal Optional partno As String = "%", ByVal Optional partsum As String = "%", ByVal Optional partdescription As String = "%", ByVal Optional manufacturer As String = "%", ByVal Optional storeid As String = "%", ByVal Optional model As String = "%", ByVal Optional partid As String = "%", ByVal Optional category As String = "%") As String
            Dim TaxiAI As New TaxiDB("TaxiAPI", "vjM9vo9HYh^D9$*D")
            Dim temp As DataTable = TaxiAI.QueryRetDT(Queries.SearchParts(partid, partsum, partdescription, manufacturer, model, partno, category))

            Dim json As String = TaxiAI.DatatabletoJSON(temp)

            Return json
        End Function

    End Class

End Namespace
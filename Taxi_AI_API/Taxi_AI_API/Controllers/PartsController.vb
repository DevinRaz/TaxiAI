Imports System.Net
Imports System.Web.Http
Imports Taxi_AI_DB
Namespace Controllers
    Public Class PartsController
        Inherits ApiController

        ' GET: api/Parts
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Parts/5
        Public Function GetValue(ByVal id As String) As String
            Dim TaxiAI As New TaxiDB("TaxiAPI", "vjM9vo9HYh^D9$*D")
            Dim temp As DataTable = TaxiAI.QueryRetDT(Queries.GetPartInfo(id))

            Dim json As String = TaxiAI.DatatabletoJSON(temp)

            Return json
        End Function


        ' POST: api/Parts
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Parts/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Parts/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace
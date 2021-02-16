Imports System.Net
Imports System.Web.Http
Imports Taxi_AI_DB
Namespace Controllers
    Public Class FleetController
        Inherits ApiController

        ' GET: api/Fleet
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"Online"}
        End Function

        ' GET: api/Fleet/5
        Public Function GetValue(ByVal id As String) As String
            Dim TaxiAI As New TaxiDB("TaxiAPI", "vjM9vo9HYh^D9$*D")

            '    Dim CarInfo() As IEnumerable(Of String)

            Dim temp As DataTable = TaxiAI.QueryRetDT(Queries.GetCarInfo(id))

            Dim CarVals As New Dictionary(Of String, String)

            If temp.Rows.Count >= 1 Then
                For Each col As DataColumn In temp.Columns
                    CarVals.Add(col.ColumnName, temp.Rows.Item(0).Item(col))
                Next
            End If

            Dim json As String = "{"

            For Each cval In CarVals
                json &= """" & cval.Key & """:""" & cval.Value & ""","
            Next

            json = json.Substring(0, json.Length - 1)

            json &= "}"

            Return json
        End Function

        ' POST: api/Fleet
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Fleet/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Fleet/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub





    End Class
End Namespace
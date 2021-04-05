Imports System.Net
Imports System.Web.Http
Imports Taxi_AI_DB
Namespace Controllers
    Public Class LocationController
        Inherits ApiController

        ' GET: api/Location
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Location/5
        Public Function GetValue(ByVal id As String) As String
            Dim TaxiAI As New TaxiDB("TaxiAPI", "vjM9vo9HYh^D9$*D")

            '    Dim CarInfo() As IEnumerable(Of String)

            Dim temp As DataTable = TaxiAI.QueryRetDT(Queries.GetPartInfo(id))

            Dim PartVals As New Dictionary(Of String, String)

            If temp.Rows.Count >= 1 Then
                For Each col As DataColumn In temp.Columns
                    PartVals.Add(col.ColumnName, temp.Rows.Item(0).Item(col))
                Next
            End If

            Dim json As String = "{'Parts':[{"

            For Each cval In PartVals
                json &= "'" & cval.Key & "':'" & cval.Value & "',"
            Next

            json = json.Substring(0, json.Length - 1)

            json &= "}]}"

            Return json
        End Function

        ' POST: api/Location
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Location/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Location/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Client


    Public Function GetCarFromID(ID As String) As Vehicle
        Dim Value As String = RESTGet("http://taxiai.razberry.network:2999/api/fleet/" & ID)
        If Value = "null" Then
            Return Nothing
        End If
        Dim FoundCars As Vehicle() = JsonConvert.DeserializeObject(Of Vehicle())(Value)
        If FoundCars.Count > 0 Then
            Return FoundCars.First
        Else
            Return Nothing
        End If

    End Function

    Public Function CarSearch(Vin As String, Plate As String, Make As String, Model As String, Color As String) As Vehicle()
        Dim RestURL As String = "http://taxiai.razberry.network:2999/api/cars/Search/"
        Dim SearchParams As String = ""
        If Vin <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "vin=%25" & Vin & "%25"
        End If
        If Plate <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "plate=%25" & Plate & "%25"
        End If
        If Model <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "model=%25" & Model & "%25"
        End If
        If Make <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "make=%25" & Make & "%25"
        End If
        If Color <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "color=%25" & Color & "%25"
        End If

        Dim Value As String = RESTGet(RestURL & SearchParams)
        If Value = "null" Then
            Return Nothing
        End If
        Dim Results As Vehicle() = JsonConvert.DeserializeObject(Of Vehicle())(Value)
        If Results.Count > 0 Then
            Return Results
        Else
            Return {}
        End If
    End Function

    Public Function PartSearch(PartNum As String, Category As String, Model As String, PartDesc As String) As Part()
        Dim RestURL As String = "http://taxiai.razberry.network:2999/api/parts/Search/"
        Dim SearchParams As String = ""
        If PartNum <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "partno=%25" & PartNum & "%25"
        End If
        If Category <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "category=%25" & Category & "%25"
        End If
        If Model <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "model=%25" & Model & "%25"
        End If
        If PartDesc <> "" Then
            SearchParams &= If(SearchParams = "", "?", "&") & "partdesc=%25" & PartDesc & "%25"
        End If

        Dim Value As String = RESTGet(RestURL & SearchParams)
        If Value = "null" Then
            Return Nothing
        End If
        Dim Results As Part() = JsonConvert.DeserializeObject(Of Part())(Value)
        If Results.Count > 0 Then
            Return Results
        Else
            Return {}
        End If

    End Function

    Public Function GetPartFromID(ID As String) As Part
        Dim Value As String = RESTGet("http://taxiai.razberry.network:2999/api/parts/" & ID)
        If Value = "null" Then
            Return Nothing
        End If
        Dim FoundParts As Part() = JsonConvert.DeserializeObject(Of Part())(Value)
        If FoundParts.Count > 0 Then
            Return FoundParts.First
        Else
            Return Nothing
        End If
    End Function


    Public Function RESTGet(URL) As String
        Dim origResponse As HttpWebResponse

        Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create(URL), HttpWebRequest)
        origRequest.ContentType = "application/json"
        origRequest.AllowAutoRedirect = False
        origRequest.Method = "GET"

        Try
            origResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
            Dim Stream As Stream = origResponse.GetResponseStream()
            Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
            Dim str As String = sr.ReadToEnd()
            str = str.Substring(1, str.Length - 2).Replace("\""", """")

            Return str
        Catch ex As WebException
            Console.WriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Class Part
        Public Property part_no As String
        Public Property part_summary As String
        Public Property part_description As String
        Public Property qty As String
        Public Property manufacturer As String
        Public Property store_id As String
        Public Property compatible_model As String
        Public Property part_id As String
        Public Property category As String
    End Class

    Public Class Vehicle

        Public Property ID As Integer
        Public Property VIN As String
        Public Property Make As String
        Public Property Model As String
        Public Property Color As String
        Public Property Plate As String
        Public Property Battery As Decimal
        Public Property Location As String
        Public Property Status As String
        Public Property Odometer As Double

    End Class


End Class

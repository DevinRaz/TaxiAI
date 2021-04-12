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

Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Client


    Public Function GetCarFromID(ID As String) As Vehicle
        Dim Value As String = RESTGet("http://taxiai.razberry.network:2999/api/fleet/" & ID)
        Return JSONtoVehicle(Value)
    End Function


    Public Function JSONtoVehicle(JSON As String) As Vehicle
        Dim testjson As String = <json>{'Vehicles':[{'id':'1','vin':'test','make':'Tesla','model':'Model S','color':'Black','plate':'TaxiAI','location':'Clarkston, MI','battery':'100','status':'Ready','odometer':'11111.11'}]}</json>

        Dim result = JsonConvert.DeserializeObject(testjson)

        Dim rescar = result("Vehicles")(0)

        Dim retCar As New Vehicle(rescar("id"), rescar("vin"), rescar("make"), rescar("model"), rescar("color"), rescar("plate"), rescar("location"), rescar("battery"), rescar("status"), rescar("odometer"))
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
            Return str
            '       Dim FollowerCount As JValue = JObject.Parse(str)("total")
            '       UpdateTotalFollowers(FollowerCount)
            '
            '       Dim Followers As JArray = JObject.Parse(str)("data")
            '
            '       Dim NewFollower As New Alert("Follower", {"user", Followers.First("from_name")})
            '       If AlertList IsNot Nothing Then
            '           AlertList.Add(NewFollower)
            '       End If
        Catch ex As WebException
            Console.WriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Class Vehicle
        Public Property _ID As Integer
        Public Property _VIN As String
        Public Property _Make As String
        Public Property _Model As String
        Public Property _Color As String
        Public Property _Plate As String
        Public Property _Battery As Decimal
        Public Property _Location As String
        Public Property _Status As String
        Public Property _Odometer As Double
        Sub New(id, vin, make, model, color, plate, location, battery, status, odometer)
            _ID = id
            _VIN = vin
            _Make = make
            _Model = model
            _Color = color
            _Plate = plate
            _Location = location
            _Battery = battery
            _Status = status
            _Odometer = odometer
        End Sub


    End Class

    Class Location

    End Class

    Class Part

    End Class

End Class

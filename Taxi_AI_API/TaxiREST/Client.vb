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
        Dim Empty As String = "{'Vehicles':[}]}"
        JSON = JSON.Replace("""", "")

        If JSON = Empty Then
            Return Nothing
        End If

        Dim result = JsonConvert.DeserializeObject(JSON)

        Dim rescar = result("Vehicles")(0)

        Dim retCar As New Vehicle(rescar("id"), rescar("vin"), rescar("make"), rescar("model"), rescar("color"), rescar("plate"), rescar("location"), rescar("battery"), rescar("status"), rescar("odometer"))

        Return retCar
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
        Catch ex As WebException
            Console.WriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Class Vehicle
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

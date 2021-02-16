Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Data.Odbc

Public Class TaxiDB
    Dim ConnString As String
    Dim DBConnection As OdbcConnection

    Public Sub New(Username As String, Password As String)
        ConnString = "Driver={PostgreSQL ANSI};database=TaxiAI;server=192.168.50.201;port=5432;sslmode=disable;readonly=0;uid=" & Username & ";password=" & Password & ";"
        DBConnection = New OdbcConnection(ConnString)
        Open()
    End Sub

    Public Function Query(qry As String)
        Console.WriteLine("Executing Query:" & qry)
        Dim RetVal As String
        Dim DBCommand As OdbcCommand = New OdbcCommand
        DBCommand.Connection = DBConnection
        DBCommand.CommandText = qry
        Try
            If qry.ToLower.Contains("update") Or qry.ToLower.Contains("insert") Then
                Try
                    DBCommand.ExecuteNonQuery()
                    RetVal = True
                Catch ex As Exception
                    RetVal = False
                End Try
            Else
                Try
                    RetVal = DBCommand.ExecuteScalar()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    Throw ex
                End Try
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            RetVal = ""
        End Try
        Return RetVal
    End Function

    Public Function Query(DBCommand As OdbcCommand) As String
        Dim RetVal As String
        DBCommand.Connection = DBConnection
        Try
            If DBCommand.CommandText.ToLower.Split(" ").First.Equals("update") Or DBCommand.CommandText.ToLower.Split(" ").First.Equals("insert") Then
                Try
                    DBCommand.ExecuteNonQuery()
                    RetVal = True
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    RetVal = False
                End Try
            Else
                Try
                    RetVal = DBCommand.ExecuteScalar()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    Throw ex
                End Try
            End If
        Catch ex As Exception
            RetVal = ""
        End Try
        Return RetVal
    End Function

    Public Function QueryRetDT(DBCommand As OdbcCommand) As DataTable
        Dim RetVal As New DataTable
        Dim DA As New OdbcDataAdapter(DBCommand)
        DBCommand.Connection = DBConnection
        Try
            Try
                DA.Fill(RetVal)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Throw ex
            End Try

        Catch ex As Exception
            RetVal = Nothing
        End Try
        Return RetVal
    End Function

    Public Sub Open()
        Try
            Console.WriteLine("Opening Database Connection")
            DBConnection.Open()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub Close()
        Try
            Console.WriteLine("Closing Database Connection")
            DBConnection.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class

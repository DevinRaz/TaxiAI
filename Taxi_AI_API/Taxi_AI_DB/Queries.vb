Imports System.IO
Imports System.Net
Imports System.Text

Public Structure Queries
    Shared Function GetCarInfo(id As String)
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = "SELECT * FROM public.fleet WHERE id = ? ORDER BY id ASC"
        cmd.Parameters.AddWithValue("ID", id)
        Return cmd
    End Function
    Shared Function GetPartInfo(id As String)
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = "SELECT * FROM public.item_ref WHERE part_id = ? ORDER BY part_id ASC"
        cmd.Parameters.AddWithValue("ID", id)
        Return cmd
    End Function

End Structure

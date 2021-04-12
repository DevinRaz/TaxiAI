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

    Shared Function SearchParts(Optional partid As String = "%", Optional partsum As String = "%", Optional partdesc As String = "%", Optional manufacturer As String = "%", Optional model As String = "%", Optional partno As String = "%", Optional category As String = "%")
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = "SELECT * FROM public.item_ref WHERE part_no like ? and part_summary like ? and part_description like ? and manufacturer like ? and compatible_model like ? and category like ? ORDER BY part_id ASC"
        cmd.Parameters.AddWithValue("part_no", partno)
        cmd.Parameters.AddWithValue("part_summary", partsum)
        cmd.Parameters.AddWithValue("part_description", partdesc)
        cmd.Parameters.AddWithValue("manufactuerer", manufacturer)
        cmd.Parameters.AddWithValue("compatible_model", model)
        cmd.Parameters.AddWithValue("category", category)
        Return cmd
    End Function

    Shared Function SearchVehicles(Optional vin As String = "&", Optional make As String = "&", Optional model As String = "&", Optional color As String = "&", Optional plate As String = "&")
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = "SELECT * FROM public.fleet WHERE vin like ? and make like ? and model like ? and color like ? and plate like ? ORDER BY id ASC"
        cmd.Parameters.AddWithValue("vin", vin)
        cmd.Parameters.AddWithValue("make", make)
        cmd.Parameters.AddWithValue("model", model)
        cmd.Parameters.AddWithValue("color", color)
        cmd.Parameters.AddWithValue("plate", model)

        Return cmd
    End Function


End Structure

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
        cmd.CommandText = "SELECT * FROM public.item_ref WHERE LOWER(part_no) like ? and LOWER(part_summary) like ? and LOWER(part_description) like ? and LOWER(manufacturer) like ? and LOWER(compatible_model) like ? and LOWER(category) like ? ORDER BY part_id ASC"
        cmd.Parameters.AddWithValue("part_no", partno.ToLower)
        cmd.Parameters.AddWithValue("part_summary", partsum.ToLower)
        cmd.Parameters.AddWithValue("part_description", partdesc.ToLower)
        cmd.Parameters.AddWithValue("manufactuerer", manufacturer.ToLower)
        cmd.Parameters.AddWithValue("compatible_model", model.ToLower)
        cmd.Parameters.AddWithValue("category", category.ToLower)
        Return cmd
    End Function

    Shared Function SearchVehicles(Optional vin As String = "&", Optional make As String = "&", Optional model As String = "&", Optional color As String = "&", Optional plate As String = "&")
        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = "SELECT * FROM public.fleet WHERE LOWER(vin) like ? and LOWER(make) like ? and LOWER(model) like ? and LOWER(color) like ? and LOWER(plate) like ? ORDER BY id ASC"
        cmd.Parameters.AddWithValue("vin", vin.ToLower)
        cmd.Parameters.AddWithValue("make", make.ToLower)
        cmd.Parameters.AddWithValue("model", model.ToLower)
        cmd.Parameters.AddWithValue("color", color.ToLower)
        cmd.Parameters.AddWithValue("plate", plate.ToLower)

        Return cmd
    End Function


End Structure

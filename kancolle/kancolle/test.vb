Public Class test
    Dim adocn As New ADODB.Connection
    Dim adors As New ADODB.Recordset
    Dim sql As String
    Dim sql1 As String
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub text_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ds.Clear()
        sql = te.Text
        adors.Open(sql, adocn, 3, 3)
        da.Fill(ds, adors, "feiji")
        DataGrid1.DataSource = ds.Tables(0)
        DataGrid1.Refresh()
    End Sub
End Class
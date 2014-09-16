Public Class ditu
    Dim adors As New ADODB.Recordset
    Dim adocn As New ADODB.Connection
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub ditu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds.Clear()
        adors.Open("select exp,出现场所,敌舰1,敌舰2,敌舰3,敌舰4,敌舰5,敌舰6,物资,阵形,制空值,优势,确保,夜战 from map where 地图='" & ComboBox1.Text & "' order by 编号", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, adors, "map")
        DataGrid1.DataSource = ds.Tables(0)
        DataGrid1.Refresh()
        PictureBox1.ImageLocation = "" & App_Path() & "\data\map\" & ComboBox1.Text & ".jpg"
    End Sub
End Class
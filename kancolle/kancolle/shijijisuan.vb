Public Class shijijisuan
    Dim adocn As New ADODB.Connection
    Dim adors As New ADODB.Recordset
    Dim sql As String
    Dim sql1, sql2, sql3, msg As String
    Dim xh, yh, dh, yhb, dhb, time As Double
    Dim zyh, zdh, r, d, g, l As Integer
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Private Sub shijijisuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "时给计算"
        sql = "select distinct 舰种 from tujian"
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
        adors.Open(sql, adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, adors, "tujian")
        ds.Tables(0).TableName = "jianzhong"
        ComboBox1.DataSource = ds.Tables("jianzhong")
        ComboBox1.DisplayMember = "舰种"
        sql1 = "select 舰名 from tujian "
        ListBox2.DisplayMember = "舰名"
        adors.Open("select * from yuanzheng", adocn, 3, 3)
        da.Fill(ds, adors, "yuanzheng")
        ds.Tables(2).TableName = "yzname"
        ComboBox2.DataSource = ds.Tables("yzname")
        ComboBox2.DisplayMember = "远征名"
    End Sub
    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        ds.Tables(1).Clear()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql1 = "select 舰名 from tujian where 舰种='" & ComboBox1.Text & "'"
        adors.Open(sql1, adocn, 3, 3)
        da.Fill(ds, adors, "tujian")
        ListBox1.DataSource = ds.Tables(1)
        ListBox1.DisplayMember = "舰名"
        ListBox1.ValueMember = "舰名"
        ListBox1.Refresh()
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.SelectedValue)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedValue)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        xh = ListBox2.Items.Count
        yh = 0
        dh = 0
        zyh = 0
        zdh = 0
        If xh < 7 Then
            xh = xh
        Else
            xh = 6
        End If
        sql3 = "select * from yuanzheng where 远征名='" & ComboBox2.Text & "'"
        adors.Open(sql3, adocn, 3, 3)
        da.Fill(ds2, adors, "yuanzheng")
        yhb = ds2.Tables(0).Rows(0).Item("耗油")
        dhb = ds2.Tables(0).Rows(0).Item("耗弹")
        For i = 0 To xh - 1
            sql2 = "select 燃料,弹药 from tujian where 舰名='" & ListBox2.Items(i).ToString & "'"
            adors.Open(sql2, adocn, 3, 3)
            da.Fill(ds2, adors, "tujian")
            yh = ds2.Tables(1).Rows(0).Item("燃料") * yhb + zyh                     '精度问题'时间
            dh = ds2.Tables(1).Rows(0).Item("弹药") * dhb + zdh
            zyh = Int(yh)
            zdh = Int(dh)
            ds2.Tables(1).Clear()
        Next
        sql2 = ""
        time = ds2.Tables(0).Rows(0).Item("时间") / 60
        r = ds2.Tables(0).Rows(0).Item("燃") - Int(zyh / time)
        d = ds2.Tables(0).Rows(0).Item("弹") - Int(zdh / time)
        g = ds2.Tables(0).Rows(0).Item("钢")
        l = ds2.Tables(0).Rows(0).Item("铝")
        ds2.Tables(0).Clear()
        msg = "燃料:" + r.ToString + (Chr(13)) + "弹药:" + d.ToString + (Chr(13)) + "钢材:" + g.ToString + (Chr(13)) + "   铝:" + l.ToString
        MsgBox(msg, , "每小时获得资源")
    End Sub
End Class
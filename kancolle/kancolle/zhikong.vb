Public Class zhikong
    Dim adocn As New ADODB.Connection
    Dim adors As New ADODB.Recordset
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim a, b, c, d As Integer
    Dim e, f, g, h As Integer
    Dim bh As String
    Dim sql As String
    Dim hl As Integer
    Private Sub zhikong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
        adors.Open("select  * from feiji order by 类型", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds3, adors, "feiji")
        ComboBox2.DataSource = ds3.Tables(0)
        ComboBox2.ValueMember = "飞机名"
        adors.Open("select  * from feiji order by 类型", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds4, adors, "feiji")
        ComboBox3.DataSource = ds4.Tables(0)
        ComboBox3.ValueMember = "飞机名"
        adors.Open("select  * from feiji order by 类型", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds5, adors, "feiji")
        ComboBox4.DataSource = ds5.Tables(0)
        ComboBox4.ValueMember = "飞机名"
        adors.Open("select  * from feiji order by 类型", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds6, adors, "feiji")
        ComboBox5.DataSource = ds6.Tables(0)
        ComboBox5.ValueMember = "飞机名"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            adors.Open("select  舰名 from tujian where 舰种='正规空母'", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            ds.Clear()
            da.Fill(ds, adors, "tujian")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "舰名"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            adors.Open("select  舰名 from tujian where 舰种='轻母'", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            ds1.Clear()
            da.Fill(ds1, adors, "tujian")
            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.ValueMember = "舰名"
            ComboBox1.Refresh()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            adors.Open("select  舰名 from tujian where 舰种='水上机母舰' or 舰种='装甲空母' or 舰种='航巡'", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            ds2.Clear()
            da.Fill(ds2, adors, "tujian")
            ComboBox1.DataSource = ds2.Tables(0)
            ComboBox1.ValueMember = "舰名"
            ComboBox1.Refresh()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ds7.Clear()
        adors.Open("select  搭载1,搭载2,搭载3,搭载4,编号,火力 from tujian where 舰名='" & ComboBox1.Text & "'", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds7, adors, "tujian")
        If ds7.Tables(0).Rows.Count > 0 Then
            a = ds7.Tables(0).Rows(0).Item(0)
            b = ds7.Tables(0).Rows(0).Item(1)
            c = ds7.Tables(0).Rows(0).Item(2)
            d = ds7.Tables(0).Rows(0).Item(3)
            bh = ds7.Tables(0).Rows(0).Item(4)
            hl = ds7.Tables(0).Rows(0).Item(5)
            Label1.Text = a
            Label2.Text = b
            Label3.Text = c
            Label4.Text = d
            PictureBox1.ImageLocation = "" & App_Path() & "\data\pic\" & bh & ".jpg"
            Label9.Text = hl
        End If
    End Sub
    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
End Class

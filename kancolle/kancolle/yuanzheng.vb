Public Class yuanzheng
    Dim adors As New ADODB.Recordset
    Dim adocn As New ADODB.Connection
    Dim sql As String
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim f As Integer
    Dim g As Integer
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    'Dim da As New System.Data.OleDb.OleDbDataAdapter           连接dataview
    'Dim ds As New DataSet
    'da.Fill(ds, adors, "kancolle")
    'DataGrid1.DataSource = ds.Tables(0)
    'DataGrid1.Refresh()
    Public Function temp() As Integer
        a = 0
        b = 0
        c = 0
        d = 0
        f = 0
        g = 0
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "远征列表"
        temp()
        sql = "select * from kancolle "
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
        adors.Open(sql, adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, adors, "kancolle")
        DataGrid1.DataSource = ds.Tables(0)
        DataGrid1.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox7.Checked Then
            sql = "select * from yuanzheng where "
        Else
            sql = "select * from kancolle where "
        End If
        If a + b + c + d + f + g > 0 Then
            If a = 1 Then
                sql = sql + "燃>0 "
                If b + c + d + f + g > 0 Then
                    sql = sql + "and "
                End If
            End If
            If b = 1 Then
                sql = sql + "弹>0 "
                If c + d + f + g > 0 Then
                    sql = sql + "and "
                End If
            End If
            If c = 1 Then
                sql = sql + "钢>0 "
                If d + f + g > 0 Then
                    sql = sql + "and "
                End If
            End If
            If d = 1 Then
                sql = sql + "铝>0"
                If f + g > 0 Then
                    sql = sql + "and "
                End If
            End If
            If f = 1 Then
                sql = sql + "紫菜>0 or 喷火>0 or 桶>0"
                If g > 0 Then
                    sql = sql + "and "
                End If
            End If
            If g = 1 Then
                sql = sql + "大家具箱>0 or 中家具箱>0 or 小家具箱>0"
            End If
        Else
            If CheckBox7.Checked Then
                sql = "select * from yuanzheng"
            Else
                sql = "select * from kancolle"
            End If
        End If
        If CheckBox7.Checked Then
            ds.Clear()
            adors.Open(sql, adocn, 3, 3)
            da.Fill(ds, adors, "yuanzheng")
            DataGrid1.DataSource = ds.Tables(1)
            DataGrid1.Refresh()
            sql = "select * from yuanzheng where "
        Else
            ds.Tables(0).Clear()
            adors.Open(sql, adocn, 3, 3)
            da.Fill(ds, adors, "kancolle")
            DataGrid1.DataSource = ds.Tables(0)
            DataGrid1.Refresh()
            sql = "select * from kancolle where "
        End If
    End Sub

    Private Sub CheckBox1_checked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            a = 1
        Else
            a = 0
        End If
    End Sub
    Private Sub CheckBox2_checked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            b = 1
        Else
            b = 0
        End If
    End Sub
    Private Sub CheckBox3_checked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            c = 1
        Else
            c = 0
        End If
    End Sub
    Private Sub CheckBox4_checked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            d = 1
        Else
            d = 0
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            f = 1
        Else
            f = 0
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            g = 1
        Else
            g = 0
        End If
    End Sub
End Class
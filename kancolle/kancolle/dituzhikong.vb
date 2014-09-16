Public Class dituzhikong
    Dim adors As New ADODB.Recordset
    Dim adocn As New ADODB.Connection
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim hs As Integer
    Dim str(100) As String
    Dim dituhang(100) As dituhang
    Dim i As Integer
    Dim ys, qb, k As Integer


    Private Sub dituzhikong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "地图" Then
            MsgBox("                   请选择地图", MsgBoxStyle.OkCancel, "地图")
        End If
        For t = 0 To 100
            Me.Controls.Remove(dituhang(t))
        Next
        adors.Open("select 编号,出现场所,制空值,优势,确保 from map where 地图='" & ComboBox1.Text & "' order by 编号", adocn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, adors, "map")
        hs = ds.Tables(0).Rows.Count
        For j = 0 To hs - 1
            dituhang(j) = New dituhang
            dituhang(j).Left = 5
            dituhang(j).Top = i * 14 + 40
            i = i + 1
            dituhang(j).Label5.Text = ds.Tables(0).Rows(j).Item(1)
            dituhang(j).Label6.Text = ds.Tables(0).Rows(j).Item(2)
            dituhang(j).Label7.Text = ds.Tables(0).Rows(j).Item(3)
            dituhang(j).Label8.Text = ds.Tables(0).Rows(j).Item(4)
            ys = ds.Tables(0).Rows(j).Item(3)
            qb = ds.Tables(0).Rows(j).Item(4)
            If TextBox1.Text > qb Then
                dituhang(j).Label9.Text = "制空权确保"
                dituhang(j).BackColor = Color.FromArgb(30, 255, 30)
            Else
                If TextBox1.Text > ys Then
                    dituhang(j).Label9.Text = "航空优势"
                    dituhang(j).BackColor = Color.FromArgb(255, 245, 66)
                Else
                    If TextBox1.Text > ((1 / 3) * ds.Tables(0).Rows(j).Item(2)) Or TextBox1.Text = ds.Tables(0).Rows(j).Item(2) Then
                        If ds.Tables(0).Rows(j).Item(2) = 0 And TextBox1.Text = 0 Then
                            dituhang(j).Label9.Text = "互角"
                        End If
                    Else
                        dituhang(j).Label9.Text = "制空权丧失"
                        dituhang(j).BackColor = Color.FromArgb(255, 0, 0)
                    End If
                End If
            End If
            Me.Controls.Add(dituhang(j))
        Next
        i = 0
        ds.Tables(0).Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tanchuditu.Close()
        tanchuditu.Show()
    End Sub
End Class
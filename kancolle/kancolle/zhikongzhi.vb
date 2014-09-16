Public Class zhikongzhi
    Dim adocn As New ADODB.Connection
    Dim adors As New ADODB.Recordset
    Dim i As Integer
    Dim str(20) As String
    Dim jg As String
    Dim zhikong(20) As zhikong
    Dim a, b, c, d As Integer
    Dim a1, b1, c1, d1 As Integer
    Dim bl1, bl2, bl3, bl4 As Double
    Dim f, g As Integer
    Dim f1, g1 As Integer
    Dim da As New System.Data.OleDb.OleDbDataAdapter
    Dim ds, ds1, ds2, ds3 As New DataSet
    Dim hl As Integer
    Dim lz1, lz2, lz3, lz4, bz1, bz2, bz3, bz4, pjz As Integer
    Private Sub zhikongzhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If i < 6 Then
            zhikong(i) = New zhikong
            zhikong(i).Left = 0
            zhikong(i).Top = i * 210 + 45
            zhikong(i).Parent = Me
            i = i + 1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        f = 0
        adocn.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=  " & App_Path() & "\data\kancolle.accdb")
        For j = 0 To i - 1
            adors.Open("select 对空,雷装,爆装,类型 from feiji where 飞机名 = '" & zhikong(j).ComboBox2.Text & "'", adocn, 3, 3)
            da.Fill(ds, adors, "feiji")
            a = ds.Tables(0).Rows(0).Item(0)
            hl = zhikong(j).Label9.Text
            If ds.Tables(0).Rows(0).Item(3) = "艦上攻撃機" Then
                bl1 = 0.8
                a1 = ds.Tables(0).Rows(0).Item(1)
                lz1 = a1
                bz1 = 0
            Else
                If ds.Tables(0).Rows(0).Item(3) = "艦上爆撃機" Or ds.Tables(0).Rows(0).Item(3) = "水上爆撃機" Then
                    bl1 = 1
                    a1 = ds.Tables(0).Rows(0).Item(2)
                    bz1 = a1
                    lz1 = 0
                Else
                    a1 = 0
                End If
            End If
            ds.Clear()
            adors.Open("select 对空,雷装,爆装,类型 from feiji where 飞机名 = '" & zhikong(j).ComboBox3.Text & "'", adocn, 3, 3)
            da.Fill(ds1, adors, "feiji")
            b = ds1.Tables(0).Rows(0).Item(0)
            If ds1.Tables(0).Rows(0).Item(3) = "艦上攻撃機" Then
                bl2 = 0.8
                b1 = ds1.Tables(0).Rows(0).Item(1)
                lz2 = b1
                bz2 = 0
            Else
                If ds1.Tables(0).Rows(0).Item(3) = "艦上爆撃機" Or ds1.Tables(0).Rows(0).Item(3) = "水上爆撃機" Then
                    bl2 = 1
                    b1 = ds1.Tables(0).Rows(0).Item(2)
                    lz2 = 0
                    bz2 = b1
                Else
                    b1 = 0
                End If
            End If
            ds1.Clear()
            adors.Open("select 对空,雷装,爆装,类型 from feiji where 飞机名 = '" & zhikong(j).ComboBox4.Text & "'", adocn, 3, 3)
            da.Fill(ds2, adors, "feiji")
            c = ds2.Tables(0).Rows(0).Item(0)
            If ds2.Tables(0).Rows(0).Item(3) = "艦上攻撃機" Then
                bl3 = 0.8
                c1 = ds2.Tables(0).Rows(0).Item(1)
                lz3 = c1
                bz3 = 0
            Else
                If ds2.Tables(0).Rows(0).Item(3) = "艦上爆撃機" Or ds2.Tables(0).Rows(0).Item(3) = "水上爆撃機" Then
                    bl3 = 1
                    c1 = ds2.Tables(0).Rows(0).Item(2)
                    lz3 = 0
                    bz3 = c1
                Else
                    c1 = 0
                End If
            End If
            ds2.Clear()
            adors.Open("select 对空,雷装,爆装,类型 from feiji where 飞机名 = '" & zhikong(j).ComboBox5.Text & "'", adocn, 3, 3)
            da.Fill(ds3, adors, "feiji")
            d = ds3.Tables(0).Rows(0).Item(0)
            If ds3.Tables(0).Rows(0).Item(3) = "艦上攻撃機" Then
                bl4 = 0.8
                d1 = ds3.Tables(0).Rows(0).Item(1)
                lz4 = d1
                bz4 = 0
            Else
                If ds3.Tables(0).Rows(0).Item(3) = "艦上爆撃機" Or ds3.Tables(0).Rows(0).Item(3) = "水上爆撃機" Then
                    bl4 = 1
                    d1 = ds3.Tables(0).Rows(0).Item(2)
                    lz4 = 0
                    bz4 = d1
                Else
                    d1 = 0
                End If
            End If
            ds3.Clear()
            g = Int(a * (zhikong(j).Label1.Text) ^ 0.5) + Int(b * (zhikong(j).Label2.Text) ^ 0.5) + Int(c * (zhikong(j).Label3.Text) ^ 0.5) + Int(d * (zhikong(j).Label4.Text) ^ 0.5)
            f = g + f
            g1 = Int(bl1 * (a1 * ((zhikong(j).Label1.Text) ^ 0.5) + 25)) + Int(bl2 * (b1 * ((zhikong(j).Label2.Text) ^ 0.5) + 25)) + Int(bl3 * (c1 * ((zhikong(j).Label3.Text) ^ 0.5) + 25)) + Int(bl4 * (d1 * ((zhikong(j).Label4.Text) ^ 0.5) + 25))
            f1 = g1 + f1
            pjz = (hl + lz1 + lz2 + lz3 + lz4) * 1.5 + (bz1 + bz2 + bz3 + bz4) * 2 + 55
            zhikong(j).Label5.Text = "制空值:" + g.ToString
            zhikong(j).Label6.Text = "开幕攻击力:" + g1.ToString
            zhikong(j).Label7.Text = "炮击战攻击力:" + pjz.ToString
        Next
        adocn.Close()
        Label1.Text = "总制空值:" + f.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dituzhikong.Show()
        dituzhikong.TextBox1.Text = f
    End Sub
End Class
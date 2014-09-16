<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.每小时获得ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.远征ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.时给计算ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.制空值ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.制空值ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.地图ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.地图总揽ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '每小时获得ToolStripMenuItem
        '
        Me.每小时获得ToolStripMenuItem.Name = "每小时获得ToolStripMenuItem"
        Me.每小时获得ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.每小时获得ToolStripMenuItem.Text = "每小时获得"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.远征ToolStripMenuItem, Me.制空值ToolStripMenuItem, Me.地图ToolStripMenuItem, Me.TextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(285, 25)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '远征ToolStripMenuItem
        '
        Me.远征ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.时给计算ToolStripMenuItem})
        Me.远征ToolStripMenuItem.Name = "远征ToolStripMenuItem"
        Me.远征ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.远征ToolStripMenuItem.Text = "远征"
        '
        '时给计算ToolStripMenuItem
        '
        Me.时给计算ToolStripMenuItem.Name = "时给计算ToolStripMenuItem"
        Me.时给计算ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.时给计算ToolStripMenuItem.Text = "时给计算"
        '
        '制空值ToolStripMenuItem
        '
        Me.制空值ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.制空值ToolStripMenuItem1})
        Me.制空值ToolStripMenuItem.Name = "制空值ToolStripMenuItem"
        Me.制空值ToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.制空值ToolStripMenuItem.Text = "制空值"
        '
        '制空值ToolStripMenuItem1
        '
        Me.制空值ToolStripMenuItem1.Name = "制空值ToolStripMenuItem1"
        Me.制空值ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.制空值ToolStripMenuItem1.Text = "制空值"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem1})
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(41, 21)
        Me.TextToolStripMenuItem.Text = "test"
        Me.TextToolStripMenuItem.Visible = False
        '
        'TextToolStripMenuItem1
        '
        Me.TextToolStripMenuItem1.Name = "TextToolStripMenuItem1"
        Me.TextToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.TextToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TextToolStripMenuItem1.Text = "test"
        '
        '地图ToolStripMenuItem
        '
        Me.地图ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.地图总揽ToolStripMenuItem})
        Me.地图ToolStripMenuItem.Name = "地图ToolStripMenuItem"
        Me.地图ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.地图ToolStripMenuItem.Text = "地图"
        '
        '地图总揽ToolStripMenuItem
        '
        Me.地图总揽ToolStripMenuItem.Name = "地图总揽ToolStripMenuItem"
        Me.地图总揽ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.地图总揽ToolStripMenuItem.Text = "地图总揽"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "menu"
        Me.Size = New System.Drawing.Size(226, 27)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 每小时获得ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 远征ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 时给计算ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 制空值ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 制空值ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 地图ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 地图总揽ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

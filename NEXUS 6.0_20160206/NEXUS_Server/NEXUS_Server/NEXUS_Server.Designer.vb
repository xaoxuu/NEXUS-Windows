<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEXUS_Server
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NEXUS_Server))
        Me.托盘图标 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.右键菜单 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.魔枢搜索 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.打开魔枢 = New System.Windows.Forms.ToolStripMenuItem()
        Me.快捷启动 = New System.Windows.Forms.ToolStripMenuItem()
        Me.立即更新 = New System.Windows.Forms.ToolStripMenuItem()
        Me.意见反馈 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出后台 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.热键 = New System.Windows.Forms.Panel()
        Me.右键菜单.SuspendLayout()
        Me.SuspendLayout()
        '
        '托盘图标
        '
        Me.托盘图标.BalloonTipText = "NEXUS 4.4"
        Me.托盘图标.BalloonTipTitle = "NEXUS"
        Me.托盘图标.ContextMenuStrip = Me.右键菜单
        Me.托盘图标.Icon = CType(resources.GetObject("托盘图标.Icon"), System.Drawing.Icon)
        Me.托盘图标.Text = "双击启动魔枢"
        Me.托盘图标.Visible = True
        '
        '右键菜单
        '
        Me.右键菜单.BackColor = System.Drawing.Color.White
        Me.右键菜单.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.右键菜单.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.右键菜单.ImageScalingSize = New System.Drawing.Size(0, 0)
        Me.右键菜单.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.魔枢搜索, Me.ToolStripSeparator1, Me.打开魔枢, Me.快捷启动, Me.立即更新, Me.意见反馈, Me.ToolStripSeparator2, Me.退出后台})
        Me.右键菜单.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.右键菜单.Name = "ContextMenuStrip"
        Me.右键菜单.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.右键菜单.Size = New System.Drawing.Size(134, 160)
        '
        '魔枢搜索
        '
        Me.魔枢搜索.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.魔枢搜索.Name = "魔枢搜索"
        Me.魔枢搜索.ShowShortcutKeys = False
        Me.魔枢搜索.Size = New System.Drawing.Size(133, 24)
        Me.魔枢搜索.Text = "魔枢搜索"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
        '
        '打开魔枢
        '
        Me.打开魔枢.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.打开魔枢.Name = "打开魔枢"
        Me.打开魔枢.ShowShortcutKeys = False
        Me.打开魔枢.Size = New System.Drawing.Size(133, 24)
        Me.打开魔枢.Text = "打开魔枢"
        '
        '快捷启动
        '
        Me.快捷启动.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.快捷启动.Name = "快捷启动"
        Me.快捷启动.ShowShortcutKeys = False
        Me.快捷启动.Size = New System.Drawing.Size(133, 24)
        Me.快捷启动.Text = "快捷启动"
        '
        '立即更新
        '
        Me.立即更新.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.立即更新.Name = "立即更新"
        Me.立即更新.ShowShortcutKeys = False
        Me.立即更新.Size = New System.Drawing.Size(133, 24)
        Me.立即更新.Text = "立即更新"
        '
        '意见反馈
        '
        Me.意见反馈.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.意见反馈.Name = "意见反馈"
        Me.意见反馈.ShowShortcutKeys = False
        Me.意见反馈.Size = New System.Drawing.Size(133, 24)
        Me.意见反馈.Text = "意见反馈"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(130, 6)
        '
        '退出后台
        '
        Me.退出后台.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.退出后台.Name = "退出后台"
        Me.退出后台.ShowShortcutKeys = False
        Me.退出后台.Size = New System.Drawing.Size(133, 24)
        Me.退出后台.Text = "退出后台"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("微軟正黑體 Light", 12.0!)
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShowShortcutKeys = False
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ToolStripMenuItem1.Text = "打开魔枢"
        '
        '热键
        '
        Me.热键.BackColor = System.Drawing.Color.Black
        Me.热键.Dock = System.Windows.Forms.DockStyle.Left
        Me.热键.Location = New System.Drawing.Point(0, 0)
        Me.热键.Name = "热键"
        Me.热键.Size = New System.Drawing.Size(5, 43)
        Me.热键.TabIndex = 1
        '
        'NEXUS_Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(100, 43)
        Me.ControlBox = False
        Me.Controls.Add(Me.热键)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NEXUS_Server"
        Me.Opacity = 0.01R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "NEXUS_Server"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.右键菜单.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 托盘图标 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 右键菜单 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 意见反馈 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出后台 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 魔枢搜索 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 立即更新 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 快捷启动 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 热键 As System.Windows.Forms.Panel
    Friend WithEvents 打开魔枢 As System.Windows.Forms.ToolStripMenuItem

End Class

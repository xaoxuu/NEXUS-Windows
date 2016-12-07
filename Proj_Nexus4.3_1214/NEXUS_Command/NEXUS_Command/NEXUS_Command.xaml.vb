Class MainWindow
    Dim Inputs, Address As String
    Dim WshShell = CreateObject("WScript.Shell")


    Private Sub window_Initialized(sender As Object, e As EventArgs) Handles NEXUS_Command.Initialized

        Grid_Expand0.Visibility = Windows.Visibility.Hidden

        图案_搜索.Visibility = Windows.Visibility.Hidden
        Input.MinWidth = 240
        Rectangle_Ctrl.Visibility = Windows.Visibility.Visible
        Fun_Tips("0")
        Fun_Opacity(1)
        Input.Text = "What do you want ?"

        Ellipse2.Visibility = Windows.Visibility.Hidden
        Ellipse3.Visibility = Windows.Visibility.Hidden
        Ellipse4.Visibility = Windows.Visibility.Hidden
        Ellipse5.Visibility = Windows.Visibility.Hidden
        Ellipse6.Visibility = Windows.Visibility.Hidden
    End Sub
    '↑↑↑初始化
    Private Sub Input_GotMouseCapture(sender As Object, e As MouseEventArgs) Handles Input.GotMouseCapture
        If Input.Text = "What do you want ?" Then
            Input.Clear()
        End If
    End Sub
    Private Sub MainGrid_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles MainGrid.PreviewKeyDown
        If Input.Text = "What do you want ?" Then
            Input.Clear()
        End If
    End Sub
    '↑↑↑键按下
    Private Sub AfterRun()
        Fun_Close()
    End Sub
    '↑↑↑AfterRun()


    '━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    '鼠标动作检测↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
    Private Sub MainGrid_PreviewMouseWheel(sender As Object, e As MouseWheelEventArgs) Handles MainGrid.PreviewMouseWheel
        Fun_Clear()
    End Sub
    '↑↑↑滑轮
    Private Sub MainWindow_MouseEnter(sender As Object, e As MouseEventArgs) Handles Me.MouseEnter
        Fun_Opacity(1)
    End Sub
    '↑↑↑鼠标进入Main
    Private Sub MainWindow_MouseLeave(sender As Object, e As MouseEventArgs) Handles Me.MouseLeave
        Fun_Opacity(1)
    End Sub
    '↑↑↑鼠标离开Main
    Private Sub Button_Expand_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button_Expand.MouseEnter
        Fun_Tips("点击打开或关闭菜单。")
        Grid_Expand0.Visibility = Windows.Visibility.Visible
    End Sub
    '↑↑↑鼠标进入Expand
    Private Sub Button_Expand_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button_Expand.MouseLeave
        Fun_Tips("0")
        Grid_Expand0.Visibility = Windows.Visibility.Hidden
    End Sub
    '↑↑↑鼠标离开Expand
    Private Sub Button_Search_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button_Search.MouseEnter
        Dim i As String
        If Input.Text = "What do you want ?" Or Input.Text = "" Then
            Fun_Tips("点击打开百度主页。")
        Else
            i = "点击使用百度搜索【" + Input.Text + "】"
            Fun_Tips(i)
        End If
    End Sub
    '↑↑↑鼠标进入搜索按钮

    Private Sub Button_Search_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button_Search.MouseLeave
        Fun_Tips("0")
        Button_Search_Show.Visibility = Windows.Visibility.Visible
        图案_搜索.Visibility = Windows.Visibility.Hidden
    End Sub
    '↑↑↑鼠标离开搜索按钮
    Private Sub Border_Left_MouseEnter(sender As Object, e As MouseEventArgs) Handles Border_Left.MouseEnter
        Dim i As String
        If Input.Text = "What do you want ?" Or Input.Text = "" Then
            Fun_Tips("点击关闭程序。")
        Else
            i = "点击使用百度搜索【" + Input.Text + "】"
            Fun_Tips(i)
        End If
    End Sub
    '↑↑↑鼠标进入左边框
    Private Sub Border_Left_MouseLeave(sender As Object, e As MouseEventArgs) Handles Border_Left.MouseLeave
        Fun_Tips("0")
    End Sub
    '↑↑↑鼠标离开左边框
    Private Sub Border_Up_MouseEnter(sender As Object, e As MouseEventArgs) Handles Border_Up.MouseEnter
        Dim i As String
        If Input.Text = "What do you want ?" Or Input.Text = "" Then
            Fun_Tips("点击关闭程序。")
        Else
            i = "点击使用百度搜索【" + Input.Text + "】"
            Fun_Tips(i)
        End If
    End Sub
    '↑↑↑鼠标进入上边框

    Private Sub Border_Up_MouseLeave(sender As Object, e As MouseEventArgs) Handles Border_Up.MouseLeave
        Fun_Tips("0")
    End Sub
    '↑↑↑鼠标离开上边框

    '鼠标动作检测↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑
    '━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
    '子函数↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

    Private Sub Fun_Opacity(i As Double)
        Input.Opacity = i
        Button_Expand.Opacity = i
        Button_Search.Opacity = i
        TipsGrid.Opacity = i
        Grid_Expand0_Show.Opacity = i

    End Sub
    '↑↑↑模块透明
    Private Sub Fun_Search()
        If Input.Text = "What do you want ?" Then '退出
            End
        End If
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=" + Input.Text & Chr(34))
        Fun_Close()
    End Sub
    '↑↑↑Enter搜索
    Private Sub Fun_Close()

        End
    End Sub
    '↑↑↑退出命令
    Private Sub Fun_Enter()
        Inputs = LCase(Input.Text)
        Fun_Search()
    End Sub
    '↑↑↑确认命令
    Private Sub Fun_Clear()
        Input.Clear()
        TimeBox.Clear()
    End Sub
    '↑↑↑清空命令
    Private Sub Fun_Tips(i As String)
        If i = "0" Then
            TipsGrid.Visibility = Windows.Visibility.Hidden
            TimeBox.Visibility = Windows.Visibility.Hidden
            TimeBlock.Visibility = Windows.Visibility.Hidden
            If Input.MinWidth = 420 Then
            Else
                Rectangle_Ctrl.Visibility = Windows.Visibility.Hidden
            End If

        ElseIf i = "1" Then
            TipsGrid.Visibility = Windows.Visibility.Hidden
            TimeBox.Visibility = Windows.Visibility.Visible
            TimeBlock.Visibility = Windows.Visibility.Visible
            Rectangle_Ctrl.Visibility = Windows.Visibility.Visible
        Else
            Rectangle_Ctrl.Visibility = Windows.Visibility.Visible
            TipsGrid.Visibility = Windows.Visibility.Visible
            Tips.Text = "       " + i
        End If
    End Sub
    '↑↑↑消息框显示

    Private Sub Fun_Clock(i As String)
        Dim shutdown, output, tin, min, hour, ts As String
        WshShell = CreateObject("WScript.Shell")
        WshShell.run("shutdown -a", vbHide)
        tin = TimeBox.Text
        If i = "执行" Then
            If tin < 10 Then
                If tin = Int(tin) Then
                    hour = tin
                    output = "电脑将在" + hour + "小时后关闭。"
                Else
                    hour = Int(tin)
                    min = 60 * tin - 60 * hour
                    output = "电脑将在" + hour + "小时" + min + "分钟后关闭。"
                End If
                ts = 3600 * tin
                shutdown = "shutdown -s -t  " + ts
            ElseIf tin < 60 Then
                min = tin
                output = "电脑将在" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s -t  " + ts
            Else
                min = tin
                hour = Int(tin \ 60)
                min = min - 60 * hour
                output = "电脑将在" + hour + "小时" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s -t  " + ts
            End If
            WshShell.run(shutdown, vbHide)
            Tips.Text = "       " + output
        ElseIf i = "取消" Then
            WshShell.run("shutdown -a", vbHide)
            Tips.Text = "       " + "定时任务已经取消。"
        End If
    End Sub
    '↑↑↑定时关机
    Private Sub Fun_Hide(i As String)
        Dim a1, a2 As String
        If i = "Hide1" Then
            a1 = "attrib +a +s +h +r " + Chr(34) & "C:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "C:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib +a +s +h +r " + Chr(34) & "D:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "D:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib +a +s +h +r " + Chr(34) & "E:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "E:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib +a +s +h +r " + Chr(34) & "F:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "F:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib +a +s +h +r " + Chr(34) & "G:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "G:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib +a +s +h +r " + Chr(34) & "H:\Program Files" & Chr(34)
            a2 = "attrib +a +s +h +r " + Chr(34) & "H:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            Tips.Text = "       " + "【Program Files】文件夹已经隐藏，如需取消，请输入【unhide】。"
        ElseIf i = "Hide0" Then
            a1 = "attrib -a -s -h -r " + Chr(34) & "C:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "C:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib -a -s -h -r " + Chr(34) & "D:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "D:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib -a -s -h -r " + Chr(34) & "E:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "E:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib -a -s -h -r " + Chr(34) & "F:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "F:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib -a -s -h -r " + Chr(34) & "G:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "G:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            a1 = "attrib -a -s -h -r " + Chr(34) & "H:\Program Files" & Chr(34)
            a2 = "attrib -a -s -h -r " + Chr(34) & "H:\Program Files (x86)" & Chr(34)
            WshShell.run(a1, vbHide)
            WshShell.run(a2, vbHide)
            Tips.Text = "       " + "【Program Files】文件夹已经取消隐藏，如需隐藏，请输入【hide】。"
        ElseIf i = "Hide1s" Then
            a1 = "attrib +a +s +h +r " + Chr(34) & Input.Text & Chr(34)
            WshShell.run(a1, vbHide)
            Tips.Text = "       " + "【" + Input.Text + "】文件夹已经隐藏，请务必记好路径。"
        ElseIf i = "Hide0s" Then
            a1 = "attrib -a -s -h -r " + Chr(34) & Input.Text & Chr(34)
            WshShell.run(a1, vbHide)
            Tips.Text = "       " + "【" + Input.Text + "】文件夹已经取消隐藏。"

        End If
    End Sub

    Private Sub Fun_Run(i As String)
        WshShell.run(i)
        Fun_Close()
    End Sub
    '↑↑↑执行命令

    Private Sub Roll()
        If Ellipse1.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Visible
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse2.Visibility = Windows.Visibility.Visible Then

            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Visible
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse3.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Visible
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse4.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Visible
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse5.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Visible
        ElseIf Ellipse6.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Visible
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    Private Sub Fun_Launch()
        Dim i, j As String
        i = Input.Text + ".lnk"
        j = "D:\Program Files\NEXUS\Temp\NEXUSLaunch\" + i
        If Dir(j) = "" Then

        Else
            j = Chr(34) & j & Chr(34)
            WshShell.run(j)
            End
        End If
    End Sub
    '↑↑↑快捷启动

    '子函数↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑


    '━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

    '键盘和按钮检测↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

    Private Sub Key_Enter_Click(sender As Object, e As RoutedEventArgs) Handles Key_Enter.Click
        Fun_Enter()
    End Sub
    '↑↑↑Enter键
    Private Sub Key_Esc_Click(sender As Object, e As RoutedEventArgs) Handles Key_Esc.Click
        Fun_Close()
    End Sub
    '↑↑↑Esc键
    Private Sub Button_Expand_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Expand.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Setting\ControlSetting\NEXUS_Box.vbs" & Chr(34))
        Grid_Expand0_Show.Visibility = Windows.Visibility.Hidden

        Grid_Expand0.Visibility = Windows.Visibility.Hidden

    End Sub
    '↑↑↑Expand按钮
    Private Sub Button_Search_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Search.MouseDown
        Fun_Enter()
    End Sub
    '按下搜索按钮
    Private Sub Button_Cancel_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Cancel.MouseDown
        If TimeBox.Visibility = Windows.Visibility.Visible Then
            Fun_Clock("取消")
        Else
            Fun_Hide("Hide1s")
        End If
    End Sub
    '↑↑↑取消按钮
    Private Sub Button_OK_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_OK.MouseDown
        If TimeBox.Visibility = Windows.Visibility.Visible Then
            If TimeBox.Text = "" Then
                Tips.Text = "请在下方输入时间后再点击【确定】。"
            Else
                Fun_Clock("执行")
            End If
        Else
            Fun_Hide("Hide0s")
        End If
    End Sub
    '↑↑↑确定按钮     
    Private Sub Border_Left_MouseDown(sender As Object, e As RoutedEventArgs) Handles Border_Left.MouseDown
        If Input.Text = "What do you want ?" Or Input.Text = "" Then
            Fun_Close()
        Else
            Fun_Enter()
        End If
    End Sub
    '↑↑↑左边框
    Private Sub Border_Up_MouseDown(sender As Object, e As RoutedEventArgs) Handles Border_Up.MouseDown
        If Input.Text = "What do you want ?" Or Input.Text = "" Then
            Fun_Close()
        Else
            Fun_Enter()
        End If
    End Sub
    '↑↑↑上边框
    Private Sub TimeBox_Keyup(sender As Object, e As KeyEventArgs) Handles TimeBox.KeyUp
        Dim tin As String
        tin = TimeBox.Text
        If tin = "" Then
            TimeBlock.Text = "时间"
        Else
            If tin > 0 Then
                If tin < 10 Then
                    TimeBlock.Text = "小时"
                ElseIf tin >= 10 Then
                    TimeBlock.Text = "分钟"
                End If
            End If
        End If
    End Sub

    Private Sub Input_KeyDown(sender As Object, e As KeyEventArgs) Handles Input.KeyDown
        Roll()
    End Sub

    Private Sub Input_KeyUp(sender As Object, e As KeyEventArgs) Handles Input.KeyUp
        Roll()
    End Sub
    '↑↑↑定时关机输入检测
    Private Sub Input_TextChanged(sender As Object, e As TextChangedEventArgs) Handles Input.TextChanged

        Inputs = LCase(Input.Text)
        Fun_Launch()
        '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■基本组件和服务
        If Inputs = "help" Then 'help
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Setting\ControlSetting\NEXUS_Box.vbs" & Chr(34))
            Fun_Clear()
        ElseIf Inputs = "定时关机" Or Inputs = "dsgj" Then '定时关机
            Fun_Tips("1")
            Fun_Tips("请输入时间（纯数字），更详细的使用细节请在设置栏里找。")
            Button_Cancel.Text = "取消"
            Button_OK.Text = "确定"

            Input.MinWidth = 420
            Rectangle_Ctrl.Visibility = Windows.Visibility.Visible

            Fun_Clear()
        ElseIf Inputs = "end" Then '隐藏
            End
        ElseIf Inputs = "bromance" Then '隐藏
            Address = (Chr(34) & "D:\Bromance" & Chr(34))
            Fun_Run(Address)
        ElseIf Inputs = "hide" Then '隐藏
            Fun_Hide("Hide1")
            Fun_Clear()
            Fun_Tips("【Program Files】文件夹已经隐藏，如需取消，请输入【unhide】。")
        ElseIf Inputs = "unhide" Then '隐藏
            Fun_Hide("Hide0")
            Fun_Clear()
            Fun_Tips("【Program Files】文件夹已经取消隐藏，如需隐藏，请输入【hide】。")
        ElseIf Input.Text = "NEXUS" Then '隐藏
            Fun_Clear()
            Fun_Tips("0")
            Fun_Tips("请在上方输入完整路径，然后选择隐藏或显示。")
            Button_Cancel.Text = "隐藏"
            Button_OK.Text = "显示"

            Input.MinWidth = 420
            Rectangle_Ctrl.Visibility = Windows.Visibility.Visible

        ElseIf Inputs = "office助手" Then 'office助手
            Address = (Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Office.exe" & Chr(34))
            Fun_Run(Address)
        ElseIf Inputs = "会声会影助手" Then '会声会影助手
            Address = (Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_VideoStudio.exe" & Chr(34))
            Fun_Run(Address)
        ElseIf Inputs = "adobe助手" Then 'adobe助手
            Address = (Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Adobe.exe" & Chr(34))
            Fun_Run(Address)





        ElseIf Inputs = "kuand" Or Inputs = "路由器" Or Inputs = "luyouq" Or Inputs = "宽带" Then '宽带
            Address = ("http://192.168.0.1/advance.asp")
            Fun_Run(Address)
        ElseIf Inputs = "更新" Or Inputs = "gengx" Or Inputs = "uuuuuuuuuu" Then '更新
            Address = ("http://pan.baidu.com/s/12IKJ8#path=%252F%25E5%25AE%25A2%25E6%2588%25B7%25E7%25AB%25AF")
            Fun_Run(Address)
        ElseIf Inputs = "反馈" Or Inputs = "fankui" Or Inputs = "fanku" Or Inputs = "建议" Or Inputs = "意见" Then '反馈
            Address = ("http://www.sojump.com/m/3499620.aspx")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■打开路径
        ElseIf Inputs = "我的电脑" Then
            Address = ("explorer.exe")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■打开功能
        ElseIf Inputs = "磁盘管理" Then
            Address = ("diskmgmt.msc")
            Fun_Run(Address)
        ElseIf Inputs = "calc" Or Inputs = "jisuanq" Or Inputs = "计算器" Then
            Address = ("calc.exe")
            Fun_Run(Address)
        ElseIf Inputs = "控制面板" Or Inputs = "control" Or Inputs = "kongzhimianb" Then
            Address = ("control.exe")
            Fun_Run(Address)
        ElseIf Inputs = "cmd" Then
            Address = ("cmd.exe")
            Fun_Run(Address)
        ElseIf Inputs = "任务管理器" Or Inputs = "task" Or Inputs = "renwug" Then
            Address = ("taskmgr.exe")
            Fun_Run(Address)
        ElseIf Inputs = "用户帐户" Then
            Address = ("netplwiz.exe")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■电源功能
        ElseIf Inputs = "取消定时" Or Inputs = "取消关机" Or Inputs = "取消休眠" Then
            Address = ("shutdown -a")
            Fun_Run(Address)
        ElseIf Inputs = "ssssssssss" Then
            Address = ("shutdown -s -t 1")
            Fun_Run(Address)
        ElseIf Inputs = "hhhhhhhhhh" Then
            Address = ("shutdown -h")
            Fun_Run(Address)
        ElseIf Inputs = "llllllllll" Then
            Address = ("shutdown -l")
            Fun_Run(Address)
        ElseIf Inputs = "rrrrrrrrrr" Then
            Address = ("shutdown -r")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■学生周边

        ElseIf Inputs = "luoyanglig" Or Inputs = "洛阳理工" Or Inputs = "洛阳理工学院" Or Inputs = "lit" Then
            Address = ("http://www.lit.edu.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "学校贴吧" Or Inputs = "洛理贴吧" Or Inputs = "洛理小窝" Then
            Address = ("http://tieba.baidu.com/f?kw=%C2%E5%D1%F4%C0%ED%B9%A4%D1%A7%D4%BA&fr")
            Fun_Run(Address)
        ElseIf Inputs = "jiaowuzaix" Or Inputs = "教务在线" Or Inputs = "教务网络" Then
            Address = ("http://202.196.192.25/lyit/")
            Fun_Run(Address)
        ElseIf Inputs = "kebia" Or Inputs = "课表" Or Inputs = "课程表" Then
            Address = ("http://202.196.192.25/lyit/ZNPK/KBFB_ClassSel.aspx")
            Fun_Run(Address)
        ElseIf Inputs = "xiaoli" Or Inputs = "校历" Then
            Address = ("http://211.84.112.49/lyit/_data/index_Lookxl.aspx")
            Fun_Run(Address)
        ElseIf Inputs = "四六级" Or Inputs = "cet" Or Inputs = "四六级成绩" Or Inputs = "四级" Or Inputs = "四级成绩" Or Inputs = "六级" Or Inputs = "六级成绩" Or Inputs = "99宿舍" Or Inputs = "cet4" Or Inputs = "cet6" Then
            Address = ("http://cet.99sushe.com/")
            Fun_Run(Address)
        ElseIf Inputs = "计算机二级" Or Inputs = "NCRE" Or Inputs = "计算机三级" Or Inputs = "计算机二级成绩" Or Inputs = "计算机三级成绩 " Then
            Address = ("http://chaxun.neea.edu.cn/examcenter/query.cn?op=doQueryCond&sid=300&pram=results")
            Fun_Run(Address)
        ElseIf Inputs = "学习导航" Or Inputs = "学习网站" Then
            Address = ("http://www.hao123.com/eduhtm_qyqx")
            Fun_Run(Address)
        ElseIf Inputs = "网易公开课" Then
            Address = ("http://open.163.com/")
            Fun_Run(Address)
        ElseIf Inputs = "公开课" Then
            Address = ("http://www.oer.edu.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "中国公开课" Then
            Address = ("http://opencla.cntv.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪公开课" Then
            Address = ("http://open.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "51自学网" Or Inputs = "我要自学网" Then
            Address = ("http://www.51zxw.net/")
            Fun_Run(Address)
        ElseIf Inputs = "大学视频教程网" Then
            Address = ("http://www.mycampus.hk/")
            Fun_Run(Address)
        ElseIf Inputs = "爱问" Or Inputs = "新浪爱问" Then
            Address = ("http://ishare.iask.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "沪江网" Or Inputs = "沪江" Then
            Address = ("http://www.hujiang.com/")
            Fun_Run(Address)
        ElseIf Inputs = "coursera" Then
            Address = ("https://www.coursera.org/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■搜索分类

        ElseIf Inputs = "google搜索" Or Inputs = "谷歌搜索" Then
            Address = ("http://www.google.com.hk/")
            Fun_Run(Address)
        ElseIf Inputs = "谷歌翻译" Or Inputs = "翻译" Or Inputs = "google翻译" Then
            Address = ("http://translate.google.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "百科" Or Inputs = "百度百科" Then
            Address = ("http://baike.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "百度视频" Then
            Address = ("http://v.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "文库" Or Inputs = "百度文库" Then
            Address = ("http://wenku.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "百度图片" Then
            Address = ("http://image.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "知道" Or Inputs = "百度知道" Then
            Address = ("http://zhidao.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "地图" Or Inputs = "百度地图" Then
            Address = ("http://map.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新闻" Or Inputs = "百度新闻" Then
            Address = ("http://news.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "贴吧" Or Inputs = "百度贴吧" Then
            Address = ("http://tieba.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "百度音乐" Then
            Address = ("http://music.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "搜搜" Or Inputs = "soso" Then
            Address = ("http://www.soso.com/")
            Fun_Run(Address)
        ElseIf Inputs = "维基百科" Or Inputs = "wiki" Then
            Address = ("http://zh.wikipedia.org/")
            Fun_Run(Address)
        ElseIf Inputs = "互动百科" Then
            Address = ("http://www.baike.com/")
            Fun_Run(Address)
        ElseIf Inputs = "google地图" Or Inputs = "谷歌地图" Then
            Address = ("http://ditu.google.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "google地球" Or Inputs = "谷歌地球" Then
            Address = ("http://www.google.com/earth/index.html")
            Fun_Run(Address)
        ElseIf Inputs = "百度经验" Or Inputs = "经验" Then
            Address = ("http://jingyan.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "谷歌学术" Or Inputs = "学术" Then
            Address = ("http://scholar.google.com/")
            Fun_Run(Address)
        ElseIf Inputs = "网盘搜索" Then
            Address = ("http://www.5p44.com/")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■名站导航
        ElseIf Inputs = "hao123" Or Inputs = "网站导航" Then
            Address = ("http://www.hao123.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪" Or Inputs = "新浪网" Or Inputs = "sina" Then
            Address = ("http://www.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "网易" Or Inputs = "163" Then
            Address = ("http://www.163.com/")
            Fun_Run(Address)
        ElseIf Inputs = "腾讯" Or Inputs = "腾讯网" Then
            Address = ("http://www.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "搜狐" Or Inputs = "搜狐网" Then
            Address = ("http://www.sohu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "凤凰" Or Inputs = "凤凰网" Then
            Address = ("http://www.ifeng.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新华" Or Inputs = "新华网" Then
            Address = ("http://www.news.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "龙腾网" Then
            Address = ("http://www.ltShowHelpa.com/")
            Fun_Run(Address)
        ElseIf Inputs = "强国社区" Then
            Address = ("http://bbs1.people.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "it之家" Then
            Address = ("http://www.ithome.com/")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■购物网站
        ElseIf Inputs = "购物导航" Or Inputs = "购物网站" Then
            Address = ("http://gouwu.hao123.com/")
            Fun_Run(Address)
        ElseIf Inputs = "中关村" Or Inputs = "zol" Then
            Address = ("http://www.zol.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "淘宝" Or Inputs = "tb" Or Inputs = "taobao" Then
            Address = ("http://www.taobao.com/")
            Fun_Run(Address)
        ElseIf Inputs = "天猫" Or Inputs = "tmall" Then
            Address = ("http://www.tmall.com/")
            Fun_Run(Address)
        ElseIf Inputs = "亚马逊" Or Inputs = "z.cn" Or Inputs = "amazon" Then
            Address = ("http://www.amazon.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "京东" Or Inputs = "jd" Then
            Address = ("http://www.jd.com/")
            Fun_Run(Address)
        ElseIf Inputs = "苏宁" Or Inputs = "苏宁易购" Then
            Address = ("http://www.suning.com/")
            Fun_Run(Address)
        ElseIf Inputs = "当当" Or Inputs = "当当网" Then
            Address = ("http://www.dangdang.com/")
            Fun_Run(Address)
        ElseIf Inputs = "12306" Or Inputs = "火车票" Then
            Address = ("http://www.12306.cn/mormhweb/")
            Fun_Run(Address)
        ElseIf Inputs = "携程" Or Inputs = "携程网" Then
            Address = ("http://www.ctrip.com/")
            Fun_Run(Address)
        ElseIf Inputs = "赶集" Or Inputs = "赶集网" Then
            Address = ("http://www.ganji.com/index.htm")
            Fun_Run(Address)
        ElseIf Inputs = "58同城" Then
            Address = ("http://bj.58.com/")
            Fun_Run(Address)
        ElseIf Inputs = "1号店" Then
            Address = ("http://www.yhd.com/")
            Fun_Run(Address)
        ElseIf Inputs = "去哪儿" Or Inputs = "去哪儿网" Then
            Address = ("http://www.qunar.com/")
            Fun_Run(Address)
        ElseIf Inputs = "凡客" Or Inputs = "凡客诚品" Or Inputs = "vancl" Or Inputs = "凡客网" Then
            Address = ("http://www.vancl.com/")
            Fun_Run(Address)
        ElseIf Inputs = "拍拍网" Or Inputs = "拍拍" Then
            Address = ("http://www.paipai.com/")
            Fun_Run(Address)
        ElseIf Inputs = "阿里巴巴" Or Inputs = "1688" Then
            Address = ("http://www.1688.com/")
            Fun_Run(Address)
        ElseIf Inputs = "前程无忧" Then
            Address = ("http://www.51job.com/")
            Fun_Run(Address)
        ElseIf Inputs = "美团" Or Inputs = "美团网" Then
            Address = ("http://www.meituan.com/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■音乐网站
        ElseIf Inputs = "音乐导航" Or Inputs = "音乐网站" Then
            Address = ("http://www.hao123.com/music/wangzhi")
            Fun_Run(Address)

        ElseIf Inputs = "soso音乐" Or Inputs = "QQ音乐" Or Inputs = "搜搜音乐" Then
            Address = ("http://music.soso.com/index.html")
            Fun_Run(Address)
        ElseIf Inputs = "虾米音乐" Or Inputs = "虾米" Then
            Address = ("http://www.xiami.com/")
            Fun_Run(Address)
        ElseIf Inputs = "酷狗音乐" Or Inputs = "酷狗" Or Inputs = "kugou" Then
            Address = ("http://www.kugou.com/")
            Fun_Run(Address)
        ElseIf Inputs = "酷我音乐" Or Inputs = "酷我" Or Inputs = "酷我音乐盒" Then
            Address = ("http://www.kuwo.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "一听音乐" Then
            Address = ("http://www.1ting.com/")
            Fun_Run(Address)
        ElseIf Inputs = "多米音乐" Or Inputs = "多米" Then
            Address = ("http://www.duomi.com/")
            Fun_Run(Address)
        ElseIf Inputs = "音悦台" Then
            Address = ("http://www.yinyuetai.com/")
            Fun_Run(Address)
        ElseIf Inputs = "搜狗音乐" Then
            Address = ("http://mp3.sogou.com/")
            Fun_Run(Address)
        ElseIf Inputs = "九酷音乐" Then
            Address = ("http://www.9ku.com/")
            Fun_Run(Address)
        ElseIf Inputs = "midomi" Then
            Address = ("http://www.midomi.com/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■视频网站
        ElseIf Inputs = "视频导航" Or Inputs = "视频网站" Then
            Address = ("http://www.hao123.com/video")
            Fun_Run(Address)

        ElseIf Inputs = "优酷" Or Inputs = "youku" Or Inputs = "优酷视频" Or Inputs = "优酷网" Then
            Address = ("http://www.youku.com/")
            Fun_Run(Address)
        ElseIf Inputs = "土豆" Or Inputs = "tudou" Or Inputs = "土豆视频" Or Inputs = "土豆网" Then
            Address = ("http://www.tudou.com/")
            Fun_Run(Address)
        ElseIf Inputs = "爱奇艺" Or Inputs = "iqiyi" Then
            Address = ("http://www.iqiyi.com/")
            Fun_Run(Address)
        ElseIf Inputs = "pps" Then
            Address = ("http://www.pps.tv/")
            Fun_Run(Address)
        ElseIf Inputs = "pptv" Then
            Address = ("http://www.pptv.com/")
            Fun_Run(Address)
        ElseIf Inputs = "youtube" Then
            Address = ("https://www.youtube.com/")
            Fun_Run(Address)
        ElseIf Inputs = "乐视" Or Inputs = "letv" Then
            Address = ("http://www.letv.com/")
            Fun_Run(Address)
        ElseIf Inputs = "迅雷看看" Then
            Address = ("http://www.kankan.com/")
            Fun_Run(Address)
        ElseIf Inputs = "腾讯视频" Then
            Address = ("http://v.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪视频" Then
            Address = ("http://video.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "网易视频" Then
            Address = ("http://v.163.com/")
            Fun_Run(Address)
        ElseIf Inputs = "cctv" Or Inputs = "cntv" Then
            Address = ("http://cctv.cntv.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "面包网" Then
            Address = ("http://www.mianbao.com/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■军事网站
        ElseIf Inputs = "军事导航" Or Inputs = "军事网站" Then
            Address = ("http://www.hao123.com/junshi")
            Fun_Run(Address)
        ElseIf Inputs = "环球网军事" Or Inputs = "环球军事" Or Inputs = "环球网" Then
            Address = ("http://mil.huanqiu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "凤凰军事" Then
            Address = ("http://v.ifeng.com/mil/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪军事" Then
            Address = ("http://mil.news.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "中国战略网" Or Inputs = "战略网" Then
            Address = ("http://www.chinaClickNumberiss.com/")
            Fun_Run(Address)
        ElseIf Inputs = "中华军事" Then
            Address = ("http://military.china.com/zh_cn/")
            Fun_Run(Address)
        ElseIf Inputs = "军情观察室" Then
            Address = ("http://phtv.ifeng.com/program/jqgcs/")
            Fun_Run(Address)
        ElseIf Inputs = "军情解码" Then
            Address = ("http://v.ifeng.com/show/jqjm/index.shtml")
            Fun_Run(Address)
        ElseIf Inputs = "cntv军事" Or Inputs = "cctv军事" Then
            Address = ("http://military.cntv.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "中国军网" Or Inputs = "军网" Then
            Address = ("http://www.chinamil.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "铁血网" Then
            Address = ("http://www.tiexue.net/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■体育网站
        ElseIf Inputs = "体育导航" Or Inputs = "体育网站" Then
            Address = ("http://www.hao123.com/sports/wangzhi")
            Fun_Run(Address)
        ElseIf Inputs = "新浪竞技风暴" Then
            Address = ("http://sports.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "虎扑" Or Inputs = "虎扑体育" Then
            Address = ("http://www.hupu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "直播吧" Or Inputs = "直播" Then
            Address = ("http://www.zhibo8.cc/")
            Fun_Run(Address)
        ElseIf Inputs = "nba中国" Or Inputs = "nba" Then
            Address = ("http://china.nba.com/")
            Fun_Run(Address)
        ElseIf Inputs = "中国篮协" Or Inputs = "篮协" Then
            Address = ("http://www.cba.gov.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "中国足协" Or Inputs = "国足" Or Inputs = "足协" Then
            Address = ("http://www.fa.org.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "武林风" Then
            Address = ("http://www.iqiyi.com/zongyi/wlf.html?src=aldzy")
            Fun_Run(Address)
        ElseIf Inputs = "中羽在线" Then
            Address = ("http://www.badmintoncn.com/")
            Fun_Run(Address)
        ElseIf Inputs = "精英乒乓网" Then
            Address = ("http://www.pingpang.info/bbs/index.asp")
            Fun_Run(Address)
        ElseIf Inputs = "nba新浪" Then
            Address = ("http://sports.sina.com.cn/nba/")
            Fun_Run(Address)
        ElseIf Inputs = "cctv5" Or Inputs = "央视体育" Or Inputs = "cctv体育" Then
            Address = ("http://sports.cntv.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "tom体育" Then
            Address = ("http://sports.tom.com/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■社区论坛
        ElseIf Inputs = "社区导航" Or Inputs = "社区网站" Then
            Address = ("http://www.hao123.com/shequ")
            Fun_Run(Address)

        ElseIf Inputs = "facebook" Then
            Address = ("https://www.Facebook.com/")
            Fun_Run(Address)
        ElseIf Inputs = "人人" Or Inputs = "renren" Or Inputs = "人人网" Then
            Address = ("http://www.renren.com/")
            Fun_Run(Address)
        ElseIf Inputs = "飞信" Or Inputs = "fetion" Then
            Address = ("http://webim.feixin.10086.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "msn" Or Inputs = "msn中文网" Then
            Address = ("http://cn.msn.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪微博" Or Inputs = "微博" Or Inputs = "weibo" Then
            Address = ("http://weibo.com/")
            Fun_Run(Address)
        ElseIf Inputs = "腾讯微博" Then
            Address = ("http://t.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "豆瓣" Then
            Address = ("http://www.douban.com/")
            Fun_Run(Address)
        ElseIf Inputs = "世纪佳缘" Then
            Address = ("http://www.jiayuan.com/?bd=1")
            Fun_Run(Address)
        ElseIf Inputs = "开心网" Then
            Address = ("http://www.kaixin001.com/")
            Fun_Run(Address)
        ElseIf Inputs = "网易微博" Then
            Address = ("http://t.163.com/session")
            Fun_Run(Address)
        ElseIf Inputs = "知乎" Then
            Address = ("http://www.zhihu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "qq空间" Or Inputs = "qzone" Then
            Address = ("http://qzone.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "qq" Then
            Address = ("http://web2.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "天涯社区" Or Inputs = "天涯" Then
            Address = ("http://www.tianya.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "百合网" Then
            Address = ("http://www.baihe.com/")
            Fun_Run(Address)
        ElseIf Inputs = "西祠胡同" Then
            Address = ("http://www.xici.net/")
            Fun_Run(Address)
        ElseIf Inputs = "178" Then
            Address = ("http://www.178.com/")
            Fun_Run(Address)
        ElseIf Inputs = "17173" Then
            Address = ("http://www.17173.com/")
            Fun_Run(Address)
        ElseIf Inputs = "糗事百科" Or Inputs = "糗百" Then
            Address = ("http://www.qiushibaike.com/")
            Fun_Run(Address)
        ElseIf Inputs = "鲜果" Then
            Address = ("http://xianguo.com/")
            Fun_Run(Address)
        ElseIf Inputs = "水木社区" Then
            Address = ("http://www.newsmth.net/")
            Fun_Run(Address)
        ElseIf Inputs = "淡蓝网" Or Inputs = "淡蓝" Then
            Address = ("http://www.danlan.org/")
            Fun_Run(Address)
        ElseIf Inputs = "有意思吧" Then
            Address = ("http://www.u148.net/")
            Fun_Run(Address)
        ElseIf Inputs = "猫扑" Then
            Address = ("http://dzh.mop.com/")
            Fun_Run(Address)
        ElseIf Inputs = "华声论坛" Then
            Address = ("http://bbs.voc.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "yy" Then
            Address = ("http://www.yy.com/")
            Fun_Run(Address)
        ElseIf Inputs = "twitter" Then
            Address = ("http://www.twitter.com/")
            Fun_Run(Address)
        ElseIf Inputs = "新浪博客" Then
            Address = ("http://blog.sina.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "网易博客" Then
            Address = ("http://blog.163.com/")
            Fun_Run(Address)
        ElseIf Inputs = "腾讯博客" Then
            Address = ("http://blog.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "outlook" Or Inputs = "outlo" Then
            Address = ("http://url.cn/P2sWnM")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■游戏资源
        ElseIf Inputs = "游戏导航" Or Inputs = "游戏网站" Then
            Address = ("http://game.hao123.com/")
            Fun_Run(Address)
        ElseIf Inputs = "魔兽世界" Or Inputs = "wow" Or Inputs = "mssj" Then
            Address = ("http://www.wowchina.com/")
            Fun_Run(Address)
        ElseIf Inputs = "英雄联盟" Or Inputs = "lol" Then
            Address = ("http://lol.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "地下城与勇士" Or Inputs = "dnf" Then
            Address = ("http://dnf.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "穿越火线" Or Inputs = "cf" Then
            Address = ("http://cf.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "剑灵" Or Inputs = "bns" Then
            Address = ("http://bns.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "上古世纪" Or Inputs = "age" Then
            Address = ("http://age.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "艾尔之光" Then
            Address = ("http://els.ztgame.com/")
            Fun_Run(Address)
        ElseIf Inputs = "dota2" Then
            Address = ("http://www.dota2.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "星际争霸2" Or Inputs = "星际争霸" Or Inputs = "星际2" Or Inputs = "sc2" Then
            Address = ("http://sc2.163.com/landing")
            Fun_Run(Address)
        ElseIf Inputs = "炉石传说" Then
            Address = ("http://www.hearthstone.com.cn/landing")
            Fun_Run(Address)
        ElseIf Inputs = "战网" Or Inputs = "战网通行证" Then
            Address = ("http://www.battlenet.com.cn/zh/")
            Fun_Run(Address)
        ElseIf Inputs = "大脚" Or Inputs = "大脚插件" Or Inputs = "bigfoot" Then
            Address = ("http://bigfoot.178.com/")
            Fun_Run(Address)
        ElseIf Inputs = "mcbbs" Or Inputs = "mc论坛" Or Inputs = "我的世界" Or Inputs = "minecraft" Then
            Address = ("http://www.mcbbs.net/forum.php")
            Fun_Run(Address)
        ElseIf Inputs = "minecraftba" Or Inputs = "minecraft吧" Or Inputs = "minecraft贴吧" Then
            Address = ("http://url.cn/7ASEbX")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■系统软件
        ElseIf Inputs = "软件下载" Or Inputs = "软件站" Then
            Address = ("http://www.baidu.com/s?ie=UTF-8&wd=%E4%B8%8B%E8%BD%BD%E7%BD%91%E7%AB%99")
            Fun_Run(Address)
        ElseIf Inputs = "百度软件" Then
            Address = ("http://rj.baidu.com/index.html")
            Fun_Run(Address)
        ElseIf Inputs = "俺下载" Or Inputs = "anxz" Then
            Address = ("http://www.anxz.com/")
            Fun_Run(Address)
        ElseIf Inputs = "软件天堂" Then
            Address = ("http://www.softonic.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "小众软件" Then
            Address = ("http://www.appinn.com/category/desktop/")
            Fun_Run(Address)
        ElseIf Inputs = "下载吧" Then
            Address = ("http://www.xiazaiba.com/")
            Fun_Run(Address)
        ElseIf Inputs = "太平洋下载" Then
            Address = ("http://dl.pconline.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "华军软件" Or Inputs = "华军软件园" Then
            Address = ("http://www.onlinedown.net/")
            Fun_Run(Address)
        ElseIf Inputs = "统一下载" Or Inputs = "统一下载站" Then
            Address = ("http://www.3987.com/")
            Fun_Run(Address)
        ElseIf Inputs = "天空下载" Or Inputs = "天空下载站" Then
            Address = ("http://www.skycn.com/")
            Fun_Run(Address)
        ElseIf Inputs = "站长下载" Or Inputs = "站长之家" Then
            Address = ("http://www.chinaz.com/")
            Fun_Run(Address)
        ElseIf Inputs = "非凡软件" Or Inputs = "非凡软件站" Then
            Address = ("http://www.crsky.com/")
            Fun_Run(Address)
        ElseIf Inputs = "wp应用" Then
            Address = ("http://www.windowsphone.com/zh-cn/store/")
            Fun_Run(Address)
        ElseIf Inputs = "adobe" Then
            Address = ("http://www.adobe.com/cn/")
            Fun_Run(Address)
        ElseIf Inputs = "msdn" Or Inputs = "msdn.iso" Then
            Address = ("http://msdn.ez58.net/")
            Fun_Run(Address)
        ElseIf Inputs = "corel" Or Inputs = "会声会影官网" Or Inputs = "绘声绘影官网" Then
            Address = ("http://www.corel.com/corel/")
            Fun_Run(Address)
        ElseIf Inputs = "autodesk" Or Inputs = "autocad" Or Inputs = "cad" Then
            Address = ("http://www.autodesk.com.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "matlab" Then
            Address = ("http://www.mathworks.cn/")
            Fun_Run(Address)


        ElseIf Inputs = "sougou" Or Inputs = "搜狗" Then
            Address = ("http://pinyin.sogou.com/")
            Fun_Run(Address)
        ElseIf Inputs = "pinyin" Or Inputs = "百度输入法" Or Inputs = "shurufa" Or Inputs = "输入法" Then
            Address = ("http://shurufa.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "qqpinyin" Or Inputs = "qq拼音" Then
            Address = ("http://shurufa.qq.com/")
            Fun_Run(Address)
        ElseIf Inputs = "7z" Then
            Address = ("http://www.7-zip.org/")
            Fun_Run(Address)
        ElseIf Inputs = "winrar" Then
            Address = ("http://www.winrar.com.cn/")
            Fun_Run(Address)

        ElseIf Inputs = "ubuntu" Then
            Address = ("http://forum.ubuntu.org.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "miui" Then
            Address = ("http://www.miui.com/download.html")
            Fun_Run(Address)
        ElseIf Inputs = "苹果在线" Then
            Address = ("http://download.macgame.com.cn/system/macosx/")
            Fun_Run(Address)

            '■■■■■■■■■■■■■■■■■■■■■■■■■■■在线工具

        ElseIf Inputs = "百度云" Or Inputs = "baiduyun" Then
            Address = ("http://yun.baidu.com/")
            Fun_Run(Address)
        ElseIf Inputs = "360云盘" Or Inputs = "360yun" Then
            Address = ("http://yunpan.360.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "微盘" Or Inputs = "vdisk" Or Inputs = "weipan" Then
            Address = ("https://vdisk.weibo.com")
            Fun_Run(Address)
        ElseIf Inputs = "金山快盘" Or Inputs = "快盘" Or Inputs = "kuaipan" Then
            Address = ("http://www.kuaipan.cn/")
            Fun_Run(Address)
        ElseIf Inputs = "onedrive" Or Inputs = "skydrive" Then
            Address = ("https://onedrive.live.com")
            Fun_Run(Address)


        ElseIf Inputs = "ico" Then
            Address = ("http://www.ico.la/")
            Fun_Run(Address)
        ElseIf Inputs = "二维码" Or Inputs = "在线二维码" Or Inputs = "制作二维码" Then
            Address = ("http://cli.im/")
            Fun_Run(Address)

        ElseIf Inputs = "硕鼠" Or Inputs = "硕鼠网" Or Inputs = "flvcd" Then
            Address = ("http://www.flvcd.com/")
            Fun_Run(Address)
            '■■■■■■■■■■■■■■■■■■■■■■■■■■■快捷下载
            '===========================聊天通讯===========================
        ElseIf Inputs = "下载qq201" Or Inputs = "下载qq2013" Then
            Address = ("http://w.x.baidu.com/alading/anquan_soft_down_normal/12350")
            Fun_Run(Address)
        ElseIf Inputs = "下载阿里旺旺" Or Inputs = "下载旺旺" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/0b/11390/AliIM2014_taobao_8.00.34C.1406620992.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载tm2013" Or Inputs = "下载tm201" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/00/15334/TM2013Preview2.1408690223.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq国际版" Or Inputs = "下载qq国际" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/85/14178/QQIntl2.1.3396238254.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载易信" Or Inputs = "下载yixin" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/c0/23980/yixinsetup.1403767675.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载yy" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/98/14000/YYSetup-6.30.0.2-zh-CN.1408428744.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载沃友" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/9a/10024/WoYou_PC_3.0.9.3739845603.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载米聊" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/95/14922/miliao-setup-100_1_PC.2370674710.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载line" Or Inputs = "下载连我" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/7b/20542/LineInst3.6.0.32.1402034880.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载飞信" Or Inputs = "下载feixin" Or Inputs = "下载fetion" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/fe/11383/FetionNew2014JulySP_5.5.1800.0.1406777144.exe")
            Fun_Run(Address)
            '===========================影视播放===========================
        ElseIf Inputs = "下载暴风影音" Or Inputs = "下载暴风" Or Inputs = "下载baofeng" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/50/15945/baofeng0721-1647.1406278367.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载百度影音" Or Inputs = "下载baiduyingy" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/71/10998/OfflineBaiduPlayer_151.1405929559.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载爱奇艺" Or Inputs = "下载iqiyi" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/40/12856/IQIYIsetup.1408442386.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq影音" Or Inputs = "下载qqplayer" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/51/14247/QQPlayer_3.7.892.400.1395741945.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载优酷" Or Inputs = "下载youku" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/07/13236/youkuclient_setup_5.1.0.8083.1407740926.exe")
            Fun_Run(Address)
        ElseIf Inputs = "quicktime" Or Inputs = "下载quicktime" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/0a/15252/QuickTimeInstaller_7.75.80.95.1396236579.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载射手影音" Or Inputs = "下载射手" Then
            Address = ("http://dl1sw.baidu.com/soft/72/12480/SPlayer_3.7.0.2437.exe?version=1978284872")
            Fun_Run(Address)
        ElseIf Inputs = "下载西瓜影音" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/a8/27459/xiguayingyinbofangqi.1406624794.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载potplayer" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/ed/24593/PotPlayerSetup.1407725040.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载itudou" Or Inputs = "下载土豆" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/e1/15573/iTudou_Setup_3.7.5.0.1402036040.exe")
            Fun_Run(Address)
            '===========================游戏===========================
        ElseIf Inputs = "下载捣蛋猪" Then
            Address = ("http://dl1sw.baidu.com/soft/b6/11088/BadPiggiesInstaller_1.3.0.exe?version=293461103")
            Fun_Run(Address)
        ElseIf Inputs = "下载植物大战僵尸" Or Inputs = "下载植物大战" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/a3/12590/10000436.1329783614.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载罪恶都市" Or Inputs = "下载罪恶" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/19/17560/Grand_1.0.exe?version=1185392965")
            Fun_Run(Address)
        ElseIf Inputs = "下载cs" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/71/17525/cstrike_1.6.exe?version=218290772")
            Fun_Run(Address)
            '===========================下载工具===========================
        ElseIf Inputs = "下载迅雷7" Or Inputs = "下载thunder" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/ca/13442/Thunder_dl_7.9.26.4824.1408503687.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载迅雷极速" Or Inputs = "下载迅雷极速版" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/7b/26860/ThunderSpeed1.0.13.140.1407396180.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载迅雷精简" Or Inputs = "下载迅雷精简版" Then
            Address = ("http://dl1sw.baidu.com/soft/9e/12351/ThunderMini_1.5.3.288.exe?version=1247572264")
            Fun_Run(Address)
        ElseIf Inputs = "下载电驴" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/ce/11640/easymule_1.2.2.1037122417.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载快车" Then
            Address = ("http://dl1sw.baidu.com/soft/73/12640/flashget3.7.0.1222cn.exe?version=178466266")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq旋风" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/5a/26397/QQDownload_Setup_39_718.1398247445.exe")
            Fun_Run(Address)
            '===========================浏览器===========================
        ElseIf Inputs = "下载百度浏览器" Or Inputs = "下载百度浏览" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/55/11339/bdbrowser_setup-alading-6_5_0_50033-6394.1406777706.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载谷歌浏览器" Or Inputs = "下载chrome" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/9d/14744/ChromeStandaloneSetup.1408587465.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq浏览器" Or Inputs = "下载qq浏览" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/42/16490/QQBrowser_Setup_26717.1408435439.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载猎豹" Or Inputs = "下载猎豹浏览" Or Inputs = "下载猎豹浏览器" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/a6/15895/KSbrowser_5.0.63.8593.1408439135.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载遨游" Or Inputs = "下载遨游浏览" Or Inputs = "下载遨游浏览器" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/6d/15449/mx4.4.1.4000cn.1408427236.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载safair" Then
            Address = ("http://dl1sw.baidu.com/soft/d3/12966/Safari_5.34.57.2.exe?version=868428140")
            Fun_Run(Address)
        ElseIf Inputs = "下载opera" Or Inputs = "下载opera浏览器" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/6f/11508/opera_stable-23.0.1522.77-windows-release-i386-cn.1408505680.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载firefox" Or Inputs = "下载firefox浏览器" Or Inputs = "下载火狐" Or Inputs = "火狐浏览" Or Inputs = "火狐浏览器" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/51/11843/Firefox-setup.1406081288.exe")
            Fun_Run(Address)
            '===========================办公学习===========================
        ElseIf Inputs = "下载wps2013" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/bb/14391/W.P.S.4843.19.996.1408589127.exe")
            Fun_Run(Address)

        ElseIf Inputs = "下载bing词典" Or Inputs = "下载必应词典" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/9b/17183/BingDict_Setup.1403856985.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载有道" Or Inputs = "下载有道词典" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/b8/14630/YoudaoDict_qq.gj-6.1.51.3321.1395999574.exe")
            Fun_Run(Address)
            '===========================系统工具===========================
        ElseIf Inputs = "下载virtualbox" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/08/15321/VirtualBox-4.3.14-95030-Win.1405567216.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载软媒魔方" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/a0/11664/pcmastersetup_u8.1408675639.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载驱动精灵" Then
            Address = ("http://w.x.baidu.com/alading/anquan_soft_down_normal/11114")
            Fun_Run(Address)
        ElseIf Inputs = "下载老毛桃" Then
            Address = ("http://w.x.baidu.com/alading/anquan_soft_down_normal/24217")
            Fun_Run(Address)

            '===========================输入法===========================
        ElseIf Inputs = "下载百度输入法" Or Inputs = "下载百度拼音" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/40/13323/BaiduPinyinSetup-2_11_2_59.1407119397.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq拼音" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/44/12767/QQPinyin_Setup_1.2.1248.400.1405654804.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载必应输入法" Or Inputs = "下载bing输入法" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/f6/17499/BingPinyinSetup_1.5.24.12.1406788334.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载搜狗输入法" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/8a/13598/sogou_pinyin_72f.1408327463.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载搜狗五笔" Or Inputs = "下载搜狗五笔输入法" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/db/15698/sogou_pinyin_wubi_2.0.1.1217.1400122502.exe")
            Fun_Run(Address)
            '===========================图像编辑===========================
        ElseIf Inputs = "下载picasa" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/62/12951/picasa39-setup.2372797439.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载美图秀秀" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/24/13406/XiuXiu_BdSetup.1406186335.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq影像" Then
            Address = ("http://dl1sw.baidu.com/soft/9e/15388/QQImage_3.0.890.400.exe?version=3399387628")
            Fun_Run(Address)
        ElseIf Inputs = "下载光影看图" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/eb/18011/NeoViewerSetup_1.1.1.1398825398.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载美图看看" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/e7/10520/KanKan_kk360Setup.1404977172.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载lightroom" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/04/15765/Lightroom_5_LS11.582112039.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载光影魔术手" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/80/13075/NeoImagingSetup_4.4.1.1398740694.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载acdsee" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/49/25345/acdsee_official_free.1395052283.exe")
            Fun_Run(Address)
            '===========================音乐播放===========================
        ElseIf Inputs = "下载百度音乐" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/b2/15892/BaiduMusic-12345617.1407922230.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载酷狗音乐" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/1a/11798/kugou7625.1408335351.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载qq音乐" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/80/10547/QQMusic_Setup_1112beta.1408325749.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载酷我音乐" Or Inputs = "下载酷我音乐盒" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/5a/12481/kuwo2014.1408685209.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载多米音乐" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/1f/14033/DuomiMusic_5.1.8.0.1394785605.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载foobar" Or Inputs = "下载foobar2000" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/ad/16323/foobar2000_v1.3.3.1405997138.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载winamp" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/cc/12912/winamp57_3444_beta_full_all.1394074175.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载aimp" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/e5/13632/aimp_3.55.1355.1405580054.exe")
            Fun_Run(Address)
            '===========================杀毒防护===========================
        ElseIf Inputs = "下载百度卫士" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/70/17456/BaiduAn_Setup_3.0.0.3971_50043.1408407200.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载百度杀毒" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/44/17448/Baidusd_Setup_2.1.0.2625.1407257072.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载腾讯电脑管家" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/58/13849/qqpcmgr_v10.1.15257.227_8878279_Normal.1408327027.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载新毒霸" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/8b/13060/kavsetup140804_99_50.1407464905.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载金山卫士" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/d6/14991/setup_4.7.0.4212.1406861419.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载卡巴斯基安全部队" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/3a/12454/kis13.0.1.4190zh-Hans-cn.exe?version=2461093036")
            Fun_Run(Address)
        ElseIf Inputs = "下载卡巴斯基反病毒软件" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/96/12753/kav14.1.0.4651zh-Hans-cn.1707928943.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载360" Then
            Address = ("http://down.360safe.com/360safe_cq.exe")
            Fun_Run(Address)
            '===========================手机管理===========================
        ElseIf Inputs = "下载百度手机助手" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/18/17521/Baidushoujizhushou_5.0.1408672252.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载wp应用" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/01/26287/windowsphone.1398047942.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载豌豆荚" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/91/14506/WanDouJia_2.79.0.6948_homepage.1408009755.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载百度一键root" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/ee/17550/BaiduRoot_setup_3.5.07.1408441990.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载应用宝" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/b1/17483/QQPhoneManager_990420.4237.1408429957.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载百度云刷机工具" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/29/16808/BaiduCloudROMFlash_2.0.28_setup.1406173071.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载金山手机助手" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/fb/17492/shoujikong_setup.1405477484.exe")
            Fun_Run(Address)
            '===========================压缩刻录===========================
        ElseIf Inputs = "下载winrar" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/2e/10849/wrar510sc.1402653363.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载7z" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/37/11063/7z934_9.34.1.0.1403839042.msi")
            Fun_Run(Address)
            '===========================网络应用===========================
        ElseIf Inputs = "下载百度云管家" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/da/17519/BaiduYunGuanjia_4.8.2.1407751793.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载金山快盘" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/e3/13074/kuaipan_0101-0202-001_4.7.7.15_setup.1405067705.exe")
            Fun_Run(Address)
            '===========================程序开发===========================
        ElseIf Inputs = "下载net4.1" Then
            Address = ("http://dl1sw.baidu.com/soft/9b/15910/Microsoft.NET.exe?version=585709662")
            Fun_Run(Address)
        ElseIf Inputs = "下载net4.5" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/b9/22370/NDP451-KB2858728-x86-x64.3505182529.exe")
            Fun_Run(Address)
        ElseIf Inputs = "下载python" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/6e/17016/python-3.3.5.1395976247.msi")
            Fun_Run(Address)
            '===========================影音编辑===========================
        ElseIf Inputs = "下载会声会影" Then
            Address = ("http://d.pcs.baidu.com/file/2da0927af2db65fcedb76932d229d348?fid=3021931942-250528-1083374463943349&time=1408806576&expires=1408834193&rt=sh&chkv=1&chkpc=et&sign=FDTERVYA-DCb740ccc5511e5e8fedcff06b081203-vwMTiL%2B9gl%2FMvXCQ8eaYXiJmJhY%3D&r=469377124&sharesign=brytExYSUMHv+UCFhVLByZTfhNTPuOS0uTyBoqIO6e0PxxvBG6v+WXjKDYVxnWwk6fESss/xkEaUjeaycDqs0Xs78mLH+aRTHCKakkQZfCCcGxv7emRRnOkd1o7oQWujCEGFdQD3MJYhZnuy4lhOsF9mEDbJzrVPScFbPQcXM3oSNA5w2ppWNaNyZl/sbuO38G2rgtaG8XTSn8YnIkQnGv7SEug66iIndt9qVvQXRBFwba0VAqyZNtdt0Yq0+VBISO5FzfkZo1PHrGPKTKuSaI6aL17YAmZM1krzv23kOtGfTzs+wj2EdQ==&sh=1&cflg=65535%3A1")
            Fun_Run(Address)
        ElseIf Inputs = "下载格式工厂" Then
            Address = ("http://dlsw.baidu.com/sw-search-sp/soft/6c/13052/FormatFactory_setup.1401763241.exe")
            Fun_Run(Address)




        End If
    End Sub
    '↑↑↑有键按下并弹起（输入检测）

    '键盘和按钮检测↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑

    Private Sub Button_Search_Show_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button_Search_Show.MouseEnter

        Button_Search_Show.Visibility = Windows.Visibility.Hidden
        图案_搜索.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Roll()
        If TipsGrid.Visibility = Windows.Visibility.Hidden Then
            Input.MinWidth = 240
            Grid_Expand0_Show.Visibility = Windows.Visibility.Visible
        End If

    End Sub
    Private Sub NEXUS_Command_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Command.MouseDown
        NEXUS_Command.DragMove()
    End Sub
  
End Class
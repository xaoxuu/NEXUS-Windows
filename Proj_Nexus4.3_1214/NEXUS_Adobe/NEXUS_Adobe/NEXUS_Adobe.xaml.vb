Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim nn, mm As Double

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        内容初始化()
        按钮初始化()
        窗口切换("展开")
    End Sub
    Private Sub 内容初始化()
        
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Visible
    End Sub
    Private Sub 按钮初始化()
        Button_Close.Visibility = Windows.Visibility.Hidden
        Grid_菜单图标.Visibility = Windows.Visibility.Hidden
        Grid_迷你菜单图标.Visibility = Windows.Visibility.Hidden
        A11.Visibility = Windows.Visibility.Hidden
        A10.Visibility = Windows.Visibility.Visible
        A21.Visibility = Windows.Visibility.Hidden
        A20.Visibility = Windows.Visibility.Visible
        A31.Visibility = Windows.Visibility.Hidden
        A30.Visibility = Windows.Visibility.Visible
        A41.Visibility = Windows.Visibility.Hidden
        A40.Visibility = Windows.Visibility.Visible
        A51.Visibility = Windows.Visibility.Hidden
        A50.Visibility = Windows.Visibility.Visible
        A61.Visibility = Windows.Visibility.Visible
        A60.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 窗口切换(i As String)
        If i = "缩小" Then
            Main.Visibility = Windows.Visibility.Hidden
            迷你模式.Visibility = Windows.Visibility.Visible
        ElseIf i = "展开" Then
            Main.Visibility = Windows.Visibility.Visible
            迷你模式.Visibility = Windows.Visibility.Hidden
        End If
    End Sub
    Private Sub 小标题(i As String)
        If i = "A1" Then
            A11.Visibility = Windows.Visibility.Visible
            A10.Visibility = Windows.Visibility.Hidden
            A21.Visibility = Windows.Visibility.Hidden
            A20.Visibility = Windows.Visibility.Visible
            A31.Visibility = Windows.Visibility.Hidden
            A30.Visibility = Windows.Visibility.Visible
            A41.Visibility = Windows.Visibility.Hidden
            A40.Visibility = Windows.Visibility.Visible
            A51.Visibility = Windows.Visibility.Hidden
            A50.Visibility = Windows.Visibility.Visible
            A61.Visibility = Windows.Visibility.Hidden
            A60.Visibility = Windows.Visibility.Visible
        ElseIf i = "A2" Then
            A11.Visibility = Windows.Visibility.Hidden
            A10.Visibility = Windows.Visibility.Visible
            A21.Visibility = Windows.Visibility.Visible
            A20.Visibility = Windows.Visibility.Hidden
            A31.Visibility = Windows.Visibility.Hidden
            A30.Visibility = Windows.Visibility.Visible
            A41.Visibility = Windows.Visibility.Hidden
            A40.Visibility = Windows.Visibility.Visible
            A51.Visibility = Windows.Visibility.Hidden
            A50.Visibility = Windows.Visibility.Visible
            A61.Visibility = Windows.Visibility.Hidden
            A60.Visibility = Windows.Visibility.Visible
        ElseIf i = "A3" Then
            A11.Visibility = Windows.Visibility.Hidden
            A10.Visibility = Windows.Visibility.Visible
            A21.Visibility = Windows.Visibility.Hidden
            A20.Visibility = Windows.Visibility.Visible
            A31.Visibility = Windows.Visibility.Visible
            A30.Visibility = Windows.Visibility.Hidden
            A41.Visibility = Windows.Visibility.Hidden
            A40.Visibility = Windows.Visibility.Visible
            A51.Visibility = Windows.Visibility.Hidden
            A50.Visibility = Windows.Visibility.Visible
            A61.Visibility = Windows.Visibility.Hidden
            A60.Visibility = Windows.Visibility.Visible
        ElseIf i = "A4" Then
            A11.Visibility = Windows.Visibility.Hidden
            A10.Visibility = Windows.Visibility.Visible
            A21.Visibility = Windows.Visibility.Hidden
            A20.Visibility = Windows.Visibility.Visible
            A31.Visibility = Windows.Visibility.Hidden
            A30.Visibility = Windows.Visibility.Visible
            A41.Visibility = Windows.Visibility.Visible
            A40.Visibility = Windows.Visibility.Hidden
            A51.Visibility = Windows.Visibility.Hidden
            A50.Visibility = Windows.Visibility.Visible
            A61.Visibility = Windows.Visibility.Hidden
            A60.Visibility = Windows.Visibility.Visible
        ElseIf i = "A5" Then
            A11.Visibility = Windows.Visibility.Hidden
            A10.Visibility = Windows.Visibility.Visible
            A21.Visibility = Windows.Visibility.Hidden
            A20.Visibility = Windows.Visibility.Visible
            A31.Visibility = Windows.Visibility.Hidden
            A30.Visibility = Windows.Visibility.Visible
            A41.Visibility = Windows.Visibility.Hidden
            A40.Visibility = Windows.Visibility.Visible
            A51.Visibility = Windows.Visibility.Visible
            A50.Visibility = Windows.Visibility.Hidden
            A61.Visibility = Windows.Visibility.Hidden
            A60.Visibility = Windows.Visibility.Visible
        ElseIf i = "A6" Then
            A11.Visibility = Windows.Visibility.Hidden
            A10.Visibility = Windows.Visibility.Visible
            A21.Visibility = Windows.Visibility.Hidden
            A20.Visibility = Windows.Visibility.Visible
            A31.Visibility = Windows.Visibility.Hidden
            A30.Visibility = Windows.Visibility.Visible
            A41.Visibility = Windows.Visibility.Hidden
            A40.Visibility = Windows.Visibility.Visible
            A51.Visibility = Windows.Visibility.Hidden
            A50.Visibility = Windows.Visibility.Visible
            A61.Visibility = Windows.Visibility.Visible
            A60.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    '↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓鼠标移动特效↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
    '------------------------------鼠标进入
    Private Sub Adobe系列软件_MouseEnter(sender As Object, e As MouseEventArgs) Handles Adobe系列软件.MouseEnter
        图文窗口.Visibility = Windows.Visibility.Visible

    End Sub

    '------------------------------鼠标离开
    Private Sub Adobe系列软件_MouseLeave(sender As Object, e As MouseEventArgs) Handles Adobe系列软件.MouseLeave
        图文窗口.Visibility = Windows.Visibility.Hidden
    End Sub
 
    '↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑鼠标移动特效↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑



  
    '↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓小标题↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
    Private Sub A10_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A10.MouseDown
        小标题("A1")
        Grid_A1.Visibility = Windows.Visibility.Visible
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub A20_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A20.MouseDown
        小标题("A2")
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Visible
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub A30_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A30.MouseDown
        小标题("A3")
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Visible
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub A40_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A40.MouseDown
        小标题("A4")
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Visible
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub A50_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A50.MouseDown
        小标题("A5")
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Visible
        Grid_A6.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub A60_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A60.MouseDown
        小标题("A6")
        Grid_A1.Visibility = Windows.Visibility.Hidden
        Grid_A2.Visibility = Windows.Visibility.Hidden
        Grid_A3.Visibility = Windows.Visibility.Hidden
        Grid_A4.Visibility = Windows.Visibility.Hidden
        Grid_A5.Visibility = Windows.Visibility.Hidden
        Grid_A6.Visibility = Windows.Visibility.Visible
    End Sub



    '↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑小标题↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑



  
    '↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓点击按钮↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
    Private Sub Button_A11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A11.MouseDown   
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=3&rsv_bp=1&tn=baidu&wd=photoshop%E4%B8%8B%E8%BD%BD&rsv_pq=be3bfc51000017bc&rsv_t=7bfah9%2BcwI4Adulq%2FyPsLD%2BFdExBChSlUOceDmmn5jmAktKRYfgo&rsv_enter=1&rsv_sug3=13&rsv_sug4=684&rsv_sug1=11&oq=PHOTOSHOPxiaz&rsv_sug2=1&rsp=0&inputT=6994" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A12.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=premiere%E4%B8%8B%E8%BD%BD&ie=utf-8&f=8&rsv_bp=1&tn=baidu&rsv_pq=f4047a9700001f6d&rsv_t=e60fEnrZDbpB4r9MSZyYWPa8KzIZ9gK072Am6XUmuBS%2Fqx5P1yiO&bs=photoshop%E4%B8%8B%E8%BD%BD" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A13.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&tn=baidu&wd=after%20effect%E4%B8%8B%E8%BD%BD&rsv_pq=9787c2ce0000bebc&rsv_t=b9ebQpk2dADC11jbK1M4VBzLkR55qCOhOEXdWQSFbv3pPfm%2FHqBX&rsv_enter=1&oq=PHOTOSHOPxiaz&inputT=7094&rsv_sug3=36&rsv_sug4=2011&rsv_sug1=20&rsv_sug2=0" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A14_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A14.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=flash%E4%B8%8B%E8%BD%BD&ie=utf-8&f=8&rsv_bp=1&tn=baidu&rsv_pq=f4047a9700001f6d&rsv_t=e60fEnrZDbpB4r9MSZyYWPa8KzIZ9gK072Am6XUmuBS%2Fqx5P1yiO&bs=after%20effect%E4%B8%8B%E8%BD%BD" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A15_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A15.MouseDown
        WshShell.run(Chr(34) & "http://www.adobe.com/downloads.html" & Chr(34))
        窗口切换("缩小")
    End Sub

    Private Sub Button_A21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A21.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A22.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CC 全系列通用破解补丁\Adobe_Photoshop_CC安装激活教程.mht" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A23.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&tn=baidu&wd=adobe%20%E5%AE%89%E8%A3%85&rsv_pq=b83e477700008562&rsv_t=6c4fB3s5Ss7sNcrUSLughc7ogAkXnZ8Ex7vMKnR7i9qXb3iOpUpB&rsv_enter=1&rsv_sug3=7&rsv_sug4=421&rsv_sug1=7&rsv_sug2=0&inputT=3422" & Chr(34))
        窗口切换("缩小")
    End Sub

    Private Sub Button_A31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A31.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CS6 全系列通用破解补丁\激活工具" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A32.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A33.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CC 全系列通用破解补丁\激活工具" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A34_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A34.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Box31\Adobe CC 全系列通用破解补丁\Adobe_Photoshop_CC安装激活教程.mht" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A35_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A35.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=adobe%20%BC%A4%BB%EE&fr=wenku" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A41_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A41.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=8" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A42_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A42.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNzQ2MDc4NzIw.html" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A43_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A43.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=UTF-8&wd=adobe%E6%95%99%E7%A8%8B" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A51_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A51.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=59" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A52_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A52.MouseDown
        WshShell.run(Chr(34) & "http://www.xuexi111.com/s/premiere/" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A53_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A53.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=333" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A54_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A54.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/baidu?word=Flash%E7%B4%A0%E6%9D%90&tn=bds&cl=3&ct=2097152&si=www.xuexi111.com&s=on" & Chr(34))
        窗口切换("缩小")
    End Sub
    Private Sub Button_A61_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_A61.MouseDown
        WshShell.run(Chr(34) & "http://www.sojump.com/m/3499620.aspx" & Chr(34))
        窗口切换("缩小")
    End Sub
 
    Private Sub Image_A61_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Image_A61.MouseDown
        WshShell.run(Chr(34) & "http://www.sojump.com/m/3499620.aspx" & Chr(34))
        窗口切换("缩小")
    End Sub

    '↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑点击按钮↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑

   


    Private Sub MainWindow_MouseLeave(sender As Object, e As MouseEventArgs) Handles Me.MouseLeave
        Main.Opacity = 1

    End Sub

    Private Sub Main_MouseEnter(sender As Object, e As MouseEventArgs) Handles Main.MouseEnter
        Main.Opacity = 1
    End Sub


    Private Sub 图文窗口_MouseEnter(sender As Object, e As MouseEventArgs) Handles 图文窗口.MouseEnter
        图文窗口.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub Button_Close_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Close.MouseDown
        End
    End Sub
   

    Private Sub 精灵软件助手_MouseDown(sender As Object, e As MouseEventArgs) Handles 精灵软件助手.MouseDown
        窗口切换("展开")
    End Sub
   

    Private Sub 精灵软件助手_MouseEnter(sender As Object, e As MouseEventArgs) Handles 精灵软件助手.MouseEnter
        精灵软件助手.Text = "点我展开界面"
    End Sub
    Private Sub 精灵软件助手_MouseLeave(sender As Object, e As MouseEventArgs) Handles 精灵软件助手.MouseLeave
        精灵软件助手.Text = "精灵软件助手"
    End Sub
    Private Sub 菜单按钮_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 菜单按钮.MouseDown
        窗口切换("缩小")
    End Sub

    Private Sub 迷你菜单按钮_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 迷你菜单按钮.MouseDown
        窗口切换("展开")
    End Sub
    Private Sub Button_Close_Show_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button_Close_Show.MouseEnter
        Button_Close.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button_Close_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button_Close.MouseLeave
        Button_Close.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 菜单按钮_MouseEnter(sender As Object, e As MouseEventArgs) Handles 菜单按钮.MouseEnter
        Grid_菜单图标_Show.Visibility = Windows.Visibility.Hidden
        Grid_菜单图标.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 菜单按钮_MouseLeave(sender As Object, e As MouseEventArgs) Handles 菜单按钮.MouseLeave
        Grid_菜单图标_Show.Visibility = Windows.Visibility.Visible
        Grid_菜单图标.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 迷你菜单按钮_MouseEnter(sender As Object, e As MouseEventArgs) Handles 迷你菜单按钮.MouseEnter
        Grid_迷你菜单图标_Show.Visibility = Windows.Visibility.Hidden
        Grid_迷你菜单图标.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 迷你菜单按钮_MouseLeave(sender As Object, e As MouseEventArgs) Handles 迷你菜单按钮.MouseLeave
        Grid_迷你菜单图标_Show.Visibility = Windows.Visibility.Visible
        Grid_迷你菜单图标.Visibility = Windows.Visibility.Hidden
    End Sub
End Class

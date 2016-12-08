Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBS\NEXUS_Games_Close.vbs" & Chr(34))
    End Sub
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        Tab(2)
        拓展区.Visibility = Windows.Visibility.Collapsed

        游戏路径查询()
        Dim A As String
        A = "attrib +a +s +h +r " + Chr(34) & "D:\Program Files\NEXUS\Launcher" & Chr(34)
        WshShell.run(A, vbHide)
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBS\NEXUS_Games_Open.vbs" & Chr(34))
    End Sub

    Private Sub Tab(i As UInteger)

        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Hidden

        Tab_1.Visibility = Windows.Visibility.Hidden
        Tab_2.Visibility = Windows.Visibility.Hidden

        拓展区.Visibility = Windows.Visibility.Collapsed

        If i = 1 Then
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_1.Visibility = Windows.Visibility.Visible

        ElseIf i = 2 Then
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_2.Visibility = Windows.Visibility.Visible

        Else
        End If


    End Sub

    Private Sub 游戏路径查询()
        If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then

            Button211.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))

        Else
            Button211.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If
        '-------------------------------------------------------------

        If Dir("D:\Program Files\NEXUS\Launcher\英雄联盟.lnk") = "" Then
            Button212.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button212.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------

        If Dir("D:\Program Files\NEXUS\Launcher\穿越火线.lnk") = "" Then
            Button213.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button213.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\战网.lnk") = "" Then

            Button214.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button214.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\魔兽世界.lnk") = "" Then

            Button215.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button215.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\风暴英雄.lnk") = "" Then

            Button216.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button216.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        '-------------------------------------------------------------
        '-------------------------------------------------------------

        If Dir("D:\Program Files\NEXUS\Launcher\红警2.lnk") = "" Then
            Button221.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button221.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------

        If Dir("D:\Program Files\NEXUS\Launcher\红警3.lnk") = "" Then
            Button222.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button222.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\魔兽争霸3.lnk") = "" Then
            Button223.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button223.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\地狱边境.lnk") = "" Then
            Button224.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button224.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\泰拉瑞亚.lnk") = "" Then
            Button225.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button225.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\Minecraft.lnk") = "" Then
            Button226.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button226.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\FC模拟器.lnk") = "" Then
            Button227.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button227.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\流星蝴蝶剑.lnk") = "" Then
            Button228.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button228.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
        If Dir("D:\Program Files\NEXUS\Launcher\孤胆枪手.lnk") = "" Then
            Button229.Fill = New SolidColorBrush(Color.FromArgb(220, 255, 255, 255))
        Else
            Button229.Fill = New SolidColorBrush(Color.FromArgb(0, 255, 255, 255))
        End If

        '-------------------------------------------------------------
    End Sub

    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Expand_XLauncher.Opacity = 0.85
        NEXUS_Expand_XLauncher.DragMove()
        NEXUS_Expand_XLauncher.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_XLauncher.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_XLauncher.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible

        背景_蓝色.Visibility = Windows.Visibility.Hidden


    End Sub


    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown

        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBS\NEXUS_Games_Close.vbs" & Chr(34))
        End

    End Sub
    Private Sub 标题按钮3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseEnter
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub
    Private Sub 标题按钮3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseLeave
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub


    Private Sub 上半部_MouseEnter(sender As Object, e As MouseEventArgs) Handles 上半部.MouseEnter
        拓展区.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 上半部_MouseLeave(sender As Object, e As MouseEventArgs) Handles 上半部.MouseLeave
        拓展区.Visibility = Windows.Visibility.Collapsed
    End Sub


    Private Sub Title_Tab1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab1.MouseDown
        Tab(1)
    End Sub
    Private Sub Title_Tab1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseEnter
        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
       
    End Sub
    Private Sub Title_Tab1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseLeave
        If Tab_1.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If

    End Sub

    Private Sub Title_Tab2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab2.MouseDown
        Tab(2)
    End Sub
    Private Sub Title_Tab2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseEnter
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseLeave
        If Tab_2.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If

    End Sub

    Private Sub Title_Tab3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab3.MouseDown

        WshShell.run(Chr(34) & "http://www.sojump.com/jq/3499620.aspx" & Chr(34))
    End Sub

    Private Sub Title_Tab3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseEnter
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseLeave

        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

    End Sub

    Private Sub 反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 反馈.MouseDown

        WshShell.run(Chr(34) & "http://www.sojump.com/jq/3499620.aspx" & Chr(34))
    End Sub

    Private Sub 反馈_MouseEnter(sender As Object, e As MouseEventArgs) Handles 反馈.MouseEnter
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub 反馈_MouseLeave(sender As Object, e As MouseEventArgs) Handles 反馈.MouseLeave
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub

    Private Sub Button211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button211.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then

            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        
        Else
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk" & Chr(34))
        End If

    End Sub
    Private Sub Button212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button212.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then
            If Dir("D:\Program Files\NEXUS\Launcher\英雄联盟.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\英雄联盟.lnk" & Chr(34))
            End If
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk" & Chr(34))
        End If


    End Sub
    Private Sub Button213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button213.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then
            If Dir("D:\Program Files\NEXUS\Launcher\穿越火线.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\穿越火线.lnk" & Chr(34))
            End If
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk" & Chr(34))
        End If

    End Sub
  
    Private Sub Button214_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button214.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\战网.lnk") = "" Then

            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        
        Else
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\战网.lnk" & Chr(34))
        End If

    End Sub
    Private Sub Button215_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button215.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\战网.lnk") = "" Then
            If Dir("D:\Program Files\NEXUS\Launcher\魔兽世界.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\魔兽世界.lnk" & Chr(34))
            End If
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\战网.lnk" & Chr(34))
        End If

    End Sub
    Private Sub Button216_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button216.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\战网.lnk") = "" Then
            If Dir("D:\Program Files\NEXUS\Launcher\风暴英雄.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\风暴英雄.lnk" & Chr(34))
            End If
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\战网.lnk" & Chr(34))
        End If

    End Sub


    Private Sub Button221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button221.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\红警2.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\红警2.lnk" & Chr(34))
        End If
      
    End Sub
    Private Sub Button222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button222.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\红警3.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\红警3.lnk" & Chr(34))
        End If
        
    End Sub
    Private Sub Button223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button223.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\魔兽争霸3.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\魔兽争霸3.lnk" & Chr(34))
        End If
     
    End Sub
    Private Sub Button224_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button224.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\地狱边境.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\地狱边境.lnk" & Chr(34))
        End If
      
    End Sub
    Private Sub Button225_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button225.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\泰拉瑞亚.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\泰拉瑞亚.lnk" & Chr(34))
        End If
     
    End Sub
    Private Sub Button226_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button226.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\Minecraft.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\Minecraft.lnk" & Chr(34))
        End If
     
    End Sub
    Private Sub Button227_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button227.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\FC模拟器.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\FC模拟器.lnk" & Chr(34))
        End If
       
    End Sub
    Private Sub Button228_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button228.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\流星蝴蝶剑.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\流星蝴蝶剑.lnk" & Chr(34))
        End If
        
    End Sub
    Private Sub Button229_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button229.MouseDown

        If Dir("D:\Program Files\NEXUS\Launcher\孤胆枪手.lnk") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\孤胆枪手.lnk" & Chr(34))
        End If
     
    End Sub


End Class

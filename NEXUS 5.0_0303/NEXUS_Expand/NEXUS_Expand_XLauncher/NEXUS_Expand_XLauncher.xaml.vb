Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim cdkey As UInteger

    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Games_Close.vbs" & Chr(34))
    End Sub
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        cdkey = 0
        Tab(1)     
        拓展区.Visibility = Windows.Visibility.Collapsed
        StartButton.Visibility = Windows.Visibility.Collapsed
        游戏路径查询()
        Dim A As String
        A = "attrib +a +s +h +r " + Chr(34) & "D:\Program Files\NEXUS\Launcher" & Chr(34)
        WshShell.run(A, vbHide)
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Games_Open.vbs" & Chr(34))
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

        If i = 1 Then
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_1.Visibility = Windows.Visibility.Visible
            拓展区.Visibility = Windows.Visibility.Visible

        ElseIf i = 2 Then
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_2.Visibility = Windows.Visibility.Visible
            拓展区.Visibility = Windows.Visibility.Collapsed


        Else

        End If



    End Sub

    Private Sub 游戏路径查询()
        If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then

            If Dir("D:\Program Files\NEXUS\Launcher\英雄联盟.lnk") = "" Then
                Button211.Fill = New SolidColorBrush(Color.FromArgb(130, 187, 222, 251))
            Else
                Button211.Fill = New SolidColorBrush(Color.FromArgb(0, 187, 222, 251))
            End If
        Else
            Button211.Fill = New SolidColorBrush(Color.FromArgb(0, 187, 222, 251))
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

        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Games_Close.vbs" & Chr(34))
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




    Private Sub 上半部_MouseLeave(sender As Object, e As MouseEventArgs) Handles 上半部.MouseLeave
        拓展区.Visibility = Windows.Visibility.Collapsed
    End Sub



    Private Sub Title_Tab1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab1.MouseDown
        Tab(1)
    End Sub
    Private Sub Title_Tab1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseEnter
        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        If Tab_1.Visibility = Windows.Visibility.Visible Then
            拓展区.Visibility = Windows.Visibility.Visible
        End If
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

        WshShell.run(Chr(34) & "http://www.sojump.com/m/3499620.aspx" & Chr(34))
    End Sub

    Private Sub Title_Tab3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseEnter
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseLeave

        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

    End Sub


    Private Sub TB_KeyUp(sender As Object, e As KeyEventArgs) Handles TB.KeyUp
        If TB11.Text = "SDA2" And TB12.Text = "FA4R" And TB13.Text = "KIR6" And TB14.Text = "3N51" Then
            If TB21.Text = "9P7W" And TB22.Text = "HNE5" And TB23.Text = "C1B4" And TB24.Text = "Z7TD" Then
                If TB31.Text = "8LEM" And TB32.Text = "ASW2" And TB33.Text = "MNTV" And TB34.Text = "39T6" Then
                    If TB41.Text = "R5HV" And TB42.Text = "XR5H" And TB43.Text = "M7H3" And TB44.Text = "H68T" Then
                        StartButton.Visibility = Windows.Visibility.Visible
                        cdkey = 1
                    Else
                        StartButton.Visibility = Windows.Visibility.Hidden
                    End If
                Else
                    StartButton.Visibility = Windows.Visibility.Hidden
                End If
            Else
                StartButton.Visibility = Windows.Visibility.Hidden
            End If
        Else
            StartButton.Visibility = Windows.Visibility.Hidden
        End If
    End Sub



    Private Sub StartButton_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles StartButton.MouseDown
        Tab(2)
    End Sub



    Private Sub Button211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button211.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then
                If Dir("D:\Program Files\NEXUS\Launcher\英雄联盟.lnk") = "" Then
                    WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
                Else
                    WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\英雄联盟.lnk" & Chr(34))
                End If
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If


    End Sub
    Private Sub Button212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button212.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk") = "" Then
                If Dir("D:\Program Files\NEXUS\Launcher\穿越火线.lnk") = "" Then
                    WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
                Else
                    WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\穿越火线.lnk" & Chr(34))
                End If
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\腾讯游戏平台.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button213.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\战网.lnk") = "" Then
                If Dir("D:\Program Files\NEXUS\Launcher\魔兽世界.lnk") = "" Then
                    WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
                Else
                    WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\魔兽世界.lnk" & Chr(34))
                End If
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\战网.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub


    Private Sub Button221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button221.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\红警2.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\红警2.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button222.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\红警3.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\红警3.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button223.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\魔兽争霸3.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\魔兽争霸3.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button224_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button224.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\地狱边境.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\地狱边境.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button225_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button225.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\泰拉瑞亚.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\泰拉瑞亚.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button226_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button226.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\Minecraft.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\Minecraft.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button227_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button227.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\FC模拟器.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\FC模拟器.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button228_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button228.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\流星蝴蝶剑.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\流星蝴蝶剑.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub
    Private Sub Button229_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button229.MouseDown
        If cdkey = 1 Then
            If Dir("D:\Program Files\NEXUS\Launcher\孤胆枪手.lnk") = "" Then
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\孤胆枪手.lnk" & Chr(34))
            End If
        Else
            Tab(1)
        End If
    End Sub


End Class

Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Fun_Wake()
        If Dir("C:\Program Files\NEXUS\VBS\NEXUS_Open.vbs") = "" Then '
        Else '
            Fun_Shell("C:\Program Files\NEXUS\VBS\NEXUS_Open.vbs")
        End If


        

        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
        Tab(1)

        If Dir("D:\Program Files\NEXUS\Temp\Startup\魔枢后台.lnk") = "" Then '
            Navigation12.Text = "保持后台：禁止"
            Navigation11_off.Visibility = Windows.Visibility.Visible
            Navigation11_on.Visibility = Windows.Visibility.Collapsed
            Navigation11_off.Fill = New SolidColorBrush(Color.FromRgb(255, 87, 34))
            Navigation11_on.Fill = New SolidColorBrush(Color.FromRgb(255, 87, 34))
        Else '
            Navigation12.Text = "保持后台：允许"
            Navigation11_off.Visibility = Windows.Visibility.Collapsed
            Navigation11_on.Visibility = Windows.Visibility.Visible
            Navigation11_off.Fill = New SolidColorBrush(Color.FromRgb(76, 175, 80))
            Navigation11_on.Fill = New SolidColorBrush(Color.FromRgb(76, 175, 80))

        End If
      
    End Sub

 
    '=====================================子函数====================================
    Private Sub Fun_Wake()

        If Dir("C:\Program Files\NEXUS\NEXUS_Server.exe") = "" Then '
        Else '
            Fun_Shell("C:\Program Files\NEXUS\NEXUS_Server.exe")
        End If


    End Sub
    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Dir("C:\Program Files\NEXUS\VBS\NEXUS_Close.vbs") = "" Then '
        Else '
            Fun_Shell("C:\Program Files\NEXUS\VBS\NEXUS_Close.vbs")
        End If
    End Sub
    Private Sub Fun_Shell(i As String)
        WshShell.run(Chr(34) & i & Chr(34))
    End Sub

    Private Sub Fun_TitleTips(i As String)
        If i = "0" Then
            TitleTips.Visibility = Windows.Visibility.Hidden
        Else
            TitleTips.Visibility = Windows.Visibility.Visible
            TitleTips.Text = i
        End If
    End Sub


    Private Sub Tab(i As UInteger)

        Title_Tab1_Text_.Opacity = 0.5
        Title_Tab2_Text_.Opacity = 0.5
        Title_Tab3_Text_.Opacity = 0.5
        Title_Tab4_Text_.Opacity = 0.5

        Title_Tab1_Rectangle_.Opacity = 0
        Title_Tab2_Rectangle_.Opacity = 0
        Title_Tab3_Rectangle_.Opacity = 0
        Title_Tab4_Rectangle_.Opacity = 0

        Tab_1.Visibility = Windows.Visibility.Collapsed
        Tab_2.Visibility = Windows.Visibility.Collapsed
        Tab_3.Visibility = Windows.Visibility.Collapsed
        Tab_4.Visibility = Windows.Visibility.Collapsed
        Tab_5.Visibility = Windows.Visibility.Collapsed
        If i = 1 Then
            Title_Tab1_Text_.Opacity = 1
            Title_Tab1_Rectangle_.Opacity = 1
            Tab_1.Visibility = Windows.Visibility.Visible

        ElseIf i = 2 Then
            Title_Tab2_Text_.Opacity = 1
            Title_Tab2_Rectangle_.Opacity = 1
            Tab_2.Visibility = Windows.Visibility.Visible

        ElseIf i = 3 Then
            Title_Tab3_Text_.Opacity = 1
            Title_Tab3_Rectangle_.Opacity = 1
            Tab_3.Visibility = Windows.Visibility.Visible

        ElseIf i = 4 Then
            Title_Tab4_Text_.Opacity = 1
            Title_Tab4_Rectangle_.Opacity = 1
            Tab_4.Visibility = Windows.Visibility.Visible
        ElseIf i = 5 Then

            Tab_5.Visibility = Windows.Visibility.Visible

        Else
        End If


    End Sub



    '=====================================窗口移动拖拽====================================

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        'Roll()
    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

        'Roll()
    End Sub

    Private Sub NEXUS_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS.MouseEnter
        Background_White.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub NEXUS_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS.MouseLeave
        Background_White.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

    End Sub



    Private Sub Background_Title_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Background_Title.MouseLeftButtonDown
        NEXUS.Opacity = 0.8
        NEXUS.DragMove()
        NEXUS.Opacity = 1
    End Sub

    '=====================================标题按钮====================================



    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown
        NEXUS.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Opacity = 1
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave

        TitleButton1_Rectangle_.Opacity = 0.5

    End Sub



    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown

        Close()

    End Sub

    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_1.Opacity = 1
        TitleButton2_Rectangle_2.Opacity = 1
        Fun_TitleTips("关闭")

    End Sub

    Private Sub TitleButton2_MouseLeave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_1.Opacity = 0.5
        TitleButton2_Rectangle_2.Opacity = 0.5

    End Sub




    Private Sub TitleButton3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton3.MouseDown
        Grid_Navigation.Visibility = Windows.Visibility.Visible
    End Sub
    Private Sub TitleButton3_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseEnter
        Fun_TitleTips("设置")
    End Sub

    Private Sub TitleButton3_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseLeave


    End Sub

    Private Sub TitleButton4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton4.MouseDown
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub TitleButton4_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton4.MouseEnter
        Fun_TitleTips("返回上一层")
    End Sub

    Private Sub TitleButton4_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton4.MouseLeave
        Fun_TitleTips("")

    End Sub


    Private Sub Grid_TitleButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles Grid_TitleButton.MouseLeave

        Fun_TitleTips("0")
    End Sub


    '=====================================标题分类====================================
    Private Sub Title_Tab1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab1.MouseDown
        Tab(1)
    End Sub
    Private Sub Title_Tab1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseEnter
        Title_Tab1_Text_.Opacity = 1

    End Sub
    Private Sub Title_Tab1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseLeave
        If Tab_1.Visibility = Windows.Visibility.Collapsed Then
            Title_Tab1_Text_.Opacity = 0.5
        End If

    End Sub

    Private Sub Title_Tab2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab2.MouseDown
        Tab(2)
    End Sub
    Private Sub Title_Tab2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseEnter
        Title_Tab2_Text_.Opacity = 1

    End Sub

    Private Sub Title_Tab2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseLeave
        If Tab_2.Visibility = Windows.Visibility.Collapsed Then
            Title_Tab2_Text_.Opacity = 0.5
        End If

    End Sub

    Private Sub Title_Tab3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab3.MouseDown
        Tab(3)

    End Sub

    Private Sub Title_Tab3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseEnter
        Title_Tab3_Text_.Opacity = 1

    End Sub

    Private Sub Title_Tab3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseLeave
        If Tab_3.Visibility = Windows.Visibility.Collapsed Then
            Title_Tab3_Text_.Opacity = 0.5
        End If
    End Sub

    Private Sub Title_Tab4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab4.MouseDown
        Tab(4)

    End Sub

    Private Sub Title_Tab4_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab4.MouseEnter
        Title_Tab4_Text_.Opacity = 1

    End Sub

    Private Sub Title_Tab4_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab4.MouseLeave
        If Tab_4.Visibility = Windows.Visibility.Collapsed Then
            Title_Tab4_Text_.Opacity = 0.5
        End If
    End Sub

 


    '===========================================================

    Private Sub Button111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button111.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\清理垃圾.lnk") = "" Then '没有快捷启动

            If Dir("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe")
            End If
        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\清理垃圾.lnk")
        End If



    End Sub

    Private Sub Button111_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button111.MouseEnter
        Button111_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button111_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin111.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button111_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button111.MouseLeave
        Button111_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button111_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin111.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub Button112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button112.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\开机加速.lnk") = "" Then '没有快捷启动
            If Dir("D:\Program Files\NEXUS\ToolBox\boostmaster.exe") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\boostmaster.exe")
            End If

        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\开机加速.lnk")
        End If



    End Sub

    Private Sub Button112_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button112.MouseEnter
        Button112_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button112_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin112.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button112_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button112.MouseLeave
        Button112_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button112_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin112.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub Button113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button113.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\本地文件搜索.lnk") = "" Then '没有快捷启动
            If Dir("D:\Program Files\NEXUS\ToolBox\Everything.exe") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\Everything.exe")
            End If

        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\本地文件搜索.lnk")
        End If



    End Sub

    Private Sub Button113_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button113.MouseEnter
        Button113_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button113_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin113.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button113_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button113.MouseLeave
        Button113_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button113_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin113.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button121.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\WiFi共享.lnk") = "" Then '没有快捷启动


            If Dir("D:\Program Files\NEXUS\ToolBox\magicwifi.exe") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\magicwifi.exe")
            End If
        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\WiFi共享.lnk")
        End If


    End Sub

    Private Sub Button121_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button121.MouseEnter
        Button121_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button121_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin121.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button121_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button121.MouseLeave
        Button121_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button121_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin121.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button122.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\VPN代理.lnk") = "" Then '没有快捷启动


            If Dir("D:\Program Files\NEXUS\ToolBox\VPN\") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\VPN")
            End If
        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\VPN代理.lnk")
        End If


    End Sub

    Private Sub Button122_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button122.MouseEnter
        Button122_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button122_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin122.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button122_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button122.MouseLeave
        Button122_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button122_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin122.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button123_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button123.MouseDown
        If Dir("D:\Program Files\NEXUS\Launcher\百度云管家.lnk") = "" Then '没有快捷启动

            If Dir("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\BaiduYunGuanjia.exe") = "" Then '没有Readme

                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
            Else '有Readme
                Fun_Shell("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\BaiduYunGuanjia.exe")
            End If
        Else '有快捷启动
            Fun_Shell("D:\Program Files\NEXUS\Launcher\百度云管家.lnk")
        End If



    End Sub

    Private Sub Button123_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button123.MouseEnter
        Button123_Rectangle_0.Visibility = Windows.Visibility.Hidden
        Button123_Rectangle_1.Visibility = Windows.Visibility.Visible
        Pin123.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button123_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button123.MouseLeave
        Button123_Rectangle_0.Visibility = Windows.Visibility.Visible
        Button123_Rectangle_1.Visibility = Windows.Visibility.Hidden
        Pin123.Visibility = Windows.Visibility.Hidden
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Button211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button211.MouseDown
        If Dir("C:\Program Files\NEXUS\Expand\SoftwareAssistant.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("C:\Program Files\NEXUS\Expand\SoftwareAssistant.exe")
        End If
    End Sub

    Private Sub Button211_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button211.MouseEnter
        Button211_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button211_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button211.MouseLeave
        Button211_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button212.MouseDown
        If Dir("C:\Program Files\NEXUS\Expand\StudentAssistant.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("C:\Program Files\NEXUS\Expand\StudentAssistant.exe")
        End If
    End Sub

    Private Sub Button212_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button212.MouseEnter
        Button212_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button212_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button212.MouseLeave
        Button212_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button213.MouseDown
        If Dir("C:\Program Files\NEXUS\Expand\NEXUSLauncher.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("C:\Program Files\NEXUS\Expand\NEXUSLauncher.exe")
        End If
    End Sub

    Private Sub Button213_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button213.MouseEnter
        Button213_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button213_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button213.MouseLeave
        Button213_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    '--------------------------------------------------------------------------
    Private Sub Button221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button221.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe")
        End If
    End Sub

    Private Sub Button221_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button221.MouseEnter
        Button221_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button221_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button221.MouseLeave
        Button221_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button222.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\boostmaster.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\boostmaster.exe")
        End If
    End Sub

    Private Sub Button222_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button222.MouseEnter
        Button222_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button222_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button222.MouseLeave
        Button222_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button223.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\filemaster.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\filemaster.exe")
        End If
    End Sub

    Private Sub Button223_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button223.MouseEnter
        Button223_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button223_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button223.MouseLeave
        Button223_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button224_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button224.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\MenuMgr.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\MenuMgr.exe")
        End If
    End Sub

    Private Sub Button224_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button224.MouseEnter
        Button224_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button224_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button224.MouseLeave
        Button224_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button225_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button225.MouseDown
        If Dir("D:\Program Files\Toolbox\Toolbox.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\Toolbox\")
        End If
    End Sub

    Private Sub Button225_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button225.MouseEnter
        Button225_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button225_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button225.MouseLeave
        Button225_background_.Visibility = Windows.Visibility.Hidden
    End Sub






    '--------------------------------------------------------------------------
    Private Sub Button231_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button231.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\magicwifi.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\magicwifi.exe")
        End If
    End Sub

    Private Sub Button231_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button231.MouseEnter
        Button231_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button231_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button231.MouseLeave
        Button231_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button232_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button232.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\VPN\") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\VPN")
        End If
    End Sub

    Private Sub Button232_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button232.MouseEnter
        Button232_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button232_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button232.MouseLeave
        Button232_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button233_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button233.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\dnshelper.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\dnshelper.exe")
        End If
    End Sub

    Private Sub Button233_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button233.MouseEnter
        Button233_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button233_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button233.MouseLeave
        Button233_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button234_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button234.MouseDown
        If Dir("D:\Program Files\硕鼠\nano.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\硕鼠\nano.exe")
        End If
    End Sub

    Private Sub Button234_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button234.MouseEnter
        Button234_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button234_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button234.MouseLeave
        Button234_background_.Visibility = Windows.Visibility.Hidden
    End Sub







    '--------------------------------------------------------------------------
    Private Sub Button241_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button241.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\KMSpico.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\KMSpico.exe")
        End If
    End Sub

    Private Sub Button241_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button241.MouseEnter
        Button241_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button241_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button241.MouseLeave
        Button241_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button242_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button242.MouseDown
        If Dir("D:\Program Files\DriverGenius\DriverGenius.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\DriverGenius\DriverGenius.exe")
        End If
    End Sub

    Private Sub Button242_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button242.MouseEnter
        Button242_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button242_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button242.MouseLeave
        Button242_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button243_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button243.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\pcdoctor.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\pcdoctor.exe")
        End If
    End Sub

    Private Sub Button243_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button243.MouseEnter
        Button243_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button243_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button243.MouseLeave
        Button243_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button244_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button244.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\datarecovery.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\datarecovery.exe")
        End If
    End Sub

    Private Sub Button244_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button244.MouseEnter
        Button244_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button244_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button244.MouseLeave
        Button244_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button245_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button245.MouseDown
        If Dir("D:\Program Files\DiskGenius\DiskGenius.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\DiskGenius\DiskGenius.exe")
        End If
    End Sub

    Private Sub Button245_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button245.MouseEnter
        Button245_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button245_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button245.MouseLeave
        Button245_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button246_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button246.MouseDown

        Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")

    End Sub

    Private Sub Button246_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button246.MouseEnter
        Button246_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button246_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button246.MouseLeave
        Button246_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button247_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button247.MouseDown

        Fun_Shell("http://msdn.itellyou.cn/")

    End Sub

    Private Sub Button247_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button247.MouseEnter
        Button247_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button247_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button247.MouseLeave
        Button247_background_.Visibility = Windows.Visibility.Hidden
    End Sub







    '--------------------------------------------------------------------------
    Private Sub Button251_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button251.MouseDown

        Fun_Shell("http://rj.baidu.com/soft/detail/20468.html?ald")

    End Sub

    Private Sub Button251_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button251.MouseEnter
        Button251_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button251_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button251.MouseLeave
        Button251_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button252_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button252.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\winstart.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\winstart.exe")
        End If
    End Sub

    Private Sub Button252_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button252.MouseEnter
        Button252_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button252_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button252.MouseLeave
        Button252_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button253_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button253.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\virtualdrivemaster.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\virtualdrivemaster.exe")
        End If
    End Sub

    Private Sub Button253_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button253.MouseEnter
        Button253_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button253_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button253.MouseLeave
        Button253_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button254_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button254.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\winmaster.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\winmaster.exe")
        End If
    End Sub

    Private Sub Button254_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button254.MouseEnter
        Button254_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button254_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button254.MouseLeave
        Button254_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button255_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button255.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\GHOST.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\GHOST.exe")
        End If
    End Sub

    Private Sub Button255_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button255.MouseEnter
        Button255_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button255_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button255.MouseLeave
        Button255_background_.Visibility = Windows.Visibility.Hidden
    End Sub








    '--------------------------------------------------------------------------
    Private Sub Button261_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button261.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\ToolBox\重启资源管理器.vbs")
    End Sub

    Private Sub Button261_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button261.MouseEnter
        Button261_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button261_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button261.MouseLeave
        Button261_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button262_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button262.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\ToolBox\IP.exe")
    End Sub

    Private Sub Button262_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button262.MouseEnter
        Button262_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button262_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button262.MouseLeave
        Button262_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button263_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button263.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\ToolBox\磁盘管理.lnk")
    End Sub

    Private Sub Button263_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button263.MouseEnter
        Button263_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button263_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button263.MouseLeave
        Button263_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button264_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button264.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\ToolBox\设备管理器.lnk")
    End Sub

    Private Sub Button264_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button264.MouseEnter
        Button264_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button264_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button264.MouseLeave
        Button264_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button265_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button265.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\ToolBox\系统配置\")
    End Sub

    Private Sub Button265_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button265.MouseEnter
        Button265_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button265_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button265.MouseLeave
        Button265_background_.Visibility = Windows.Visibility.Hidden
    End Sub






    '--------------------------------------------------------------------------
    Private Sub Button271_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button271.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Expand\ShutdownTimer.exe")
    End Sub

    Private Sub Button271_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button271.MouseEnter
        Button271_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button271_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button271.MouseLeave
        Button271_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button272_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button272.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\FX82ES.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\FX82ES.exe")
        End If
    End Sub

    Private Sub Button272_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button272.MouseEnter
        Button272_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button272_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button272.MouseLeave
        Button272_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button273_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button273.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Everything.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Everything.exe")
        End If
    End Sub

    Private Sub Button273_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button273.MouseEnter
        Button273_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button273_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button273.MouseLeave
        Button273_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button274_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button274.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\语音合成.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\语音合成.exe")
        End If
    End Sub

    Private Sub Button274_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button274.MouseEnter
        Button274_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button274_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button274.MouseLeave
        Button274_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button275_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button275.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
    End Sub

    Private Sub Button275_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button275.MouseEnter
        Button275_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button275_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button275.MouseLeave
        Button275_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button276_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button276.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Download.exe")
    End Sub

    Private Sub Button276_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button276.MouseEnter
        Button276_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button276_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button276.MouseLeave
        Button276_background_.Visibility = Windows.Visibility.Hidden
    End Sub






    '================================================================================================

    '--------------------------------------------------------------------------
    Private Sub Button311_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button311.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/28772.html")

    End Sub

    Private Sub Button311_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button311.MouseEnter
        Button311_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button311_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button311.MouseLeave
        Button311_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button312_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button312.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/11761.html")

    End Sub

    Private Sub Button312_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button312.MouseEnter
        Button312_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button312_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button312.MouseLeave
        Button312_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button313_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button313.MouseDown
        Fun_Shell("http://sparanoid.com/lab/7z/")

    End Sub

    Private Sub Button313_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button313.MouseEnter
        Button313_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button313_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button313.MouseLeave
        Button313_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button314_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button314.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/14744.html")

    End Sub

    Private Sub Button314_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button314.MouseEnter
        Button314_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button314_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button314.MouseLeave
        Button314_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button315_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button315.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/12951.html")

    End Sub

    Private Sub Button315_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button315.MouseEnter
        Button315_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button315_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button315.MouseLeave
        Button315_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button316_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button316.MouseDown
        Fun_Shell("http://music.163.com/#/download")

    End Sub

    Private Sub Button316_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button316.MouseEnter
        Button316_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button316_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button316.MouseLeave
        Button316_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button317_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button317.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/14247.html")

    End Sub

    Private Sub Button317_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button317.MouseEnter
        Button317_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button317_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button317.MouseLeave
        Button317_background_.Visibility = Windows.Visibility.Hidden
    End Sub





    '--------------------------------------------------------------------------
    Private Sub Button320_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button320.MouseDown
        Fun_Shell("http://www.anxz.com/downlist/r_4_1.html")

    End Sub


    Private Sub Button321_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button321.MouseDown
        Fun_Shell("http://msdn.itellyou.cn/")

    End Sub

    Private Sub Button321_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button321.MouseEnter
        Button321_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button321_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button321.MouseLeave
        Button321_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button322_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button322.MouseDown
        Fun_Shell("http://rj.baidu.com/soft/detail/13052.html")

    End Sub

    Private Sub Button322_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button322.MouseEnter
        Button322_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button322_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button322.MouseLeave
        Button322_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button323_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button323.MouseDown

        Fun_Shell("http://url.cn/aNPm4t")

    End Sub

    Private Sub Button323_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button323.MouseEnter
        Button323_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button323_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button323.MouseLeave
        Button323_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button324_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button324.MouseDown

        Fun_Shell("https://icons8.com/")

    End Sub

    Private Sub Button324_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button324.MouseEnter
        Button324_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button324_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button324.MouseLeave
        Button324_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button325_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button325.MouseDown
        Fun_Shell("http://www.anxz.com/down/6295.html")

    End Sub

    Private Sub Button325_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button325.MouseEnter
        Button325_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button325_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button325.MouseLeave
        Button325_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button326_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button326.MouseDown
        Fun_Shell("http://www.anxz.com/down/1884.html")

    End Sub

    Private Sub Button326_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button326.MouseEnter
        Button326_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button326_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button326.MouseLeave
        Button326_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button327_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button327.MouseDown
        Fun_Shell("http://www.anxz.com/down/1609.html")

    End Sub

    Private Sub Button327_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button327.MouseEnter
        Button327_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button327_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button327.MouseLeave
        Button327_background_.Visibility = Windows.Visibility.Hidden
    End Sub








    '--------------------------------------------------------------------------
    Private Sub Button331_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button331.MouseDown
        Fun_Shell("http://www.anxz.com/down/2636.html")

    End Sub

    Private Sub Button331_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button331.MouseEnter
        Button331_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button331_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button331.MouseLeave
        Button331_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button332_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button332.MouseDown
        Fun_Shell("http://www.anxz.com/down/641.html")

    End Sub

    Private Sub Button332_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button332.MouseEnter
        Button332_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button332_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button332.MouseLeave
        Button332_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button333_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button333.MouseDown
        Fun_Shell("http://www.anxz.com/down/4402.html")

    End Sub

    Private Sub Button333_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button333.MouseEnter
        Button333_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button333_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button333.MouseLeave
        Button333_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button334_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button334.MouseDown
        Fun_Shell("http://www.anxz.com/down/8887.html")

    End Sub

    Private Sub Button334_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button334.MouseEnter
        Button334_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button334_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button334.MouseLeave
        Button334_background_.Visibility = Windows.Visibility.Hidden
    End Sub





    '--------------------------------------------------------------------------
    Private Sub Button340_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button340.MouseDown
        Fun_Shell("http://www.anxz.com/downlist/r_9_1.html")

    End Sub


    Private Sub Button341_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button341.MouseDown
        Fun_Shell("http://url.cn/Zw0oSk")

    End Sub

    Private Sub Button341_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button341.MouseEnter
        Button341_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button341_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button341.MouseLeave
        Button341_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button342_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button342.MouseDown
        Fun_Shell("http://url.cn/Zw0oSk")

    End Sub

    Private Sub Button342_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button342.MouseEnter
        Button342_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button342_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button342.MouseLeave
        Button342_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button343_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button343.MouseDown
        Fun_Shell("http://url.cn/Zw0oSk")

    End Sub

    Private Sub Button343_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button343.MouseEnter
        Button343_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button343_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button343.MouseLeave
        Button343_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button344_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button344.MouseDown
        Fun_Shell("http://url.cn/Zw0oSk")

    End Sub

    Private Sub Button344_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button344.MouseEnter
        Button344_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button344_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button344.MouseLeave
        Button344_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button345_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button345.MouseDown
        Fun_Shell("http://url.cn/Zw0oSk")

    End Sub

    Private Sub Button345_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button345.MouseEnter
        Button345_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button345_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button345.MouseLeave
        Button345_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button346_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button346.MouseDown
        Fun_Shell("http://tieba.baidu.com/p/2011098233")

    End Sub

    Private Sub Button346_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button346.MouseEnter
        Button346_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button346_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button346.MouseLeave
        Button346_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    '--------------------------------------------------------------------------
    Private Sub Button351_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button351.MouseDown
        Fun_Shell("http://rj.baidu.com/")

    End Sub

    Private Sub Button351_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button351.MouseEnter
        Button351_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button351_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button351.MouseLeave
        Button351_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button352_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button352.MouseDown
        Fun_Shell("http://www.anxz.com")

    End Sub

    Private Sub Button352_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button352.MouseEnter
        Button352_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button352_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button352.MouseLeave
        Button352_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button353_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button353.MouseDown
        Fun_Shell("http://en.softonic.com/")

    End Sub

    Private Sub Button353_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button353.MouseEnter
        Button353_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button353_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button353.MouseLeave
        Button353_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button354_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button354.MouseDown
        Fun_Shell("http://www.appinn.com")

    End Sub

    Private Sub Button354_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button354.MouseEnter
        Button354_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button354_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button354.MouseLeave
        Button354_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button355_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button355.MouseDown
        Fun_Shell("http://www.itellyou.cn/")

    End Sub

    Private Sub Button355_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button355.MouseEnter
        Button355_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button355_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button355.MouseLeave
        Button355_background_.Visibility = Windows.Visibility.Hidden
    End Sub









    '================================================================================================

    '--------------------------------------------------------------------------
    Private Sub Button411_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button411.MouseDown
        Fun_Shell("http://aesir1.isitestar.cn/")

    End Sub

    Private Sub Button411_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button411.MouseEnter
        Button411_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button411_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button411.MouseLeave
        Button411_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button412_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button412.MouseDown
        Fun_Shell("http://shang.qq.com/wpa/qunwpa?idkey=17d34ad4288abedeff11840cd4608c49c14c585976c633848fb2d5f4250fbf50")

    End Sub

    Private Sub Button412_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button412.MouseEnter
        Button412_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button412_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button412.MouseLeave
        Button412_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button413_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button413.MouseDown
        Fun_Shell("http://202.196.192.25/lyit/")

    End Sub

    Private Sub Button413_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button413.MouseEnter
        Button413_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button413_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button413.MouseLeave
        Button413_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button414_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button414.MouseDown
        Fun_Shell("http://202.196.192.25/lyit/")

    End Sub

    Private Sub Button414_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button414.MouseEnter
        Button414_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button414_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button414.MouseLeave
        Button414_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button415_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button415.MouseDown
        Fun_Shell("http://202.196.192.25/lyit/ZNPK/KBFB_ClassSel.aspx")

    End Sub

    Private Sub Button415_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button415.MouseEnter
        Button415_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button415_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button415.MouseLeave
        Button415_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    '--------------------------------------------------------------------------


    Private Sub Button421_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button421.MouseDown
        Fun_Shell("http://study.163.com/")

    End Sub

    Private Sub Button421_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button421.MouseEnter
        Button421_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button421_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button421.MouseLeave
        Button421_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button422_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button422.MouseDown
        Fun_Shell("http://www.imooc.com/")

    End Sub

    Private Sub Button422_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button422.MouseEnter
        Button422_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button422_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button422.MouseLeave
        Button422_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button423_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button423.MouseDown
        Fun_Shell("http://www.jikexueyuan.com/")

    End Sub

    Private Sub Button423_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button423.MouseEnter
        Button423_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button423_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button423.MouseLeave
        Button423_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button424_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button424.MouseDown
        Fun_Shell("http://www.51zxw.net/")

    End Sub

    Private Sub Button424_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button424.MouseEnter
        Button424_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button424_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button424.MouseLeave
        Button424_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button425_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button425.MouseDown
        Fun_Shell("http://www.rjzxw.com/")

    End Sub

    Private Sub Button425_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button425.MouseEnter
        Button425_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button425_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button425.MouseLeave
        Button425_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button426_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button426.MouseDown
        Fun_Shell("http://www.zhihu.com/")

    End Sub

    Private Sub Button426_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button426.MouseEnter
        Button426_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button426_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button426.MouseLeave
        Button426_background_.Visibility = Windows.Visibility.Hidden
    End Sub







    '--------------------------------------------------------------------------
    Private Sub Button431_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button431.MouseDown
        Fun_Shell("http://www.tudou.com/programs/view/a2AXbb3kMfI/")

    End Sub

    Private Sub Button431_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button431.MouseEnter
        Button431_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button431_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button431.MouseLeave
        Button431_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button432_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button432.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNjg5NTI3MTY0.html?from=s1.8-1-1.2")

    End Sub

    Private Sub Button432_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button432.MouseEnter
        Button432_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button432_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button432.MouseLeave
        Button432_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button433_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button433.MouseDown
        Fun_Shell("http://edu.163.com/special/2011cet_46/")

    End Sub

    Private Sub Button433_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button433.MouseEnter
        Button433_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button433_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button433.MouseLeave
        Button433_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button434_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button434.MouseDown
        Fun_Shell("http://www.youku.com/show_page/id_ze6e937b80d8d11e4b8b7.html")

    End Sub

    Private Sub Button434_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button434.MouseEnter
        Button434_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button434_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button434.MouseLeave
        Button434_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button435_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button435.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XMTMzMjM5MTU0NA==.html?from=s1.8-1-1.2")

    End Sub

    Private Sub Button435_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button435.MouseEnter
        Button435_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button435_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button435.MouseLeave
        Button435_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button436_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button436.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNDc3MzcwMDg0.html?from=s1.8-1-2.999&f=18578329&sf=10103")

    End Sub

    Private Sub Button436_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button436.MouseEnter
        Button436_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button436_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button436.MouseLeave
        Button436_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    '--------------------------------------------------------------------------


    Private Sub Button441_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button441.MouseDown
        Fun_Shell("http://hao.uisdc.com/")

    End Sub

    Private Sub Button441_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button441.MouseEnter
        Button441_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button441_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button441.MouseLeave
        Button441_background_.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub Button442_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button442.MouseDown
        Fun_Shell("http://www.materialup.com/")

    End Sub

    Private Sub Button442_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button442.MouseEnter
        Button442_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button442_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button442.MouseLeave
        Button442_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button443_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button443.MouseDown
        Fun_Shell("http://www.materialpalette.com")

    End Sub

    Private Sub Button443_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button443.MouseEnter
        Button443_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button443_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button443.MouseLeave
        Button443_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button444_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button444.MouseDown
        Fun_Shell("http://www.chinaz.com/")

    End Sub

    Private Sub Button444_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button444.MouseEnter
        Button444_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button444_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button444.MouseLeave
        Button444_background_.Visibility = Windows.Visibility.Hidden
    End Sub



    Private Sub Button445_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button445.MouseDown
        Fun_Shell("http://www.nipic.com/")

    End Sub

    Private Sub Button445_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button445.MouseEnter
        Button445_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button445_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button445.MouseLeave
        Button445_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    '--------------------------------------------------------------------------
    Private Sub Button451_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button451.MouseDown
        Fun_Shell("http://www.findmd5.com/")

    End Sub

    Private Sub Button451_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button451.MouseEnter
        Button451_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button451_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button451.MouseLeave
        Button451_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button452_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button452.MouseDown
        Fun_Shell("http://music.163.com/#/playlist?id=76243445")

    End Sub

    Private Sub Button452_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button452.MouseEnter
        Button452_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button452_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button452.MouseLeave
        Button452_background_.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub Button453_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button453.MouseDown
        Fun_Shell("http://music.163.com/#/user/home?id=63035382")

    End Sub

    Private Sub Button453_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button453.MouseEnter
        Button453_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button453_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button453.MouseLeave
        Button453_background_.Visibility = Windows.Visibility.Hidden
    End Sub




    Private Sub Button454_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button454.MouseDown
        Fun_Shell("http://cn163.net/")

    End Sub

    Private Sub Button454_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button454.MouseEnter
        Button454_background_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button454_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button454.MouseLeave
        Button454_background_.Visibility = Windows.Visibility.Hidden
    End Sub













    Private Sub Pin111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin111.MouseDown

        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\软媒清理大师.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\软媒清理大师.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub

    Private Sub Pin112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin112.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\软媒优化大师.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\软媒优化大师.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub

    Private Sub Pin113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin113.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\Everything.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\Everything.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub

    Private Sub Pin121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin121.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\WiFi共享.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\WiFi共享.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub

    Private Sub Pin122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin122.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\VPN代理.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\VPN代理.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub

    Private Sub Pin123_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Pin123.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Pin\百度云.exe") = "" Then '没有Readme

            Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Expand.exe")
        Else '有Readme
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Pin\百度云.exe")
            MessageBox.Show("快捷方式创建成功！")

        End If
    End Sub






    '=====================================设置====================================
    Private Sub Navigation_Button1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button1.MouseDown

        If Navigation12.Text = "保持后台：允许" Then

            Navigation12.Text = "保持后台：禁止"
            Navigation11_off.Visibility = Windows.Visibility.Visible
            Navigation11_on.Visibility = Windows.Visibility.Collapsed

            Fun_Shell("C:\Windows\StartupCancel.vbs")

        Else
            Navigation12.Text = "保持后台：允许"
            Navigation11_off.Visibility = Windows.Visibility.Collapsed
            Navigation11_on.Visibility = Windows.Visibility.Visible

            Fun_Shell("C:\Windows\StartupOK.vbs")

        End If

    End Sub
    Private Sub Navigation_Button1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button1.MouseEnter
        Navigation11_off.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation11_on.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation12.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button1.MouseLeave
        If Navigation12.Text = "保持后台：允许" Then

            Navigation11_off.Fill = New SolidColorBrush(Color.FromRgb(76, 175, 80))
            Navigation11_on.Fill = New SolidColorBrush(Color.FromRgb(76, 175, 80))

        Else
            Navigation11_off.Fill = New SolidColorBrush(Color.FromRgb(255, 87, 34))
            Navigation11_on.Fill = New SolidColorBrush(Color.FromRgb(255, 87, 34))

        End If

        Navigation12.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub


    Private Sub Navigation_Button2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button2.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\")
        Fun_Shell("C:\Program Files\NEXUS\VBS\StartupFolder.vbs")
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub Navigation_Button2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button2.MouseEnter
        Navigation21.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation22.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button2.MouseLeave

        Navigation21.Fill = New SolidColorBrush(Color.FromRgb(80, 80, 80))
        Navigation22.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub


    Private Sub Navigation_Button3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button3.MouseDown

        If Dir("C:\Program Files\NEXUS\Expand\NEXUS_Instructions.exe") = "" Then
            If Dir("C:\Program Files\NEXUS\Tips\Tips_Error.exe") = "" Then

                MessageBox.Show("文件丢失，请查看是否被杀毒软件误删！")

            Else
                Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Error.exe")
            End If

        Else
            Fun_Shell("C:\Program Files\NEXUS\Expand\NEXUS_Instructions.exe")

        End If
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub Navigation_Button3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button3.MouseEnter
        Navigation31.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation32.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button3.MouseLeave

        Navigation31.Fill = New SolidColorBrush(Color.FromRgb(80, 80, 80))
        Navigation32.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub


    Private Sub Navigation_Button4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button4.MouseDown
        Fun_Shell("http://aesir1.isitestar.cn/Download")
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub Navigation_Button4_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button4.MouseEnter
        Navigation41.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation42.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button4_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button4.MouseLeave

        Navigation41.Fill = New SolidColorBrush(Color.FromRgb(80, 80, 80))
        Navigation42.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub


    Private Sub Navigation_Button5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button5.MouseDown
        Fun_Shell("http://www.sojump.com/jq/3499620.aspx")
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub Navigation_Button5_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button5.MouseEnter
        Navigation51.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation52.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button5_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button5.MouseLeave

        Navigation51.Fill = New SolidColorBrush(Color.FromRgb(80, 80, 80))
        Navigation52.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub


    Private Sub Navigation_Button6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Navigation_Button6.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Tips\Tips_Uninstall.exe")
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
    Private Sub Navigation_Button6_MouseEnter(sender As Object, e As MouseEventArgs) Handles Navigation_Button6.MouseEnter
        Navigation61.Fill = New SolidColorBrush(Color.FromRgb(68, 134, 244))
        Navigation62.Foreground = New SolidColorBrush(Color.FromRgb(68, 134, 244))

    End Sub
    Private Sub Navigation_Button6_MouseLeave(sender As Object, e As MouseEventArgs) Handles Navigation_Button6.MouseLeave

        Navigation61.Fill = New SolidColorBrush(Color.FromRgb(80, 80, 80))
        Navigation62.Foreground = New SolidColorBrush(Color.FromRgb(80, 80, 80))


    End Sub







 
    Private Sub Background0_MouseEnter(sender As Object, e As MouseEventArgs) Handles Background0.MouseEnter
        Grid_Navigation.Visibility = Windows.Visibility.Collapsed
    End Sub
End Class

Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")

    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Expand_SoftwareAssistant_Close.vbs" & Chr(34))

    End Sub
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Tab(1)

        拓展区.Visibility = Windows.Visibility.Collapsed
      
    End Sub
 
    Private Sub Tab(i As UInteger)
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Expand_SoftwareAssistant_Close.vbs" & Chr(34))

        Title_Tab1_Ellipse_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Ellipse_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Ellipse_.Visibility = Windows.Visibility.Hidden

        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Hidden

        Tab_1.Visibility = Windows.Visibility.Hidden
        Tab_2.Visibility = Windows.Visibility.Hidden
        Tab_3.Visibility = Windows.Visibility.Hidden

        If i = 1 Then
            Title_Tab1_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_1.Visibility = Windows.Visibility.Visible
            

            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Office_Open.vbs" & Chr(34))

        ElseIf i = 2 Then
            Title_Tab2_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_2.Visibility = Windows.Visibility.Visible

            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Adobe_Open.vbs" & Chr(34))

        ElseIf i = 3 Then
            Title_Tab3_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_3.Visibility = Windows.Visibility.Visible

            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Corel_Open.vbs" & Chr(34))

        Else

        End If



    End Sub



    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Expand_SoftwareAssistant.Opacity = 0.85
        NEXUS_Expand_SoftwareAssistant.DragMove()
        NEXUS_Expand_SoftwareAssistant.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_SoftwareAssistant.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_SoftwareAssistant.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible

        背景_蓝色.Visibility = Windows.Visibility.Hidden


    End Sub


    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Expand\VBSSource\NEXUS_Expand_SoftwareAssistant_Close.vbs" & Chr(34))

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
        Tab(3)
    End Sub
    Private Sub Title_Tab3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseEnter
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseLeave
        If Tab_3.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If
    End Sub
    Private Sub 反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 反馈.MouseDown
       
        WshShell.run(Chr(34) & "http://www.sojump.com/m/3499620.aspx" & Chr(34))
    End Sub

    Private Sub 反馈_MouseEnter(sender As Object, e As MouseEventArgs) Handles 反馈.MouseEnter
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub 反馈_MouseLeave(sender As Object, e As MouseEventArgs) Handles 反馈.MouseLeave
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub

   
   

   
    Private Sub Button111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button111.MouseDown
        WshShell.run(Chr(34) & "http://www.anxz.com/down/20.html#down" & Chr(34))
    End Sub
    Private Sub Button112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button112.MouseDown
        WshShell.run(Chr(34) & "http://www.anxz.com/down/4517.html" & Chr(34))
    End Sub
    Private Sub Button113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button113.MouseDown
        WshShell.run(Chr(34) & "http://www.anxz.com/down/4084.html" & Chr(34))
    End Sub
    Private Sub Button114_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button114.MouseDown
        WshShell.run(Chr(34) & "http://yun.baidu.com/s/1eQfBPOe#path=%252F%25E7%25AC%25AC%25E4%25B8%2589%25E6%2596%25B9%25E7%25BB%2584%25E4%25BB%25B6" & Chr(34))
    End Sub
    Private Sub Button115_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button115.MouseDown
        WshShell.run(Chr(34) & "http://www.wps.cn/" & Chr(34))
    End Sub
    Private Sub Button116_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button116.MouseDown
        WshShell.run(Chr(34) & "http://zh-cn.libreoffice.org/download/libreoffice-stable/" & Chr(34))
    End Sub

    Private Sub Button121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button121.MouseDown

        If Dir("D:\Program Files\NEXUS\ToolBox\Office2013\Office2013安装教程.mht") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\ToolBox\Office2013\Office2013安装教程.mht" & Chr(34))
        End If
    End Sub
    Private Sub Button122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button122.MouseDown
        If Dir("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        End If

    End Sub
    Private Sub Button123_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button123.MouseDown

        If Dir("D:\Program Files\NEXUS\ToolBox\KMSpico.exe") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\ToolBox\KMSpico.exe" & Chr(34))
        End If
    End Sub

    Private Sub Button131_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button131.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNzA2NjQ1MjQ0.html?f=22202372" & Chr(34))
    End Sub
    Private Sub Button132_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button132.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNjg5NTI3MTY0.html?from=y1.2-1-87.3.4-2.1-1-1-3" & Chr(34))
    End Sub
    Private Sub Button133_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button133.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNjU5MDM1NDc2.html?f=22757686" & Chr(34))
    End Sub

    Private Sub Button141_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button141.MouseDown
        WshShell.run(Chr(34) & "http://www.glzy8.com/zt/moban/word_moban.html" & Chr(34))
    End Sub
    Private Sub Button142_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button142.MouseDown
        WshShell.run(Chr(34) & "http://www.glzy8.com/zt/excel/" & Chr(34))
    End Sub
    Private Sub Button143_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button143.MouseDown
        WshShell.run(Chr(34) & "http://www.glzy8.com/list/1/" & Chr(34))
    End Sub
    Private Sub Button144_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button144.MouseDown
        WshShell.run(Chr(34) & "http://www.cr173.com/soft/36165.html" & Chr(34))
    End Sub
    Private Sub Button145_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button145.MouseDown
       
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
    End Sub

    '-----------------------------------------------------------------

    Private Sub Button211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button211.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=3&rsv_bp=1&tn=baidu&wd=photoshop%E4%B8%8B%E8%BD%BD&rsv_pq=be3bfc51000017bc&rsv_t=7bfah9%2BcwI4Adulq%2FyPsLD%2BFdExBChSlUOceDmmn5jmAktKRYfgo&rsv_enter=1&rsv_sug3=13&rsv_sug4=684&rsv_sug1=11&oq=PHOTOSHOPxiaz&rsv_sug2=1&rsp=0&inputT=6994" & Chr(34))
    End Sub
    Private Sub Button212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button212.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=premiere%E4%B8%8B%E8%BD%BD&ie=utf-8&f=8&rsv_bp=1&tn=baidu&rsv_pq=f4047a9700001f6d&rsv_t=e60fEnrZDbpB4r9MSZyYWPa8KzIZ9gK072Am6XUmuBS%2Fqx5P1yiO&bs=photoshop%E4%B8%8B%E8%BD%BD" & Chr(34))
    End Sub
    Private Sub Button213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button213.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&tn=baidu&wd=after%20effect%E4%B8%8B%E8%BD%BD&rsv_pq=9787c2ce0000bebc&rsv_t=b9ebQpk2dADC11jbK1M4VBzLkR55qCOhOEXdWQSFbv3pPfm%2FHqBX&rsv_enter=1&oq=PHOTOSHOPxiaz&inputT=7094&rsv_sug3=36&rsv_sug4=2011&rsv_sug1=20&rsv_sug2=0" & Chr(34))
    End Sub
    Private Sub Button214_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button214.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?wd=flash%E4%B8%8B%E8%BD%BD&ie=utf-8&f=8&rsv_bp=1&tn=baidu&rsv_pq=f4047a9700001f6d&rsv_t=e60fEnrZDbpB4r9MSZyYWPa8KzIZ9gK072Am6XUmuBS%2Fqx5P1yiO&bs=after%20effect%E4%B8%8B%E8%BD%BD" & Chr(34))
    End Sub
    Private Sub Button215_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button215.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=utf-8&f=3&rsv_bp=1&dsp=baidubrowser&tn=baidu&wd=Audition&rsv_pq=e869855f0001c681&rsv_t=545bIhyR5suweOPRWNweK7E%2BRm5cHGeCqliz%2BcjDtKR2ip3C1lfKYqVvj7A&rsv_enter=0&rsv_sug3=1&rsv_sug1=1&rsp=0&inputT=1474&rsv_sug4=1474&rsv_sug=1" & Chr(34))
    End Sub
    Private Sub Button216_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button216.MouseDown
        WshShell.run(Chr(34) & "http://www.adobe.com/downloads.html" & Chr(34))
    End Sub

    Private Sub Button221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button221.MouseDown

        If Dir("D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CC 全系列通用破解补丁\Adobe_Photoshop_CC安装激活教程.mht" & Chr(34))
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht" & Chr(34))
        End If


    End Sub
    Private Sub Button222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button222.MouseDown
        If Dir("D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\Adobe_Photoshop_CS6安装激活教程.mht" & Chr(34))
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CC 全系列通用破解补丁\Adobe_Photoshop_CC安装激活教程.mht" & Chr(34))

        End If

    End Sub
    Private Sub Button223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button223.MouseDown
        If Dir("D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\激活工具\x86\amtlib.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else

            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CS6 全系列通用破解补丁\激活工具" & Chr(34))
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\Adobe CC 全系列通用破解补丁\激活工具" & Chr(34))

        End If
    End Sub

    Private Sub Button231_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button231.MouseDown
       WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=8" & Chr(34))
    End Sub
    Private Sub Button232_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button232.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNzQ2MDc4NzIw.html" & Chr(34))

    End Sub
    Private Sub Button233_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button233.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=UTF-8&wd=adobe%E6%95%99%E7%A8%8B" & Chr(34))
    End Sub

    Private Sub Button241_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button241.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=59" & Chr(34))
    End Sub
    Private Sub Button242_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button242.MouseDown
       WshShell.run(Chr(34) & "http://www.xuexi111.com/s/premiere/" & Chr(34))
    End Sub
    Private Sub Button243_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button243.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=333" & Chr(34))
    End Sub
    Private Sub Button244_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button244.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/baidu?word=Flash%E7%B4%A0%E6%9D%90&tn=bds&cl=3&ct=2097152&si=www.xuexi111.com&s=on" & Chr(34))
    End Sub


    '-----------------------------------------------------------------

    Private Sub Button311_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button311.MouseDown
        WshShell.run(Chr(34) & "http://rj.baidu.com/soft/detail/27006.html" & Chr(34))

    End Sub
    Private Sub Button312_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button312.MouseDown
        WshShell.run(Chr(34) & "http://rj.baidu.com/soft/detail/15648.html" & Chr(34))

    End Sub
    Private Sub Button313_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button313.MouseDown
        WshShell.run(Chr(34) & "http://rj.baidu.com/soft/detail/26085.html" & Chr(34))

    End Sub
    Private Sub Button314_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button314.MouseDown
        WshShell.run(Chr(34) & "https://store.videostudiopro.com/1184/catalog/catalog.1122/category.53191/?id=ftCvEpPgnO&language=zg&hptrack=cn2bb4" & Chr(34))

    End Sub
    Private Sub Button315_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button315.MouseDown
        WshShell.run(Chr(34) & "http://www.corel.com/cn/" & Chr(34))
    End Sub
   

    Private Sub Button321_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button321.MouseDown
        WshShell.run(Chr(34) & "http://jingyan.baidu.com/article/5552ef473936f1518ffbc90f.html" & Chr(34))

    End Sub
    Private Sub Button322_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button322.MouseDown

        If Dir("D:\Program Files\NEXUS\Box\Class3\会声会影\会声会影激活教程.mht") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\会声会影\会声会影激活教程.mht" & Chr(34))

        End If
    End Sub
    Private Sub Button323_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button323.MouseDown
        If Dir("D:\Program Files\NEXUS\Box\Class3\会声会影\Corel激活.exe") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Error.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Box\Class3\会声会影\Corel激活.exe" & Chr(34))

        End If
    End Sub

    Private Sub Button331_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button331.MouseDown
        WshShell.run(Chr(34) & "http://www.51zxw.net/list.aspx?cid=461" & Chr(34))
    End Sub
    Private Sub Button332_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button332.MouseDown
        WshShell.run(Chr(34) & "http://v.youku.com/v_show/id_XNjcxMTM5OTY4.html?f=21844931" & Chr(34))
    End Sub
    Private Sub Button333_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button333.MouseDown
        WshShell.run(Chr(34) & "http://www.baidu.com/s?ie=UTF-8&wd=%E4%BC%9A%E5%A3%B0%E4%BC%9A%E5%BD%B1%E6%95%99%E7%A8%8B" & Chr(34))
    End Sub

    Private Sub Button341_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button341.MouseDown
        WshShell.run(Chr(34) & "http://sc.chinaz.com/yinxiao/" & Chr(34))
    End Sub
    Private Sub Button342_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button342.MouseDown
        WshShell.run(Chr(34) & "http://www.nipic.com/index.html" & Chr(34))
    End Sub
    Private Sub Button343_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button343.MouseDown
        WshShell.run(Chr(34) & "http://www.ooopic.com/shipinsucai/" & Chr(34))
    End Sub
    Private Sub Button344_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button344.MouseDown
        WshShell.run(Chr(34) & "http://font.chinaz.com/" & Chr(34))
    End Sub
    Private Sub Button345_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button345.MouseDown
        WshShell.run(Chr(34) & "http://www.smzy.com/smzy/sort01870-smzy-1870-1.html" & Chr(34))
    End Sub



End Class

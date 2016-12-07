Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        子函数_更新时间()
        子函数_标题选择(0)
    End Sub

    '=====================================子函数====================================
    Private Sub Fun_Shell(i As String)
        WshShell.run(Chr(34) & i & Chr(34))
    End Sub
 
    Private Sub 子函数_提示_标题右侧(i As String)
        If i = "0" Then
            提示_标题右侧.Visibility = Windows.Visibility.Hidden
        Else
            提示_标题右侧.Visibility = Windows.Visibility.Visible
            提示_标题右侧.Text = i
        End If
    End Sub
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
    Private Sub 子函数_标题选择(Titlecodes As UInteger)
        子函数_灰色标题()

        If Titlecodes = 0 Then

            子函数_文件检测(0)
            NEXUS_Box.Title = "NEXUS 5.0"

            主要内容0.Visibility = Windows.Visibility.Visible
           

            标题_左侧标题_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            标题_左侧标题_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

            页脚.Visibility = Windows.Visibility.Visible
        ElseIf Titlecodes = 1 Then


            子函数_文件检测(1)
            NEXUS_Box.Title = "魔枢共享"

            主要内容1.Visibility = Windows.Visibility.Visible


            内容分类1.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))


        ElseIf Titlecodes = 2 Then


            子函数_文件检测(2)
            NEXUS_Box.Title = "学习资源"



            主要内容2.Visibility = Windows.Visibility.Visible

            内容分类2.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

        ElseIf Titlecodes = 3 Then

            子函数_文件检测(3)
            NEXUS_Box.Title = "软件资源"


            主要内容3.Visibility = Windows.Visibility.Visible


            内容分类3.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

        ElseIf Titlecodes = 4 Then


            子函数_文件检测(4)
            NEXUS_Box.Title = "影音资源"

            主要内容4.Visibility = Windows.Visibility.Visible


            内容分类4.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))



        ElseIf Titlecodes = 5 Then

            子函数_文件检测(5)
            NEXUS_Box.Title = "实用工具"


            主要内容5.Visibility = Windows.Visibility.Visible


            内容分类5.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

        ElseIf Titlecodes = 6 Then

            子函数_文件检测(6)
            NEXUS_Box.Title = "网络工具"



            主要内容6.Visibility = Windows.Visibility.Visible


            内容分类6.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

        ElseIf Titlecodes = 7 Then

            子函数_文件检测(7)
            NEXUS_Box.Title = "系统工具"


            主要内容7.Visibility = Windows.Visibility.Visible


            内容分类7.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

        ElseIf Titlecodes = 8 Then

            子函数_文件检测(8)
            NEXUS_Box.Title = "美化工具"



            主要内容8.Visibility = Windows.Visibility.Visible

            内容分类8.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
            内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        ElseIf Titlecodes = 9 Then
            子函数_文件检测(9)
            主要内容9.Visibility = Windows.Visibility.Visible
            页脚.Visibility = Windows.Visibility.Visible

        End If
    End Sub
    Private Sub 子函数_灰色标题()
        主要内容0.Visibility = Windows.Visibility.Hidden
        主要内容1.Visibility = Windows.Visibility.Hidden
        主要内容2.Visibility = Windows.Visibility.Hidden
        主要内容3.Visibility = Windows.Visibility.Hidden
        主要内容4.Visibility = Windows.Visibility.Hidden
        主要内容5.Visibility = Windows.Visibility.Hidden
        主要内容6.Visibility = Windows.Visibility.Hidden
        主要内容7.Visibility = Windows.Visibility.Hidden
        主要内容8.Visibility = Windows.Visibility.Hidden
        主要内容9.Visibility = Windows.Visibility.Hidden

        内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))

        内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

        内容分类1.Background = Nothing
        内容分类2.Background = Nothing
        内容分类3.Background = Nothing
        内容分类4.Background = Nothing
        内容分类5.Background = Nothing
        内容分类6.Background = Nothing
        内容分类7.Background = Nothing
        内容分类8.Background = Nothing

        标题_左侧标题_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        标题_左侧标题_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

        二级区域_设置_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        二级区域_设置_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        主要内容9.Visibility = Windows.Visibility.Hidden
        页脚.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 子函数_文件检测(i As UInteger)
        If i = 0 Then '主页-------------------------------------------------------------------------------主页----------


        ElseIf i = 3 Then '软件资源-------------------------------------------------------------------软件资源----------

            If Dir("D:\Program Files\Matlab6.5\bin\win32\matlab.exe") = "" Then
                内容341_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容341_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\C-Free 5\CppIDE.exe") = "" Then
                内容342_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容342_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE") = "" Then
                内容343_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容343_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program File\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then

                If Dir("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then
                    内容344_Grid_.Visibility = Windows.Visibility.Visible
                Else
                    内容344_Grid_.Visibility = Windows.Visibility.Hidden
                End If

            Else
                内容344_Grid_.Visibility = Windows.Visibility.Hidden
            End If

            If Dir("D:\Program Files\Keil\UV4\UV4.exe") = "" Then
                内容345_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容345_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\ProtelDXP2004\DXP.exe") = "" Then
                内容346_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容346_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Altium\AD13\DXP.EXE") = "" Then
                内容347_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容347_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE") = "" Then
                内容348_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容348_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe") = "" Then
                内容351_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容351_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe") = "" Then
                内容352_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容352_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe") = "" Then
                内容353_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容353_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe") = "" Then
                内容354_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容354_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe") = "" Then
                内容355_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容355_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe") = "" Then
                内容356_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容356_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe") = "" Then
                内容357_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容357_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe") = "" Then
                内容361_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容361_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\IcoFX 2\IcoFX2.exe") = "" Then
                内容362_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容362_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe") = "" Then
                内容363_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容363_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe") = "" Then
                内容364_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容364_Grid_.Visibility = Windows.Visibility.Hidden
            End If


        ElseIf i = 5 Then '实用工具-------------------------------------------------------------------实用工具----------
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
                内容521_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容521_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk") = "" Then
                内容522_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容522_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk") = "" Then
                内容523_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容523_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe") = "" Then
                内容524_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容524_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            '-------------------------------------------------------------------------------


            If Dir("D:\Program Files\Matlab5.3\matlab.exe") = "" Then
                内容536_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容536_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        ElseIf i = 6 Then '网络工具-------------------------------------------------------------------网络工具----------


            If Dir("D:\Program Files\硕鼠\commence.exe") = "" Then
                内容614_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容614_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        ElseIf i = 7 Then '系统工具-------------------------------------------------------------------系统工具----------

            If Dir("D:\Program Files\DriverGenius\drivergenius.exe") = "" Then
                内容722_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容722_Grid_.Visibility = Windows.Visibility.Hidden
            End If
            If Dir("D:\Program Files\DiskGenius\diskgenius.exe") = "" Then
                内容725_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容725_Grid_.Visibility = Windows.Visibility.Hidden
            End If

        ElseIf i = 8 Then '美化工具-------------------------------------------------------------------美化工具----------

        ElseIf i = 9 Then '设置---------------------------------------------------------------------------设置----------

            If Dir("D:\Program Files\NEXUS\Temp\Startup\魔枢后台.lnk") = "" Then
                按钮_后台关.Visibility = Windows.Visibility.Visible
                按钮_后台开.Visibility = Windows.Visibility.Hidden
            Else
                按钮_后台关.Visibility = Windows.Visibility.Hidden
                按钮_后台开.Visibility = Windows.Visibility.Visible
            End If

        End If '-------------------------------------------------------------------------------



    End Sub

    Private Sub 子函数_提示(i As String)
        Tips = i
        一级区域_提示.Visibility = Windows.Visibility.Visible
        If Tips = "0" Then
            一级区域_提示.Visibility = Windows.Visibility.Hidden
        Else
            提示内容.Text = "       缺少" + Tips + "，需要安装吗？点击确定开始从魔枢的百度云共享下载安装。"
        End If
    End Sub
    Private Sub 子函数_提示确定()

        一级区域_提示.Visibility = Windows.Visibility.Hidden
        If 提示标题.Text = "卸载提示" Then
            Fun_Shell("C:\Windows\UnInstall.vbs")
        End If

        If TipsCodes = 321 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 322 Then
            Fun_Shell("http://install.avira-update.com/package/wks_avira13/win32/zhcn/pecl/avira_free_antivirus_zhcn.exe")

        ElseIf TipsCodes = 323 Then
            Fun_Shell("http://sparanoid.com/lab/7z/")

        ElseIf TipsCodes = 324 Then
            Fun_Shell("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B47BF6219-2E7A-8D94-BE09-A7E27F9E5BAD%7D%26lang%3Dzh-CN%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe")

        ElseIf TipsCodes = 325 Then
            Fun_Shell("https://dl.google.com/picasa/picasa39-setup.exe")

        ElseIf TipsCodes = 326 Then
            Fun_Shell("http://dl_dir.qq.com/invc/qqplayer/QQPlayer_Setup_37_892.exe")
        ElseIf TipsCodes = 327 Then
            Fun_Shell("http://www.foobar2000.org/files/152cf5511719b95ebfccb42265ed36f1/foobar2000_v1.3.6.exe")

        End If
        If TipsCodes = 341 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 342 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 343 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 344 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 345 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 346 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 347 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 348 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        End If
        If TipsCodes = 351 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 352 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 353 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 354 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 355 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 356 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 357 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        End If
        If TipsCodes = 361 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 362 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        ElseIf TipsCodes = 363 Then
            Fun_Shell("http://www.corel.com/cn/")
        ElseIf TipsCodes = 364 Then
            Fun_Shell("http://url.cn/Zw0oSk")
        End If







        If TipsCodes = 521 Or TipsCodes = 522 Or TipsCodes = 523 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        ElseIf TipsCodes = 524 Then
            Fun_Shell("http://url.cn/Zw0oSk")


        ElseIf TipsCodes = 533 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        ElseIf TipsCodes = 611 Then
            Fun_Shell("http://url.cn/Zw0oSk")


        ElseIf TipsCodes = 613 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        ElseIf TipsCodes = 614 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        ElseIf TipsCodes = 722 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        ElseIf TipsCodes = 725 Then
            Fun_Shell("http://url.cn/Zw0oSk")

        End If
    End Sub

    Private Sub 子函数_更新时间()
        提示_标题左侧.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub


    Private Sub Fun_Run(i As UInteger)
        TipsCodes = i
        If i = 111 Then
            Fun_Shell("http://202.196.192.25/lyit/_data/index_Lookxl.aspx")

        ElseIf i = 112 Then

            ' Fun_Shell("")

        ElseIf i = 113 Then

            ' Fun_Shell("")

        ElseIf i = 114 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class1\BaiduYunGuanjia\BaiduYunGuanjia.exe")

        ElseIf i = 121 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class1\BaiduYunGuanjia\BaiduYunGuanjia.exe")

        ElseIf i = 122 Then

            Fun_Shell("http://pan.baidu.com/")

        ElseIf i = 211 Then

            Fun_Shell("http://study.163.com/")

        ElseIf i = 212 Then

            Fun_Shell("http://open.163.com/")

        ElseIf i = 213 Then

            Fun_Shell("http://opencla.cntv.cn/")

        ElseIf i = 214 Then

            Fun_Shell("http://course.jingpinke.com/")

        ElseIf i = 215 Then

            Fun_Shell("http://open.sina.com.cn/")

        ElseIf i = 216 Then

            Fun_Shell("http://www.mycampus.hk/")

        ElseIf i = 217 Then

            Fun_Shell("https://www.coursera.org/")

        ElseIf i = 218 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 221 Then

            Fun_Shell("http://www.51zxw.net/")

        ElseIf i = 222 Then

            Fun_Shell("http://www.rjzxw.com/")

        ElseIf i = 223 Then

            Fun_Shell("http://www.jcwcn.com/")

        ElseIf i = 224 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 231 Then

            Fun_Shell("http://www.nipic.com/")

        ElseIf i = 232 Then

            Fun_Shell("http://sc.chinaz.com/")

        ElseIf i = 233 Then

            Fun_Shell("http://www.webshu.net/")

        ElseIf i = 234 Then

            Fun_Shell("http://www.ooopic.com/")

        ElseIf i = 235 Then

            Fun_Shell("http://www.zcool.com.cn/")

        ElseIf i = 236 Then

            Fun_Shell("http://www.sccnn.com/")

        ElseIf i = 237 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")


        ElseIf i = 241 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjU5MDM1NDc2.html")

        ElseIf i = 242 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjg5MzU1OTYw.html")

        ElseIf i = 243 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjQ4MjQ3MDMy.html")

        ElseIf i = 244 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 251 Then

            Fun_Shell("http://v.youku.com/v_show/id_XOTAzMTIxNTI=.html")

        ElseIf i = 252 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzQ2MDc4NzIw.html")

        ElseIf i = 253 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjcxMTM5OTY4.html?f=21844931")

        ElseIf i = 254 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 261 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzI2MzU0MTMy.html")

        ElseIf i = 262 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")



        ElseIf i = 311 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_Office.exe")

        ElseIf i = 312 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_VideoStudio.exe")

        ElseIf i = 313 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_Adobe.exe")

        ElseIf i = 321 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\")
            End If
        ElseIf i = 322 Then

            子函数_提示("AVIRA")

        ElseIf i = 323 Then
            If Dir("C:\Program Files\7-Zip\7zFM.exe") = "" Then
                子函数_提示("7z")
            Else
                Fun_Shell("C:\Program Files\7-Zip\7zFM.exe")
            End If

        ElseIf i = 324 Then

            子函数_提示("Chrome")

        ElseIf i = 325 Then

            子函数_提示("Picasa")


        ElseIf i = 326 Then

            子函数_提示("QQ影音")

        ElseIf i = 327 Then

            子函数_提示("Foobar2000")

        ElseIf i = 328 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 331 Then

            Fun_Shell("http://rj.baidu.com/")

        ElseIf i = 332 Then

            Fun_Shell("http://www.anxz.com/")

        ElseIf i = 333 Then

            Fun_Shell("http://www.appinn.com/")

        ElseIf i = 334 Then

            Fun_Shell("http://www.softonic.cn/")
        ElseIf i = 341 Then
            If Dir("D:\Program Files\Matlab6.5\bin\win32\matlab.exe") = "" Then
                子函数_提示("MATLAB6.5")
            Else
                Fun_Shell("D:\Program Files\Matlab6.5\bin\win32\matlab.exe")
            End If
        ElseIf i = 342 Then
            If Dir("D:\Program Files\C-Free 5\CppIDE.exe") = "" Then
                子函数_提示("C-Free 5.0")
            Else
                Fun_Shell("D:\Program Files\C-Free 5\CppIDE.exe")
            End If
        ElseIf i = 343 Then
            If Dir("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE") = "" Then
                子函数_提示("Visual C++ 6.0")
            Else
                Fun_Shell("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE")
            End If
        ElseIf i = 344 Then
            If Dir("D:\Program File\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then

                If Dir("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then
                    子函数_提示("Visual Studio 2013")
                End If
                Fun_Shell("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe")

            Else
                Fun_Shell("D:\Program Files\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe")
            End If
        ElseIf i = 345 Then
            If Dir("D:\Program Files\Keil\UV4\UV4.exe") = "" Then
                子函数_提示("Keil C51")
            Else
                Fun_Shell("D:\Program Files\Keil\UV4\UV4.exe")
            End If
        ElseIf i = 346 Then
            If Dir("D:\Program Files\ProtelDXP2004\DXP.exe") = "" Then
                子函数_提示("Protel 99SE")
            Else
                Fun_Shell("D:\Program Files\ProtelDXP2004\DXP.exe")
            End If
        ElseIf i = 347 Then
            If Dir("D:\Program Files\Altium\AD13\DXP.EXE") = "" Then
                子函数_提示("Altium Designer")
            Else
                Fun_Shell("D:\Program Files\Altium\AD13\DXP.EXE")
            End If
        ElseIf i = 348 Then
            If Dir("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE") = "" Then
                子函数_提示("Proteus")
            Else
                Fun_Shell("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE")
            End If
        ElseIf i = 351 Then
            If Dir("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe") = "" Then
                子函数_提示("Adobe PhotoShop")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe")
            End If
        ElseIf i = 352 Then
            If Dir("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe") = "" Then
                子函数_提示("Adobe Bridge")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe")
            End If
        ElseIf i = 353 Then
            If Dir("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe") = "" Then
                子函数_提示("Adobe Flash")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe")
            End If
        ElseIf i = 354 Then
            If Dir("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe") = "" Then
                子函数_提示("Adobe Audition")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe")
            End If
        ElseIf i = 355 Then
            If Dir("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe") = "" Then
                子函数_提示("Adobe Premiere")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe")
            End If
        ElseIf i = 356 Then
            If Dir("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe") = "" Then
                子函数_提示("Adobe After Effects")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe")
            End If
        ElseIf i = 357 Then
            If Dir("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe") = "" Then
                子函数_提示("Adobe Illustrator")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe")
            End If
        ElseIf i = 361 Then
            If Dir("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe") = "" Then
                子函数_提示("格式工厂")
            Else
                Fun_Shell("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe")
            End If
        ElseIf i = 362 Then
            If Dir("D:\Program Files\IcoFX 2\IcoFX2.exe") = "" Then
                子函数_提示("IcoFX2")
            Else
                Fun_Shell("D:\Program Files\IcoFX 2\IcoFX2.exe")
            End If
        ElseIf i = 363 Then
            If Dir("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe") = "" Then
                子函数_提示("会声会影")
            Else
                Fun_Shell("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe")
            End If
        ElseIf i = 364 Then
            If Dir("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe") = "" Then
                子函数_提示("美图秀秀")
            Else
                Fun_Shell("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe")
            End If

        ElseIf i = 411 Then

            Fun_Shell("http://i.youku.com/u/UNjE4MzEyOTYw")

        ElseIf i = 412 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzI3ODMzMTUy.html?f=22415103")

        ElseIf i = 413 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 421 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class1\BaiduYunGuanjia\BaiduYunGuanjia.exe")

        ElseIf i = 422 Then


        ElseIf i = 423 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 431 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Class1\BaiduYunGuanjia\BaiduYunGuanjia.exe")
        ElseIf i = 432 Then



        ElseIf i = 433 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 521 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
            End If
        ElseIf i = 522 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk")
            End If
        ElseIf i = 523 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk")
            End If
        ElseIf i = 524 Then
            If Dir("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe") = "" Then
                子函数_提示("Toolbox")
            Else
                Fun_Shell("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe")
            End If
        ElseIf i = 525 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\cleanmaster.exe")

        ElseIf i = 526 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\boostmaster.exe")

        ElseIf i = 527 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\filemaster.exe")

        ElseIf i = 531 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\FX82ES.exe")

        ElseIf i = 532 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\virtualdrivemaster.exe")

        ElseIf i = 533 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\winstart.exe")

        ElseIf i = 534 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\MenuMgr.exe")

        ElseIf i = 535 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\SNDA\Finder\Finder.exe")

        ElseIf i = 536 Then
            If Dir("D:\Program Files\Matlab5.3\matlab.exe") = "" Then
                子函数_提示("Matlab极限精简版")
            Else
                Fun_Shell("D:\Program Files\Matlab5.3\matlab.exe")
            End If
        ElseIf i = 537 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\语音合成\语音合成工具.exe")
        ElseIf i = 541 Then

            Fun_Shell("calc")

        ElseIf i = 542 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\便笺\")

        ElseIf i = 543 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\画图.vbs")

        ElseIf i = 544 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class5\IP.exe")

        ElseIf i = 611 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class6\magicwifi.exe")

        ElseIf i = 612 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class6\VPN\")

        ElseIf i = 613 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class6\dnshelper.exe")

        ElseIf i = 614 Then
            If Dir("D:\Program Files\硕鼠\commence.exe") = "" Then
                子函数_提示("硕鼠视频下载器")
            Else
                Fun_Shell("D:\Program Files\硕鼠\commence.exe")
            End If
        ElseIf i = 615 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 711 Then

            Fun_Shell("netplwiz.exe")

        ElseIf i = 712 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\磁盘管理.vbs")

        ElseIf i = 713 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\设备管理器.vbs")

        ElseIf i = 714 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\计算机管理.vbs")

        ElseIf i = 715 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\系统配置\")

        ElseIf i = 721 Then


            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\KMSpico.exe")

        ElseIf i = 722 Then
            If Dir("D:\Program Files\DriverGenius\drivergenius.exe") = "" Then
                子函数_提示("驱动精灵免安装版")
            Else
                Fun_Shell("D:\Program Files\DriverGenius\drivergenius.exe")
            End If
        ElseIf i = 723 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\pcdoctor.exe")

        ElseIf i = 724 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\datarecovery.exe")

        ElseIf i = 725 Then
            If Dir("D:\Program Files\DiskGenius\diskgenius.exe") = "" Then
                子函数_提示("磁盘精灵免安装版")
            Else
                Fun_Shell("D:\Program Files\DiskGenius\diskgenius.exe")
            End If
        ElseIf i = 726 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\重启资源管理器.vbs")
        ElseIf i = 731 Then
            Fun_Shell("http://111.7.128.33/cache/dlsw.baidu.com/sw-search-sp/soft/dc/23411/dotnetfx35.2792382908.exe?ich_args=34326a8441cc863a8ac0ffad180115fe_7734_0_0_11_5e0f15fae776f25872a85c7c048387d8bb533b3c6c99688148725cd3e3fcf24c_77062a9debe7d16d79e8296329444b08_1_0")
        ElseIf i = 732 Then
            Fun_Shell("http://dl1sw.baidu.com/soft/9b/15910/Microsoft.NET.exe?version=585709662")
        ElseIf i = 733 Then
            Fun_Shell("http://dlsw.baidu.com/sw-search-sp/soft/b9/22370/NDP451-KB2858728-x86-x64.3505182529.exe")
        ElseIf i = 734 Then

            Fun_Shell("http://pan.baidu.com/s/1ntmNpTv")

        ElseIf i = 741 Then

            Fun_Shell("http://pan.baidu.com/s/1sjsKGgt")

        ElseIf i = 742 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Class7\winmaster.exe")

        ElseIf i = 743 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        ElseIf i = 811 Then
            Fun_Shell("http://pan.baidu.com/s/1dDIRDk9")
        ElseIf i = 812 Then
            Fun_Shell("http://pan.baidu.com/s/1pJ8xPxD")
        ElseIf i = 813 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        ElseIf i = 821 Then
            ' Fun_Shell("")
        ElseIf i = 822 Then
            Fun_Shell("http://pan.baidu.com/s/1ntr6YDV")
        ElseIf i = 823 Then
            'Fun_Shell("")
        ElseIf i = 824 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        End If
    End Sub

    Private Sub 子函数_定时关机(i As String)
        Dim shutdown, output, tin, min, hour, ts As String
        WshShell.run("shutdown -a", vbHide)
        tin = 文本框_定时关机.Text
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
                shutdown = "shutdown -s  -t  " + ts
            ElseIf tin < 60 Then
                min = tin
                output = "电脑将在" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s  -t  " + ts
            Else
                min = tin
                hour = Int(tin \ 60)
                min = min - 60 * hour
                output = "电脑将在" + hour + "小时" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s  -t  " + ts
            End If
            WshShell.run(shutdown, vbHide)

        ElseIf i = "取消" Then
            WshShell.run("shutdown -a ", vbHide)

        End If
    End Sub


    '=====================================移动拖拽检测====================================

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        子函数_更新时间()

        Roll()
    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

        子函数_更新时间()

        Roll()
    End Sub

    Private Sub NEXUS_Box_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseEnter
        边框_灰色.Visibility = Windows.Visibility.Hidden
        Cover.Visibility = Windows.Visibility.Hidden
        边框_蓝色.Visibility = Windows.Visibility.Visible
        Title0.Visibility = Windows.Visibility.Hidden
        Title1.Visibility = Windows.Visibility.Visible
        名言.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        If 主要内容0.Visibility = Windows.Visibility.Visible Or 主要内容9.Visibility = Windows.Visibility.Visible Then
            页脚.Visibility = Windows.Visibility.Visible
        End If
    End Sub

    Private Sub NEXUS_Box_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseLeave
        边框_灰色.Visibility = Windows.Visibility.Visible
        Cover.Visibility = Windows.Visibility.Visible
        边框_蓝色.Visibility = Windows.Visibility.Hidden

        Title0.Visibility = Windows.Visibility.Visible
        Title1.Visibility = Windows.Visibility.Hidden
        名言.Foreground = New SolidColorBrush(Color.FromRgb(180, 180, 180))

        页脚.Visibility = Windows.Visibility.Hidden


    End Sub


    Private Sub NEXUS_Box_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Box.MouseLeftButtonDown
        NEXUS_Box.Opacity = 0.85
        NEXUS_Box.DragMove()
        NEXUS_Box.Opacity = 1
    End Sub




    '=====================================局部动作检测====================================
    Private Sub 标题按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮1.MouseDown
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 标题按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseEnter
        标题按钮1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        子函数_提示_标题右侧("反馈")
    End Sub

    Private Sub 标题按钮1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseLeave
        标题按钮1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
    End Sub




    Private Sub 标题按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮2.MouseDown
        NEXUS_Box.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub 标题按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseEnter
        标题按钮2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        子函数_提示_标题右侧("缩小")

    End Sub

    Private Sub 标题按钮2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseLeave
        标题按钮2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))

    End Sub



    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown
        End
    End Sub

    Private Sub 标题按钮3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseEnter
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        子函数_提示_标题右侧("关闭")

    End Sub

    Private Sub 标题按钮3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseLeave
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))

    End Sub
    Private Sub 二级区域_右侧标题按钮_MouseLeave(sender As Object, e As MouseEventArgs) Handles 二级区域_右侧标题按钮.MouseLeave

        子函数_提示_标题右侧("0")
    End Sub
    '--------------------------------------------------------------------------
    Private Sub 二级区域_设置_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 二级区域_设置.MouseDown
        子函数_标题选择(9)


    End Sub

    Private Sub 二级区域_设置_MouseEnter(sender As Object, e As MouseEventArgs) Handles 二级区域_设置.MouseEnter

        二级区域_设置_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        二级区域_设置_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))

    End Sub

    Private Sub 二级区域_设置_MouseLeave(sender As Object, e As MouseEventArgs) Handles 二级区域_设置.MouseLeave

        If 主要内容9.Visibility = Windows.Visibility.Visible Then
        Else
            二级区域_设置_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            二级区域_设置_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub



    Private Sub 快捷操作1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 快捷操作1.MouseDown
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            子函数_提示("TuneUp")
        Else
            Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
        End If
    End Sub

    Private Sub 快捷操作1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 快捷操作1.MouseEnter
        快捷操作1_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        快捷操作1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 快捷操作1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 快捷操作1.MouseLeave
        快捷操作1_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        快捷操作1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

    End Sub

    Private Sub 快捷操作2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 快捷操作2.MouseDown

        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Setting\ControlSetting\shutdown-r.vbs" & Chr(34))
    End Sub

    Private Sub 快捷操作2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 快捷操作2.MouseEnter
        快捷操作2_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        快捷操作2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 快捷操作2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 快捷操作2.MouseLeave
        快捷操作2_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        快捷操作2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

    End Sub

    Private Sub 快捷操作3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 快捷操作3.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Setting\ControlSetting\shutdown-s.vbs" & Chr(34))
    End Sub

    Private Sub 快捷操作3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 快捷操作3.MouseEnter
        快捷操作3_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        快捷操作3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 快捷操作3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 快捷操作3.MouseLeave
        快捷操作3_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        快捷操作3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

    End Sub




    Private Sub 按钮_后台_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_后台.MouseDown
        If 按钮_后台关.Visibility = Windows.Visibility.Visible Then
            按钮_后台关.Visibility = Windows.Visibility.Hidden
            按钮_后台开.Visibility = Windows.Visibility.Visible
            Fun_Shell("C:\Windows\StartupOK.vbs")
        Else
            按钮_后台关.Visibility = Windows.Visibility.Visible
            按钮_后台开.Visibility = Windows.Visibility.Hidden
            Fun_Shell("C:\Windows\StartupCancel.vbs")
        End If
    End Sub
    Private Sub 按钮_精灵影视_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_精灵影视.MouseDown
        Fun_Shell("http://i.youku.com/u/UNjE4MzEyOTYw")
    End Sub
    Private Sub 按钮_路径1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_路径1.MouseDown

        Fun_Shell("D:\Program Files\NEXUS\")
    End Sub
    Private Sub 按钮_路径2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_路径2.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Setting\ControlSetting\StartupFolder.vbs")

    End Sub

    Private Sub 按钮_更新_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_更新.MouseDown
        Fun_Shell("http://pan.baidu.com/s/12IKJ8#path=%252F%25E5%25AE%25A2%25E6%2588%25B7%25E7%25AB%25AF")

    End Sub

    Private Sub 按钮_源代码_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_源代码.MouseDown

        Fun_Shell("http://pan.baidu.com/s/1c0tRlIg#path=%252F%25E6%25BA%2590%25E4%25BB%25A3%25E7%25A0%2581")
    End Sub
    Private Sub 按钮_反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_反馈.MouseDown
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 按钮_卸载_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_卸载.MouseDown

        一级区域_提示.Visibility = Windows.Visibility.Visible
        提示标题.Text = "卸载提示"
        提示内容.Text = "       注意：此操作不可恢复，确认卸载？"
    End Sub


    Private Sub 标题_左侧标题_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题_左侧标题.MouseDown
        子函数_标题选择(0)
    End Sub

    Private Sub 标题_左侧标题_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题_左侧标题.MouseEnter
        标题_左侧标题_Image_.Background = New SolidColorBrush(Color.FromRgb(27, 161, 227))
        标题_左侧标题_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 标题_左侧标题_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题_左侧标题.MouseLeave
        If 主要内容0.Visibility = Windows.Visibility.Visible Then
        Else
            标题_左侧标题_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            标题_左侧标题_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))

        End If

    End Sub




    Private Sub 内容分类1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类1.MouseDown
        子函数_标题选择(1)
    End Sub

    Private Sub 内容分类1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类1.MouseEnter
        内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(27, 161, 227))
        内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类1.MouseLeave
        If 主要内容1.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If

    End Sub
    Private Sub 内容分类2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类2.MouseDown
        子函数_标题选择(2)
    End Sub

    Private Sub 内容分类2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类2.MouseEnter
        内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类2.MouseLeave
        If 主要内容2.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类3.MouseDown
        子函数_标题选择(3)
    End Sub

    Private Sub 内容分类3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类3.MouseEnter
        内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类3.MouseLeave
        If 主要内容3.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类4.MouseDown
        子函数_标题选择(4)
    End Sub

    Private Sub 内容分类4_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类4.MouseEnter
        内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类4_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类4.MouseLeave
        If 主要内容4.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类5.MouseDown
        子函数_标题选择(5)
    End Sub

    Private Sub 内容分类5_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类5.MouseEnter
        内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类5_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类5.MouseLeave
        If 主要内容5.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类6.MouseDown
        子函数_标题选择(6)
    End Sub

    Private Sub 内容分类6_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类6.MouseEnter
        内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类6_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类6.MouseLeave
        If 主要内容6.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类7_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类7.MouseDown
        子函数_标题选择(7)
    End Sub

    Private Sub 内容分类7_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类7.MouseEnter
        内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类7_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类7.MouseLeave
        If 主要内容7.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub
    Private Sub 内容分类8_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类8.MouseDown
        子函数_标题选择(8)
    End Sub

    Private Sub 内容分类8_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类8.MouseEnter
        内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))
        内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 内容分类8_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类8.MouseLeave
        If 主要内容8.Visibility = Windows.Visibility.Visible Then
        Else
            内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
            内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
        End If
    End Sub



    '=========================================内容=============================================
    Private Sub 内容111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容111.MouseDown
        Fun_Run("111")
    End Sub
    Private Sub 内容112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容112.MouseDown
        Fun_Run("112")
    End Sub
    Private Sub 内容113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容113.MouseDown
        Fun_Run("113")
    End Sub
    Private Sub 内容114_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容114.MouseDown
        Fun_Run("114")
    End Sub

    Private Sub 内容114_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容114.MouseEnter
        提示114.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容114_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容114.MouseLeave
        提示114.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容121.MouseDown
        Fun_Run("121")
    End Sub
    Private Sub 内容122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容122.MouseDown
        Fun_Run("122")
    End Sub


    '-------------------------------------------------------------------------------------------



    Private Sub 内容211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容211.MouseDown
        Fun_Run("211")
    End Sub
    Private Sub 内容212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容212.MouseDown
        Fun_Run("212")
    End Sub
    Private Sub 内容213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容213.MouseDown
        Fun_Run("213")
    End Sub
    Private Sub 内容214_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容214.MouseDown
        Fun_Run("214")
    End Sub
    Private Sub 内容215_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容215.MouseDown
        Fun_Run("215")
    End Sub
    Private Sub 内容216_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容216.MouseDown
        Fun_Run("216")
    End Sub
    Private Sub 内容217_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容217.MouseDown
        Fun_Run("217")
    End Sub
    Private Sub 内容218_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容218.MouseDown
        Fun_Run("218")
    End Sub
    Private Sub 内容218_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容218.MouseEnter
        提示218.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容218_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容218.MouseLeave
        提示218.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容221.MouseDown
        Fun_Run("221")
    End Sub
    Private Sub 内容222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容222.MouseDown
        Fun_Run("222")
    End Sub
    Private Sub 内容223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容223.MouseDown
        Fun_Run("223")
    End Sub
    Private Sub 内容224_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容224.MouseDown
        Fun_Run("224")
    End Sub

    Private Sub 内容224_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容224.MouseEnter
        提示224.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容224_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容224.MouseLeave
        提示224.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容231_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容231.MouseDown
        Fun_Run("231")
    End Sub
    Private Sub 内容232_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容232.MouseDown
        Fun_Run("232")
    End Sub
    Private Sub 内容233_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容233.MouseDown
        Fun_Run("233")
    End Sub
    Private Sub 内容234_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容234.MouseDown
        Fun_Run("234")
    End Sub
    Private Sub 内容235_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容235.MouseDown
        Fun_Run("235")
    End Sub
    Private Sub 内容236_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容236.MouseDown
        Fun_Run("236")
    End Sub
    Private Sub 内容237_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容237.MouseDown
        Fun_Run("237")
    End Sub

    Private Sub 内容237_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容237.MouseEnter
        提示237.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容237_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容237.MouseLeave
        提示237.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容241_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容241.MouseDown
        Fun_Run("241")
    End Sub
    Private Sub 内容242_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容242.MouseDown
        Fun_Run("242")
    End Sub
    Private Sub 内容243_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容243.MouseDown
        Fun_Run("243")
    End Sub
    Private Sub 内容244_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容244.MouseDown
        Fun_Run("244")
    End Sub

    Private Sub 内容244_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容244.MouseEnter
        提示244.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容244_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容244.MouseLeave
        提示244.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容251_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容251.MouseDown
        Fun_Run("251")
    End Sub
    Private Sub 内容252_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容252.MouseDown
        Fun_Run("252")
    End Sub
    Private Sub 内容253_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容253.MouseDown
        Fun_Run("253")
    End Sub
    Private Sub 内容254_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容254.MouseDown
        Fun_Run("254")
    End Sub

    Private Sub 内容254_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容254.MouseEnter
        提示254.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容254_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容254.MouseLeave
        提示254.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容261_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容261.MouseDown
        Fun_Run("261")
    End Sub
    Private Sub 内容262_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容262.MouseDown
        Fun_Run("262")
    End Sub

    Private Sub 内容262_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容262.MouseEnter
        提示262.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容262_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容262.MouseLeave
        提示262.Visibility = Windows.Visibility.Hidden
    End Sub


    '-------------------------------------------------------------------------------------------


    Private Sub 内容311_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容311.MouseDown
        Fun_Run("311")
    End Sub
    Private Sub 内容312_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容312.MouseDown
        Fun_Run("312")
    End Sub
    Private Sub 内容313_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容313.MouseDown
        Fun_Run("313")
    End Sub


    Private Sub 内容321_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容321.MouseDown
        Fun_Run("321")
    End Sub
    Private Sub 内容322_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容322.MouseDown
        Fun_Run("322")
    End Sub
    Private Sub 内容323_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容323.MouseDown
        Fun_Run("323")
    End Sub
    Private Sub 内容324_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容324.MouseDown
        Fun_Run("324")
    End Sub
    Private Sub 内容325_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容325.MouseDown
        Fun_Run("325")
    End Sub
    Private Sub 内容326_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容326.MouseDown
        Fun_Run("326")
    End Sub
    Private Sub 内容327_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容327.MouseDown
        Fun_Run("327")
    End Sub

    Private Sub 内容328_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容328.MouseDown
        Fun_Run("328")
    End Sub

    Private Sub 内容328_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容328.MouseEnter
        提示328.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容328_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容328.MouseLeave
        提示328.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容331_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容331.MouseDown
        Fun_Run("331")
    End Sub
    Private Sub 内容332_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容332.MouseDown
        Fun_Run("332")
    End Sub
    Private Sub 内容333_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容333.MouseDown
        Fun_Run("333")
    End Sub
    Private Sub 内容334_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容334.MouseDown
        Fun_Run("334")
    End Sub


    Private Sub 内容341_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容341.MouseDown
        Fun_Run("341")
    End Sub
    Private Sub 内容342_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容342.MouseDown
        Fun_Run("342")
    End Sub
    Private Sub 内容343_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容343.MouseDown
        Fun_Run("343")
    End Sub
    Private Sub 内容344_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容344.MouseDown
        Fun_Run("344")
    End Sub
    Private Sub 内容345_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容345.MouseDown
        Fun_Run("345")
    End Sub
    Private Sub 内容346_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容346.MouseDown
        Fun_Run("346")
    End Sub
    Private Sub 内容347_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容347.MouseDown
        Fun_Run("347")
    End Sub
    Private Sub 内容348_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容348.MouseDown
        Fun_Run("348")
    End Sub
    Private Sub 内容351_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容351.MouseDown
        Fun_Run("351")
    End Sub
    Private Sub 内容352_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容352.MouseDown
        Fun_Run("352")
    End Sub
    Private Sub 内容353_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容353.MouseDown
        Fun_Run("353")
    End Sub
    Private Sub 内容354_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容354.MouseDown
        Fun_Run("354")
    End Sub
    Private Sub 内容355_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容355.MouseDown
        Fun_Run("355")
    End Sub
    Private Sub 内容356_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容356.MouseDown
        Fun_Run("356")
    End Sub
    Private Sub 内容357_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容357.MouseDown
        Fun_Run("357")
    End Sub
    Private Sub 内容361_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容361.MouseDown
        Fun_Run("361")
    End Sub
    Private Sub 内容362_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容362.MouseDown
        Fun_Run("362")
    End Sub
    Private Sub 内容363_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容363.MouseDown
        Fun_Run("363")
    End Sub
    Private Sub 内容364_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容364.MouseDown
        Fun_Run("364")
    End Sub
    '---------------------------------------------------------------------------------




    Private Sub 内容411_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容411.MouseDown
        Fun_Run("411")
    End Sub
    Private Sub 内容412_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容412.MouseDown
        Fun_Run("412")
    End Sub
    Private Sub 内容413_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容413.MouseDown
        Fun_Run("413")
    End Sub
    Private Sub 内容413_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容413.MouseEnter
        提示413.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容413_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容413.MouseLeave
        提示413.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容421_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容421.MouseDown
        Fun_Run("421")
    End Sub
    Private Sub 内容422_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容422.MouseDown
        Fun_Run("422")
    End Sub
    Private Sub 内容423_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容423.MouseDown
        Fun_Run("423")
    End Sub
    Private Sub 内容423_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容423.MouseEnter
        提示423.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容423_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容423.MouseLeave
        提示423.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容431_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容431.MouseDown
        Fun_Run("431")
    End Sub
    Private Sub 内容432_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容432.MouseDown
        Fun_Run("432")
    End Sub
    Private Sub 内容433_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容433.MouseDown
        Fun_Run("433")
    End Sub
    Private Sub 内容433_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容433.MouseEnter
        提示433.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容433_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容433.MouseLeave
        提示433.Visibility = Windows.Visibility.Hidden
    End Sub


    '------------------------------------------------------------------------------------




    Private Sub 内容511_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容511.MouseDown
        Fun_Run("511")
    End Sub
    Private Sub 内容512_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容512.MouseDown
        Fun_Run("512")
    End Sub


    Private Sub 内容521_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容521.MouseDown
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            子函数_提示("TuneUp")
        Else
            Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
        End If
    End Sub
    Private Sub 内容522_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容522.MouseDown
        Fun_Run("522")
    End Sub
    Private Sub 内容523_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容523.MouseDown
        Fun_Run("523")
    End Sub
    Private Sub 内容524_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容524.MouseDown
        Fun_Run("524")
    End Sub
    Private Sub 内容525_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容525.MouseDown
        Fun_Run("525")
    End Sub
    Private Sub 内容526_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容526.MouseDown
        Fun_Run("526")
    End Sub
    Private Sub 内容527_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容527.MouseDown
        Fun_Run("527")
    End Sub
    Private Sub 内容531_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容531.MouseDown
        Fun_Run("531")
    End Sub
    Private Sub 内容532_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容532.MouseDown
        Fun_Run("532")
    End Sub
    Private Sub 内容533_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容533.MouseDown
        Fun_Run("533")
    End Sub
    Private Sub 内容534_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容534.MouseDown
        Fun_Run("534")
    End Sub
    Private Sub 内容535_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容535.MouseDown
        Fun_Run("535")
    End Sub
    Private Sub 内容536_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容536.MouseDown
        Fun_Run("536")
    End Sub
    Private Sub 内容537_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容537.MouseDown
        Fun_Run("537")
    End Sub

    Private Sub 内容541_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容541.MouseDown
        Fun_Run("541")
    End Sub
    Private Sub 内容542_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容542.MouseDown
        Fun_Run("542")
    End Sub
    Private Sub 内容543_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容543.MouseDown
        Fun_Run("543")
    End Sub
    Private Sub 内容544_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容544.MouseDown
        Fun_Run("544")
    End Sub


    '--------------------------------------------------------------------------------------------




    Private Sub 内容611_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容611.MouseDown
        Fun_Run("611")
    End Sub
    Private Sub 内容612_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容612.MouseDown
        Fun_Run("612")
    End Sub
    Private Sub 内容613_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容613.MouseDown
        Fun_Run("613")
    End Sub
    Private Sub 内容614_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容614.MouseDown
        Fun_Run("614")
    End Sub
    Private Sub 内容615_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容615.MouseDown
        Fun_Run("615")
    End Sub

    Private Sub 内容615_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容615.MouseEnter
        提示615.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容615_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容615.MouseLeave
        提示615.Visibility = Windows.Visibility.Hidden
    End Sub


    '---------------------------------------------------------------------------






    Private Sub 内容711_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容711.MouseDown
        Fun_Run("711")
    End Sub
    Private Sub 内容712_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容712.MouseDown
        Fun_Run("712")
    End Sub
    Private Sub 内容713_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容713.MouseDown
        Fun_Run("713")
    End Sub
    Private Sub 内容714_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容714.MouseDown
        Fun_Run("714")
    End Sub
    Private Sub 内容715_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容715.MouseDown
        Fun_Run("715")
    End Sub

    Private Sub 内容721_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容721.MouseDown
        Fun_Run("721")
    End Sub
    Private Sub 内容722_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容722.MouseDown
        Fun_Run("722")
    End Sub
    Private Sub 内容723_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容723.MouseDown
        Fun_Run("723")
    End Sub
    Private Sub 内容724_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容724.MouseDown
        Fun_Run("724")
    End Sub
    Private Sub 内容725_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容725.MouseDown
        Fun_Run("725")
    End Sub
    Private Sub 内容726_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容726.MouseDown
        Fun_Run("726")
    End Sub
    Private Sub 内容731_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容731.MouseDown
        Fun_Run("731")
    End Sub
    Private Sub 内容732_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容732.MouseDown
        Fun_Run("731")
    End Sub
    Private Sub 内容733_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容733.MouseDown
        Fun_Run("733")
    End Sub
    Private Sub 内容734_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容734.MouseDown
        Fun_Run("734")
    End Sub
    Private Sub 内容741_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容741.MouseDown
        Fun_Run("741")
    End Sub
    Private Sub 内容742_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容742.MouseDown
        Fun_Run("742")
    End Sub
    Private Sub 内容743_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容743.MouseDown
        Fun_Run("743")
    End Sub

    Private Sub 内容743_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容743.MouseEnter
        提示743.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容743_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容743.MouseLeave
        提示743.Visibility = Windows.Visibility.Hidden
    End Sub

    '--------------------------------------------------------------------





    Private Sub 内容811_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容811.MouseDown
        Fun_Run("811")
    End Sub
    Private Sub 内容812_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容812.MouseDown
        Fun_Run("812")
    End Sub
    Private Sub 内容813_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容813.MouseDown
        Fun_Run("813")
    End Sub
    Private Sub 内容813_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容813.MouseEnter
        提示813.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容813_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容813.MouseLeave
        提示813.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容821_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容821.MouseDown
        Fun_Run("821")
    End Sub
    Private Sub 内容822_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容822.MouseDown
        Fun_Run("822")
    End Sub
    Private Sub 内容823_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容823.MouseDown
        Fun_Run("823")
    End Sub
    Private Sub 内容824_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容824.MouseDown
        Fun_Run("824")
    End Sub

    Private Sub 内容824_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容824.MouseEnter
        提示824.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容824_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容824.MouseLeave
        提示824.Visibility = Windows.Visibility.Hidden
    End Sub







    Private Sub 按钮_提示取消_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_提示取消.MouseDown
        一级区域_提示.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 按钮_提示确定_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_提示确定.MouseDown
        一级区域_提示.Visibility = Windows.Visibility.Hidden
        子函数_提示确定()
    End Sub


    Private Sub 按钮_定时关机_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_定时开.MouseDown
        子函数_定时关机("执行")
    End Sub
    Private Sub 文本框_定时关机_Keyup(sender As Object, e As KeyEventArgs) Handles 文本框_定时关机.KeyUp
        Dim tin As String
        tin = 文本框_定时关机.Text
        If tin = "" Then
            文本框_定时关机提示.Text = "电脑将在                       多久后关机"
        Else
            If tin > 0 Then
                If tin < 10 Then
                    文本框_定时关机提示.Text = "电脑将在                       小时后关机"
                ElseIf tin >= 10 Then
                    文本框_定时关机提示.Text = "电脑将在                       分钟后关机"
                End If
            End If
        End If
    End Sub

    Private Sub 按钮_定时关_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_定时关.MouseDown
        子函数_定时关机("取消")
    End Sub



    Private Sub C11_MouseEnter(sender As Object, e As MouseEventArgs) Handles C11.MouseEnter
        课表备注.Text = "考核方式：考试★          老师：张丽娟          学分：3.0★★★          学时：48"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C11_MouseLeave(sender As Object, e As MouseEventArgs) Handles C11.MouseLeave
        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub C12_MouseEnter(sender As Object, e As MouseEventArgs) Handles C12.MouseEnter
        课表备注.Text = "考核方式：考试★          老师：葛运旺          学分：2.5★★☆          学时：40"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C12_MouseLeave(sender As Object, e As MouseEventArgs) Handles C12.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub


    Private Sub C13_MouseEnter(sender As Object, e As MouseEventArgs) Handles C13.MouseEnter
        课表备注.Text = "考核方式：考查☆          老师：李春娟          学分：2.5★★☆          学时：40"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C13_MouseLeave(sender As Object, e As MouseEventArgs) Handles C13.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub C21_MouseEnter(sender As Object, e As MouseEventArgs) Handles C21.MouseEnter
        课表备注.Text = "考核方式：考查☆          老师：康怀云          学分：2.0★★             学时：32"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C21_MouseLeave(sender As Object, e As MouseEventArgs) Handles C21.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub


    Private Sub C22_MouseEnter(sender As Object, e As MouseEventArgs) Handles C22.MouseEnter
        课表备注.Text = "考核方式：考试★          老师：张丽娟          学分：3.0★★★          学时：48"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C22_MouseLeave(sender As Object, e As MouseEventArgs) Handles C22.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub C31_MouseEnter(sender As Object, e As MouseEventArgs) Handles C31.MouseEnter
        课表备注.Text = "考核方式：考查☆          老师：康怀云          学分：2.0★★             学时：32"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C31_MouseLeave(sender As Object, e As MouseEventArgs) Handles C31.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub


    Private Sub C42_MouseEnter(sender As Object, e As MouseEventArgs) Handles C42.MouseEnter
        课表备注.Text = "考核方式：考试★          老师：葛运旺          学分：2.5★★☆          学时：40"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C42_MouseLeave(sender As Object, e As MouseEventArgs) Handles C42.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub C43_MouseEnter(sender As Object, e As MouseEventArgs) Handles C43.MouseEnter
        课表备注.Text = "考核方式：考查☆          老师：李春娟          学分：2.5★★☆          学时：40"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub C43_MouseLeave(sender As Object, e As MouseEventArgs) Handles C43.MouseLeave

        课表备注.Text = ""
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub



    Private Sub 主页_课表_MouseLeave(sender As Object, e As MouseEventArgs) Handles 主页_课表.MouseLeave
        课表备注.Text = "暂无"
        课表备注.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub
End Class

Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\NEXUS_DataCenter_Open.vbs")
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\NEXUS_Panel_Close.vbs")

        Grid_Goto.Visibility = Windows.Visibility.Hidden
    End Sub
    '=====================================子函数====================================
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

    Private Sub Fun_Color(i As String)

        If i = "0" Then
            Grid_Title.Background = New SolidColorBrush(Color.FromRgb(0, 80, 239))
            Ellipse1.Fill = New SolidColorBrush(Color.FromRgb(230, 230, 230))
            Ellipse2.Fill = New SolidColorBrush(Color.FromRgb(0, 80, 239))


        ElseIf i = "1" Then
            Grid_Title.Background = New SolidColorBrush(Color.FromRgb(230, 230, 230))
            Ellipse1.Fill = New SolidColorBrush(Color.FromRgb(0, 80, 239))
            Ellipse2.Fill = New SolidColorBrush(Color.FromRgb(230, 230, 230))


        End If
    End Sub



    '=====================================窗口移动拖拽====================================

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub NEXUS_DataCenter_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_DataCenter.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible
        ' Fun_Color("1")

    End Sub

    Private Sub NEXUS_DataCenter_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_DataCenter.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

        'Fun_Color("0")
    End Sub

    Private Sub Background_Title_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Background_Title.MouseLeftButtonDown
        NEXUS_DataCenter.Opacity = 0.85
        NEXUS_DataCenter.DragMove()
        NEXUS_DataCenter.Opacity = 1
    End Sub


    '=====================================标题按钮====================================
    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown
        Fun_Shell("http://www.sojump.com/jq/3499620.aspx")
    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("反馈")
    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(255, 224, 178))
    End Sub




    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        NEXUS_DataCenter.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 224, 178))

    End Sub



    Private Sub TitleButton3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton3.MouseDown
        End
    End Sub

    Private Sub TitleButton3_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseEnter
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("关闭")

    End Sub

    Private Sub TitleButton3_MouseLeave(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseLeave
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 224, 178))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 224, 178))

    End Sub
    Private Sub Grid_TitleButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles Grid_TitleButton.MouseLeave

        Fun_TitleTips("0")
    End Sub



    Private Sub ButtonB0_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB0.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_Panel.exe")

    End Sub

    Private Sub ButtonB1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB1.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_AppCenter.exe")

    End Sub

    Private Sub ButtonB2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB2.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_MediaCenter.exe")

    End Sub

    Private Sub ButtonB3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB3.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_DataCenter.exe")

    End Sub

    Private Sub ButtonB4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB4.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_ToolBox.exe")

    End Sub

    Private Sub ButtonB5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB5.MouseDown
        Fun_Shell("http://www.sojump.com/jq/3499620.aspx")

    End Sub

    Private Sub ButtonB6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB6.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_SettingCenter.exe")

    End Sub

    Private Sub Button_Goto_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Goto.MouseDown
        If Grid_Goto.Visibility = Windows.Visibility.Hidden Then
            Grid_Goto.Visibility = Windows.Visibility.Visible
        Else
            Grid_Goto.Visibility = Windows.Visibility.Hidden
        End If
    End Sub



    Private Sub Button11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button11.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\baiduyunguanjia.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\baiduyunguanjia.exe")
        End If
    End Sub

    Private Sub Button11_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button11.MouseEnter
        Button11.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button11_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button11.MouseLeave
        Button11.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button12.MouseDown

        Fun_Shell("http://pan.baidu.com")
    End Sub

    Private Sub Button12_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button12.MouseEnter
        Button12.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button12.MouseLeave
        Button12.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button13.MouseDown
        Fun_Shell("http://202.196.192.25/lyit/_data/index_Lookxl.aspx")
    End Sub

    Private Sub Button13_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button13.MouseEnter
        Button13.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button13_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button13.MouseLeave
        Button13.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button14_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button14.MouseDown

        Fun_Shell("http://202.196.192.25/lyit/ZNPK/KBFB_ClassSel.aspx")
    End Sub

    Private Sub Button14_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button14.MouseEnter
        Button14.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button14_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button14.MouseLeave
        Button14.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button21.MouseDown
        Fun_Shell("http://study.163.com/")
    End Sub

    Private Sub Button21_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button21.MouseEnter
        Button21.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button21_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button21.MouseLeave
        Button21.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button22.MouseDown
        Fun_Shell("http://open.163.com/")
    End Sub

    Private Sub Button22_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button22.MouseEnter
        Button22.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button22_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button22.MouseLeave
        Button22.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button23.MouseDown
        Fun_Shell("http://opencla.cntv.cn/")
    End Sub

    Private Sub Button23_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button23.MouseEnter
        Button23.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button23_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button23.MouseLeave
        Button23.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button24_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button24.MouseDown
        Fun_Shell("http://www.mycampus.hk/")
    End Sub

    Private Sub Button24_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button24.MouseEnter
        Button24.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button24_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button24.MouseLeave
        Button24.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button25_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button25.MouseDown
        Fun_Shell("https://www.coursera.org/")
    End Sub

    Private Sub Button25_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button25.MouseEnter
        Button25.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button25_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button25.MouseLeave
        Button25.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button31.MouseDown
        Fun_Shell("http://www.51zxw.net/")
    End Sub

    Private Sub Button31_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button31.MouseEnter
        Button31.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button31_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button31.MouseLeave
        Button31.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button32.MouseDown
        Fun_Shell("http://www.rjzxw.com/")
    End Sub

    Private Sub Button32_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button32.MouseEnter
        Button32.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button32_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button32.MouseLeave
        Button32.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub
    Private Sub Button33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button33.MouseDown
        Fun_Shell("http://www.jcwcn.com/")
    End Sub

    Private Sub Button33_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button33.MouseEnter
        Button33.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button33_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button33.MouseLeave
        Button33.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub


    Private Sub Button41_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button41.MouseDown
        Fun_Shell("http://www.nipic.com/")
    End Sub

    Private Sub Button41_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button41.MouseEnter
        Button41.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button41_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button41.MouseLeave
        Button41.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button42_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button42.MouseDown
        Fun_Shell("http://sc.chinaz.com/")
    End Sub

    Private Sub Button42_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button42.MouseEnter
        Button42.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button42_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button42.MouseLeave
        Button42.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button43_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button43.MouseDown
        Fun_Shell("http://www.sccnn.com/")
    End Sub

    Private Sub Button43_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button43.MouseEnter
        Button43.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button43_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button43.MouseLeave
        Button43.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button44_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button44.MouseDown
        Fun_Shell("http://www.webshu.net/")
    End Sub

    Private Sub Button44_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button44.MouseEnter
        Button44.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button44_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button44.MouseLeave
        Button44.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button45_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button45.MouseDown
        Fun_Shell("http://www.zcool.com.cn/")
    End Sub

    Private Sub Button45_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button45.MouseEnter
        Button45.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button45_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button45.MouseLeave
        Button45.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button51_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button51.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNjU5MDM1NDc2.html")
    End Sub

    Private Sub Button51_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button51.MouseEnter
        Button51.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button51_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button51.MouseLeave
        Button51.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button52_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button52.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNjg5MzU1OTYw.html")
    End Sub

    Private Sub Button52_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button52.MouseEnter
        Button52.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button52_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button52.MouseLeave
        Button52.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button53_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button53.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNjQ4MjQ3MDMy.html")
    End Sub

    Private Sub Button53_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button53.MouseEnter
        Button53.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button53_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button53.MouseLeave
        Button53.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button61_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button61.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNzQ2MDc4NzIw.html")
    End Sub

    Private Sub Button61_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button61.MouseEnter
        Button61.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button61_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button61.MouseLeave
        Button61.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button62_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button62.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNjcxMTM5OTY4.html?f=21844931")
    End Sub

    Private Sub Button62_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button62.MouseEnter
        Button62.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button62_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button62.MouseLeave
        Button62.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button63_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button63.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XOTAzMTIxNTI=.html")
    End Sub

    Private Sub Button63_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button63.MouseEnter
        Button63.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button63_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button63.MouseLeave
        Button63.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub

    Private Sub Button71_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button71.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XNzI2MzU0MTMy.html")
    End Sub

    Private Sub Button71_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button71.MouseEnter
        Button71.Fill = New SolidColorBrush(Color.FromArgb(30, 0, 0, 0))
    End Sub

    Private Sub Button71_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button71.MouseLeave
        Button71.Fill = New SolidColorBrush(Color.FromArgb(0, 0, 0, 0))
    End Sub



End Class

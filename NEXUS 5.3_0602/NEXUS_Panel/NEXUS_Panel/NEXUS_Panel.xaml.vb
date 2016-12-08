Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Fun_Clock()

        Tab(1)
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\CloseExpand.vbs")
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\NEXUS_Panel_Open.vbs")
        Fun_Shell("C:\Program Files\NEXUS\Window.Main\NEXUS_Backstage.exe")
    End Sub
    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\NEXUS_Panel_Close.vbs")
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
    Private Sub Fun_Clock()
        Clock.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
    Private Sub Tab(i As UInteger)

        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab4.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab5.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab4_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab5_Rectangle_.Visibility = Windows.Visibility.Hidden

        Tab_1.Visibility = Windows.Visibility.Hidden
        Tab_2.Visibility = Windows.Visibility.Hidden
        Tab_3.Visibility = Windows.Visibility.Hidden
        Tab_4.Visibility = Windows.Visibility.Hidden
        Tab_5.Visibility = Windows.Visibility.Hidden
        If i = 1 Then
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_1.Visibility = Windows.Visibility.Visible
          
        ElseIf i = 2 Then
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_2.Visibility = Windows.Visibility.Visible

        ElseIf i = 3 Then
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_3.Visibility = Windows.Visibility.Visible

        ElseIf i = 4 Then
            Title_Tab4.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab4_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_4.Visibility = Windows.Visibility.Visible

        ElseIf i = 5 Then
            Title_Tab5.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab5_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_5.Visibility = Windows.Visibility.Visible
        Else
        End If


    End Sub



    '=====================================窗口移动拖拽====================================

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Fun_Clock()

        Roll()
    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

        Fun_Clock()

        Roll()
    End Sub

    Private Sub NEXUS_Panel_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Panel.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub NEXUS_Panel_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Panel.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

    End Sub

  

    Private Sub Background_Title_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Background_Title.MouseLeftButtonDown
        NEXUS_Panel.Opacity = 0.85
        NEXUS_Panel.DragMove()
        NEXUS_Panel.Opacity = 1
    End Sub


    '=====================================标题按钮====================================
   


    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown
        NEXUS_Panel.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave

        TitleButton1_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))

    End Sub



    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBS\NEXUS_Panel_Close.vbs")
        End

    End Sub

    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        TitleButton2_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("关闭")

    End Sub

    Private Sub TitleButton2_MouseLeave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        TitleButton2_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))

    End Sub
    Private Sub Grid_TitleButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles Grid_TitleButton.MouseLeave

        Fun_TitleTips("0")
    End Sub


    '=====================================标题分类====================================
    Private Sub Title_Tab1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab1.MouseDown
        Tab(1)
    End Sub
    Private Sub Title_Tab1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseEnter
        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

    End Sub
    Private Sub Title_Tab1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseLeave
        If Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Hidden Then
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
        If Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Hidden Then
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
        If Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        End If

    End Sub

    Private Sub Title_Tab4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab4.MouseDown
        Tab(4)

    End Sub

    Private Sub Title_Tab4_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab4.MouseEnter
        Title_Tab4.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab4_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab4.MouseLeave
        If Title_Tab4_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Title_Tab4.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        End If

    End Sub

    Private Sub Title_Tab5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab5.MouseDown
        Tab(5)

    End Sub

    Private Sub Title_Tab5_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab5.MouseEnter
        Title_Tab5.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab5_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab5.MouseLeave
        If Title_Tab5_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Title_Tab5.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        End If

    End Sub

    '===========================================================



 
    Private Sub Button111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button111.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\cleanmaster.exe")
        End If
    End Sub

    Private Sub Button111_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button111.MouseEnter
        Grid111.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button111_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button111.MouseLeave
        Grid111.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button112.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\boostmaster.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\boostmaster.exe")
        End If
    End Sub

    Private Sub Button112_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button112.MouseEnter
        Grid112.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button112_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button112.MouseLeave
        Grid112.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button113.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\MenuMgr.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\MenuMgr.exe")
        End If
    End Sub

    Private Sub Button113_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button113.MouseEnter
        Grid113.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button113_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button113.MouseLeave
        Grid113.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button114_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button114.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\GHOST.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\GHOST.exe")
        End If
    End Sub

    Private Sub Button114_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button114.MouseEnter
        Grid114.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button114_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button114.MouseLeave
        Grid114.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button121.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\magicwifi.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\magicwifi.exe")
        End If
    End Sub

    Private Sub Button121_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button121.MouseEnter
        Grid121.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button121_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button121.MouseLeave
        Grid121.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button122.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\VPN\fg753p.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\VPN\fg753p.exe")
        End If
    End Sub

    Private Sub Button122_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button122.MouseEnter
        Grid122.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button122_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button122.MouseLeave
        Grid122.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button123_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button123.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\baiduyunguanjia.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\BaiduYunGuanjia\baiduyunguanjia.exe")
        End If
    End Sub

    Private Sub Button123_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button123.MouseEnter
        Grid123.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button123_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button123.MouseLeave
        Grid123.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button124_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button124.MouseDown
        If Dir("D:\Program Files\NEXUS\ToolBox\Everything.exe") = "" Then
            Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Tips_Version.exe")
        Else
            Fun_Shell("D:\Program Files\NEXUS\ToolBox\Everything.exe")
        End If
    End Sub

    Private Sub Button124_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button124.MouseEnter
        Grid124.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button124_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button124.MouseLeave
        Grid124.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button131_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button131.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\NEXUS_SettingCenter.exe")

    End Sub

    Private Sub Button131_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button131.MouseEnter
        Grid131.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button131_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button131.MouseLeave
        Grid131.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button132_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button132.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Tips\NEXUS_Help.exe")
    End Sub

    Private Sub Button132_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button132.MouseEnter
        Grid132.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button132_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button132.MouseLeave
        Grid132.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button133_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button133.MouseDown
        Fun_Shell("http://www.sojump.com/jq/3499620.aspx")
    End Sub

    Private Sub Button133_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button133.MouseEnter
        Grid133.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button133_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button133.MouseLeave
        Grid133.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub Button134_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button134.MouseDown
        Fun_Shell("http://i.youku.com/u/UNjE4MzEyOTYw")
    End Sub

    Private Sub Button134_MouseEnter(sender As Object, e As MouseEventArgs) Handles Button134.MouseEnter
        Grid134.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button134_MouseLeave(sender As Object, e As MouseEventArgs) Handles Button134.MouseLeave
        Grid134.Visibility = Windows.Visibility.Hidden
    End Sub

 
End Class

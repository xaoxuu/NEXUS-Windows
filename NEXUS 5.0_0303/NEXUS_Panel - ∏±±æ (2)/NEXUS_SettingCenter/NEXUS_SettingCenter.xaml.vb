Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized


        Grid_Goto.Visibility = Windows.Visibility.Hidden
        If Dir("D:\Program Files\NEXUS\Temp\Startup\魔枢后台.lnk") = "" Then
            按钮_后台关.Visibility = Windows.Visibility.Visible
            按钮_后台开.Visibility = Windows.Visibility.Hidden
        Else
            按钮_后台关.Visibility = Windows.Visibility.Hidden
            按钮_后台开.Visibility = Windows.Visibility.Visible
        End If
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

    Private Sub NEXUS_SettingCenter_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_SettingCenter.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible
        ' Fun_Color("1")

    End Sub

    Private Sub NEXUS_SettingCenter_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_SettingCenter.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

        'Fun_Color("0")
    End Sub

    Private Sub Background_Title_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Background_Title.MouseLeftButtonDown
        NEXUS_SettingCenter.Opacity = 0.85
        NEXUS_SettingCenter.DragMove()
        NEXUS_SettingCenter.Opacity = 1
    End Sub


    '=====================================标题按钮====================================
    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("反馈")
    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub




    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        NEXUS_SettingCenter.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))

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
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))

    End Sub
    Private Sub Grid_TitleButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles Grid_TitleButton.MouseLeave

        Fun_TitleTips("0")
    End Sub



    Private Sub ButtonB0_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB0.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_Panel.exe")

    End Sub

    Private Sub ButtonB1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB1.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_AppCenter.exe")

    End Sub

    Private Sub ButtonB2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB2.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_MediaCenter.exe")

    End Sub

    Private Sub ButtonB3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB3.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_DataCenter.exe")

    End Sub

    Private Sub ButtonB4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB4.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_ToolBox.exe")

    End Sub

    Private Sub ButtonB5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB5.MouseDown
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")

    End Sub

    Private Sub ButtonB6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB6.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Window.Panel\NEXUS_SettingCenter.exe")

    End Sub

    Private Sub Button_Goto_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Goto.MouseDown
        If Grid_Goto.Visibility = Windows.Visibility.Hidden Then
            Grid_Goto.Visibility = Windows.Visibility.Visible
        Else
            Grid_Goto.Visibility = Windows.Visibility.Hidden
        End If
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

      
    End Sub


End Class

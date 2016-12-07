Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_AppCenter_Open.vbs")
        Fun_Shell("C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_Panel_Close.vbs")
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

    Private Sub NEXUS_AppCenter_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_AppCenter.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible
        ' Fun_Color("1")

    End Sub

    Private Sub NEXUS_AppCenter_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_AppCenter.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

        'Fun_Color("0")
    End Sub

    Private Sub Background_Title_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Background_Title.MouseLeftButtonDown
        NEXUS_AppCenter.Opacity = 0.85
        NEXUS_AppCenter.DragMove()
        NEXUS_AppCenter.Opacity = 1
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
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(255, 236, 179))
    End Sub




    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        NEXUS_AppCenter.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 236, 179))

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
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 236, 179))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 236, 179))

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
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")

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
        Fun_Shell("C:\Program Files\NEXUS\Window.Expand\NEXUS_Expand_SoftwareAssistant.exe")

    End Sub

  
    Private Sub Button12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button12.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Expand\NEXUS_Expand_SoftwareAssistant.exe")

    End Sub

  
    Private Sub Button13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button13.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Expand\NEXUS_Expand_SoftwareAssistant.exe")

    End Sub
    Private Sub Button14_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button14.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Expand\NEXUS_Expand_GREAssistant.exe")

    End Sub
    Private Sub Button15_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button15.MouseDown
        Fun_Shell("C:\Program Files\NEXUS\Window.Expand\NEXUS_Expand_XLauncher.exe")

    End Sub


    Private Sub Button21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button21.MouseDown

    End Sub

 
    Private Sub Button22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button22.MouseDown

    End Sub

    Private Sub Button23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button23.MouseDown

    End Sub

    Private Sub Button24_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button24.MouseDown

    End Sub


    Private Sub Button25_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button25.MouseDown

    End Sub

  
    Private Sub Button26_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button26.MouseDown

    End Sub

    Private Sub Button27_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button27.MouseDown

    End Sub

   
    Private Sub Button28_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button28.MouseDown

    End Sub

   



    Private Sub Button31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button31.MouseDown

    End Sub

  

    Private Sub Button32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button32.MouseDown

    End Sub

  
    Private Sub Button33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button33.MouseDown

    End Sub

   
    Private Sub Button34_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button34.MouseDown

    End Sub

  






    Private Sub Button41_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button41.MouseDown

    End Sub

  
    Private Sub Button42_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button42.MouseDown

    End Sub

   
    Private Sub Button43_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button43.MouseDown

    End Sub



    Private Sub Button44_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button44.MouseDown

    End Sub

  

    Private Sub Button45_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button45.MouseDown

    End Sub

   

    Private Sub Button46_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button46.MouseDown

    End Sub

   
    Private Sub Button47_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button47.MouseDown

    End Sub

 
    Private Sub Button48_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button48.MouseDown

    End Sub

  






    Private Sub Button51_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button51.MouseDown

    End Sub

  
    Private Sub Button52_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button52.MouseDown

    End Sub

   

    Private Sub Button53_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button53.MouseDown

    End Sub

  

    Private Sub Button54_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button54.MouseDown

    End Sub

   
    Private Sub Button55_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button55.MouseDown

    End Sub

  
    Private Sub Button56_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button56.MouseDown

    End Sub

 







    Private Sub Button61_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button61.MouseDown

    End Sub

 
 
    Private Sub Button62_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button62.MouseDown

    End Sub

   
    Private Sub Button63_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button63.MouseDown

    End Sub

   
  
    Private Sub Button64_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button64.MouseDown

    End Sub

   

End Class

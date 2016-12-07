Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        Fun_Color("1")
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

    Private Sub NEXUS_Box_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden
        Cover.Visibility = Windows.Visibility.Hidden
        Background_Blue.Visibility = Windows.Visibility.Visible
        Fun_Color("1")
        
    End Sub

    Private Sub NEXUS_Box_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible
        Cover.Visibility = Windows.Visibility.Visible
        Background_Blue.Visibility = Windows.Visibility.Hidden

        'Fun_Color("0")
    End Sub

    Private Sub NEXUS_Box_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Box.MouseLeftButtonDown
        NEXUS_Box.Opacity = 0.85
        NEXUS_Box.DragMove()
        NEXUS_Box.Opacity = 1
    End Sub


    '=====================================标题按钮====================================
    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown
        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(0, 80, 239))
        Fun_TitleTips("反馈")
    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
    End Sub




    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        NEXUS_Box.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(0, 80, 239))
        Fun_TitleTips("缩小")

    End Sub

    Private Sub TitleButton2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
        TitleButton2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))

    End Sub



    Private Sub TitleButton3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton3.MouseDown
        End
    End Sub

    Private Sub TitleButton3_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseEnter
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(0, 80, 239))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(0, 80, 239))
        Fun_TitleTips("关闭")

    End Sub

    Private Sub TitleButton3_MouseLeave(sender As Object, e As MouseEventArgs) Handles TitleButton3.MouseLeave
        TitleButton3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        TitleButton3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))

    End Sub
    Private Sub Grid_TitleButton_MouseLeave(sender As Object, e As MouseEventArgs) Handles Grid_TitleButton.MouseLeave

        Fun_TitleTips("0")
    End Sub

   
  

    Private Sub Title1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title1.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Panel.exe" & Chr(34))

    End Sub

  
    Private Sub Button11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button11.MouseDown
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Panel.exe" & Chr(34))

    End Sub
End Class

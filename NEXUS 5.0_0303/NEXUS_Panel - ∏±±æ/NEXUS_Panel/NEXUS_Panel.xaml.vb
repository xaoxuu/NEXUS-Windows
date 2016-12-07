Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Fun_Clock()
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
  
    Private Sub Fun_Color(i As String)
        ButtonA1_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA1_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(254, 192, 8))
        ButtonA1_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(254, 192, 8))
        ButtonA2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA2_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(205, 220, 57))
        ButtonA2_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(205, 220, 57))
        ButtonA3_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA3_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 152, 0))
        ButtonA3_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 152, 0))
        ButtonA4_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA4_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(76, 175, 80))
        ButtonA4_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(76, 175, 80))
        ButtonA5_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA5_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 87, 34))
        ButtonA5_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 87, 34))
        ButtonA6_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ButtonA6_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(33, 150, 243))
        ButtonA6_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(33, 150, 243))
        ButtonB11.Opacity = 0
        ButtonB12.Opacity = 0
        ButtonB21.Opacity = 0
        ButtonB22.Opacity = 0
        ButtonB23.Opacity = 0
        ButtonB31.Opacity = 0
        ButtonB32.Opacity = 0
        ButtonB33.Opacity = 0
        ButtonB34.Opacity = 0
        If i = "0" Then

            ButtonA1_Rectangle_.Opacity = 0
            ButtonA2_Rectangle_.Opacity = 0
            ButtonA3_Rectangle_.Opacity = 0
            ButtonA4_Rectangle_.Opacity = 0
            ButtonA5_Rectangle_.Opacity = 0
            ButtonA6_Rectangle_.Opacity = 0

        ElseIf i = "1" Then

            ButtonA1_Rectangle_.Opacity = 1
            ButtonA2_Rectangle_.Opacity = 1
            ButtonA3_Rectangle_.Opacity = 1
            ButtonA4_Rectangle_.Opacity = 1
            ButtonA5_Rectangle_.Opacity = 1
            ButtonA6_Rectangle_.Opacity = 1

        ElseIf i = "a1" Then
            ButtonA1_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(254, 192, 8))
            ButtonA1_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA1_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = "a2" Then
            ButtonA2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(205, 220, 57))
            ButtonA2_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA2_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = "a3" Then
            ButtonA3_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 152, 0))
            ButtonA3_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA3_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = "a4" Then
            ButtonA4_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(76, 175, 80))
            ButtonA4_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA4_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = "a5" Then
            ButtonA5_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 87, 34))
            ButtonA5_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA5_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = "a6" Then
            ButtonA6_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(33, 150, 243))
            ButtonA6_TextBox_1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            ButtonA6_TextBox_2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        End If
    End Sub
    Private Sub Fun_Clock()
        Clock.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
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

    Private Sub NEXUS_Box_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible
       
    End Sub

    Private Sub NEXUS_Box_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Box.MouseLeave
        Background_Gray.Visibility = Windows.Visibility.Visible

        Background_Blue.Visibility = Windows.Visibility.Hidden

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
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        Fun_TitleTips("反馈")
    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave
        TitleButton1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub




    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown
        NEXUS_Box.WindowState = Windows.WindowState.Minimized
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

   
    Private Sub ButtonA1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA1.MouseDown

    End Sub

    Private Sub ButtonA1_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA1_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a1")
    End Sub

    Private Sub ButtonA1_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA1_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub

    Private Sub ButtonA2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA2.MouseDown

    End Sub

    Private Sub ButtonA2_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA2_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a2")
    End Sub
    Private Sub ButtonA2_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA2_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub

    Private Sub ButtonA3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA3.MouseDown

    End Sub

    Private Sub ButtonA3_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA3_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a3")
    End Sub
    Private Sub ButtonA3_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA3_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub

    Private Sub ButtonA4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA4.MouseDown

    End Sub

    Private Sub ButtonA4_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA4_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a4")
    End Sub
    Private Sub ButtonA4_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA4_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub
    Private Sub ButtonA5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA5.MouseDown

    End Sub

    Private Sub ButtonA5_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA5_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a5")
    End Sub
    Private Sub ButtonA5_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA5_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub
    Private Sub ButtonA6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonA6.MouseDown

    End Sub

    Private Sub ButtonA6_Ellipse_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonA6_Ellipse_.MouseEnter
        ' Fun_Color("1")
        Fun_Color("a6")
    End Sub
    Private Sub ButtonA6_Ellipse_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonA6_Ellipse_.MouseLeave
        Fun_Color("1")
    End Sub


    '===========================================================



    Private Sub ButtonB10_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB10.MouseDown

    End Sub

    Private Sub ButtonB10_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB10.MouseEnter

    End Sub

    Private Sub ButtonB10_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB10.MouseLeave

    End Sub
    Private Sub ButtonB11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB11.MouseDown

    End Sub

    Private Sub ButtonB11_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB11.MouseEnter
        ButtonB11.Opacity = 1
    End Sub

    Private Sub ButtonB11_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB11.MouseLeave
        ButtonB11.Opacity = 0
    End Sub

    Private Sub ButtonB12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB12.MouseDown

    End Sub

    Private Sub ButtonB12_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB12.MouseEnter
        ButtonB12.Opacity = 1
    End Sub

    Private Sub ButtonB12_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB12.MouseLeave
        ButtonB12.Opacity = 0
    End Sub

    Private Sub ButtonB20_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB20.MouseDown

    End Sub

    Private Sub ButtonB20_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB20.MouseEnter

    End Sub

    Private Sub ButtonB20_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB20.MouseLeave

    End Sub

    Private Sub ButtonB21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB21.MouseDown

    End Sub

    Private Sub ButtonB21_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB21.MouseEnter
        ButtonB21.Opacity = 1
    End Sub

    Private Sub ButtonB21_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB21.MouseLeave
        ButtonB21.Opacity = 0
    End Sub

    Private Sub ButtonB22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB22.MouseDown

    End Sub

    Private Sub ButtonB22_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB22.MouseEnter
        ButtonB22.Opacity = 1
    End Sub

    Private Sub ButtonB22_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB22.MouseLeave
        ButtonB22.Opacity = 0
    End Sub

    Private Sub ButtonB23_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB23.MouseDown

    End Sub

    Private Sub ButtonB23_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB23.MouseEnter
        ButtonB23.Opacity = 1
    End Sub

    Private Sub ButtonB23_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB23.MouseLeave
        ButtonB23.Opacity = 0
    End Sub

    Private Sub ButtonB30_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB30.MouseDown

    End Sub

    Private Sub ButtonB30_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB30.MouseEnter

    End Sub

    Private Sub ButtonB30_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB30.MouseLeave

    End Sub

    Private Sub ButtonB31_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB31.MouseDown

    End Sub

    Private Sub ButtonB31_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB31.MouseEnter
        ButtonB31.Opacity = 1
    End Sub

    Private Sub ButtonB31_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB31.MouseLeave
        ButtonB31.Opacity = 0
    End Sub

    Private Sub ButtonB32_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB32.MouseDown

    End Sub

    Private Sub ButtonB32_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB32.MouseEnter
        ButtonB32.Opacity = 1
    End Sub

    Private Sub ButtonB32_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB32.MouseLeave
        ButtonB32.Opacity = 0
    End Sub

    Private Sub ButtonB33_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB33.MouseDown

    End Sub

    Private Sub ButtonB33_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB33.MouseEnter
        ButtonB33.Opacity = 1
    End Sub

    Private Sub ButtonB33_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB33.MouseLeave
        ButtonB33.Opacity = 0
    End Sub

    Private Sub ButtonB34_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonB34.MouseDown

    End Sub

    Private Sub ButtonB34_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonB34.MouseEnter
        ButtonB34.Opacity = 1
    End Sub

    Private Sub ButtonB34_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonB34.MouseLeave
        ButtonB34.Opacity = 0
    End Sub


End Class

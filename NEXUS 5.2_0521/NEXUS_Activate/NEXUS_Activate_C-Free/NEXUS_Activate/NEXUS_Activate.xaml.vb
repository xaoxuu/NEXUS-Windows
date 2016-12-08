Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
      
        页脚.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub NEXUS_Activate_LocationChanged(sender As Object, e As EventArgs) Handles NEXUS_Activate.LocationChanged
        Roll()

    End Sub
    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Activate.Opacity = 0.85
        NEXUS_Activate.DragMove()
        NEXUS_Activate.Opacity = 1
    End Sub

    Private Sub NEXUS_Activate_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Activate.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden
        Cover.Visibility = Windows.Visibility.Hidden
        背景_蓝色.Visibility = Windows.Visibility.Visible

        '页脚.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub NEXUS_Activate_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Activate.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible
        Cover.Visibility = Windows.Visibility.Visible
        背景_蓝色.Visibility = Windows.Visibility.Hidden

        '页脚.Visibility = Windows.Visibility.Hidden

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
  
    Private Sub 标题按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮1.MouseDown
        WshShell.run("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 标题按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseEnter
        标题按钮1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(60, 153, 248))

    End Sub

    Private Sub 标题按钮1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseLeave
        标题按钮1_Rectangle_.Background = New SolidColorBrush(Color.FromRgb(180, 180, 180))
    End Sub




    Private Sub 标题按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮2.MouseDown
        NEXUS_Activate.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub 标题按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseEnter
        标题按钮2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(60, 153, 248))

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
    End Sub
    Private Sub 标题按钮3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseLeave
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))
    End Sub

    Private Sub 页脚按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮1.MouseDown

        End

    End Sub

    Private Sub 页脚按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseEnter
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseLeave
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub 页脚按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮2.MouseDown

    End Sub

    Private Sub 页脚按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseEnter
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseLeave
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub NEXUS_Activate_MouseMove(sender As Object, e As MouseEventArgs) Handles NEXUS_Activate.MouseMove
        Roll()
       
    End Sub
   
End Class

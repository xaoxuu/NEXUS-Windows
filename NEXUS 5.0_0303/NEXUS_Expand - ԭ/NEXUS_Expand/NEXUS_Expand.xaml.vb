Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim PageNumber As Integer

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        PageNumber = 1
        Pages()
        页脚.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub NEXUS_Expand_LocationChanged(sender As Object, e As EventArgs) Handles NEXUS_Expand.LocationChanged
        Roll()

    End Sub
    Private Sub NEXUS_Expand_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Expand.MouseLeftButtonDown
        NEXUS_Expand.Opacity = 0.85
        NEXUS_Expand.DragMove()
        NEXUS_Expand.Opacity = 1
    End Sub

    Private Sub NEXUS_Expand_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand.MouseEnter
        
        背景_灰色.Visibility = Windows.Visibility.Hidden
        Cover.Visibility = Windows.Visibility.Hidden
        背景_蓝色.Visibility = Windows.Visibility.Visible

        页脚.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub NEXUS_Expand_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible
        Cover.Visibility = Windows.Visibility.Visible
        背景_蓝色.Visibility = Windows.Visibility.Hidden

        页脚.Visibility = Windows.Visibility.Hidden

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
    Private Sub Pages()

        文本_服务条款.Visibility = Windows.Visibility.Hidden
        文本_正在安装.Visibility = Windows.Visibility.Hidden
        文本_安装完成.Visibility = Windows.Visibility.Hidden
        拓展按钮.Visibility = Windows.Visibility.Hidden

        If PageNumber = 1 Then
            页眉.Text = "精灵软件™服务条款"
            文本_服务条款.Visibility = Windows.Visibility.Visible
            拓展按钮.Visibility = Windows.Visibility.Visible
            页脚按钮1_TextBox_.Text = "拒绝"
            页脚按钮2_TextBox_.Text = "接受"
        ElseIf PageNumber = 2 Then
            页眉.Text = "正在安装，请稍候……"
            文本_正在安装.Visibility = Windows.Visibility.Visible
        ElseIf PageNumber = 3 Then
            页眉.Text = "安装已完成！"
            文本_安装完成.Visibility = Windows.Visibility.Visible
            拓展按钮.Visibility = Windows.Visibility.Visible
            页脚按钮1_TextBox_.Text = "否"
            页脚按钮2_TextBox_.Text = "是"
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
        NEXUS_Expand.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub 标题按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseEnter
        标题按钮2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(60, 153, 248))

    End Sub

    Private Sub 标题按钮2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseLeave
        标题按钮2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(180, 180, 180))

    End Sub
    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown
        If PageNumber = 2 Then
        Else
            End
        End If

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
        End
        If PageNumber = 1 Then
            PageNumber = 2
            Pages()
        ElseIf PageNumber = 3 Then

            If Dir("D:\Program Files\NEXUS\Temp\Expand\Shortcut.exe") = "" Then

            Else
                WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Temp\Expand\Shortcut.exe" & Chr(34))
                End
            End If
        End If

    End Sub

    Private Sub 页脚按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseEnter
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseLeave
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub NEXUS_Expand_MouseMove(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand.MouseMove
        Roll()
        If PageNumber = 2 Then
            If Dir("D:\Program Files\NEXUS\Temp\Expand\Shortcut.exe") = "" Then

            Else
                PageNumber = 3
                Pages()
            End If
        End If

    End Sub

   
End Class

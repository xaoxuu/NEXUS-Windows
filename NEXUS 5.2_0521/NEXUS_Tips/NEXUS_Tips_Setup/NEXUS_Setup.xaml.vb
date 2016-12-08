Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Pages, Install As String

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Pages = 0
        Install = 0
        Background_Gray.Visibility = Windows.Visibility.Visible

    End Sub
    Private Sub ProgressBar()

        If Pages = 1 Then

            ProgressBar61.Visibility = Windows.Visibility.Visible
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        ElseIf Pages = 2 Then

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Visible
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        ElseIf Pages = 3 Then

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Visible
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        ElseIf Pages = 4 Then

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Visible
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        ElseIf Pages = 5 Then

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Visible
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        ElseIf Pages = 6 Then

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Visible

        Else

            ProgressBar61.Visibility = Windows.Visibility.Hidden
            ProgressBar62.Visibility = Windows.Visibility.Hidden
            ProgressBar63.Visibility = Windows.Visibility.Hidden
            ProgressBar64.Visibility = Windows.Visibility.Hidden
            ProgressBar65.Visibility = Windows.Visibility.Hidden
            ProgressBar66.Visibility = Windows.Visibility.Hidden

        End If
    End Sub

    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Roll()
    End Sub
    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Roll()
        ProgressBar()
      
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Backstage.dll") = "" Then
        Else
            If Pages = 6 Then
                Contents.Text = "       安装已经完成，请尽情使用吧。"
                页脚按钮1_TextBox_.Text = "返回观看"
                页脚按钮2_TextBox_.Text = "开始体验"
                Titles.Background = New SolidColorBrush(Color.FromRgb(33, 150, 243))
                Titles.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                PageNumber.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))


                Ellipse0.Stroke = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse1.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse2.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse3.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse4.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse5.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Ellipse6.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))

                Contents.Foreground = New SolidColorBrush(Color.FromRgb(33, 150, 243))
                Logo0.Background = New SolidColorBrush(Color.FromRgb(33, 150, 243))
                拓展按钮_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
                拓展按钮_Rectangle_.Stroke = New SolidColorBrush(Color.FromRgb(187, 222, 251))
                页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(33, 150, 243))
                页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(33, 150, 243))

            End If
        End If

    End Sub
    Private Sub PageContent()



        If Pages = 0 Then
            PageNumber.Text = ""
            Titles.Text = "精灵软件     服务条款"
            Contents.Text = "       本软件可提供源代码仅供学习交流使用，不得用作商业用途。软件内置了一些作者认为好用的精品软件，这些组件并非都是作者开发。由于能力有限，软件只能安装在[D:\Program Files]目录下。点击【接受】开始安装。"
            页脚按钮1_TextBox_.Text = "稍等片刻"
            页脚按钮2_TextBox_.Text = "使用向导"
            If Install = 0 Then
                页脚按钮1_TextBox_.Text = "拒绝"
                页脚按钮2_TextBox_.Text = "接受"
            End If
        ElseIf Pages = 1 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       如果允许魔枢保持后台，则可以把鼠标放在屏幕左上角（此时鼠标变成手的形状），单击左键，即可呼出魔枢搜索。魔枢搜索可以使一部分常用关键词直达官网，还可以快速启动本地应用、打开系统功能等。"
            页脚按钮1_TextBox_.Text = "上一步"
            页脚按钮2_TextBox_.Text = "下一步"
        ElseIf Pages = 2 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       如果允许魔枢保持后台，则任务栏右下角有个白色的Logo，双击这个图标，可以打开魔枢主面板。右键点击这个图标，可以选择快捷启动、更新、反馈、退出后台等功能。"
            页脚按钮1_TextBox_.Text = "上一步"
            页脚按钮2_TextBox_.Text = "下一步"
        ElseIf Pages = 3 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       魔枢的后台原理是使一个功能简单、体积极小的小程序保持后台运行，主面板以及其他组件都关闭，当你点击屏幕左上角或者双击任务栏图标时，才打开相应程序。因此，占用的后台内存仅有10MB左右。"
            页脚按钮1_TextBox_.Text = "上一步"
            页脚按钮2_TextBox_.Text = "下一步"
        ElseIf Pages = 4 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       保持后台运行占用的资源很小，但是提供了很大的方便，例如你在其他窗口突然需要搜索网页，你只需要用鼠标点击左上角即可，如果你搜索的内容是[优酷][淘宝]等热门网站，还可以直达官网，非常便捷。"
            页脚按钮1_TextBox_.Text = "上一步"
            页脚按钮2_TextBox_.Text = "下一步"
        ElseIf Pages = 5 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       作者非常重视您的意见和建议，如果您在使用中有关于任何方面的想法，都可以向作者反馈。反馈方法很简单，任务栏图标右键选择反馈，或者点击魔枢主面板右上角的意见反馈图标。"
            页脚按钮1_TextBox_.Text = "上一步"
            页脚按钮2_TextBox_.Text = "下一步"
        ElseIf Pages = 6 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "精灵软件     安装向导"
            Contents.Text = "       安装过程尚未结束，请返回观看使用向导，等待安装结束后方可进行下一步。"
            页脚按钮1_TextBox_.Text = "返回观看"
            页脚按钮2_TextBox_.Text = "稍等片刻"
        End If
    End Sub

    Private Sub NEXUS_Setup_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Setup.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden
        Cover.Visibility = Windows.Visibility.Hidden
        Background_Blue.Visibility = Windows.Visibility.Visible
    End Sub


    Private Sub NEXUS_Setup_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Setup.MouseLeave
        Background_Blue.Visibility = Windows.Visibility.Hidden
        Background_Gray.Visibility = Windows.Visibility.Visible
        Cover.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub NEXUS_Setup_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Setup.MouseLeftButtonDown
        NEXUS_Setup.Opacity = 0.85
        NEXUS_Setup.DragMove()
        NEXUS_Setup.Opacity = 1
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


    Private Sub 页脚按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮1.MouseDown
        If Pages > 0 Then
            Pages = Pages - 1
            PageContent()
        End If
        If Pages = 0 And Install = 0 Then
            End
        End If

    End Sub

    Private Sub 页脚按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseEnter
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseLeave
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub 页脚按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮2.MouseDown
        If Install = 0 Then
            Install = 1
        End If
        If Pages < 6 Then
            Pages = Pages + 1
            PageContent()
        End If
        If 页脚按钮2_TextBox_.Text = "开始体验" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Main\NEXUS_Backstage.exe" & Chr(34))
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Main\NEXUS_Command.exe" & Chr(34))
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\NEXUS_Panel.exe" & Chr(34))
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Tips\NEXUS_Help.exe" & Chr(34))
            End
        End If
    End Sub

    Private Sub 页脚按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseEnter
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseLeave
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

  

End Class

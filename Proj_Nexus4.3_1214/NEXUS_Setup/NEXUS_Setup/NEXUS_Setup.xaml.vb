Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Pages, Install As String

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Pages = 0
        Install = 0
        Background_Yellow.Visibility = Windows.Visibility.Visible

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
        If Dir("D:\Program Files\NEXUS\Temp\Install\Setup.exe") = "" Then
            Contents.Text = "       安装程序丢失，请检查是否被杀毒软件删除，待还原后再点击接受开始安装。"
            Background_Red.Visibility = Windows.Visibility.Visible
            Background_Blue.Visibility = Windows.Visibility.Hidden

        Else
            PageContent()
            Background_Red.Visibility = Windows.Visibility.Hidden
            Background_Blue.Visibility = Windows.Visibility.Visible

        End If
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Backstage.dll") = "" Then
        Else
            If Pages = 6 Then
                Contents.Text = "       安装已经完成，请尽情使用吧。"
                ButtonCancels.Text = "返回观看"
                ButtonOKs.Text = "开始体验"
            End If
        End If

    End Sub
    Private Sub PageContent()

        

        If Pages = 0 Then
            PageNumber.Text = ""
            Titles.Text = "精灵软件     服务条款"
            Contents.Text = "       本软件可提供源代码仅供学习交流使用，不得用作商业用途。软件内置了一些作者认为好用的精品软件，这些组件并非都是作者开发。由于能力有限，软件只能安装在[D:\Program Files]目录下。点击【接受】开始安装。"
            ButtonCancels.Text = "稍等片刻"
            ButtonOKs.Text = "使用向导"
            If Install = 0 Then
                ButtonCancels.Text = "拒绝"
                ButtonOKs.Text = "接受"
            End If
        ElseIf Pages = 1 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       如果允许魔枢保持后台，则可以把鼠标放在屏幕左上角（此时鼠标变成手的形状），单击左键，即可呼出魔枢搜索。魔枢搜索可以使一部分常用关键词直达官网，还可以快速启动本地应用、打开系统功能等。"
            ButtonCancels.Text = "上一步"
            ButtonOKs.Text = "下一步"
        ElseIf Pages = 2 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       如果允许魔枢保持后台，则任务栏右下角有个白色的Logo，双击这个图标，可以打开魔枢主面板。右键点击这个图标，可以选择快捷启动、更新、反馈、退出后台等功能。"
            ButtonCancels.Text = "上一步"
            ButtonOKs.Text = "下一步"
        ElseIf Pages = 3 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       魔枢的后台原理是使一个功能简单、体积极小的小程序保持后台运行，主面板以及其他组件都关闭，当你点击屏幕左上角或者双击任务栏图标时，才打开相应程序。因此，占用的后台内存仅有10MB左右。"
            ButtonCancels.Text = "上一步"
            ButtonOKs.Text = "下一步"
        ElseIf Pages = 4 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       保持后台运行占用的资源很小，但是提供了很大的方便，例如你在其他窗口突然需要搜索网页，你只需要用鼠标点击左上角即可，如果你搜索的内容是[优酷][淘宝]等热门网站，还可以直达官网，非常便捷。"
            ButtonCancels.Text = "上一步"
            ButtonOKs.Text = "下一步"
        ElseIf Pages = 5 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       作者非常重视您的意见和建议，如果您在使用中有关于任何方面的想法，都可以向作者反馈。反馈方法很简单，任务栏图标右键选择反馈，或者点击魔枢主面板右边的意见反馈框。"
            ButtonCancels.Text = "上一步"
            ButtonOKs.Text = "下一步"
        ElseIf Pages = 6 Then
            PageNumber.Text = Pages + "/6"
            Titles.Text = "魔枢     向导"
            Contents.Text = "       安装过程尚未结束，请返回观看使用向导，等待安装结束后方可进行下一步。"
            ButtonCancels.Text = "返回观看"
            ButtonOKs.Text = "稍等片刻"
        End If
    End Sub

    Private Sub NEXUS_Setup_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Setup.MouseEnter
        Background_Yellow.Visibility = Windows.Visibility.Hidden
        Background_Blue.Visibility = Windows.Visibility.Visible
    End Sub


    Private Sub NEXUS_Setup_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Setup.MouseLeave
        Background_Blue.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub NEXUS_Setup_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles NEXUS_Setup.MouseLeftButtonDown
        NEXUS_Setup.Opacity = 0.75
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



    Private Sub ButtonCancels_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonCancels.MouseEnter
        ButtonCancel1.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub ButtonCancels_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonCancels.MouseDown

        If Pages > 0 Then
            Pages = Pages - 1
            PageContent()
        End If
        If Pages = 0 And Install = 0 Then
            End
        End If

    End Sub

    Private Sub ButtonCancels_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonCancels.MouseLeave
        ButtonCancel1.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub ButtonOKs_MouseEnter(sender As Object, e As MouseEventArgs) Handles ButtonOKs.MouseEnter
        ButtonOK1.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub ButtonOKs_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonOKs.MouseDown
        If Install = 0 Then
                Install = 1
        End If
        If Pages < 6 Then
            Pages = Pages + 1
            PageContent()
        End If
        If ButtonOKs.Text = "开始体验" Then
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Command.exe" & Chr(34))
            WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Bin\NEXUS_Box.exe" & Chr(34))
            End
        End If
    End Sub

    Private Sub ButtonOKs_MouseLeave(sender As Object, e As MouseEventArgs) Handles ButtonOKs.MouseLeave
        ButtonOK1.Visibility = Windows.Visibility.Hidden
    End Sub

End Class

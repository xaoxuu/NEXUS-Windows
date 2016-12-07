Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Games.dll") = "" Then
        Else
            MainTips.Text = "       找不到游戏，请创建该游戏的快捷方式，然后重命名为跟游戏管家里对应的这个游戏的名字一模一样之后，点击右键发送到【魔枢快捷启动】"
        End If
    End Sub

 
    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Tips_Error.Opacity = 0.85
        NEXUS_Tips_Error.DragMove()
        NEXUS_Tips_Error.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Error_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_Error.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Error_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_Error.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible

        背景_蓝色.Visibility = Windows.Visibility.Hidden


    End Sub
  
   
    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown

        End

    End Sub
    Private Sub 标题按钮3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseEnter
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub
    Private Sub 标题按钮3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseLeave
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub

    Private Sub Button_Plus_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button_Plus.MouseDown
        WshShell.run("http://www.sojump.com/m/3499620.aspx")
    End Sub
End Class

Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

        If Dir("D:\Program Files\NEXUS\ToolBox\Readme.txt") = "" Then
            页眉.Text = "正在安装"
            MainTips.Text = "正在安装拓展包，请稍等……"
        Else
            页眉.Text = "安装完成"
            MainTips.Text = "拓展包已安装完成！"
            按钮3.Visibility = Windows.Visibility.Visible
        End If
    End Sub
    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Dir("D:\Program Files\NEXUS\ToolBox\Readme.txt") = "" Then
            页眉.Text = "正在安装"
            MainTips.Text = "正在安装拓展包，请稍等……"
        Else
            页眉.Text = "安装完成"
            MainTips.Text = "拓展包已安装完成！"
            按钮3.Visibility = Windows.Visibility.Visible
        End If
    End Sub

    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        Tips_InstallExpand.Opacity = 0.8
        Tips_InstallExpand.DragMove()
        Tips_InstallExpand.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tips_InstallExpand.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tips_InstallExpand.MouseLeave

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
        标题按钮3_Rectangle_1.Fill = New SolidColorBrush(Color.FromRgb(255, 204, 188))
        标题按钮3_Rectangle_2.Fill = New SolidColorBrush(Color.FromRgb(255, 204, 188))
    End Sub

 
  

  
   
End Class

Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
       
    End Sub
    Private Sub 子函数_定时关机(i As String)
        Dim shutdown, output, tin, min, hour, ts As String
        WshShell.run("shutdown -a", vbHide)
        tin = 文本框_定时关机.Text
        If i = "执行" Then
            If tin = "" Then
                WshShell.run("shutdown -s -t 0", vbHide)
            End If
            If tin < 10 Then
                If tin = Int(tin) Then
                    hour = tin
                    output = "电脑将在" + hour + "小时后关闭。"
                Else
                    hour = Int(tin)
                    min = 60 * tin - 60 * hour
                    output = "电脑将在" + hour + "小时" + min + "分钟后关闭。"
                End If
                ts = 3600 * tin
                shutdown = "shutdown -s  -t  " + ts
            ElseIf tin < 60 Then
                min = tin
                output = "电脑将在" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s  -t  " + ts
            Else
                min = tin
                hour = Int(tin \ 60)
                min = min - 60 * hour
                output = "电脑将在" + hour + "小时" + min + "分钟后关闭。"
                ts = 60 * tin
                shutdown = "shutdown -s  -t  " + ts
            End If
            WshShell.run(shutdown, vbHide)

        ElseIf i = "取消" Then
            WshShell.run("shutdown -a ", vbHide)

        End If
    End Sub
   
    Private Sub 文本框_定时关机_Keyup(sender As Object, e As KeyEventArgs) Handles 文本框_定时关机.KeyUp
        Dim tin As String
        tin = 文本框_定时关机.Text
        If tin = "" Then
            文本框_定时关机提示.Text = "电脑将在                       多久后关机"
        Else
            If tin > 0 Then
                If tin < 10 Then
                    文本框_定时关机提示.Text = "电脑将在                       小时后关机"
                ElseIf tin >= 10 Then
                    文本框_定时关机提示.Text = "电脑将在                       分钟后关机"
                End If
            End If
        End If
    End Sub
   
    Private Sub Button_确定_Click(sender As Object, e As RoutedEventArgs) Handles Button_确定.Click
        子函数_定时关机("执行")
        开关_开.Visibility = Windows.Visibility.Visible
        开关_关.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 开关_关_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 开关_关.MouseDown
        子函数_定时关机("执行")
        开关_开.Visibility = Windows.Visibility.Visible
        开关_关.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 开关_开_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 开关_开.MouseDown
        子函数_定时关机("取消")
        开关_开.Visibility = Windows.Visibility.Hidden
        开关_关.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Tips_ShutdownTimer.Opacity = 0.85
        NEXUS_Tips_ShutdownTimer.DragMove()
        NEXUS_Tips_ShutdownTimer.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_ShutdownTimer.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_ShutdownTimer.MouseLeave

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
        WshShell.run("http://www.sojump.com/jq/3499620.aspx")
    End Sub
End Class

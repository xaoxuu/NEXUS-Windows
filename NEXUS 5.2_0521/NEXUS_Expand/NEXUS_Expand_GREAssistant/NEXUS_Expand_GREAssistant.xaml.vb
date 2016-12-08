Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Tab(1)

        拓展区.Visibility = Windows.Visibility.Collapsed
      
    End Sub
 
    Private Sub Tab(i As UInteger)

        Title_Tab1_Ellipse_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Ellipse_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Ellipse_.Visibility = Windows.Visibility.Hidden

        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))

        Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Hidden

        Tab_1.Visibility = Windows.Visibility.Hidden
        Tab_2.Visibility = Windows.Visibility.Hidden
        Tab_3.Visibility = Windows.Visibility.Hidden

        拓展区.Visibility = Windows.Visibility.Collapsed

        If i = 1 Then
            Title_Tab1_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab1_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_1.Visibility = Windows.Visibility.Visible

        ElseIf i = 2 Then
            Title_Tab2_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab2_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_2.Visibility = Windows.Visibility.Visible

        ElseIf i = 3 Then
            Title_Tab3_Ellipse_.Visibility = Windows.Visibility.Visible
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Title_Tab3_Rectangle_.Visibility = Windows.Visibility.Visible
            Tab_3.Visibility = Windows.Visibility.Visible


        Else

        End If



    End Sub



    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Expand_GREAssistant.Opacity = 0.85
        NEXUS_Expand_GREAssistant.DragMove()
        NEXUS_Expand_GREAssistant.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_GREAssistant.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible


    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Expand_GREAssistant.MouseLeave

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





    Private Sub 上半部_MouseEnter(sender As Object, e As MouseEventArgs) Handles 上半部.MouseEnter
        拓展区.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 上半部_MouseLeave(sender As Object, e As MouseEventArgs) Handles 上半部.MouseLeave
        拓展区.Visibility = Windows.Visibility.Collapsed
    End Sub




    Private Sub Title_Tab1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab1.MouseDown
        Tab(1)
    End Sub
    Private Sub Title_Tab1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseEnter
        Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub
    Private Sub Title_Tab1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab1.MouseLeave
        If Tab_1.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab1.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If
    End Sub

    Private Sub Title_Tab2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab2.MouseDown
        Tab(2)
    End Sub
    Private Sub Title_Tab2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseEnter
        Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab2.MouseLeave
        If Tab_2.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab2.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If
    End Sub
    Private Sub Title_Tab3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Title_Tab3.MouseDown
        Tab(3)
    End Sub
    Private Sub Title_Tab3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseEnter
        Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Title_Tab3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Title_Tab3.MouseLeave
        If Tab_3.Visibility = Windows.Visibility.Visible Then
        Else
            Title_Tab3.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
        End If
    End Sub
    Private Sub 反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 反馈.MouseDown
       
        WshShell.run(Chr(34) & "http://www.sojump.com/jq/3499620.aspx" & Chr(34))
    End Sub

    Private Sub 反馈_MouseEnter(sender As Object, e As MouseEventArgs) Handles 反馈.MouseEnter
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub 反馈_MouseLeave(sender As Object, e As MouseEventArgs) Handles 反馈.MouseLeave
        反馈.Foreground = New SolidColorBrush(Color.FromRgb(187, 222, 251))
    End Sub

   
   

   
End Class

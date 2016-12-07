Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
      
        页脚.Visibility = Windows.Visibility.Hidden
    End Sub

 
    Private Sub 标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 标题.MouseLeftButtonDown
        NEXUS_Tips_Version.Opacity = 0.85
        NEXUS_Tips_Version.DragMove()
        NEXUS_Tips_Version.Opacity = 1
    End Sub

    Private Sub NEXUS_Tips_Version_MouseEnter(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_Version.MouseEnter

        背景_灰色.Visibility = Windows.Visibility.Hidden

        背景_蓝色.Visibility = Windows.Visibility.Visible

      
    End Sub

    Private Sub NEXUS_Tips_Version_MouseLeave(sender As Object, e As MouseEventArgs) Handles NEXUS_Tips_Version.MouseLeave

        背景_灰色.Visibility = Windows.Visibility.Visible

        背景_蓝色.Visibility = Windows.Visibility.Hidden

     
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

  
End Class

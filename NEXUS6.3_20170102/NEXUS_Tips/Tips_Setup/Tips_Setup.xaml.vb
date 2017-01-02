Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim ok As UInteger

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        ok = 0
        Background_Gray.Visibility = Windows.Visibility.Visible
    End Sub
 
    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
      
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Server.dll") = "" Then
        Else
            ok = 1
        End If

    End Sub
 
    Private Sub Tips_Setup_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tips_Setup.MouseEnter
        Background_Gray.Visibility = Windows.Visibility.Hidden

        Background_Blue.Visibility = Windows.Visibility.Visible
    End Sub


    Private Sub Tips_Setup_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tips_Setup.MouseLeave
        Background_Blue.Visibility = Windows.Visibility.Hidden
        Background_Gray.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub Tips_Setup_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Tips_Setup.MouseLeftButtonDown
        Tips_Setup.Opacity = 0.8
        Tips_Setup.DragMove()
        Tips_Setup.Opacity = 1
    End Sub
   

    Private Sub 页脚按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮1.MouseDown
        WshShell.run("C:\Windows\Uninstall.vbs")
            End
    
    End Sub

    Private Sub 页脚按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseEnter
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮1.MouseLeave
        页脚按钮1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

    Private Sub 页脚按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 页脚按钮2.MouseDown
      
                WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Expand\NEXUS_Instructions.exe" & Chr(34))
         
        End
    End Sub

    Private Sub 页脚按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseEnter
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(60, 153, 248))
    End Sub

    Private Sub 页脚按钮2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 页脚按钮2.MouseLeave
        页脚按钮2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(120, 120, 120))
    End Sub

  

End Class

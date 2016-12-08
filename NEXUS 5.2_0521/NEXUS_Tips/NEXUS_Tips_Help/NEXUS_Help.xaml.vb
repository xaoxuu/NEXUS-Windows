Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Step2.Visibility = Windows.Visibility.Collapsed
        Step3.Visibility = Windows.Visibility.Collapsed
        按钮_后台开.Visibility = Windows.Visibility.Collapsed
    End Sub
  

    Private Sub Button1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button1.MouseDown
        Step1.Visibility = Windows.Visibility.Collapsed
        Step2.Visibility = Windows.Visibility.Visible
        Step3.Visibility = Windows.Visibility.Collapsed
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button2.MouseDown
        Step1.Visibility = Windows.Visibility.Collapsed
        Step2.Visibility = Windows.Visibility.Collapsed
        Step3.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Button3.MouseDown
        End
    End Sub


 
    Private Sub 按钮_后台_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_后台.MouseDown
        If 按钮_后台关.Visibility = Windows.Visibility.Visible Then
            按钮_后台关.Visibility = Windows.Visibility.Hidden
            按钮_后台开.Visibility = Windows.Visibility.Visible
            WshShell.run("C:\Windows\StartupOK.vbs")
        Else
            按钮_后台关.Visibility = Windows.Visibility.Visible
            按钮_后台开.Visibility = Windows.Visibility.Hidden
            WshShell.run("C:\Windows\StartupCancel.vbs")
        End If
    End Sub

End Class

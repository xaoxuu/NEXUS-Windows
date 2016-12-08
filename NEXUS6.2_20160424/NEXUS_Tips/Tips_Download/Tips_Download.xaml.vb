Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
       
    End Sub

 
    Private Sub ButtonOK_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonOK.MouseDown


        WshShell.run("http://url.cn/Zw0oSk")
        End
    End Sub

    Private Sub ButtonCancel_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonCancel.MouseDown
        End
    End Sub
End Class

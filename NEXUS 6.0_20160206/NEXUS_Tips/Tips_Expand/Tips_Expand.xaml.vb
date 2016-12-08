Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        If Dir("D:\Program Files\NEXUS\ToolBox\Readme.txt") = "" Then '没有Readme

            MainTips.Text = "您没有安装拓展包，不包含此功能，现在要安装拓展包吗？"
            ButtonOK.Text = "安装"
            ButtonCancel.Text = "不安装"
        Else '有Readme
            MainTips.Text = "您已经安装了拓展包但仍旧缺少这个组件，请检查是否被杀毒软件误删。"
            ButtonOK.Text = "重新安装"
            ButtonCancel.Text = "关闭"
        End If
    End Sub

 
    Private Sub ButtonOK_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonOK.MouseDown


        WshShell.run("http://url.cn/bXvJ9F")
        End
    End Sub

    Private Sub ButtonCancel_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles ButtonCancel.MouseDown
        End
    End Sub
End Class

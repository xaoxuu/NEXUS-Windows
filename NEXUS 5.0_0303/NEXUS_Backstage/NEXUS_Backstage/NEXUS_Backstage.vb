Public Class NEXUS_Backstage
    Dim Inputs, Codes, Hidei As String
    Dim WshShell = CreateObject("WScript.Shell")
   
    Private Sub 托盘图标_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles 托盘图标.MouseDoubleClick
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Panel.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\NEXUS_Panel.exe" & Chr(34))
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_Panel_Open.vbs" & Chr(34))
        Else
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_Panel_Close.vbs" & Chr(34))
        End If
       
    End Sub
    Private Sub 魔枢搜索_Click(sender As Object, e As EventArgs) Handles 魔枢搜索.Click
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Main\NEXUS_Command.exe" & Chr(34))
    End Sub
    Private Sub 魔枢主页_Click(sender As Object, e As EventArgs) Handles 魔枢主页.Click, 魔枢主页.Click
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Panel.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\NEXUS_Panel.exe" & Chr(34))
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_Panel_Open.vbs" & Chr(34))
        Else
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Panel\VBSSource\NEXUS_Panel_Close.vbs" & Chr(34))
        End If
    End Sub
    Private Sub 立即更新_Click(sender As Object, e As EventArgs) Handles 立即更新.Click
        WshShell.run("http://pan.baidu.com/s/12IKJ8#path=%252F%25E5%25AE%25A2%25E6%2588%25B7%25E7%25AB%25AF")
    End Sub
    Private Sub 意见反馈_Click(sender As Object, e As EventArgs) Handles 意见反馈.Click
        WshShell.run("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 退出后台_Click(sender As Object, e As EventArgs) Handles 退出后台.Click
        End
    End Sub


    Private Sub 快捷启动_Click(sender As Object, e As EventArgs) Handles 快捷启动.Click
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\" & Chr(34))
    End Sub

    Private Sub 热键_Click(sender As Object, e As EventArgs) Handles 热键.Click
        WshShell.run(Chr(34) & "C:\Program Files\NEXUS\Window.Main\NEXUS_Command.exe" & Chr(34))
    End Sub
End Class

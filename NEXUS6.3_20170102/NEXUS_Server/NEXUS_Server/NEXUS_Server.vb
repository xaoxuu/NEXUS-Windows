Public Class NEXUS_Server
    Dim Inputs, Codes, Hidei As String
    Dim WshShell = CreateObject("WScript.Shell")

    Private Sub 托盘图标_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles 托盘图标.MouseDoubleClick
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Runing.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\NEXUS.exe" & Chr(34))
        Else
        End If

    End Sub
    Private Sub 魔枢搜索_Click(sender As Object, e As EventArgs) Handles 魔枢搜索.Click
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Search_Runing.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\NEXUS_Search.exe" & Chr(34))
        Else
        End If
    End Sub
    Private Sub 打开魔枢_Click(sender As Object, e As EventArgs) Handles 打开魔枢.Click
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Runing.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\NEXUS.exe" & Chr(34))
        Else
        End If
    End Sub
    Private Sub 立即更新_Click(sender As Object, e As EventArgs) Handles 立即更新.Click
        WshShell.run("https://TitanStudio.github.io/NEXUS")
    End Sub
    Private Sub 意见反馈_Click(sender As Object, e As EventArgs) Handles 意见反馈.Click
        WshShell.run("https://github.com/TitanStudio/NEXUS/issues/1")
    End Sub
    Private Sub 退出后台_Click(sender As Object, e As EventArgs) Handles 退出后台.Click
        End
    End Sub


    Private Sub 快捷启动_Click(sender As Object, e As EventArgs) Handles 快捷启动.Click
        WshShell.run(Chr(34) & "D:\Program Files\NEXUS\Launcher\" & Chr(34))
    End Sub

    Private Sub 热键_Click(sender As Object, e As EventArgs) Handles 热键.Click
        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Search_Runing.dll") = "" Then
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\NEXUS_Search.exe" & Chr(34))
        Else
            WshShell.run(Chr(34) & "C:\Program Files\NEXUS\VBS\NEXUS_Search_Close.vbs" & Chr(34))
        End If
    End Sub



End Class

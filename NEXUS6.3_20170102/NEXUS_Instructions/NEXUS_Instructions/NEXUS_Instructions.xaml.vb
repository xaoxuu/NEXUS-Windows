Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim Tips, TipsCodes, Titlecodes As String
    Dim r, c As UInteger

    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed



        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Server.dll") = "" Then '初次安装
            If Dir("C:\Program Files\NEXUS\NEXUS.exe") = "" Then '
            Else '
                WshShell.Run(Chr(34) & "C:\Program Files\NEXUS\NEXUS.exe" & Chr(34))
            End If

            If Dir("C:\Program Files\NEXUS\VBS\NEXUS_Server_Open.vbs") = "" Then '
            Else '
                WshShell.Run(Chr(34) & "C:\Program Files\NEXUS\VBS\NEXUS_Server_Open.vbs" & Chr(34))
            End If
        Else '不是初次安装

        End If
       
    End Sub

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        r = 1
        c = 1
        Tab()
        Tab_r4.Visibility = Windows.Visibility.Collapsed
        Tab_r5.Visibility = Windows.Visibility.Collapsed



        If Dir("D:\Program Files\NEXUS\Temp\NEXUS_Server.dll") = "" Then '初次安装
           
            If Dir("C:\Program Files\NEXUS\NEXUS_Search.exe") = "" Then '
            Else '
                WshShell.Run(Chr(34) & "C:\Program Files\NEXUS\NEXUS_Search.exe" & Chr(34))
            End If
            If Dir("C:\Program Files\NEXUS\NEXUS_Server.exe") = "" Then '
            Else '
                WshShell.Run(Chr(34) & "C:\Program Files\NEXUS\NEXUS_Server.exe" & Chr(34))
            End If

           
        Else '不是初次安装

        End If

       
      
    End Sub
   
    '=====================================子函数====================================
    Private Sub Fun_Shell(i As String)
        WshShell.run(Chr(34) & i & Chr(34))
    End Sub
    Private Sub Fun_Expand(i As String)


    End Sub
 

    Private Sub Tab()

        If r = 2 Then
            Tab_c1_text_.Text = "官方网站"
            Tab_c2_text_.Text = "作者主页"
            Tab_c3_text_.Text = "资源中心"

            Tab_c1_text_.Visibility = Windows.Visibility.Visible
            Tab_c2_text_.Visibility = Windows.Visibility.Visible
            Tab_c3_text_.Visibility = Windows.Visibility.Visible
            Tab_c4_text_.Visibility = Windows.Visibility.Collapsed
            Tab_c5_text_.Visibility = Windows.Visibility.Collapsed
        ElseIf r = 3 Then



            Tab_c1_text_.Text = "问卷星"
            Tab_c2_text_.Text = "其他方式"

            Tab_c3_text_.Visibility = Windows.Visibility.Collapsed
            Tab_c4_text_.Visibility = Windows.Visibility.Collapsed
            Tab_c5_text_.Visibility = Windows.Visibility.Collapsed

        Else


            Tab_c1_text_.Text = "软件概述"
            Tab_c2_text_.Text = "搜索框"
            Tab_c3_text_.Text = "主程序"
            Tab_c4_text_.Text = "保持后台"
            Tab_c5_text_.Text = "其他功能"

            Tab_c1_text_.Visibility = Windows.Visibility.Visible
            Tab_c2_text_.Visibility = Windows.Visibility.Visible
            Tab_c3_text_.Visibility = Windows.Visibility.Visible
            Tab_c4_text_.Visibility = Windows.Visibility.Visible
            Tab_c5_text_.Visibility = Windows.Visibility.Visible

        End If
        Tab_r1_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_r2_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_r3_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_r4_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_r5_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))
        Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))



        Tab_r1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_r2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_r3_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_r4_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_r5_Rectangle_.Visibility = Windows.Visibility.Hidden

        Tab_c1_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_c2_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_c3_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_c4_Rectangle_.Visibility = Windows.Visibility.Hidden
        Tab_c5_Rectangle_.Visibility = Windows.Visibility.Hidden


        Tab_11.Visibility = Windows.Visibility.Hidden
        Tab_12.Visibility = Windows.Visibility.Hidden
        Tab_13.Visibility = Windows.Visibility.Hidden
        Tab_14.Visibility = Windows.Visibility.Hidden
        Tab_15.Visibility = Windows.Visibility.Hidden
        Tab_21.Visibility = Windows.Visibility.Hidden
        Tab_22.Visibility = Windows.Visibility.Hidden
        Tab_23.Visibility = Windows.Visibility.Hidden
        Tab_24.Visibility = Windows.Visibility.Hidden
        Tab_25.Visibility = Windows.Visibility.Hidden
        Tab_31.Visibility = Windows.Visibility.Hidden
        Tab_32.Visibility = Windows.Visibility.Hidden
        Tab_33.Visibility = Windows.Visibility.Hidden
        Tab_34.Visibility = Windows.Visibility.Hidden
        Tab_35.Visibility = Windows.Visibility.Hidden
        Tab_41.Visibility = Windows.Visibility.Hidden
        Tab_42.Visibility = Windows.Visibility.Hidden
        Tab_43.Visibility = Windows.Visibility.Hidden
        Tab_44.Visibility = Windows.Visibility.Hidden
        Tab_45.Visibility = Windows.Visibility.Hidden
        Tab_51.Visibility = Windows.Visibility.Hidden
        Tab_52.Visibility = Windows.Visibility.Hidden
        Tab_53.Visibility = Windows.Visibility.Hidden
        Tab_54.Visibility = Windows.Visibility.Hidden
        Tab_55.Visibility = Windows.Visibility.Hidden

        If r = 2 Then
            Tab_r2_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Tab_r2_Rectangle_.Visibility = Windows.Visibility.Visible
            If c = 2 Then
                Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c2_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_22.Visibility = Windows.Visibility.Visible
            ElseIf c = 3 Then
                Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c3_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_23.Visibility = Windows.Visibility.Visible
            ElseIf c = 4 Then
                Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c4_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_24.Visibility = Windows.Visibility.Visible
            ElseIf c = 5 Then
                Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c5_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_25.Visibility = Windows.Visibility.Visible
            Else
                Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c1_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_21.Visibility = Windows.Visibility.Visible
            End If
            '-----------------------------
        ElseIf r = 3 Then
            Tab_r3_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Tab_r3_Rectangle_.Visibility = Windows.Visibility.Visible
            If c = 2 Then
                Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c2_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_32.Visibility = Windows.Visibility.Visible
            ElseIf c = 3 Then
                Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c3_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_33.Visibility = Windows.Visibility.Visible
            ElseIf c = 4 Then
                Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c4_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_34.Visibility = Windows.Visibility.Visible
            ElseIf c = 5 Then
                Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c5_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_35.Visibility = Windows.Visibility.Visible
            Else
                Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c1_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_31.Visibility = Windows.Visibility.Visible
            End If
            '-----------------------------

        ElseIf r = 4 Then
            Tab_r4_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Tab_r4_Rectangle_.Visibility = Windows.Visibility.Visible
            If c = 2 Then
                Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c2_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_42.Visibility = Windows.Visibility.Visible
            ElseIf c = 3 Then
                Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c3_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_43.Visibility = Windows.Visibility.Visible
            ElseIf c = 4 Then
                Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c4_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_44.Visibility = Windows.Visibility.Visible
            ElseIf c = 5 Then
                Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c5_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_45.Visibility = Windows.Visibility.Visible
            Else
                Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c1_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_41.Visibility = Windows.Visibility.Visible
            End If
            '-----------------------------

        ElseIf r = 5 Then
            Tab_r5_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Tab_r5_Rectangle_.Visibility = Windows.Visibility.Visible
            If c = 2 Then
                Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c2_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_52.Visibility = Windows.Visibility.Visible
            ElseIf c = 3 Then
                Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c3_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_53.Visibility = Windows.Visibility.Visible
            ElseIf c = 4 Then
                Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c4_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_54.Visibility = Windows.Visibility.Visible
            ElseIf c = 5 Then
                Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c5_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_55.Visibility = Windows.Visibility.Visible
            Else
                Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c1_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_51.Visibility = Windows.Visibility.Visible
            End If
            '-----------------------------
        Else
            Tab_r1_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            Tab_r1_Rectangle_.Visibility = Windows.Visibility.Visible
            If c = 2 Then
                Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c2_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_12.Visibility = Windows.Visibility.Visible
            ElseIf c = 3 Then
                Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c3_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_13.Visibility = Windows.Visibility.Visible
            ElseIf c = 4 Then
                Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c4_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_14.Visibility = Windows.Visibility.Visible
            ElseIf c = 5 Then
                Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c5_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_15.Visibility = Windows.Visibility.Visible
            Else
                Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))
                Tab_c1_Rectangle_.Visibility = Windows.Visibility.Visible
                Tab_11.Visibility = Windows.Visibility.Visible
            End If

        End If


    End Sub



    '=====================================窗口移动拖拽====================================

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub



    '=====================================标题按钮====================================



    Private Sub TitleButton1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton1.MouseDown

    End Sub
    Private Sub TitleButton1_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseEnter
        TitleButton1_Rectangle_.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub TitleButton1_MouseLsseave(sender As Object, e As MouseEventArgs) Handles TitleButton1.MouseLeave

        TitleButton1_Rectangle_.Visibility = Windows.Visibility.Hidden

    End Sub



    Private Sub TitleButton2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton2.MouseDown

        End

    End Sub

    Private Sub TitleButton2_MouseEnter(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseEnter
       
    End Sub

    Private Sub TitleButton2_MouseLeave(sender As Object, e As MouseEventArgs) Handles TitleButton2.MouseLeave
       
    End Sub




    Private Sub TitleButton3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TitleButton3.MouseDown
        If Titletext.Visibility = Windows.Visibility.Visible Then
            Fun_Expand(0)
        Else
            Fun_Expand(1)

        End If
    End Sub





    '=====================================标题分类====================================
    Private Sub Tab_r1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_r1.MouseDown
        r = 1
        c = 1
        Tab()
    End Sub
    Private Sub Tab_r1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_r1.MouseEnter
        Tab_r1_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

    End Sub
    Private Sub Tab_r1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_r1.MouseLeave
        If Tab_r1_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_r1_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_r2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_r2.MouseDown
        r = 2
        c = 1
        Tab()
    End Sub
    Private Sub Tab_r2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_r2.MouseEnter
        Tab_r2_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Tab_r2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_r2.MouseLeave
        If Tab_r2_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_r2_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_r3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_r3.MouseDown
        r = 3
        c = 1
        Tab()

    End Sub

    Private Sub Tab_r3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_r3.MouseEnter
        Tab_r3_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Tab_r3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_r3.MouseLeave
        If Tab_r3_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_r3_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_r4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_r4.MouseDown
        r = 4
        c = 1
        Tab()

    End Sub

    Private Sub Tab_r4_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_r4.MouseEnter
        Tab_r4_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Tab_r4_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_r4.MouseLeave
        If Tab_r4_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_r4_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_r5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_r5.MouseDown
        r = 5
        c = 1
        Tab()

    End Sub

    Private Sub Tab_r5_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_r5.MouseEnter
        Tab_r5_text_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub

    Private Sub Tab_r5_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_r5.MouseLeave
        If Tab_r5_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_r5_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub




    Private Sub Tab_c1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_c1.MouseDown
        c = 1
        Tab()
    End Sub
    Private Sub Tab_c1_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_c1.MouseEnter
        Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))

    End Sub
    Private Sub Tab_c1_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_c1.MouseLeave
        If Tab_c1_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_c1_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_c2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_c2.MouseDown
        c = 2
        Tab()
    End Sub
    Private Sub Tab_c2_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_c2.MouseEnter
        Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))

    End Sub
    Private Sub Tab_c2_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_c2.MouseLeave
        If Tab_c2_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_c2_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub


    Private Sub Tab_c3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_c3.MouseDown
        c = 3
        Tab()
    End Sub
    Private Sub Tab_c3_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_c3.MouseEnter
        Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))

    End Sub
    Private Sub Tab_c3_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_c3.MouseLeave
        If Tab_c3_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_c3_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub

    Private Sub Tab_c4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_c4.MouseDown
        c = 4
        Tab()
    End Sub
    Private Sub Tab_c4_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_c4.MouseEnter
        Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))

    End Sub
    Private Sub Tab_c4_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_c4.MouseLeave
        If Tab_c4_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_c4_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub



    Private Sub Tab_c5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Tab_c5.MouseDown
        c = 5
        Tab()
    End Sub
    Private Sub Tab_c5_MouseEnter(sender As Object, e As MouseEventArgs) Handles Tab_c5.MouseEnter
        Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(104, 159, 56))

    End Sub
    Private Sub Tab_c5_MouseLeave(sender As Object, e As MouseEventArgs) Handles Tab_c5.MouseLeave
        If Tab_c5_Rectangle_.Visibility = Windows.Visibility.Hidden Then
            Tab_c5_text_.Foreground = New SolidColorBrush(Color.FromRgb(220, 237, 200))

        End If

    End Sub



    '=====================================设置====================================
 

    '===========================================================

 
   
    Private Sub Grid_Title_MouseEnter(sender As Object, e As MouseEventArgs) Handles Grid_Title.MouseEnter
        Fun_Expand(1)
    End Sub

    Private Sub Grid_Main_MouseEnter(sender As Object, e As MouseEventArgs) Handles Grid_Main.MouseEnter
        Fun_Expand(0)
    End Sub

   

    Private Sub TextBox111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TextBox111.MouseDown
        Fun_Shell("http://v.youku.com/v_show/id_XMTQ2MDM0OTcxNg==.html?f=26630656&from=y1.7-1.3#paction")

    End Sub
  
    Private Sub TextBox321_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TextBox321.MouseDown
        Fun_Shell("http://shang.qq.com/wpa/qunwpa?idkey=17d34ad4288abedeff11840cd4608c49c14c585976c633848fb2d5f4250fbf50")

    End Sub
    Private Sub TextBox322_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TextBox322.MouseDown
        Fun_Shell("http://weibo.com/5584004288")

    End Sub
    Private Sub TextBox323_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles TextBox323.MouseDown
        Fun_Shell("http://tieba.baidu.com/f?kw=%C2%E5%D1%F4%C0%ED%B9%A4%D1%A7%D4%BA&fr=home")

    End Sub
End Class

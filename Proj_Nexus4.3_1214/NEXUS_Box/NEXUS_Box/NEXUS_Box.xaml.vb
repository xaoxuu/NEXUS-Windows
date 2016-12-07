Class MainWindow
    Dim WshShell = CreateObject("WScript.Shell")
    Dim 语言变量, Tips, TipsCodes, Themecodes, R, G, B As String

    '=====================================初始化函数====================================
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        R = 150
        G = 150
        B = 150
        子函数_设置初始化()
        子函数_更新日期()
        子函数_更新时间()
        子函数_标题选择(5)
        子函数_文件检测()
        子函数_主题文件检测()

    End Sub

    '=====================================子函数====================================
    Private Sub Fun_Shell(i As String)
        WshShell.run(Chr(34) & i & Chr(34))
    End Sub
    Private Sub 子函数_主题(i As UInteger)
        Themecodes = i

       
        If i = 1 Then
            R = 150
            G = 150
            B = 150
        ElseIf i = 2 Then
            R = 154
            G = 226
            B = 121
        ElseIf i = 3 Then
            R = 96
            G = 169
            B = 23
        ElseIf i = 4 Then
            R = 0
            G = 138
            B = 0
        ElseIf i = 5 Then
            R = 142
            G = 208
            B = 240
        ElseIf i = 6 Then
            R = 27
            G = 161
            B = 226
        ElseIf i = 7 Then
            R = 0
            G = 80
            B = 239
        ElseIf i = 8 Then
            R = 106
            G = 0
            B = 255
        ElseIf i = 9 Then
            R = 170
            G = 0
            B = 255
        ElseIf i = 10 Then
            R = 244
            G = 114
            B = 208
        ElseIf i = 11 Then
            R = 216
            G = 0
            B = 255
        ElseIf i = 12 Then
            R = 100
            G = 100
            B = 100
        ElseIf i = 13 Then
            R = 162
            G = 0
            B = 37
        ElseIf i = 14 Then
            R = 251
            G = 67
            B = 67
        ElseIf i = 15 Then
            R = 250
            G = 104
            B = 0
        ElseIf i = 16 Then
            R = 240
            G = 163
            B = 10
        ElseIf i = 17 Then
            R = 163
            G = 200
            B = 0
        ElseIf i = 18 Then
            R = 130
            G = 90
            B = 44
        ElseIf i = 19 Then
            R = 215
            G = 202
            B = 153
        ElseIf i = 20 Then
            R = 54
            G = 37
            B = 17
        ElseIf i = 21 Then
            R = 118
            G = 77
            B = 57
        ElseIf i = 22 Then
            R = 229
            G = 187
            B = 129
        End If
        RGB值.Text = "R=" + R + ",G=" + G + ",B=" + B
        背景.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        背景.BorderBrush = New SolidColorBrush(Color.FromRgb(R, G, B))
        按钮_后台开_Ellipse_.Stroke = New SolidColorBrush(Color.FromRgb(R, G, B))
        English_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        中文_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        菜单.Background = New SolidColorBrush(Color.FromRgb(R, G, B))




    End Sub
    Private Sub 子函数_提示_标题右侧(i As String)
        If i = "0" Then
            提示_标题右侧.Visibility = Windows.Visibility.Hidden
        Else
            提示_标题右侧.Visibility = Windows.Visibility.Visible
            提示_标题右侧.Text = i
        End If
    End Sub
    Private Sub Roll()
        If Ellipse1.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Visible
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse2.Visibility = Windows.Visibility.Visible Then

            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Visible
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse3.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Visible
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse4.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Visible
            Ellipse6.Visibility = Windows.Visibility.Hidden
        ElseIf Ellipse5.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Hidden
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Visible
        ElseIf Ellipse6.Visibility = Windows.Visibility.Visible Then
            Ellipse1.Visibility = Windows.Visibility.Visible
            Ellipse2.Visibility = Windows.Visibility.Hidden
            Ellipse3.Visibility = Windows.Visibility.Hidden
            Ellipse4.Visibility = Windows.Visibility.Hidden
            Ellipse5.Visibility = Windows.Visibility.Hidden
            Ellipse6.Visibility = Windows.Visibility.Hidden
        End If

    End Sub
    Private Sub 子函数_标题选择(i As UInteger)
        子函数_灰色标题()
       
        If i = 1 Then

            If 语言变量 = "英文" Then
                提示_标题.Text = "NEXUS Sharing"
                NEXUS_Box.Title = "NEXUS Sharing"
            Else
                提示_标题.Text = "魔枢共享"
                NEXUS_Box.Title = "魔枢共享"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden

            主要内容1.Visibility = Windows.Visibility.Visible
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden


            内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))

        ElseIf i = 2 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Learning Sharing"
                NEXUS_Box.Title = "Learning Sharing"
            Else
                提示_标题.Text = "学习资源"
                NEXUS_Box.Title = "学习资源"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Visible
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 3 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Program Sharing"
                NEXUS_Box.Title = "Program Sharing"
            Else
                提示_标题.Text = "软件资源"
                NEXUS_Box.Title = "软件资源"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Visible
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 4 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Media Sharing"
                NEXUS_Box.Title = "Media Sharing"
            Else
                提示_标题.Text = "影音资源"
                NEXUS_Box.Title = "影音资源"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Visible
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 5 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "NEXUS v4.3"
                NEXUS_Box.Title = "NEXUS v4.3"
            Else
                提示_标题.Text = "魔枢 v4.3"
                NEXUS_Box.Title = "魔枢 v4.3"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Visible
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 6 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Practical Tools"
                NEXUS_Box.Title = "Practical Tools"
            Else
                提示_标题.Text = "实用工具"
                NEXUS_Box.Title = "实用工具"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Visible
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 7 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Internet Tools"
                NEXUS_Box.Title = "Internet Tools"
            Else
                提示_标题.Text = "网络工具"
                NEXUS_Box.Title = "网络工具"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Visible
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 8 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "System Tools"
                NEXUS_Box.Title = "System Tools"
            Else
                提示_标题.Text = "系统工具"
                NEXUS_Box.Title = "系统工具"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Visible
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Hidden
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Visible
            主要内容9.Visibility = Windows.Visibility.Hidden

            内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        ElseIf i = 9 Then
            If 语言变量 = "英文" Then
                提示_标题.Text = "Personalize Tools"
                NEXUS_Box.Title = "Personalize Tools"
            Else
                提示_标题.Text = "美化工具"
                NEXUS_Box.Title = "美化工具"
            End If

            内容分类1_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类2_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类3_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类4_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类5_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类6_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类7_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类8_Rectangle_.Visibility = Windows.Visibility.Hidden
            内容分类9_Rectangle_.Visibility = Windows.Visibility.Visible
            主要内容1.Visibility = Windows.Visibility.Hidden
            主要内容2.Visibility = Windows.Visibility.Hidden
            主要内容3.Visibility = Windows.Visibility.Hidden
            主要内容4.Visibility = Windows.Visibility.Hidden
            主要内容5.Visibility = Windows.Visibility.Hidden
            主要内容6.Visibility = Windows.Visibility.Hidden
            主要内容7.Visibility = Windows.Visibility.Hidden
            主要内容8.Visibility = Windows.Visibility.Hidden
            主要内容9.Visibility = Windows.Visibility.Visible

            内容分类9_Image_.Background = New SolidColorBrush(Color.FromRgb(255, 255, 255))
            内容分类9_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
        End If
    End Sub
    Private Sub 子函数_灰色标题()

        内容分类1_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类2_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类3_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类4_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类5_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类6_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类7_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类8_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类9_Image_.Background = New SolidColorBrush(Color.FromRgb(R, G, B))

        内容分类1_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类2_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类3_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类4_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类5_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类6_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类7_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类8_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类9_TextBox_.Foreground = New SolidColorBrush(Color.FromRgb(R, G, B))

        内容分类1_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类2_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类3_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类4_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类5_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类6_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类7_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类8_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        内容分类9_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(R, G, B))
        '一级区域_内容_Rectangle_.Fill = New SolidColorBrush(Color.FromRgb(255, 255, 255))
    End Sub
    Private Sub 子函数_语言(i As String)

        If i = "中文" Then
            语言变量 = "中文"
            Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Language\Chinese.vbs")
            If 提示_标题.Text = "NEXUS Sharing" Then
                提示_标题.Text = "魔枢共享"
                NEXUS_Box.Title = "魔枢共享"
            ElseIf 提示_标题.Text = "Learning Sharing" Then
                提示_标题.Text = "学习资源"
                NEXUS_Box.Title = "学习资源"
            ElseIf 提示_标题.Text = "Program Sharing" Then
                提示_标题.Text = "软件资源"
                NEXUS_Box.Title = "软件资源"
            ElseIf 提示_标题.Text = "Media Sharing" Then
                提示_标题.Text = "影音资源"
                NEXUS_Box.Title = "影音资源"
            ElseIf 提示_标题.Text = "NEXUS v4.3" Then
                提示_标题.Text = "魔枢 v4.3"
                NEXUS_Box.Title = "魔枢 v4.3"
            ElseIf 提示_标题.Text = "Practical Tools" Then
                提示_标题.Text = "实用工具"
                NEXUS_Box.Title = "实用工具"
            ElseIf 提示_标题.Text = "Internet Tools" Then
                提示_标题.Text = "网络工具"
                NEXUS_Box.Title = "网络工具"
            ElseIf 提示_标题.Text = "System Tools" Then
                提示_标题.Text = "系统工具"
                NEXUS_Box.Title = "系统工具"
            ElseIf 提示_标题.Text = "Personalize Tools" Then
                提示_标题.Text = "美化工具"
                NEXUS_Box.Title = "美化工具"
            End If
            内容分类1_TextBox_.Text = "魔枢共享"
            内容分类2_TextBox_.Text = "学习资源"
            内容分类3_TextBox_.Text = "软件资源"
            内容分类4_TextBox_.Text = "影音资源"
            内容分类5_TextBox_.Text = "主页"
            内容分类6_TextBox_.Text = "实用工具"
            内容分类7_TextBox_.Text = "网络工具"
            内容分类8_TextBox_.Text = "系统工具"
            内容分类9_TextBox_.Text = "美化工具"

            文本框_搜索全部功能.Text = "搜索全部功能"
            标题_反馈.Text = "意见反馈"
            文本框_意见反馈.Text = "      您的意见是作者创作灵感的源泉，每一次的版本更新都是大家共同智慧的结晶。因此本软件不是个人作品，而是集体劳动成果。       作者恳切请求您写下关于本软件的任何意见或者修改建议。"
            按钮_反馈_TextBox_.Text = "提交反馈"
            标题_开机自启.Text = "保持后台"
            描述_开机自启.Text = "需占用您10MB左右的内存。"
            标题_安装路径.Text = "安装路径"
            描述_安装路径.Text = "打开魔枢安装路径。"
            标题_更新.Text = "下载更新"
            描述_更新.Text = "体验更多更完善的功能。"
            标题_源代码.Text = "获取源代码"
            描述_源代码.Text = "以供专业人员查看"
            标题_卸载.Text = "卸载魔枢"
            描述_卸载.Text = "从电脑中完全删除"
            软件信息_名字.Text = "名字	魔枢"
            软件信息_版本.Text = "版本	4.3"
            软件信息_作者.Text = "作者	精灵软件"
            标题_语言切换.Text = "语言"
            标题_主题.Text = "主题"

            主页_周1.Text = "大三上学期"
            主页_周2.Text = "第15周"
            计划任务.Text = "备注"
            放假日期.Text = "放假日期：2015-01-22"
            考研日期.Text = "考研日期：2015-12-26"
            毕业日期.Text = "毕业日期：2016-06-12"

            内容11.Text = "最新分享"
            内容12.Text = "百度云"
            内容21.Text = "公开课"
            内容22.Text = "自学网站"
            内容23.Text = "素材网站"
            内容24.Text = "基础能力"
            内容25.Text = "影音"
            内容26.Text = "专业知识"
            内容31.Text = "魔枢软件助手"
            内容32.Text = "装机推荐"
            内容33.Text = "软件站"
            内容41.Text = "精灵影视"
            内容42.Text = "音乐"
            内容43.Text = "电影"
            内容61.Text = "定时关机"
            内容62.Text = "清理优化"
            内容63.Text = "辅助工具"
            内容64.Text = "系统自带"
            内容71.Text = "网络工具"
            内容81.Text = "系统自带"
            内容82.Text = "故障修复"
            内容83.Text = "系统组件"
            内容84.Text = "第三方工具"
            内容91.Text = "桌面"
            内容92.Text = "Windows7破解主题"

            快捷功能_TextBox_.Text = "快捷功能"

        ElseIf i = "英文" Then
            语言变量 = "英文"
            Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Language\English.vbs")
            If 提示_标题.Text = "魔枢共享" Then
                提示_标题.Text = "NEXUS Sharing"
                NEXUS_Box.Title = "NEXUS Sharing"
            ElseIf 提示_标题.Text = "学习资源" Then
                提示_标题.Text = "Learning Sharing"
                NEXUS_Box.Title = "Learning Sharing"
            ElseIf 提示_标题.Text = "软件资源" Then
                提示_标题.Text = "Program Sharing"
                NEXUS_Box.Title = "Program Sharing"
            ElseIf 提示_标题.Text = "影音资源" Then
                提示_标题.Text = "Media Sharing"
                NEXUS_Box.Title = "Media Sharing"
            ElseIf 提示_标题.Text = "魔枢 v4.3" Then
                提示_标题.Text = "NEXUS v4.3"
                NEXUS_Box.Title = "NEXUS v4.3"
            ElseIf 提示_标题.Text = "实用工具" Then
                提示_标题.Text = "Practical Tools"
                NEXUS_Box.Title = "Practical Tools"
            ElseIf 提示_标题.Text = "网络工具" Then
                提示_标题.Text = "Internet Tools"
                NEXUS_Box.Title = "Internet Tools"
            ElseIf 提示_标题.Text = "系统工具" Then
                提示_标题.Text = "System Tools"
                NEXUS_Box.Title = "System Tools"
            ElseIf 提示_标题.Text = "美化工具" Then
                提示_标题.Text = "Personalize Tools"
                NEXUS_Box.Title = "Personalize Tools"
            End If
            内容分类1_TextBox_.Text = "Sharing"
            内容分类2_TextBox_.Text = "Learning"
            内容分类3_TextBox_.Text = "Program"
            内容分类4_TextBox_.Text = "Media"
            内容分类5_TextBox_.Text = "Home"
            内容分类6_TextBox_.Text = "Tools"
            内容分类7_TextBox_.Text = "Internet"
            内容分类8_TextBox_.Text = "System"
            内容分类9_TextBox_.Text = "Personal"

            文本框_搜索全部功能.Text = "Search All"
            标题_反馈.Text = "Feedback"
            文本框_意见反馈.Text = "      Your suggestions is a source of inspiration to the author, each version updates are common wisdom crystallization. This software is not a personal work, but the collective labor results.       The author earnestly request you to write about this software for any comments or suggestions for modification."
            按钮_反馈_TextBox_.Text = "Submit feedback"
            标题_开机自启.Text = "Startup"
            描述_开机自启.Text = "It takes only about 10MB of memory."
            标题_安装路径.Text = "Installation path"
            描述_安装路径.Text = "Open the installation path of NEXUS."
            标题_更新.Text = "Check Updates"
            描述_更新.Text = "Experience more perfect function."
            标题_源代码.Text = "Source codes"
            描述_源代码.Text = "Get the source codes of NEXUS."
            标题_卸载.Text = "Uninstall"
            描述_卸载.Text = "Uninstall NEXUS."
            软件信息_名字.Text = "Name	NEXUS"
            软件信息_版本.Text = "Version	4.3"
            软件信息_作者.Text = "Author	ELFPRO"
            标题_语言切换.Text = "Language"
            标题_主题.Text = "Theme"

            主页_周1.Text = "First Semester in Junior"
            主页_周2.Text = "15th weeks"
            计划任务.Text = "Schedule"
            放假日期.Text = "Winter：2015-01-22"
            考研日期.Text = "NEEP：2015-12-26"
            毕业日期.Text = "Graduation：2016-06-12"

            内容11.Text = ""
            内容12.Text = ""
            内容21.Text = ""
            内容22.Text = ""
            内容23.Text = ""
            内容24.Text = ""
            内容25.Text = ""
            内容26.Text = ""
            内容31.Text = ""
            内容32.Text = ""
            内容33.Text = ""
            内容41.Text = ""
            内容42.Text = ""
            内容43.Text = ""
            内容61.Text = ""
            内容62.Text = ""
            内容63.Text = ""
            内容64.Text = ""
            内容71.Text = ""
            内容81.Text = ""
            内容82.Text = ""
            内容83.Text = ""
            内容84.Text = ""
            内容91.Text = ""
            内容92.Text = ""
            内容11.Text = "Latest Sharing"
            内容12.Text = "Cloud Disk"
            内容21.Text = "Open Class Website"
            内容22.Text = "Self-Taught Website"
            内容23.Text = "Material Website"
            内容24.Text = "Basic ability"
            内容25.Text = "Audio and Video"
            内容26.Text = "Professional Knowledge"
            内容31.Text = "NEXUS Software Assistant"
            内容32.Text = "Excellent Software"
            内容33.Text = "Software Download Station"
            内容41.Text = "ELFILM"
            内容42.Text = "Music"
            内容43.Text = "Film"
            内容61.Text = "Timing Shutdown"
            内容62.Text = "Clean up the optimization"
            内容63.Text = "Auxiliary tools"
            内容64.Text = "System Tools"
            内容71.Text = "Internet Tools"
            内容81.Text = "System Setting"
            内容82.Text = "Fault Repair"
            内容83.Text = "Microsoft .NET Framework"
            内容84.Text = "Other Tools"
            内容91.Text = "Desktop"
            内容92.Text = "Windows7 Themes"

            快捷功能_TextBox_.Text = "Goto"


        End If

        二级区域_菜单.Visibility = Windows.Visibility.Hidden
        子函数_更新日期()
    End Sub
    Private Sub 子函数_文件检测()
        If Dir("D:\Program Files\NEXUS\Temp\Startup\魔枢后台.lnk") = "" Then
            按钮_后台关.Visibility = Windows.Visibility.Visible
            按钮_后台开.Visibility = Windows.Visibility.Hidden
        Else
            按钮_后台关.Visibility = Windows.Visibility.Hidden
            按钮_后台开.Visibility = Windows.Visibility.Visible
        End If
        If Dir("D:\Program Files\NEXUS\Temp\Language\English.txt") = "" Then
            子函数_语言("中文")
        Else
            子函数_语言("英文")
        End If

        If 语言变量 = "英文" Then
            语言切换_中文.Visibility = Windows.Visibility.Hidden
            语言切换_英文.Visibility = Windows.Visibility.Visible
        Else
            语言切换_中文.Visibility = Windows.Visibility.Visible
            语言切换_英文.Visibility = Windows.Visibility.Hidden
        End If

        '-------------------------------------------------------------------------------
        
        '-------------------------------------------------------------------------------
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            快捷1_TextBox_.Text = "点击安装TuneUp"
            内容621_Grid_.Visibility = Windows.Visibility.Visible
        Else
            快捷1_TextBox_.Text = "TuneUp一键优化"
            内容621_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        '-------------------------------------------------------------------------------

        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            内容321_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容321_Grid_.Visibility = Windows.Visibility.Hidden
        End If


        If Dir("C:\Program Files\7-Zip\7zFM.exe") = "" Then
            内容323_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容323_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") = "" Then
            If Dir("C:\Program Files\Google\Chrome\Application\chrome.exe") = "" Then
                内容324_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容324_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        Else
            内容324_Grid_.Visibility = Windows.Visibility.Hidden
        End If


        If Dir("C:\Program Files (x86)\Google\Picasa3\Picasa3.exe") = "" Then
            If Dir("C:\Program Files\Google\Picasa3\Picasa3.exe") = "" Then
                If Dir("D:\Program Files\Google\Picasa3\Picasa3.exe") = "" Then
                    内容325_Grid_.Visibility = Windows.Visibility.Visible
                Else
                    内容325_Grid_.Visibility = Windows.Visibility.Hidden
                End If
            Else
                内容325_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        Else
            内容325_Grid_.Visibility = Windows.Visibility.Hidden
        End If

        If Dir("C:\Program Files (x86)\Tencent\QQPlayer\QQPlayer.exe") = "" Then
            If Dir("C:\Program Files\Tencent\QQPlayer\QQPlayer.exe") = "" Then
                If Dir("D:\Program Files\Tencent\QQPlayer\QQPlayer.exe") = "" Then
                    内容326_Grid_.Visibility = Windows.Visibility.Visible
                Else
                    内容326_Grid_.Visibility = Windows.Visibility.Hidden
                End If
            Else
                内容326_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        Else
            内容326_Grid_.Visibility = Windows.Visibility.Hidden
        End If
      
      
        If Dir("D:\Program Files\Foobar2000_Metro\foobar2000.exe") = "" Then
            If Dir("D:\Program Files\Foobar2000\foobar2000.exe") = "" Then
                内容327_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容327_Grid_.Visibility = Windows.Visibility.Hidden
            End If
        Else
            内容327_Grid_.Visibility = Windows.Visibility.Hidden
        End If








        '-------------------------------------------------------------------------------

        If Dir("D:\Program Files\Matlab6.5\bin\win32\matlab.exe") = "" Then
            内容341_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容341_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\C-Free 5\CppIDE.exe") = "" Then
            内容342_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容342_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE") = "" Then
            内容343_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容343_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program File\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then

            If Dir("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then
                内容344_Grid_.Visibility = Windows.Visibility.Visible
            Else
                内容344_Grid_.Visibility = Windows.Visibility.Hidden
            End If

        Else
            内容344_Grid_.Visibility = Windows.Visibility.Hidden
        End If
       
        If Dir("D:\Program Files\Keil\UV4\UV4.exe") = "" Then
            内容345_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容345_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\ProtelDXP2004\DXP.exe") = "" Then
            内容346_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容346_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Altium\AD13\DXP.EXE") = "" Then
            内容347_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容347_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE") = "" Then
            内容348_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容348_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe") = "" Then
            内容351_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容351_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe") = "" Then
            内容352_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容352_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe") = "" Then
            内容353_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容353_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe") = "" Then
            内容354_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容354_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe") = "" Then
            内容355_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容355_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe") = "" Then
            内容356_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容356_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe") = "" Then
            内容357_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容357_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe") = "" Then
            内容361_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容361_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\IcoFX 2\IcoFX2.exe") = "" Then
            内容362_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容362_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe") = "" Then
            内容363_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容363_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe") = "" Then
            内容364_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容364_Grid_.Visibility = Windows.Visibility.Hidden
        End If

        
        '-------------------------------------------------------------------------------


        '-------------------------------------------------------------------------------
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk") = "" Then
            内容622_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容622_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk") = "" Then
            内容623_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容623_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe") = "" Then
            内容624_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容624_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        '-------------------------------------------------------------------------------
        If Dir("D:\Program Files\Tools\FX82ES.exe") = "" Then
            内容631_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容631_Grid_.Visibility = Windows.Visibility.Hidden
        End If

        If Dir("D:\Program Files\NEXUS\Box\Box63\winstart.exe") = "" Then
            内容633_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容633_Grid_.Visibility = Windows.Visibility.Hidden
        End If

        If Dir("D:\Program Files\Tools\Matlab5.3\matlab.exe") = "" Then
            内容636_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容636_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        '-------------------------------------------------------------------------------
        If Dir("D:\Program Files\Tools\magicwifi.exe") = "" Then
            内容711_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容711_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Tools\VPN\SuperIdiot2.11.exe") = "" Then
            内容712_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容712_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\Tools\DNSCrypt Proxy 1.4.0\dnscrypt-winclient.exe") = "" Then
            内容713_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容713_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\硕鼠\commence.exe") = "" Then
            内容714_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容714_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        '-------------------------------------------------------------------------------

        If Dir("D:\Program Files\DriverGenius\drivergenius.exe") = "" Then
            内容822_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容822_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\DiskGenius\diskgenius.exe") = "" Then
            内容825_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容825_Grid_.Visibility = Windows.Visibility.Hidden
        End If
        If Dir("D:\Program Files\DirectX Repair V3.0\DirectX Repair.exe") = "" Then
            内容834_Grid_.Visibility = Windows.Visibility.Visible
        Else
            内容834_Grid_.Visibility = Windows.Visibility.Hidden
        End If




    End Sub
    Private Sub 子函数_主题文件检测()
        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme01.txt") = "" Then
            If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme02.txt") = "" Then
                If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme03.txt") = "" Then
                    If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme04.txt") = "" Then
                        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme05.txt") = "" Then
                            If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme06.txt") = "" Then
                                If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme07.txt") = "" Then
                                    If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme08.txt") = "" Then
                                        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme09.txt") = "" Then
                                            If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme10.txt") = "" Then
                                                If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme11.txt") = "" Then
                                                    If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme12.txt") = "" Then
                                                        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme13.txt") = "" Then
                                                            If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme14.txt") = "" Then
                                                                If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme15.txt") = "" Then
                                                                    If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme16.txt") = "" Then
                                                                        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme17.txt") = "" Then
                                                                            If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme18.txt") = "" Then

                                                                                If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme19.txt") = "" Then

                                                                                    If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme20.txt") = "" Then

                                                                                        If Dir("D:\Program Files\NEXUS\Temp\Themes\Theme21.txt") = "" Then
                                                                                            子函数_主题(22)
                                                                                            Exit Sub
                                                                                        Else
                                                                                            子函数_主题(21)
                                                                                            Exit Sub
                                                                                        End If

                                                                                    Else
                                                                                        子函数_主题(20)
                                                                                        Exit Sub
                                                                                    End If

                                                                                Else
                                                                                    子函数_主题(19)
                                                                                    Exit Sub
                                                                                End If

                                                                            Else
                                                                                子函数_主题(18)
                                                                                Exit Sub
                                                                            End If

                                                                        Else
                                                                            子函数_主题(17)
                                                                            Exit Sub
                                                                        End If

                                                                    Else
                                                                        子函数_主题(16)
                                                                        Exit Sub
                                                                    End If

                                                                Else
                                                                    子函数_主题(15)
                                                                    Exit Sub
                                                                End If

                                                            Else
                                                                子函数_主题(14)
                                                                Exit Sub
                                                            End If

                                                        Else
                                                            子函数_主题(13)
                                                            Exit Sub
                                                        End If

                                                    Else
                                                        子函数_主题(12)
                                                        Exit Sub
                                                    End If

                                                Else
                                                    子函数_主题(11)
                                                    Exit Sub
                                                End If

                                            Else
                                                子函数_主题(10)
                                                Exit Sub
                                            End If

                                        Else
                                            子函数_主题(9)
                                            Exit Sub
                                        End If

                                    Else
                                        子函数_主题(8)
                                        Exit Sub
                                    End If

                                Else
                                    子函数_主题(7)
                                    Exit Sub
                                End If

                            Else
                                子函数_主题(6)
                                Exit Sub
                            End If

                        Else
                            子函数_主题(5)
                            Exit Sub
                        End If

                    Else
                        子函数_主题(4)
                        Exit Sub
                    End If

                Else
                    子函数_主题(3)
                    Exit Sub
                End If

            Else
                子函数_主题(2)
                Exit Sub
            End If

        Else
            子函数_主题(1)
            Exit Sub
        End If
    End Sub
    Private Sub 子函数_提示(i As String)
        Tips = i
        一级区域_提示.Visibility = Windows.Visibility.Visible
        If Tips = "0" Then
            一级区域_提示.Visibility = Windows.Visibility.Hidden
        Else
            提示内容.Text = "       缺少" + Tips + "，需要安装吗？点击确定开始从魔枢的百度云共享下载安装。"
        End If
    End Sub
    Private Sub 子函数_提示确定()

        一级区域_提示.Visibility = Windows.Visibility.Hidden
        If 提示标题.Text = "卸载提示" Then
            Fun_Shell("C:\Windows\UnInstall.vbs")
        End If

        If TipsCodes = 321 Then
            Fun_Shell("http://yun.baidu.com/s/1eQgpYtc")
        ElseIf TipsCodes = 322 Then
            Fun_Shell("http://install.avira-update.com/package/wks_avira13/win32/zhcn/pecl/avira_free_antivirus_zhcn.exe")

        ElseIf TipsCodes = 323 Then
            Fun_Shell("http://sparanoid.com/lab/7z/")

        ElseIf TipsCodes = 324 Then
            Fun_Shell("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B47BF6219-2E7A-8D94-BE09-A7E27F9E5BAD%7D%26lang%3Dzh-CN%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe")

        ElseIf TipsCodes = 325 Then
            Fun_Shell("https://dl.google.com/picasa/picasa39-setup.exe")

        ElseIf TipsCodes = 326 Then
            Fun_Shell("http://dl_dir.qq.com/invc/qqplayer/QQPlayer_Setup_37_892.exe")
        ElseIf TipsCodes = 327 Then
            Fun_Shell("http://www.foobar2000.org/files/152cf5511719b95ebfccb42265ed36f1/foobar2000_v1.3.6.exe")

        End If
        If TipsCodes = 341 Then
            Fun_Shell("")
        ElseIf TipsCodes = 342 Then
            Fun_Shell("")
        ElseIf TipsCodes = 343 Then
            Fun_Shell("")
        ElseIf TipsCodes = 344 Then
            Fun_Shell("")
        ElseIf TipsCodes = 345 Then
            Fun_Shell("")
        ElseIf TipsCodes = 346 Then
            Fun_Shell("")
        ElseIf TipsCodes = 347 Then
            Fun_Shell("")
        ElseIf TipsCodes = 348 Then
            Fun_Shell("")
        End If
        If TipsCodes = 351 Then
            Fun_Shell("")
        ElseIf TipsCodes = 352 Then
            Fun_Shell("")
        ElseIf TipsCodes = 353 Then
            Fun_Shell("")
        ElseIf TipsCodes = 354 Then
            Fun_Shell("")
        ElseIf TipsCodes = 355 Then
            Fun_Shell("")
        ElseIf TipsCodes = 356 Then
            Fun_Shell("")
        ElseIf TipsCodes = 357 Then
            Fun_Shell("")
        End If
        If TipsCodes = 361 Then
            Fun_Shell("")
        ElseIf TipsCodes = 362 Then
            Fun_Shell("")
        ElseIf TipsCodes = 363 Then
            Fun_Shell("")
        ElseIf TipsCodes = 364 Then
            Fun_Shell("")
        End If







        If TipsCodes = 621 Or TipsCodes = 622 Or TipsCodes = 623 Then
            Fun_Shell("http://pan.baidu.com/s/1eQgpYtc")

        ElseIf TipsCodes = 624 Then
            Fun_Shell("http://pan.baidu.com/s/1mg5gkAW")

        ElseIf TipsCodes = 631 Then
            Fun_Shell("http://pan.baidu.com/s/1jGyyDfS")

        ElseIf TipsCodes = 633 Then
            Fun_Shell("http://pan.baidu.com/s/1jGmTwXK")

        ElseIf TipsCodes = 711 Then
            Fun_Shell("http://pan.baidu.com/s/1i3gPK6T")

        ElseIf TipsCodes = 712 Then
            Fun_Shell("http://pan.baidu.com/s/1ntFn7CX")

        ElseIf TipsCodes = 713 Then
            Fun_Shell("http://pan.baidu.com/s/1mgDnEiO")

        ElseIf TipsCodes = 714 Then
            Fun_Shell("http://pan.baidu.com/s/1dD0AIOh")

        ElseIf TipsCodes = 822 Then
            Fun_Shell("http://pan.baidu.com/s/1dDD1Xy5")

        ElseIf TipsCodes = 825 Then
            Fun_Shell("http://pan.baidu.com/s/1qW0oupI")

        ElseIf TipsCodes = 834 Then
            Fun_Shell("http://pan.baidu.com/s/1ntmNpTv")


        End If
    End Sub

    Private Sub 子函数_更新时间()
        提示_标题左侧.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        主页时钟.Text = System.DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Private Sub 子函数_更新日期()
        If 语言变量 = "英文" Then
            倒计时1.Text = "Today：" + System.DateTime.Now.ToString("yyyy-MM-dd")
        ElseIf 语言变量 = "中文" Then
            倒计时1.Text = "现在时间：" + System.DateTime.Now.ToString("yyyy-MM-dd")
        End If
    End Sub

    Private Sub 子函数_设置初始化()
        If Dir("D:\Program Files\Nexus\UserSetting\Language\English.txt") = "" Then
            子函数_语言("中文")
        Else
            子函数_语言("英文")
        End If



    End Sub
    Private Sub Fun_Run(i As UInteger)
        TipsCodes = i
        If i = 111 Then

            Fun_Shell("http://202.196.192.25/lyit/_data/index_Lookxl.aspx")

        ElseIf i = 112 Then

            ' Fun_Shell("")

        ElseIf i = 113 Then

            ' Fun_Shell("")

        ElseIf i = 114 Then

            Fun_Shell("http://pan.baidu.com/")

        ElseIf i = 121 Then
            If Dir("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe") = "" Then
                子函数_提示("百度云管家客户端")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe")
            End If
        ElseIf i = 122 Then
           
            Fun_Shell("http://pan.baidu.com/")

        ElseIf i = 211 Then

            Fun_Shell("http://study.163.com/")

        ElseIf i = 212 Then

            Fun_Shell("http://open.163.com/")

        ElseIf i = 213 Then

            Fun_Shell("http://opencla.cntv.cn/")

        ElseIf i = 214 Then

            Fun_Shell("http://course.jingpinke.com/")

        ElseIf i = 215 Then

            Fun_Shell("http://open.sina.com.cn/")

        ElseIf i = 216 Then

            Fun_Shell("http://www.mycampus.hk/")

        ElseIf i = 217 Then

            Fun_Shell("https://www.coursera.org/")

        ElseIf i = 218 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 221 Then

            Fun_Shell("http://www.51zxw.net/")

        ElseIf i = 222 Then

            Fun_Shell("http://www.rjzxw.com/")

        ElseIf i = 223 Then

            Fun_Shell("http://www.jcwcn.com/")

        ElseIf i = 224 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 231 Then

            Fun_Shell("http://www.nipic.com/")

        ElseIf i = 232 Then

            Fun_Shell("http://sc.chinaz.com/")

        ElseIf i = 233 Then

            Fun_Shell("http://www.webshu.net/")

        ElseIf i = 234 Then

            Fun_Shell("http://www.ooopic.com/")

        ElseIf i = 235 Then

            Fun_Shell("http://www.zcool.com.cn/")

        ElseIf i = 236 Then

            Fun_Shell("http://www.sccnn.com/")

        ElseIf i = 237 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")


        ElseIf i = 241 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjU5MDM1NDc2.html")

        ElseIf i = 242 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjg5MzU1OTYw.html")

        ElseIf i = 243 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjQ4MjQ3MDMy.html")

        ElseIf i = 244 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 251 Then

            Fun_Shell("http://v.youku.com/v_show/id_XOTAzMTIxNTI=.html")

        ElseIf i = 252 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzQ2MDc4NzIw.html")

        ElseIf i = 253 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNjcxMTM5OTY4.html?f=21844931")

        ElseIf i = 254 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 261 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzI2MzU0MTMy.html")

        ElseIf i = 262 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")



        ElseIf i = 311 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_Office.exe")

        ElseIf i = 312 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_VideoStudio.exe")

        ElseIf i = 313 Then

            Fun_Shell("D:\Program Files\NEXUS\Bin\NEXUS_Adobe.exe")

        ElseIf i = 321 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
            End If
        ElseIf i = 322 Then

            子函数_提示("AVIRA")

        ElseIf i = 323 Then
            If Dir("C:\Program Files\7-Zip\7zFM.exe") = "" Then
                子函数_提示("7z")
            Else
                Fun_Shell("C:\Program Files\7-Zip\7zFM.exe")
            End If
           
        ElseIf i = 324 Then
            If Dir("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") = "" Then
                If Dir("C:\Program Files\Google\Chrome\Application\chrome.exe") = "" Then
                    子函数_提示("Chrome")
                Else
                    Fun_Shell("C:\Program Files\Google\Chrome\Application\chrome.exe")
                End If
            Else
                Fun_Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
            End If

           
        ElseIf i = 325 Then
            If Dir("C:\Program Files (x86)\Google\Picasa3\Picasa3.exe") = "" Then
                If Dir("C:\Program Files\Google\Picasa3\Picasa3.exe") = "" Then
                    If Dir("D:\Program Files\Google\Picasa3\Picasa3.exe") = "" Then
                        子函数_提示("Chrome")
                    Else
                        Fun_Shell("D\Program Files\Google\Picasa3\Picasa3.exe")
                    End If
                Else
                    Fun_Shell("C:\Program Files\Google\Picasa3\Picasa3.exe")
                End If
            Else
                Fun_Shell("C:\Program Files (x86)\Google\Picasa3\Picasa3.exe")
            End If

           
        ElseIf i = 326 Then
            If Dir("C:\Program Files (x86)\Tencent\QQPlayer\QQPlayer.exe") = "" Then
                If Dir("C:\Program Files\Tencent\QQPlayer\QQPlayer.exe") = "" Then
                    If Dir("D:\Program Files\Tencent\QQPlayer\QQPlayer.exe") = "" Then
                        子函数_提示("QQ影音")
                    Else
                        Fun_Shell("D\Program Files\Tencent\QQPlayer\QQPlayer.exe")
                    End If
                Else
                    Fun_Shell("C:\Program Files\Tencent\QQPlayer\QQPlayer.exe")
                End If
            Else
                Fun_Shell("C:\Program Files (x86)\Tencent\QQPlayer\QQPlayer.exe")
            End If
           

        ElseIf i = 327 Then
            If Dir("D:\Program Files\Foobar2000_Metro\foobar2000.exe") = "" Then
                If Dir("D:\Program Files\Foobar2000\foobar2000.exe") = "" Then
                    子函数_提示("Foobar2000")
                Else
                    Fun_Shell("D:\Program Files\Foobar2000\foobar2000.exe")
                End If
            Else
                Fun_Shell("D:\Program Files\Foobar2000_Metro\foobar2000.exe")
            End If

           
        ElseIf i = 328 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 331 Then

            Fun_Shell("http://rj.baidu.com/")

        ElseIf i = 332 Then

            Fun_Shell("http://www.anxz.com/")

        ElseIf i = 333 Then

            Fun_Shell("http://www.appinn.com/")

        ElseIf i = 334 Then

            Fun_Shell("http://www.softonic.cn/")
        ElseIf i = 341 Then
            If Dir("D:\Program Files\Matlab6.5\bin\win32\matlab.exe") = "" Then
                子函数_提示("MATLAB6.5")
            Else
                Fun_Shell("D:\Program Files\Matlab6.5\bin\win32\matlab.exe")
            End If
        ElseIf i = 342 Then
            If Dir("D:\Program Files\C-Free 5\CppIDE.exe") = "" Then
                子函数_提示("C-Free 5.0")
            Else
                Fun_Shell("D:\Program Files\C-Free 5\CppIDE.exe")
            End If
        ElseIf i = 343 Then
            If Dir("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE") = "" Then
                子函数_提示("Visual C++ 6.0")
            Else
                Fun_Shell("D:\Program Files\Microsoft Visual Studio\Common\MSDev98\Bin\MSDEV.EXE")
            End If
        ElseIf i = 344 Then
            If Dir("D:\Program File\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then

                If Dir("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe") = "" Then
                    子函数_提示("Visual Studio 2013")
                End If
                Fun_Shell("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe")

            Else
                Fun_Shell("D:\Program Files\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe")
            End If
        ElseIf i = 345 Then
            If Dir("D:\Program Files\Keil\UV4\UV4.exe") = "" Then
                子函数_提示("Keil C51")
            Else
                Fun_Shell("D:\Program Files\Keil\UV4\UV4.exe")
            End If
        ElseIf i = 346 Then
            If Dir("D:\Program Files\ProtelDXP2004\DXP.exe") = "" Then
                子函数_提示("Protel 99SE")
            Else
                Fun_Shell("D:\Program Files\ProtelDXP2004\DXP.exe")
            End If
        ElseIf i = 347 Then
            If Dir("D:\Program Files\Altium\AD13\DXP.EXE") = "" Then
                子函数_提示("Altium Designer")
            Else
                Fun_Shell("D:\Program Files\Altium\AD13\DXP.EXE")
            End If
        ElseIf i = 348 Then
            If Dir("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE") = "" Then
                子函数_提示("Proteus")
            Else
                Fun_Shell("D:\Program Files\Labcenter Electronics\Proteus 8 Professional\BIN\PDS.EXE")
            End If
        ElseIf i = 351 Then
            If Dir("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe") = "" Then
                子函数_提示("Adobe PhotoShop")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Photoshop CS6\Adobe Photoshop CS6\Photoshop.exe")
            End If
        ElseIf i = 352 Then
            If Dir("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe") = "" Then
                子函数_提示("Adobe Bridge")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Bridge CS4\Bridge.exe")
            End If
        ElseIf i = 353 Then
            If Dir("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe") = "" Then
                子函数_提示("Adobe Flash")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Flash CC\Adobe Flash CC\Flash.exe")
            End If
        ElseIf i = 354 Then
            If Dir("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe") = "" Then
                子函数_提示("Adobe Audition")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Audition CC\Adobe Audition CC\Adobe Audition CC.exe")
            End If
        ElseIf i = 355 Then
            If Dir("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe") = "" Then
                子函数_提示("Adobe Premiere")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe")
            End If
        ElseIf i = 356 Then
            If Dir("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe") = "" Then
                子函数_提示("Adobe After Effects")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe After Effects CC\Support Files\AfterFX.exe")
            End If
        ElseIf i = 357 Then
            If Dir("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe") = "" Then
                子函数_提示("Adobe Illustrator")
            Else
                Fun_Shell("D:\Program Files\Adobe\Adobe Illustrator CS6\Support Files\Contents\Windows\Illustrator.exe")
            End If
        ElseIf i = 361 Then
            If Dir("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe") = "" Then
                子函数_提示("格式工厂")
            Else
                Fun_Shell("D:\Program Files\FreeTime\FormatFactory\FormatFactory.exe")
            End If
        ElseIf i = 362 Then
            If Dir("D:\Program Files\IcoFX 2\IcoFX2.exe") = "" Then
                子函数_提示("IcoFX2")
            Else
                Fun_Shell("D:\Program Files\IcoFX 2\IcoFX2.exe")
            End If
        ElseIf i = 363 Then
            If Dir("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe") = "" Then
                子函数_提示("会声会影")
            Else
                Fun_Shell("D:\Program Files\Corel\Corel VideoStudio Pro X6\vstudio.exe")
            End If
        ElseIf i = 364 Then
            If Dir("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe") = "" Then
                子函数_提示("美图秀秀")
            Else
                Fun_Shell("D:\Program Files\Meitu\XiuXiu\XiuXiu.exe")
            End If

        ElseIf i = 411 Then

            Fun_Shell("http://i.youku.com/u/UNjE4MzEyOTYw")

        ElseIf i = 412 Then

            Fun_Shell("http://v.youku.com/v_show/id_XNzI3ODMzMTUy.html?f=22415103")

        ElseIf i = 413 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 421 Then
            If Dir("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe") = "" Then
                子函数_提示("百度云管家客户端")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe")
            End If
        ElseIf i = 422 Then

           
        ElseIf i = 423 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 431 Then
            If Dir("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe") = "" Then
                子函数_提示("百度云管家客户端")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box12\BaiduYunGuanjia\BaiduYunGuanjia.exe")
            End If
        ElseIf i = 432 Then



        ElseIf i = 433 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 621 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
            End If
        ElseIf i = 622 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp Program Deactivator.lnk")
            End If
        ElseIf i = 623 Then
            If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk") = "" Then
                子函数_提示("TuneUp")
            Else
                Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp StartUp Manager.lnk")
            End If
        ElseIf i = 624 Then
            If Dir("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe") = "" Then
                子函数_提示("Toolbox")
            Else
                Fun_Shell("D:\Program Files\IObit_Toolbox_v1.2\Toolbox.exe")
            End If
        ElseIf i = 625 Then
            If Dir("D:\Program Files\NEXUS\Box\Box62\cleanmaster.exe") = "" Then
                子函数_提示("软媒清理大师")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box62\cleanmaster.exe")
            End If
        ElseIf i = 626 Then
            If Dir("D:\Program Files\NEXUS\Box\Box62\boostmaster.exe") = "" Then
                子函数_提示("软媒优化大师")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box62\boostmaster.exe")
            End If
        ElseIf i = 627 Then
            If Dir("D:\Program Files\NEXUS\Box\Box62\filemaster.exe") = "" Then
                子函数_提示("软媒文件大师")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box62\filemaster.exe")
            End If
        ElseIf i = 631 Then
            If Dir("D:\Program Files\Tools\FX82ES.exe") = "" Then
                子函数_提示("卡西欧科学计算器单文件版")
            Else
                Fun_Shell("D:\Program Files\Tools\FX82ES.exe")
            End If
        ElseIf i = 632 Then
            If Dir("D:\Program Files\NEXUS\Box\Box63\virtualdrivemaster.exe") = "" Then
                子函数_提示("软媒虚拟光驱")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box63\virtualdrivemaster.exe")
            End If
        ElseIf i = 633 Then
            If Dir("D:\Program Files\Tools\winstart.exe") = "" Then
                子函数_提示("windows8开始菜单")
            Else
                Fun_Shell("D:\Program Files\Tools\winstart.exe")
            End If
        ElseIf i = 634 Then
            If Dir("D:\Program Files\NEXUS\Box\Box63\MenuMgr.exe") = "" Then
                子函数_提示("右键菜单管理")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box63\MenuMgr.exe")
            End If
        ElseIf i = 635 Then
            If Dir("D:\Program Files\NEXUS\Box\Box63\SNDA\Finder\Finder.exe") = "" Then
                子函数_提示("盛大光速搜索")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box63\SNDA\Finder\Finder.exe")
            End If
        ElseIf i = 636 Then
            If Dir("D:\Program Files\Tools\Matlab5.3\matlab.exe") = "" Then
                子函数_提示("Matlab极限精简版")
            Else
                Fun_Shell("D:\Program Files\Tools\Matlab5.3\matlab.exe")
            End If
        ElseIf i = 637 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Box63\语音合成\语音合成工具.exe")
        ElseIf i = 641 Then

            Fun_Shell("calc")

        ElseIf i = 642 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Box64\StikyNot.vbs")

        ElseIf i = 643 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Box64\画图.vbs")

        ElseIf i = 644 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Box64\IP.vbs")

        ElseIf i = 711 Then
            If Dir("D:\Program Files\Tools\magicwifi.exe") = "" Then
                子函数_提示("软媒WIFI共享")
            Else
                Fun_Shell("D:\Program Files\Tools\magicwifi.exe")
            End If
        ElseIf i = 712 Then
            If Dir("D:\Program Files\Tools\VPN\") = "" Then
                子函数_提示("VPN代理")
            Else
                Fun_Shell("D:\Program Files\Tools\VPN\")
            End If


        ElseIf i = 713 Then
            If Dir("D:\Program Files\Tools\DNSCrypt Proxy 1.4.0\dnscrypt-winclient.exe") = "" Then
                子函数_提示("DNS保护")
            Else
                Fun_Shell("D:\Program Files\Tools\DNSCrypt Proxy 1.4.0\dnscrypt-winclient.exe")
            End If
        ElseIf i = 714 Then
            If Dir("D:\Program Files\硕鼠\commence.exe") = "" Then
                子函数_提示("硕鼠视频下载器")
            Else
                Fun_Shell("D:\Program Files\硕鼠\commence.exe")
            End If
        ElseIf i = 715 Then

            Fun_Shell("http://www.sojump.com/m/3499620.aspx")

        ElseIf i = 811 Then

            Fun_Shell("netplwiz.exe")

        ElseIf i = 812 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Box81\磁盘管理.vbs")

        ElseIf i = 813 Then

            Fun_Shell("D:\Program Files\NEXUS\Box\Box81\设备管理器.vbs")

        ElseIf i = 814 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Box81\计算机管理.vbs")

        ElseIf i = 821 Then
            If Dir("D:\Program Files\NEXUS\Box\Box82\KMSpico.exe") = "" Then
                子函数_提示("windows激活工具KMS")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box82\KMSpico.exe")
            End If
        ElseIf i = 822 Then
            If Dir("D:\Program Files\DriverGenius\drivergenius.exe") = "" Then
                子函数_提示("驱动精灵免安装版")
            Else
                Fun_Shell("D:\Program Files\DriverGenius\drivergenius.exe")
            End If
        ElseIf i = 823 Then
            If Dir("D:\Program Files\NEXUS\Box\Box82\pcdoctor.exe") = "" Then
                子函数_提示("软媒电脑医生")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box82\pcdoctor.exe")
            End If
        ElseIf i = 824 Then
            If Dir("D:\Program Files\NEXUS\Box\Box82\datarecovery.exe") = "" Then
                子函数_提示("软媒数据恢复")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box82\datarecovery.exe")
            End If
        ElseIf i = 825 Then
            If Dir("D:\Program Files\DiskGenius\diskgenius.exe") = "" Then
                子函数_提示("驱动精灵免安装版")
            Else
                Fun_Shell("D:\Program Files\DiskGenius\diskgenius.exe")
            End If
        ElseIf i = 826 Then
            Fun_Shell("D:\Program Files\NEXUS\Box\Box82\重启资源管理器.vbs")
        ElseIf i = 831 Then
            Fun_Shell("http://111.7.128.33/cache/dlsw.baidu.com/sw-search-sp/soft/dc/23411/dotnetfx35.2792382908.exe?ich_args=34326a8441cc863a8ac0ffad180115fe_7734_0_0_11_5e0f15fae776f25872a85c7c048387d8bb533b3c6c99688148725cd3e3fcf24c_77062a9debe7d16d79e8296329444b08_1_0")
        ElseIf i = 832 Then
            Fun_Shell("http://dl1sw.baidu.com/soft/9b/15910/Microsoft.NET.exe?version=585709662")
        ElseIf i = 833 Then
            Fun_Shell("http://dlsw.baidu.com/sw-search-sp/soft/b9/22370/NDP451-KB2858728-x86-x64.3505182529.exe")
        ElseIf i = 834 Then
            If Dir("D:\Program Files\DirectX Repair V3.0\DirectX Repair.exe") = "" Then
                子函数_提示("DirectX修复工具")
            Else
                Fun_Shell("D:\Program Files\DirectX Repair V3.0\DirectX Repair.exe")
            End If
        ElseIf i = 841 Then
           
            Fun_Shell("http://pan.baidu.com/s/1sjsKGgt")

        ElseIf i = 842 Then
            If Dir("D:\Program Files\NEXUS\Box\Box84\winmaster.exe") = "" Then
                子函数_提示("软媒设置大师")
            Else
                Fun_Shell("D:\Program Files\NEXUS\Box\Box84\winmaster.exe")
            End If
        ElseIf i = 843 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        ElseIf i = 911 Then
            Fun_Shell("http://pan.baidu.com/s/1dDIRDk9")
        ElseIf i = 912 Then
            Fun_Shell("http://pan.baidu.com/s/1pJ8xPxD")
        ElseIf i = 913 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        ElseIf i = 921 Then
            ' Fun_Shell("")
        ElseIf i = 922 Then
            Fun_Shell("http://pan.baidu.com/s/1ntr6YDV")
        ElseIf i = 923 Then
            'Fun_Shell("")
        ElseIf i = 924 Then
            Fun_Shell("http://www.sojump.com/m/3499620.aspx")
        End If
    End Sub

    Private Sub 子函数_定时关机(i As String)
        Dim shutdown, output, tin, min, hour, ts As String
        WshShell.run("shutdown -a", vbHide)
        tin = 文本框_定时关机.Text
        If i = "执行" Then
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


    '=====================================移动拖拽检测====================================
   
    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        子函数_更新时间()

        Roll()
    End Sub
    Private Sub MainWindow_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

        子函数_更新时间()

        Roll()
    End Sub
    Private Sub MainWindow_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles Me.MouseDoubleClick
        If NEXUS_Box.WindowState = Windows.WindowState.Normal Then
            NEXUS_Box.WindowState = Windows.WindowState.Maximized
        ElseIf NEXUS_Box.WindowState = Windows.WindowState.Maximized Then
            NEXUS_Box.WindowState = Windows.WindowState.Normal
        End If
    End Sub

  
    Private Sub 一级区域_提示_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 一级区域_提示.MouseLeftButtonDown
        NEXUS_Box.Opacity = 0.75
        NEXUS_Box.DragMove()
        NEXUS_Box.Opacity = 1
    End Sub

    Private Sub 一级区域_标题_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles 一级区域_标题.MouseLeftButtonDown
        NEXUS_Box.Opacity = 0.75
        NEXUS_Box.DragMove()
        NEXUS_Box.Opacity = 1
    End Sub
   

    '=====================================局部动作检测====================================
    Private Sub 标题按钮1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮1.MouseDown
        If 二级区域_菜单.Visibility = Windows.Visibility.Hidden Then
            二级区域_菜单.Visibility = Windows.Visibility.Visible
        Else
            二级区域_菜单.Visibility = Windows.Visibility.Hidden
        End If
    End Sub
    Private Sub 标题按钮1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseEnter
        边框_按钮1.Visibility = Windows.Visibility.Visible
        If 语言变量 = "英文" Then
            子函数_提示_标题右侧("Menu")
        Else
            子函数_提示_标题右侧("菜单")
        End If

    End Sub

    Private Sub 标题按钮1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮1.MouseLeave
        边框_按钮1.Visibility = Windows.Visibility.Hidden

    End Sub

    Private Sub 标题按钮2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮2.MouseDown
        NEXUS_Box.WindowState = Windows.WindowState.Minimized
    End Sub
    Private Sub 标题按钮2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseEnter
        边框_按钮2.Visibility = Windows.Visibility.Visible
        If 语言变量 = "英文" Then
            子函数_提示_标题右侧("Minimize")
        Else
            子函数_提示_标题右侧("最小化")
        End If

    End Sub

    Private Sub 标题按钮2_MouseLsseave(sender As Object, e As MouseEventArgs) Handles 标题按钮2.MouseLeave
        边框_按钮2.Visibility = Windows.Visibility.Hidden

    End Sub
    Private Sub 标题按钮3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮3.MouseDown
        If NEXUS_Box.WindowState = Windows.WindowState.Normal Then
            NEXUS_Box.WindowState = Windows.WindowState.Maximized
        ElseIf NEXUS_Box.WindowState = Windows.WindowState.Maximized Then
            NEXUS_Box.WindowState = Windows.WindowState.Normal
        End If
    End Sub



    Private Sub 标题按钮3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseEnter
        边框_按钮3.Visibility = Windows.Visibility.Visible
        If NEXUS_Box.WindowState = Windows.WindowState.Normal Then
            If 语言变量 = "英文" Then
                子函数_提示_标题右侧("Maximize")
            Else
                子函数_提示_标题右侧("更大")
            End If

        ElseIf NEXUS_Box.WindowState = Windows.WindowState.Maximized Then
            If 语言变量 = "英文" Then
                子函数_提示_标题右侧("Normal")
            Else
                子函数_提示_标题右侧("还原")
            End If

        End If

    End Sub

    Private Sub 标题按钮3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮3.MouseLeave
        边框_按钮3.Visibility = Windows.Visibility.Hidden

    End Sub
    Private Sub 标题按钮4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题按钮4.MouseDown
        End
    End Sub

    Private Sub 标题按钮4_MouseEnter(sender As Object, e As MouseEventArgs) Handles 标题按钮4.MouseEnter
        边框_按钮4.Visibility = Windows.Visibility.Visible
        If 语言变量 = "英文" Then
            子函数_提示_标题右侧("Close")
        Else
            子函数_提示_标题右侧("关闭")
        End If

    End Sub

    Private Sub 标题按钮4_MouseLeave(sender As Object, e As MouseEventArgs) Handles 标题按钮4.MouseLeave
        边框_按钮4.Visibility = Windows.Visibility.Hidden

    End Sub
    Private Sub 二级区域_右侧标题按钮_MouseLeave(sender As Object, e As MouseEventArgs) Handles 二级区域_右侧标题按钮.MouseLeave

        子函数_提示_标题右侧("0")
    End Sub
    '--------------------------------------------------------------------------
    Private Sub 文本框_搜索全部功能_MouseEnter(sender As Object, e As MouseEventArgs) Handles 文本框_搜索全部功能.MouseEnter
        If 文本框_搜索全部功能.Text = "Search All" Or 文本框_搜索全部功能.Text = "搜索全部功能" Then
            文本框_搜索全部功能.Clear()
            文本框_搜索全部功能.Focus()
        End If
    End Sub

    Private Sub 文本框_搜索全部功能_MouseLeave(sender As Object, e As MouseEventArgs) Handles 文本框_搜索全部功能.MouseLeave
        If 文本框_搜索全部功能.Text = "" Then
            If 语言变量 = "英文" Then
                文本框_搜索全部功能.Text = "Search All"
            Else
                文本框_搜索全部功能.Text = "搜索全部功能"
            End If

        End If
    End Sub

    Private Sub 文本框_搜索全部功能_MouseWheel(sender As Object, e As MouseWheelEventArgs) Handles 文本框_搜索全部功能.MouseWheel
        文本框_搜索全部功能.Clear()
    End Sub


    Private Sub 文本框_意见反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 文本框_意见反馈.MouseDown

        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 二级区域_反馈_MouseEnter(sender As Object, e As MouseEventArgs) Handles 二级区域_反馈.MouseEnter
        文本框_意见反馈_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 二级区域_反馈_MouseLeave(sender As Object, e As MouseEventArgs) Handles 二级区域_反馈.MouseLeave
        文本框_意见反馈_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 按钮_反馈_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_反馈.MouseDown

        Fun_Shell("http://www.sojump.com/m/3499620.aspx")
    End Sub
    Private Sub 按钮_反馈_MouseEnter(sender As Object, e As MouseEventArgs) Handles 按钮_反馈.MouseEnter
        按钮_反馈_Border_.Background = New SolidColorBrush(Color.FromArgb(120, 255, 255, 255))
        按钮_反馈_TextBox_.Foreground = New SolidColorBrush(Color.FromArgb(120, 80, 80, 80))

    End Sub

    Private Sub 按钮_反馈_MouseLeave(sender As Object, e As MouseEventArgs) Handles 按钮_反馈.MouseLeave
        按钮_反馈_Border_.Background = Nothing

        按钮_反馈_TextBox_.Foreground = New SolidColorBrush(Color.FromArgb(120, 255, 255, 255))

    End Sub

    Private Sub 按钮_后台_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_后台.MouseDown
        If 按钮_后台关.Visibility = Windows.Visibility.Visible Then
            按钮_后台关.Visibility = Windows.Visibility.Hidden
            按钮_后台开.Visibility = Windows.Visibility.Visible
            Fun_Shell("C:\Windows\StartupOK.vbs")
        Else
            按钮_后台关.Visibility = Windows.Visibility.Visible
            按钮_后台开.Visibility = Windows.Visibility.Hidden
            Fun_Shell("C:\Windows\StartupCancel.vbs")
        End If
    End Sub

    Private Sub 标题_安装路径_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题_安装路径.MouseDown
        Fun_Shell("D:\Program Files\NEXUS\Setting\ControlSetting\StartupFolder.vbs")
        Fun_Shell("D:\Program Files\NEXUS\")
    End Sub

    Private Sub 标题_更新_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题_更新.MouseDown
        Fun_Shell("http://pan.baidu.com/s/12IKJ8#path=%252F%25E5%25AE%25A2%25E6%2588%25B7%25E7%25AB%25AF")

    End Sub

    Private Sub 标题_源代码_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题_源代码.MouseDown

        Fun_Shell("http://pan.baidu.com/s/1c0tRlIg#path=%252F%25E6%25BA%2590%25E4%25BB%25A3%25E7%25A0%2581")
    End Sub

    Private Sub 标题_卸载_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 标题_卸载.MouseDown

        一级区域_提示.Visibility = Windows.Visibility.Visible
        提示标题.Text = "卸载提示"
        提示内容.Text = "       注意：此操作不可恢复，确认卸载？"
    End Sub


   
  

  

    Private Sub 内容分类1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类1.MouseDown
        子函数_标题选择(1)
    End Sub

    Private Sub 内容分类1_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类1.MouseEnter
        内容分类1_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类1_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类1.MouseLeave
        内容分类1_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类2.MouseDown
        子函数_标题选择(2)
    End Sub

    Private Sub 内容分类2_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类2.MouseEnter
        内容分类2_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类2_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类2.MouseLeave
        内容分类2_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类3_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类3.MouseDown
        子函数_标题选择(3)
    End Sub

    Private Sub 内容分类3_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类3.MouseEnter
        内容分类3_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类3_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类3.MouseLeave
        内容分类3_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类4_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类4.MouseDown
        子函数_标题选择(4)
    End Sub

    Private Sub 内容分类4_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类4.MouseEnter
        内容分类4_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类4_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类4.MouseLeave
        内容分类4_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类5_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类5.MouseDown
        子函数_标题选择(5)
    End Sub

    Private Sub 内容分类5_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类5.MouseEnter
        内容分类5_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类5_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类5.MouseLeave
        内容分类5_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类6_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类6.MouseDown
        子函数_标题选择(6)
    End Sub

    Private Sub 内容分类6_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类6.MouseEnter
        内容分类6_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类6_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类6.MouseLeave
        内容分类6_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类7_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类7.MouseDown
        子函数_标题选择(7)
    End Sub

    Private Sub 内容分类7_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类7.MouseEnter
        内容分类7_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类7_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类7.MouseLeave
        内容分类7_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类8_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类8.MouseDown
        子函数_标题选择(8)
    End Sub

    Private Sub 内容分类8_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类8.MouseEnter
        内容分类8_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类8_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类8.MouseLeave
        内容分类8_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub 内容分类9_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容分类9.MouseDown
        子函数_标题选择(9)
    End Sub

    Private Sub 内容分类9_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容分类9.MouseEnter
        内容分类9_Grid_.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容分类9_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容分类9.MouseLeave
        内容分类9_Grid_.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 按钮_中文_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_中文.MouseDown
        子函数_语言("中文")
        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Language\Chinese.vbs")
        语言切换_中文.Visibility = Windows.Visibility.Visible
        语言切换_英文.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 按钮_英文_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_英文.MouseDown
        子函数_语言("英文")
        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Language\English.vbs")
        语言切换_中文.Visibility = Windows.Visibility.Hidden
        语言切换_英文.Visibility = Windows.Visibility.Visible
    End Sub



    Private Sub 一级区域_内容_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 一级区域_内容.MouseDown
        二级区域_菜单.Visibility = Windows.Visibility.Hidden
    End Sub

    '=========================================内容=============================================
    Private Sub 内容111_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容111.MouseDown
        Fun_Run("111")
    End Sub
    Private Sub 内容112_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容112.MouseDown
        Fun_Run("112")
    End Sub
    Private Sub 内容113_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容113.MouseDown
        Fun_Run("113")
    End Sub
    Private Sub 内容114_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容114.MouseDown
        Fun_Run("114")
    End Sub

    Private Sub 内容114_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容114.MouseEnter
        提示114.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容114_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容114.MouseLeave
        提示114.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容121_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容121.MouseDown
        Fun_Run("121")
    End Sub
    Private Sub 内容122_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容122.MouseDown
        Fun_Run("122")
    End Sub


    '-------------------------------------------------------------------------------------------



    Private Sub 内容211_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容211.MouseDown
        Fun_Run("211")
    End Sub
    Private Sub 内容212_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容212.MouseDown
        Fun_Run("212")
    End Sub
    Private Sub 内容213_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容213.MouseDown
        Fun_Run("213")
    End Sub
    Private Sub 内容214_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容214.MouseDown
        Fun_Run("214")
    End Sub
    Private Sub 内容215_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容215.MouseDown
        Fun_Run("215")
    End Sub
    Private Sub 内容216_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容216.MouseDown
        Fun_Run("216")
    End Sub
    Private Sub 内容217_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容217.MouseDown
        Fun_Run("217")
    End Sub
    Private Sub 内容218_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容218.MouseDown
        Fun_Run("218")
    End Sub
    Private Sub 内容218_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容218.MouseEnter
        提示218.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容218_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容218.MouseLeave
        提示218.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容221_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容221.MouseDown
        Fun_Run("221")
    End Sub
    Private Sub 内容222_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容222.MouseDown
        Fun_Run("222")
    End Sub
    Private Sub 内容223_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容223.MouseDown
        Fun_Run("223")
    End Sub
    Private Sub 内容224_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容224.MouseDown
        Fun_Run("224")
    End Sub

    Private Sub 内容224_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容224.MouseEnter
        提示224.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容224_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容224.MouseLeave
        提示224.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容231_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容231.MouseDown
        Fun_Run("231")
    End Sub
    Private Sub 内容232_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容232.MouseDown
        Fun_Run("232")
    End Sub
    Private Sub 内容233_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容233.MouseDown
        Fun_Run("233")
    End Sub
    Private Sub 内容234_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容234.MouseDown
        Fun_Run("234")
    End Sub
    Private Sub 内容235_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容235.MouseDown
        Fun_Run("235")
    End Sub
    Private Sub 内容236_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容236.MouseDown
        Fun_Run("236")
    End Sub
    Private Sub 内容237_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容237.MouseDown
        Fun_Run("237")
    End Sub

    Private Sub 内容237_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容237.MouseEnter
        提示237.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容237_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容237.MouseLeave
        提示237.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容241_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容241.MouseDown
        Fun_Run("241")
    End Sub
    Private Sub 内容242_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容242.MouseDown
        Fun_Run("242")
    End Sub
    Private Sub 内容243_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容243.MouseDown
        Fun_Run("243")
    End Sub
    Private Sub 内容244_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容244.MouseDown
        Fun_Run("244")
    End Sub

    Private Sub 内容244_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容244.MouseEnter
        提示244.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容244_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容244.MouseLeave
        提示244.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容251_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容251.MouseDown
        Fun_Run("251")
    End Sub
    Private Sub 内容252_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容252.MouseDown
        Fun_Run("252")
    End Sub
    Private Sub 内容253_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容253.MouseDown
        Fun_Run("253")
    End Sub
    Private Sub 内容254_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容254.MouseDown
        Fun_Run("254")
    End Sub

    Private Sub 内容254_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容254.MouseEnter
        提示254.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容254_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容254.MouseLeave
        提示254.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容261_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容261.MouseDown
        Fun_Run("261")
    End Sub
    Private Sub 内容262_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容262.MouseDown
        Fun_Run("262")
    End Sub

    Private Sub 内容262_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容262.MouseEnter
        提示262.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容262_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容262.MouseLeave
        提示262.Visibility = Windows.Visibility.Hidden
    End Sub


    '-------------------------------------------------------------------------------------------


    Private Sub 内容311_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容311.MouseDown
        Fun_Run("311")
    End Sub
    Private Sub 内容312_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容312.MouseDown
        Fun_Run("312")
    End Sub
    Private Sub 内容313_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容313.MouseDown
        Fun_Run("313")
    End Sub


    Private Sub 内容321_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容321.MouseDown
        Fun_Run("321")
    End Sub
    Private Sub 内容322_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容322.MouseDown
        Fun_Run("322")
    End Sub
    Private Sub 内容323_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容323.MouseDown
        Fun_Run("323")
    End Sub
    Private Sub 内容324_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容324.MouseDown
        Fun_Run("324")
    End Sub
    Private Sub 内容325_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容325.MouseDown
        Fun_Run("325")
    End Sub
    Private Sub 内容326_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容326.MouseDown
        Fun_Run("326")
    End Sub
    Private Sub 内容327_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容327.MouseDown
        Fun_Run("327")
    End Sub

    Private Sub 内容328_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容328.MouseDown
        Fun_Run("328")
    End Sub

    Private Sub 内容328_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容328.MouseEnter
        提示328.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容328_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容328.MouseLeave
        提示328.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容331_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容331.MouseDown
        Fun_Run("331")
    End Sub
    Private Sub 内容332_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容332.MouseDown
        Fun_Run("332")
    End Sub
    Private Sub 内容333_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容333.MouseDown
        Fun_Run("333")
    End Sub
    Private Sub 内容334_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容334.MouseDown
        Fun_Run("334")
    End Sub


    Private Sub 内容341_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容341.MouseDown
        Fun_Run("341")
    End Sub
    Private Sub 内容342_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容342.MouseDown
        Fun_Run("342")
    End Sub
    Private Sub 内容343_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容343.MouseDown
        Fun_Run("343")
    End Sub
    Private Sub 内容344_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容344.MouseDown
        Fun_Run("344")
    End Sub
    Private Sub 内容345_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容345.MouseDown
        Fun_Run("345")
    End Sub
    Private Sub 内容346_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容346.MouseDown
        Fun_Run("346")
    End Sub
    Private Sub 内容347_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容347.MouseDown
        Fun_Run("347")
    End Sub
    Private Sub 内容348_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容348.MouseDown
        Fun_Run("348")
    End Sub
    Private Sub 内容351_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容351.MouseDown
        Fun_Run("351")
    End Sub
    Private Sub 内容352_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容352.MouseDown
        Fun_Run("352")
    End Sub
    Private Sub 内容353_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容353.MouseDown
        Fun_Run("353")
    End Sub
    Private Sub 内容354_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容354.MouseDown
        Fun_Run("354")
    End Sub
    Private Sub 内容355_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容355.MouseDown
        Fun_Run("355")
    End Sub
    Private Sub 内容356_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容356.MouseDown
        Fun_Run("356")
    End Sub
    Private Sub 内容357_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容357.MouseDown
        Fun_Run("357")
    End Sub
    Private Sub 内容361_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容361.MouseDown
        Fun_Run("361")
    End Sub
    Private Sub 内容362_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容362.MouseDown
        Fun_Run("362")
    End Sub
    Private Sub 内容363_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容363.MouseDown
        Fun_Run("363")
    End Sub
    Private Sub 内容364_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容364.MouseDown
        Fun_Run("364")
    End Sub
    '---------------------------------------------------------------------------------




    Private Sub 内容411_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容411.MouseDown
        Fun_Run("411")
    End Sub
    Private Sub 内容412_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容412.MouseDown
        Fun_Run("412")
    End Sub
    Private Sub 内容413_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容413.MouseDown
        Fun_Run("413")
    End Sub
    Private Sub 内容413_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容413.MouseEnter
        提示413.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容413_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容413.MouseLeave
        提示413.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容421_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容421.MouseDown
        Fun_Run("421")
    End Sub
    Private Sub 内容422_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容422.MouseDown
        Fun_Run("422")
    End Sub
    Private Sub 内容423_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容423.MouseDown
        Fun_Run("423")
    End Sub
    Private Sub 内容423_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容423.MouseEnter
        提示423.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容423_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容423.MouseLeave
        提示423.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub 内容431_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容431.MouseDown
        Fun_Run("431")
    End Sub
    Private Sub 内容432_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容432.MouseDown
        Fun_Run("432")
    End Sub
    Private Sub 内容433_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容433.MouseDown
        Fun_Run("433")
    End Sub
    Private Sub 内容433_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容433.MouseEnter
        提示433.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容433_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容433.MouseLeave
        提示433.Visibility = Windows.Visibility.Hidden
    End Sub


    '------------------------------------------------------------------------------------




    Private Sub 内容611_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容611.MouseDown
        Fun_Run("611")
    End Sub
    Private Sub 内容612_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容612.MouseDown
        Fun_Run("612")
    End Sub


    Private Sub 内容621_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容621.MouseDown
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            子函数_提示("TuneUp")
        Else
            Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
        End If
    End Sub
    Private Sub 内容622_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容622.MouseDown
        Fun_Run("622")
    End Sub
    Private Sub 内容623_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容623.MouseDown
        Fun_Run("623")
    End Sub
    Private Sub 内容624_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容624.MouseDown
        Fun_Run("624")
    End Sub
    Private Sub 内容625_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容625.MouseDown
        Fun_Run("625")
    End Sub
    Private Sub 内容626_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容626.MouseDown
        Fun_Run("626")
    End Sub
    Private Sub 内容627_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容627.MouseDown
        Fun_Run("627")
    End Sub
    Private Sub 内容631_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容631.MouseDown
        Fun_Run("631")
    End Sub
    Private Sub 内容632_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容632.MouseDown
        Fun_Run("632")
    End Sub
    Private Sub 内容633_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容633.MouseDown
        Fun_Run("633")
    End Sub
    Private Sub 内容634_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容634.MouseDown
        Fun_Run("634")
    End Sub
    Private Sub 内容635_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容635.MouseDown
        Fun_Run("635")
    End Sub
    Private Sub 内容636_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容636.MouseDown
        Fun_Run("636")
    End Sub
    Private Sub 内容637_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容637.MouseDown
        Fun_Run("637")
    End Sub

    Private Sub 内容641_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容641.MouseDown
        Fun_Run("641")
    End Sub
    Private Sub 内容642_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容642.MouseDown

        Fun_Shell("D:\Program Files\NEXUS\Box\Box64\StikyNot.bat")
    End Sub
    Private Sub 内容643_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容643.MouseDown
        Fun_Run("643")
    End Sub
    Private Sub 内容644_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容644.MouseDown
        Fun_Run("644")
    End Sub


    '--------------------------------------------------------------------------------------------




    Private Sub 内容711_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容711.MouseDown
        Fun_Run("711")
    End Sub
    Private Sub 内容712_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容712.MouseDown
        Fun_Run("712")
    End Sub
    Private Sub 内容713_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容713.MouseDown
        Fun_Run("713")
    End Sub
    Private Sub 内容714_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容714.MouseDown
        Fun_Run("714")
    End Sub
    Private Sub 内容715_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容715.MouseDown
        Fun_Run("715")
    End Sub

    Private Sub 内容715_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容715.MouseEnter
        提示715.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容715_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容715.MouseLeave
        提示715.Visibility = Windows.Visibility.Hidden
    End Sub


    '---------------------------------------------------------------------------






    Private Sub 内容811_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容811.MouseDown
        Fun_Run("811")
    End Sub
    Private Sub 内容812_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容812.MouseDown
        Fun_Run("812")
    End Sub
    Private Sub 内容813_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容813.MouseDown
        Fun_Run("813")
    End Sub
    Private Sub 内容814_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容814.MouseDown
        Fun_Run("814")
    End Sub

    Private Sub 内容821_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容821.MouseDown
        Fun_Run("821")
    End Sub
    Private Sub 内容822_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容822.MouseDown
        Fun_Run("822")
    End Sub
    Private Sub 内容823_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容823.MouseDown
        Fun_Run("823")
    End Sub
    Private Sub 内容824_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容824.MouseDown
        Fun_Run("824")
    End Sub
    Private Sub 内容825_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容825.MouseDown
        Fun_Run("825")
    End Sub
    Private Sub 内容826_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容826.MouseDown
        Fun_Run("826")
    End Sub
    Private Sub 内容831_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容831.MouseDown
        Fun_Run("831")
    End Sub
    Private Sub 内容832_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容832.MouseDown
        Fun_Run("831")
    End Sub
    Private Sub 内容833_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容833.MouseDown
        Fun_Run("833")
    End Sub
    Private Sub 内容834_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容834.MouseDown
        Fun_Run("834")
    End Sub
    Private Sub 内容841_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容841.MouseDown
        Fun_Run("841")
    End Sub
    Private Sub 内容842_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容842.MouseDown
        Fun_Run("842")
    End Sub
    Private Sub 内容843_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容843.MouseDown
        Fun_Run("843")
    End Sub

    Private Sub 内容843_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容843.MouseEnter
        提示843.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容843_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容843.MouseLeave
        提示843.Visibility = Windows.Visibility.Hidden
    End Sub

    '--------------------------------------------------------------------





    Private Sub 内容911_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容911.MouseDown
        Fun_Run("911")
    End Sub
    Private Sub 内容912_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容912.MouseDown
        Fun_Run("912")
    End Sub
    Private Sub 内容913_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容913.MouseDown
        Fun_Run("913")
    End Sub
    Private Sub 内容913_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容913.MouseEnter
        提示913.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容913_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容913.MouseLeave
        提示913.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 内容921_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容921.MouseDown
        Fun_Run("921")
    End Sub
    Private Sub 内容922_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容922.MouseDown
        Fun_Run("922")
    End Sub
    Private Sub 内容923_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容923.MouseDown
        Fun_Run("923")
    End Sub
    Private Sub 内容924_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 内容924.MouseDown
        Fun_Run("924")
    End Sub

    Private Sub 内容924_MouseEnter(sender As Object, e As MouseEventArgs) Handles 内容924.MouseEnter
        提示924.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub 内容924_MouseLeave(sender As Object, e As MouseEventArgs) Handles 内容924.MouseLeave
        提示924.Visibility = Windows.Visibility.Hidden
    End Sub






    Private Sub 快捷1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 快捷1.MouseDown
        If Dir("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk") = "" Then
            子函数_提示("TuneUp")
        Else
            Fun_Shell("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\TuneUp Utilities 2014\All functions\TuneUp 1-Click Maintenance.lnk")
        End If
    End Sub
    Private Sub 快捷2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 快捷2.MouseDown
        If Dir("D:\Program Files\NEXUS\Box\Box63\SNDA\Finder\Finder.exe") = "" Then
            子函数_提示("光速搜索")
        Else

            Fun_Shell("D:\Program Files\NEXUS\Box\Box63\SNDA\Finder\Finder.exe")
        End If
    End Sub

    Private Sub 按钮_提示取消_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_提示取消.MouseDown
        一级区域_提示.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub 按钮_提示确定_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_提示确定.MouseDown
        一级区域_提示.Visibility = Windows.Visibility.Hidden
        子函数_提示确定()
    End Sub

  
    Private Sub 按钮_定时关机_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_定时开.MouseDown
        子函数_定时关机("执行")
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

    Private Sub 按钮_定时关_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles 按钮_定时关.MouseDown
        子函数_定时关机("取消")
    End Sub

 
    Private Sub Theme01_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme01.MouseDown
        子函数_主题(1)
        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme01.vbs")
    End Sub
    Private Sub Theme02_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme02.MouseDown
        子函数_主题(2)
        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme02.vbs")

    End Sub
    Private Sub Theme03_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme03.MouseDown
        子函数_主题(3)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme03.vbs")
    End Sub
    Private Sub Theme04_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme04.MouseDown
        子函数_主题(4)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme04.vbs")
    End Sub
    Private Sub Theme05_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme05.MouseDown
        子函数_主题(5)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme05.vbs")
    End Sub
    Private Sub Theme06_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme06.MouseDown
        子函数_主题(6)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme06.vbs")
    End Sub
    Private Sub Theme07_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme07.MouseDown
        子函数_主题(7)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme07.vbs")
    End Sub
    Private Sub Theme08_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme08.MouseDown
        子函数_主题(8)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme08.vbs")
    End Sub
    Private Sub Theme09_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme09.MouseDown
        子函数_主题(9)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme09.vbs")
    End Sub
    Private Sub Theme10_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme10.MouseDown
        子函数_主题(10)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme10.vbs")
    End Sub
    Private Sub Theme11_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme11.MouseDown
        子函数_主题(11)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme11.vbs")
    End Sub
    Private Sub Theme12_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme12.MouseDown
        子函数_主题(12)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme12.vbs")
    End Sub
    Private Sub Theme13_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme13.MouseDown
        子函数_主题(13)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme13.vbs")
    End Sub
    Private Sub Theme14_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme14.MouseDown
        子函数_主题(14)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme14.vbs")
    End Sub
    Private Sub Theme15_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme15.MouseDown
        子函数_主题(15)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme15.vbs")
    End Sub
    Private Sub Theme16_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme16.MouseDown
        子函数_主题(16)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme16.vbs")
    End Sub
    Private Sub Theme17_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme17.MouseDown
        子函数_主题(17)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme17.vbs")
    End Sub
    Private Sub Theme18_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme18.MouseDown
        子函数_主题(18)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme18.vbs")
    End Sub
    Private Sub Theme19_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme19.MouseDown
        子函数_主题(19)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme19.vbs")
    End Sub
    Private Sub Theme20_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme20.MouseDown
        子函数_主题(20)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme20.vbs")
    End Sub
    Private Sub Theme21_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme21.MouseDown
        子函数_主题(21)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme21.vbs")
    End Sub
    Private Sub Theme22_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Theme22.MouseDown
        子函数_主题(22)

        Fun_Shell("D:\Program Files\NEXUS\Setting\UserSetting\Themes\Theme22.vbs")
    End Sub
  


   
End Class

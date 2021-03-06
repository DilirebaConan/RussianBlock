﻿Public Class GameForm
    Private _gamePadGraphics As Graphics  ' 画板：游戏面板
    Private _nextBrickGraphics As Graphics  ' 画板：下一个砖块
    Private _console As GameConsole  ' 游戏主机

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' 初始化游戏面板的网格线
    Private Sub InitializeGrid()
        GamePadGraphics = PN_GamePad.CreateGraphics  ' 获取画板

        Dim brush As SolidBrush = New SolidBrush(ConstantData.ColorGridLine)  ' 生成画刷

        ' 画边框
        GamePadGraphics.FillRectangle(brush, 0, 0, 1, ConstantData.SizeHeight)
        GamePadGraphics.FillRectangle(brush, 0, 0, ConstantData.SizeWidth, 1)
        GamePadGraphics.FillRectangle(brush, ConstantData.SizeWidth - 1, 0, 1, ConstantData.SizeHeight)
        GamePadGraphics.FillRectangle(brush, 0, ConstantData.SizeHeight - 1, ConstantData.SizeWidth, 1)

        ' 画网格线
        ' 画水平网格线
        For row As Integer = 1 To ConstantData.CountVertical
            GamePadGraphics.FillRectangle(brush, 0, ConstantData.Delta * row - 1, ConstantData.SizeWidth, 2)
        Next
        ' 画垂直网格线
        For collumn As Integer = 1 To ConstantData.CountHorizon
            GamePadGraphics.FillRectangle(brush, ConstantData.Delta * collumn - 1, 0, 2, ConstantData.SizeHeight)
        Next

    End Sub

    ' 开始
    Private Sub MI_Start_Click(sender As Object, e As EventArgs) Handles MI_Start.Click
        InitializeGrid()  ' 初始化游戏面板的网格线
        Console = New GameConsole(Me)  ' 新建游戏主机实例化对象

        Console.InitConsole()  ' 初始化：游戏主机
        Console.InitBlockList()  ' 游戏面板的方块状态信息的集合

        Console.Start()  ' 游戏开始
        MI_Start.Enabled = False
        TI_Game.Enabled = True

    End Sub

    Public Property GamePadGraphics As Graphics
        Get
            Return _gamePadGraphics
        End Get
        Set(value As Graphics)
            _gamePadGraphics = value
        End Set
    End Property

    Public Property NextBrickGraphics As Graphics
        Get
            Return _nextBrickGraphics
        End Get
        Set(value As Graphics)
            _nextBrickGraphics = value
        End Set
    End Property

    Public Property Console As GameConsole
        Get
            Return _console
        End Get
        Set(value As GameConsole)
            _console = value
        End Set
    End Property

    ' 计时器
    Private Sub TI_Game_Tick(sender As Object, e As EventArgs) Handles TI_Game.Tick
        Console.Run()
    End Sub

    ' 关于游戏
    Private Sub MI_AboutGame_Click(sender As Object, e As EventArgs) Handles MI_AboutGame.Click
        MessageBox.Show("使用VB编写的俄罗斯方块。" & vbCrLf & "@Author 李舟", "俄罗斯方块")
    End Sub

    ' 暂停
    Private Sub MI_Pause_Click(sender As Object, e As EventArgs) Handles MI_Pause.Click
        TI_Game.Enabled = False
    End Sub
End Class

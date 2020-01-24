﻿' 【砖块】父类
Public Class Brick

    Private _alpha As Block
    Private _beta As Block
    Private _gamma As Block
    Private _delte As Block
    Private _color As Color
    Private _graphics As Graphics
    Private _brush As SolidBrush

    Public Sub New(
                  paramAlpha As Block,
                  paramColor As Color,
                  paramGraphics As Graphics,
                  paramBrush As SolidBrush)
        Alpha = paramAlpha
        Color = paramColor
        Graphics = paramGraphics
        Brush = paramBrush
    End Sub

    ' 砖块下沉
    Public Sub Sink()
        Move(ConstantData.Direction.Down)
    End Sub

    ' 砖块移动
    Public Sub Move(direction As Integer)
        Select Case direction
            Case ConstantData.Direction.Down  ' 向下移动
                ' 四个砖块向下移动一个方块的距离
                Alpha.Locating.Offset(0, ConstantData.MovingDelta)
                Beta.Locating.Offset(0, ConstantData.MovingDelta)
                Gamma.Locating.Offset(0, ConstantData.MovingDelta)
                Delte.Locating.Offset(0, ConstantData.MovingDelta)
            Case ConstantData.Direction.Left  ' 向左移动
                ' 四个砖块向左移动一个方块的距离
                Alpha.Locating.Offset(-ConstantData.MovingDelta, 0)
                Beta.Locating.Offset(-ConstantData.MovingDelta, 0)
                Gamma.Locating.Offset(-ConstantData.MovingDelta, 0)
                Delte.Locating.Offset(-ConstantData.MovingDelta, 0)
            Case ConstantData.Direction.Right  ' 向右移动
                ' 四个砖块向右移动一个方块的距离
                Alpha.Locating.Offset(ConstantData.MovingDelta, 0)
                Beta.Locating.Offset(ConstantData.MovingDelta, 0)
                Gamma.Locating.Offset(ConstantData.MovingDelta, 0)
                Delte.Locating.Offset(ConstantData.MovingDelta, 0)
        End Select
    End Sub

    ' 砖块旋转（顺时针）
    Public Sub Whilr()

    End Sub

    Public Property Alpha As Block
        Get
            Return _alpha
        End Get
        Set(value As Block)
            _alpha = value
        End Set
    End Property

    Public Property Beta As Block
        Get
            Return _beta
        End Get
        Set(value As Block)
            _beta = value
        End Set
    End Property

    Public Property Gamma As Block
        Get
            Return _gamma
        End Get
        Set(value As Block)
            _gamma = value
        End Set
    End Property

    Public Property Delte As Block
        Get
            Return _delte
        End Get
        Set(value As Block)
            _delte = value
        End Set
    End Property

    Public Property Graphics As Graphics
        Get
            Return _graphics
        End Get
        Set(value As Graphics)
            _graphics = value
        End Set
    End Property

    Public Property Brush As SolidBrush
        Get
            Return _brush
        End Get
        Set(value As SolidBrush)
            _brush = value
        End Set
    End Property

    Public Property Color As Color
        Get
            Return _color
        End Get
        Set(value As Color)
            _color = value
        End Set
    End Property

End Class

﻿' 正方形砖块
Public NotInheritable Class SquareBrick
    Inherits Brick  ' 继承【Brick】父类

    ' 构造函数
    Public Sub New(
                      paramAlpha As Block,
                      paramColor As Color,
                      paramGraphics As Graphics,
                      paramBrush As SolidBrush)
        MyBase.New(paramAlpha, paramColor, paramGraphics, paramBrush)  ' 调用父类方法

        Dim locatingBeta As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y)
        Beta = New Block(locatingBeta, Alpha.Color, Graphics, Brush)
        Dim locatingGamma As Point = New Point(Alpha.Locating.X, Alpha.Locating.Y + ConstantData.Delta)
        Gamma = New Block(locatingGamma, Alpha.Color, Graphics, Brush)
        Dim locatingDelta As Point = New Point(Alpha.Locating.X + ConstantData.Delta, Alpha.Locating.Y + ConstantData.Delta)
        delta = New Block(locatingDelta, Alpha.Color, Graphics, Brush)

    End Sub

    ' 砖块下沉
    Public Overrides Sub Sink()
        DoErase()  ' 擦除砖块
        MyBase.Sink()  ' 调用父类方法
        DrawSelf()  ' 绘制砖块
    End Sub

    ' 砖块旋转（顺时针）
    Public Overrides Sub Whirl(blockList As ArrayList)
        ' 正方形砖块不需要做旋转操作
    End Sub

End Class

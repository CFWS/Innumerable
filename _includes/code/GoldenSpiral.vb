Imports System.Drawing
Module GoldenSpiral

    Sub Main()
        Dim Phi As Double = (1 + Math.Sqrt(5)) / 2

        Using bmp As New Drawing.Bitmap(3860, 2180), Graphics As Drawing.Graphics = Drawing.Graphics.FromImage(bmp)

            ' Original square
            Dim TopLeft As New Point(0, 0)
            Dim TopRight As New Point(3840, 0)
            Dim BottomLeft As New Point(0, 2160)
            Dim BottomRight As New Point(3840, 2160)

            Dim Min As Boolean = True
            Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            For i = 0 To 6
                Dim CurrentLength As Double = TopRight.X - TopLeft.X
                Dim CurrentHeight As Double = BottomRight.Y - TopRight.Y

                'Horizontal lines
                Dim AHorizontal As Double = CurrentLength / (Phi + 1)
                Dim BHorizontal As Double = CurrentLength - AHorizontal

                ' Vertical Line
                Dim AVer As Double = CurrentHeight / (Phi + 1)
                Dim BVer As Double = CurrentHeight - AVer

                If Min = True Then
                    ' First part of curve
                    Graphics.DrawArc(Pens.White, New Rectangle(New Point(TopLeft.X + 10, TopLeft.Y + 10), New Size(BHorizontal * 2, CurrentHeight * 2)), 180, 90)

                    ' Update square
                    BottomLeft = New Point(Math.Floor(TopLeft.X + BHorizontal), BottomLeft.Y)
                    TopLeft = New Point(Math.Floor(TopLeft.X + BHorizontal), TopLeft.Y)

                    Graphics.DrawArc(Pens.White, New Rectangle(New Point(TopLeft.X - (CurrentLength - BHorizontal) + 10, TopLeft.Y + 10), New Size((CurrentLength - BHorizontal) * 2, BVer * 2)), -90, 90)

                    TopRight = New Point(TopRight.X, Math.Floor(TopLeft.Y + BVer))
                    TopLeft = New Point(TopLeft.X, Math.Floor(TopLeft.Y + BVer))

                    Min = False
                Else
                    Graphics.DrawArc(Pens.White, New Rectangle(New Point(TopLeft.X - (BHorizontal - AHorizontal) + 10, TopLeft.Y - CurrentHeight + 10), New Size(BHorizontal * 2, CurrentHeight * 2)), 90, -90)

                    BottomRight = New Point(Math.Floor(TopLeft.X + AHorizontal), BottomLeft.Y)
                    TopRight = New Point(Math.Floor(TopLeft.X + AHorizontal), TopLeft.Y)

                    Graphics.DrawArc(Pens.White, New Rectangle(New Point(TopLeft.X + 10, TopLeft.Y - (BVer - AVer) + 10), New Size(AHorizontal * 2, (CurrentHeight - AVer) * 2)), 90, 90)

                    BottomLeft = New Point(Math.Floor(BottomLeft.X), Math.Floor(TopLeft.Y + AVer))
                    BottomRight = New Point(Math.Floor(BottomRight.X), Math.Floor(TopLeft.Y + AVer))

                    Min = True
                End If
            Next

            'Save Curve
            bmp.Save("GoldenSpiral.bmp", Imaging.ImageFormat.Bmp)
        End Using
    End Sub

End Module
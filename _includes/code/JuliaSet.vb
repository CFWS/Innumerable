Module JuliaSet
    Sub Main()
        Using BMP As New Drawing.Bitmap(5000, 5000), bmpgraphics = Drawing.Graphics.FromImage(BMP)
            For i = 0 To 5000 - 1
                For j = 0 To 5000 - 1
                    Dim Real As Double = 0.0008 * i - 2
                    Dim Complex As Double = 0.0008 * j - 2
                    Dim Properties As Escape = Escapes(New ComplexNumber(Real, Complex))

                    'Plot point if it has escaped
                    If Properties.Escaped = True Then BMP.SetPixel(i, j, New HSBColour(-3.5 * Math.Sqrt(Properties.Iterations) + 30, 1, 1).HSBToRGB)
                Next
            Next

            BMP.Save("FilledJulia.bmp", Drawing.Imaging.ImageFormat.Bmp)
        End Using
    End Sub

    Function Escapes(Current As ComplexNumber) As Escape
        ' z^2 + c
        Dim C As New ComplexNumber(-0.1259259, -0.7851851)
        'Fixed C Value
        Dim PreviousValues As New System.Collections.Generic.List(Of ComplexNumber)

        For iterations = 0 To 1000
            '1000 iterations
            Current = Current.Squared.Add(C)
            If Current.Modulus > 4 Then Return New Escape(True, iterations)
        Next
        Return (New Escape(False, -1))
    End Function
End Module

Class Escape
    Public Property Escaped As Boolean = False
    Public Property Iterations As Integer

    Sub New(E As Boolean, I As Integer)
        Escaped = E
        Iterations = I
    End Sub
End Class

Class ComplexNumber
    Public Property Real As Double
    Public Property Complex As Double
    Sub New(R As Double, C As Double)
        Real = R
        Complex = C
    End Sub
    Function Squared() As ComplexNumber
        Dim RealTemp As Double = Real * Real - Complex * Complex
        Complex = 2 * Real * Complex
        Real = RealTemp
        Return New ComplexNumber(Real, Complex)
    End Function
    Function Modulus() As Double
        Return Real * Real + Complex * Complex
    End Function
    Function Add(Num As ComplexNumber) As ComplexNumber
        Return New ComplexNumber(Real + Num.Real, Complex + Num.Complex)
    End Function
End Class
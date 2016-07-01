Module MandelbrotSet

    Sub Main()
        Dim sw As New System.Diagnostics.Stopwatch
        sw.Start()
        Using BMP As New Drawing.Bitmap(1000, 1000), bmpgraphics = Drawing.Graphics.FromImage(BMP)
            For i = 0 To 1000 - 1
                For j = 0 To 1000 - 1
                    Dim Real As Double = 0.00000147602 * i - 0.74291189
                    'Range
                    Dim Complex As Double = 0.00000147602 * j + 0.13262005

                    Dim Properties As Escape = Escapes(New ComplexNumber(Real, Complex))
                    If Properties.Escaped = True Then BMP.SetPixel(i, j, New HSBColour(0.36 * Properties.Iterations, 0.7, 0.7).HSBToRGB)
                    'Draw if it has escaped
                Next
                Console.WriteLine(i)
            Next

            BMP.Save("Mandelbrot.bmp", Drawing.Imaging.ImageFormat.Bmp)
            Console.WriteLine(sw.ElapsedMilliseconds)

            Console.ReadLine()
        End Using
    End Sub


    Function Escapes(C As ComplexNumber) As Escape
        ' z^2 + c

        Dim Current As New ComplexNumber(0, 0)
        'Start at 0
        
        For iterations = 0 To 1000
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
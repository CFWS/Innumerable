Module Buddhabrot

    Sub Main()
        Dim Points(4999, 4999) As Integer

        Dim rnd As New Random
        ' Random Value

        For i = 0 To 10000000
            Dim TempPoints As New System.Collections.Generic.List(Of ComplexNumber)

            Dim Real As Decimal = rnd.NextDouble * 4 - 2
            Dim Complex As Decimal = rnd.NextDouble * 4 - 2
            ' NextDouble is between 0 and 1, needs to be between -2 and 2
            If Escaped(New ComplexNumber(Real, Complex), TempPoints) = False Then
                ' if it returns False, restart loop
                i -= 1
                Continue For
            End If
            For Each Current In TempPoints
                Points(Current.Real, Current.Complex) += 1
            Next
            ' Update array
            Console.WriteLine(i)
        Next

        Dim max As Integer = 0
        For j = 0 To 4999
            For k = 0 To 4999
                If Points(j, k) > 0 Then Points(j, k) = Math.Log(Points(j, k))
                If Points(j, k) > max Then max = Points(j, k)
                ' Find max value
            Next
        Next

        Using BMP As New Drawing.Bitmap(5000, 5000)
            For j = 0 To 4999
                For k = 0 To 4999
                    BMP.SetPixel(j, k, New HSBColour(17, 0.97, 1 / max * Points(j, k)).HSBToRGB)
                    ' Plot points
                Next
            Next

            BMP.Save("Buddhabrot.bmp", Drawing.Imaging.ImageFormat.Bmp)
        End Using
    End Sub

    Private Function Escaped(C As ComplexNumber, ByRef List As System.Collections.Generic.List(Of ComplexNumber)) As Boolean
        ' z^2 + c
        List.Clear()

        Dim Current As New ComplexNumber(0, 0)

        For iterations = 0 To 1000
            Current = Current.Squared.Add(C)
            'Z^2 + C
            If Current.Modulus > 4 Then Return False
            ' Modulus is greater then 2
            List.Add(New ComplexNumber(1250 * (Current.Real + 2), 1250 * (Current.Complex + 2)))

        Next

        Return True
    End Function


End Module
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
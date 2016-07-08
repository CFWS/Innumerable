Module Buddhabrot

    Sub Main()
        Dim Points(4999, 4999) As Integer
        Dim rnd As New Random

        For i = 0 To 10000000
            Dim TempPoints As New System.Collections.Generic.List(Of ComplexNumber)
            ' NextDouble is between 0 and 1, needs to be between -2 and 2
            Dim Real As Decimal = rnd.NextDouble * 4 - 2
            Dim Complex As Decimal = rnd.NextDouble * 4 - 2

            ' if it returns False, restart loop
            If Escaped(New ComplexNumber(Real, Complex), TempPoints) = False Then
                i -= 1
                Continue For
            End If

            ' Update array
            For Each Current In TempPoints
                Points(Current.Real, Current.Complex) += 1
            Next

            Console.WriteLine(i)
        Next

        ' Find max value
        Dim max As Integer = 0
        For j = 0 To 4999
            For k = 0 To 4999
                If Points(j, k) > 0 Then Points(j, k) = Math.Log(Points(j, k))
                If Points(j, k) > max Then max = Points(j, k)
            Next
        Next

        Using BMP As New Drawing.Bitmap(5000, 5000)
            For j = 0 To 4999
                For k = 0 To 4999
                    ' Plot points
                    BMP.SetPixel(j, k, New HSBColour(17, 0.97, 1 / max * Points(j, k)).HSBToRGB)
                Next
            Next

            BMP.Save("Buddhabrot.bmp", Drawing.Imaging.ImageFormat.Bmp)
        End Using
    End Sub

    Private Function Escaped(C As ComplexNumber, ByRef List As System.Collections.Generic.List(Of ComplexNumber)) As Boolean
        ' z^2 + c
        List.Clear()
        ' Starting Value of 0
        Dim Current As New ComplexNumber(0, 0)

        For iterations = 0 To 1000
            ' Square Value and add C
            Current = Current.Squared.Add(C)
            ' Modulus Squared is greater then 4
            If Current.Modulus > 4 Then Return False
            ' Update Range to fit Bitmap and add to list
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
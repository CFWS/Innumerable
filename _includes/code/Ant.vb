Module Ant

    Dim pi As String = My.Resources.Pi

    ' Pi as string
    Dim Density(3839, 2159) As Integer
    ' Array of values
    Dim Orientation As String = "North"
    ' Orientation
    Sub Main()

        Using BMP As New Drawing.Bitmap(3840, 2160)
            ' Bitmap picture
            Dim x As Integer = 1920
            Dim y As Integer = 1080
            ' Starting Co-ords
            For Each i In pi
                If Val(i) Mod 2 = 0 Then
                    ' Turn Right
                    If Orientation = "North" Then
                        y -= 1
                        Orientation = "East"
                    ElseIf Orientation = "East" Then
                        x -= 1
                        Orientation = "South"
                    ElseIf Orientation = "South" Then
                        y += 1
                        Orientation = "West"
                    Else
                        x += 1
                        Orientation = "North"
                    End If
                Else
                    'Turn Left
                    If Orientation = "North" Then
                        y -= 1
                        Orientation = "West"
                    ElseIf Orientation = "East" Then
                        x -= 1
                        Orientation = "North"
                    ElseIf Orientation = "South" Then
                        y += 1
                        Orientation = "East"
                    Else
                        x += 1
                        Orientation = "South"
                    End If
                End If

                If x < 0 Then x = 3839
                If y < 0 Then y = 2159
                If x >= 3840 Then x = 0
                If y >= 2160 Then y = 0
                ' Wrap around edges

                Density(x, y) += 1
                ' Update array
            Next
            Dim max As Double = 0
            For i = 0 To 3840 - 1
                For j = 0 To 2160 - 1
                    If Density(i, j) = 0 Then Continue For
                    Dim colour As New HSBColour(250, 0.5, 0.00549450549 * Density(i, j) + 0.15)
                    ' Brightness based on desnity
                    BMP.SetPixel(i, j, colour.HSBToRGB)
                Next
            Next
            BMP.Save("Ant.bmp", Drawing.Imaging.ImageFormat.Bmp)
        End Using
    End Sub

End Module
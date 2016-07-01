Module Carpet

    Sub Main()
        Using bmp As New Drawing.Bitmap(3000, 3000), graphics As Drawing.Graphics = Drawing.Graphics.FromImage(bmp)

            Dim Squares, NewSquares As New Collections.Generic.List(Of Drawing.Rectangle)
   
            Squares.Add(New Drawing.Rectangle(New Drawing.Point(0, 0), New Drawing.Size(3000, 3000)))
            NewSquares.Add(New Drawing.Rectangle(New Drawing.Point(0, 0), New Drawing.Size(3000, 3000)))
            For i = 0 To 4
                For Each Item In Squares
                    Dim Height As Double = Item.Size.Height / 3
                    Dim Width As Double = Item.Size.Width / 3
                    Dim X As Double = Item.X

                    Dim Square1 As New Drawing.Rectangle(New Drawing.Point(Item.X, Item.Y), New Drawing.Size(Height, Width))
                    Dim Square2 As New Drawing.Rectangle(New Drawing.Point(Item.X, Item.Y + Height), New Drawing.Size(Height, Width))
                    Dim Square3 As New Drawing.Rectangle(New Drawing.Point(Item.X, Item.Y + 2 * Height), New Drawing.Size(Height, Width))

                    Dim Square4 As New Drawing.Rectangle(New Drawing.Point(Item.X + Width, Item.Y), New Drawing.Size(Height, Width))
                    Dim Hole As New Drawing.Rectangle(New Drawing.Point(Item.X + Width, Item.Y + Height), New Drawing.Size(Height, Width))
                    Dim Square6 As New Drawing.Rectangle(New Drawing.Point(Item.X + Width, Item.Y + 2 * Height), New Drawing.Size(Height, Width))

                    Dim Square7 As New Drawing.Rectangle(New Drawing.Point(Item.X + Width * 2, Item.Y), New Drawing.Size(Height, Width))
                    Dim Square8 As New Drawing.Rectangle(New Drawing.Point(Item.X + Width * 2, Item.Y + Height), New Drawing.Size(Height, Width))
                    Dim Square9 As New Drawing.Rectangle(New Drawing.Point(Item.X + Width * 2, Item.Y + 2 * Height), New Drawing.Size(Height, Width))
                    ' The 9 Squares in current grid.

                    NewSquares.Remove(Item)
                    NewSquares.Add(Square1)
                    NewSquares.Add(Square2)
                    NewSquares.Add(Square3)
                    NewSquares.Add(Square4)
                    NewSquares.Add(Square6)
                    NewSquares.Add(Square7)
                    NewSquares.Add(Square8)
                    NewSquares.Add(Square9)
                    'Add new squares apart from hole, to iterate through

                    graphics.FillRectangle(Drawing.Brushes.White, Hole)
                Next
                For Each item In NewSquares
                    Squares.Add(item)
                Next
                NewSquares.Clear()
                'Update array
            Next

            bmp.Save("SCarpet.bmp", Drawing.Imaging.ImageFormat.Bmp)
        End Using
    End Sub

End Module
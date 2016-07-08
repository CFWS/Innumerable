Module Sierpinski_Triangle

    Sub Main()
        Using bmp As New Drawing.Bitmap(1000, 1000), graphics As Drawing.Graphics = Drawing.Graphics.FromImage(bmp)
            Dim Points As Drawing.Point() = {New Drawing.Point(500, 0), New Drawing.Point(1000, 1000), New Drawing.Point(0, 1000)}
            graphics.FillPolygon(Drawing.Brushes.White, Points)

            Dim Triangles As New System.Collections.Generic.List(Of Drawing.Point())
            Triangles.Add(Points)

            Dim NewTriangles As New System.Collections.Generic.List(Of Drawing.Point())
            NewTriangles.Add(Points)

            For i = 0 To 7
                For Each item In Triangles
                    ' Work out the hole based on three vertexs
                    Dim Vertex1 As New System.Drawing.Point((item(0).X + item(1).X) / 2, (item(0).Y + item(1).Y) / 2)
                    Dim Vertex2 As New System.Drawing.Point((item(1).X + item(2).X) / 2, (item(1).Y + item(2).Y) / 2)
                    Dim Vertex3 As New System.Drawing.Point((item(0).X + item(2).X) / 2, (item(0).Y + item(2).Y) / 2)
                    Dim Hole As Drawing.Point() = {Vertex1, Vertex2, Vertex3}

                    'Work out other three triangles
                    Dim Triangle1 As Drawing.Point() = {item(1), Vertex1, Vertex2}
                    Dim Triangle2 As Drawing.Point() = {item(2), Vertex2, Vertex3}
                    Dim Triangle3 As Drawing.Point() = {item(0), Vertex3, Vertex1}

                    'Add to array to be iterated over
                    NewTriangles.Remove(item)
                    NewTriangles.Add(Triangle1)
                    NewTriangles.Add(Triangle2)
                    NewTriangles.Add(Triangle3)

                    graphics.FillPolygon(Drawing.Brushes.Black, Hole)
                Next

                ' Save Different steps
                bmp.Save(i & ".bmp", Drawing.Imaging.ImageFormat.Bmp)

                For Each item In NewTriangles
                    Triangles.Add(item)
                Next

                'Update array
                NewTriangles.Clear()
            Next

        End Using
    End Sub
End Module
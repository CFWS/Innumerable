boolean AntGrid[][] = new boolean[1080][720];
int AntGridColour[][] = new int[1080][720];
int iterations = 25000;
boolean computefinished;
void setup()
{
  size(1080, 720);
  background(0);
  colorMode(HSB, 360);
  compute();
}
void draw()
{
  if (computefinished == true) {
    for (int i=0; i < 1080; i++) {
      for (int j=0; j < 720; j++) {
        if (AntGrid[i][j] == true)
        {
          stroke(0 + AntGridColour[i][j] * 1.5, AntGridColour[i][j] * 20 + 220, 360);
          point(i, j);
        }
      }
    }
    save("langdon.tif");
  }
}
int x, y;
int Orientation = 1; // North - 1, East - 2, South - 3, West - 4
void compute()
{
  x = 540; 
  y = 360;
  for (int i = 0; i<iterations; i++)
  {
    if (AntGrid[x][y] == false) // Turn 90deg Anticlockwise
    {
      if (Orientation == 4) Orientation = 3;
      else if (Orientation == 1) Orientation = 4;
      else if (Orientation == 2) Orientation = 1;
      else if (Orientation == 3) Orientation = 2;
      AntGrid[x][y] = true;
      AntGridColour[x][y] += 1;
    } else // Turn 90deg Clockwise
    {
      if (Orientation == 1) Orientation = 2;
      else if (Orientation == 2) Orientation = 3;
      else if (Orientation == 4) Orientation = 1;
      else if (Orientation == 3) Orientation = 4;
      AntGrid[x][y] = false;
    }
    // Move forward one block
    if (Orientation == 1) y = y - 1; // Closer to Origin (Top-Left)
    if (Orientation == 2) x = x + 1;
    if (Orientation == 4) x = x - 1;
    if (Orientation == 3) y = y + 1;
  }
  computefinished = true;
}
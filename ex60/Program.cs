void FillMatrix(int[,,] matrix)
{
  int i = 0;
  for(int x = 0; x < matrix.GetLength(0); x++)
  {
    for(int y = 0; y < matrix.GetLength(1); y++)
    {
      for(int z = 0; z < matrix.GetLength(2); z ++)
      {
        matrix[x, y, z] = 99 - i;
        i += 1;
      }
    }
  }
}

void PrintMatrix(int[,,] matrix)
{
  for(int x = 0; x < matrix.GetLength(0); x ++)
  {
    for(int y = 0; y < matrix.GetLength(1); y++)
    {
      for(int z = 0; z < matrix.GetLength(2); z++)
        Console.Write($"{matrix[x,y,z]} ({x}, {y}, {z}) \t");
      Console.WriteLine();
    }
    
  }
}



Console.Clear();
Console.Write("Введите размер массива: ");
int [] size = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
FillMatrix(matrix);
PrintMatrix(matrix);
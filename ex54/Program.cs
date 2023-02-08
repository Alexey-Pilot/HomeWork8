void PrintMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i,j]} \t");
      }
      Console.WriteLine();
  }
}

int [] SortRow(int row, int[,] matrix)
{
  int[] xrow = new int[matrix.GetLength(1)];
  for(int i = 0; i < matrix.GetLength(1); i++)
  {
    xrow[i] = matrix[row, i];
  }
  Array.Sort(xrow);
  Array.Reverse(xrow);
  return xrow;
}

void SortByRows(int[,]matrix)
{
  int[] SortedRow = new int[matrix.GetLength(1)];
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    SortedRow = SortRow(i, matrix);
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{SortedRow[j]} \t");
    }
    Console.WriteLine();
  }
}



Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
int[,] matrix = new int[size[0], size[1]];
PrintMatrix(matrix);
Console.WriteLine();
SortByRows(matrix);





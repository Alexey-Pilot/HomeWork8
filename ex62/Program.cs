void spiral(int[,] matrix, int step, int n)
{
  for( int i = n; i < matrix.GetLength(0)* matrix.GetLength(1); i++) //i =16 i< 25
  {
    if (i < matrix.GetLength(0) + n - 2 * step)
      matrix[0 + step, i - n + step] = i + 1;
    else if (i < (matrix.GetLength(0) + matrix.GetLength(1) - 1 + n - 4 * step)) 
      matrix[i - n - matrix.GetLength(0) + 1 + 3 * step, matrix.GetLength(1) - 1 - step] = i + 1;
    else if (i < (matrix.GetLength(0) * 2 + matrix.GetLength(1) - 2 + n - 6 * step))
      matrix[matrix.GetLength(1) - 1 - step, matrix.GetLength(1) * 2 + matrix.GetLength(0) - 3 - i + n - 5 * step] = i + 1; 
    else if (i < matrix.GetLength(0) * 2 + matrix.GetLength(1) * 2 - 4 + n - 8 * step) 
    {
      matrix[matrix.GetLength(0) * 2 + matrix.GetLength(1) * 2 - 4 - i  + n - 7 *  step, 0 + step] = i + 1;
      if (i == matrix.GetLength(0) * 2 + matrix.GetLength(0) * 2 - 5  + 8 * step)
        {
          step++;
          n = i + 1;
          spiral(matrix, step, n);
        }
    }
  }

}


void PrintMatrix(int[,] matrix)
{
  for(int i= 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i,j]} \t");
    Console.WriteLine();
  }
}


Console.Clear();
Console.Write("введите 3 или 4 или 5: ");

int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
spiral(matrix, 0, 0);
PrintMatrix(matrix);

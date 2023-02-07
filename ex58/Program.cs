void MultMatrix(int[,]matrix1, int[,]matrix2)
{
  int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  for(int i = 0; i < result.GetLength(0); i++)
  {
    for(int j = 0; j < result.GetLength(1); j++)
    {
      result[i,j] = Mult(i, j, matrix1, matrix2);
    }
  }
  PrintMatrix(result);
}
int Mult(int row, int col, int[,] matrix1, int[,]matrix2)
{
  int[] row1 = new int[matrix1.GetLength(1)];
  int[] col2 = new int[matrix2.GetLength(0)];
  for(int i = 0; i < matrix1.GetLength(0); i++)
  {
    if(i == row)
      {
      for(int j = 0; j < matrix1.GetLength(1); j++)
        row1[j] = matrix1[i, j];
      }
  }
  for(int i = 0; i < matrix2.GetLength(0); i++)
  {
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
      if(j == col)
      {
        col2[i] = matrix2[i, j];
        break;
      }
    }
  }
  int result = 0;
  for(int i = 0; i < row1.Length; i++)
  {
    result += (row1[i] * col2[i]);
  }
  return result;
}

void PrintMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i,j]} \t");
    Console.WriteLine();
  }
}

void FillMatrix(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
      matrix[i, j] = new Random().Next(1,10);
  }
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] size1 = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.Write("Введите размер второй матрицы: ");
int[] size2 = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
FillMatrix(matrix2);
PrintMatrix(matrix2);
if (size2[0] == size1[1])
  MultMatrix(matrix1, matrix2);
else if (size2[1] == size1[0])
  MultMatrix(matrix2, matrix1);
else
  Console.WriteLine("Матрицы невозможно умножить!\nКолличество строк одной матрицы должно совпадать с колличеством столбцов другой. \nВведите другие размеры!");
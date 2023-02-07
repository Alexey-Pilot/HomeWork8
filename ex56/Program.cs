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

int Summ(int row, int[,] matrix)
{
  int summ = 0;
  for(int j = 0; j < matrix.GetLength(1); j++)
  {
    summ += matrix[row, j]; 
  }
  return summ;
}

void MinSummInRows(int[,] matrix)
{
  int[] SummInRow = new int[matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
    SummInRow[i] = Summ(i, matrix);
  int min = SearchMin(SummInRow);
  Console.WriteLine($"Минимальная сумма чисел находится в {min + 1} ряду и равняется {SummInRow[min]}");
}

int SearchMin(int[] nums)
{
  int index = 0;
  for(int i = 1; i < nums.Length; i++)
  {
    if(nums[i] < nums[index])
      index = i;
  }
  return index;
}




Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
int[,] matrix = new int[size[0], size[1]];
PrintMatrix(matrix);
Console.WriteLine();
MinSummInRows(matrix);
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

Console.WriteLine("Enter dimension for square array: ");
  int n = Convert.ToInt32(Console.ReadLine());

int [,] arrayToWork = new int [n,n];
New2DArray(arrayToWork);

void New2DArray (int [,] array)
{
  int n = array.GetLength(0);
       
  int [,] arrSpy = new int [n, n];
  int minRow = 0; int maxRow = n-1;
  int minCol = 0; int maxCol = n-1;
  int count = 0;
  int value = 1;
  int max = n * n;
  while (count < max)
  {
    for (int i = minCol; i<= maxCol; i++)
    {
      arrSpy[minRow,i] = value;
      value++;
      count++;
    }
    minRow = minRow+1;
    for (int i = minRow; i<= maxRow; i++)
    {
      arrSpy[i,maxCol] = value;
      value++;
      count++;
    }
    maxCol= maxCol-1;
    for (int i = maxCol; i>= minCol; i--)
    {
      arrSpy[maxRow,i] = value;
      value++;
      count++;
    }
    maxRow = maxRow-1;
    for (int i =maxRow; i>= minRow; i--)
    {
      arrSpy[i,minCol]=value;
      value++;
      count++;
    }
    
  minCol = minCol+1;
  }
for (int i = 0; i < n; i++)
{
  for (int j = 0; j < n; j++)
  {
    Console.Write($"  {arrSpy[i,j]}");
  }
  Console.WriteLine();
}
Console.WriteLine();
}




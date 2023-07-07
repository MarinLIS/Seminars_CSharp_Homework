// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение"+ 
"двух матриц");

Console.WriteLine($"\nEnter quantity of rows and columns for 2D-Matrix:");
int a = EnterNumbers("Enter quantity of rows for the first Matrix: ");
int b = EnterNumbers("Enter quantity of columns for the first matrix (must be equal "+
"to the rows of the second matrix): ");
int c = EnterNumbers("Enter quantity of rows for the second Matrix: ");
int d = EnterNumbers("Enter  quantity of columns for the second matrix: ");

int EnterNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,4);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(0); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      result[i,j] = sum;
    }
  }
 }


int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine($"\nFirst matrix:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[c, d];
CreateArray(secondMartrix);
Console.WriteLine($"\nSecond matrix:");
WriteArray(secondMartrix);

int[,] result = new int[b,c];

if ( firstMartrix.GetLength(1) != secondMartrix.GetLength(0))
{
  Console.WriteLine("The quantity of columns of the first matrix must be equal"+
 " to the quantity of rows for the second matrix");
}
else
{
MultiplyMatrix(firstMartrix, secondMartrix, result);
Console.WriteLine($"\nProduct for first and second matrices: ");
WriteArray(result);
}

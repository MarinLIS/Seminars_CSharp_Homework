// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int [,] New2DArray ()
{
    Console.WriteLine ("Enter the quontity of rows: ");
    int numRows = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Enter the quontity of collumns: ");
    int numColls = Convert.ToInt32 (Console.ReadLine());

    int [,] newArray = new int [numRows, numColls];

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j< numColls; j++)
        {
            newArray[i,j] = new Random().Next(-40,41);
        }
    }
    return newArray;
}

void ArrayToPrint (int [,] array2dToPrint)
{
    for (int i = 0; i < array2dToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < array2dToPrint.GetLength(1); j++)
        {
            Console.Write(array2dToPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array2D = New2DArray();
ArrayToPrint(array2D);

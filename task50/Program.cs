// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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
            newArray[i,j] = new Random().Next(10, 99);
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


void  AskForElement (int [,] array)
{
    Console.WriteLine ("Enter the number of necessary row: ");
    int userRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter the number of necessary column: ");
    int userCol = Convert.ToInt32(Console.ReadLine());
  
    if (userRow <= array.GetLength(0) && userCol <= array.GetLength(1))
        Console.Write ("Value of entered cell is-> " + array.GetValue(userRow, userCol));
    else
        Console.WriteLine(" Your cell doesn't exist in present array");
}

int [,] array = New2DArray();
ArrayToPrint (array);
AskForElement(array);

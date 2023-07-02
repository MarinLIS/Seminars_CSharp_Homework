// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] New2DArray ()
{
    Console.WriteLine("Enter dimension for square array: ");
    int n = Convert.ToInt32(Console.ReadLine());
            
    int [,] newArray = new int [n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j< n; j++)
        {
            newArray[i,j] = new Random().Next(1, 10);
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

void PrintAvg (int [,] array)
{
    // int n = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
        {
            double avgSum = 0;
            double count =0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                count+= array[j, i];
                avgSum = Math.Round((count / array.GetLength(1)), 2);
            }
            Console.WriteLine("Sum in {0} column: {1}", i, avgSum);
        }
}
    


int [,] array = New2DArray();
ArrayToPrint (array);
PrintAvg (array);

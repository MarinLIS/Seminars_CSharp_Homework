// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
//суммой элементов: 1 строка

int [,] CreatArr (int rows, int columns)
{
    int [,] arr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next (10, 40);
        }
    }
    return arr;
}

void ArrToShow (int [,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write (arr2D [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void SumShowArr (int [,] arrToSum)
{
    
    int [] arrSum = new int [arrToSum.GetLength(0)];
    for (int i = 0; i < arrToSum.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrToSum.GetLength(1); j++)
        {
            sum += arrToSum[i, j];
            arrSum[i] = sum;

        }
        Console.Write(arrSum[i] + " ");
    }
    
    int minValue = arrSum[0];
    int index = 0;
    for (int i = 0; i < arrSum.Length; i++)
    {
        if (minValue > arrSum[i])
        {
            minValue = arrSum[i];
            index = i;
        }
    }
    Console.WriteLine ($"The mininal value is  {minValue} and it stands in line {index+1}");
}



int num_rows = 8;
int num_cols = 6;
int [,] arrToWork = CreatArr(num_rows, num_cols);
ArrToShow(arrToWork);

SumShowArr(arrToWork);


   

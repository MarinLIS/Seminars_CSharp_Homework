// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine ("Задача 54: Задайте двумерный массив."+
"Напишите программу, которая упорядочит"+
"по убыванию элементы каждой строки двумерного массива.");

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

int [,] SortArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(1); m++)
            {
                if (arr[i, j] >= arr[i, m])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, m];
                    arr[i, m] = temp;
                } 
                
            }
        }

    }
    return arr;
}
    

int [,] array2D = New2DArray();
ArrayToPrint(array2D);

int [,] tempArr = SortArray(array2D);
ArrayToPrint (tempArr);


// сортировка столбцов

/*
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

int [,] SortArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(1); m++)
            {
                if (arr[i, j] >= arr[m, j])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[m, j];
                    arr[m, j] = temp;
                } 
                
            }
        }

    }
    return arr;
}
    


int [,] array2D = New2DArray();
ArrayToPrint(array2D);

int [,] tempArr = SortArray(array2D);
ArrayToPrint (tempArr);
*/
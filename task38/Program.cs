// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] RandomArray ( )
{
    int size = 12;
    double [] RandomArray = new double [size];
    for ( int i=0; i < size; i++)
    {
        RandomArray[i] = new Random().NextDouble() *10; 
    }
    return RandomArray;
}


void ShowArray (double [] arrayToShow)
{
    for (int i =0; i < arrayToShow.Length; i++)
        Console.Write ($"{arrayToShow[i]:f2}, ");
    Console.WriteLine("\b\b ");
}

void NumDif (double [] arrayDif)
{
    double maxVal = 0;
    double elemDiff = 0;
    for (int i = 0; i < arrayDif.Length; i++)
    {
        if (arrayDif[i]> maxVal)
        {
            maxVal = arrayDif[i];
        }
    }
    Console.Write($"{maxVal:f2} - ");

    double minVal = arrayDif[0];
    for (int i = 0; i < arrayDif.Length; i++)
    {
        if (arrayDif[i]< minVal)
        {
            minVal = arrayDif[i];
        }
    }
    Console.Write ($"{minVal:f2}");
elemDiff = maxVal - minVal;
Console.WriteLine($" = > {elemDiff:f2}");
}

double [] arrayRand = RandomArray();
ShowArray (arrayRand);
NumDif (arrayRand);


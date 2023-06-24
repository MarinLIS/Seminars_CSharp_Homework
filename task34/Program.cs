// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] RandomArray ( )
{
    int size = 12; // сгенерировали размер массива 12 элемента 
    int [] RandomArray = new int [size];
    for ( int i=0; i < size; i++)
    {
        RandomArray[i] = new Random().Next (100, 999);
    }
    return RandomArray;
}

void ShowArray (int [] arrayToShow)
{
    for (int i =0; i < arrayToShow.Length; i++)
        Console.Write (arrayToShow[i] + " ");
}

void CountEvenNum (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count ++;
    }
    Console.Write($"-> {count}");
}


int [] randomArray = RandomArray();
ShowArray (randomArray);
CountEvenNum (randomArray);
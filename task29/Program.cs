// Задача 29: Напишите программу, которая задаёт массив из произвольного количества 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] RandomArray(int array_size)
{
    int [] random = new int [array_size];
    for (int i = 0; i < array_size; i++)
    {
        random[i] = new Random().Next(0,100);
    }
    return random;
}

void Array_Print(int [] random_array)
{
    Console.Write("Your array is:-> [");
    for(int i =0; i< random_array.Length; i++)
        Console.Write (random_array[i] + " , ");
        Console.WriteLine("\b\b]");
}

Console.WriteLine("Enter the quantity of array elements: ");
int array_number =Convert.ToInt32(Console.ReadLine());

int [] my_array =RandomArray(array_number);

Array_Print (my_array);

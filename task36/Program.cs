// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArray ()
{
    Console.WriteLine ("Enter the array volume");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] CreateArray = new int [size];
    for (int i =0; i < size; i++)
    {
        CreateArray[i]= new Random().Next (-10, 10);
    }
    return CreateArray;
}

void PrintArray (int [] arrayNew)

{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        Console.Write(arrayNew[i] + " ");
    }
}

void EvenCounter (int [] myArray)
{
    int sum = 0;
    for (int i = 1; i < myArray.Length; i=i+2)
    {
        sum += myArray[i];
    }
    Console.WriteLine($" -> {sum}");
}
int [] random = CreateArray();
PrintArray (random);
EvenCounter(random);


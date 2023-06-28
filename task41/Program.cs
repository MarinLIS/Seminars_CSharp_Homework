// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void CountPosNum (string [] args)
{
 int Num;
 Console.WriteLine("Enter number of elements in your array");
 Num = Convert.ToInt32 (Console.ReadLine());
 int [] array = new int [Num];
 int i = 0;
 while (i < Num)
 {
    Console.WriteLine ("Enter number and press <Enter>");
    array [i] = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine();
    i++;
}
Console.Write("Entered numbers are: ");

for (i = 0; i < Num; i = i + 1)
Console.Write(array[i] + " ");

int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
            count ++;
    }
    Console.Write($" Quontity of positive numbers is -> {count}");
}


CountPosNum(args);

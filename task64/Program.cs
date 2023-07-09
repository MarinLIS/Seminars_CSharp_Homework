// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int ShowNatNum (int n)
// {
//     int i;
//     for (i = n; i>1; i--)
//     {
//         Console.Write($"{i} ");
//     }
//     return i;
// }
// Console.WriteLine(ShowNatNum(10));

void ShowNumRange(int n, int m)
{
    if (n != m) ShowNumRange(Math.Min(n,m)+1, Math.Max(n,m));
    Console.Write($"{Math.Min(n,m)} ");
}

ShowNumRange(10,20);
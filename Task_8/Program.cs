/*
Задача 8: Напишите программу, 
которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Input Number : ");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 1;
            while (i <= Number)
            {
                if (i % 2 == 0)
                    Console.Write(i + " "); // ("{0}", i)
                ++i;
            }

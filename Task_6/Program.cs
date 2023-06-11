/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine ("Input your number = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
     if (number % 2 == 0)
    {
        Console.Write ("Your num is even");
    }
    else
    {
        Console.Write ("Your num is NOT even");
    }
}
else
{
    if (number < 0 & number*(-1)% 2 == 0)
    {
        Console.Write ("Your num is even");
    }
    else
    {
        Console.Write ("Your num is NOT even");
    }
}


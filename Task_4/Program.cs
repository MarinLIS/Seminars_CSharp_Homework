/*
Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
 */

Console.WriteLine("Input num1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num3 ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3)
{
    Console.WriteLine ("maxNum = " + num1);
}
else
{
    if (num2 > num1 & num2 > num3)
    {
        Console.WriteLine ("maxNum = " + num2);
    }
    else
    {
        if (num3 > num1 & num3 > num2)
        {
            Console.WriteLine ("maxNum = " + num3);
        }
    }
}
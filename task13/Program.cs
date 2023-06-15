// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Input your number ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number < -100) 
{
    number = number * (-1);
}
if (number>100)
{
    if (number < 1000)
    {
        int num3 = number % 10;
        Console.WriteLine("The third figure is " + num3);
    }
    else
    {
        int num3 = (number / 100 )% 10;
        Console.WriteLine("The third figure is " + num3);
    }
}
else
{
    Console.WriteLine("No third figure, too short number");
}

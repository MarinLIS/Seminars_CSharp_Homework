// Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Input num1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine ("max = " + num1);
    Console.Write ("min = "+ num2);
}
else
{
    Console.WriteLine ("max = " + num2);
    Console.Write ("min = "+ num1);
}
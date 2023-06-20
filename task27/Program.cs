// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigits (int Num)
{
    int Sum = 0;
    while (Num > 0)
    {
        Sum += Num%10;
        Num /= 10;
    }
    return Sum;
}

Console.WriteLine ("Enter your number: ");
int number = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(SumDigits(number));

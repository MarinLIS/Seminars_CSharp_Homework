// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power (int userNumA, int userNumB)
{
    int count_result = 1;
    int powerTimes = 0;
    while (powerTimes != userNumB)
    {
        count_result = count_result * userNumA;
        powerTimes++;
    }
    return count_result;
}

Console.WriteLine ("Enter NumberA = ");
int NumberA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Enter NumberB = ");
int NumberB = Convert.ToInt32 (Console.ReadLine());

if (NumberB > 0)
{
    int power_result = Power (NumberA, NumberB);
    Console.WriteLine ($"Number A in power number B is: {power_result}");
}
else
{
    Console.WriteLine ($"Number B is incorrect");
}

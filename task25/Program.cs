// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power (int userNumA, int userNumB)
{
    for (int count = 1; count != userNumB; count++)
    {
        count = userNumA * userNumA;
    }
    return count;
}

Console.WriteLine ("Enter NumberA = ");
int NumberA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Enter NumberB = ");
int NumberB = Convert.ToInt32 (Console.ReadLine());

int power_result = Power (NumberA, NumberB);

Console.WriteLine (power_result);

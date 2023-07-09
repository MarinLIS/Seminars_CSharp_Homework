// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckFunct (int m, int n)
{
    int result = 0;
    if (m == 0) return result = n+1;
    if (m > 0  && n == 0) return result = AckFunct(m-1,1);
    if (m > 0 && n > 0) return result = AckFunct(m-1,AckFunct(m, n-1));
    return result;
}

Console.WriteLine("enter m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter n:");
int n = Convert.ToInt32(Console.ReadLine());
int ack = AckFunct(m,n);
Console.Write($"Your result is {ack}");

// A(0, n) = n + 1,

// A(1, n) = n + 2,

// A(2, n) = 2n + 3,

// A(3, n) = 2n+3 – 3
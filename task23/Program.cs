void SqurePrinter(int numberN)
{
        int current = 1;
        while (current <= numberN)
        {
                double res = Math.Pow(current,3);
                Console.Write($"{res:f0}, ");
                current++;
        }
        Console.WriteLine("\b\b.");
}

void SqurePrinterNeg(int numberN) // на случай, если отрицательные
{
        int current = -1;
        while (current >= numberN)
        {
                double res = Math.Pow(current,3);
                Console.Write($"{res:f0}, ");
                current--;
        }
        Console.WriteLine("\b\b.");
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
        SqurePrinter(user_number);
else
        SqurePrinterNeg(user_number);

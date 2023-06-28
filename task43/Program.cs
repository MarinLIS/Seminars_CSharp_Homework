// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void EnterNum ( string [] args)
{
 int size = 4;
 int [] array = new int [size];
 int i = 0;
 while (i < size)
 {
    Console.WriteLine ("Enter number");
    array [i] = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine();
    i++;
}

double crossPointX = Convert.ToDouble(array[0]- array[1]) / (array[3] - array[2]);
double crossPointY = Convert.ToDouble(array[2] * crossPointX) + array[0];

Console.Write ($@"The crosspoint of two lines with coordinates:[{array[0]};{array[1]}] and [{array[2]};{array[3]}] is: 
[{crossPointX:f1};{crossPointY:f1}]");
}

EnterNum(args);
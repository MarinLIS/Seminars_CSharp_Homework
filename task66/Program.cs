// Задача 66: Задайте значения M и N (включая). Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNatElem (int m, int n){
if (m!=n)
    if (m<n) return SumNatElem(m, n-1)+n;
    if (m>n) return SumNatElem(m-1, n)+m;
return m;
}

Console.WriteLine("enter num:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter num:");
int n = Convert.ToInt32(Console.ReadLine());
int summ = SumNatElem(m,n);
Console.Write($"Your sum is {summ}");


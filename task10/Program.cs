// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100, 999);
Console.WriteLine("Your number is " + num);
int middle = num % 100;
int second = middle / 10;
    
Console.WriteLine("Result is - " + second);

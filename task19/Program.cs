﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void PalindromNumber (int Num)
{
    int rightPartNum = Num % 100;
    int leftPartNum = Num / 1000;
    int invNum1 = leftPartNum / 10;
    int invNum2 = leftPartNum % 10;
    int invNum22 = rightPartNum / 10;
    int invNum11 = rightPartNum % 10;
       if (invNum1 == invNum11 && invNum2 == invNum22) Console.WriteLine ("your Number is Palindrom");
       else {Console.WriteLine("your number is NOT Palindrom");}
}
Console.WriteLine ("Enter 5-digits number ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number > 10000 && number < 99999 && number != 0) 
{
    PalindromNumber (number);
}
else if (number == 00000)Console.WriteLine("Your Number is incorrect");
else
{
    Console.WriteLine("Your number is not 5-digits number");
}
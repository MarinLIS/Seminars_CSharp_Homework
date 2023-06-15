// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number of the day of the week ");
int weekDayNum = Convert.ToInt32 (Console.ReadLine());

if (weekDayNum == 6){Console.WriteLine ("It's Saturday, weekend");}
else if (weekDayNum == 7){Console.WriteLine ("It's Sunday, weekend");}
else {Console.WriteLine ("It's NOT weekend");}
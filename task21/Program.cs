// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double LonglineABC (int  xA, int yA, int zA, int  xB, int yB, int zB)
{
    double longline = Math.Sqrt((xB - xA)*(xB-xA)+ (yB-yA)*(yB-yA)+ (zB-zA)*(zB-zA)); // \/(x2 - x1)*(x2 - x1) + (y2 - y1)* (y2-y1) + (z2 - z1)*(z2 - z1)
    longline = Math.Round(longline, 2);// округление до двух точек после запятой
    return longline;
}
Console.Write ("Enter x coord of A: ");
int xCoordA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter x coord of B: ");
int xCoordB = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter y coord of A: ");
int yCoordA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter x coord of B: ");
int yCoordB = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter z coord of A: ");
int zCoordA = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Enter z coord of B: ");
int zCoordB = Convert.ToInt32 (Console.ReadLine());

double dist = LonglineABC(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);
Console.WriteLine ($"distance AB is {dist:f3}"); // f3 округление до трех символов
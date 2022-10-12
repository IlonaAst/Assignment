/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
в 3Д пространстве.
А(3,6,8); В(2,1,-7) -> 15.84  */

int X1, Y1, Z1, X2, Y2, Z2;
double distance;

Console.WriteLine("Введите Х1:");
X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1:");
Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1:");
Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Х2:");
X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2:");
Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2:");
Z2 = Convert.ToInt32(Console.ReadLine());

distance = Math.Pow((Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2) * 1.0), 0.5);
Console.WriteLine($"Расстояние между точками = {distance}");


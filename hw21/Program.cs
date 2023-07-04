
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координаты x1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y1 ");
int y1 =int.Parse(Console.ReadLine());
Console.Write("Введите координаты y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты z1 ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты z2 ");
int z2 = int.Parse(Console.ReadLine());
double result = ((x1 - x2)*(x2-x1)+ (y1 - y2)*(y1-y2) + (z1 - z2)*(z1-z2));
double s = Math.Sqrt(result);
Console.WriteLine(s);
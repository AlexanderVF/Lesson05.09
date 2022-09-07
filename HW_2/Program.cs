Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if (b1 == b2 && k1 == k2)
{
    Console.WriteLine(" Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine(" Прямые парралельны");
}
else
{
    Console.WriteLine($"Точки пересечения двух прямых ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
}





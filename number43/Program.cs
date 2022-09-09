Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k2");
double k2 = double.Parse(Console.ReadLine());

if ((b1 == b2) && (k1 == k2))
{
    Console.WriteLine("прямые не пересекаются");
}
else
{
    double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine("прямые пересекаются в точке с координатами"+"("+ x +";"+ y +")");
}

Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine (y <= -x + 2 && y >= -x + 1 && (y <= x - 1 && y >= x - 2));

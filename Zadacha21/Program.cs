using static System.Console;

Write("Enter x coordinates for 1st point : ");
long x1 = long.Parse(ReadLine()!);

Write("Enter y coordinates for 1st point : ");
long y1 = long.Parse(ReadLine()!);

Write("Enter z coordinates for 1st point : ");
long z1 = long.Parse(ReadLine()!);

Write("Enter x coordinates for 2nd point : ");
long x2 = long.Parse(ReadLine()!);

Write("Enter y coordinates for 2nd point : ");
long y2 = long.Parse(ReadLine()!);

Write("Enter z coordinates for 2nd point : ");
long z2 = long.Parse(ReadLine()!);

double distance = (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
WriteLine($"Distance between two point: {distance:f2}");
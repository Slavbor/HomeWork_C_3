using static System.Console;

Write("Enter number: ");
long num = long.Parse(ReadLine()!);
long i = 1;
while (i <= num)
{
    Write(Math.Pow(i, 3));
    i++;
    if (i <= num)
    {
        Write(", ");
    }
}

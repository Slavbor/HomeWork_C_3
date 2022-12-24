using static System.Console;

Write("Input number for polindrome check: ");

long num = long.Parse(ReadLine()!);
long revers = 0;
long num2 = num;
while (num2 != 0)
{
    revers *= 10;
    revers += num2 % 10;
    num2 = num2 / 10;
}
Write(revers == num ? "YES" : "NO");

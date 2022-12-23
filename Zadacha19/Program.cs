using static System.Console;

Write("Input number for polindrome check: ");

long num = long.Parse(ReadLine()!);
long result = 0;
long num2 = num;
while (num2 != 0)
{
    result *= 10;
    result += num2 % 10;
    num2 = num2 / 10;
}
Write(result == num ? "YES" : "NO");
return;
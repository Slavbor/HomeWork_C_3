using static System.Console;

Write("Input number for polindrome check: ");

long n = long.Parse(ReadLine()!);
long refer = n;
string n2 = "";

while (n != 0)
{
    string testnum = Convert.ToString(n % 10);
    n2 = n2 + testnum;
    n = n / 10;
}
Write(long.Parse(n2) == refer ? "YES" : "NO");
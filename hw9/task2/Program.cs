Random rnd = new Random();
int n = rnd.Next(5, 30);
int m = rnd.Next(5, 30);
while (n >= m)
{
    m = rnd.Next(3, 10);
    n = rnd.Next(3, 10);
}
Console.WriteLine("The sum from " + n + " to " + m + " is:");

int Recursion(int n, int m)
{
    if (n == m + 1) return 0;
    else return n + Recursion(n + 1, m);
}
Console.WriteLine(Recursion(n, m));


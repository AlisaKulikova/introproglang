Random rnd = new Random();
int n = rnd.Next(5, 30);

string Recursion(int n)
{
    if (n <=0) return "";
    else return Recursion(n-1)+" "+n;
}
Console.WriteLine(Recursion(n));
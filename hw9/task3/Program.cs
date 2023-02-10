Console.WriteLine("Enter a value N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a value M");
int m = Convert.ToInt32(Console.ReadLine());

int A(int n, int m)
{
    if(n==0) return m+1;
    else if(m==0 && n!=0) return A(n-1,1);
    else 
    return A(n-1,A(n,m-1));
}
Console.WriteLine("Result:");
Console.WriteLine(A(n, m));
 
int SumFunction(int a)
{
int digit= 0; 
int sum = 0;
while (a>0)
{
 digit = a%10;
 sum= sum+digit;
 a=a/10;   
}
return(sum);
}
Console.WriteLine("Enter an integer:");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumFunction(a));

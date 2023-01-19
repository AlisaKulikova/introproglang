
int ThirdFunction(int a)
{
int thirdnum = -1;

if ( Math.Abs(a) >= 100)
{
while (Math.Abs(a) > 999)
{
    a = Math.Abs(a)/10;
}
thirdnum = Math.Abs(a)%10;
}
return thirdnum;

}
Console.WriteLine("Enter an integer:");
int a1 = Convert.ToInt32(Console.ReadLine());
if (ThirdFunction(a1)== -1) 
{
Console.WriteLine("There is no third number");
}
else 
{
    Console.WriteLine(ThirdFunction(a1));
}




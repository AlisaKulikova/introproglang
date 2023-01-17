
int ThirdFunction(int a)
{
int thirdnum = -1;

if (a >= 100)
{
while (a > 999)
{
    a = a/10;
}
thirdnum = a%10;
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




System.Console.WriteLine("Enter three numbers one by one:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b )
{
    System.Console.WriteLine("FirstNum = maximum");
}

else if ( b > c)
{ 
     System.Console.WriteLine("SecondNum = maximum");
     
}
else 
{
     System.Console.WriteLine("ThirdNum = maximum");
}

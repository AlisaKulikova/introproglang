System.Console.WriteLine("Enter two numbers one by one:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if ( a > b ) max = a;

else max = b;
             
if (b > a) min = a;

System.Console.Write ("maximum:");
System.Console.WriteLine (max);
System.Console.Write ("minimum:");
System.Console.WriteLine (min);
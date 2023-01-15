System.Console.WriteLine("Enter three numbers one by one:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int result = a;


if (a > b ) result = a;

else if ( b > c) result = b;

else result = c;
Console.WriteLine("maximal number:");
Console.WriteLine(result);
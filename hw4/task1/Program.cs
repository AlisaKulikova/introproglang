//Работает для положительных и отрицательных целых чисел
Console.WriteLine("Enter A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B :");
int b = Convert.ToInt32(Console.ReadLine());

double pow(double a,double b)
{

double num = 1;
for(double i=0;i<Math.Abs(b);i++)
{
    num*=a;
}
return num;
}
if (b>0)
{
    Console.WriteLine("{0}^{1}={2}", a, b, pow(a,b));
} 
else
{
    Console.WriteLine("{0}^{1}={2}", a, b, 1/pow(a,b));
}


// Без явной конвертации:
// int/int => int
// double/int => double
// double/double => double
// int/float => float
// float/float => float
// double/float => double

System.Console.WriteLine("Enter a three-digit number:");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a < 1000)
{
    int secondnum = (a / 10)%10;
    Console.WriteLine(secondnum);
}
else
{
    Console.WriteLine("Enter ONLY THREE-DIGIT number, please");
}

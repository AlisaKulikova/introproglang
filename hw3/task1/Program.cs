int Function(int num)
{

  int n = num;
  int revers = 0;
   while (n>0)
   {
    int lastnum = n%10;
    revers= revers*10+lastnum;
    n=n/10;
   }  
   return(num = revers);
}

Console.WriteLine("Enter an integer:");
int n1 = Convert.ToInt32(Console.ReadLine());
if (Function(n1)==n1) 
{
   Console.WriteLine(" PALINDROME");
}
else
{
 Console.WriteLine("NOT PALINDROME");
}


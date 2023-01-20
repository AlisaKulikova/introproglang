System.Console.WriteLine("Enter an enteger:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int index = 0; 
double [] array = new double [Math.Abs(n)];
Console.WriteLine("Cubes:"); 

while (i< Math.Abs(n))
{
   double cube = Math.Pow(i,3);

   array[index]= cube;

   i++;
  
  if(n<0) array[index]= array[index]*-1;
   Console.Write($"{array[index]}, ");
}
Console.Write($"{Math.Pow(n,3)}");

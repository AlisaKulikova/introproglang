Console.WriteLine("Entet the number of array elements:");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double [n];
Random rnd = new Random();
double min=array[0];
double max=array[0];

for (int i=0; i<n; i++)
{
    array[i]= rnd.NextDouble()*1000;
    Console.Write( Math.Round(array[i],1)+" ");
}

double MIN(double min)
{
    min=array[0];
    for (int i=0; i<n; i++)
 {  
    
    if (array[i]<min)
    {
       min=array[i];
    }
 }
return min;
}

double MAX(double max)
{
    max=array[0];
    for (int i=0; i<n; i++)
 {
   
    if (array[i]>max)
     
    {
       max=array[i];
    }
 }
return max;
}
Console.WriteLine("\nDifference between max and min:");
Console.WriteLine("{0}-{1}={2}", Math.Round(MAX(max),1),Math.Round(MIN(min),1), Math.Round(MAX(max)-MIN(min),1));
Console.WriteLine("Enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array= new double[m,n];

double genRndDouble( int a, int b)
{
    Random rnd = new Random();
    double rndDouble = a+rnd.NextDouble()*(b-a);
    return rndDouble;
}


void FillArray(double [,]array)
{
  for(int i=0;i<array.GetLength(0);i++)
{
    for(int j = 0;j<array.GetLength(1);j++)
    {
        array[i,j]=genRndDouble(-10,11);
    }
}
}

void PrintArray(double[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
{
    for(int j = 0;j<array.GetLength(1);j++)
    {
        Console.Write(String.Format("{0,7}", Math.Round(array[i,j],2)));
    }
    Console.WriteLine();
}
}
FillArray(array);
Console.WriteLine("Random array:");
PrintArray(array);

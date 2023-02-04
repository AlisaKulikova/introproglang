Console.WriteLine("Enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array= new int[m,n];
Random rnd = new Random();

void FillArray(int [,]array)
{
  for(int i=0;i<array.GetLength(0);i++)
  {
    for(int j = 0;j<array.GetLength(1);j++)
    {
        array[i,j]=rnd.Next(-10,11);
    }
  }
}

void PrintArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
    for(int j = 0;j<array.GetLength(1);j++)
        {
        Console.Write( );
        }
    Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine("Random array:");
PrintArray(array);
Console.WriteLine("Arithmetic mean of array column:");

for (int j=0; j<n; j++)
{
    double sum=0;
    for(int i=0;i<m;i++)
    {
        sum=sum+array[i,j];
    }
    Console.Write(String.Format("{0,5}",Math.Round(sum/m,1)));
}


Random rnd = new Random();
int m =rnd.Next(3,10);
int n =rnd.Next(3,10);
int [,] array = new int[m,n];

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
        Console.Write(String.Format("{0,5}",array[i,j]));
        }
    Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine("Random array:");
PrintArray(array);

 for (int q = 0; q < m; q++)
{
    
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {

        for (int i = 0;i < array.GetLength(0); i++)
        {   
            if (array[i,j]<array[i,j+1])
            {
            int buf=array[i,j]; 
            array[i,j]=array[i,j+1];
            array[i,j+1]=buf;
            }
        } 
    }
}
Console.WriteLine();
PrintArray(array);
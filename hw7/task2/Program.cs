Console.WriteLine("Enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array= new int[m,n];

int genRnd( int a, int b)
{
    Random rnd = new Random();
    int rndInt = rnd.Next(-9,10);
    return rndInt;
}
void FillArray(int [,]array)
{
  for(int i=0;i<array.GetLength(0);i++)
  {
    for(int j = 0;j<array.GetLength(1);j++)
    {
        array[i,j]=genRnd(0,0);
    }
  }
}

void PrintArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
    for(int j = 0;j<array.GetLength(1);j++)
        {
        Console.Write("{0}",String.Format("{0,5}",array[i,j]));
        }
    Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine("Random array:");
PrintArray(array);

Console.WriteLine("Enter the index of lines:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the index of columns:");
int b = Convert.ToInt32(Console.ReadLine());

if (a>=m || b>=n) Console.WriteLine("The element corresponding to the given indexs does not exist");

else
   for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                
               if(i==a && j==b){Console.Write(String.Format("{0,4}",array[a,b]));}
               else Console.Write(String.Format("{0,4}"," ♥ ")); 
            }
           
            Console.WriteLine();
        }

       
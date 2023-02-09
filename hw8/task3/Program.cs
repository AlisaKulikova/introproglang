Random rnd = new Random();
int am =rnd.Next(3,10);
int an =rnd.Next(3,10);
int bm =an;
int bn =rnd.Next(3,10);
int [,] arrA = new int[am,an];
int [,] arrB = new int[bm,bn];
void FillArrayA(int [,]arrA)
{
  for(int i=0;i<am;i++)
  {
    for(int j = 0;j<an;j++)
    {
        arrA[i,j]=rnd.Next(-10,11);
    }
  }
}
void PrintArrayA(int[,] arrA)
{
    for(int i=0;i<am;i++)
    {
    for(int j = 0;j<an;j++)
        {
        Console.Write(String.Format("{0,5}",arrA[i,j]));
        }
    Console.WriteLine();
    }
}
void FillArrayB(int [,]arrB)
{
  for(int i=0;i<bm;i++)
  {
    for(int j = 0;j<bn;j++)
    {
        arrB[i,j]=rnd.Next(-10,11);
    }
  }
}
void PrintArrayB(int[,] arrB)
{
    for(int i=0;i<bm;i++)
    {
    for(int j = 0;j<bn;j++)
        {
        Console.Write(String.Format("{0,5}",arrB[i,j]));
        }
    Console.WriteLine();
    }
}
FillArrayA(arrA);
FillArrayB(arrB);
Console.WriteLine("Matrix A:");
PrintArrayA(arrA);
Console.WriteLine("Matrix B:");
PrintArrayB(arrB);
Console.WriteLine();

int[,] arrC=new int[am,bn];
Console.WriteLine(String.Format("Matrix C:"));
for (int row = 0; row < am; row++) 
{
        for (int col = 0; col < bn; col++) 
        {
        
            for (int q = 0; q < 2; q++) 
            {
                arrC[row,col] += arrA[row,q] * arrB[q,col];
                 
            }
            Console.Write(String.Format("{0,5}",arrC[row,col]));
        }
         Console.WriteLine();
}


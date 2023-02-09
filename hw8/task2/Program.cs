Random rnd = new Random();
int m = rnd.Next(3, 10);
int n = rnd.Next(3, 10);
int[] sum = new int[m];
for (int i = 0; i < 10; i++)
{
    if (n == m)
    {
        m = rnd.Next(3, 10);
        n = rnd.Next(3, 10);
    }
}
int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", array[i, j]));
        }
        Console.WriteLine();
    }
}

void Sum(int []sum)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] = sum[i] + array[i, j];
    }
    Console.Write("Sum of " + (i + 1) + "  line:  " + sum[i]);
    Console.WriteLine();
}
}
int min = sum[0];
int num = 0;
FillArray(array);
Console.WriteLine("Random array:");
PrintArray(array);
Console.WriteLine();
Sum(sum);
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    if (sum[i] < min)
    {
        min = sum[i];
        num = i;
    }
}    

Console.Write("The line with  minimum sum of elements is:"+(num+1));

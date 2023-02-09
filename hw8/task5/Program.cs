//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Random rnd = new Random();
int m = rnd.Next(4, 30);
int n = rnd.Next(4, 30);
int[,] array = new int[m, n];
int count = m*n;

Spir(array);

void Spir(int[,] array, int a = 0)
{
    for (int i = 0+a; i < n-a; i++)
    {
        array[0+a, i] = count;
        count--;
        if (count==0) return;
        
    }

    for (int j = 1+a; j < m-a; j++)
    {
        array[j, n - 1-a] = count;
        count--;
         if (count==0) return;
    }
    for (int k = n - 2-a; k >= 0+a; k--)
    {
        array[m - 1-a, k] = count;
        count--;
         if (count==0) return;
    }
    for (int l = m - 2-a; l > 0+a; l--)
    {
        array[l, 0+a] = count;
        count--;
         if (count==0) return;
    }
    Spir(array,a+1);
}

PrintArray(array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {

            Console.Write(String.Format("{0,5}", (array[i, j])));
        }
        Console.WriteLine();
    }
}

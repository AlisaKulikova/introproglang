Console.WriteLine("Entet the number of array elements:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
Random rnd = new Random();

for (int i=0; i<array.Length; i++)
{
array[i]= rnd.Next(-100,101);
Console.Write( array[i]+" ");
}
int sum = 0;
for (int i=0; i<array.Length; i++)
{
    if (i%2==1)
    {
        sum=sum+array[i];
        i++;
    }
}
Console.WriteLine("\nThe sum of array elements in odd position:");
Console.WriteLine(sum);
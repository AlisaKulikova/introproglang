Console.WriteLine("Entet the number of array elements:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
Random rnd = new Random();

for (int i=0; i<array.Length; i++)
{
array[i]= rnd.Next(100,1000);
Console.Write( array[i]+" ");
}

int count = 0;

foreach (var item in array)
{
    if (item%2==0)
    {
        count++;
    }

}
Console.WriteLine("\nThe number of even array elements:");
Console.WriteLine(count);

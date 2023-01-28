int [] array = new int[8];
 Random rnd = new Random();
Console.WriteLine("Enter an array of integers:");
for (int i=0;i<8;i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());  // вводим 8 элементов массива
}

for (int i = array.Length-1;i>=1;i--)
{
    int j = rnd.Next(i);
    int buf = array[j];
    array [j] = array [i];
    array[i]= buf;
}
Console.WriteLine("Array in random order:"); 
Console.WriteLine(string.Join(",",array)); 



// int [] array = new int[8];

// int GetRandom(int n)
// {
//     Random rnd = new Random();
//     int i = rnd.Next(8);
//     return i;
// }
// Console.WriteLine(GetRandom(0)); 
// Console.WriteLine(GetRandom(1)); 
// Console.WriteLine(GetRandom(2)); 
// Console.WriteLine(GetRandom(3)); 
// Console.WriteLine(GetRandom(4)); 
// Console.WriteLine(GetRandom(5)); 
// Console.WriteLine(GetRandom(6)); 
// Console.WriteLine(GetRandom(7)); 
// int i0 = GetRandom(0);
// int i1 = GetRandom(1);
// int i2 = GetRandom(2); 
// int i3 = GetRandom(3); 
// int i4 = GetRandom(4); 
// int i5 = GetRandom(5); 
// int i6 = GetRandom(6); 
// int i7 = GetRandom(7); 


// Console.WriteLine("Enter");


//  array[i0] = Convert.ToInt32(Console.ReadLine());
//  array[i1] = Convert.ToInt32(Console.ReadLine());
//  array[i2] = Convert.ToInt32(Console.ReadLine());
//  array[i3] = Convert.ToInt32(Console.ReadLine());
//  array[i4] = Convert.ToInt32(Console.ReadLine());
//  array[i5] = Convert.ToInt32(Console.ReadLine());
//  array[i6] = Convert.ToInt32(Console.ReadLine());
//  array[i7] = Convert.ToInt32(Console.ReadLine());
 
//  Console.WriteLine(string.Join(",",array)); 
 
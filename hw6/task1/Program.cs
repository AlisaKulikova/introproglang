Console.WriteLine("Enter an array of integer elements separated by SPASE, SLASH, DOT or COMMA, end press 'ENTER'");
string str = Console.ReadLine();
char [] separator =  new char [] {' ',',','.','/'};
string [] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
int [] a = Array.ConvertAll(array,int.Parse);
Console.WriteLine("Your array:");
Console.Write("{"+string.Join(",",a)+"}"); 

int count=0;
for (int i=0;i<array.Length;i++)
{
 if(a[i]>0)count++;
}
Console.WriteLine("\nThe number of positive array elements is:");
Console.WriteLine(count);

 





// // // string [] separator = {" ","  ","   ", ",", "."};
// string str = Console.ReadLine();
// int [] separator =  new char [] {" ",",", "."};
// // //var array = str.ToCharArray();
// string [] array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
// // //int [] arrayint = new int [array.Length];
// foreach (var item in array)
// {
//      Console.Write(" "+item );   
// }
// // {
// //   Console.Write(" "+item );   
// // }
// // // {
// // //     arrayint[i] = Convert.ToInt32(array[i]);
// // // }
// // //Console.Write(" "+item); 
 
// // //}
// // // {
// // //Console.Write(i, s[i] ); 
// // // }
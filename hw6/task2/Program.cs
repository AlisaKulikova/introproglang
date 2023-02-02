Console.WriteLine("Enter value B1:");
double ba = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value K1:");
double ka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value B2:");
double bb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value K2:");
double kb = Convert.ToInt32(Console.ReadLine());
if (ka==kb | ba==bb ) Console.WriteLine("Lines don't intersect");
else 
{
double x= (bb-ba)/(ka-kb);
double y = kb*x+bb;
Console.Write("Point of intersectoin of lines:");
Console.Write("(" + Math.Round(x,2)+","+ Math.Round(y,2)+ ")");
}

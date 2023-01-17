Console.WriteLine("Is this day a holyday?");
Console.WriteLine("p.s.: enter an integer from 1 to 7:");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
    Console.WriteLine("Monday--> no, it's not");
    Console.WriteLine("GO TO WORK!");
    break;

    case 2:
    Console.WriteLine("Tuesday-->no, it's not");
    Console.WriteLine("GO TO WORK!");
    break;
    
    case 3:
    Console.WriteLine("Wednesday--> no, it's not");
    Console.WriteLine("GO TO WORK!");
    break;
    
    case 4:
    Console.WriteLine("Thursday--> no, it's not");
    Console.WriteLine("GO TO WORK!");
    break;
    
    case 5:
    Console.WriteLine("Friday--> no, it's not");
    Console.WriteLine("GO TO WORK!");
    break;
    
    case 6:
    Console.WriteLine("Saturday --> yes, it is");
    Console.WriteLine("YOU CAN KEEP SLEEPING");
    break;
   
    case 7:
    Console.WriteLine("Sunday--> yes, it is");
    Console.WriteLine("YOU CAN KEEP SLEEPING");
    break;

    default:
    Console.WriteLine("Enter an integer FROM 1 TO 7 ONLY");
    break;
}
//По заданному с клавиатуры номеру дня недели вывести его название.

int a;
Console.WriteLine("Insert a number of a week day: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
switch (a)
{
    case 1: System.Console.WriteLine("Monday");
    break;
    case 2: System.Console.WriteLine("Tuesday");
    break;
    case 3: System.Console.WriteLine("Wednesday");
    break;
    case 4: System.Console.WriteLine("Thursday");
    break;
    case 5: System.Console.WriteLine("Friday");
    break;
    case 6: System.Console.Write("Saturday");
    break;
    case 7: System.Console.Write("Sunday");
    break;
    default:
    System.Console.WriteLine("No more days");
    break;
}
if (a==6 || a==7)
{
    System.Console.Write(" is a weekend day");
}
 


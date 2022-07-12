//Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.WriteLine("Insert a number of a week day: ");
int a=Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1: System.Console.Write("Monday");
    break;
    case 2: System.Console.Write("Tuesday");
    break;
    case 3: System.Console.Write("Wednesday");
    break;
    case 4: System.Console.Write("Thursday");
    break;
    case 5: System.Console.Write("Friday ");
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
if (a==1|| a==2 || a==3|| a==4|| a==5)
{
    System.Console.Write(" is a work day");
}
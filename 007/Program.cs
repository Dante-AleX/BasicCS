//Выяснить является ли число чётным.

double a;
System.Console.WriteLine("Please insert a number");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);

if (a%2==0)
{
    System.Console.WriteLine($"{a} is an even number");
}
else
{
    System.Console.WriteLine($"{a} isn't an even number");
}
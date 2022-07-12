//Выяснить является ли число чётным.

System.Console.WriteLine("Please insert a number");
double a=Convert.ToDouble(Console.ReadLine());

if (a%2==0)
{
    System.Console.WriteLine($"{a} is an even number");
}
else
{
    System.Console.WriteLine($"{a} isn't an even number");
}
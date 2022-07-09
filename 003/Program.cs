//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a;
double b;
System.Console.WriteLine("Please insert the first number");
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.WriteLine("Please insert the second number");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a>b)
{
    System.Console.WriteLine($"{a}");
}
else
{
    System.Console.WriteLine($"{b}");
}
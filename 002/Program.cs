//С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго

int a;
int b;
System.Console.WriteLine("Please insert first number");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Please insert second number");
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (b==a*a)
{
    System.Console.WriteLine("Second number is the sqr of the first");
}
else
{
    if (a==b*b)
    {
        System.Console.WriteLine("First number is the sqr of the second");
    }
    else 
    {
        System.Console.WriteLine("Numbers aren't sqrs of each other");
    }
}
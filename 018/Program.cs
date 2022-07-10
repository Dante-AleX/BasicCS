//По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b;
}
int a;
int b;
System.Console.WriteLine("Please insert the first number");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Please insert the second number");
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (Check(a,b))
{
    System.Console.WriteLine("Second number is the sqr of the first");
}
else
{
    if (Check(b, a))
    {
        System.Console.WriteLine("First number is the sqr of the second");
    }
    else 
    {
        System.Console.WriteLine("Numbers aren't sqrs of each other");
    }
}
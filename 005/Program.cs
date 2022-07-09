//С клавиатуры вводятся три числа. Найти максимальное из трех чисел.

int a, b, c;

System.Console.WriteLine("Please insert the first number");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Please insert the second number");
s=Console.ReadLine();
b=Convert.ToInt32(s);
System.Console.WriteLine("Please insert the third number");
s=Console.ReadLine();
c=Convert.ToInt32(s);

if (b>a)
{
    if (b>c)
    System.Console.WriteLine($"{b} is the biggest number");
}
else
{
    if (a>c)
        System.Console.WriteLine($"{a} is the biggest number");
}
if (a<c)
{
    System.Console.WriteLine($"{c} is the biggest number");
}
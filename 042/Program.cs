//Выяснить являются ли три числа сторонами треугольника.

System.Console.WriteLine("Please insert the first whole, positive number");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Please insert the second whole, positive number");
int b = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Please insert the third whole, positive number");
int c = Convert.ToInt32(System.Console.ReadLine());

if (a < 0 || b < 0 || c < 0)
{
    System.Console.WriteLine("I said a whole WHOLE, POSITIVE number");
    return;
}
if (a + b < c || b + c < a || c + a < b)
{
    System.Console.WriteLine("Your numbers can't form a trinagle");
    return;
}
if (a + b > c || b + c > a || c + a > b)
{
    System.Console.WriteLine("Your numbers can form a trinagle");
}
else
{
    System.Console.WriteLine("Your numbers can't form a trinagle");
}
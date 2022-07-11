//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

bool c;
System.Console.WriteLine("Please insert the first number");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please insert the second number");
int b = Convert.ToInt32(Console.ReadLine());
c = true;

if (c = a % b == 0)
{
    System.Console.WriteLine($"{a} divides by {b} without reminder");
}
else
{
    System.Console.WriteLine($"{a % b} is the reminder of {a} divided by {b}");
}

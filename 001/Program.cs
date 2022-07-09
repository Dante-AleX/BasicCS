//С клавиатуры вводится целое число. Вывести квадрат числа.

int a;
int b;
System.Console.WriteLine("Please insert a number");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
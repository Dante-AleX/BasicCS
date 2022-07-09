//Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

int a;
System.Console.WriteLine("Please insert a number");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine();
int c=a%10;
System.Console.WriteLine(c);
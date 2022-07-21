//Подсчитать сумму цифр в числе.

System.Console.WriteLine("Please insert a whole number");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a / 10;
}
Console.WriteLine(s);
//Вывести на экран кубы чисел от 1 до N.

Console.WriteLine("Please insert a whole number from 2 to N");
int n = Convert.ToInt16(Console.ReadLine());

if (n < 1)
{
    Console.WriteLine($"{n} isn't a whole number");
    return;
}
for ( int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}

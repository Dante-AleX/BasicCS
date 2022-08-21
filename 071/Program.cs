//Написать программу вычисления функции Аккермана.

Console.WriteLine("Insert number N: ");
int number = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Insert number M: ");
int number1 = Convert.ToInt16(Console.ReadLine());

if (number < 0 || number1 < 0) Console.WriteLine("Please insert a positive number");

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
Console.WriteLine(Akkerman(number, number1));
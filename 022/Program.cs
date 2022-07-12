//Программа проверяет пятизначное число на палиндромом.

Console.Write("Please insert a 5 digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 10000 || a > 99999)
{
    System.Console.WriteLine("This number doesn't meet the requirements");
    return;
}

if ((a / 10000) == (a % 10) || (a / 1000) == (a / 10 % 10))
{
    System.Console.WriteLine("This number is a polyndrome");
}
else
{
    System.Console.WriteLine("This number isn't a polyndrome");
}
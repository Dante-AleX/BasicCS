//Найти сумму цифр числа - 2.

System.Console.WriteLine("Please insert a 2 digit number");
int a = Convert.ToInt32(Console.ReadLine());
int result;

if (a < 10)
{
    System.Console.WriteLine("This isn't a 2 digit number");
    return;
}
if (a > 99)
{
    System.Console.WriteLine("This number has more than 2 digits");
    return;
}
else
{
    result = (a % 10) + (a / 10);
}
System.Console.WriteLine(result);

/*
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма цифр числа:"+Sum(num));
        }
        static int Sum(int num)
        {
            if (num < 10) return num;
            else return num % 10 + Sum(num / 10);
        }
*/
//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

System.Console.WriteLine("Please insert a number");
int a = Convert.ToInt32(Console.ReadLine());
int d = ThirdDigit(a);
Console.WriteLine($"{d} is the third digit of {a}");


int ThirdDigit(int k)
{
    while (k > 1000)
    k /= 10;
    int d = k % 10;
    return d;
}
if (a<100)
System.Console.WriteLine("There is no third digit");

/*Код работает но с одной оговоркой. Если вводить двухзначное число, то он пишет что нет 3 цифры, 
но так же показывает что 2 цифра это якобы 3 цифра числа.
*/
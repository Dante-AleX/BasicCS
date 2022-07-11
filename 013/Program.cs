//Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.WriteLine("Please insert a whole number");
int a=Convert.ToInt32(Console.ReadLine());
int Digit;

Digit = a/10 % 10;

System.Console.WriteLine(Digit);

//Код работает с двухзначными числами. Как сделать лучше пока не знаю(
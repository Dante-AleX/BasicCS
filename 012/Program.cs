//Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа.

int a = new Random().Next(10, 99);
System.Console.WriteLine(a);
int Digit1;
int Digit2;

Digit1 = a / 10 % 10;
Digit2 = a % 10;
System.Console.WriteLine($"The first digit is {Digit1}");
System.Console.WriteLine($"The second digit is {Digit2}");
    if (Digit1>Digit2)
    {
        System.Console.WriteLine($"{Digit1} is the biggest digit");
    }
        else
            {
                System.Console.WriteLine($"{Digit2} is the biggest digit");
            }
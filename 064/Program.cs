//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int M=1;
int N=5;

System.Console.WriteLine($"{M} {N}");
while (M<=N)
{
    System.Console.Write($"{M} ");
    M++;
}
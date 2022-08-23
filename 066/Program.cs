//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1;
int N = 10;
int Sum = 0;

System.Console.WriteLine($"{M} {N}");

while (M<=N)
{
    Sum = Sum + M;
    M++;
}
System.Console.WriteLine(Sum);
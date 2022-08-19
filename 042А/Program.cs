/*
Даны две квадратных таблицы чисел. Требуется построить третью,
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.
*/

int M = 2;
int N = 10;

int[,] a = new int[M, N];
int[,] b = new int[M, N];
int[,] c = new int[M, N];

Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(1, 101);
    }
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) System.Console.Write($"{a[i, j]} ");
    System.Console.WriteLine();
}

System.Console.WriteLine();

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = random.Next(1, 101);
    }
}

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++) System.Console.Write($"{b[i, j]} ");
    System.Console.WriteLine();
}

System.Console.WriteLine();

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        c[i, j] = a[i,j]+b[i,j];
    }
}

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++) System.Console.Write($"{c[i, j]} ");
    System.Console.WriteLine();
}


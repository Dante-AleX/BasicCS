//Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

/*
Я не уверен что правильно понял задачу, но тут симметрия обусловлена если матрица квадратная, 2х2, 3х3 и т.д
*/
System.Console.WriteLine("Please insert the length of the matrix");
int M = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Please insert the width of the matrix");
int N = Convert.ToInt32(System.Console.ReadLine());

int[,] a = new int[M, N];

Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(1, 10);
    }
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) System.Console.Write($"{a[i, j]} ");
    System.Console.WriteLine();
}

if (M==N)
{
    System.Console.WriteLine("This matrix is symmetric");
}
else 
{
    System.Console.WriteLine("This matrix isn't symmetric");
}
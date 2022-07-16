//Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.WriteLine("Please insert a whole number");
int a = Convert.ToInt32(Console.ReadLine());
int k = DigitsCount(a);
int a2 = a % (int)Math.Pow(10, k - 2);
int a3 = a2 / (int)Math.Pow(10, k - 1);
int aa = a3 * (int)Math.Pow(10, k - 2) + a2;
System.Console.WriteLine(aa);

int DigitsCount(int N)
{
    if (N == 0) return 1;
    int k = 0;
    while (N != 0)
    {
        k++;
        N = N / 10;
    }
    return k;
}

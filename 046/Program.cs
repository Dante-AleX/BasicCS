//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

int length = 50;
double[] array = new double[length];
array[0] = 0;
array[1] = 1;
void FA(double[] a)
{
    for (int i = 2; i < a.Length; i++) a[i] = a[i - 1] + a[i - 2];
}
FA(array);
for (int j = 0; j < array.Length; j++)
    if (array[j] == 0 || array[j] == 1)
    {
        Console.Write($"{array[j]} ");
    }
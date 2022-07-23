//В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int Min(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
}

int[]array={10, 95, 35, 84, 51, 19, 15, 13, 42};
int result;
Print(array, "a");

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

int min = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]), 
    Min(array[6], array[7], array[8]));

void Print(int[] array, string variableName)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{variableName}[{i}]={array[i]} ");
}

System.Console.WriteLine();
System.Console.WriteLine($"The maximal number in array is {max}");
System.Console.WriteLine($"The minimal number in array is {min}");
result = max-min;
System.Console.WriteLine($"The difference between maximal and minimal number is {result}");
//Определить, присутствует ли в заданном массиве, некоторое число.

int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

int f=400;
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

//Linear Search
int j=0;
while (j<a.Length && a[j]!=f) j++;

if (j==a.Length) System.Console.WriteLine("\nNot found");
else System.Console.WriteLine($"\nElement {f} finded at {j}");

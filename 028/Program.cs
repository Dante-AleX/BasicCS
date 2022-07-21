//Определить количество цифр в числе. Сделать подпрограмму.

System.Console.WriteLine("Please insert a whole number");
int N=Convert.ToInt32(System.Console.ReadLine());
int k=0;
while (N!=0)
{
    k++;
    N=N/10;
}
System.Console.WriteLine(k);
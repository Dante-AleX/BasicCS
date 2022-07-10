//Дано число. Проверить кратно ли оно 7 и 23.

bool b, c, d;
int x = 7 * 23;
b = true;
b = false;
d = b && c;

b = x % 7 == 0;
c = x % 23 == 0;
System.Console.WriteLine(x);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d);
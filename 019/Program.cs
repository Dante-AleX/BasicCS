//Проверить истинность утверждения ¬(x ⋁ y) = ¬x ⋀ ¬y. 
//!(x || y)==!x && !y.

bool x,y,f1,f2,f;
x=true;
y=true;
f1=!(x || y);
f2=!x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");

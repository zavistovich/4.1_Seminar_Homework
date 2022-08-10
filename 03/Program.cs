// Найти максимальное из трех чисел
Console.Clear();

int a = 7, b = 94, c = 101;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
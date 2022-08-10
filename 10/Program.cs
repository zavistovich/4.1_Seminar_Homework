// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();

int b = 7;
Console.WriteLine($"Will your number be a multiple of the given number {b}?");

Console.Write("Enter your number: ");
int a;
a = int.Parse(Console.ReadLine());

int result = 0;


if (result == a % b) 
{   
    Console.WriteLine($"The number {a} a multiple of the number {b}");
}
else
{
    Console.WriteLine($"The number {a} is not a multiple of the number {b}"); 
    Console.WriteLine($"The remainder of the division is {a % b}");
}
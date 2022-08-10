// Показать числа от -N до N
Console.Clear();

Console.Write("Enter extreme value N: ");
int a = int.Parse(Console.ReadLine());
int b = -a;

while (b <= a)
{
    Console.Write(b + "   "); 
    b++;
}

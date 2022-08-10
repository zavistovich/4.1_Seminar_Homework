// Удалить вторую цифру трёхзначного числа
Console.Clear();

int a = 125;
int b = 0;

b = a / 100 * 10 + a % 10;

Console.WriteLine($"The number {a} without second digit is {b}");
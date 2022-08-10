// Показать вторую цифру трёхзначного числа
Console.Clear();

int number = 125; //new Random().Next(100, 1000);

Console.WriteLine($"The second digit of the number {number} is {number / 10 % 10}");
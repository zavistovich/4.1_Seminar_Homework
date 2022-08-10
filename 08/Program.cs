// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Clear();

int number = new Random().Next(10, 100);
int max = 0;
int a = number / 10;  // First Digit
int b = number % 10;  // Second Digit

if (a > b) 
{
   max = a;
}
else max = b;

Console.WriteLine($"The biggest digit of the number {number} is {max}");
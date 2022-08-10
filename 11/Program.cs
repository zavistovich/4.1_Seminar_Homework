// Найти третью цифру числа или сообщить, что её нет
Console.Clear();

Console.WriteLine("Enter a number: ");
int n;
n = int.Parse(Console.ReadLine());

if (n / 100 > 0)
{
    //Console.WriteLine($"The first digit of number {n} is: {n / 100 % 10} ");   // First digit 
    //Console.WriteLine($"The second digit of number {n} is: {n / 10 % 10} ");   // Second digit 
    Console.WriteLine($"The third digit of the number {n} is: {n % 10} ");    // Third digit
}
else
{   
    Console.WriteLine("It is not a three-digit number. A third digit is missing.");
}
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Input first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

switch (num1 - num2)
{
    case > 0.0 :
        Console.WriteLine($"First number {num1} is more then second number {num2}");
        break;
    case < 0.0 :
        Console.WriteLine($"First number {num1} is less then second number {num2}");
        break;
    default: 
        Console.WriteLine("Numbers are equal");
        break;
}
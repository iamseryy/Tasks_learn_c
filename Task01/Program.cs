// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = 9 -> нет
// a = 9; b = -3 -> да

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"The first number {num1} is a square number of the second number {num2}");
}
else
{
    Console.WriteLine($"The first number {num1} is not a square number of the second number {num2}");
}
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Input first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double max;

if (num1 > num2) 
{
    max = num1;
}
else 
{
    max = num2;
}

if (max <  num3)
{
    max = num3;
}

Console.WriteLine($"The maximum is {max}");
﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Input three-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The last number digit is {num % 10}");
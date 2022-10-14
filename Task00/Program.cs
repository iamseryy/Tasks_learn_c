// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {(num * num)}");
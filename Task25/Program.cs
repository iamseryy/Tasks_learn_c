// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.Write("\nEnter two numbers A and integer B");
double a = GetInputNumber("\nA: ", IsValidNumberA);
int b =  (int) GetInputNumber("B: ", IsValidNumberB);

Console.Write($"\n{a}, {b} -> {MathPow(a, b)}\n"); 



// ************* methods section ***************

double MathPow(double x, int y)
{
    if (y == 0) 
    {
        return 1;
    }
    
    double result = x;

    for (int i = 0; i < Math.Abs(y) - 1; i++)
    {
        result *= x;
    }

    return y > 0 ? result : (1 / result);
}

double GetInputNumber(string inputText, IsValid isValid)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data));

    return Convert.ToDouble(data); 
}

bool IsValidNumberA(string? data)
{
    if (!double.TryParse(data, out double number))
    {
        Console.Write("\nError! It's should be number");
        return false;
    }

    return true;
}

bool IsValidNumberB(string? data)
{
    if (!int.TryParse(data, out int number))
    {
        Console.Write("\nError! It's should be integer number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);
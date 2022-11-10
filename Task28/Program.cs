// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int n = GetInputNumber("\nEnter natural number N: ", IsValidNumber);

Console.Write($"\n{n} -> {MultNumbers(n)}\n"); 


// ************* methods section ***************

int MultNumbers(int number)
{
    int result = 1;

    for(int i = 2; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

int GetInputNumber(string inputText, IsValid isValid)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data));

    return Convert.ToInt32(data); ; 
}

bool IsValidNumber(string? data)
{
    if (!(int.TryParse(data, out int number) && number > 0))
    {
        Console.Write("\nError! It's should be natural number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);

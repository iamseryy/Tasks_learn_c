// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




int n = GetInputNumber("\nEnter natural number N: ", IsValidNumber);

Console.Write($"\n N = {n} -> ");
PrintNaturalNumber(n);



// ************* methods section ***************

void PrintNaturalNumber(int number)
{
    if(number == 0) return;

    Console.Write($"{number}{(number > 1 ? ", " : "")}");
    PrintNaturalNumber(number - 1);
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
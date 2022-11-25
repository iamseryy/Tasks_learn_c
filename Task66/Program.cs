// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int m = GetInputNumber("\nEnter natural number M: ", IsValidNumber);
int n = GetInputNumber("\nEnter natural number N: ", IsValidNumber);

Console.Write($"\n M = {m}; N = {n} -> {SumNaturalNumber(m < n ? m : n, m < n ? n : m)}\n");

// ************* methods section ***************

int SumNaturalNumber(int numberFrom, int numberTo)
{
    if(numberFrom == numberTo) return numberTo;
    return numberFrom + SumNaturalNumber(++numberFrom, numberTo);   
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
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12 




int num = GetInputNumber("\nEnter integer number: ", IsValidNumber);

Console.Write($"\n{num} -> {SumDigits(num)}\n"); 



// ************* methods section ***************

int SumDigits(int number)
{
    int sumDigits = 0;
    number = Math.Abs(number);

    do
    {
        sumDigits = sumDigits + number % 10;
    }
    while ((number /= 10)  > 0);

    return sumDigits;
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

    return Convert.ToInt32(data); 
}

bool IsValidNumber(string? data)
{
    if (!int.TryParse(data, out int number))
    {
        Console.Write("\nError! It's should be integer number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? number);
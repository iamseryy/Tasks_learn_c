// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int num = GetInputNumber("\nEnter integer number: ", IsValidNumber);

Console.Write($"\n{num} -> {CountDigits(num)}\n"); 


// ************* methods section ***************

int CountDigits(int number)
{
    int countDigits = 0;
    number = Math.Abs(number);

    do
    {
        countDigits++;
    }
    while ((number /= 10) > 0);

    return countDigits;
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
    if (!int.TryParse(data, out int number))
    {
        Console.Write("\nError! It's should be integer number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);

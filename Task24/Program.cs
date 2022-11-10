// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int a = GetInputNumber("\nEnter natural number A: ", IsValidNumber);

Console.Write($"\n{a} -> {SumNumbers(a)}\n"); 


// ************* methods section ***************

int SumNumbers(int number)
{
    int result = 1;

    for(int i = 2; i <= number; i++)
    {
        result += i;
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

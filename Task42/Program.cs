// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 20 мин



int numDec = GetInputNumber("\nEnter natural number: ", IsValidNumber);

Console.Write(DecToBin(numDec));


// ************* methods section ***************

int DecToBin(int num)
{
    return num == 0 || num == 1 ? num : DecToBin(num / 2) * 10 + num % 2;
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
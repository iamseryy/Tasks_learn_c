// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да



int number = GetInputNumber("\nEnter five-digit number: ");
Console.Write($"\n{number} -> {(GetReverseNumber(number) == number ? "да" : "нет")}\n");


// ************* methods section ***************
int GetReverseNumber(int sourceNumber)
{
    int reverseNumber = 0;
    int digits = Math.Abs(sourceNumber);

    while (digits % 10 > 0)
    {
        reverseNumber = reverseNumber * 10 + digits % 10;
        digits /= 10;
    }

    return sourceNumber < 0 ? -reverseNumber : reverseNumber;
}


int GetInputNumber(string inputText)
{
    int num;

    while(true)
    {
        Console.Write(inputText);
        num = Convert.ToInt32(Console.ReadLine());
        
        if (IsValid(num)) 
        {
            break;
        }
    }

    return(num);
}



bool IsValid(int num)
{
    if(Math.Abs(num) < 10000 || Math.Abs(num) > 99999)
    {
        Console.Write("\nError! It's should be five-digit number");
        return false;
    }

    return true;
}
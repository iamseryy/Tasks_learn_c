// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int inputNumber = GetInputNumber();

Console.Write($"\n{inputNumber} -> {(ThirdDigitExits(inputNumber) ? $"{GetThirdDigit(inputNumber)}" : $"третьей цифры нет\n")}");


// ************* methods section ***************
int GetInputNumber()
{
    Console.Write("\nВведите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return(num);
}

int GetThirdDigit(int number)
{
    int num = Math.Abs(number);

    while (num > 999)
    {
        num /= 10;
    }
    
    return num % 10;
}

bool ThirdDigitExits(int number)
{
    if (Math.Abs(number) <= 99)
    {
        return false;
    }

    return true;
}
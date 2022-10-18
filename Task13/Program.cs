// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int inputNumber = GetInputNumber();

Console.Write(!ThirdDigitExits(inputNumber) ? $"\n{inputNumber} -> третьей цифры нет\n" : "");


// ************* methods section ***************
int GetInputNumber()
{
    Console.Write("\nВведите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return(num);
}

bool ThirdDigitExits(int number)
{
    int num = Math.Abs(number);

    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }

        Console.WriteLine($"\n{number} -> {num % 10}");

        return true;
    }

    return false;
}
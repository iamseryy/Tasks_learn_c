// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



int inputNumber = GetInputNumber();

Console.WriteLine($"\n{inputNumber} -> {GetSecondDigit(inputNumber)}");


// ************* methods section ***************
int GetInputNumber()
{
    int num;

    while(true)
    {
        Console.Write("\nInput a three digit-number or Ctrl+c for exit: ");
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
    if(num < 100 || num > 999)
    {
        Console.WriteLine("\nError! It's should be three-digit number!");
        return false;
    }

    return true;
}


int GetSecondDigit(int num)
{
    return (num / 10) % 10;
}


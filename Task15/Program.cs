// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



int dayNumber = GetInputNumber();

if (IsValid(dayNumber))
{
    Console.WriteLine($"\n{dayNumber} -> {(IsDayOff(dayNumber) ? "да" : "нет")}");
}



// ************* methods section ***************
int GetInputNumber()
{
    Console.Write("\nВведите цифру: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return(num);
}


bool IsValid(int dayNumberForValidation)
{
    if (dayNumberForValidation < 1 || dayNumberForValidation > 7)
    {
        Console.WriteLine("\nОшибка! Такого дня недели нет!");
        return false;
    }

    return true;
}


bool IsDayOff(int dayNum)
{
    if (dayNum < 6 || dayNum > 7 )
    {
        return false;
    } 

    return true;
}


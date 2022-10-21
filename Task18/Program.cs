// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


int quarterNum = GetInputNumber("\nEnter coordinate plane number: ");

Console.Write($"\nRange of possible coordinates of points in this quarter: {GeRange(quarterNum)}\n");



// ************* methods section ***************

string GeRange(int quarter)
{
    switch (quarter)
    {
        case 1: return "X > 0 and Y > 0";
        case 2: return "X < 0 and Y > 0";    
        case 3: return "X < 0 and Y < 0";
        case 4: return "X > 0 and Y < 0";
    } 
    
    return "";
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
    if(num < 1 || num > 4)
    {
        Console.Write("\nError! It's should be integer number from 1 to 4");
        return false;
    }

    return true;
}